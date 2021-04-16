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
    public class ListVpcEndpointServicesResponseUnmarshaller
    {
        public static ListVpcEndpointServicesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListVpcEndpointServicesResponse listVpcEndpointServicesResponse = new ListVpcEndpointServicesResponse();

			listVpcEndpointServicesResponse.HttpResponse = _ctx.HttpResponse;
			listVpcEndpointServicesResponse.RequestId = _ctx.StringValue("ListVpcEndpointServices.RequestId");
			listVpcEndpointServicesResponse.NextToken = _ctx.StringValue("ListVpcEndpointServices.NextToken");
			listVpcEndpointServicesResponse.MaxResults = _ctx.StringValue("ListVpcEndpointServices.MaxResults");

			List<ListVpcEndpointServicesResponse.ListVpcEndpointServices_Service> listVpcEndpointServicesResponse_services = new List<ListVpcEndpointServicesResponse.ListVpcEndpointServices_Service>();
			for (int i = 0; i < _ctx.Length("ListVpcEndpointServices.Services.Length"); i++) {
				ListVpcEndpointServicesResponse.ListVpcEndpointServices_Service service = new ListVpcEndpointServicesResponse.ListVpcEndpointServices_Service();
				service.Payer = _ctx.StringValue("ListVpcEndpointServices.Services["+ i +"].Payer");
				service.ServiceDescription = _ctx.StringValue("ListVpcEndpointServices.Services["+ i +"].ServiceDescription");
				service.MaxBandwidth = _ctx.IntegerValue("ListVpcEndpointServices.Services["+ i +"].MaxBandwidth");
				service.CreateTime = _ctx.StringValue("ListVpcEndpointServices.Services["+ i +"].CreateTime");
				service.ServiceDomain = _ctx.StringValue("ListVpcEndpointServices.Services["+ i +"].ServiceDomain");
				service.MinBandwidth = _ctx.IntegerValue("ListVpcEndpointServices.Services["+ i +"].MinBandwidth");
				service.ServiceId = _ctx.StringValue("ListVpcEndpointServices.Services["+ i +"].ServiceId");
				service.AutoAcceptEnabled = _ctx.BooleanValue("ListVpcEndpointServices.Services["+ i +"].AutoAcceptEnabled");
				service.ServiceBusinessStatus = _ctx.StringValue("ListVpcEndpointServices.Services["+ i +"].ServiceBusinessStatus");
				service.ServiceName = _ctx.StringValue("ListVpcEndpointServices.Services["+ i +"].ServiceName");
				service.ServiceStatus = _ctx.StringValue("ListVpcEndpointServices.Services["+ i +"].ServiceStatus");
				service.ConnectBandwidth = _ctx.IntegerValue("ListVpcEndpointServices.Services["+ i +"].ConnectBandwidth");
				service.RegionId = _ctx.StringValue("ListVpcEndpointServices.Services["+ i +"].RegionId");
				service.ZoneAffinityEnabled = _ctx.BooleanValue("ListVpcEndpointServices.Services["+ i +"].ZoneAffinityEnabled");

				listVpcEndpointServicesResponse_services.Add(service);
			}
			listVpcEndpointServicesResponse.Services = listVpcEndpointServicesResponse_services;
        
			return listVpcEndpointServicesResponse;
        }
    }
}
