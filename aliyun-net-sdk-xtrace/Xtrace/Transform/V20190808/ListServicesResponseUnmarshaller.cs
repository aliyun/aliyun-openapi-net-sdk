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
using Aliyun.Acs.xtrace.Model.V20190808;

namespace Aliyun.Acs.xtrace.Transform.V20190808
{
    public class ListServicesResponseUnmarshaller
    {
        public static ListServicesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListServicesResponse listServicesResponse = new ListServicesResponse();

			listServicesResponse.HttpResponse = _ctx.HttpResponse;
			listServicesResponse.RequestId = _ctx.StringValue("ListServices.RequestId");

			List<ListServicesResponse.ListServices_Service> listServicesResponse_services = new List<ListServicesResponse.ListServices_Service>();
			for (int i = 0; i < _ctx.Length("ListServices.Services.Length"); i++) {
				ListServicesResponse.ListServices_Service service = new ListServicesResponse.ListServices_Service();
				service.ServiceName = _ctx.StringValue("ListServices.Services["+ i +"].ServiceName");
				service.Pid = _ctx.StringValue("ListServices.Services["+ i +"].Pid");
				service.RegionId = _ctx.StringValue("ListServices.Services["+ i +"].RegionId");

				listServicesResponse_services.Add(service);
			}
			listServicesResponse.Services = listServicesResponse_services;
        
			return listServicesResponse;
        }
    }
}
