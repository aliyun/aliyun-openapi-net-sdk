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
    public class ListGatewaysPacketStatResponseUnmarshaller
    {
        public static ListGatewaysPacketStatResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListGatewaysPacketStatResponse listGatewaysPacketStatResponse = new ListGatewaysPacketStatResponse();

			listGatewaysPacketStatResponse.HttpResponse = _ctx.HttpResponse;
			listGatewaysPacketStatResponse.RequestId = _ctx.StringValue("ListGatewaysPacketStat.RequestId");
			listGatewaysPacketStatResponse.Success = _ctx.BooleanValue("ListGatewaysPacketStat.Success");

			List<ListGatewaysPacketStatResponse.ListGatewaysPacketStat_GatewayPacketStat> listGatewaysPacketStatResponse_data = new List<ListGatewaysPacketStatResponse.ListGatewaysPacketStat_GatewayPacketStat>();
			for (int i = 0; i < _ctx.Length("ListGatewaysPacketStat.Data.Length"); i++) {
				ListGatewaysPacketStatResponse.ListGatewaysPacketStat_GatewayPacketStat gatewayPacketStat = new ListGatewaysPacketStatResponse.ListGatewaysPacketStat_GatewayPacketStat();
				gatewayPacketStat.GwEui = _ctx.StringValue("ListGatewaysPacketStat.Data["+ i +"].GwEui");
				gatewayPacketStat.UplinkCount = _ctx.IntegerValue("ListGatewaysPacketStat.Data["+ i +"].UplinkCount");
				gatewayPacketStat.DownlinkCount = _ctx.IntegerValue("ListGatewaysPacketStat.Data["+ i +"].DownlinkCount");

				listGatewaysPacketStatResponse_data.Add(gatewayPacketStat);
			}
			listGatewaysPacketStatResponse.Data = listGatewaysPacketStatResponse_data;
        
			return listGatewaysPacketStatResponse;
        }
    }
}
