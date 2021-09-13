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
    public class ListNodeTransferPacketsResponseUnmarshaller
    {
        public static ListNodeTransferPacketsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListNodeTransferPacketsResponse listNodeTransferPacketsResponse = new ListNodeTransferPacketsResponse();

			listNodeTransferPacketsResponse.HttpResponse = _ctx.HttpResponse;
			listNodeTransferPacketsResponse.RequestId = _ctx.StringValue("ListNodeTransferPackets.RequestId");
			listNodeTransferPacketsResponse.Success = _ctx.BooleanValue("ListNodeTransferPackets.Success");

			ListNodeTransferPacketsResponse.ListNodeTransferPackets_Data data = new ListNodeTransferPacketsResponse.ListNodeTransferPackets_Data();
			data.TotalCount = _ctx.LongValue("ListNodeTransferPackets.Data.TotalCount");

			List<ListNodeTransferPacketsResponse.ListNodeTransferPackets_Data.ListNodeTransferPackets_Packet> data_list = new List<ListNodeTransferPacketsResponse.ListNodeTransferPackets_Data.ListNodeTransferPackets_Packet>();
			for (int i = 0; i < _ctx.Length("ListNodeTransferPackets.Data.List.Length"); i++) {
				ListNodeTransferPacketsResponse.ListNodeTransferPackets_Data.ListNodeTransferPackets_Packet packet = new ListNodeTransferPacketsResponse.ListNodeTransferPackets_Data.ListNodeTransferPackets_Packet();
				packet.GwEui = _ctx.StringValue("ListNodeTransferPackets.Data.List["+ i +"].GwEui");
				packet.DevEui = _ctx.StringValue("ListNodeTransferPackets.Data.List["+ i +"].DevEui");
				packet.Freq = _ctx.FloatValue("ListNodeTransferPackets.Data.List["+ i +"].Freq");
				packet.Datr = _ctx.StringValue("ListNodeTransferPackets.Data.List["+ i +"].Datr");
				packet.ClassMode = _ctx.StringValue("ListNodeTransferPackets.Data.List["+ i +"].ClassMode");
				packet.Rssi = _ctx.IntegerValue("ListNodeTransferPackets.Data.List["+ i +"].Rssi");
				packet.Snr = _ctx.FloatValue("ListNodeTransferPackets.Data.List["+ i +"].Snr");
				packet.LogMillis = _ctx.LongValue("ListNodeTransferPackets.Data.List["+ i +"].LogMillis");

				data_list.Add(packet);
			}
			data.List = data_list;
			listNodeTransferPacketsResponse.Data = data;
        
			return listNodeTransferPacketsResponse;
        }
    }
}
