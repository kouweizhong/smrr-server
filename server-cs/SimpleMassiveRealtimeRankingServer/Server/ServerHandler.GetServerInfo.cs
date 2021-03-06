﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpUtils;

namespace SimpleMassiveRealtimeRankingServer.Server
{
	public partial class ServerHandler
	{
        /// <summary>
        /// Obtains information about the server:
        /// - IndexCount
        /// - TotalNumberOfElements
        /// - CurrentPrivateMemory
        /// - CurrentVirtualMemory
        /// - PeakVirtualMemory
        /// </summary>
        /// <param name="RequestContent">Content of the request.</param>
        /// <returns>A ServerManager.ServerInfoStruct as a byte array.</returns>
#if NET_4_5
        async protected Task<byte[]> HandlePacketAsync_GetServerInfo(byte[] RequestContent)
        {
            return StructUtils.StructToBytes(ServerManager.ServerInfo);
        }
#else
		protected byte[] HandlePacket_GetServerInfo(byte[] RequestContent)
		{
			return StructUtils.StructToBytes(ServerManager.ServerInfo);
		}
#endif
	}
}
