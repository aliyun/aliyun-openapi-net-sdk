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
    public class ListTransferPacketResponseUnmarshaller
    {
        public static ListTransferPacketResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTransferPacketResponse listTransferPacketResponse = new ListTransferPacketResponse();

			listTransferPacketResponse.HttpResponse = _ctx.HttpResponse;
			listTransferPacketResponse.RequestId = _ctx.StringValue("ListTransferPacket.RequestId");
			listTransferPacketResponse.Success = _ctx.BooleanValue("ListTransferPacket.Success");
			listTransferPacketResponse.Code = _ctx.StringValue("ListTransferPacket.Code");
			listTransferPacketResponse.ErrorMessage = _ctx.StringValue("ListTransferPacket.ErrorMessage");

			ListTransferPacketResponse.ListTransferPacket_Data data = new ListTransferPacketResponse.ListTransferPacket_Data();
			data.TotalCount = _ctx.LongValue("ListTransferPacket.Data.TotalCount");

			List<ListTransferPacketResponse.ListTransferPacket_Data.ListTransferPacket_Packet> data_list = new List<ListTransferPacketResponse.ListTransferPacket_Data.ListTransferPacket_Packet>();
			for (int i = 0; i < _ctx.Length("ListTransferPacket.Data.List.Length"); i++) {
				ListTransferPacketResponse.ListTransferPacket_Data.ListTransferPacket_Packet packet = new ListTransferPacketResponse.ListTransferPacket_Data.ListTransferPacket_Packet();
				packet.GwEui = _ctx.StringValue("ListTransferPacket.Data.List["+ i +"].GwEui");
				packet.DevEui = _ctx.StringValue("ListTransferPacket.Data.List["+ i +"].DevEui");
				packet.DevAddr = _ctx.StringValue("ListTransferPacket.Data.List["+ i +"].DevAddr");
				packet.Freq = _ctx.FloatValue("ListTransferPacket.Data.List["+ i +"].Freq");
				packet.Datr = _ctx.StringValue("ListTransferPacket.Data.List["+ i +"].Datr");
				packet.ClassMode = _ctx.StringValue("ListTransferPacket.Data.List["+ i +"].ClassMode");
				packet.Rssi = _ctx.IntegerValue("ListTransferPacket.Data.List["+ i +"].Rssi");
				packet.Lsnr = _ctx.FloatValue("ListTransferPacket.Data.List["+ i +"].Lsnr");
				packet.FPort = _ctx.IntegerValue("ListTransferPacket.Data.List["+ i +"].FPort");
				packet.FreqBandPlanGroupId = _ctx.LongValue("ListTransferPacket.Data.List["+ i +"].FreqBandPlanGroupId");
				packet.LogMillis = _ctx.LongValue("ListTransferPacket.Data.List["+ i +"].LogMillis");
				packet.HasMacCommand = _ctx.BooleanValue("ListTransferPacket.Data.List["+ i +"].HasMacCommand");
				packet.HasData = _ctx.BooleanValue("ListTransferPacket.Data.List["+ i +"].HasData");
				packet.Base64EncodedMacPayload = _ctx.StringValue("ListTransferPacket.Data.List["+ i +"].Base64EncodedMacPayload");
				packet.MacPayloadSize = _ctx.LongValue("ListTransferPacket.Data.List["+ i +"].MacPayloadSize");
				packet.ProcessEvent = _ctx.StringValue("ListTransferPacket.Data.List["+ i +"].ProcessEvent");
				packet.MessageType = _ctx.StringValue("ListTransferPacket.Data.List["+ i +"].MessageType");
				packet.FcntDown = _ctx.LongValue("ListTransferPacket.Data.List["+ i +"].FcntDown");
				packet.FcntUp = _ctx.LongValue("ListTransferPacket.Data.List["+ i +"].FcntUp");

				data_list.Add(packet);
			}
			data.List = data_list;
			listTransferPacketResponse.Data = data;
        
			return listTransferPacketResponse;
        }
    }
}
