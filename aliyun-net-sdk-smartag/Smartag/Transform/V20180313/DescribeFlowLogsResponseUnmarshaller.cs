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
using Aliyun.Acs.Smartag.Model.V20180313;

namespace Aliyun.Acs.Smartag.Transform.V20180313
{
    public class DescribeFlowLogsResponseUnmarshaller
    {
        public static DescribeFlowLogsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeFlowLogsResponse describeFlowLogsResponse = new DescribeFlowLogsResponse();

			describeFlowLogsResponse.HttpResponse = context.HttpResponse;
			describeFlowLogsResponse.RequestId = context.StringValue("DescribeFlowLogs.RequestId");
			describeFlowLogsResponse.TotalCount = context.IntegerValue("DescribeFlowLogs.TotalCount");
			describeFlowLogsResponse.PageNumber = context.IntegerValue("DescribeFlowLogs.PageNumber");
			describeFlowLogsResponse.PageSize = context.IntegerValue("DescribeFlowLogs.PageSize");

			List<DescribeFlowLogsResponse.DescribeFlowLogs_FlowLogSetType> describeFlowLogsResponse_flowLogs = new List<DescribeFlowLogsResponse.DescribeFlowLogs_FlowLogSetType>();
			for (int i = 0; i < context.Length("DescribeFlowLogs.FlowLogs.Length"); i++) {
				DescribeFlowLogsResponse.DescribeFlowLogs_FlowLogSetType flowLogSetType = new DescribeFlowLogsResponse.DescribeFlowLogs_FlowLogSetType();
				flowLogSetType.FlowLogId = context.StringValue("DescribeFlowLogs.FlowLogs["+ i +"].FlowLogId");
				flowLogSetType.Description = context.StringValue("DescribeFlowLogs.FlowLogs["+ i +"].Description");
				flowLogSetType.ActiveAging = context.IntegerValue("DescribeFlowLogs.FlowLogs["+ i +"].ActiveAging");
				flowLogSetType.InactiveAging = context.IntegerValue("DescribeFlowLogs.FlowLogs["+ i +"].InactiveAging");
				flowLogSetType.OutputType = context.StringValue("DescribeFlowLogs.FlowLogs["+ i +"].OutputType");
				flowLogSetType.SlsRegionId = context.StringValue("DescribeFlowLogs.FlowLogs["+ i +"].SlsRegionId");
				flowLogSetType.ProjectName = context.StringValue("DescribeFlowLogs.FlowLogs["+ i +"].ProjectName");
				flowLogSetType.LogstoreName = context.StringValue("DescribeFlowLogs.FlowLogs["+ i +"].LogstoreName");
				flowLogSetType.NetflowServerIp = context.StringValue("DescribeFlowLogs.FlowLogs["+ i +"].NetflowServerIp");
				flowLogSetType.NetflowServerPort = context.StringValue("DescribeFlowLogs.FlowLogs["+ i +"].NetflowServerPort");
				flowLogSetType.NetflowVersion = context.StringValue("DescribeFlowLogs.FlowLogs["+ i +"].NetflowVersion");
				flowLogSetType.Status = context.StringValue("DescribeFlowLogs.FlowLogs["+ i +"].Status");
				flowLogSetType.Name = context.StringValue("DescribeFlowLogs.FlowLogs["+ i +"].Name");
				flowLogSetType.TotalSagNum = context.IntegerValue("DescribeFlowLogs.FlowLogs["+ i +"].TotalSagNum");

				describeFlowLogsResponse_flowLogs.Add(flowLogSetType);
			}
			describeFlowLogsResponse.FlowLogs = describeFlowLogsResponse_flowLogs;
        
			return describeFlowLogsResponse;
        }
    }
}
