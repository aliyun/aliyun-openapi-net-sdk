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
using Aliyun.Acs.aegis.Model.V20161111;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class DescribeStrategyExecDetailResponseUnmarshaller
    {
        public static DescribeStrategyExecDetailResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeStrategyExecDetailResponse describeStrategyExecDetailResponse = new DescribeStrategyExecDetailResponse();

			describeStrategyExecDetailResponse.HttpResponse = context.HttpResponse;
			describeStrategyExecDetailResponse.RequestId = context.StringValue("DescribeStrategyExecDetail.RequestId");
			describeStrategyExecDetailResponse.StartTime = context.StringValue("DescribeStrategyExecDetail.StartTime");
			describeStrategyExecDetailResponse.EndTime = context.StringValue("DescribeStrategyExecDetail.EndTime");
			describeStrategyExecDetailResponse.Source = context.StringValue("DescribeStrategyExecDetail.Source");
			describeStrategyExecDetailResponse.Percent = context.StringValue("DescribeStrategyExecDetail.Percent");
			describeStrategyExecDetailResponse.SuccessCount = context.IntegerValue("DescribeStrategyExecDetail.SuccessCount");
			describeStrategyExecDetailResponse.FailCount = context.IntegerValue("DescribeStrategyExecDetail.FailCount");
			describeStrategyExecDetailResponse.InProcessCount = context.IntegerValue("DescribeStrategyExecDetail.InProcessCount");

			List<DescribeStrategyExecDetailResponse.DescribeStrategyExecDetail_FailedEcs> describeStrategyExecDetailResponse_failedEcsList = new List<DescribeStrategyExecDetailResponse.DescribeStrategyExecDetail_FailedEcs>();
			for (int i = 0; i < context.Length("DescribeStrategyExecDetail.FailedEcsList.Length"); i++) {
				DescribeStrategyExecDetailResponse.DescribeStrategyExecDetail_FailedEcs failedEcs = new DescribeStrategyExecDetailResponse.DescribeStrategyExecDetail_FailedEcs();
				failedEcs.Reason = context.StringValue("DescribeStrategyExecDetail.FailedEcsList["+ i +"].Reason");
				failedEcs.InstanceName = context.StringValue("DescribeStrategyExecDetail.FailedEcsList["+ i +"].InstanceName");
				failedEcs.IP = context.StringValue("DescribeStrategyExecDetail.FailedEcsList["+ i +"].IP");
				failedEcs.IntranetIp = context.StringValue("DescribeStrategyExecDetail.FailedEcsList["+ i +"].IntranetIp");

				describeStrategyExecDetailResponse_failedEcsList.Add(failedEcs);
			}
			describeStrategyExecDetailResponse.FailedEcsList = describeStrategyExecDetailResponse_failedEcsList;
        
			return describeStrategyExecDetailResponse;
        }
    }
}
