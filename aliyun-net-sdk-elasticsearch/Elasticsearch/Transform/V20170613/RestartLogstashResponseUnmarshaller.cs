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
    public class RestartLogstashResponseUnmarshaller
    {
        public static RestartLogstashResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RestartLogstashResponse restartLogstashResponse = new RestartLogstashResponse();

			restartLogstashResponse.HttpResponse = _ctx.HttpResponse;
			restartLogstashResponse.RequestId = _ctx.StringValue("RestartLogstash.RequestId");

			RestartLogstashResponse.RestartLogstash_Result result = new RestartLogstashResponse.RestartLogstash_Result();
			result.Status = _ctx.StringValue("RestartLogstash.Result.status");
			result.Description = _ctx.StringValue("RestartLogstash.Result.description");
			result.ResourceGroupId = _ctx.StringValue("RestartLogstash.Result.resourceGroupId");
			result.EndTime = _ctx.LongValue("RestartLogstash.Result.endTime");
			result.InstanceId = _ctx.StringValue("RestartLogstash.Result.instanceId");
			result.Config = _ctx.StringValue("RestartLogstash.Result.config");
			result.CreatedAt = _ctx.StringValue("RestartLogstash.Result.createdAt");
			result.NodeAmount = _ctx.LongValue("RestartLogstash.Result.nodeAmount");
			result.UpdatedAt = _ctx.StringValue("RestartLogstash.Result.updatedAt");
			result.Version = _ctx.StringValue("RestartLogstash.Result.version");
			result.DataNode = _ctx.BooleanValue("RestartLogstash.Result.dataNode");
			result.PaymentType = _ctx.StringValue("RestartLogstash.Result.paymentType");
			result.Protocol = _ctx.StringValue("RestartLogstash.Result.protocol");
			result.ZoneCount = _ctx.LongValue("RestartLogstash.Result.zoneCount");

			RestartLogstashResponse.RestartLogstash_Result.RestartLogstash_NetworkConfig networkConfig = new RestartLogstashResponse.RestartLogstash_Result.RestartLogstash_NetworkConfig();
			networkConfig.Type = _ctx.StringValue("RestartLogstash.Result.NetworkConfig.type");
			networkConfig.VpcId = _ctx.StringValue("RestartLogstash.Result.NetworkConfig.vpcId");
			networkConfig.VsArea = _ctx.StringValue("RestartLogstash.Result.NetworkConfig.vsArea");
			networkConfig.VswitchId = _ctx.StringValue("RestartLogstash.Result.NetworkConfig.vswitchId");
			result.NetworkConfig = networkConfig;

			RestartLogstashResponse.RestartLogstash_Result.RestartLogstash_NodeSpec nodeSpec = new RestartLogstashResponse.RestartLogstash_Result.RestartLogstash_NodeSpec();
			nodeSpec.Disk = _ctx.LongValue("RestartLogstash.Result.NodeSpec.disk");
			nodeSpec.DiskType = _ctx.StringValue("RestartLogstash.Result.NodeSpec.diskType");
			nodeSpec.Spec = _ctx.StringValue("RestartLogstash.Result.NodeSpec.spec");
			result.NodeSpec = nodeSpec;

			List<RestartLogstashResponse.RestartLogstash_Result.RestartLogstash_EndpointListItem> result_endpointList = new List<RestartLogstashResponse.RestartLogstash_Result.RestartLogstash_EndpointListItem>();
			for (int i = 0; i < _ctx.Length("RestartLogstash.Result.EndpointList.Length"); i++) {
				RestartLogstashResponse.RestartLogstash_Result.RestartLogstash_EndpointListItem endpointListItem = new RestartLogstashResponse.RestartLogstash_Result.RestartLogstash_EndpointListItem();
				endpointListItem.Host = _ctx.StringValue("RestartLogstash.Result.EndpointList["+ i +"].host");
				endpointListItem.Port = _ctx.LongValue("RestartLogstash.Result.EndpointList["+ i +"].port");
				endpointListItem.ZoneId = _ctx.StringValue("RestartLogstash.Result.EndpointList["+ i +"].zoneId");

				result_endpointList.Add(endpointListItem);
			}
			result.EndpointList = result_endpointList;

			List<RestartLogstashResponse.RestartLogstash_Result.RestartLogstash_ZoneInfosItem> result_zoneInfos = new List<RestartLogstashResponse.RestartLogstash_Result.RestartLogstash_ZoneInfosItem>();
			for (int i = 0; i < _ctx.Length("RestartLogstash.Result.ZoneInfos.Length"); i++) {
				RestartLogstashResponse.RestartLogstash_Result.RestartLogstash_ZoneInfosItem zoneInfosItem = new RestartLogstashResponse.RestartLogstash_Result.RestartLogstash_ZoneInfosItem();
				zoneInfosItem.Status = _ctx.StringValue("RestartLogstash.Result.ZoneInfos["+ i +"].status");
				zoneInfosItem.ZoneId = _ctx.StringValue("RestartLogstash.Result.ZoneInfos["+ i +"].zoneId");

				result_zoneInfos.Add(zoneInfosItem);
			}
			result.ZoneInfos = result_zoneInfos;

			List<RestartLogstashResponse.RestartLogstash_Result.RestartLogstash_TagsItem> result_tags = new List<RestartLogstashResponse.RestartLogstash_Result.RestartLogstash_TagsItem>();
			for (int i = 0; i < _ctx.Length("RestartLogstash.Result.Tags.Length"); i++) {
				RestartLogstashResponse.RestartLogstash_Result.RestartLogstash_TagsItem tagsItem = new RestartLogstashResponse.RestartLogstash_Result.RestartLogstash_TagsItem();
				tagsItem.TagKey = _ctx.StringValue("RestartLogstash.Result.Tags["+ i +"].tagKey");
				tagsItem.TagValue = _ctx.StringValue("RestartLogstash.Result.Tags["+ i +"].tagValue");

				result_tags.Add(tagsItem);
			}
			result.Tags = result_tags;
			restartLogstashResponse.Result = result;
        
			return restartLogstashResponse;
        }
    }
}
