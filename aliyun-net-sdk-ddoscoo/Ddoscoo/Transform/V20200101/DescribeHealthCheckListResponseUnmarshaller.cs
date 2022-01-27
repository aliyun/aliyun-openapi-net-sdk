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
using Aliyun.Acs.ddoscoo.Model.V20200101;

namespace Aliyun.Acs.ddoscoo.Transform.V20200101
{
    public class DescribeHealthCheckListResponseUnmarshaller
    {
        public static DescribeHealthCheckListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeHealthCheckListResponse describeHealthCheckListResponse = new DescribeHealthCheckListResponse();

			describeHealthCheckListResponse.HttpResponse = _ctx.HttpResponse;
			describeHealthCheckListResponse.RequestId = _ctx.StringValue("DescribeHealthCheckList.RequestId");

			List<DescribeHealthCheckListResponse.DescribeHealthCheckList_HealthCheckItem> describeHealthCheckListResponse_healthCheckList = new List<DescribeHealthCheckListResponse.DescribeHealthCheckList_HealthCheckItem>();
			for (int i = 0; i < _ctx.Length("DescribeHealthCheckList.HealthCheckList.Length"); i++) {
				DescribeHealthCheckListResponse.DescribeHealthCheckList_HealthCheckItem healthCheckItem = new DescribeHealthCheckListResponse.DescribeHealthCheckList_HealthCheckItem();
				healthCheckItem.InstanceId = _ctx.StringValue("DescribeHealthCheckList.HealthCheckList["+ i +"].InstanceId");
				healthCheckItem.Protocol = _ctx.StringValue("DescribeHealthCheckList.HealthCheckList["+ i +"].Protocol");
				healthCheckItem.FrontendPort = _ctx.IntegerValue("DescribeHealthCheckList.HealthCheckList["+ i +"].FrontendPort");

				DescribeHealthCheckListResponse.DescribeHealthCheckList_HealthCheckItem.DescribeHealthCheckList_HealthCheck healthCheck = new DescribeHealthCheckListResponse.DescribeHealthCheckList_HealthCheckItem.DescribeHealthCheckList_HealthCheck();
				healthCheck.Type = _ctx.StringValue("DescribeHealthCheckList.HealthCheckList["+ i +"].HealthCheck.Type");
				healthCheck.Domain = _ctx.StringValue("DescribeHealthCheckList.HealthCheckList["+ i +"].HealthCheck.Domain");
				healthCheck.Uri = _ctx.StringValue("DescribeHealthCheckList.HealthCheckList["+ i +"].HealthCheck.Uri");
				healthCheck.Down = _ctx.IntegerValue("DescribeHealthCheckList.HealthCheckList["+ i +"].HealthCheck.Down");
				healthCheck.Interval = _ctx.IntegerValue("DescribeHealthCheckList.HealthCheckList["+ i +"].HealthCheck.Interval");
				healthCheck.Port = _ctx.IntegerValue("DescribeHealthCheckList.HealthCheckList["+ i +"].HealthCheck.Port");
				healthCheck.Timeout = _ctx.IntegerValue("DescribeHealthCheckList.HealthCheckList["+ i +"].HealthCheck.Timeout");
				healthCheck.Up = _ctx.IntegerValue("DescribeHealthCheckList.HealthCheckList["+ i +"].HealthCheck.Up");
				healthCheckItem.HealthCheck = healthCheck;

				describeHealthCheckListResponse_healthCheckList.Add(healthCheckItem);
			}
			describeHealthCheckListResponse.HealthCheckList = describeHealthCheckListResponse_healthCheckList;
        
			return describeHealthCheckListResponse;
        }
    }
}
