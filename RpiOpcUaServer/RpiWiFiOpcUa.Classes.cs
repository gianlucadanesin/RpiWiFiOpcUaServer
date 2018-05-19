/* ========================================================================
 * Copyright (c) 2005-2016 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace RpiWiFiOpcUa
{
    #region RpiWiFiInterfaceState Class
    #if (!OPCUA_EXCLUDE_RpiWiFiInterfaceState)
    /// <summary>
    /// Stores an instance of the RpiWiFiInterface ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class RpiWiFiInterfaceState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public RpiWiFiInterfaceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(RpiWiFiOpcUa.ObjectTypes.RpiWiFiInterface, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACUAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvUnBpV2lGaU9wY1Vh/////wRggAABAAAAAQAY" +
           "AAAAUnBpV2lGaUludGVyZmFjZUluc3RhbmNlAQGoOgEBqDr/////EQAAABVgiQoCAAAAAQAKAAAAV2lG" +
           "aTFfU1NJRAEBqToALwA/qToAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACgAAAFdpRmkyX1NTSUQB" +
           "Aao6AC8AP6o6AAAADP////8BAf////8AAAAAFWCJCgIAAAABAAoAAABXaUZpM19TU0lEAQGrOgAvAD+r" +
           "OgAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAKAAAAV2lGaTRfU1NJRAEBrDoALwA/rDoAAAAM////" +
           "/wEB/////wAAAAAVYIkKAgAAAAEACgAAAFdpRmk1X1NTSUQBAa06AC8AP606AAAADP////8BAf////8A" +
           "AAAAFWCJCgIAAAABAA4AAABTZWxXaUZpUGFzc2tleQEBrjoALwA/rjoAAAAM/////wMD/////wAAAAAV" +
           "YIkKAgAAAAEADwAAAFdpRmkxX0Nvbm5lY3RlZAEBrzoALwA/rzoAAAAB/////wEB/////wAAAAAVYIkK" +
           "AgAAAAEADwAAAFdpRmkyX0Nvbm5lY3RlZAEBsDoALwA/sDoAAAAB/////wEB/////wAAAAAVYIkKAgAA" +
           "AAEADwAAAFdpRmkzX0Nvbm5lY3RlZAEBsToALwA/sToAAAAB/////wEB/////wAAAAAVYIkKAgAAAAEA" +
           "DwAAAFdpRmk0X0Nvbm5lY3RlZAEBsjoALwA/sjoAAAAB/////wEB/////wAAAAAVYIkKAgAAAAEADwAA" +
           "AFdpRmk1X0Nvbm5lY3RlZAEBszoALwA/szoAAAAB/////wEB/////wAAAAAVYIkKAgAAAAEAEAAAAFdp" +
           "RmkxX0Nvbm5lY3RDbWQBAbQ6AC8AP7Q6AAAAAf////8CAv////8AAAAAFWCJCgIAAAABABAAAABXaUZp" +
           "Ml9Db25uZWN0Q21kAQG1OgAvAD+1OgAAAAH/////AgL/////AAAAABVgiQoCAAAAAQAQAAAAV2lGaTNf" +
           "Q29ubmVjdENtZAEBtjoALwA/tjoAAAAB/////wIC/////wAAAAAVYIkKAgAAAAEAEAAAAFdpRmk0X0Nv" +
           "bm5lY3RDbWQBAbc6AC8AP7c6AAAAAf////8CAv////8AAAAAFWCJCgIAAAABABAAAABXaUZpNV9Db25u" +
           "ZWN0Q21kAQG4OgAvAD+4OgAAAAH/////AgL/////AAAAABVgiQoCAAAAAQASAAAAV2lGaV9EaXNjb25u" +
           "ZWN0Q21kAQELOwAvAD8LOwAAAAH/////AgL/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the WiFi1_SSID Variable.
        /// </summary>
        public BaseDataVariableState<string> WiFi1_SSID
        {
            get
            {
                return m_wiFi1_SSID;
            }

            set
            {
                if (!Object.ReferenceEquals(m_wiFi1_SSID, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_wiFi1_SSID = value;
            }
        }

        /// <summary>
        /// A description for the WiFi2_SSID Variable.
        /// </summary>
        public BaseDataVariableState<string> WiFi2_SSID
        {
            get
            {
                return m_wiFi2_SSID;
            }

            set
            {
                if (!Object.ReferenceEquals(m_wiFi2_SSID, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_wiFi2_SSID = value;
            }
        }

        /// <summary>
        /// A description for the WiFi3_SSID Variable.
        /// </summary>
        public BaseDataVariableState<string> WiFi3_SSID
        {
            get
            {
                return m_wiFi3_SSID;
            }

            set
            {
                if (!Object.ReferenceEquals(m_wiFi3_SSID, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_wiFi3_SSID = value;
            }
        }

        /// <summary>
        /// A description for the WiFi4_SSID Variable.
        /// </summary>
        public BaseDataVariableState<string> WiFi4_SSID
        {
            get
            {
                return m_wiFi4_SSID;
            }

            set
            {
                if (!Object.ReferenceEquals(m_wiFi4_SSID, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_wiFi4_SSID = value;
            }
        }

        /// <summary>
        /// A description for the WiFi5_SSID Variable.
        /// </summary>
        public BaseDataVariableState<string> WiFi5_SSID
        {
            get
            {
                return m_wiFi5_SSID;
            }

            set
            {
                if (!Object.ReferenceEquals(m_wiFi5_SSID, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_wiFi5_SSID = value;
            }
        }

        /// <summary>
        /// A description for the SelWiFiPasskey Variable.
        /// </summary>
        public BaseDataVariableState<string> SelWiFiPasskey
        {
            get
            {
                return m_selWiFiPasskey;
            }

            set
            {
                if (!Object.ReferenceEquals(m_selWiFiPasskey, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_selWiFiPasskey = value;
            }
        }

        /// <summary>
        /// A description for the WiFi1_Connected Variable.
        /// </summary>
        public BaseDataVariableState<bool> WiFi1_Connected
        {
            get
            {
                return m_wiFi1_Connected;
            }

            set
            {
                if (!Object.ReferenceEquals(m_wiFi1_Connected, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_wiFi1_Connected = value;
            }
        }

        /// <summary>
        /// A description for the WiFi2_Connected Variable.
        /// </summary>
        public BaseDataVariableState<bool> WiFi2_Connected
        {
            get
            {
                return m_wiFi2_Connected;
            }

            set
            {
                if (!Object.ReferenceEquals(m_wiFi2_Connected, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_wiFi2_Connected = value;
            }
        }

        /// <summary>
        /// A description for the WiFi3_Connected Variable.
        /// </summary>
        public BaseDataVariableState<bool> WiFi3_Connected
        {
            get
            {
                return m_wiFi3_Connected;
            }

            set
            {
                if (!Object.ReferenceEquals(m_wiFi3_Connected, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_wiFi3_Connected = value;
            }
        }

        /// <summary>
        /// A description for the WiFi4_Connected Variable.
        /// </summary>
        public BaseDataVariableState<bool> WiFi4_Connected
        {
            get
            {
                return m_wiFi4_Connected;
            }

            set
            {
                if (!Object.ReferenceEquals(m_wiFi4_Connected, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_wiFi4_Connected = value;
            }
        }

        /// <summary>
        /// A description for the WiFi5_Connected Variable.
        /// </summary>
        public BaseDataVariableState<bool> WiFi5_Connected
        {
            get
            {
                return m_wiFi5_Connected;
            }

            set
            {
                if (!Object.ReferenceEquals(m_wiFi5_Connected, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_wiFi5_Connected = value;
            }
        }

        /// <summary>
        /// A description for the WiFi1_ConnectCmd Variable.
        /// </summary>
        public BaseDataVariableState<bool> WiFi1_ConnectCmd
        {
            get
            {
                return m_wiFi1_ConnectCmd;
            }

            set
            {
                if (!Object.ReferenceEquals(m_wiFi1_ConnectCmd, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_wiFi1_ConnectCmd = value;
            }
        }

        /// <summary>
        /// A description for the WiFi2_ConnectCmd Variable.
        /// </summary>
        public BaseDataVariableState<bool> WiFi2_ConnectCmd
        {
            get
            {
                return m_wiFi2_ConnectCmd;
            }

            set
            {
                if (!Object.ReferenceEquals(m_wiFi2_ConnectCmd, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_wiFi2_ConnectCmd = value;
            }
        }

        /// <summary>
        /// A description for the WiFi3_ConnectCmd Variable.
        /// </summary>
        public BaseDataVariableState<bool> WiFi3_ConnectCmd
        {
            get
            {
                return m_wiFi3_ConnectCmd;
            }

            set
            {
                if (!Object.ReferenceEquals(m_wiFi3_ConnectCmd, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_wiFi3_ConnectCmd = value;
            }
        }

        /// <summary>
        /// A description for the WiFi4_ConnectCmd Variable.
        /// </summary>
        public BaseDataVariableState<bool> WiFi4_ConnectCmd
        {
            get
            {
                return m_wiFi4_ConnectCmd;
            }

            set
            {
                if (!Object.ReferenceEquals(m_wiFi4_ConnectCmd, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_wiFi4_ConnectCmd = value;
            }
        }

        /// <summary>
        /// A description for the WiFi5_ConnectCmd Variable.
        /// </summary>
        public BaseDataVariableState<bool> WiFi5_ConnectCmd
        {
            get
            {
                return m_wiFi5_ConnectCmd;
            }

            set
            {
                if (!Object.ReferenceEquals(m_wiFi5_ConnectCmd, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_wiFi5_ConnectCmd = value;
            }
        }

        /// <summary>
        /// A description for the WiFi_DisconnectCmd Variable.
        /// </summary>
        public BaseDataVariableState<bool> WiFi_DisconnectCmd
        {
            get
            {
                return m_wiFi_DisconnectCmd;
            }

            set
            {
                if (!Object.ReferenceEquals(m_wiFi_DisconnectCmd, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_wiFi_DisconnectCmd = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_wiFi1_SSID != null)
            {
                children.Add(m_wiFi1_SSID);
            }

            if (m_wiFi2_SSID != null)
            {
                children.Add(m_wiFi2_SSID);
            }

            if (m_wiFi3_SSID != null)
            {
                children.Add(m_wiFi3_SSID);
            }

            if (m_wiFi4_SSID != null)
            {
                children.Add(m_wiFi4_SSID);
            }

            if (m_wiFi5_SSID != null)
            {
                children.Add(m_wiFi5_SSID);
            }

            if (m_selWiFiPasskey != null)
            {
                children.Add(m_selWiFiPasskey);
            }

            if (m_wiFi1_Connected != null)
            {
                children.Add(m_wiFi1_Connected);
            }

            if (m_wiFi2_Connected != null)
            {
                children.Add(m_wiFi2_Connected);
            }

            if (m_wiFi3_Connected != null)
            {
                children.Add(m_wiFi3_Connected);
            }

            if (m_wiFi4_Connected != null)
            {
                children.Add(m_wiFi4_Connected);
            }

            if (m_wiFi5_Connected != null)
            {
                children.Add(m_wiFi5_Connected);
            }

            if (m_wiFi1_ConnectCmd != null)
            {
                children.Add(m_wiFi1_ConnectCmd);
            }

            if (m_wiFi2_ConnectCmd != null)
            {
                children.Add(m_wiFi2_ConnectCmd);
            }

            if (m_wiFi3_ConnectCmd != null)
            {
                children.Add(m_wiFi3_ConnectCmd);
            }

            if (m_wiFi4_ConnectCmd != null)
            {
                children.Add(m_wiFi4_ConnectCmd);
            }

            if (m_wiFi5_ConnectCmd != null)
            {
                children.Add(m_wiFi5_ConnectCmd);
            }

            if (m_wiFi_DisconnectCmd != null)
            {
                children.Add(m_wiFi_DisconnectCmd);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case RpiWiFiOpcUa.BrowseNames.WiFi1_SSID:
                {
                    if (createOrReplace)
                    {
                        if (WiFi1_SSID == null)
                        {
                            if (replacement == null)
                            {
                                WiFi1_SSID = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                WiFi1_SSID = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = WiFi1_SSID;
                    break;
                }

                case RpiWiFiOpcUa.BrowseNames.WiFi2_SSID:
                {
                    if (createOrReplace)
                    {
                        if (WiFi2_SSID == null)
                        {
                            if (replacement == null)
                            {
                                WiFi2_SSID = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                WiFi2_SSID = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = WiFi2_SSID;
                    break;
                }

                case RpiWiFiOpcUa.BrowseNames.WiFi3_SSID:
                {
                    if (createOrReplace)
                    {
                        if (WiFi3_SSID == null)
                        {
                            if (replacement == null)
                            {
                                WiFi3_SSID = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                WiFi3_SSID = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = WiFi3_SSID;
                    break;
                }

                case RpiWiFiOpcUa.BrowseNames.WiFi4_SSID:
                {
                    if (createOrReplace)
                    {
                        if (WiFi4_SSID == null)
                        {
                            if (replacement == null)
                            {
                                WiFi4_SSID = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                WiFi4_SSID = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = WiFi4_SSID;
                    break;
                }

                case RpiWiFiOpcUa.BrowseNames.WiFi5_SSID:
                {
                    if (createOrReplace)
                    {
                        if (WiFi5_SSID == null)
                        {
                            if (replacement == null)
                            {
                                WiFi5_SSID = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                WiFi5_SSID = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = WiFi5_SSID;
                    break;
                }

                case RpiWiFiOpcUa.BrowseNames.SelWiFiPasskey:
                {
                    if (createOrReplace)
                    {
                        if (SelWiFiPasskey == null)
                        {
                            if (replacement == null)
                            {
                                SelWiFiPasskey = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                SelWiFiPasskey = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = SelWiFiPasskey;
                    break;
                }

                case RpiWiFiOpcUa.BrowseNames.WiFi1_Connected:
                {
                    if (createOrReplace)
                    {
                        if (WiFi1_Connected == null)
                        {
                            if (replacement == null)
                            {
                                WiFi1_Connected = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                WiFi1_Connected = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = WiFi1_Connected;
                    break;
                }

                case RpiWiFiOpcUa.BrowseNames.WiFi2_Connected:
                {
                    if (createOrReplace)
                    {
                        if (WiFi2_Connected == null)
                        {
                            if (replacement == null)
                            {
                                WiFi2_Connected = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                WiFi2_Connected = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = WiFi2_Connected;
                    break;
                }

                case RpiWiFiOpcUa.BrowseNames.WiFi3_Connected:
                {
                    if (createOrReplace)
                    {
                        if (WiFi3_Connected == null)
                        {
                            if (replacement == null)
                            {
                                WiFi3_Connected = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                WiFi3_Connected = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = WiFi3_Connected;
                    break;
                }

                case RpiWiFiOpcUa.BrowseNames.WiFi4_Connected:
                {
                    if (createOrReplace)
                    {
                        if (WiFi4_Connected == null)
                        {
                            if (replacement == null)
                            {
                                WiFi4_Connected = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                WiFi4_Connected = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = WiFi4_Connected;
                    break;
                }

                case RpiWiFiOpcUa.BrowseNames.WiFi5_Connected:
                {
                    if (createOrReplace)
                    {
                        if (WiFi5_Connected == null)
                        {
                            if (replacement == null)
                            {
                                WiFi5_Connected = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                WiFi5_Connected = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = WiFi5_Connected;
                    break;
                }

                case RpiWiFiOpcUa.BrowseNames.WiFi1_ConnectCmd:
                {
                    if (createOrReplace)
                    {
                        if (WiFi1_ConnectCmd == null)
                        {
                            if (replacement == null)
                            {
                                WiFi1_ConnectCmd = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                WiFi1_ConnectCmd = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = WiFi1_ConnectCmd;
                    break;
                }

                case RpiWiFiOpcUa.BrowseNames.WiFi2_ConnectCmd:
                {
                    if (createOrReplace)
                    {
                        if (WiFi2_ConnectCmd == null)
                        {
                            if (replacement == null)
                            {
                                WiFi2_ConnectCmd = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                WiFi2_ConnectCmd = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = WiFi2_ConnectCmd;
                    break;
                }

                case RpiWiFiOpcUa.BrowseNames.WiFi3_ConnectCmd:
                {
                    if (createOrReplace)
                    {
                        if (WiFi3_ConnectCmd == null)
                        {
                            if (replacement == null)
                            {
                                WiFi3_ConnectCmd = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                WiFi3_ConnectCmd = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = WiFi3_ConnectCmd;
                    break;
                }

                case RpiWiFiOpcUa.BrowseNames.WiFi4_ConnectCmd:
                {
                    if (createOrReplace)
                    {
                        if (WiFi4_ConnectCmd == null)
                        {
                            if (replacement == null)
                            {
                                WiFi4_ConnectCmd = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                WiFi4_ConnectCmd = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = WiFi4_ConnectCmd;
                    break;
                }

                case RpiWiFiOpcUa.BrowseNames.WiFi5_ConnectCmd:
                {
                    if (createOrReplace)
                    {
                        if (WiFi5_ConnectCmd == null)
                        {
                            if (replacement == null)
                            {
                                WiFi5_ConnectCmd = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                WiFi5_ConnectCmd = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = WiFi5_ConnectCmd;
                    break;
                }

                case RpiWiFiOpcUa.BrowseNames.WiFi_DisconnectCmd:
                {
                    if (createOrReplace)
                    {
                        if (WiFi_DisconnectCmd == null)
                        {
                            if (replacement == null)
                            {
                                WiFi_DisconnectCmd = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                WiFi_DisconnectCmd = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = WiFi_DisconnectCmd;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<string> m_wiFi1_SSID;
        private BaseDataVariableState<string> m_wiFi2_SSID;
        private BaseDataVariableState<string> m_wiFi3_SSID;
        private BaseDataVariableState<string> m_wiFi4_SSID;
        private BaseDataVariableState<string> m_wiFi5_SSID;
        private BaseDataVariableState<string> m_selWiFiPasskey;
        private BaseDataVariableState<bool> m_wiFi1_Connected;
        private BaseDataVariableState<bool> m_wiFi2_Connected;
        private BaseDataVariableState<bool> m_wiFi3_Connected;
        private BaseDataVariableState<bool> m_wiFi4_Connected;
        private BaseDataVariableState<bool> m_wiFi5_Connected;
        private BaseDataVariableState<bool> m_wiFi1_ConnectCmd;
        private BaseDataVariableState<bool> m_wiFi2_ConnectCmd;
        private BaseDataVariableState<bool> m_wiFi3_ConnectCmd;
        private BaseDataVariableState<bool> m_wiFi4_ConnectCmd;
        private BaseDataVariableState<bool> m_wiFi5_ConnectCmd;
        private BaseDataVariableState<bool> m_wiFi_DisconnectCmd;
        #endregion
    }
    #endif
    #endregion

    #region RpiFolderState Class
    #if (!OPCUA_EXCLUDE_RpiFolderState)
    /// <summary>
    /// Stores an instance of the RpiFolder ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class RpiFolderState : FolderState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public RpiFolderState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(RpiWiFiOpcUa.ObjectTypes.RpiFolder, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACUAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvUnBpV2lGaU9wY1Vh/////wRggAABAAAAAQAR" +
           "AAAAUnBpRm9sZGVySW5zdGFuY2UBAd06AQHdOv////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region RpiState Class
    #if (!OPCUA_EXCLUDE_RpiState)
    /// <summary>
    /// Stores an instance of the RpiType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class RpiState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public RpiState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(RpiWiFiOpcUa.ObjectTypes.RpiType, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACUAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvUnBpV2lGaU9wY1Vh/////4RggAABAAAAAQAP" +
           "AAAAUnBpVHlwZUluc3RhbmNlAQG5OgEBuToB/////wEAAACEYMAKAQAAAAQAAABXaUZpAQAHAAAAUnBp" +
           "V2lGaQEBujoALwEBqDq6OgAAAf////8RAAAAFWCJCgIAAAABAAoAAABXaUZpMV9TU0lEAQG7OgAvAD+7" +
           "OgAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAKAAAAV2lGaTJfU1NJRAEBvDoALwA/vDoAAAAM////" +
           "/wEB/////wAAAAAVYIkKAgAAAAEACgAAAFdpRmkzX1NTSUQBAb06AC8AP706AAAADP////8BAf////8A" +
           "AAAAFWCJCgIAAAABAAoAAABXaUZpNF9TU0lEAQG+OgAvAD++OgAAAAz/////AQH/////AAAAABVgiQoC" +
           "AAAAAQAKAAAAV2lGaTVfU1NJRAEBvzoALwA/vzoAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEADgAA" +
           "AFNlbFdpRmlQYXNza2V5AQHAOgAvAD/AOgAAAAz/////AwP/////AAAAABVgiQoCAAAAAQAPAAAAV2lG" +
           "aTFfQ29ubmVjdGVkAQHBOgAvAD/BOgAAAAH/////AQH/////AAAAABVgiQoCAAAAAQAPAAAAV2lGaTJf" +
           "Q29ubmVjdGVkAQHCOgAvAD/COgAAAAH/////AQH/////AAAAABVgiQoCAAAAAQAPAAAAV2lGaTNfQ29u" +
           "bmVjdGVkAQHDOgAvAD/DOgAAAAH/////AQH/////AAAAABVgiQoCAAAAAQAPAAAAV2lGaTRfQ29ubmVj" +
           "dGVkAQHEOgAvAD/EOgAAAAH/////AQH/////AAAAABVgiQoCAAAAAQAPAAAAV2lGaTVfQ29ubmVjdGVk" +
           "AQHFOgAvAD/FOgAAAAH/////AQH/////AAAAABVgiQoCAAAAAQAQAAAAV2lGaTFfQ29ubmVjdENtZAEB" +
           "xjoALwA/xjoAAAAB/////wIC/////wAAAAAVYIkKAgAAAAEAEAAAAFdpRmkyX0Nvbm5lY3RDbWQBAcc6" +
           "AC8AP8c6AAAAAf////8CAv////8AAAAAFWCJCgIAAAABABAAAABXaUZpM19Db25uZWN0Q21kAQHIOgAv" +
           "AD/IOgAAAAH/////AgL/////AAAAABVgiQoCAAAAAQAQAAAAV2lGaTRfQ29ubmVjdENtZAEByToALwA/" +
           "yToAAAAB/////wIC/////wAAAAAVYIkKAgAAAAEAEAAAAFdpRmk1X0Nvbm5lY3RDbWQBAco6AC8AP8o6" +
           "AAAAAf////8CAv////8AAAAAFWCJCgIAAAABABIAAABXaUZpX0Rpc2Nvbm5lY3RDbWQBAQw7AC8APww7" +
           "AAAAAf////8CAv////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <summary>
        /// A description for the RpiWiFi Object.
        /// </summary>
        public RpiWiFiInterfaceState WiFi
        {
            get
            {
                return m_wiFi;
            }

            set
            {
                if (!Object.ReferenceEquals(m_wiFi, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_wiFi = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_wiFi != null)
            {
                children.Add(m_wiFi);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case RpiWiFiOpcUa.BrowseNames.WiFi:
                {
                    if (createOrReplace)
                    {
                        if (WiFi == null)
                        {
                            if (replacement == null)
                            {
                                WiFi = new RpiWiFiInterfaceState(this);
                            }
                            else
                            {
                                WiFi = (RpiWiFiInterfaceState)replacement;
                            }
                        }
                    }

                    instance = WiFi;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private RpiWiFiInterfaceState m_wiFi;
        #endregion
    }
    #endif
    #endregion
}