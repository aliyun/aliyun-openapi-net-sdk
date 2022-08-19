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
    public class ListVpcGatewayEndpointsResponseUnmarshaller
    {
        public static ListVpcGatewayEndpointsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListVpcGatewayEndpointsResponse listVpcGatewayEndpointsResponse = new ListVpcGatewayEndpointsResponse();

			listVpcGatewayEndpointsResponse.HttpResponse = _ctx.HttpResponse;
			listVpcGatewayEndpointsResponse.RequestId = _ctx.StringValue("ListVpcGatewayEndpoints.RequestId");
			listVpcGatewayEndpointsResponse.NextToken = _ctx.StringValue("ListVpcGatewayEndpoints.NextToken");
			listVpcGatewayEndpointsResponse.TotalCount = _ctx.LongValue("ListVpcGatewayEndpoints.TotalCount");
			listVpcGatewayEndpointsResponse.MaxResults = _ctx.LongValue("ListVpcGatewayEndpoints.MaxResults");

			List<ListVpcGatewayEndpointsResponse.ListVpcGatewayEndpoints_Endpoint> listVpcGatewayEndpointsResponse_endpoints = new List<ListVpcGatewayEndpointsResponse.ListVpcGatewayEndpoints_Endpoint>();
			for (int i = 0; i < _ctx.Length("ListVpcGatewayEndpoints.Endpoints.Length"); i++) {
				ListVpcGatewayEndpointsResponse.ListVpcGatewayEndpoints_Endpoint endpoint = new ListVpcGatewayEndpointsResponse.ListVpcGatewayEndpoints_Endpoint();
				endpoint.EndpointId = _ctx.StringValue("ListVpcGatewayEndpoints.Endpoints["+ i +"].EndpointId");
				endpoint.EndpointName = _ctx.StringValue("ListVpcGatewayEndpoints.Endpoints["+ i +"].EndpointName");
				endpoint.EndpointDescription = _ctx.StringValue("ListVpcGatewayEndpoints.Endpoints["+ i +"].EndpointDescription");
				endpoint.ServiceName = _ctx.StringValue("ListVpcGatewayEndpoints.Endpoints["+ i +"].ServiceName");
				endpoint.VpcId = _ctx.StringValue("ListVpcGatewayEndpoints.Endpoints["+ i +"].VpcId");
				endpoint.PolicyDocument = _ctx.StringValue("ListVpcGatewayEndpoints.Endpoints["+ i +"].PolicyDocument");
				endpoint.CreationTime = _ctx.StringValue("ListVpcGatewayEndpoints.Endpoints["+ i +"].CreationTime");
				endpoint.EndpointStatus = _ctx.StringValue("ListVpcGatewayEndpoints.Endpoints["+ i +"].EndpointStatus");

				List<string> endpoint_associatedRouteTables = new List<string>();
				for (int j = 0; j < _ctx.Length("ListVpcGatewayEndpoints.Endpoints["+ i +"].AssociatedRouteTables.Length"); j++) {
					endpoint_associatedRouteTables.Add(_ctx.StringValue("ListVpcGatewayEndpoints.Endpoints["+ i +"].AssociatedRouteTables["+ j +"]"));
				}
				endpoint.AssociatedRouteTables = endpoint_associatedRouteTables;

				listVpcGatewayEndpointsResponse_endpoints.Add(endpoint);
			}
			listVpcGatewayEndpointsResponse.Endpoints = listVpcGatewayEndpointsResponse_endpoints;
        
			return listVpcGatewayEndpointsResponse;
        }
    }
}
