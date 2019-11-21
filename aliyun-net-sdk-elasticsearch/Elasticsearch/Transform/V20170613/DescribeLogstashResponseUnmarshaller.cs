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
using Aliyun.Acs.elasticsearch.Model.V20170613;

namespace Aliyun.Acs.elasticsearch.Transform.V20170613
{
    public class DescribeLogstashResponseUnmarshaller
    {
        public static DescribeLogstashResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLogstashResponse describeLogstashResponse = new DescribeLogstashResponse();

			describeLogstashResponse.HttpResponse = context.HttpResponse;
			describeLogstashResponse.RequestId = context.StringValue("DescribeLogstash.RequestId");

			DescribeLogstashResponse.DescribeLogstash_Result result = new DescribeLogstashResponse.DescribeLogstash_Result();
			result.InstanceId = context.StringValue("DescribeLogstash.Result.instanceId");
			result.Description = context.StringValue("DescribeLogstash.Result.description");
			result.NodeAmount = context.IntegerValue("DescribeLogstash.Result.nodeAmount");
			result.PaymentType = context.StringValue("DescribeLogstash.Result.paymentType");
			result.Status = context.StringValue("DescribeLogstash.Result.status");
			result.Version = context.StringValue("DescribeLogstash.Result.version");
			result.CreatedAt = context.StringValue("DescribeLogstash.Result.createdAt");
			result.UpdatedAt = context.StringValue("DescribeLogstash.Result.updatedAt");
			result.VpcInstanceId = context.StringValue("DescribeLogstash.Result.vpcInstanceId");
			result.Config = context.StringValue("DescribeLogstash.Result.config");

			DescribeLogstashResponse.DescribeLogstash_Result.DescribeLogstash_NodeSpec nodeSpec = new DescribeLogstashResponse.DescribeLogstash_Result.DescribeLogstash_NodeSpec();
			nodeSpec.Spec = context.StringValue("DescribeLogstash.Result.NodeSpec.spec");
			nodeSpec.Disk = context.IntegerValue("DescribeLogstash.Result.NodeSpec.disk");
			nodeSpec.DiskType = context.StringValue("DescribeLogstash.Result.NodeSpec.diskType");
			result.NodeSpec = nodeSpec;

			DescribeLogstashResponse.DescribeLogstash_Result.DescribeLogstash_NetworkConfig networkConfig = new DescribeLogstashResponse.DescribeLogstash_Result.DescribeLogstash_NetworkConfig();
			networkConfig.Type = context.StringValue("DescribeLogstash.Result.NetworkConfig.type");
			networkConfig.VpcId = context.StringValue("DescribeLogstash.Result.NetworkConfig.vpcId");
			networkConfig.VswitchId = context.StringValue("DescribeLogstash.Result.NetworkConfig.vswitchId");
			networkConfig.VsArea = context.StringValue("DescribeLogstash.Result.NetworkConfig.vsArea");
			result.NetworkConfig = networkConfig;

			List<DescribeLogstashResponse.DescribeLogstash_Result.DescribeLogstash_Endpoint> result_endpointList = new List<DescribeLogstashResponse.DescribeLogstash_Result.DescribeLogstash_Endpoint>();
			for (int i = 0; i < context.Length("DescribeLogstash.Result.EndpointList.Length"); i++) {
				DescribeLogstashResponse.DescribeLogstash_Result.DescribeLogstash_Endpoint endpoint = new DescribeLogstashResponse.DescribeLogstash_Result.DescribeLogstash_Endpoint();
				endpoint.Host = context.StringValue("DescribeLogstash.Result.EndpointList["+ i +"].host");
				endpoint.Port = context.StringValue("DescribeLogstash.Result.EndpointList["+ i +"].port");

				result_endpointList.Add(endpoint);
			}
			result.EndpointList = result_endpointList;
			describeLogstashResponse.Result = result;
        
			return describeLogstashResponse;
        }
    }
}
