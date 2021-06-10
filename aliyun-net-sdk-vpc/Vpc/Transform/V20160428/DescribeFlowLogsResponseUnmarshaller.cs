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
using Aliyun.Acs.Vpc.Model.V20160428;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class DescribeFlowLogsResponseUnmarshaller
    {
        public static DescribeFlowLogsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeFlowLogsResponse describeFlowLogsResponse = new DescribeFlowLogsResponse();

			describeFlowLogsResponse.HttpResponse = _ctx.HttpResponse;
			describeFlowLogsResponse.RequestId = _ctx.StringValue("DescribeFlowLogs.RequestId");
			describeFlowLogsResponse.Success = _ctx.StringValue("DescribeFlowLogs.Success");
			describeFlowLogsResponse.TotalCount = _ctx.StringValue("DescribeFlowLogs.TotalCount");
			describeFlowLogsResponse.PageNumber = _ctx.StringValue("DescribeFlowLogs.PageNumber");
			describeFlowLogsResponse.PageSize = _ctx.StringValue("DescribeFlowLogs.PageSize");

			List<DescribeFlowLogsResponse.DescribeFlowLogs_FlowLog> describeFlowLogsResponse_flowLogs = new List<DescribeFlowLogsResponse.DescribeFlowLogs_FlowLog>();
			for (int i = 0; i < _ctx.Length("DescribeFlowLogs.FlowLogs.Length"); i++) {
				DescribeFlowLogsResponse.DescribeFlowLogs_FlowLog flowLog = new DescribeFlowLogsResponse.DescribeFlowLogs_FlowLog();
				flowLog.FlowLogId = _ctx.StringValue("DescribeFlowLogs.FlowLogs["+ i +"].FlowLogId");
				flowLog.FlowLogName = _ctx.StringValue("DescribeFlowLogs.FlowLogs["+ i +"].FlowLogName");
				flowLog.Description = _ctx.StringValue("DescribeFlowLogs.FlowLogs["+ i +"].Description");
				flowLog.CreationTime = _ctx.StringValue("DescribeFlowLogs.FlowLogs["+ i +"].CreationTime");
				flowLog.ResourceType = _ctx.StringValue("DescribeFlowLogs.FlowLogs["+ i +"].ResourceType");
				flowLog.ResourceId = _ctx.StringValue("DescribeFlowLogs.FlowLogs["+ i +"].ResourceId");
				flowLog.ProjectName = _ctx.StringValue("DescribeFlowLogs.FlowLogs["+ i +"].ProjectName");
				flowLog.LogStoreName = _ctx.StringValue("DescribeFlowLogs.FlowLogs["+ i +"].LogStoreName");
				flowLog.Status = _ctx.StringValue("DescribeFlowLogs.FlowLogs["+ i +"].Status");
				flowLog.TrafficType = _ctx.StringValue("DescribeFlowLogs.FlowLogs["+ i +"].TrafficType");
				flowLog.RegionId = _ctx.StringValue("DescribeFlowLogs.FlowLogs["+ i +"].RegionId");

				describeFlowLogsResponse_flowLogs.Add(flowLog);
			}
			describeFlowLogsResponse.FlowLogs = describeFlowLogsResponse_flowLogs;
        
			return describeFlowLogsResponse;
        }
    }
}
