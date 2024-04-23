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
using Aliyun.Acs.ComputeNest.Model.V20210601;

namespace Aliyun.Acs.ComputeNest.Transform.V20210601
{
    public class GetServiceInstanceResponseUnmarshaller
    {
        public static GetServiceInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetServiceInstanceResponse getServiceInstanceResponse = new GetServiceInstanceResponse();

			getServiceInstanceResponse.HttpResponse = _ctx.HttpResponse;
			getServiceInstanceResponse.Outputs = _ctx.StringValue("GetServiceInstance.Outputs");
			getServiceInstanceResponse.Status = _ctx.StringValue("GetServiceInstance.Status");
			getServiceInstanceResponse.TemplateName = _ctx.StringValue("GetServiceInstance.TemplateName");
			getServiceInstanceResponse.UpdateTime = _ctx.StringValue("GetServiceInstance.UpdateTime");
			getServiceInstanceResponse.Progress = _ctx.LongValue("GetServiceInstance.Progress");
			getServiceInstanceResponse.Parameters = _ctx.StringValue("GetServiceInstance.Parameters");
			getServiceInstanceResponse.RequestId = _ctx.StringValue("GetServiceInstance.RequestId");
			getServiceInstanceResponse.ServiceInstanceId = _ctx.StringValue("GetServiceInstance.ServiceInstanceId");
			getServiceInstanceResponse.CreateTime = _ctx.StringValue("GetServiceInstance.CreateTime");
			getServiceInstanceResponse.StatusDetail = _ctx.StringValue("GetServiceInstance.StatusDetail");
			getServiceInstanceResponse.Resources = _ctx.StringValue("GetServiceInstance.Resources");
			getServiceInstanceResponse.OperationStartTime = _ctx.StringValue("GetServiceInstance.OperationStartTime");
			getServiceInstanceResponse.OperationEndTime = _ctx.StringValue("GetServiceInstance.OperationEndTime");
			getServiceInstanceResponse.OperatedServiceInstanceId = _ctx.StringValue("GetServiceInstance.OperatedServiceInstanceId");
			getServiceInstanceResponse.EnableInstanceOps = _ctx.BooleanValue("GetServiceInstance.EnableInstanceOps");
			getServiceInstanceResponse.IsOperated = _ctx.BooleanValue("GetServiceInstance.IsOperated");
			getServiceInstanceResponse.LicenseEndTime = _ctx.StringValue("GetServiceInstance.LicenseEndTime");
			getServiceInstanceResponse.UserId = _ctx.LongValue("GetServiceInstance.UserId");
			getServiceInstanceResponse.SupplierUid = _ctx.LongValue("GetServiceInstance.SupplierUid");
			getServiceInstanceResponse.EndTime = _ctx.StringValue("GetServiceInstance.EndTime");
			getServiceInstanceResponse.Source = _ctx.StringValue("GetServiceInstance.Source");
			getServiceInstanceResponse.ServiceType = _ctx.StringValue("GetServiceInstance.ServiceType");
			getServiceInstanceResponse.PayType = _ctx.StringValue("GetServiceInstance.PayType");
			getServiceInstanceResponse.Name = _ctx.StringValue("GetServiceInstance.Name");
			getServiceInstanceResponse.EnableUserPrometheus = _ctx.BooleanValue("GetServiceInstance.EnableUserPrometheus");
			getServiceInstanceResponse.Components = _ctx.StringValue("GetServiceInstance.Components");
			getServiceInstanceResponse.PredefinedParameterName = _ctx.StringValue("GetServiceInstance.PredefinedParameterName");
			getServiceInstanceResponse.MarketInstanceId = _ctx.StringValue("GetServiceInstance.MarketInstanceId");
			getServiceInstanceResponse.ResourceGroupId = _ctx.StringValue("GetServiceInstance.ResourceGroupId");
			getServiceInstanceResponse.BizStatus = _ctx.StringValue("GetServiceInstance.BizStatus");
			getServiceInstanceResponse.GrafanaDashBoardUrl = _ctx.StringValue("GetServiceInstance.GrafanaDashBoardUrl");

