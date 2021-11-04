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
using Aliyun.Acs.Privatelink.Model.V20200415;

namespace Aliyun.Acs.Privatelink.Transform.V20200415
{
    public class GetVpcEndpointAttributeResponseUnmarshaller
    {
        public static GetVpcEndpointAttributeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetVpcEndpointAttributeResponse getVpcEndpointAttributeResponse = new GetVpcEndpointAttributeResponse();

			getVpcEndpointAttributeResponse.HttpResponse = _ctx.HttpResponse;
			getVpcEndpointAttributeResponse.Payer = _ctx.StringValue("GetVpcEndpointAttribute.Payer");
			getVpcEndpointAttributeResponse.EndpointDomain = _ctx.StringValue("GetVpcEndpointAttribute.EndpointDomain");
			getVpcEndpointAttributeResponse.RequestId = _ctx.StringValue("GetVpcEndpointAttribute.RequestId");
			getVpcEndpointAttributeResponse.CreateTime = _ctx.StringValue("GetVpcEndpointAttribute.CreateTime");
			getVpcEndpointAttributeResponse.ResourceOwner = _ctx.BooleanValue("GetVpcEndpointAttribute.ResourceOwner");
			getVpcEndpointAttributeResponse.EndpointBusinessStatus = _ctx.StringValue("GetVpcEndpointAttribute.EndpointBusinessStatus");
			getVpcEndpointAttributeResponse.EndpointDescription = _ctx.StringValue("GetVpcEndpointAttribute.EndpointDescription");
			getVpcEndpointAttributeResponse.ServiceId = _ctx.StringValue("GetVpcEndpointAttribute.ServiceId");
			getVpcEndpointAttributeResponse.EndpointStatus = _ctx.StringValue("GetVpcEndpointAttribute.EndpointStatus");
			getVpcEndpointAttributeResponse.VpcId = _ctx.StringValue("GetVpcEndpointAttribute.VpcId");
			getVpcEndpointAttributeResponse.EndpointName = _ctx.StringValue("GetVpcEndpointAttribute.EndpointName");
			getVpcEndpointAttributeResponse.ZonePrivateIpAddressCount = _ctx.LongValue("GetVpcEndpointAttribute.ZonePrivateIpAddressCount");
			getVpcEndpointAttributeResponse.EndpointType = _ctx.StringValue("GetVpcEndpointAttribute.EndpointType");
			getVpcEndpointAttributeResponse.ServiceName = _ctx.StringValue("GetVpcEndpointAttribute.ServiceName");
			getVpcEndpointAttributeResponse.Bandwidth = _ctx.IntegerValue("GetVpcEndpointAttribute.Bandwidth");
			getVpcEndpointAttributeResponse.EndpointId = _ctx.StringValue("GetVpcEndpointAttribute.EndpointId");
			getVpcEndpointAttributeResponse.RegionId = _ctx.StringValue("GetVpcEndpointAttribute.RegionId");
			getVpcEndpointAttributeResponse.ConnectionStatus = _ctx.StringValue("GetVpcEndpointAttribute.ConnectionStatus");
			getVpcEndpointAttributeResponse.ZoneAffinityEnabled = _ctx.BooleanValue("GetVpcEndpointAttribute.ZoneAffinityEnabled");
        
			return getVpcEndpointAttributeResponse;
        }
    }
}
