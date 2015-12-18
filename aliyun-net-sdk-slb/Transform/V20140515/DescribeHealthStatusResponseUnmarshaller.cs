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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Slb.Model.V20140515;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Slb.Transform.V20140515
{
    public class DescribeHealthStatusResponseUnmarshaller
    {
        public static DescribeHealthStatusResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeHealthStatusResponse describeHealthStatusResponse = new DescribeHealthStatusResponse();

			describeHealthStatusResponse.HttpResponse = context.HttpResponse;
			describeHealthStatusResponse.RequestId = context.StringValue("DescribeHealthStatus.RequestId");

			List<DescribeHealthStatusResponse.BackendServer> backendServers = new List<DescribeHealthStatusResponse.BackendServer>();
			for (int i = 0; i < context.Length("DescribeHealthStatus.BackendServers.Length"); i++) {
				DescribeHealthStatusResponse.BackendServer backendServer = new DescribeHealthStatusResponse.BackendServer();
				backendServer.ServerId = context.StringValue("DescribeHealthStatus.BackendServers["+ i +"].ServerId");
				backendServer.ServerHealthStatus = context.StringValue("DescribeHealthStatus.BackendServers["+ i +"].ServerHealthStatus");

				backendServers.Add(backendServer);
			}
			describeHealthStatusResponse.BackendServers = backendServers;
        
			return describeHealthStatusResponse;
        }
    }
}