			GetServiceInstanceResponse.GetServiceInstance_Service service = new GetServiceInstanceResponse.GetServiceInstance_Service();
			service.Status = _ctx.StringValue("GetServiceInstance.Service.Status");
			service.PublishTime = _ctx.StringValue("GetServiceInstance.Service.PublishTime");
			service.Version = _ctx.StringValue("GetServiceInstance.Service.Version");
			service.DeployMetadata = _ctx.StringValue("GetServiceInstance.Service.DeployMetadata");
			service.DeployType = _ctx.StringValue("GetServiceInstance.Service.DeployType");
			service.ServiceId = _ctx.StringValue("GetServiceInstance.Service.ServiceId");
			service.SupplierUrl = _ctx.StringValue("GetServiceInstance.Service.SupplierUrl");
			service.ServiceType = _ctx.StringValue("GetServiceInstance.Service.ServiceType");
			service.SupplierName = _ctx.StringValue("GetServiceInstance.Service.SupplierName");
			service.VersionName = _ctx.StringValue("GetServiceInstance.Service.VersionName");
			service.UpgradeMetadata = _ctx.StringValue("GetServiceInstance.Service.UpgradeMetadata");
			service.ServiceProductUrl = _ctx.StringValue("GetServiceInstance.Service.ServiceProductUrl");
			service.ServiceDocUrl = _ctx.StringValue("GetServiceInstance.Service.ServiceDocUrl");

			List<string> service_upgradableServiceVersions = new List<string>();
			for (int i = 0; i < _ctx.Length("GetServiceInstance.Service.UpgradableServiceVersions.Length"); i++) {
				service_upgradableServiceVersions.Add(_ctx.StringValue("GetServiceInstance.Service.UpgradableServiceVersions["+ i +"]"));
			}
			service.UpgradableServiceVersions = service_upgradableServiceVersions;

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
			networkConfig.EndpointId = _ctx.StringValue("GetServiceInstance.NetworkConfig.EndpointId");
			networkConfig.PrivateZoneId = _ctx.StringValue("GetServiceInstance.NetworkConfig.PrivateZoneId");

