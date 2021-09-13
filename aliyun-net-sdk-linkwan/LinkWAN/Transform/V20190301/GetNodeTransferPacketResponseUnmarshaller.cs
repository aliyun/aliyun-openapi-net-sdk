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
    public class GetNodeTransferPacketResponseUnmarshaller
    {
        public static GetNodeTransferPacketResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetNodeTransferPacketResponse getNodeTransferPacketResponse = new GetNodeTransferPacketResponse();

			getNodeTransferPacketResponse.HttpResponse = _ctx.HttpResponse;
			getNodeTransferPacketResponse.RequestId = _ctx.StringValue("GetNodeTransferPacket.RequestId");
			getNodeTransferPacketResponse.Success = _ctx.BooleanValue("GetNodeTransferPacket.Success");

			GetNodeTransferPacketResponse.GetNodeTransferPacket_Data data = new GetNodeTransferPacketResponse.GetNodeTransferPacket_Data();
			data.LogMillis = _ctx.LongValue("GetNodeTransferPacket.Data.LogMillis");
			data.GwEui = _ctx.StringValue("GetNodeTransferPacket.Data.GwEui");
			data.DevEui = _ctx.StringValue("GetNodeTransferPacket.Data.DevEui");
			data.DevAddr = _ctx.StringValue("GetNodeTransferPacket.Data.DevAddr");
			data.Freq = _ctx.FloatValue("GetNodeTransferPacket.Data.Freq");
			data.Datr = _ctx.StringValue("GetNodeTransferPacket.Data.Datr");
			data.ClassMode = _ctx.StringValue("GetNodeTransferPacket.Data.ClassMode");
			data.Rssi = _ctx.IntegerValue("GetNodeTransferPacket.Data.Rssi");
			data.Lsnr = _ctx.FloatValue("GetNodeTransferPacket.Data.Lsnr");
			data.FPort = _ctx.IntegerValue("GetNodeTransferPacket.Data.FPort");
			data.FreqBandPlanGroupId = _ctx.LongValue("GetNodeTransferPacket.Data.FreqBandPlanGroupId");
			data.HasMacCommand = _ctx.BooleanValue("GetNodeTransferPacket.Data.HasMacCommand");
			data.HasData = _ctx.BooleanValue("GetNodeTransferPacket.Data.HasData");
			data.Base64EncodedMacPayload = _ctx.StringValue("GetNodeTransferPacket.Data.Base64EncodedMacPayload");
			data.MacPayloadSize = _ctx.IntegerValue("GetNodeTransferPacket.Data.MacPayloadSize");
			data.ProcessEvent = _ctx.StringValue("GetNodeTransferPacket.Data.ProcessEvent");
			data.MessageType = _ctx.StringValue("GetNodeTransferPacket.Data.MessageType");
			data.GwOwnerAliyunId = _ctx.StringValue("GetNodeTransferPacket.Data.GwOwnerAliyunId");

			List<Dictionary<string, string>> data_macCommandCIDs = new List<Dictionary<string, string>>();
			for (int i = 0; i < _ctx.Length("GetNodeTransferPacket.Data.MacCommandCIDs.Length"); i++) {
				Dictionary<string, string> tmp = new Dictionary<string, string>() { };
				foreach (var _item in _ctx.ResponseDictionary){
					string prefix = "GetNodeTransferPacket.Data.MacCommandCIDs["+ i +"].";
					if (_item.Key.IndexOf(prefix) == 0){
						tmp.Add(_item.Key.Substring(prefix.Length), _item.Value);
					}
				}
				if (tmp.Count > 0){
					data_macCommandCIDs.Add(tmp);
				}
			}
			data.MacCommandCIDs = data_macCommandCIDs;
			getNodeTransferPacketResponse.Data = data;
        
			return getNodeTransferPacketResponse;
        }
    }
}
