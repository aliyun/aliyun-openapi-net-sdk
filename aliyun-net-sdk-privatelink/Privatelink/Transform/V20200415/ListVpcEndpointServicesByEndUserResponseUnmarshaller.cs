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
    public class ListVpcEndpointServicesByEndUserResponseUnmarshaller
    {
        public static ListVpcEndpointServicesByEndUserResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListVpcEndpointServicesByEndUserResponse listVpcEndpointServicesByEndUserResponse = new ListVpcEndpointServicesByEndUserResponse();

			listVpcEndpointServicesByEndUserResponse.HttpResponse = _ctx.HttpResponse;
			listVpcEndpointServicesByEndUserResponse.MaxResults = _ctx.StringValue("ListVpcEndpointServicesByEndUser.MaxResults");
			listVpcEndpointServicesByEndUserResponse.NextToken = _ctx.StringValue("ListVpcEndpointServicesByEndUser.NextToken");
			listVpcEndpointServicesByEndUserResponse.RequestId = _ctx.StringValue("ListVpcEndpointServicesByEndUser.RequestId");

			List<ListVpcEndpointServicesByEndUserResponse.ListVpcEndpointServicesByEndUser_Service> listVpcEndpointServicesByEndUserResponse_services = new List<ListVpcEndpointServicesByEndUserResponse.ListVpcEndpointServicesByEndUser_Service>();
			for (int i = 0; i < _ctx.Length("ListVpcEndpointServicesByEndUser.Services.Length"); i++) {
				ListVpcEndpointServicesByEndUserResponse.ListVpcEndpointServicesByEndUser_Service service = new ListVpcEndpointServicesByEndUserResponse.ListVpcEndpointServicesByEndUser_Service();
				service.ServiceDomain = _ctx.StringValue("ListVpcEndpointServicesByEndUser.Services["+ i +"].ServiceDomain");
				service.ServiceId = _ctx.StringValue("ListVpcEndpointServicesByEndUser.Services["+ i +"].ServiceId");
				service.ServiceName = _ctx.StringValue("ListVpcEndpointServicesByEndUser.Services["+ i +"].ServiceName");
				service.Payer = _ctx.StringValue("ListVpcEndpointServicesByEndUser.Services["+ i +"].Payer");

				List<string> service_zones = new List<string>();
				for (int j = 0; j < _ctx.Length("ListVpcEndpointServicesByEndUser.Services["+ i +"].Zones.Length"); j++) {
					service_zones.Add(_ctx.StringValue("ListVpcEndpointServicesByEndUser.Services["+ i +"].Zones["+ j +"]"));
				}
				service.Zones = service_zones;

				listVpcEndpointServicesByEndUserResponse_services.Add(service);
			}
			listVpcEndpointServicesByEndUserResponse.Services = listVpcEndpointServicesByEndUserResponse_services;
        
			return listVpcEndpointServicesByEndUserResponse;
        }
    }
}
