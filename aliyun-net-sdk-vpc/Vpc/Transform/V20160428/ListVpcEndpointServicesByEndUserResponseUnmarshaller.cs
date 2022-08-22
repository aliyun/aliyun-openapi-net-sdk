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
    public class ListVpcEndpointServicesByEndUserResponseUnmarshaller
    {
        public static ListVpcEndpointServicesByEndUserResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListVpcEndpointServicesByEndUserResponse listVpcEndpointServicesByEndUserResponse = new ListVpcEndpointServicesByEndUserResponse();

			listVpcEndpointServicesByEndUserResponse.HttpResponse = _ctx.HttpResponse;
			listVpcEndpointServicesByEndUserResponse.RequestId = _ctx.StringValue("ListVpcEndpointServicesByEndUser.RequestId");
			listVpcEndpointServicesByEndUserResponse.NextToken = _ctx.StringValue("ListVpcEndpointServicesByEndUser.NextToken");
			listVpcEndpointServicesByEndUserResponse.MaxResults = _ctx.LongValue("ListVpcEndpointServicesByEndUser.MaxResults");

			List<ListVpcEndpointServicesByEndUserResponse.ListVpcEndpointServicesByEndUser_Service> listVpcEndpointServicesByEndUserResponse_services = new List<ListVpcEndpointServicesByEndUserResponse.ListVpcEndpointServicesByEndUser_Service>();
			for (int i = 0; i < _ctx.Length("ListVpcEndpointServicesByEndUser.Services.Length"); i++) {
				ListVpcEndpointServicesByEndUserResponse.ListVpcEndpointServicesByEndUser_Service service = new ListVpcEndpointServicesByEndUserResponse.ListVpcEndpointServicesByEndUser_Service();
				service.ServiceId = _ctx.StringValue("ListVpcEndpointServicesByEndUser.Services["+ i +"].ServiceId");
				service.ServiceName = _ctx.StringValue("ListVpcEndpointServicesByEndUser.Services["+ i +"].ServiceName");
				service.DefaultPolicyDocument = _ctx.StringValue("ListVpcEndpointServicesByEndUser.Services["+ i +"].DefaultPolicyDocument");
				service.SupportPolicy = _ctx.BooleanValue("ListVpcEndpointServicesByEndUser.Services["+ i +"].SupportPolicy");
				service.ServiceDomain = _ctx.StringValue("ListVpcEndpointServicesByEndUser.Services["+ i +"].ServiceDomain");

				listVpcEndpointServicesByEndUserResponse_services.Add(service);
			}
			listVpcEndpointServicesByEndUserResponse.Services = listVpcEndpointServicesByEndUserResponse_services;
        
			return listVpcEndpointServicesByEndUserResponse;
        }
    }
}
