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
    public class CreateLogstashResponseUnmarshaller
    {
        public static CreateLogstashResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateLogstashResponse createLogstashResponse = new CreateLogstashResponse();

			createLogstashResponse.HttpResponse = _ctx.HttpResponse;
			createLogstashResponse.RequestId = _ctx.StringValue("CreateLogstash.RequestId");

			CreateLogstashResponse.CreateLogstash_Result result = new CreateLogstashResponse.CreateLogstash_Result();
			result.Status = _ctx.StringValue("CreateLogstash.Result.status");
			result.Description = _ctx.StringValue("CreateLogstash.Result.description");
			result.ResourceGroupId = _ctx.StringValue("CreateLogstash.Result.resourceGroupId");
			result.EndTime = _ctx.LongValue("CreateLogstash.Result.endTime");
			result.InstanceId = _ctx.StringValue("CreateLogstash.Result.instanceId");
			result.Config = _ctx.StringValue("CreateLogstash.Result.config");
			result.CreatedAt = _ctx.StringValue("CreateLogstash.Result.createdAt");
			result.NodeAmount = _ctx.LongValue("CreateLogstash.Result.nodeAmount");
			result.UpdatedAt = _ctx.StringValue("CreateLogstash.Result.updatedAt");
			result.Version = _ctx.StringValue("CreateLogstash.Result.version");
			result.DataNode = _ctx.BooleanValue("CreateLogstash.Result.dataNode");
			result.PaymentType = _ctx.StringValue("CreateLogstash.Result.paymentType");
			result.Protocol = _ctx.StringValue("CreateLogstash.Result.protocol");
			result.ZoneCount = _ctx.LongValue("CreateLogstash.Result.zoneCount");

			CreateLogstashResponse.CreateLogstash_Result.CreateLogstash_NetworkConfig networkConfig = new CreateLogstashResponse.CreateLogstash_Result.CreateLogstash_NetworkConfig();
			networkConfig.Type = _ctx.StringValue("CreateLogstash.Result.NetworkConfig.type");
			networkConfig.VpcId = _ctx.StringValue("CreateLogstash.Result.NetworkConfig.vpcId");
			networkConfig.VsArea = _ctx.StringValue("CreateLogstash.Result.NetworkConfig.vsArea");
			networkConfig.VswitchId = _ctx.StringValue("CreateLogstash.Result.NetworkConfig.vswitchId");
			result.NetworkConfig = networkConfig;

			CreateLogstashResponse.CreateLogstash_Result.CreateLogstash_NodeSpec nodeSpec = new CreateLogstashResponse.CreateLogstash_Result.CreateLogstash_NodeSpec();
			nodeSpec.Disk = _ctx.LongValue("CreateLogstash.Result.NodeSpec.disk");
			nodeSpec.DiskType = _ctx.StringValue("CreateLogstash.Result.NodeSpec.diskType");
			nodeSpec.Spec = _ctx.StringValue("CreateLogstash.Result.NodeSpec.spec");
			result.NodeSpec = nodeSpec;

			List<CreateLogstashResponse.CreateLogstash_Result.CreateLogstash_EndpointListItem> result_endpointList = new List<CreateLogstashResponse.CreateLogstash_Result.CreateLogstash_EndpointListItem>();
			for (int i = 0; i < _ctx.Length("CreateLogstash.Result.EndpointList.Length"); i++) {
				CreateLogstashResponse.CreateLogstash_Result.CreateLogstash_EndpointListItem endpointListItem = new CreateLogstashResponse.CreateLogstash_Result.CreateLogstash_EndpointListItem();
				endpointListItem.Host = _ctx.StringValue("CreateLogstash.Result.EndpointList["+ i +"].host");
				endpointListItem.Port = _ctx.LongValue("CreateLogstash.Result.EndpointList["+ i +"].port");
				endpointListItem.ZoneId = _ctx.StringValue("CreateLogstash.Result.EndpointList["+ i +"].zoneId");

				result_endpointList.Add(endpointListItem);
			}
			result.EndpointList = result_endpointList;

			List<CreateLogstashResponse.CreateLogstash_Result.CreateLogstash_ZoneInfosItem> result_zoneInfos = new List<CreateLogstashResponse.CreateLogstash_Result.CreateLogstash_ZoneInfosItem>();
			for (int i = 0; i < _ctx.Length("CreateLogstash.Result.ZoneInfos.Length"); i++) {
				CreateLogstashResponse.CreateLogstash_Result.CreateLogstash_ZoneInfosItem zoneInfosItem = new CreateLogstashResponse.CreateLogstash_Result.CreateLogstash_ZoneInfosItem();
				zoneInfosItem.Status = _ctx.StringValue("CreateLogstash.Result.ZoneInfos["+ i +"].status");
				zoneInfosItem.ZoneId = _ctx.StringValue("CreateLogstash.Result.ZoneInfos["+ i +"].zoneId");

				result_zoneInfos.Add(zoneInfosItem);
			}
			result.ZoneInfos = result_zoneInfos;

			List<CreateLogstashResponse.CreateLogstash_Result.CreateLogstash_TagsItem> result_tags = new List<CreateLogstashResponse.CreateLogstash_Result.CreateLogstash_TagsItem>();
			for (int i = 0; i < _ctx.Length("CreateLogstash.Result.Tags.Length"); i++) {
				CreateLogstashResponse.CreateLogstash_Result.CreateLogstash_TagsItem tagsItem = new CreateLogstashResponse.CreateLogstash_Result.CreateLogstash_TagsItem();
				tagsItem.TagKey = _ctx.StringValue("CreateLogstash.Result.Tags["+ i +"].tagKey");
				tagsItem.TagValue = _ctx.StringValue("CreateLogstash.Result.Tags["+ i +"].tagValue");

				result_tags.Add(tagsItem);
			}
			result.Tags = result_tags;
			createLogstashResponse.Result = result;
        
			return createLogstashResponse;
        }
    }
}
