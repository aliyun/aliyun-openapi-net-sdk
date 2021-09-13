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
    public class ListNodeGroupTransferPacketsResponseUnmarshaller
    {
        public static ListNodeGroupTransferPacketsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListNodeGroupTransferPacketsResponse listNodeGroupTransferPacketsResponse = new ListNodeGroupTransferPacketsResponse();

			listNodeGroupTransferPacketsResponse.HttpResponse = _ctx.HttpResponse;
			listNodeGroupTransferPacketsResponse.RequestId = _ctx.StringValue("ListNodeGroupTransferPackets.RequestId");
			listNodeGroupTransferPacketsResponse.Success = _ctx.BooleanValue("ListNodeGroupTransferPackets.Success");

			ListNodeGroupTransferPacketsResponse.ListNodeGroupTransferPackets_Data data = new ListNodeGroupTransferPacketsResponse.ListNodeGroupTransferPackets_Data();
			data.TotalCount = _ctx.LongValue("ListNodeGroupTransferPackets.Data.TotalCount");

			List<ListNodeGroupTransferPacketsResponse.ListNodeGroupTransferPackets_Data.ListNodeGroupTransferPackets_Packet> data_list = new List<ListNodeGroupTransferPacketsResponse.ListNodeGroupTransferPackets_Data.ListNodeGroupTransferPackets_Packet>();
			for (int i = 0; i < _ctx.Length("ListNodeGroupTransferPackets.Data.List.Length"); i++) {
				ListNodeGroupTransferPacketsResponse.ListNodeGroupTransferPackets_Data.ListNodeGroupTransferPackets_Packet packet = new ListNodeGroupTransferPacketsResponse.ListNodeGroupTransferPackets_Data.ListNodeGroupTransferPackets_Packet();
				packet.GwEui = _ctx.StringValue("ListNodeGroupTransferPackets.Data.List["+ i +"].GwEui");
				packet.DevEui = _ctx.StringValue("ListNodeGroupTransferPackets.Data.List["+ i +"].DevEui");
				packet.DevAddr = _ctx.StringValue("ListNodeGroupTransferPackets.Data.List["+ i +"].DevAddr");
				packet.Freq = _ctx.FloatValue("ListNodeGroupTransferPackets.Data.List["+ i +"].Freq");
				packet.Datr = _ctx.StringValue("ListNodeGroupTransferPackets.Data.List["+ i +"].Datr");
				packet.ClassMode = _ctx.StringValue("ListNodeGroupTransferPackets.Data.List["+ i +"].ClassMode");
				packet.Rssi = _ctx.IntegerValue("ListNodeGroupTransferPackets.Data.List["+ i +"].Rssi");
				packet.Lsnr = _ctx.FloatValue("ListNodeGroupTransferPackets.Data.List["+ i +"].Lsnr");
				packet.FPort = _ctx.IntegerValue("ListNodeGroupTransferPackets.Data.List["+ i +"].FPort");
				packet.GwOwnerAliyunId = _ctx.StringValue("ListNodeGroupTransferPackets.Data.List["+ i +"].GwOwnerAliyunId");
				packet.FreqBandPlanGroupId = _ctx.LongValue("ListNodeGroupTransferPackets.Data.List["+ i +"].FreqBandPlanGroupId");
				packet.LogMillis = _ctx.LongValue("ListNodeGroupTransferPackets.Data.List["+ i +"].LogMillis");
				packet.HasMacCommand = _ctx.BooleanValue("ListNodeGroupTransferPackets.Data.List["+ i +"].HasMacCommand");
				packet.HasData = _ctx.BooleanValue("ListNodeGroupTransferPackets.Data.List["+ i +"].HasData");
				packet.Base64EncodedMacPayload = _ctx.StringValue("ListNodeGroupTransferPackets.Data.List["+ i +"].Base64EncodedMacPayload");
				packet.MacPayloadSize = _ctx.LongValue("ListNodeGroupTransferPackets.Data.List["+ i +"].MacPayloadSize");
				packet.ProcessEvent = _ctx.StringValue("ListNodeGroupTransferPackets.Data.List["+ i +"].ProcessEvent");
				packet.MessageType = _ctx.StringValue("ListNodeGroupTransferPackets.Data.List["+ i +"].MessageType");
				packet.MacCommandCIDs = _ctx.StringValue("ListNodeGroupTransferPackets.Data.List["+ i +"].MacCommandCIDs");
				packet.FcntUp = _ctx.LongValue("ListNodeGroupTransferPackets.Data.List["+ i +"].FcntUp");
				packet.FcntDown = _ctx.LongValue("ListNodeGroupTransferPackets.Data.List["+ i +"].FcntDown");

				data_list.Add(packet);
			}
			data.List = data_list;
			listNodeGroupTransferPacketsResponse.Data = data;
        
			return listNodeGroupTransferPacketsResponse;
        }
    }
}
