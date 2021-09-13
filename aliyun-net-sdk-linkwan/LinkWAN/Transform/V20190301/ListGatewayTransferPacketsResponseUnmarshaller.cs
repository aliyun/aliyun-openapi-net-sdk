/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.LinkWAN.Model.V20190301;

namespace Aliyun.Acs.LinkWAN.Transform.V20190301
{
    public class ListGatewayTransferPacketsResponseUnmarshaller
    {
        public static ListGatewayTransferPacketsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListGatewayTransferPacketsResponse listGatewayTransferPacketsResponse = new ListGatewayTransferPacketsResponse();

			listGatewayTransferPacketsResponse.HttpResponse = _ctx.HttpResponse;
			listGatewayTransferPacketsResponse.RequestId = _ctx.StringValue("ListGatewayTransferPackets.RequestId");
			listGatewayTransferPacketsResponse.Success = _ctx.BooleanValue("ListGatewayTransferPackets.Success");

			ListGatewayTransferPacketsResponse.ListGatewayTransferPackets_Data data = new ListGatewayTransferPacketsResponse.ListGatewayTransferPackets_Data();
			data.TotalCount = _ctx.LongValue("ListGatewayTransferPackets.Data.TotalCount");

			List<ListGatewayTransferPacketsResponse.ListGatewayTransferPackets_Data.ListGatewayTransferPackets_Packet> data_list = new List<ListGatewayTransferPacketsResponse.ListGatewayTransferPackets_Data.ListGatewayTransferPackets_Packet>();
			for (int i = 0; i < _ctx.Length("ListGatewayTransferPackets.Data.List.Length"); i++) {
				ListGatewayTransferPacketsResponse.ListGatewayTransferPackets_Data.ListGatewayTransferPackets_Packet packet = new ListGatewayTransferPacketsResponse.ListGatewayTransferPackets_Data.ListGatewayTransferPackets_Packet();
				packet.GwEui = _ctx.StringValue("ListGatewayTransferPackets.Data.List["+ i +"].GwEui");
				packet.DevEui = _ctx.StringValue("ListGatewayTransferPackets.Data.List["+ i +"].DevEui");
				packet.LogMillis = _ctx.StringValue("ListGatewayTransferPackets.Data.List["+ i +"].LogMillis");
				packet.DevAddr = _ctx.StringValue("ListGatewayTransferPackets.Data.List["+ i +"].DevAddr");
				packet.Freq = _ctx.StringValue("ListGatewayTransferPackets.Data.List["+ i +"].Freq");
				packet.Datr = _ctx.StringValue("ListGatewayTransferPackets.Data.List["+ i +"].Datr");
				packet.ClassMode = _ctx.StringValue("ListGatewayTransferPackets.Data.List["+ i +"].ClassMode");
				packet.Rssi = _ctx.IntegerValue("ListGatewayTransferPackets.Data.List["+ i +"].Rssi");
				packet.Lsnr = _ctx.FloatValue("ListGatewayTransferPackets.Data.List["+ i +"].Lsnr");
				packet.FPort = _ctx.IntegerValue("ListGatewayTransferPackets.Data.List["+ i +"].FPort");
				packet.HasMacCommand = _ctx.BooleanValue("ListGatewayTransferPackets.Data.List["+ i +"].HasMacCommand");
				packet.HasData = _ctx.BooleanValue("ListGatewayTransferPackets.Data.List["+ i +"].HasData");
				packet.Base64EncodedMacPayload = _ctx.StringValue("ListGatewayTransferPackets.Data.List["+ i +"].Base64EncodedMacPayload");
				packet.MacPayloadSize = _ctx.LongValue("ListGatewayTransferPackets.Data.List["+ i +"].MacPayloadSize");
				packet.ProcessEvent = _ctx.StringValue("ListGatewayTransferPackets.Data.List["+ i +"].ProcessEvent");
				packet.MessageType = _ctx.StringValue("ListGatewayTransferPackets.Data.List["+ i +"].MessageType");
				packet.NodeOwnerAliyunId = _ctx.StringValue("ListGatewayTransferPackets.Data.List["+ i +"].NodeOwnerAliyunId");

				List<Dictionary<string, string>> packet_macCommandCIDs = new List<Dictionary<string, string>>();
				for (int j = 0; j < _ctx.Length("ListGatewayTransferPackets.Data.List["+ i +"].MacCommandCIDs.Length"); j++) {
					Dictionary<string, string> tmp = new Dictionary<string, string>() { };
					foreach (var _item in _ctx.ResponseDictionary){
						string prefix = "ListGatewayTransferPackets.Data.List["+ i +"].MacCommandCIDs["+ j +"].";
						if (_item.Key.IndexOf(prefix) == 0){
							tmp.Add(_item.Key.Substring(prefix.Length), _item.Value);
						}
					}
					if (tmp.Count > 0){
						packet_macCommandCIDs.Add(tmp);
					}
				}
				packet.MacCommandCIDs = packet_macCommandCIDs;

				data_list.Add(packet);
			}
			data.List = data_list;
			listGatewayTransferPacketsResponse.Data = data;
        
			return listGatewayTransferPacketsResponse;
        }
    }
}
