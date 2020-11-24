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
    public class DescribeHealthCheckStatusResponseUnmarshaller
    {
        public static DescribeHealthCheckStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeHealthCheckStatusResponse describeHealthCheckStatusResponse = new DescribeHealthCheckStatusResponse();

			describeHealthCheckStatusResponse.HttpResponse = _ctx.HttpResponse;
			describeHealthCheckStatusResponse.RequestId = _ctx.StringValue("DescribeHealthCheckStatus.RequestId");

			List<DescribeHealthCheckStatusResponse.DescribeHealthCheckStatus_Status> describeHealthCheckStatusResponse_healthCheckStatus = new List<DescribeHealthCheckStatusResponse.DescribeHealthCheckStatus_Status>();
			for (int i = 0; i < _ctx.Length("DescribeHealthCheckStatus.HealthCheckStatus.Length"); i++) {
				DescribeHealthCheckStatusResponse.DescribeHealthCheckStatus_Status status = new DescribeHealthCheckStatusResponse.DescribeHealthCheckStatus_Status();
				status.InstanceId = _ctx.StringValue("DescribeHealthCheckStatus.HealthCheckStatus["+ i +"].InstanceId");
				status.Protocol = _ctx.StringValue("DescribeHealthCheckStatus.HealthCheckStatus["+ i +"].Protocol");
				status.FrontendPort = _ctx.IntegerValue("DescribeHealthCheckStatus.HealthCheckStatus["+ i +"].FrontendPort");
				status.Status = _ctx.StringValue("DescribeHealthCheckStatus.HealthCheckStatus["+ i +"].Status");

				List<DescribeHealthCheckStatusResponse.DescribeHealthCheckStatus_Status.DescribeHealthCheckStatus_RealServerStatus> status_realServerStatusList = new List<DescribeHealthCheckStatusResponse.DescribeHealthCheckStatus_Status.DescribeHealthCheckStatus_RealServerStatus>();
				for (int j = 0; j < _ctx.Length("DescribeHealthCheckStatus.HealthCheckStatus["+ i +"].RealServerStatusList.Length"); j++) {
					DescribeHealthCheckStatusResponse.DescribeHealthCheckStatus_Status.DescribeHealthCheckStatus_RealServerStatus realServerStatus = new DescribeHealthCheckStatusResponse.DescribeHealthCheckStatus_Status.DescribeHealthCheckStatus_RealServerStatus();
					realServerStatus.Address = _ctx.StringValue("DescribeHealthCheckStatus.HealthCheckStatus["+ i +"].RealServerStatusList["+ j +"].Address");
					realServerStatus.Status = _ctx.StringValue("DescribeHealthCheckStatus.HealthCheckStatus["+ i +"].RealServerStatusList["+ j +"].Status");

					status_realServerStatusList.Add(realServerStatus);
				}
				status.RealServerStatusList = status_realServerStatusList;

				describeHealthCheckStatusResponse_healthCheckStatus.Add(status);
			}
			describeHealthCheckStatusResponse.HealthCheckStatus = describeHealthCheckStatusResponse_healthCheckStatus;
        
			return describeHealthCheckStatusResponse;
        }
    }
}