			List<GetServiceInstanceResponse.GetServiceInstance_NetworkConfig.GetServiceInstance_PrivateVpcConnection> networkConfig_privateVpcConnections = new List<GetServiceInstanceResponse.GetServiceInstance_NetworkConfig.GetServiceInstance_PrivateVpcConnection>();
			for (int i = 0; i < _ctx.Length("GetServiceInstance.NetworkConfig.PrivateVpcConnections.Length"); i++) {
				GetServiceInstanceResponse.GetServiceInstance_NetworkConfig.GetServiceInstance_PrivateVpcConnection privateVpcConnection = new GetServiceInstanceResponse.GetServiceInstance_NetworkConfig.GetServiceInstance_PrivateVpcConnection();
				privateVpcConnection.EndpointId = _ctx.StringValue("GetServiceInstance.NetworkConfig.PrivateVpcConnections["+ i +"].EndpointId");
				privateVpcConnection.PrivateZoneId = _ctx.StringValue("GetServiceInstance.NetworkConfig.PrivateVpcConnections["+ i +"].PrivateZoneId");
				privateVpcConnection.PrivateZoneName = _ctx.StringValue("GetServiceInstance.NetworkConfig.PrivateVpcConnections["+ i +"].PrivateZoneName");
				privateVpcConnection.RegionId = _ctx.StringValue("GetServiceInstance.NetworkConfig.PrivateVpcConnections["+ i +"].RegionId");

				List<GetServiceInstanceResponse.GetServiceInstance_NetworkConfig.GetServiceInstance_PrivateVpcConnection.GetServiceInstance_ConnectionConfig> privateVpcConnection_connectionConfigs = new List<GetServiceInstanceResponse.GetServiceInstance_NetworkConfig.GetServiceInstance_PrivateVpcConnection.GetServiceInstance_ConnectionConfig>();
				for (int j = 0; j < _ctx.Length("GetServiceInstance.NetworkConfig.PrivateVpcConnections["+ i +"].ConnectionConfigs.Length"); j++) {
					GetServiceInstanceResponse.GetServiceInstance_NetworkConfig.GetServiceInstance_PrivateVpcConnection.GetServiceInstance_ConnectionConfig connectionConfig = new GetServiceInstanceResponse.GetServiceInstance_NetworkConfig.GetServiceInstance_PrivateVpcConnection.GetServiceInstance_ConnectionConfig();
					connectionConfig.VpcId = _ctx.StringValue("GetServiceInstance.NetworkConfig.PrivateVpcConnections["+ i +"].ConnectionConfigs["+ j +"].VpcId");
					connectionConfig.IngressEndpointStatus = _ctx.StringValue("GetServiceInstance.NetworkConfig.PrivateVpcConnections["+ i +"].ConnectionConfigs["+ j +"].IngressEndpointStatus");
					connectionConfig.NetworkServiceStatus = _ctx.StringValue("GetServiceInstance.NetworkConfig.PrivateVpcConnections["+ i +"].ConnectionConfigs["+ j +"].NetworkServiceStatus");
					connectionConfig.DomainName = _ctx.StringValue("GetServiceInstance.NetworkConfig.PrivateVpcConnections["+ i +"].ConnectionConfigs["+ j +"].DomainName");
					connectionConfig.RegionId = _ctx.StringValue("GetServiceInstance.NetworkConfig.PrivateVpcConnections["+ i +"].ConnectionConfigs["+ j +"].RegionId");
					connectionConfig.ConnectBandwidth = _ctx.IntegerValue("GetServiceInstance.NetworkConfig.PrivateVpcConnections["+ i +"].ConnectionConfigs["+ j +"].ConnectBandwidth");

					List<string> connectionConfig_securityGroups = new List<string>();
					for (int k = 0; k < _ctx.Length("GetServiceInstance.NetworkConfig.PrivateVpcConnections["+ i +"].ConnectionConfigs["+ j +"].SecurityGroups.Length"); k++) {
						connectionConfig_securityGroups.Add(_ctx.StringValue("GetServiceInstance.NetworkConfig.PrivateVpcConnections["+ i +"].ConnectionConfigs["+ j +"].SecurityGroups["+ k +"]"));
					}
					connectionConfig.SecurityGroups = connectionConfig_securityGroups;

					List<string> connectionConfig_vSwitches = new List<string>();
					for (int k = 0; k < _ctx.Length("GetServiceInstance.NetworkConfig.PrivateVpcConnections["+ i +"].ConnectionConfigs["+ j +"].VSwitches.Length"); k++) {
						connectionConfig_vSwitches.Add(_ctx.StringValue("GetServiceInstance.NetworkConfig.PrivateVpcConnections["+ i +"].ConnectionConfigs["+ j +"].VSwitches["+ k +"]"));
					}
					connectionConfig.VSwitches = connectionConfig_vSwitches;

					List<string> connectionConfig_endpointIps = new List<string>();
					for (int k = 0; k < _ctx.Length("GetServiceInstance.NetworkConfig.PrivateVpcConnections["+ i +"].ConnectionConfigs["+ j +"].EndpointIps.Length"); k++) {
						connectionConfig_endpointIps.Add(_ctx.StringValue("GetServiceInstance.NetworkConfig.PrivateVpcConnections["+ i +"].ConnectionConfigs["+ j +"].EndpointIps["+ k +"]"));
					}
					connectionConfig.EndpointIps = connectionConfig_endpointIps;

					privateVpcConnection_connectionConfigs.Add(connectionConfig);
				}
				privateVpcConnection.ConnectionConfigs = privateVpcConnection_connectionConfigs;

				networkConfig_privateVpcConnections.Add(privateVpcConnection);
			}
			networkConfig.PrivateVpcConnections = networkConfig_privateVpcConnections;

			List<GetServiceInstanceResponse.GetServiceInstance_NetworkConfig.GetServiceInstance_ReversePrivateVpcConnection> networkConfig_reversePrivateVpcConnections = new List<GetServiceInstanceResponse.GetServiceInstance_NetworkConfig.GetServiceInstance_ReversePrivateVpcConnection>();
			for (int i = 0; i < _ctx.Length("GetServiceInstance.NetworkConfig.ReversePrivateVpcConnections.Length"); i++) {
				GetServiceInstanceResponse.GetServiceInstance_NetworkConfig.GetServiceInstance_ReversePrivateVpcConnection reversePrivateVpcConnection = new GetServiceInstanceResponse.GetServiceInstance_NetworkConfig.GetServiceInstance_ReversePrivateVpcConnection();
				reversePrivateVpcConnection.EndpointId = _ctx.StringValue("GetServiceInstance.NetworkConfig.ReversePrivateVpcConnections["+ i +"].EndpointId");

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
