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
    public class ListLogstashResponseUnmarshaller
    {
        public static ListLogstashResponse Unmarshall(UnmarshallerContext context)
        {
			ListLogstashResponse listLogstashResponse = new ListLogstashResponse();

			listLogstashResponse.HttpResponse = context.HttpResponse;
			listLogstashResponse.RequestId = context.StringValue("ListLogstash.RequestId");

			List<ListLogstashResponse.ListLogstash_Instance> listLogstashResponse_result = new List<ListLogstashResponse.ListLogstash_Instance>();
			for (int i = 0; i < context.Length("ListLogstash.Result.Length"); i++) {
				ListLogstashResponse.ListLogstash_Instance instance = new ListLogstashResponse.ListLogstash_Instance();
				instance.InstanceId = context.StringValue("ListLogstash.Result["+ i +"].instanceId");
				instance.Description = context.StringValue("ListLogstash.Result["+ i +"].description");
				instance.NodeAmount = context.IntegerValue("ListLogstash.Result["+ i +"].nodeAmount");
				instance.PaymentType = context.StringValue("ListLogstash.Result["+ i +"].paymentType");
				instance.Status = context.StringValue("ListLogstash.Result["+ i +"].status");
				instance.Version = context.StringValue("ListLogstash.Result["+ i +"].version");
				instance.CreatedAt = context.StringValue("ListLogstash.Result["+ i +"].createdAt");
				instance.UpdatedAt = context.StringValue("ListLogstash.Result["+ i +"].updatedAt");

				ListLogstashResponse.ListLogstash_Instance.ListLogstash_NodeSpec nodeSpec = new ListLogstashResponse.ListLogstash_Instance.ListLogstash_NodeSpec();
				nodeSpec.Spec = context.StringValue("ListLogstash.Result["+ i +"].NodeSpec.spec");
				nodeSpec.Disk = context.IntegerValue("ListLogstash.Result["+ i +"].NodeSpec.disk");
				nodeSpec.DiskType = context.StringValue("ListLogstash.Result["+ i +"].NodeSpec.diskType");
				instance.NodeSpec = nodeSpec;

				ListLogstashResponse.ListLogstash_Instance.ListLogstash_NetworkConfig networkConfig = new ListLogstashResponse.ListLogstash_Instance.ListLogstash_NetworkConfig();
				networkConfig.Type = context.StringValue("ListLogstash.Result["+ i +"].NetworkConfig.type");
				networkConfig.VpcId = context.StringValue("ListLogstash.Result["+ i +"].NetworkConfig.vpcId");
				networkConfig.VswitchId = context.StringValue("ListLogstash.Result["+ i +"].NetworkConfig.vswitchId");
				networkConfig.VsArea = context.StringValue("ListLogstash.Result["+ i +"].NetworkConfig.vsArea");
				instance.NetworkConfig = networkConfig;

				listLogstashResponse_result.Add(instance);
			}
			listLogstashResponse.Result = listLogstashResponse_result;
        
			return listLogstashResponse;
        }
    }
}
