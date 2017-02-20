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
using System.Collections.Generic;

namespace Aliyun.Acs.Slb.Transform.V20140515
{
    public class DescribeVServerGroupAttributeResponseUnmarshaller
    {
        public static DescribeVServerGroupAttributeResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeVServerGroupAttributeResponse describeVServerGroupAttributeResponse = new DescribeVServerGroupAttributeResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeVServerGroupAttribute.RequestId"),
                VServerGroupId = context.StringValue("DescribeVServerGroupAttribute.VServerGroupId"),
                VServerGroupName = context.StringValue("DescribeVServerGroupAttribute.VServerGroupName")
            };
            List<DescribeVServerGroupAttributeResponse.BackendServer> backendServers = new List<DescribeVServerGroupAttributeResponse.BackendServer>();
			for (int i = 0; i < context.Length("DescribeVServerGroupAttribute.BackendServers.Length"); i++) {
                DescribeVServerGroupAttributeResponse.BackendServer backendServer = new DescribeVServerGroupAttributeResponse.BackendServer()
                {
                    ServerId = context.StringValue($"DescribeVServerGroupAttribute.BackendServers[{i}].ServerId"),
                    Port = context.IntegerValue($"DescribeVServerGroupAttribute.BackendServers[{i}].Port"),
                    Weight = context.IntegerValue($"DescribeVServerGroupAttribute.BackendServers[{i}].Weight")
                };
                backendServers.Add(backendServer);
			}
			describeVServerGroupAttributeResponse.BackendServers = backendServers;
        
			return describeVServerGroupAttributeResponse;
        }
    }
}