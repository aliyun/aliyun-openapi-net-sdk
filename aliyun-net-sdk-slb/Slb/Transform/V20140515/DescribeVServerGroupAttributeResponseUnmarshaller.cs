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
using Aliyun.Acs.Slb.Model.V20140515;

namespace Aliyun.Acs.Slb.Transform.V20140515
{
    public class DescribeVServerGroupAttributeResponseUnmarshaller
    {
        public static DescribeVServerGroupAttributeResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVServerGroupAttributeResponse describeVServerGroupAttributeResponse = new DescribeVServerGroupAttributeResponse();

			describeVServerGroupAttributeResponse.HttpResponse = context.HttpResponse;
			describeVServerGroupAttributeResponse.RequestId = context.StringValue("DescribeVServerGroupAttribute.RequestId");
			describeVServerGroupAttributeResponse.VServerGroupId = context.StringValue("DescribeVServerGroupAttribute.VServerGroupId");
			describeVServerGroupAttributeResponse.VServerGroupName = context.StringValue("DescribeVServerGroupAttribute.VServerGroupName");
			describeVServerGroupAttributeResponse.LoadBalancerId = context.StringValue("DescribeVServerGroupAttribute.LoadBalancerId");

			List<DescribeVServerGroupAttributeResponse.DescribeVServerGroupAttribute_BackendServer> describeVServerGroupAttributeResponse_backendServers = new List<DescribeVServerGroupAttributeResponse.DescribeVServerGroupAttribute_BackendServer>();
			for (int i = 0; i < context.Length("DescribeVServerGroupAttribute.BackendServers.Length"); i++) {
				DescribeVServerGroupAttributeResponse.DescribeVServerGroupAttribute_BackendServer backendServer = new DescribeVServerGroupAttributeResponse.DescribeVServerGroupAttribute_BackendServer();
				backendServer.ServerId = context.StringValue("DescribeVServerGroupAttribute.BackendServers["+ i +"].ServerId");
				backendServer.Port = context.IntegerValue("DescribeVServerGroupAttribute.BackendServers["+ i +"].Port");
				backendServer.Weight = context.IntegerValue("DescribeVServerGroupAttribute.BackendServers["+ i +"].Weight");
				backendServer.Type = context.StringValue("DescribeVServerGroupAttribute.BackendServers["+ i +"].Type");
				backendServer.ServerIp = context.StringValue("DescribeVServerGroupAttribute.BackendServers["+ i +"].ServerIp");
				backendServer.VpcId = context.StringValue("DescribeVServerGroupAttribute.BackendServers["+ i +"].VpcId");
				backendServer.VbrId = context.StringValue("DescribeVServerGroupAttribute.BackendServers["+ i +"].VbrId");
				backendServer.ServerRegionId = context.StringValue("DescribeVServerGroupAttribute.BackendServers["+ i +"].ServerRegionId");
				backendServer.Description = context.StringValue("DescribeVServerGroupAttribute.BackendServers["+ i +"].Description");

				describeVServerGroupAttributeResponse_backendServers.Add(backendServer);
			}
			describeVServerGroupAttributeResponse.BackendServers = describeVServerGroupAttributeResponse_backendServers;
        
			return describeVServerGroupAttributeResponse;
        }
    }
}
