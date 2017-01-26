//
// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
//

using Microsoft.SqlTools.ServiceLayer.Hosting.Protocol.Contracts;

namespace Microsoft.SqlTools.ServiceLayer.Connection.ProtocolContracts
{
    public class ConnectionInfo
    {
        public string ServerName;

	    public string DatabaseName;
    }

    public class ListConnectionParams
    {
        public ConnectionInfo ConnectionInfo { get; set; }
    }

    public class ListConnectionRequest
    {
        public static readonly
            RequestType<ListConnectionParams, ConnectionInfo[]> Type =
            RequestType<ListConnectionParams, ConnectionInfo[]>.Create("connection/listConnections");
    }
}
