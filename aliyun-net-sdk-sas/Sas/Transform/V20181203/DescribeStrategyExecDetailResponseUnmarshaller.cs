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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeStrategyExecDetailResponseUnmarshaller
    {
        public static DescribeStrategyExecDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeStrategyExecDetailResponse describeStrategyExecDetailResponse = new DescribeStrategyExecDetailResponse();

			describeStrategyExecDetailResponse.HttpResponse = _ctx.HttpResponse;
			describeStrategyExecDetailResponse.InProcessCount = _ctx.IntegerValue("DescribeStrategyExecDetail.InProcessCount");
			describeStrategyExecDetailResponse.EndTime = _ctx.StringValue("DescribeStrategyExecDetail.EndTime");
			describeStrategyExecDetailResponse.StartTime = _ctx.StringValue("DescribeStrategyExecDetail.StartTime");
			describeStrategyExecDetailResponse.Percent = _ctx.StringValue("DescribeStrategyExecDetail.Percent");
			describeStrategyExecDetailResponse.RequestId = _ctx.StringValue("DescribeStrategyExecDetail.RequestId");
			describeStrategyExecDetailResponse.FailCount = _ctx.IntegerValue("DescribeStrategyExecDetail.FailCount");
			describeStrategyExecDetailResponse.Source = _ctx.StringValue("DescribeStrategyExecDetail.Source");
			describeStrategyExecDetailResponse.SuccessCount = _ctx.IntegerValue("DescribeStrategyExecDetail.SuccessCount");

			List<DescribeStrategyExecDetailResponse.DescribeStrategyExecDetail_FailedEcs> describeStrategyExecDetailResponse_failedEcsList = new List<DescribeStrategyExecDetailResponse.DescribeStrategyExecDetail_FailedEcs>();
			for (int i = 0; i < _ctx.Length("DescribeStrategyExecDetail.FailedEcsList.Length"); i++) {
				DescribeStrategyExecDetailResponse.DescribeStrategyExecDetail_FailedEcs failedEcs = new DescribeStrategyExecDetailResponse.DescribeStrategyExecDetail_FailedEcs();
				failedEcs.IP = _ctx.StringValue("DescribeStrategyExecDetail.FailedEcsList["+ i +"].IP");
				failedEcs.InternetIp = _ctx.StringValue("DescribeStrategyExecDetail.FailedEcsList["+ i +"].InternetIp");
				failedEcs.IntranetIp = _ctx.StringValue("DescribeStrategyExecDetail.FailedEcsList["+ i +"].IntranetIp");
				failedEcs.Reason = _ctx.StringValue("DescribeStrategyExecDetail.FailedEcsList["+ i +"].Reason");
				failedEcs.InstanceName = _ctx.StringValue("DescribeStrategyExecDetail.FailedEcsList["+ i +"].InstanceName");

				describeStrategyExecDetailResponse_failedEcsList.Add(failedEcs);
			}
			describeStrategyExecDetailResponse.FailedEcsList = describeStrategyExecDetailResponse_failedEcsList;
        
			return describeStrategyExecDetailResponse;
        }
    }
}
