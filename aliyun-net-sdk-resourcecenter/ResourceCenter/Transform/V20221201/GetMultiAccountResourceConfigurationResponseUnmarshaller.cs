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
using Aliyun.Acs.ResourceCenter.Model.V20221201;

namespace Aliyun.Acs.ResourceCenter.Transform.V20221201
{
    public class GetMultiAccountResourceConfigurationResponseUnmarshaller
    {
        public static GetMultiAccountResourceConfigurationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetMultiAccountResourceConfigurationResponse getMultiAccountResourceConfigurationResponse = new GetMultiAccountResourceConfigurationResponse();

			getMultiAccountResourceConfigurationResponse.HttpResponse = _ctx.HttpResponse;
			getMultiAccountResourceConfigurationResponse.AccountId = _ctx.StringValue("GetMultiAccountResourceConfiguration.AccountId");
			getMultiAccountResourceConfigurationResponse.Configuration = _ctx.StringValue("GetMultiAccountResourceConfiguration.Configuration");
			getMultiAccountResourceConfigurationResponse.CreateTime = _ctx.StringValue("GetMultiAccountResourceConfiguration.CreateTime");
			getMultiAccountResourceConfigurationResponse.ExpireTime = _ctx.StringValue("GetMultiAccountResourceConfiguration.ExpireTime");
			getMultiAccountResourceConfigurationResponse.RegionId = _ctx.StringValue("GetMultiAccountResourceConfiguration.RegionId");
			getMultiAccountResourceConfigurationResponse.RequestId = _ctx.StringValue("GetMultiAccountResourceConfiguration.RequestId");
			getMultiAccountResourceConfigurationResponse.ResourceGroupId = _ctx.StringValue("GetMultiAccountResourceConfiguration.ResourceGroupId");
			getMultiAccountResourceConfigurationResponse.ResourceId = _ctx.StringValue("GetMultiAccountResourceConfiguration.ResourceId");
			getMultiAccountResourceConfigurationResponse.ResourceName = _ctx.StringValue("GetMultiAccountResourceConfiguration.ResourceName");
			getMultiAccountResourceConfigurationResponse.ResourceType = _ctx.StringValue("GetMultiAccountResourceConfiguration.ResourceType");
			getMultiAccountResourceConfigurationResponse.ZoneId = _ctx.StringValue("GetMultiAccountResourceConfiguration.ZoneId");

			List<string> getMultiAccountResourceConfigurationResponse_ipAddresses = new List<string>();
			for (int i = 0; i < _ctx.Length("GetMultiAccountResourceConfiguration.IpAddresses.Length"); i++) {
				getMultiAccountResourceConfigurationResponse_ipAddresses.Add(_ctx.StringValue("GetMultiAccountResourceConfiguration.IpAddresses["+ i +"]"));
			}
			getMultiAccountResourceConfigurationResponse.IpAddresses = getMultiAccountResourceConfigurationResponse_ipAddresses;

			List<GetMultiAccountResourceConfigurationResponse.GetMultiAccountResourceConfiguration_IpAddressAttribute> getMultiAccountResourceConfigurationResponse_ipAddressAttributes = new List<GetMultiAccountResourceConfigurationResponse.GetMultiAccountResourceConfiguration_IpAddressAttribute>();
			for (int i = 0; i < _ctx.Length("GetMultiAccountResourceConfiguration.IpAddressAttributes.Length"); i++) {
				GetMultiAccountResourceConfigurationResponse.GetMultiAccountResourceConfiguration_IpAddressAttribute ipAddressAttribute = new GetMultiAccountResourceConfigurationResponse.GetMultiAccountResourceConfiguration_IpAddressAttribute();
				ipAddressAttribute.IpAddress = _ctx.StringValue("GetMultiAccountResourceConfiguration.IpAddressAttributes["+ i +"].IpAddress");
				ipAddressAttribute.NetworkType = _ctx.StringValue("GetMultiAccountResourceConfiguration.IpAddressAttributes["+ i +"].NetworkType");
				ipAddressAttribute.Version = _ctx.StringValue("GetMultiAccountResourceConfiguration.IpAddressAttributes["+ i +"].Version");

				getMultiAccountResourceConfigurationResponse_ipAddressAttributes.Add(ipAddressAttribute);
			}
			getMultiAccountResourceConfigurationResponse.IpAddressAttributes = getMultiAccountResourceConfigurationResponse_ipAddressAttributes;

			List<GetMultiAccountResourceConfigurationResponse.GetMultiAccountResourceConfiguration_Tag> getMultiAccountResourceConfigurationResponse_tags = new List<GetMultiAccountResourceConfigurationResponse.GetMultiAccountResourceConfiguration_Tag>();
			for (int i = 0; i < _ctx.Length("GetMultiAccountResourceConfiguration.Tags.Length"); i++) {
				GetMultiAccountResourceConfigurationResponse.GetMultiAccountResourceConfiguration_Tag tag = new GetMultiAccountResourceConfigurationResponse.GetMultiAccountResourceConfiguration_Tag();
				tag.Key = _ctx.StringValue("GetMultiAccountResourceConfiguration.Tags["+ i +"].Key");
				tag._Value = _ctx.StringValue("GetMultiAccountResourceConfiguration.Tags["+ i +"].Value");

				getMultiAccountResourceConfigurationResponse_tags.Add(tag);
			}
			getMultiAccountResourceConfigurationResponse.Tags = getMultiAccountResourceConfigurationResponse_tags;
        
			return getMultiAccountResourceConfigurationResponse;
        }
    }
}
