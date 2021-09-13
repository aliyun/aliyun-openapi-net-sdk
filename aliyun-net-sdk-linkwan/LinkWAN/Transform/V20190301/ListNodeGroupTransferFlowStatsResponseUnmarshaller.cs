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
    public class ListNodeGroupTransferFlowStatsResponseUnmarshaller
    {
        public static ListNodeGroupTransferFlowStatsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListNodeGroupTransferFlowStatsResponse listNodeGroupTransferFlowStatsResponse = new ListNodeGroupTransferFlowStatsResponse();

			listNodeGroupTransferFlowStatsResponse.HttpResponse = _ctx.HttpResponse;
			listNodeGroupTransferFlowStatsResponse.RequestId = _ctx.StringValue("ListNodeGroupTransferFlowStats.RequestId");
			listNodeGroupTransferFlowStatsResponse.Success = _ctx.BooleanValue("ListNodeGroupTransferFlowStats.Success");

			List<ListNodeGroupTransferFlowStatsResponse.ListNodeGroupTransferFlowStats_FlowStat> listNodeGroupTransferFlowStatsResponse_data = new List<ListNodeGroupTransferFlowStatsResponse.ListNodeGroupTransferFlowStats_FlowStat>();
			for (int i = 0; i < _ctx.Length("ListNodeGroupTransferFlowStats.Data.Length"); i++) {
				ListNodeGroupTransferFlowStatsResponse.ListNodeGroupTransferFlowStats_FlowStat flowStat = new ListNodeGroupTransferFlowStatsResponse.ListNodeGroupTransferFlowStats_FlowStat();
				flowStat.StatMillis = _ctx.LongValue("ListNodeGroupTransferFlowStats.Data["+ i +"].StatMillis");
				flowStat.UplinkCount = _ctx.LongValue("ListNodeGroupTransferFlowStats.Data["+ i +"].UplinkCount");
				flowStat.DownlinkCount = _ctx.LongValue("ListNodeGroupTransferFlowStats.Data["+ i +"].DownlinkCount");

				listNodeGroupTransferFlowStatsResponse_data.Add(flowStat);
			}
			listNodeGroupTransferFlowStatsResponse.Data = listNodeGroupTransferFlowStatsResponse_data;
        
			return listNodeGroupTransferFlowStatsResponse;
        }
    }
}
