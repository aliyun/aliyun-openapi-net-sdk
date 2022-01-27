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
    public class ListGatewayTransferFlowStatsResponseUnmarshaller
    {
        public static ListGatewayTransferFlowStatsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListGatewayTransferFlowStatsResponse listGatewayTransferFlowStatsResponse = new ListGatewayTransferFlowStatsResponse();

			listGatewayTransferFlowStatsResponse.HttpResponse = _ctx.HttpResponse;
			listGatewayTransferFlowStatsResponse.RequestId = _ctx.StringValue("ListGatewayTransferFlowStats.RequestId");
			listGatewayTransferFlowStatsResponse.Success = _ctx.BooleanValue("ListGatewayTransferFlowStats.Success");

			List<ListGatewayTransferFlowStatsResponse.ListGatewayTransferFlowStats_FlowStat> listGatewayTransferFlowStatsResponse_data = new List<ListGatewayTransferFlowStatsResponse.ListGatewayTransferFlowStats_FlowStat>();
			for (int i = 0; i < _ctx.Length("ListGatewayTransferFlowStats.Data.Length"); i++) {
				ListGatewayTransferFlowStatsResponse.ListGatewayTransferFlowStats_FlowStat flowStat = new ListGatewayTransferFlowStatsResponse.ListGatewayTransferFlowStats_FlowStat();
				flowStat.StatMillis = _ctx.StringValue("ListGatewayTransferFlowStats.Data["+ i +"].StatMillis");
				flowStat.UplinkCount = _ctx.LongValue("ListGatewayTransferFlowStats.Data["+ i +"].UplinkCount");
				flowStat.DownlinkCount = _ctx.LongValue("ListGatewayTransferFlowStats.Data["+ i +"].DownlinkCount");

				listGatewayTransferFlowStatsResponse_data.Add(flowStat);
			}
			listGatewayTransferFlowStatsResponse.Data = listGatewayTransferFlowStatsResponse_data;
        
			return listGatewayTransferFlowStatsResponse;
        }
    }
}
