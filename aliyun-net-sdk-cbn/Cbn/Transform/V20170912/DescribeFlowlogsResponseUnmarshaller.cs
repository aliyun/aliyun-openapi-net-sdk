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
using Aliyun.Acs.Cbn.Model.V20170912;

namespace Aliyun.Acs.Cbn.Transform.V20170912
{
    public class DescribeFlowlogsResponseUnmarshaller
    {
        public static DescribeFlowlogsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeFlowlogsResponse describeFlowlogsResponse = new DescribeFlowlogsResponse();

			describeFlowlogsResponse.HttpResponse = _ctx.HttpResponse;
			describeFlowlogsResponse.RequestId = _ctx.StringValue("DescribeFlowlogs.RequestId");
			describeFlowlogsResponse.Success = _ctx.StringValue("DescribeFlowlogs.Success");
			describeFlowlogsResponse.TotalCount = _ctx.StringValue("DescribeFlowlogs.TotalCount");
			describeFlowlogsResponse.PageNumber = _ctx.StringValue("DescribeFlowlogs.PageNumber");
			describeFlowlogsResponse.PageSize = _ctx.StringValue("DescribeFlowlogs.PageSize");

			List<DescribeFlowlogsResponse.DescribeFlowlogs_FlowLog> describeFlowlogsResponse_flowLogs = new List<DescribeFlowlogsResponse.DescribeFlowlogs_FlowLog>();
			for (int i = 0; i < _ctx.Length("DescribeFlowlogs.FlowLogs.Length"); i++) {
				DescribeFlowlogsResponse.DescribeFlowlogs_FlowLog flowLog = new DescribeFlowlogsResponse.DescribeFlowlogs_FlowLog();
				flowLog.FlowLogId = _ctx.StringValue("DescribeFlowlogs.FlowLogs["+ i +"].FlowLogId");
				flowLog.FlowLogName = _ctx.StringValue("DescribeFlowlogs.FlowLogs["+ i +"].FlowLogName");
				flowLog.Description = _ctx.StringValue("DescribeFlowlogs.FlowLogs["+ i +"].Description");
				flowLog.CreationTime = _ctx.StringValue("DescribeFlowlogs.FlowLogs["+ i +"].CreationTime");
				flowLog.CenId = _ctx.StringValue("DescribeFlowlogs.FlowLogs["+ i +"].CenId");
				flowLog.ProjectName = _ctx.StringValue("DescribeFlowlogs.FlowLogs["+ i +"].ProjectName");
				flowLog.LogStoreName = _ctx.StringValue("DescribeFlowlogs.FlowLogs["+ i +"].LogStoreName");
				flowLog.Status = _ctx.StringValue("DescribeFlowlogs.FlowLogs["+ i +"].Status");
				flowLog.RegionId = _ctx.StringValue("DescribeFlowlogs.FlowLogs["+ i +"].RegionId");

				describeFlowlogsResponse_flowLogs.Add(flowLog);
			}
			describeFlowlogsResponse.FlowLogs = describeFlowlogsResponse_flowLogs;
        
			return describeFlowlogsResponse;
        }
    }
}
