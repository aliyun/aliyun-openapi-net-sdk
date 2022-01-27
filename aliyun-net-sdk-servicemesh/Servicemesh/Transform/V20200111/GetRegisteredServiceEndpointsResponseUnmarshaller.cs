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
using Aliyun.Acs.servicemesh.Model.V20200111;

namespace Aliyun.Acs.servicemesh.Transform.V20200111
{
    public class GetRegisteredServiceEndpointsResponseUnmarshaller
    {
        public static GetRegisteredServiceEndpointsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetRegisteredServiceEndpointsResponse getRegisteredServiceEndpointsResponse = new GetRegisteredServiceEndpointsResponse();

			getRegisteredServiceEndpointsResponse.HttpResponse = _ctx.HttpResponse;
			getRegisteredServiceEndpointsResponse.RequestId = _ctx.StringValue("GetRegisteredServiceEndpoints.RequestId");

			List<GetRegisteredServiceEndpointsResponse.GetRegisteredServiceEndpoints_ServiceEndpoint> getRegisteredServiceEndpointsResponse_serviceEndpoints = new List<GetRegisteredServiceEndpointsResponse.GetRegisteredServiceEndpoints_ServiceEndpoint>();
			for (int i = 0; i < _ctx.Length("GetRegisteredServiceEndpoints.ServiceEndpoints.Length"); i++) {
				GetRegisteredServiceEndpointsResponse.GetRegisteredServiceEndpoints_ServiceEndpoint serviceEndpoint = new GetRegisteredServiceEndpointsResponse.GetRegisteredServiceEndpoints_ServiceEndpoint();
				serviceEndpoint.Address = _ctx.StringValue("GetRegisteredServiceEndpoints.ServiceEndpoints["+ i +"].Address");
				serviceEndpoint.ClusterId = _ctx.StringValue("GetRegisteredServiceEndpoints.ServiceEndpoints["+ i +"].ClusterId");

				getRegisteredServiceEndpointsResponse_serviceEndpoints.Add(serviceEndpoint);
			}
			getRegisteredServiceEndpointsResponse.ServiceEndpoints = getRegisteredServiceEndpointsResponse_serviceEndpoints;
        
			return getRegisteredServiceEndpointsResponse;
        }
    }
}
