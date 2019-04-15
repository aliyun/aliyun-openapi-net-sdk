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
    public class DescribeOperateInfoResponseUnmarshaller
    {
        public static DescribeOperateInfoResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeOperateInfoResponse describeOperateInfoResponse = new DescribeOperateInfoResponse();

			describeOperateInfoResponse.HttpResponse = context.HttpResponse;
			describeOperateInfoResponse.RequestId = context.StringValue("DescribeOperateInfo.RequestId");
			describeOperateInfoResponse.HealthCheckDealedCount = context.IntegerValue("DescribeOperateInfo.HealthCheckDealedCount");
			describeOperateInfoResponse.SecurityEventDealedCount = context.IntegerValue("DescribeOperateInfo.SecurityEventDealedCount");
			describeOperateInfoResponse.VulnerabilityDealedCount = context.IntegerValue("DescribeOperateInfo.VulnerabilityDealedCount");
			describeOperateInfoResponse.Success = context.BooleanValue("DescribeOperateInfo.Success");

			List<string> describeOperateInfoResponse_suspEventValueArray = new List<string>();
			for (int i = 0; i < context.Length("DescribeOperateInfo.SuspEventValueArray.Length"); i++) {
				describeOperateInfoResponse_suspEventValueArray.Add(context.StringValue("DescribeOperateInfo.SuspEventValueArray["+ i +"]"));
			}
			describeOperateInfoResponse.SuspEventValueArray = describeOperateInfoResponse_suspEventValueArray;

			List<string> describeOperateInfoResponse_suspEventAaggregatValueArray = new List<string>();
			for (int i = 0; i < context.Length("DescribeOperateInfo.SuspEventAaggregatValueArray.Length"); i++) {
				describeOperateInfoResponse_suspEventAaggregatValueArray.Add(context.StringValue("DescribeOperateInfo.SuspEventAaggregatValueArray["+ i +"]"));
			}
			describeOperateInfoResponse.SuspEventAaggregatValueArray = describeOperateInfoResponse_suspEventAaggregatValueArray;

			List<string> describeOperateInfoResponse_vulValueArray = new List<string>();
			for (int i = 0; i < context.Length("DescribeOperateInfo.VulValueArray.Length"); i++) {
				describeOperateInfoResponse_vulValueArray.Add(context.StringValue("DescribeOperateInfo.VulValueArray["+ i +"]"));
			}
			describeOperateInfoResponse.VulValueArray = describeOperateInfoResponse_vulValueArray;

			List<string> describeOperateInfoResponse_vulAaggregatValueArray = new List<string>();
			for (int i = 0; i < context.Length("DescribeOperateInfo.VulAaggregatValueArray.Length"); i++) {
				describeOperateInfoResponse_vulAaggregatValueArray.Add(context.StringValue("DescribeOperateInfo.VulAaggregatValueArray["+ i +"]"));
			}
			describeOperateInfoResponse.VulAaggregatValueArray = describeOperateInfoResponse_vulAaggregatValueArray;

			List<string> describeOperateInfoResponse_dateArray = new List<string>();
			for (int i = 0; i < context.Length("DescribeOperateInfo.DateArray.Length"); i++) {
				describeOperateInfoResponse_dateArray.Add(context.StringValue("DescribeOperateInfo.DateArray["+ i +"]"));
			}
			describeOperateInfoResponse.DateArray = describeOperateInfoResponse_dateArray;

			List<string> describeOperateInfoResponse_healthCheckValueArray = new List<string>();
			for (int i = 0; i < context.Length("DescribeOperateInfo.HealthCheckValueArray.Length"); i++) {
				describeOperateInfoResponse_healthCheckValueArray.Add(context.StringValue("DescribeOperateInfo.HealthCheckValueArray["+ i +"]"));
			}
			describeOperateInfoResponse.HealthCheckValueArray = describeOperateInfoResponse_healthCheckValueArray;

			List<string> describeOperateInfoResponse_healthCheckAaggregatValueArray = new List<string>();
			for (int i = 0; i < context.Length("DescribeOperateInfo.HealthCheckAaggregatValueArray.Length"); i++) {
				describeOperateInfoResponse_healthCheckAaggregatValueArray.Add(context.StringValue("DescribeOperateInfo.HealthCheckAaggregatValueArray["+ i +"]"));
			}
			describeOperateInfoResponse.HealthCheckAaggregatValueArray = describeOperateInfoResponse_healthCheckAaggregatValueArray;
        
			return describeOperateInfoResponse;
        }
    }
}
