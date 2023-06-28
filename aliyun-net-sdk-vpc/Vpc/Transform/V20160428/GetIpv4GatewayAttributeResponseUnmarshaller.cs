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
using Aliyun.Acs.Vpc.Model.V20160428;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class GetIpv4GatewayAttributeResponseUnmarshaller
    {
        public static GetIpv4GatewayAttributeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetIpv4GatewayAttributeResponse getIpv4GatewayAttributeResponse = new GetIpv4GatewayAttributeResponse();

			getIpv4GatewayAttributeResponse.HttpResponse = _ctx.HttpResponse;
			getIpv4GatewayAttributeResponse.VpcId = _ctx.StringValue("GetIpv4GatewayAttribute.VpcId");
			getIpv4GatewayAttributeResponse.Status = _ctx.StringValue("GetIpv4GatewayAttribute.Status");
			getIpv4GatewayAttributeResponse.Ipv4GatewayId = _ctx.StringValue("GetIpv4GatewayAttribute.Ipv4GatewayId");
			getIpv4GatewayAttributeResponse.RequestId = _ctx.StringValue("GetIpv4GatewayAttribute.RequestId");
			getIpv4GatewayAttributeResponse.Ipv4GatewayDescription = _ctx.StringValue("GetIpv4GatewayAttribute.Ipv4GatewayDescription");
			getIpv4GatewayAttributeResponse.Enabled = _ctx.BooleanValue("GetIpv4GatewayAttribute.Enabled");
			getIpv4GatewayAttributeResponse.Ipv4GatewayRouteTableId = _ctx.StringValue("GetIpv4GatewayAttribute.Ipv4GatewayRouteTableId");
			getIpv4GatewayAttributeResponse.Ipv4GatewayName = _ctx.StringValue("GetIpv4GatewayAttribute.Ipv4GatewayName");
			getIpv4GatewayAttributeResponse.CreateTime = _ctx.StringValue("GetIpv4GatewayAttribute.CreateTime");
			getIpv4GatewayAttributeResponse.ResourceGroupId = _ctx.StringValue("GetIpv4GatewayAttribute.ResourceGroupId");

			List<GetIpv4GatewayAttributeResponse.GetIpv4GatewayAttribute_Tag> getIpv4GatewayAttributeResponse_tags = new List<GetIpv4GatewayAttributeResponse.GetIpv4GatewayAttribute_Tag>();
			for (int i = 0; i < _ctx.Length("GetIpv4GatewayAttribute.Tags.Length"); i++) {
				GetIpv4GatewayAttributeResponse.GetIpv4GatewayAttribute_Tag tag = new GetIpv4GatewayAttributeResponse.GetIpv4GatewayAttribute_Tag();
				tag.Key = _ctx.StringValue("GetIpv4GatewayAttribute.Tags["+ i +"].Key");
				tag._Value = _ctx.StringValue("GetIpv4GatewayAttribute.Tags["+ i +"].Value");

				getIpv4GatewayAttributeResponse_tags.Add(tag);
			}
			getIpv4GatewayAttributeResponse.Tags = getIpv4GatewayAttributeResponse_tags;
        
			return getIpv4GatewayAttributeResponse;
        }
    }
}
