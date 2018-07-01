using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using RpiWiFiOpcUa.Server;
using Opc.Ua;
using Opc.Ua.Configuration;
using Opc.Ua.Server;

namespace NetCoreApp
{
    class Program
    {
        public static bool isWindows = false;
        static void Main(string[] args)
        {
            isWindows = System.Runtime.InteropServices.RuntimeInformation
                                               .IsOSPlatform(OSPlatform.Windows);

            MySampleServer server = new MySampleServer(true, 5000);
            server.Run();
            int exitCode = (int)MySampleServer.ExitCode;

            Console.Write($"Exited with code {exitCode.ToString()}"); Console.ReadLine();
            //Test();
        }

        public class MySampleServer
        {
            RpiWiFiOpcUaServer server;
            Task status;
            DateTime lastEventTime;
            IList<Session> lastSessions = null;
            int serverRunTime = Timeout.Infinite;
            static bool autoAccept = false;
            static ExitCode exitCode;

            public MySampleServer(bool _autoAccept, int _stopTimeout)
            {
                autoAccept = _autoAccept;
                serverRunTime = _stopTimeout == 0 ? Timeout.Infinite : _stopTimeout * 1000;
            }

            public void Run()
            {

                try
                {
                    exitCode = ExitCode.ErrorServerNotStarted;
                    RpiWiFiOpcUaServer().Wait();
                    Console.WriteLine("Server started. Press Ctrl-C to exit...");
                    exitCode = ExitCode.ErrorServerRunning;
                }
                catch (Exception ex)
                {
                    Utils.Trace("ServiceResultException:" + ex.Message);
                    Console.WriteLine("Exception: {0}", ex.Message);
                    exitCode = ExitCode.ErrorServerException;
                    return;
                }

                ManualResetEvent quitEvent = new ManualResetEvent(false);
                try
                {
                    Console.CancelKeyPress += (sender, eArgs) => {
                        quitEvent.Set();
                        eArgs.Cancel = true;
                    };
                }
                catch
                {
                }

                // wait for timeout or Ctrl-C
                quitEvent.WaitOne(serverRunTime);

                if (server != null)
                {
                    Console.WriteLine("Server stopped. Waiting for exit...");

                    using (RpiWiFiOpcUaServer _server = server)
                    {
                        // Stop status thread
                        server = null;
                        status.Wait();
                        // Stop server and dispose
                        _server.Stop();
                    }
                }

                exitCode = ExitCode.Ok;
            }

            public static ExitCode ExitCode { get => exitCode; }

            private static void CertificateValidator_CertificateValidation(CertificateValidator validator, CertificateValidationEventArgs e)
            {
                if (e.Error.StatusCode == StatusCodes.BadCertificateUntrusted)
                {
                    e.Accept = autoAccept;
                    if (autoAccept)
                    {
                        Console.WriteLine("Accepted Certificate: {0}", e.Certificate.Subject);
                    }
                    else
                    {
                        Console.WriteLine("Rejected Certificate: {0}", e.Certificate.Subject);
                    }
                }
            }

            private async Task RpiWiFiOpcUaServer()
            {
                //ApplicationInstance.MessageDlg = new ApplicationMessageDlg();
                ApplicationInstance application = new ApplicationInstance();

                application.ApplicationName = "UA Core Rpi WiFi";
                application.ApplicationType = ApplicationType.Server;
                application.ConfigSectionName = "Opc.Ua.RpiWiFiOpcUa";

                // load the application configuration.
                ApplicationConfiguration config = await application.LoadApplicationConfiguration(false);

                // check the application certificate.
                bool haveAppCertificate = await application.CheckApplicationInstanceCertificate(false, 0);
                if (!haveAppCertificate)
                {
                    throw new Exception("Application instance certificate invalid!");
                }

                if (!config.SecurityConfiguration.AutoAcceptUntrustedCertificates)
                {
                    config.CertificateValidator.CertificateValidation += new CertificateValidationEventHandler(CertificateValidator_CertificateValidation);
                }

                // start the server.
                server = new RpiWiFiOpcUaServer();

                await application.Start(server);

                // start the status thread
                status = Task.Run(new Action(StatusThread));

                // print notification on session events
                server.CurrentInstance.SessionManager.SessionActivated += EventStatus;
                server.CurrentInstance.SessionManager.SessionClosing += EventStatus;
                server.CurrentInstance.SessionManager.SessionCreated += EventStatus;
            }

            private void EventStatus(Session session, SessionEventReason reason)
            {
                lastEventTime = DateTime.UtcNow;
                PrintSessionStatus(session, reason.ToString());
            }

            void PrintSessionStatus(Session session, string reason, bool lastContact = false)
            {
                lock (session.DiagnosticsLock)
                {
                    string item = String.Format("{0,9}:{1,20}:", reason, session.SessionDiagnostics.SessionName);
                    if (lastContact)
                    {
                        item += String.Format("Last Event:{0:HH:mm:ss}", session.SessionDiagnostics.ClientLastContactTime.ToLocalTime());
                    }
                    else
                    {
                        if (session.Identity != null)
                        {
                            item += String.Format(":{0,20}", session.Identity.DisplayName);
                        }
                        item += String.Format(":{0}", session.Id);
                    }
                    Console.WriteLine(item);
                }
            }

            private async void StatusThread()
            {
                while (server != null)
                {
                    if (DateTime.UtcNow - lastEventTime > TimeSpan.FromMilliseconds(6000))
                    {
                        IList<Session> sessions = server.CurrentInstance.SessionManager.GetSessions();
                        if (lastSessions != null && lastSessions.Count != sessions.Count)
                        {
                            for (int ii = 0; ii < sessions.Count; ii++)
                            {
                                Session session = sessions[ii];
                                PrintSessionStatus(session, "-Status-", true);
                            }
                        }
                        lastEventTime = DateTime.UtcNow;
                        lastSessions = sessions;
                    }
                    await Task.Delay(1000);
                }
            }
        }

        public enum ExitCode : int
        {
            Ok = 0,
            ErrorServerNotStarted = 0x80,
            ErrorServerRunning = 0x81,
            ErrorServerException = 0x82,
            ErrorInvalidCommandLine = 0x100
        };

    }
}
