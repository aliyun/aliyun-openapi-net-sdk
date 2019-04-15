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
    public class DescribeScreenOperateInfoResponseUnmarshaller
    {
        public static DescribeScreenOperateInfoResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeScreenOperateInfoResponse describeScreenOperateInfoResponse = new DescribeScreenOperateInfoResponse();

			describeScreenOperateInfoResponse.HttpResponse = context.HttpResponse;
			describeScreenOperateInfoResponse.RequestId = context.StringValue("DescribeScreenOperateInfo.RequestId");
			describeScreenOperateInfoResponse.HealthCheckDealedCount = context.IntegerValue("DescribeScreenOperateInfo.HealthCheckDealedCount");
			describeScreenOperateInfoResponse.SecurityEventDealedCount = context.IntegerValue("DescribeScreenOperateInfo.SecurityEventDealedCount");
			describeScreenOperateInfoResponse.VulnerabilityDealedCount = context.IntegerValue("DescribeScreenOperateInfo.VulnerabilityDealedCount");
			describeScreenOperateInfoResponse.Success = context.BooleanValue("DescribeScreenOperateInfo.Success");

			List<string> describeScreenOperateInfoResponse_suspEventValueArray = new List<string>();
			for (int i = 0; i < context.Length("DescribeScreenOperateInfo.SuspEventValueArray.Length"); i++) {
				describeScreenOperateInfoResponse_suspEventValueArray.Add(context.StringValue("DescribeScreenOperateInfo.SuspEventValueArray["+ i +"]"));
			}
			describeScreenOperateInfoResponse.SuspEventValueArray = describeScreenOperateInfoResponse_suspEventValueArray;

			List<string> describeScreenOperateInfoResponse_vulValueArray = new List<string>();
			for (int i = 0; i < context.Length("DescribeScreenOperateInfo.VulValueArray.Length"); i++) {
				describeScreenOperateInfoResponse_vulValueArray.Add(context.StringValue("DescribeScreenOperateInfo.VulValueArray["+ i +"]"));
			}
			describeScreenOperateInfoResponse.VulValueArray = describeScreenOperateInfoResponse_vulValueArray;

			List<string> describeScreenOperateInfoResponse_dateArray = new List<string>();
			for (int i = 0; i < context.Length("DescribeScreenOperateInfo.DateArray.Length"); i++) {
				describeScreenOperateInfoResponse_dateArray.Add(context.StringValue("DescribeScreenOperateInfo.DateArray["+ i +"]"));
			}
			describeScreenOperateInfoResponse.DateArray = describeScreenOperateInfoResponse_dateArray;

			List<string> describeScreenOperateInfoResponse_healthCheckValueArray = new List<string>();
			for (int i = 0; i < context.Length("DescribeScreenOperateInfo.HealthCheckValueArray.Length"); i++) {
				describeScreenOperateInfoResponse_healthCheckValueArray.Add(context.StringValue("DescribeScreenOperateInfo.HealthCheckValueArray["+ i +"]"));
			}
			describeScreenOperateInfoResponse.HealthCheckValueArray = describeScreenOperateInfoResponse_healthCheckValueArray;
        
			return describeScreenOperateInfoResponse;
        }
    }
}
