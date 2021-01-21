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
    public class ListVpcEndpointsResponseUnmarshaller
    {
        public static ListVpcEndpointsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListVpcEndpointsResponse listVpcEndpointsResponse = new ListVpcEndpointsResponse();

			listVpcEndpointsResponse.HttpResponse = _ctx.HttpResponse;
			listVpcEndpointsResponse.MaxResults = _ctx.StringValue("ListVpcEndpoints.MaxResults");
			listVpcEndpointsResponse.NextToken = _ctx.StringValue("ListVpcEndpoints.NextToken");
			listVpcEndpointsResponse.RequestId = _ctx.StringValue("ListVpcEndpoints.RequestId");

			List<ListVpcEndpointsResponse.ListVpcEndpoints_Endpoint> listVpcEndpointsResponse_endpoints = new List<ListVpcEndpointsResponse.ListVpcEndpoints_Endpoint>();
			for (int i = 0; i < _ctx.Length("ListVpcEndpoints.Endpoints.Length"); i++) {
				ListVpcEndpointsResponse.ListVpcEndpoints_Endpoint endpoint = new ListVpcEndpointsResponse.ListVpcEndpoints_Endpoint();
				endpoint.EndpointId = _ctx.StringValue("ListVpcEndpoints.Endpoints["+ i +"].EndpointId");
				endpoint.EndpointName = _ctx.StringValue("ListVpcEndpoints.Endpoints["+ i +"].EndpointName");
				endpoint.EndpointDescription = _ctx.StringValue("ListVpcEndpoints.Endpoints["+ i +"].EndpointDescription");
				endpoint.EndpointStatus = _ctx.StringValue("ListVpcEndpoints.Endpoints["+ i +"].EndpointStatus");
				endpoint.EndpointBusinessStatus = _ctx.StringValue("ListVpcEndpoints.Endpoints["+ i +"].EndpointBusinessStatus");
				endpoint.EndpointDomain = _ctx.StringValue("ListVpcEndpoints.Endpoints["+ i +"].EndpointDomain");
				endpoint.Bandwidth = _ctx.LongValue("ListVpcEndpoints.Endpoints["+ i +"].Bandwidth");
				endpoint.ConnectionStatus = _ctx.StringValue("ListVpcEndpoints.Endpoints["+ i +"].ConnectionStatus");
				endpoint.ServiceId = _ctx.StringValue("ListVpcEndpoints.Endpoints["+ i +"].ServiceId");
				endpoint.ServiceName = _ctx.StringValue("ListVpcEndpoints.Endpoints["+ i +"].ServiceName");
				endpoint.VpcId = _ctx.StringValue("ListVpcEndpoints.Endpoints["+ i +"].VpcId");
				endpoint.CreateTime = _ctx.StringValue("ListVpcEndpoints.Endpoints["+ i +"].CreateTime");
				endpoint.RegionId = _ctx.StringValue("ListVpcEndpoints.Endpoints["+ i +"].RegionId");
				endpoint.ResourceOwner = _ctx.BooleanValue("ListVpcEndpoints.Endpoints["+ i +"].ResourceOwner");

				listVpcEndpointsResponse_endpoints.Add(endpoint);
			}
			listVpcEndpointsResponse.Endpoints = listVpcEndpointsResponse_endpoints;
        
			return listVpcEndpointsResponse;
        }
    }
}
