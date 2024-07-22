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
        public static DescribeLogstashResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLogstashResponse describeLogstashResponse = new DescribeLogstashResponse();

			describeLogstashResponse.HttpResponse = _ctx.HttpResponse;
			describeLogstashResponse.RequestId = _ctx.StringValue("DescribeLogstash.RequestId");

			DescribeLogstashResponse.DescribeLogstash_Result result = new DescribeLogstashResponse.DescribeLogstash_Result();
			result.Config = _ctx.StringValue("DescribeLogstash.Result.config");
			result.PaymentType = _ctx.StringValue("DescribeLogstash.Result.paymentType");
			result.ResourceGroupId = _ctx.StringValue("DescribeLogstash.Result.ResourceGroupId");
			result.NodeAmount = _ctx.IntegerValue("DescribeLogstash.Result.nodeAmount");
			result.Description = _ctx.StringValue("DescribeLogstash.Result.description");
			result.CreatedAt = _ctx.StringValue("DescribeLogstash.Result.createdAt");
			result.Status = _ctx.StringValue("DescribeLogstash.Result.status");
			result.VpcInstanceId = _ctx.StringValue("DescribeLogstash.Result.vpcInstanceId");
			result.UpdatedAt = _ctx.StringValue("DescribeLogstash.Result.updatedAt");
			result.Version = _ctx.StringValue("DescribeLogstash.Result.version");
			result.InstanceId = _ctx.StringValue("DescribeLogstash.Result.instanceId");

			List<Dictionary<string, string>> result_extendConfigs = new List<Dictionary<string, string>>();
			for (int i = 0; i < _ctx.Length("DescribeLogstash.Result.ExtendConfigs.Length"); i++) {
				Dictionary<string, string> tmp = new Dictionary<string, string>() { };
				foreach (var _item in _ctx.ResponseDictionary){
					string prefix = "DescribeLogstash.Result.ExtendConfigs["+ i +"].";
					if (_item.Key.IndexOf(prefix) == 0){
						tmp.Add(_item.Key.Substring(prefix.Length), _item.Value);
					}
				}
				if (tmp.Count > 0){
					result_extendConfigs.Add(tmp);
				}
			}
			result.ExtendConfigs = result_extendConfigs;

			DescribeLogstashResponse.DescribeLogstash_Result.DescribeLogstash_NodeSpec nodeSpec = new DescribeLogstashResponse.DescribeLogstash_Result.DescribeLogstash_NodeSpec();
			nodeSpec.Spec = _ctx.StringValue("DescribeLogstash.Result.NodeSpec.spec");
			nodeSpec.Disk = _ctx.IntegerValue("DescribeLogstash.Result.NodeSpec.disk");
			nodeSpec.DiskEncryption = _ctx.BooleanValue("DescribeLogstash.Result.NodeSpec.diskEncryption");
			nodeSpec.DiskType = _ctx.StringValue("DescribeLogstash.Result.NodeSpec.diskType");
			result.NodeSpec = nodeSpec;

			DescribeLogstashResponse.DescribeLogstash_Result.DescribeLogstash_NetworkConfig networkConfig = new DescribeLogstashResponse.DescribeLogstash_Result.DescribeLogstash_NetworkConfig();
			networkConfig.VpcId = _ctx.StringValue("DescribeLogstash.Result.NetworkConfig.vpcId");
			networkConfig.VsArea = _ctx.StringValue("DescribeLogstash.Result.NetworkConfig.vsArea");
			networkConfig.Type = _ctx.StringValue("DescribeLogstash.Result.NetworkConfig.type");
			networkConfig.VswitchId = _ctx.StringValue("DescribeLogstash.Result.NetworkConfig.vswitchId");
			result.NetworkConfig = networkConfig;

			List<DescribeLogstashResponse.DescribeLogstash_Result.DescribeLogstash_Endpoint> result_endpointList = new List<DescribeLogstashResponse.DescribeLogstash_Result.DescribeLogstash_Endpoint>();
			for (int i = 0; i < _ctx.Length("DescribeLogstash.Result.EndpointList.Length"); i++) {
				DescribeLogstashResponse.DescribeLogstash_Result.DescribeLogstash_Endpoint endpoint = new DescribeLogstashResponse.DescribeLogstash_Result.DescribeLogstash_Endpoint();
				endpoint.ZoneId = _ctx.StringValue("DescribeLogstash.Result.EndpointList["+ i +"].zoneId");
				endpoint.Port = _ctx.StringValue("DescribeLogstash.Result.EndpointList["+ i +"].port");
				endpoint.Host = _ctx.StringValue("DescribeLogstash.Result.EndpointList["+ i +"].host");

				result_endpointList.Add(endpoint);
			}
			result.EndpointList = result_endpointList;

			List<DescribeLogstashResponse.DescribeLogstash_Result.DescribeLogstash_TagsItem> result_tags = new List<DescribeLogstashResponse.DescribeLogstash_Result.DescribeLogstash_TagsItem>();
			for (int i = 0; i < _ctx.Length("DescribeLogstash.Result.Tags.Length"); i++) {
				DescribeLogstashResponse.DescribeLogstash_Result.DescribeLogstash_TagsItem tagsItem = new DescribeLogstashResponse.DescribeLogstash_Result.DescribeLogstash_TagsItem();
				tagsItem.TagKey = _ctx.StringValue("DescribeLogstash.Result.Tags["+ i +"].tagKey");
				tagsItem.TagValue = _ctx.StringValue("DescribeLogstash.Result.Tags["+ i +"].tagValue");

				result_tags.Add(tagsItem);
			}
			result.Tags = result_tags;

			List<DescribeLogstashResponse.DescribeLogstash_Result.DescribeLogstash_ZoneInfosItem> result_zoneInfos = new List<DescribeLogstashResponse.DescribeLogstash_Result.DescribeLogstash_ZoneInfosItem>();
			for (int i = 0; i < _ctx.Length("DescribeLogstash.Result.ZoneInfos.Length"); i++) {
				DescribeLogstashResponse.DescribeLogstash_Result.DescribeLogstash_ZoneInfosItem zoneInfosItem = new DescribeLogstashResponse.DescribeLogstash_Result.DescribeLogstash_ZoneInfosItem();
				zoneInfosItem.Status = _ctx.StringValue("DescribeLogstash.Result.ZoneInfos["+ i +"].status");
				zoneInfosItem.ZoneId = _ctx.StringValue("DescribeLogstash.Result.ZoneInfos["+ i +"].zoneId");

				result_zoneInfos.Add(zoneInfosItem);
			}
			result.ZoneInfos = result_zoneInfos;
			describeLogstashResponse.Result = result;
        
			return describeLogstashResponse;
        }
    }
}
