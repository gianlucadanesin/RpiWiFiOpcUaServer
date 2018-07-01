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
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace RpiWiFiOpcUa
{
    #region Object Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <summary>
        /// The identifier for the RpiType_WiFi Object.
        /// </summary>
        public const uint RpiType_WiFi = 15034;

        /// <summary>
        /// The identifier for the Rpi Object.
        /// </summary>
        public const uint Rpi = 15097;

        /// <summary>
        /// The identifier for the Rpi_WiFi Object.
        /// </summary>
        public const uint Rpi_WiFi = 15098;
    }
    #endregion

    #region ObjectType Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <summary>
        /// The identifier for the RpiWiFiInterface ObjectType.
        /// </summary>
        public const uint RpiWiFiInterface = 15016;

        /// <summary>
        /// The identifier for the RpiFolder ObjectType.
        /// </summary>
        public const uint RpiFolder = 15069;

        /// <summary>
        /// The identifier for the RpiType ObjectType.
        /// </summary>
        public const uint RpiType = 15033;
    }
    #endregion

    #region Variable Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi1_SSID Variable.
        /// </summary>
        public const uint RpiWiFiInterface_WiFi1_SSID = 15017;

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi2_SSID Variable.
        /// </summary>
        public const uint RpiWiFiInterface_WiFi2_SSID = 15018;

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi3_SSID Variable.
        /// </summary>
        public const uint RpiWiFiInterface_WiFi3_SSID = 15019;

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi4_SSID Variable.
        /// </summary>
        public const uint RpiWiFiInterface_WiFi4_SSID = 15020;

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi5_SSID Variable.
        /// </summary>
        public const uint RpiWiFiInterface_WiFi5_SSID = 15021;

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi6_SSID Variable.
        /// </summary>
        public const uint RpiWiFiInterface_WiFi6_SSID = 15001;

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi7_SSID Variable.
        /// </summary>
        public const uint RpiWiFiInterface_WiFi7_SSID = 15002;

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi8_SSID Variable.
        /// </summary>
        public const uint RpiWiFiInterface_WiFi8_SSID = 15003;

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi9_SSID Variable.
        /// </summary>
        public const uint RpiWiFiInterface_WiFi9_SSID = 15004;

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi10_SSID Variable.
        /// </summary>
        public const uint RpiWiFiInterface_WiFi10_SSID = 15005;

        /// <summary>
        /// The identifier for the RpiWiFiInterface_SelWiFiPasskey Variable.
        /// </summary>
        public const uint RpiWiFiInterface_SelWiFiPasskey = 15022;

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi1_Connected Variable.
        /// </summary>
        public const uint RpiWiFiInterface_WiFi1_Connected = 15023;

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi2_Connected Variable.
        /// </summary>
        public const uint RpiWiFiInterface_WiFi2_Connected = 15024;

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi3_Connected Variable.
        /// </summary>
        public const uint RpiWiFiInterface_WiFi3_Connected = 15025;

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi4_Connected Variable.
        /// </summary>
        public const uint RpiWiFiInterface_WiFi4_Connected = 15026;

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi5_Connected Variable.
        /// </summary>
        public const uint RpiWiFiInterface_WiFi5_Connected = 15027;

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi6_Connected Variable.
        /// </summary>
        public const uint RpiWiFiInterface_WiFi6_Connected = 15006;

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi7_Connected Variable.
        /// </summary>
        public const uint RpiWiFiInterface_WiFi7_Connected = 15007;

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi8_Connected Variable.
        /// </summary>
        public const uint RpiWiFiInterface_WiFi8_Connected = 15008;

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi9_Connected Variable.
        /// </summary>
        public const uint RpiWiFiInterface_WiFi9_Connected = 15009;

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi10_Connected Variable.
        /// </summary>
        public const uint RpiWiFiInterface_WiFi10_Connected = 15010;

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi1_ConnectCmd Variable.
        /// </summary>
        public const uint RpiWiFiInterface_WiFi1_ConnectCmd = 15028;

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi2_ConnectCmd Variable.
        /// </summary>
        public const uint RpiWiFiInterface_WiFi2_ConnectCmd = 15029;

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi3_ConnectCmd Variable.
        /// </summary>
        public const uint RpiWiFiInterface_WiFi3_ConnectCmd = 15030;

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi4_ConnectCmd Variable.
        /// </summary>
        public const uint RpiWiFiInterface_WiFi4_ConnectCmd = 15031;

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi5_ConnectCmd Variable.
        /// </summary>
        public const uint RpiWiFiInterface_WiFi5_ConnectCmd = 15032;

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi6_ConnectCmd Variable.
        /// </summary>
        public const uint RpiWiFiInterface_WiFi6_ConnectCmd = 15011;

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi7_ConnectCmd Variable.
        /// </summary>
        public const uint RpiWiFiInterface_WiFi7_ConnectCmd = 15012;

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi8_ConnectCmd Variable.
        /// </summary>
        public const uint RpiWiFiInterface_WiFi8_ConnectCmd = 15013;

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi9_ConnectCmd Variable.
        /// </summary>
        public const uint RpiWiFiInterface_WiFi9_ConnectCmd = 15014;

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi10_ConnectCmd Variable.
        /// </summary>
        public const uint RpiWiFiInterface_WiFi10_ConnectCmd = 15015;

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi_DisconnectCmd Variable.
        /// </summary>
        public const uint RpiWiFiInterface_WiFi_DisconnectCmd = 15115;

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi1_SSID Variable.
        /// </summary>
        public const uint RpiType_WiFi_WiFi1_SSID = 15035;

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi2_SSID Variable.
        /// </summary>
        public const uint RpiType_WiFi_WiFi2_SSID = 15036;

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi3_SSID Variable.
        /// </summary>
        public const uint RpiType_WiFi_WiFi3_SSID = 15037;

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi4_SSID Variable.
        /// </summary>
        public const uint RpiType_WiFi_WiFi4_SSID = 15038;

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi5_SSID Variable.
        /// </summary>
        public const uint RpiType_WiFi_WiFi5_SSID = 15039;

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi6_SSID Variable.
        /// </summary>
        public const uint RpiType_WiFi_WiFi6_SSID = 15051;

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi7_SSID Variable.
        /// </summary>
        public const uint RpiType_WiFi_WiFi7_SSID = 15052;

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi8_SSID Variable.
        /// </summary>
        public const uint RpiType_WiFi_WiFi8_SSID = 15053;

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi9_SSID Variable.
        /// </summary>
        public const uint RpiType_WiFi_WiFi9_SSID = 15054;

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi10_SSID Variable.
        /// </summary>
        public const uint RpiType_WiFi_WiFi10_SSID = 15055;

        /// <summary>
        /// The identifier for the RpiType_WiFi_SelWiFiPasskey Variable.
        /// </summary>
        public const uint RpiType_WiFi_SelWiFiPasskey = 15040;

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi1_Connected Variable.
        /// </summary>
        public const uint RpiType_WiFi_WiFi1_Connected = 15041;

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi2_Connected Variable.
        /// </summary>
        public const uint RpiType_WiFi_WiFi2_Connected = 15042;

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi3_Connected Variable.
        /// </summary>
        public const uint RpiType_WiFi_WiFi3_Connected = 15043;

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi4_Connected Variable.
        /// </summary>
        public const uint RpiType_WiFi_WiFi4_Connected = 15044;

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi5_Connected Variable.
        /// </summary>
        public const uint RpiType_WiFi_WiFi5_Connected = 15045;

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi6_Connected Variable.
        /// </summary>
        public const uint RpiType_WiFi_WiFi6_Connected = 15056;

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi7_Connected Variable.
        /// </summary>
        public const uint RpiType_WiFi_WiFi7_Connected = 15057;

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi8_Connected Variable.
        /// </summary>
        public const uint RpiType_WiFi_WiFi8_Connected = 15058;

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi9_Connected Variable.
        /// </summary>
        public const uint RpiType_WiFi_WiFi9_Connected = 15059;

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi10_Connected Variable.
        /// </summary>
        public const uint RpiType_WiFi_WiFi10_Connected = 15060;

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi1_ConnectCmd Variable.
        /// </summary>
        public const uint RpiType_WiFi_WiFi1_ConnectCmd = 15046;

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi2_ConnectCmd Variable.
        /// </summary>
        public const uint RpiType_WiFi_WiFi2_ConnectCmd = 15047;

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi3_ConnectCmd Variable.
        /// </summary>
        public const uint RpiType_WiFi_WiFi3_ConnectCmd = 15048;

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi4_ConnectCmd Variable.
        /// </summary>
        public const uint RpiType_WiFi_WiFi4_ConnectCmd = 15049;

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi5_ConnectCmd Variable.
        /// </summary>
        public const uint RpiType_WiFi_WiFi5_ConnectCmd = 15050;

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi6_ConnectCmd Variable.
        /// </summary>
        public const uint RpiType_WiFi_WiFi6_ConnectCmd = 15061;

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi7_ConnectCmd Variable.
        /// </summary>
        public const uint RpiType_WiFi_WiFi7_ConnectCmd = 15062;

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi8_ConnectCmd Variable.
        /// </summary>
        public const uint RpiType_WiFi_WiFi8_ConnectCmd = 15063;

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi9_ConnectCmd Variable.
        /// </summary>
        public const uint RpiType_WiFi_WiFi9_ConnectCmd = 15064;

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi10_ConnectCmd Variable.
        /// </summary>
        public const uint RpiType_WiFi_WiFi10_ConnectCmd = 15065;

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi_DisconnectCmd Variable.
        /// </summary>
        public const uint RpiType_WiFi_WiFi_DisconnectCmd = 15116;

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi1_SSID Variable.
        /// </summary>
        public const uint Rpi_WiFi_WiFi1_SSID = 15099;

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi2_SSID Variable.
        /// </summary>
        public const uint Rpi_WiFi_WiFi2_SSID = 15100;

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi3_SSID Variable.
        /// </summary>
        public const uint Rpi_WiFi_WiFi3_SSID = 15101;

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi4_SSID Variable.
        /// </summary>
        public const uint Rpi_WiFi_WiFi4_SSID = 15102;

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi5_SSID Variable.
        /// </summary>
        public const uint Rpi_WiFi_WiFi5_SSID = 15103;

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi6_SSID Variable.
        /// </summary>
        public const uint Rpi_WiFi_WiFi6_SSID = 15066;

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi7_SSID Variable.
        /// </summary>
        public const uint Rpi_WiFi_WiFi7_SSID = 15067;

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi8_SSID Variable.
        /// </summary>
        public const uint Rpi_WiFi_WiFi8_SSID = 15068;

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi9_SSID Variable.
        /// </summary>
        public const uint Rpi_WiFi_WiFi9_SSID = 15070;

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi10_SSID Variable.
        /// </summary>
        public const uint Rpi_WiFi_WiFi10_SSID = 15071;

        /// <summary>
        /// The identifier for the Rpi_WiFi_SelWiFiPasskey Variable.
        /// </summary>
        public const uint Rpi_WiFi_SelWiFiPasskey = 15104;

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi1_Connected Variable.
        /// </summary>
        public const uint Rpi_WiFi_WiFi1_Connected = 15105;

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi2_Connected Variable.
        /// </summary>
        public const uint Rpi_WiFi_WiFi2_Connected = 15106;

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi3_Connected Variable.
        /// </summary>
        public const uint Rpi_WiFi_WiFi3_Connected = 15107;

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi4_Connected Variable.
        /// </summary>
        public const uint Rpi_WiFi_WiFi4_Connected = 15108;

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi5_Connected Variable.
        /// </summary>
        public const uint Rpi_WiFi_WiFi5_Connected = 15109;

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi6_Connected Variable.
        /// </summary>
        public const uint Rpi_WiFi_WiFi6_Connected = 15072;

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi7_Connected Variable.
        /// </summary>
        public const uint Rpi_WiFi_WiFi7_Connected = 15073;

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi8_Connected Variable.
        /// </summary>
        public const uint Rpi_WiFi_WiFi8_Connected = 15074;

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi9_Connected Variable.
        /// </summary>
        public const uint Rpi_WiFi_WiFi9_Connected = 15075;

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi10_Connected Variable.
        /// </summary>
        public const uint Rpi_WiFi_WiFi10_Connected = 15076;

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi1_ConnectCmd Variable.
        /// </summary>
        public const uint Rpi_WiFi_WiFi1_ConnectCmd = 15110;

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi2_ConnectCmd Variable.
        /// </summary>
        public const uint Rpi_WiFi_WiFi2_ConnectCmd = 15111;

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi3_ConnectCmd Variable.
        /// </summary>
        public const uint Rpi_WiFi_WiFi3_ConnectCmd = 15112;

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi4_ConnectCmd Variable.
        /// </summary>
        public const uint Rpi_WiFi_WiFi4_ConnectCmd = 15113;

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi5_ConnectCmd Variable.
        /// </summary>
        public const uint Rpi_WiFi_WiFi5_ConnectCmd = 15114;

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi6_ConnectCmd Variable.
        /// </summary>
        public const uint Rpi_WiFi_WiFi6_ConnectCmd = 15077;

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi7_ConnectCmd Variable.
        /// </summary>
        public const uint Rpi_WiFi_WiFi7_ConnectCmd = 15078;

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi8_ConnectCmd Variable.
        /// </summary>
        public const uint Rpi_WiFi_WiFi8_ConnectCmd = 15079;

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi9_ConnectCmd Variable.
        /// </summary>
        public const uint Rpi_WiFi_WiFi9_ConnectCmd = 15080;

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi10_ConnectCmd Variable.
        /// </summary>
        public const uint Rpi_WiFi_WiFi10_ConnectCmd = 15081;

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi_DisconnectCmd Variable.
        /// </summary>
        public const uint Rpi_WiFi_WiFi_DisconnectCmd = 15117;
    }
    #endregion

    #region Object Node Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <summary>
        /// The identifier for the RpiType_WiFi Object.
        /// </summary>
        public static readonly ExpandedNodeId RpiType_WiFi = new ExpandedNodeId(RpiWiFiOpcUa.Objects.RpiType_WiFi, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the Rpi Object.
        /// </summary>
        public static readonly ExpandedNodeId Rpi = new ExpandedNodeId(RpiWiFiOpcUa.Objects.Rpi, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the Rpi_WiFi Object.
        /// </summary>
        public static readonly ExpandedNodeId Rpi_WiFi = new ExpandedNodeId(RpiWiFiOpcUa.Objects.Rpi_WiFi, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <summary>
        /// The identifier for the RpiWiFiInterface ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId RpiWiFiInterface = new ExpandedNodeId(RpiWiFiOpcUa.ObjectTypes.RpiWiFiInterface, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiFolder ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId RpiFolder = new ExpandedNodeId(RpiWiFiOpcUa.ObjectTypes.RpiFolder, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId RpiType = new ExpandedNodeId(RpiWiFiOpcUa.ObjectTypes.RpiType, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);
    }
    #endregion

    #region Variable Node Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi1_SSID Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiWiFiInterface_WiFi1_SSID = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiWiFiInterface_WiFi1_SSID, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi2_SSID Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiWiFiInterface_WiFi2_SSID = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiWiFiInterface_WiFi2_SSID, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi3_SSID Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiWiFiInterface_WiFi3_SSID = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiWiFiInterface_WiFi3_SSID, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi4_SSID Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiWiFiInterface_WiFi4_SSID = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiWiFiInterface_WiFi4_SSID, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi5_SSID Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiWiFiInterface_WiFi5_SSID = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiWiFiInterface_WiFi5_SSID, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi6_SSID Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiWiFiInterface_WiFi6_SSID = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiWiFiInterface_WiFi6_SSID, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi7_SSID Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiWiFiInterface_WiFi7_SSID = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiWiFiInterface_WiFi7_SSID, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi8_SSID Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiWiFiInterface_WiFi8_SSID = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiWiFiInterface_WiFi8_SSID, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi9_SSID Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiWiFiInterface_WiFi9_SSID = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiWiFiInterface_WiFi9_SSID, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi10_SSID Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiWiFiInterface_WiFi10_SSID = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiWiFiInterface_WiFi10_SSID, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiWiFiInterface_SelWiFiPasskey Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiWiFiInterface_SelWiFiPasskey = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiWiFiInterface_SelWiFiPasskey, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi1_Connected Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiWiFiInterface_WiFi1_Connected = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiWiFiInterface_WiFi1_Connected, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi2_Connected Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiWiFiInterface_WiFi2_Connected = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiWiFiInterface_WiFi2_Connected, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi3_Connected Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiWiFiInterface_WiFi3_Connected = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiWiFiInterface_WiFi3_Connected, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi4_Connected Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiWiFiInterface_WiFi4_Connected = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiWiFiInterface_WiFi4_Connected, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi5_Connected Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiWiFiInterface_WiFi5_Connected = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiWiFiInterface_WiFi5_Connected, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi6_Connected Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiWiFiInterface_WiFi6_Connected = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiWiFiInterface_WiFi6_Connected, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi7_Connected Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiWiFiInterface_WiFi7_Connected = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiWiFiInterface_WiFi7_Connected, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi8_Connected Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiWiFiInterface_WiFi8_Connected = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiWiFiInterface_WiFi8_Connected, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi9_Connected Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiWiFiInterface_WiFi9_Connected = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiWiFiInterface_WiFi9_Connected, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi10_Connected Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiWiFiInterface_WiFi10_Connected = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiWiFiInterface_WiFi10_Connected, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi1_ConnectCmd Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiWiFiInterface_WiFi1_ConnectCmd = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiWiFiInterface_WiFi1_ConnectCmd, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi2_ConnectCmd Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiWiFiInterface_WiFi2_ConnectCmd = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiWiFiInterface_WiFi2_ConnectCmd, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi3_ConnectCmd Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiWiFiInterface_WiFi3_ConnectCmd = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiWiFiInterface_WiFi3_ConnectCmd, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi4_ConnectCmd Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiWiFiInterface_WiFi4_ConnectCmd = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiWiFiInterface_WiFi4_ConnectCmd, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi5_ConnectCmd Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiWiFiInterface_WiFi5_ConnectCmd = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiWiFiInterface_WiFi5_ConnectCmd, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi6_ConnectCmd Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiWiFiInterface_WiFi6_ConnectCmd = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiWiFiInterface_WiFi6_ConnectCmd, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi7_ConnectCmd Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiWiFiInterface_WiFi7_ConnectCmd = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiWiFiInterface_WiFi7_ConnectCmd, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi8_ConnectCmd Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiWiFiInterface_WiFi8_ConnectCmd = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiWiFiInterface_WiFi8_ConnectCmd, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi9_ConnectCmd Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiWiFiInterface_WiFi9_ConnectCmd = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiWiFiInterface_WiFi9_ConnectCmd, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi10_ConnectCmd Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiWiFiInterface_WiFi10_ConnectCmd = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiWiFiInterface_WiFi10_ConnectCmd, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiWiFiInterface_WiFi_DisconnectCmd Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiWiFiInterface_WiFi_DisconnectCmd = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiWiFiInterface_WiFi_DisconnectCmd, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi1_SSID Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiType_WiFi_WiFi1_SSID = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiType_WiFi_WiFi1_SSID, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi2_SSID Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiType_WiFi_WiFi2_SSID = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiType_WiFi_WiFi2_SSID, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi3_SSID Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiType_WiFi_WiFi3_SSID = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiType_WiFi_WiFi3_SSID, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi4_SSID Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiType_WiFi_WiFi4_SSID = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiType_WiFi_WiFi4_SSID, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi5_SSID Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiType_WiFi_WiFi5_SSID = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiType_WiFi_WiFi5_SSID, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi6_SSID Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiType_WiFi_WiFi6_SSID = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiType_WiFi_WiFi6_SSID, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi7_SSID Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiType_WiFi_WiFi7_SSID = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiType_WiFi_WiFi7_SSID, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi8_SSID Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiType_WiFi_WiFi8_SSID = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiType_WiFi_WiFi8_SSID, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi9_SSID Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiType_WiFi_WiFi9_SSID = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiType_WiFi_WiFi9_SSID, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi10_SSID Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiType_WiFi_WiFi10_SSID = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiType_WiFi_WiFi10_SSID, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiType_WiFi_SelWiFiPasskey Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiType_WiFi_SelWiFiPasskey = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiType_WiFi_SelWiFiPasskey, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi1_Connected Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiType_WiFi_WiFi1_Connected = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiType_WiFi_WiFi1_Connected, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi2_Connected Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiType_WiFi_WiFi2_Connected = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiType_WiFi_WiFi2_Connected, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi3_Connected Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiType_WiFi_WiFi3_Connected = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiType_WiFi_WiFi3_Connected, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi4_Connected Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiType_WiFi_WiFi4_Connected = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiType_WiFi_WiFi4_Connected, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi5_Connected Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiType_WiFi_WiFi5_Connected = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiType_WiFi_WiFi5_Connected, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi6_Connected Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiType_WiFi_WiFi6_Connected = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiType_WiFi_WiFi6_Connected, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi7_Connected Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiType_WiFi_WiFi7_Connected = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiType_WiFi_WiFi7_Connected, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi8_Connected Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiType_WiFi_WiFi8_Connected = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiType_WiFi_WiFi8_Connected, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi9_Connected Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiType_WiFi_WiFi9_Connected = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiType_WiFi_WiFi9_Connected, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi10_Connected Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiType_WiFi_WiFi10_Connected = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiType_WiFi_WiFi10_Connected, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi1_ConnectCmd Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiType_WiFi_WiFi1_ConnectCmd = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiType_WiFi_WiFi1_ConnectCmd, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi2_ConnectCmd Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiType_WiFi_WiFi2_ConnectCmd = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiType_WiFi_WiFi2_ConnectCmd, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi3_ConnectCmd Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiType_WiFi_WiFi3_ConnectCmd = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiType_WiFi_WiFi3_ConnectCmd, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi4_ConnectCmd Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiType_WiFi_WiFi4_ConnectCmd = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiType_WiFi_WiFi4_ConnectCmd, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi5_ConnectCmd Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiType_WiFi_WiFi5_ConnectCmd = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiType_WiFi_WiFi5_ConnectCmd, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi6_ConnectCmd Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiType_WiFi_WiFi6_ConnectCmd = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiType_WiFi_WiFi6_ConnectCmd, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi7_ConnectCmd Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiType_WiFi_WiFi7_ConnectCmd = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiType_WiFi_WiFi7_ConnectCmd, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi8_ConnectCmd Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiType_WiFi_WiFi8_ConnectCmd = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiType_WiFi_WiFi8_ConnectCmd, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi9_ConnectCmd Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiType_WiFi_WiFi9_ConnectCmd = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiType_WiFi_WiFi9_ConnectCmd, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi10_ConnectCmd Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiType_WiFi_WiFi10_ConnectCmd = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiType_WiFi_WiFi10_ConnectCmd, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the RpiType_WiFi_WiFi_DisconnectCmd Variable.
        /// </summary>
        public static readonly ExpandedNodeId RpiType_WiFi_WiFi_DisconnectCmd = new ExpandedNodeId(RpiWiFiOpcUa.Variables.RpiType_WiFi_WiFi_DisconnectCmd, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi1_SSID Variable.
        /// </summary>
        public static readonly ExpandedNodeId Rpi_WiFi_WiFi1_SSID = new ExpandedNodeId(RpiWiFiOpcUa.Variables.Rpi_WiFi_WiFi1_SSID, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi2_SSID Variable.
        /// </summary>
        public static readonly ExpandedNodeId Rpi_WiFi_WiFi2_SSID = new ExpandedNodeId(RpiWiFiOpcUa.Variables.Rpi_WiFi_WiFi2_SSID, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi3_SSID Variable.
        /// </summary>
        public static readonly ExpandedNodeId Rpi_WiFi_WiFi3_SSID = new ExpandedNodeId(RpiWiFiOpcUa.Variables.Rpi_WiFi_WiFi3_SSID, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi4_SSID Variable.
        /// </summary>
        public static readonly ExpandedNodeId Rpi_WiFi_WiFi4_SSID = new ExpandedNodeId(RpiWiFiOpcUa.Variables.Rpi_WiFi_WiFi4_SSID, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi5_SSID Variable.
        /// </summary>
        public static readonly ExpandedNodeId Rpi_WiFi_WiFi5_SSID = new ExpandedNodeId(RpiWiFiOpcUa.Variables.Rpi_WiFi_WiFi5_SSID, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi6_SSID Variable.
        /// </summary>
        public static readonly ExpandedNodeId Rpi_WiFi_WiFi6_SSID = new ExpandedNodeId(RpiWiFiOpcUa.Variables.Rpi_WiFi_WiFi6_SSID, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi7_SSID Variable.
        /// </summary>
        public static readonly ExpandedNodeId Rpi_WiFi_WiFi7_SSID = new ExpandedNodeId(RpiWiFiOpcUa.Variables.Rpi_WiFi_WiFi7_SSID, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi8_SSID Variable.
        /// </summary>
        public static readonly ExpandedNodeId Rpi_WiFi_WiFi8_SSID = new ExpandedNodeId(RpiWiFiOpcUa.Variables.Rpi_WiFi_WiFi8_SSID, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi9_SSID Variable.
        /// </summary>
        public static readonly ExpandedNodeId Rpi_WiFi_WiFi9_SSID = new ExpandedNodeId(RpiWiFiOpcUa.Variables.Rpi_WiFi_WiFi9_SSID, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi10_SSID Variable.
        /// </summary>
        public static readonly ExpandedNodeId Rpi_WiFi_WiFi10_SSID = new ExpandedNodeId(RpiWiFiOpcUa.Variables.Rpi_WiFi_WiFi10_SSID, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the Rpi_WiFi_SelWiFiPasskey Variable.
        /// </summary>
        public static readonly ExpandedNodeId Rpi_WiFi_SelWiFiPasskey = new ExpandedNodeId(RpiWiFiOpcUa.Variables.Rpi_WiFi_SelWiFiPasskey, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi1_Connected Variable.
        /// </summary>
        public static readonly ExpandedNodeId Rpi_WiFi_WiFi1_Connected = new ExpandedNodeId(RpiWiFiOpcUa.Variables.Rpi_WiFi_WiFi1_Connected, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi2_Connected Variable.
        /// </summary>
        public static readonly ExpandedNodeId Rpi_WiFi_WiFi2_Connected = new ExpandedNodeId(RpiWiFiOpcUa.Variables.Rpi_WiFi_WiFi2_Connected, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi3_Connected Variable.
        /// </summary>
        public static readonly ExpandedNodeId Rpi_WiFi_WiFi3_Connected = new ExpandedNodeId(RpiWiFiOpcUa.Variables.Rpi_WiFi_WiFi3_Connected, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi4_Connected Variable.
        /// </summary>
        public static readonly ExpandedNodeId Rpi_WiFi_WiFi4_Connected = new ExpandedNodeId(RpiWiFiOpcUa.Variables.Rpi_WiFi_WiFi4_Connected, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi5_Connected Variable.
        /// </summary>
        public static readonly ExpandedNodeId Rpi_WiFi_WiFi5_Connected = new ExpandedNodeId(RpiWiFiOpcUa.Variables.Rpi_WiFi_WiFi5_Connected, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi6_Connected Variable.
        /// </summary>
        public static readonly ExpandedNodeId Rpi_WiFi_WiFi6_Connected = new ExpandedNodeId(RpiWiFiOpcUa.Variables.Rpi_WiFi_WiFi6_Connected, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi7_Connected Variable.
        /// </summary>
        public static readonly ExpandedNodeId Rpi_WiFi_WiFi7_Connected = new ExpandedNodeId(RpiWiFiOpcUa.Variables.Rpi_WiFi_WiFi7_Connected, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi8_Connected Variable.
        /// </summary>
        public static readonly ExpandedNodeId Rpi_WiFi_WiFi8_Connected = new ExpandedNodeId(RpiWiFiOpcUa.Variables.Rpi_WiFi_WiFi8_Connected, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi9_Connected Variable.
        /// </summary>
        public static readonly ExpandedNodeId Rpi_WiFi_WiFi9_Connected = new ExpandedNodeId(RpiWiFiOpcUa.Variables.Rpi_WiFi_WiFi9_Connected, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi10_Connected Variable.
        /// </summary>
        public static readonly ExpandedNodeId Rpi_WiFi_WiFi10_Connected = new ExpandedNodeId(RpiWiFiOpcUa.Variables.Rpi_WiFi_WiFi10_Connected, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi1_ConnectCmd Variable.
        /// </summary>
        public static readonly ExpandedNodeId Rpi_WiFi_WiFi1_ConnectCmd = new ExpandedNodeId(RpiWiFiOpcUa.Variables.Rpi_WiFi_WiFi1_ConnectCmd, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi2_ConnectCmd Variable.
        /// </summary>
        public static readonly ExpandedNodeId Rpi_WiFi_WiFi2_ConnectCmd = new ExpandedNodeId(RpiWiFiOpcUa.Variables.Rpi_WiFi_WiFi2_ConnectCmd, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi3_ConnectCmd Variable.
        /// </summary>
        public static readonly ExpandedNodeId Rpi_WiFi_WiFi3_ConnectCmd = new ExpandedNodeId(RpiWiFiOpcUa.Variables.Rpi_WiFi_WiFi3_ConnectCmd, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi4_ConnectCmd Variable.
        /// </summary>
        public static readonly ExpandedNodeId Rpi_WiFi_WiFi4_ConnectCmd = new ExpandedNodeId(RpiWiFiOpcUa.Variables.Rpi_WiFi_WiFi4_ConnectCmd, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi5_ConnectCmd Variable.
        /// </summary>
        public static readonly ExpandedNodeId Rpi_WiFi_WiFi5_ConnectCmd = new ExpandedNodeId(RpiWiFiOpcUa.Variables.Rpi_WiFi_WiFi5_ConnectCmd, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi6_ConnectCmd Variable.
        /// </summary>
        public static readonly ExpandedNodeId Rpi_WiFi_WiFi6_ConnectCmd = new ExpandedNodeId(RpiWiFiOpcUa.Variables.Rpi_WiFi_WiFi6_ConnectCmd, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi7_ConnectCmd Variable.
        /// </summary>
        public static readonly ExpandedNodeId Rpi_WiFi_WiFi7_ConnectCmd = new ExpandedNodeId(RpiWiFiOpcUa.Variables.Rpi_WiFi_WiFi7_ConnectCmd, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi8_ConnectCmd Variable.
        /// </summary>
        public static readonly ExpandedNodeId Rpi_WiFi_WiFi8_ConnectCmd = new ExpandedNodeId(RpiWiFiOpcUa.Variables.Rpi_WiFi_WiFi8_ConnectCmd, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi9_ConnectCmd Variable.
        /// </summary>
        public static readonly ExpandedNodeId Rpi_WiFi_WiFi9_ConnectCmd = new ExpandedNodeId(RpiWiFiOpcUa.Variables.Rpi_WiFi_WiFi9_ConnectCmd, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi10_ConnectCmd Variable.
        /// </summary>
        public static readonly ExpandedNodeId Rpi_WiFi_WiFi10_ConnectCmd = new ExpandedNodeId(RpiWiFiOpcUa.Variables.Rpi_WiFi_WiFi10_ConnectCmd, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);

        /// <summary>
        /// The identifier for the Rpi_WiFi_WiFi_DisconnectCmd Variable.
        /// </summary>
        public static readonly ExpandedNodeId Rpi_WiFi_WiFi_DisconnectCmd = new ExpandedNodeId(RpiWiFiOpcUa.Variables.Rpi_WiFi_WiFi_DisconnectCmd, RpiWiFiOpcUa.Namespaces.RpiWiFiOpcUa);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the Rpi component.
        /// </summary>
        public const string Rpi = "Raspberry Pi";

        /// <summary>
        /// The BrowseName for the RpiFolder component.
        /// </summary>
        public const string RpiFolder = "RpiFolder";

        /// <summary>
        /// The BrowseName for the RpiType component.
        /// </summary>
        public const string RpiType = "RpiType";

        /// <summary>
        /// The BrowseName for the RpiWiFiInterface component.
        /// </summary>
        public const string RpiWiFiInterface = "RpiWiFiInterface";

        /// <summary>
        /// The BrowseName for the SelWiFiPasskey component.
        /// </summary>
        public const string SelWiFiPasskey = "SelWiFiPasskey";

        /// <summary>
        /// The BrowseName for the WiFi component.
        /// </summary>
        public const string WiFi = "RpiWiFi";

        /// <summary>
        /// The BrowseName for the WiFi_DisconnectCmd component.
        /// </summary>
        public const string WiFi_DisconnectCmd = "WiFi_DisconnectCmd";

        /// <summary>
        /// The BrowseName for the WiFi1_ConnectCmd component.
        /// </summary>
        public const string WiFi1_ConnectCmd = "WiFi1_ConnectCmd";

        /// <summary>
        /// The BrowseName for the WiFi1_Connected component.
        /// </summary>
        public const string WiFi1_Connected = "WiFi1_Connected";

        /// <summary>
        /// The BrowseName for the WiFi1_SSID component.
        /// </summary>
        public const string WiFi1_SSID = "WiFi1_SSID";

        /// <summary>
        /// The BrowseName for the WiFi10_ConnectCmd component.
        /// </summary>
        public const string WiFi10_ConnectCmd = "WiFi10_ConnectCmd";

        /// <summary>
        /// The BrowseName for the WiFi10_Connected component.
        /// </summary>
        public const string WiFi10_Connected = "WiFi10_Connected";

        /// <summary>
        /// The BrowseName for the WiFi10_SSID component.
        /// </summary>
        public const string WiFi10_SSID = "WiFi10_SSID";

        /// <summary>
        /// The BrowseName for the WiFi2_ConnectCmd component.
        /// </summary>
        public const string WiFi2_ConnectCmd = "WiFi2_ConnectCmd";

        /// <summary>
        /// The BrowseName for the WiFi2_Connected component.
        /// </summary>
        public const string WiFi2_Connected = "WiFi2_Connected";

        /// <summary>
        /// The BrowseName for the WiFi2_SSID component.
        /// </summary>
        public const string WiFi2_SSID = "WiFi2_SSID";

        /// <summary>
        /// The BrowseName for the WiFi3_ConnectCmd component.
        /// </summary>
        public const string WiFi3_ConnectCmd = "WiFi3_ConnectCmd";

        /// <summary>
        /// The BrowseName for the WiFi3_Connected component.
        /// </summary>
        public const string WiFi3_Connected = "WiFi3_Connected";

        /// <summary>
        /// The BrowseName for the WiFi3_SSID component.
        /// </summary>
        public const string WiFi3_SSID = "WiFi3_SSID";

        /// <summary>
        /// The BrowseName for the WiFi4_ConnectCmd component.
        /// </summary>
        public const string WiFi4_ConnectCmd = "WiFi4_ConnectCmd";

        /// <summary>
        /// The BrowseName for the WiFi4_Connected component.
        /// </summary>
        public const string WiFi4_Connected = "WiFi4_Connected";

        /// <summary>
        /// The BrowseName for the WiFi4_SSID component.
        /// </summary>
        public const string WiFi4_SSID = "WiFi4_SSID";

        /// <summary>
        /// The BrowseName for the WiFi5_ConnectCmd component.
        /// </summary>
        public const string WiFi5_ConnectCmd = "WiFi5_ConnectCmd";

        /// <summary>
        /// The BrowseName for the WiFi5_Connected component.
        /// </summary>
        public const string WiFi5_Connected = "WiFi5_Connected";

        /// <summary>
        /// The BrowseName for the WiFi5_SSID component.
        /// </summary>
        public const string WiFi5_SSID = "WiFi5_SSID";

        /// <summary>
        /// The BrowseName for the WiFi6_ConnectCmd component.
        /// </summary>
        public const string WiFi6_ConnectCmd = "WiFi6_ConnectCmd";

        /// <summary>
        /// The BrowseName for the WiFi6_Connected component.
        /// </summary>
        public const string WiFi6_Connected = "WiFi6_Connected";

        /// <summary>
        /// The BrowseName for the WiFi6_SSID component.
        /// </summary>
        public const string WiFi6_SSID = "WiFi6_SSID";

        /// <summary>
        /// The BrowseName for the WiFi7_ConnectCmd component.
        /// </summary>
        public const string WiFi7_ConnectCmd = "WiFi7_ConnectCmd";

        /// <summary>
        /// The BrowseName for the WiFi7_Connected component.
        /// </summary>
        public const string WiFi7_Connected = "WiFi7_Connected";

        /// <summary>
        /// The BrowseName for the WiFi7_SSID component.
        /// </summary>
        public const string WiFi7_SSID = "WiFi7_SSID";

        /// <summary>
        /// The BrowseName for the WiFi8_ConnectCmd component.
        /// </summary>
        public const string WiFi8_ConnectCmd = "WiFi8_ConnectCmd";

        /// <summary>
        /// The BrowseName for the WiFi8_Connected component.
        /// </summary>
        public const string WiFi8_Connected = "WiFi8_Connected";

        /// <summary>
        /// The BrowseName for the WiFi8_SSID component.
        /// </summary>
        public const string WiFi8_SSID = "WiFi8_SSID";

        /// <summary>
        /// The BrowseName for the WiFi9_ConnectCmd component.
        /// </summary>
        public const string WiFi9_ConnectCmd = "WiFi9_ConnectCmd";

        /// <summary>
        /// The BrowseName for the WiFi9_Connected component.
        /// </summary>
        public const string WiFi9_Connected = "WiFi9_Connected";

        /// <summary>
        /// The BrowseName for the WiFi9_SSID component.
        /// </summary>
        public const string WiFi9_SSID = "WiFi9_SSID";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";

        /// <summary>
        /// The URI for the RpiWiFiOpcUa namespace (.NET code namespace is 'RpiWiFiOpcUa').
        /// </summary>
        public const string RpiWiFiOpcUa = "http://opcfoundation.org/RpiWiFiOpcUa";
    }
    #endregion
}