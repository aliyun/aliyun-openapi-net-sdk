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
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class GetK8sServicesResponseUnmarshaller
    {
        public static GetK8sServicesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetK8sServicesResponse getK8sServicesResponse = new GetK8sServicesResponse();

			getK8sServicesResponse.HttpResponse = _ctx.HttpResponse;
			getK8sServicesResponse.Code = _ctx.IntegerValue("GetK8sServices.Code");
			getK8sServicesResponse.Message = _ctx.StringValue("GetK8sServices.Message");
			getK8sServicesResponse.RequestId = _ctx.StringValue("GetK8sServices.RequestId");

			List<GetK8sServicesResponse.GetK8sServices_ServicesItem> getK8sServicesResponse_services = new List<GetK8sServicesResponse.GetK8sServices_ServicesItem>();
			for (int i = 0; i < _ctx.Length("GetK8sServices.Services.Length"); i++) {
				GetK8sServicesResponse.GetK8sServices_ServicesItem servicesItem = new GetK8sServicesResponse.GetK8sServices_ServicesItem();
				servicesItem.Name = _ctx.StringValue("GetK8sServices.Services["+ i +"].Name");
				servicesItem.Type = _ctx.StringValue("GetK8sServices.Services["+ i +"].Type");
				servicesItem.ClusterIP = _ctx.StringValue("GetK8sServices.Services["+ i +"].ClusterIP");

				List<GetK8sServicesResponse.GetK8sServices_ServicesItem.GetK8sServices_ServicePortsItem> servicesItem_servicePorts = new List<GetK8sServicesResponse.GetK8sServices_ServicesItem.GetK8sServices_ServicePortsItem>();
				for (int j = 0; j < _ctx.Length("GetK8sServices.Services["+ i +"].ServicePorts.Length"); j++) {
					GetK8sServicesResponse.GetK8sServices_ServicesItem.GetK8sServices_ServicePortsItem servicePortsItem = new GetK8sServicesResponse.GetK8sServices_ServicesItem.GetK8sServices_ServicePortsItem();
					servicePortsItem.Protocol = _ctx.StringValue("GetK8sServices.Services["+ i +"].ServicePorts["+ j +"].Protocol");
					servicePortsItem.Port = _ctx.IntegerValue("GetK8sServices.Services["+ i +"].ServicePorts["+ j +"].Port");
					servicePortsItem.TargetPort = _ctx.StringValue("GetK8sServices.Services["+ i +"].ServicePorts["+ j +"].TargetPort");
					servicePortsItem.NodePort = _ctx.IntegerValue("GetK8sServices.Services["+ i +"].ServicePorts["+ j +"].NodePort");

					servicesItem_servicePorts.Add(servicePortsItem);
				}
				servicesItem.ServicePorts = servicesItem_servicePorts;

				getK8sServicesResponse_services.Add(servicesItem);
			}
			getK8sServicesResponse.Services = getK8sServicesResponse_services;
        
			return getK8sServicesResponse;
        }
    }
}
