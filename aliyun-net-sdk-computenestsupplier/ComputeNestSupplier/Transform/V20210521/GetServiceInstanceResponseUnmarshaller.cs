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
using Aliyun.Acs.ComputeNestSupplier.Model.V20210521;

namespace Aliyun.Acs.ComputeNestSupplier.Transform.V20210521
{
    public class GetServiceInstanceResponseUnmarshaller
    {
        public static GetServiceInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetServiceInstanceResponse getServiceInstanceResponse = new GetServiceInstanceResponse();

			getServiceInstanceResponse.HttpResponse = _ctx.HttpResponse;
			getServiceInstanceResponse.Status = _ctx.StringValue("GetServiceInstance.Status");
			getServiceInstanceResponse.TemplateName = _ctx.StringValue("GetServiceInstance.TemplateName");
			getServiceInstanceResponse.UpdateTime = _ctx.StringValue("GetServiceInstance.UpdateTime");
			getServiceInstanceResponse.RequestId = _ctx.StringValue("GetServiceInstance.RequestId");
			getServiceInstanceResponse.ServiceInstanceId = _ctx.StringValue("GetServiceInstance.ServiceInstanceId");
			getServiceInstanceResponse.CreateTime = _ctx.StringValue("GetServiceInstance.CreateTime");
			getServiceInstanceResponse.UserId = _ctx.LongValue("GetServiceInstance.UserId");
			getServiceInstanceResponse.SupplierUid = _ctx.LongValue("GetServiceInstance.SupplierUid");
			getServiceInstanceResponse.Parameters = _ctx.StringValue("GetServiceInstance.Parameters");
			getServiceInstanceResponse.Progress = _ctx.LongValue("GetServiceInstance.Progress");
			getServiceInstanceResponse.StatusDetail = _ctx.StringValue("GetServiceInstance.StatusDetail");
			getServiceInstanceResponse.OperationStartTime = _ctx.StringValue("GetServiceInstance.OperationStartTime");
			getServiceInstanceResponse.OperationEndTime = _ctx.StringValue("GetServiceInstance.OperationEndTime");
			getServiceInstanceResponse.OperatedServiceInstanceId = _ctx.StringValue("GetServiceInstance.OperatedServiceInstanceId");
			getServiceInstanceResponse.IsOperated = _ctx.BooleanValue("GetServiceInstance.IsOperated");
			getServiceInstanceResponse.EnableInstanceOps = _ctx.BooleanValue("GetServiceInstance.EnableInstanceOps");
			getServiceInstanceResponse.Resources = _ctx.StringValue("GetServiceInstance.Resources");
			getServiceInstanceResponse.Outputs = _ctx.StringValue("GetServiceInstance.Outputs");
			getServiceInstanceResponse.EndTime = _ctx.StringValue("GetServiceInstance.EndTime");
			getServiceInstanceResponse.Source = _ctx.StringValue("GetServiceInstance.Source");
			getServiceInstanceResponse.ServiceType = _ctx.StringValue("GetServiceInstance.ServiceType");
			getServiceInstanceResponse.PayType = _ctx.StringValue("GetServiceInstance.PayType");
			getServiceInstanceResponse.LicenseMetadata = _ctx.StringValue("GetServiceInstance.LicenseMetadata");
			getServiceInstanceResponse.Name = _ctx.StringValue("GetServiceInstance.Name");

			GetServiceInstanceResponse.GetServiceInstance_Service service = new GetServiceInstanceResponse.GetServiceInstance_Service();
			service.Status = _ctx.StringValue("GetServiceInstance.Service.Status");
			service.PublishTime = _ctx.StringValue("GetServiceInstance.Service.PublishTime");
			service.Version = _ctx.StringValue("GetServiceInstance.Service.Version");
			service.DeployMetadata = _ctx.StringValue("GetServiceInstance.Service.DeployMetadata");
			service.DeployType = _ctx.StringValue("GetServiceInstance.Service.DeployType");
			service.ServiceId = _ctx.StringValue("GetServiceInstance.Service.ServiceId");
			service.SupplierUrl = _ctx.StringValue("GetServiceInstance.Service.SupplierUrl");
			service.ServiceProductUrl = _ctx.StringValue("GetServiceInstance.Service.ServiceProductUrl");
			service.ServiceDocUrl = _ctx.StringValue("GetServiceInstance.Service.ServiceDocUrl");
			service.ServiceType = _ctx.StringValue("GetServiceInstance.Service.ServiceType");
			service.SupplierName = _ctx.StringValue("GetServiceInstance.Service.SupplierName");
			service.VersionName = _ctx.StringValue("GetServiceInstance.Service.VersionName");

