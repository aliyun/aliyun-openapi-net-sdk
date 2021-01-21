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
    public class GetVpcEndpointServiceAttributeResponseUnmarshaller
    {
        public static GetVpcEndpointServiceAttributeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetVpcEndpointServiceAttributeResponse getVpcEndpointServiceAttributeResponse = new GetVpcEndpointServiceAttributeResponse();

			getVpcEndpointServiceAttributeResponse.HttpResponse = _ctx.HttpResponse;
			getVpcEndpointServiceAttributeResponse.RequestId = _ctx.StringValue("GetVpcEndpointServiceAttribute.RequestId");
			getVpcEndpointServiceAttributeResponse.ServiceId = _ctx.StringValue("GetVpcEndpointServiceAttribute.ServiceId");
			getVpcEndpointServiceAttributeResponse.ServiceName = _ctx.StringValue("GetVpcEndpointServiceAttribute.ServiceName");
			getVpcEndpointServiceAttributeResponse.ServiceDomain = _ctx.StringValue("GetVpcEndpointServiceAttribute.ServiceDomain");
			getVpcEndpointServiceAttributeResponse.ServiceDescription = _ctx.StringValue("GetVpcEndpointServiceAttribute.ServiceDescription");
			getVpcEndpointServiceAttributeResponse.ServiceBusinessStatus = _ctx.StringValue("GetVpcEndpointServiceAttribute.ServiceBusinessStatus");
			getVpcEndpointServiceAttributeResponse.ServiceStatus = _ctx.StringValue("GetVpcEndpointServiceAttribute.ServiceStatus");
			getVpcEndpointServiceAttributeResponse.AutoAcceptEnabled = _ctx.BooleanValue("GetVpcEndpointServiceAttribute.AutoAcceptEnabled");
			getVpcEndpointServiceAttributeResponse.CreateTime = _ctx.StringValue("GetVpcEndpointServiceAttribute.CreateTime");
			getVpcEndpointServiceAttributeResponse.MaxBandwidth = _ctx.IntegerValue("GetVpcEndpointServiceAttribute.MaxBandwidth");
			getVpcEndpointServiceAttributeResponse.MinBandwidth = _ctx.IntegerValue("GetVpcEndpointServiceAttribute.MinBandwidth");
			getVpcEndpointServiceAttributeResponse.ConnectBandwidth = _ctx.IntegerValue("GetVpcEndpointServiceAttribute.ConnectBandwidth");
			getVpcEndpointServiceAttributeResponse.RegionId = _ctx.StringValue("GetVpcEndpointServiceAttribute.RegionId");
			getVpcEndpointServiceAttributeResponse.Payer = _ctx.StringValue("GetVpcEndpointServiceAttribute.Payer");

			List<string> getVpcEndpointServiceAttributeResponse_zones = new List<string>();
			for (int i = 0; i < _ctx.Length("GetVpcEndpointServiceAttribute.Zones.Length"); i++) {
				getVpcEndpointServiceAttributeResponse_zones.Add(_ctx.StringValue("GetVpcEndpointServiceAttribute.Zones["+ i +"]"));
			}
			getVpcEndpointServiceAttributeResponse.Zones = getVpcEndpointServiceAttributeResponse_zones;
        
			return getVpcEndpointServiceAttributeResponse;
        }
    }
}
