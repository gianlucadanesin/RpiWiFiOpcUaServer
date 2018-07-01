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
           "AAAAUnBpV2lGaUludGVyZmFjZUluc3RhbmNlAQGoOgEBqDr/////IAAAABVgiQoCAAAAAQAKAAAAV2lG" +
           "aTFfU1NJRAEBqToALwA/qToAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACgAAAFdpRmkyX1NTSUQB" +
           "Aao6AC8AP6o6AAAADP////8BAf////8AAAAAFWCJCgIAAAABAAoAAABXaUZpM19TU0lEAQGrOgAvAD+r" +
           "OgAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAKAAAAV2lGaTRfU1NJRAEBrDoALwA/rDoAAAAM////" +
           "/wEB/////wAAAAAVYIkKAgAAAAEACgAAAFdpRmk1X1NTSUQBAa06AC8AP606AAAADP////8BAf////8A" +
           "AAAAFWCJCgIAAAABAAoAAABXaUZpNl9TU0lEAQGZOgAvAD+ZOgAAAAz/////AQH/////AAAAABVgiQoC" +
           "AAAAAQAKAAAAV2lGaTdfU1NJRAEBmjoALwA/mjoAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACgAA" +
           "AFdpRmk4X1NTSUQBAZs6AC8AP5s6AAAADP////8BAf////8AAAAAFWCJCgIAAAABAAoAAABXaUZpOV9T" +
           "U0lEAQGcOgAvAD+cOgAAAAz/////AQH/////AAAAABVgiQoCAAAAAQALAAAAV2lGaTEwX1NTSUQBAZ06" +
           "AC8AP506AAAADP////8BAf////8AAAAAFWCJCgIAAAABAA4AAABTZWxXaUZpUGFzc2tleQEBrjoALwA/" +
           "rjoAAAAM/////wMD/////wAAAAAVYIkKAgAAAAEADwAAAFdpRmkxX0Nvbm5lY3RlZAEBrzoALwA/rzoA" +
           "AAAB/////wEB/////wAAAAAVYIkKAgAAAAEADwAAAFdpRmkyX0Nvbm5lY3RlZAEBsDoALwA/sDoAAAAB" +
           "/////wEB/////wAAAAAVYIkKAgAAAAEADwAAAFdpRmkzX0Nvbm5lY3RlZAEBsToALwA/sToAAAAB////" +
           "/wEB/////wAAAAAVYIkKAgAAAAEADwAAAFdpRmk0X0Nvbm5lY3RlZAEBsjoALwA/sjoAAAAB/////wEB" +
           "/////wAAAAAVYIkKAgAAAAEADwAAAFdpRmk1X0Nvbm5lY3RlZAEBszoALwA/szoAAAAB/////wEB////" +
           "/wAAAAAVYIkKAgAAAAEADwAAAFdpRmk2X0Nvbm5lY3RlZAEBnjoALwA/njoAAAAB/////wEB/////wAA" +
           "AAAVYIkKAgAAAAEADwAAAFdpRmk3X0Nvbm5lY3RlZAEBnzoALwA/nzoAAAAB/////wEB/////wAAAAAV" +
           "YIkKAgAAAAEADwAAAFdpRmk4X0Nvbm5lY3RlZAEBoDoALwA/oDoAAAAB/////wEB/////wAAAAAVYIkK" +
           "AgAAAAEADwAAAFdpRmk5X0Nvbm5lY3RlZAEBoToALwA/oToAAAAB/////wEB/////wAAAAAVYIkKAgAA" +
           "AAEAEAAAAFdpRmkxMF9Db25uZWN0ZWQBAaI6AC8AP6I6AAAAAf////8BAf////8AAAAAFWCJCgIAAAAB" +
           "ABAAAABXaUZpMV9Db25uZWN0Q21kAQG0OgAvAD+0OgAAAAH/////AgL/////AAAAABVgiQoCAAAAAQAQ" +
           "AAAAV2lGaTJfQ29ubmVjdENtZAEBtToALwA/tToAAAAB/////wIC/////wAAAAAVYIkKAgAAAAEAEAAA" +
           "AFdpRmkzX0Nvbm5lY3RDbWQBAbY6AC8AP7Y6AAAAAf////8CAv////8AAAAAFWCJCgIAAAABABAAAABX" +
           "aUZpNF9Db25uZWN0Q21kAQG3OgAvAD+3OgAAAAH/////AgL/////AAAAABVgiQoCAAAAAQAQAAAAV2lG" +
           "aTVfQ29ubmVjdENtZAEBuDoALwA/uDoAAAAB/////wIC/////wAAAAAVYIkKAgAAAAEAEAAAAFdpRmk2" +
           "X0Nvbm5lY3RDbWQBAaM6AC8AP6M6AAAAAf////8CAv////8AAAAAFWCJCgIAAAABABAAAABXaUZpN19D" +
           "b25uZWN0Q21kAQGkOgAvAD+kOgAAAAH/////AgL/////AAAAABVgiQoCAAAAAQAQAAAAV2lGaThfQ29u" +
           "bmVjdENtZAEBpToALwA/pToAAAAB/////wIC/////wAAAAAVYIkKAgAAAAEAEAAAAFdpRmk5X0Nvbm5l" +
           "Y3RDbWQBAaY6AC8AP6Y6AAAAAf////8CAv////8AAAAAFWCJCgIAAAABABEAAABXaUZpMTBfQ29ubmVj" +
           "dENtZAEBpzoALwA/pzoAAAAB/////wIC/////wAAAAAVYIkKAgAAAAEAEgAAAFdpRmlfRGlzY29ubmVj" +
           "dENtZAEBCzsALwA/CzsAAAAB/////wIC/////wAAAAA=";
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
        /// A description for the WiFi6_SSID Variable.
        /// </summary>
        public BaseDataVariableState<string> WiFi6_SSID
        {
            get
            {
                return m_wiFi6_SSID;
            }

            set
            {
                if (!Object.ReferenceEquals(m_wiFi6_SSID, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_wiFi6_SSID = value;
            }
        }

        /// <summary>
        /// A description for the WiFi7_SSID Variable.
        /// </summary>
        public BaseDataVariableState<string> WiFi7_SSID
        {
            get
            {
                return m_wiFi7_SSID;
            }

            set
            {
                if (!Object.ReferenceEquals(m_wiFi7_SSID, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_wiFi7_SSID = value;
            }
        }

        /// <summary>
        /// A description for the WiFi8_SSID Variable.
        /// </summary>
        public BaseDataVariableState<string> WiFi8_SSID
        {
            get
            {
                return m_wiFi8_SSID;
            }

            set
            {
                if (!Object.ReferenceEquals(m_wiFi8_SSID, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_wiFi8_SSID = value;
            }
        }

        /// <summary>
        /// A description for the WiFi9_SSID Variable.
        /// </summary>
        public BaseDataVariableState<string> WiFi9_SSID
        {
            get
            {
                return m_wiFi9_SSID;
            }

            set
            {
                if (!Object.ReferenceEquals(m_wiFi9_SSID, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_wiFi9_SSID = value;
            }
        }

        /// <summary>
        /// A description for the WiFi10_SSID Variable.
        /// </summary>
        public BaseDataVariableState<string> WiFi10_SSID
        {
            get
            {
                return m_wiFi10_SSID;
            }

            set
            {
                if (!Object.ReferenceEquals(m_wiFi10_SSID, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_wiFi10_SSID = value;
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
        /// A description for the WiFi6_Connected Variable.
        /// </summary>
        public BaseDataVariableState<bool> WiFi6_Connected
        {
            get
            {
                return m_wiFi6_Connected;
            }

            set
            {
                if (!Object.ReferenceEquals(m_wiFi6_Connected, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_wiFi6_Connected = value;
            }
        }

        /// <summary>
        /// A description for the WiFi7_Connected Variable.
        /// </summary>
        public BaseDataVariableState<bool> WiFi7_Connected
        {
            get
            {
                return m_wiFi7_Connected;
            }

            set
            {
                if (!Object.ReferenceEquals(m_wiFi7_Connected, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_wiFi7_Connected = value;
            }
        }

        /// <summary>
        /// A description for the WiFi8_Connected Variable.
        /// </summary>
        public BaseDataVariableState<bool> WiFi8_Connected
        {
            get
            {
                return m_wiFi8_Connected;
            }

            set
            {
                if (!Object.ReferenceEquals(m_wiFi8_Connected, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_wiFi8_Connected = value;
            }
        }

        /// <summary>
        /// A description for the WiFi9_Connected Variable.
        /// </summary>
        public BaseDataVariableState<bool> WiFi9_Connected
        {
            get
            {
                return m_wiFi9_Connected;
            }

            set
            {
                if (!Object.ReferenceEquals(m_wiFi9_Connected, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_wiFi9_Connected = value;
            }
        }

        /// <summary>
        /// A description for the WiFi10_Connected Variable.
        /// </summary>
        public BaseDataVariableState<bool> WiFi10_Connected
        {
            get
            {
                return m_wiFi10_Connected;
            }

            set
            {
                if (!Object.ReferenceEquals(m_wiFi10_Connected, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_wiFi10_Connected = value;
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
        /// A description for the WiFi6_ConnectCmd Variable.
        /// </summary>
        public BaseDataVariableState<bool> WiFi6_ConnectCmd
        {
            get
            {
                return m_wiFi6_ConnectCmd;
            }

            set
            {
                if (!Object.ReferenceEquals(m_wiFi6_ConnectCmd, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_wiFi6_ConnectCmd = value;
            }
        }

        /// <summary>
        /// A description for the WiFi7_ConnectCmd Variable.
        /// </summary>
        public BaseDataVariableState<bool> WiFi7_ConnectCmd
        {
            get
            {
                return m_wiFi7_ConnectCmd;
            }

            set
            {
                if (!Object.ReferenceEquals(m_wiFi7_ConnectCmd, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_wiFi7_ConnectCmd = value;
            }
        }

        /// <summary>
        /// A description for the WiFi8_ConnectCmd Variable.
        /// </summary>
        public BaseDataVariableState<bool> WiFi8_ConnectCmd
        {
            get
            {
                return m_wiFi8_ConnectCmd;
            }

            set
            {
                if (!Object.ReferenceEquals(m_wiFi8_ConnectCmd, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_wiFi8_ConnectCmd = value;
            }
        }

        /// <summary>
        /// A description for the WiFi9_ConnectCmd Variable.
        /// </summary>
        public BaseDataVariableState<bool> WiFi9_ConnectCmd
        {
            get
            {
                return m_wiFi9_ConnectCmd;
            }

            set
            {
                if (!Object.ReferenceEquals(m_wiFi9_ConnectCmd, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_wiFi9_ConnectCmd = value;
            }
        }

        /// <summary>
        /// A description for the WiFi10_ConnectCmd Variable.
        /// </summary>
        public BaseDataVariableState<bool> WiFi10_ConnectCmd
        {
            get
            {
                return m_wiFi10_ConnectCmd;
            }

            set
            {
                if (!Object.ReferenceEquals(m_wiFi10_ConnectCmd, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_wiFi10_ConnectCmd = value;
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

            if (m_wiFi6_SSID != null)
            {
                children.Add(m_wiFi6_SSID);
            }

            if (m_wiFi7_SSID != null)
            {
                children.Add(m_wiFi7_SSID);
            }

            if (m_wiFi8_SSID != null)
            {
                children.Add(m_wiFi8_SSID);
            }

            if (m_wiFi9_SSID != null)
            {
                children.Add(m_wiFi9_SSID);
            }

            if (m_wiFi10_SSID != null)
            {
                children.Add(m_wiFi10_SSID);
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

            if (m_wiFi6_Connected != null)
            {
                children.Add(m_wiFi6_Connected);
            }

            if (m_wiFi7_Connected != null)
            {
                children.Add(m_wiFi7_Connected);
            }

            if (m_wiFi8_Connected != null)
            {
                children.Add(m_wiFi8_Connected);
            }

            if (m_wiFi9_Connected != null)
            {
                children.Add(m_wiFi9_Connected);
            }

            if (m_wiFi10_Connected != null)
            {
                children.Add(m_wiFi10_Connected);
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

            if (m_wiFi6_ConnectCmd != null)
            {
                children.Add(m_wiFi6_ConnectCmd);
            }

            if (m_wiFi7_ConnectCmd != null)
            {
                children.Add(m_wiFi7_ConnectCmd);
            }

            if (m_wiFi8_ConnectCmd != null)
            {
                children.Add(m_wiFi8_ConnectCmd);
            }

            if (m_wiFi9_ConnectCmd != null)
            {
                children.Add(m_wiFi9_ConnectCmd);
            }

            if (m_wiFi10_ConnectCmd != null)
            {
                children.Add(m_wiFi10_ConnectCmd);
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

                case RpiWiFiOpcUa.BrowseNames.WiFi6_SSID:
                {
                    if (createOrReplace)
                    {
                        if (WiFi6_SSID == null)
                        {
                            if (replacement == null)
                            {
                                WiFi6_SSID = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                WiFi6_SSID = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = WiFi6_SSID;
                    break;
                }

                case RpiWiFiOpcUa.BrowseNames.WiFi7_SSID:
                {
                    if (createOrReplace)
                    {
                        if (WiFi7_SSID == null)
                        {
                            if (replacement == null)
                            {
                                WiFi7_SSID = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                WiFi7_SSID = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = WiFi7_SSID;
                    break;
                }

                case RpiWiFiOpcUa.BrowseNames.WiFi8_SSID:
                {
                    if (createOrReplace)
                    {
                        if (WiFi8_SSID == null)
                        {
                            if (replacement == null)
                            {
                                WiFi8_SSID = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                WiFi8_SSID = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = WiFi8_SSID;
                    break;
                }

                case RpiWiFiOpcUa.BrowseNames.WiFi9_SSID:
                {
                    if (createOrReplace)
                    {
                        if (WiFi9_SSID == null)
                        {
                            if (replacement == null)
                            {
                                WiFi9_SSID = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                WiFi9_SSID = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = WiFi9_SSID;
                    break;
                }

                case RpiWiFiOpcUa.BrowseNames.WiFi10_SSID:
                {
                    if (createOrReplace)
                    {
                        if (WiFi10_SSID == null)
                        {
                            if (replacement == null)
                            {
                                WiFi10_SSID = new BaseDataVariableState<string>(this);
                            }
                            else
                            {
                                WiFi10_SSID = (BaseDataVariableState<string>)replacement;
                            }
                        }
                    }

                    instance = WiFi10_SSID;
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

                case RpiWiFiOpcUa.BrowseNames.WiFi6_Connected:
                {
                    if (createOrReplace)
                    {
                        if (WiFi6_Connected == null)
                        {
                            if (replacement == null)
                            {
                                WiFi6_Connected = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                WiFi6_Connected = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = WiFi6_Connected;
                    break;
                }

                case RpiWiFiOpcUa.BrowseNames.WiFi7_Connected:
                {
                    if (createOrReplace)
                    {
                        if (WiFi7_Connected == null)
                        {
                            if (replacement == null)
                            {
                                WiFi7_Connected = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                WiFi7_Connected = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = WiFi7_Connected;
                    break;
                }

                case RpiWiFiOpcUa.BrowseNames.WiFi8_Connected:
                {
                    if (createOrReplace)
                    {
                        if (WiFi8_Connected == null)
                        {
                            if (replacement == null)
                            {
                                WiFi8_Connected = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                WiFi8_Connected = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = WiFi8_Connected;
                    break;
                }

                case RpiWiFiOpcUa.BrowseNames.WiFi9_Connected:
                {
                    if (createOrReplace)
                    {
                        if (WiFi9_Connected == null)
                        {
                            if (replacement == null)
                            {
                                WiFi9_Connected = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                WiFi9_Connected = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = WiFi9_Connected;
                    break;
                }

                case RpiWiFiOpcUa.BrowseNames.WiFi10_Connected:
                {
                    if (createOrReplace)
                    {
                        if (WiFi10_Connected == null)
                        {
                            if (replacement == null)
                            {
                                WiFi10_Connected = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                WiFi10_Connected = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = WiFi10_Connected;
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

                case RpiWiFiOpcUa.BrowseNames.WiFi6_ConnectCmd:
                {
                    if (createOrReplace)
                    {
                        if (WiFi6_ConnectCmd == null)
                        {
                            if (replacement == null)
                            {
                                WiFi6_ConnectCmd = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                WiFi6_ConnectCmd = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = WiFi6_ConnectCmd;
                    break;
                }

                case RpiWiFiOpcUa.BrowseNames.WiFi7_ConnectCmd:
                {
                    if (createOrReplace)
                    {
                        if (WiFi7_ConnectCmd == null)
                        {
                            if (replacement == null)
                            {
                                WiFi7_ConnectCmd = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                WiFi7_ConnectCmd = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = WiFi7_ConnectCmd;
                    break;
                }

                case RpiWiFiOpcUa.BrowseNames.WiFi8_ConnectCmd:
                {
                    if (createOrReplace)
                    {
                        if (WiFi8_ConnectCmd == null)
                        {
                            if (replacement == null)
                            {
                                WiFi8_ConnectCmd = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                WiFi8_ConnectCmd = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = WiFi8_ConnectCmd;
                    break;
                }

                case RpiWiFiOpcUa.BrowseNames.WiFi9_ConnectCmd:
                {
                    if (createOrReplace)
                    {
                        if (WiFi9_ConnectCmd == null)
                        {
                            if (replacement == null)
                            {
                                WiFi9_ConnectCmd = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                WiFi9_ConnectCmd = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = WiFi9_ConnectCmd;
                    break;
                }

                case RpiWiFiOpcUa.BrowseNames.WiFi10_ConnectCmd:
                {
                    if (createOrReplace)
                    {
                        if (WiFi10_ConnectCmd == null)
                        {
                            if (replacement == null)
                            {
                                WiFi10_ConnectCmd = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                WiFi10_ConnectCmd = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = WiFi10_ConnectCmd;
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
        private BaseDataVariableState<string> m_wiFi6_SSID;
        private BaseDataVariableState<string> m_wiFi7_SSID;
        private BaseDataVariableState<string> m_wiFi8_SSID;
        private BaseDataVariableState<string> m_wiFi9_SSID;
        private BaseDataVariableState<string> m_wiFi10_SSID;
        private BaseDataVariableState<string> m_selWiFiPasskey;
        private BaseDataVariableState<bool> m_wiFi1_Connected;
        private BaseDataVariableState<bool> m_wiFi2_Connected;
        private BaseDataVariableState<bool> m_wiFi3_Connected;
        private BaseDataVariableState<bool> m_wiFi4_Connected;
        private BaseDataVariableState<bool> m_wiFi5_Connected;
        private BaseDataVariableState<bool> m_wiFi6_Connected;
        private BaseDataVariableState<bool> m_wiFi7_Connected;
        private BaseDataVariableState<bool> m_wiFi8_Connected;
        private BaseDataVariableState<bool> m_wiFi9_Connected;
        private BaseDataVariableState<bool> m_wiFi10_Connected;
        private BaseDataVariableState<bool> m_wiFi1_ConnectCmd;
        private BaseDataVariableState<bool> m_wiFi2_ConnectCmd;
        private BaseDataVariableState<bool> m_wiFi3_ConnectCmd;
        private BaseDataVariableState<bool> m_wiFi4_ConnectCmd;
        private BaseDataVariableState<bool> m_wiFi5_ConnectCmd;
        private BaseDataVariableState<bool> m_wiFi6_ConnectCmd;
        private BaseDataVariableState<bool> m_wiFi7_ConnectCmd;
        private BaseDataVariableState<bool> m_wiFi8_ConnectCmd;
        private BaseDataVariableState<bool> m_wiFi9_ConnectCmd;
        private BaseDataVariableState<bool> m_wiFi10_ConnectCmd;
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
           "V2lGaQEBujoALwEBqDq6OgAAAf////8gAAAAFWCJCgIAAAABAAoAAABXaUZpMV9TU0lEAQG7OgAvAD+7" +
           "OgAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAKAAAAV2lGaTJfU1NJRAEBvDoALwA/vDoAAAAM////" +
           "/wEB/////wAAAAAVYIkKAgAAAAEACgAAAFdpRmkzX1NTSUQBAb06AC8AP706AAAADP////8BAf////8A" +
           "AAAAFWCJCgIAAAABAAoAAABXaUZpNF9TU0lEAQG+OgAvAD++OgAAAAz/////AQH/////AAAAABVgiQoC" +
           "AAAAAQAKAAAAV2lGaTVfU1NJRAEBvzoALwA/vzoAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACgAA" +
           "AFdpRmk2X1NTSUQBAcs6AC8AP8s6AAAADP////8BAf////8AAAAAFWCJCgIAAAABAAoAAABXaUZpN19T" +
           "U0lEAQHMOgAvAD/MOgAAAAz/////AQH/////AAAAABVgiQoCAAAAAQAKAAAAV2lGaThfU1NJRAEBzToA" +
           "LwA/zToAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEACgAAAFdpRmk5X1NTSUQBAc46AC8AP846AAAA" +
           "DP////8BAf////8AAAAAFWCJCgIAAAABAAsAAABXaUZpMTBfU1NJRAEBzzoALwA/zzoAAAAM/////wEB" +
           "/////wAAAAAVYIkKAgAAAAEADgAAAFNlbFdpRmlQYXNza2V5AQHAOgAvAD/AOgAAAAz/////AwP/////" +
           "AAAAABVgiQoCAAAAAQAPAAAAV2lGaTFfQ29ubmVjdGVkAQHBOgAvAD/BOgAAAAH/////AQH/////AAAA" +
           "ABVgiQoCAAAAAQAPAAAAV2lGaTJfQ29ubmVjdGVkAQHCOgAvAD/COgAAAAH/////AQH/////AAAAABVg" +
           "iQoCAAAAAQAPAAAAV2lGaTNfQ29ubmVjdGVkAQHDOgAvAD/DOgAAAAH/////AQH/////AAAAABVgiQoC" +
           "AAAAAQAPAAAAV2lGaTRfQ29ubmVjdGVkAQHEOgAvAD/EOgAAAAH/////AQH/////AAAAABVgiQoCAAAA" +
           "AQAPAAAAV2lGaTVfQ29ubmVjdGVkAQHFOgAvAD/FOgAAAAH/////AQH/////AAAAABVgiQoCAAAAAQAP" +
           "AAAAV2lGaTZfQ29ubmVjdGVkAQHQOgAvAD/QOgAAAAH/////AQH/////AAAAABVgiQoCAAAAAQAPAAAA" +
           "V2lGaTdfQ29ubmVjdGVkAQHROgAvAD/ROgAAAAH/////AQH/////AAAAABVgiQoCAAAAAQAPAAAAV2lG" +
           "aThfQ29ubmVjdGVkAQHSOgAvAD/SOgAAAAH/////AQH/////AAAAABVgiQoCAAAAAQAPAAAAV2lGaTlf" +
           "Q29ubmVjdGVkAQHTOgAvAD/TOgAAAAH/////AQH/////AAAAABVgiQoCAAAAAQAQAAAAV2lGaTEwX0Nv" +
           "bm5lY3RlZAEB1DoALwA/1DoAAAAB/////wEB/////wAAAAAVYIkKAgAAAAEAEAAAAFdpRmkxX0Nvbm5l" +
           "Y3RDbWQBAcY6AC8AP8Y6AAAAAf////8CAv////8AAAAAFWCJCgIAAAABABAAAABXaUZpMl9Db25uZWN0" +
           "Q21kAQHHOgAvAD/HOgAAAAH/////AgL/////AAAAABVgiQoCAAAAAQAQAAAAV2lGaTNfQ29ubmVjdENt" +
           "ZAEByDoALwA/yDoAAAAB/////wIC/////wAAAAAVYIkKAgAAAAEAEAAAAFdpRmk0X0Nvbm5lY3RDbWQB" +
           "Ack6AC8AP8k6AAAAAf////8CAv////8AAAAAFWCJCgIAAAABABAAAABXaUZpNV9Db25uZWN0Q21kAQHK" +
           "OgAvAD/KOgAAAAH/////AgL/////AAAAABVgiQoCAAAAAQAQAAAAV2lGaTZfQ29ubmVjdENtZAEB1ToA" +
           "LwA/1ToAAAAB/////wIC/////wAAAAAVYIkKAgAAAAEAEAAAAFdpRmk3X0Nvbm5lY3RDbWQBAdY6AC8A" +
           "P9Y6AAAAAf////8CAv////8AAAAAFWCJCgIAAAABABAAAABXaUZpOF9Db25uZWN0Q21kAQHXOgAvAD/X" +
           "OgAAAAH/////AgL/////AAAAABVgiQoCAAAAAQAQAAAAV2lGaTlfQ29ubmVjdENtZAEB2DoALwA/2DoA" +
           "AAAB/////wIC/////wAAAAAVYIkKAgAAAAEAEQAAAFdpRmkxMF9Db25uZWN0Q21kAQHZOgAvAD/ZOgAA" +
           "AAH/////AgL/////AAAAABVgiQoCAAAAAQASAAAAV2lGaV9EaXNjb25uZWN0Q21kAQEMOwAvAD8MOwAA" +
           "AAH/////AgL/////AAAAAA==";
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