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
        public static ListLogstashResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListLogstashResponse listLogstashResponse = new ListLogstashResponse();

			listLogstashResponse.HttpResponse = _ctx.HttpResponse;
			listLogstashResponse.RequestId = _ctx.StringValue("ListLogstash.RequestId");

			ListLogstashResponse.ListLogstash_Headers headers = new ListLogstashResponse.ListLogstash_Headers();
			headers.XTotalCount = _ctx.IntegerValue("ListLogstash.Headers.X-Total-Count");
			listLogstashResponse.Headers = headers;

			List<ListLogstashResponse.ListLogstash_Instance> listLogstashResponse_result = new List<ListLogstashResponse.ListLogstash_Instance>();
			for (int i = 0; i < _ctx.Length("ListLogstash.Result.Length"); i++) {
				ListLogstashResponse.ListLogstash_Instance instance = new ListLogstashResponse.ListLogstash_Instance();
				instance.PaymentType = _ctx.StringValue("ListLogstash.Result["+ i +"].paymentType");
				instance.NodeAmount = _ctx.IntegerValue("ListLogstash.Result["+ i +"].nodeAmount");
				instance.Description = _ctx.StringValue("ListLogstash.Result["+ i +"].description");
				instance.CreatedAt = _ctx.StringValue("ListLogstash.Result["+ i +"].createdAt");
				instance.Status = _ctx.StringValue("ListLogstash.Result["+ i +"].status");
				instance.UpdatedAt = _ctx.StringValue("ListLogstash.Result["+ i +"].updatedAt");
				instance.InstanceId = _ctx.StringValue("ListLogstash.Result["+ i +"].instanceId");
				instance.Version = _ctx.StringValue("ListLogstash.Result["+ i +"].version");
				instance.ResourceGroupId = _ctx.StringValue("ListLogstash.Result["+ i +"].resourceGroupId");

				ListLogstashResponse.ListLogstash_Instance.ListLogstash_NodeSpec nodeSpec = new ListLogstashResponse.ListLogstash_Instance.ListLogstash_NodeSpec();
				nodeSpec.Spec = _ctx.StringValue("ListLogstash.Result["+ i +"].NodeSpec.spec");
				nodeSpec.Disk = _ctx.IntegerValue("ListLogstash.Result["+ i +"].NodeSpec.disk");
				nodeSpec.DiskEncryption = _ctx.BooleanValue("ListLogstash.Result["+ i +"].NodeSpec.diskEncryption");
				nodeSpec.DiskType = _ctx.StringValue("ListLogstash.Result["+ i +"].NodeSpec.diskType");
				instance.NodeSpec = nodeSpec;

				ListLogstashResponse.ListLogstash_Instance.ListLogstash_NetworkConfig networkConfig = new ListLogstashResponse.ListLogstash_Instance.ListLogstash_NetworkConfig();
				networkConfig.VpcId = _ctx.StringValue("ListLogstash.Result["+ i +"].NetworkConfig.vpcId");
				networkConfig.VsArea = _ctx.StringValue("ListLogstash.Result["+ i +"].NetworkConfig.vsArea");
				networkConfig.Type = _ctx.StringValue("ListLogstash.Result["+ i +"].NetworkConfig.type");
				networkConfig.VswitchId = _ctx.StringValue("ListLogstash.Result["+ i +"].NetworkConfig.vswitchId");
				instance.NetworkConfig = networkConfig;

				List<ListLogstashResponse.ListLogstash_Instance.ListLogstash_TagsItem> instance_tags = new List<ListLogstashResponse.ListLogstash_Instance.ListLogstash_TagsItem>();
				for (int j = 0; j < _ctx.Length("ListLogstash.Result["+ i +"].Tags.Length"); j++) {
					ListLogstashResponse.ListLogstash_Instance.ListLogstash_TagsItem tagsItem = new ListLogstashResponse.ListLogstash_Instance.ListLogstash_TagsItem();
					tagsItem.TagValue = _ctx.StringValue("ListLogstash.Result["+ i +"].Tags["+ j +"].TagValue");
					tagsItem.TagKey = _ctx.StringValue("ListLogstash.Result["+ i +"].Tags["+ j +"].TagKey");

					instance_tags.Add(tagsItem);
				}
				instance.Tags = instance_tags;

				listLogstashResponse_result.Add(instance);
			}
			listLogstashResponse.Result = listLogstashResponse_result;
        
			return listLogstashResponse;
        }
    }
}
