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
    public class GetVpcGatewayEndpointAttributeResponseUnmarshaller
    {
        public static GetVpcGatewayEndpointAttributeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetVpcGatewayEndpointAttributeResponse getVpcGatewayEndpointAttributeResponse = new GetVpcGatewayEndpointAttributeResponse();

			getVpcGatewayEndpointAttributeResponse.HttpResponse = _ctx.HttpResponse;
			getVpcGatewayEndpointAttributeResponse.RequestId = _ctx.StringValue("GetVpcGatewayEndpointAttribute.RequestId");
			getVpcGatewayEndpointAttributeResponse.EndpointId = _ctx.StringValue("GetVpcGatewayEndpointAttribute.EndpointId");
			getVpcGatewayEndpointAttributeResponse.EndpointName = _ctx.StringValue("GetVpcGatewayEndpointAttribute.EndpointName");
			getVpcGatewayEndpointAttributeResponse.EndpointDescription = _ctx.StringValue("GetVpcGatewayEndpointAttribute.EndpointDescription");
			getVpcGatewayEndpointAttributeResponse.ServiceName = _ctx.StringValue("GetVpcGatewayEndpointAttribute.ServiceName");
			getVpcGatewayEndpointAttributeResponse.VpcId = _ctx.StringValue("GetVpcGatewayEndpointAttribute.VpcId");
			getVpcGatewayEndpointAttributeResponse.PolicyDocument = _ctx.StringValue("GetVpcGatewayEndpointAttribute.PolicyDocument");
			getVpcGatewayEndpointAttributeResponse.CreationTime = _ctx.StringValue("GetVpcGatewayEndpointAttribute.CreationTime");
			getVpcGatewayEndpointAttributeResponse.EndpointStatus = _ctx.StringValue("GetVpcGatewayEndpointAttribute.EndpointStatus");

			List<string> getVpcGatewayEndpointAttributeResponse_routeTables = new List<string>();
			for (int i = 0; i < _ctx.Length("GetVpcGatewayEndpointAttribute.RouteTables.Length"); i++) {
				getVpcGatewayEndpointAttributeResponse_routeTables.Add(_ctx.StringValue("GetVpcGatewayEndpointAttribute.RouteTables["+ i +"]"));
			}
			getVpcGatewayEndpointAttributeResponse.RouteTables = getVpcGatewayEndpointAttributeResponse_routeTables;
        
			return getVpcGatewayEndpointAttributeResponse;
        }
    }
}