			List<GetServiceInstanceResponse.GetServiceInstance_Service.GetServiceInstance_ServiceInfo> service_serviceInfos = new List<GetServiceInstanceResponse.GetServiceInstance_Service.GetServiceInstance_ServiceInfo>();
			for (int i = 0; i < _ctx.Length("GetServiceInstance.Service.ServiceInfos.Length"); i++) {
				GetServiceInstanceResponse.GetServiceInstance_Service.GetServiceInstance_ServiceInfo serviceInfo = new GetServiceInstanceResponse.GetServiceInstance_Service.GetServiceInstance_ServiceInfo();
				serviceInfo.Locale = _ctx.StringValue("GetServiceInstance.Service.ServiceInfos["+ i +"].Locale");
				serviceInfo.Image = _ctx.StringValue("GetServiceInstance.Service.ServiceInfos["+ i +"].Image");
				serviceInfo.Name = _ctx.StringValue("GetServiceInstance.Service.ServiceInfos["+ i +"].Name");
				serviceInfo.ShortDescription = _ctx.StringValue("GetServiceInstance.Service.ServiceInfos["+ i +"].ShortDescription");

				service_serviceInfos.Add(serviceInfo);
			}
			service.ServiceInfos = service_serviceInfos;
			getServiceInstanceResponse.Service = service;

			GetServiceInstanceResponse.GetServiceInstance_NetworkConfig networkConfig = new GetServiceInstanceResponse.GetServiceInstance_NetworkConfig();
			networkConfig.EndpointServiceId = _ctx.StringValue("GetServiceInstance.NetworkConfig.EndpointServiceId");
			networkConfig.EndpointId = _ctx.StringValue("GetServiceInstance.NetworkConfig.EndpointId");

			List<GetServiceInstanceResponse.GetServiceInstance_NetworkConfig.GetServiceInstance_PrivateVpcConnection> networkConfig_privateVpcConnections = new List<GetServiceInstanceResponse.GetServiceInstance_NetworkConfig.GetServiceInstance_PrivateVpcConnection>();
			for (int i = 0; i < _ctx.Length("GetServiceInstance.NetworkConfig.PrivateVpcConnections.Length"); i++) {
				GetServiceInstanceResponse.GetServiceInstance_NetworkConfig.GetServiceInstance_PrivateVpcConnection privateVpcConnection = new GetServiceInstanceResponse.GetServiceInstance_NetworkConfig.GetServiceInstance_PrivateVpcConnection();
				privateVpcConnection.EndpointId = _ctx.StringValue("GetServiceInstance.NetworkConfig.PrivateVpcConnections["+ i +"].EndpointId");
				privateVpcConnection.EndpointServiceId = _ctx.StringValue("GetServiceInstance.NetworkConfig.PrivateVpcConnections["+ i +"].EndpointServiceId");

				networkConfig_privateVpcConnections.Add(privateVpcConnection);
			}
			networkConfig.PrivateVpcConnections = networkConfig_privateVpcConnections;

			List<GetServiceInstanceResponse.GetServiceInstance_NetworkConfig.GetServiceInstance_ReversePrivateVpcConnection> networkConfig_reversePrivateVpcConnections = new List<GetServiceInstanceResponse.GetServiceInstance_NetworkConfig.GetServiceInstance_ReversePrivateVpcConnection>();
			for (int i = 0; i < _ctx.Length("GetServiceInstance.NetworkConfig.ReversePrivateVpcConnections.Length"); i++) {
				GetServiceInstanceResponse.GetServiceInstance_NetworkConfig.GetServiceInstance_ReversePrivateVpcConnection reversePrivateVpcConnection = new GetServiceInstanceResponse.GetServiceInstance_NetworkConfig.GetServiceInstance_ReversePrivateVpcConnection();
				reversePrivateVpcConnection.EndpointId = _ctx.StringValue("GetServiceInstance.NetworkConfig.ReversePrivateVpcConnections["+ i +"].EndpointId");
				reversePrivateVpcConnection.EndpointServiceId = _ctx.StringValue("GetServiceInstance.NetworkConfig.ReversePrivateVpcConnections["+ i +"].EndpointServiceId");

				networkConfig_reversePrivateVpcConnections.Add(reversePrivateVpcConnection);
			}
			networkConfig.ReversePrivateVpcConnections = networkConfig_reversePrivateVpcConnections;
			getServiceInstanceResponse.NetworkConfig = networkConfig;

			List<GetServiceInstanceResponse.GetServiceInstance_Tag> getServiceInstanceResponse_tags = new List<GetServiceInstanceResponse.GetServiceInstance_Tag>();
			for (int i = 0; i < _ctx.Length("GetServiceInstance.Tags.Length"); i++) {
				GetServiceInstanceResponse.GetServiceInstance_Tag tag = new GetServiceInstanceResponse.GetServiceInstance_Tag();
				tag.Key = _ctx.StringValue("GetServiceInstance.Tags["+ i +"].Key");
				tag._Value = _ctx.StringValue("GetServiceInstance.Tags["+ i +"].Value");

				getServiceInstanceResponse_tags.Add(tag);
			}
			getServiceInstanceResponse.Tags = getServiceInstanceResponse_tags;
        
			return getServiceInstanceResponse;
        }
    }
}
