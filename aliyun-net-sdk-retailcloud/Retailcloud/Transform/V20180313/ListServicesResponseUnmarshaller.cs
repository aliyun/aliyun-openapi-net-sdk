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
using Aliyun.Acs.retailcloud.Model.V20180313;

namespace Aliyun.Acs.retailcloud.Transform.V20180313
{
    public class ListServicesResponseUnmarshaller
    {
        public static ListServicesResponse Unmarshall(UnmarshallerContext context)
        {
			ListServicesResponse listServicesResponse = new ListServicesResponse();

			listServicesResponse.HttpResponse = context.HttpResponse;
			listServicesResponse.Code = context.IntegerValue("ListServices.Code");
			listServicesResponse.ErrorMsg = context.StringValue("ListServices.ErrorMsg");
			listServicesResponse.PageNumber = context.IntegerValue("ListServices.PageNumber");
			listServicesResponse.PageSize = context.IntegerValue("ListServices.PageSize");
			listServicesResponse.RequestId = context.StringValue("ListServices.RequestId");
			listServicesResponse.TotalCount = context.LongValue("ListServices.TotalCount");
			listServicesResponse.ClusterIP = context.StringValue("ListServices.ClusterIP");
			listServicesResponse.ClusterIP1 = context.StringValue("ListServices.ClusterIP");

			List<ListServicesResponse.ListServices_ServiceInstance> listServicesResponse_data = new List<ListServicesResponse.ListServices_ServiceInstance>();
			for (int i = 0; i < context.Length("ListServices.Data.Length"); i++) {
				ListServicesResponse.ListServices_ServiceInstance serviceInstance = new ListServicesResponse.ListServices_ServiceInstance();
				serviceInstance.AppId = context.LongValue("ListServices.Data["+ i +"].AppId");
				serviceInstance.EnvId = context.LongValue("ListServices.Data["+ i +"].EnvId");
				serviceInstance.Headless = context.BooleanValue("ListServices.Data["+ i +"].Headless");
				serviceInstance.K8sServiceId = context.StringValue("ListServices.Data["+ i +"].K8sServiceId");
				serviceInstance.Name = context.StringValue("ListServices.Data["+ i +"].Name");
				serviceInstance.ServiceId = context.LongValue("ListServices.Data["+ i +"].ServiceId");
				serviceInstance.ServiceType = context.StringValue("ListServices.Data["+ i +"].ServiceType");
				serviceInstance.ClusterIP = context.StringValue("ListServices.Data["+ i +"].ClusterIP");

				List<ListServicesResponse.ListServices_ServiceInstance.ListServices_ServicePortMapping> serviceInstance_portMappings = new List<ListServicesResponse.ListServices_ServiceInstance.ListServices_ServicePortMapping>();
				for (int j = 0; j < context.Length("ListServices.Data["+ i +"].PortMappings.Length"); j++) {
					ListServicesResponse.ListServices_ServiceInstance.ListServices_ServicePortMapping servicePortMapping = new ListServicesResponse.ListServices_ServiceInstance.ListServices_ServicePortMapping();
					servicePortMapping.Name = context.StringValue("ListServices.Data["+ i +"].PortMappings["+ j +"].Name");
					servicePortMapping.NodePort = context.IntegerValue("ListServices.Data["+ i +"].PortMappings["+ j +"].NodePort");
					servicePortMapping.Port = context.IntegerValue("ListServices.Data["+ i +"].PortMappings["+ j +"].Port");
					servicePortMapping.Protocol = context.StringValue("ListServices.Data["+ i +"].PortMappings["+ j +"].Protocol");
					servicePortMapping.TargetPort = context.StringValue("ListServices.Data["+ i +"].PortMappings["+ j +"].TargetPort");

					serviceInstance_portMappings.Add(servicePortMapping);
				}
				serviceInstance.PortMappings = serviceInstance_portMappings;

				listServicesResponse_data.Add(serviceInstance);
			}
			listServicesResponse.Data = listServicesResponse_data;
        
			return listServicesResponse;
        }
    }
}
