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
using System.Collections.Generic;
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.ComputeNestSupplier.Model.V20210521
{
	public class GetServiceInstanceResponse : AcsResponse
	{

		private string status;

		private string templateName;

		private string updateTime;

		private string requestId;

		private string serviceInstanceId;

		private string createTime;

		private long? userId;

		private long? supplierUid;

		private string parameters;

		private long? progress;

		private string statusDetail;

		private string operationStartTime;

		private string operationEndTime;

		private string operatedServiceInstanceId;

		private bool? isOperated;

		private bool? enableInstanceOps;

		private string resources;

		private string outputs;

		private string endTime;

		private string source;

		private string serviceType;

		private string payType;

		private string licenseMetadata;

		private string name;

		private string enableUserPrometheus;

		private string rdAccountLoginUrl;

		private List<GetServiceInstance_Tag> tags;

		private GetServiceInstance_Service service;

		private GetServiceInstance_NetworkConfig networkConfig;

		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
			}
		}

		public string TemplateName
		{
			get
			{
				return templateName;
			}
			set	
			{
				templateName = value;
			}
		}

		public string UpdateTime
		{
			get
			{
				return updateTime;
			}
			set	
			{
				updateTime = value;
			}
		}

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public string ServiceInstanceId
		{
			get
			{
				return serviceInstanceId;
			}
			set	
			{
				serviceInstanceId = value;
			}
		}

		public string CreateTime
		{
			get
			{
				return createTime;
			}
			set	
			{
				createTime = value;
			}
		}

		public long? UserId
		{
			get
			{
				return userId;
			}
			set	
			{
				userId = value;
			}
		}

		public long? SupplierUid
		{
			get
			{
				return supplierUid;
			}
			set	
			{
				supplierUid = value;
			}
		}

		public string Parameters
		{
			get
			{
				return parameters;
			}
			set	
			{
				parameters = value;
			}
		}

		public long? Progress
		{
			get
			{
				return progress;
			}
			set	
			{
				progress = value;
			}
		}

		public string StatusDetail
		{
			get
			{
				return statusDetail;
			}
			set	
			{
				statusDetail = value;
			}
		}

		public string OperationStartTime
		{
			get
			{
				return operationStartTime;
			}
			set	
			{
				operationStartTime = value;
			}
		}

		public string OperationEndTime
		{
			get
			{
				return operationEndTime;
			}
			set	
			{
				operationEndTime = value;
			}
		}

		public string OperatedServiceInstanceId
		{
			get
			{
				return operatedServiceInstanceId;
			}
			set	
			{
				operatedServiceInstanceId = value;
			}
		}

		public bool? IsOperated
		{
			get
			{
				return isOperated;
			}
			set	
			{
				isOperated = value;
			}
		}

		public bool? EnableInstanceOps
		{
			get
			{
				return enableInstanceOps;
			}
			set	
			{
				enableInstanceOps = value;
			}
		}

		public string Resources
		{
			get
			{
				return resources;
			}
			set	
			{
				resources = value;
			}
		}

		public string Outputs
		{
			get
			{
				return outputs;
			}
			set	
			{
				outputs = value;
			}
		}

		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
			}
		}

		public string Source
		{
			get
			{
				return source;
			}
			set	
			{
				source = value;
			}
		}

		public string ServiceType
		{
			get
			{
				return serviceType;
			}
			set	
			{
				serviceType = value;
			}
		}

		public string PayType
		{
			get
			{
				return payType;
			}
			set	
			{
				payType = value;
			}
		}

		public string LicenseMetadata
		{
			get
			{
				return licenseMetadata;
			}
			set	
			{
				licenseMetadata = value;
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
			}
		}

		public string EnableUserPrometheus
		{
			get
			{
				return enableUserPrometheus;
			}
			set	
			{
				enableUserPrometheus = value;
			}
		}

		public string RdAccountLoginUrl
		{
			get
			{
				return rdAccountLoginUrl;
			}
			set	
			{
				rdAccountLoginUrl = value;
			}
		}

		public List<GetServiceInstance_Tag> Tags
		{
			get
			{
				return tags;
			}
			set	
			{
				tags = value;
			}
		}

		public GetServiceInstance_Service Service
		{
			get
			{
				return service;
			}
			set	
			{
				service = value;
			}
		}

		public GetServiceInstance_NetworkConfig NetworkConfig
		{
			get
			{
				return networkConfig;
			}
			set	
			{
				networkConfig = value;
			}
		}

		public class GetServiceInstance_Tag
		{

			private string key;

			private string _value;

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}

			public string _Value
			{
				get
				{
					return _value;
				}
				set	
				{
					_value = value;
				}
			}
		}

		public class GetServiceInstance_Service
		{

			private string status;

			private string publishTime;

			private string version;

			private string deployMetadata;

			private string deployType;

			private string serviceId;

			private string supplierUrl;

			private string serviceProductUrl;

			private string serviceDocUrl;

			private string serviceType;

			private string supplierName;

			private string versionName;

			private List<GetServiceInstance_ServiceInfo> serviceInfos;

			private List<string> upgradableServiceVersions;

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public string PublishTime
			{
				get
				{
					return publishTime;
				}
				set	
				{
					publishTime = value;
				}
			}

			public string Version
			{
				get
				{
					return version;
				}
				set	
				{
					version = value;
				}
			}

			public string DeployMetadata
			{
				get
				{
					return deployMetadata;
				}
				set	
				{
					deployMetadata = value;
				}
			}

			public string DeployType
			{
				get
				{
					return deployType;
				}
				set	
				{
					deployType = value;
				}
			}

			public string ServiceId
			{
				get
				{
					return serviceId;
				}
				set	
				{
					serviceId = value;
				}
			}

			public string SupplierUrl
			{
				get
				{
					return supplierUrl;
				}
				set	
				{
					supplierUrl = value;
				}
			}

			public string ServiceProductUrl
			{
				get
				{
					return serviceProductUrl;
				}
				set	
				{
					serviceProductUrl = value;
				}
			}

			public string ServiceDocUrl
			{
				get
				{
					return serviceDocUrl;
				}
				set	
				{
					serviceDocUrl = value;
				}
			}

			public string ServiceType
			{
				get
				{
					return serviceType;
				}
				set	
				{
					serviceType = value;
				}
			}

			public string SupplierName
			{
				get
				{
					return supplierName;
				}
				set	
				{
					supplierName = value;
				}
			}

			public string VersionName
			{
				get
				{
					return versionName;
				}
				set	
				{
					versionName = value;
				}
			}

			public List<GetServiceInstance_ServiceInfo> ServiceInfos
			{
				get
				{
					return serviceInfos;
				}
				set	
				{
					serviceInfos = value;
				}
			}

			public List<string> UpgradableServiceVersions
			{
				get
				{
					return upgradableServiceVersions;
				}
				set	
				{
					upgradableServiceVersions = value;
				}
			}

			public class GetServiceInstance_ServiceInfo
			{

				private string locale;

				private string image;

				private string name;

				private string shortDescription;

				public string Locale
				{
					get
					{
						return locale;
					}
					set	
					{
						locale = value;
					}
				}

				public string Image
				{
					get
					{
						return image;
					}
					set	
					{
						image = value;
					}
				}

				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}

				public string ShortDescription
				{
					get
					{
						return shortDescription;
					}
					set	
					{
						shortDescription = value;
					}
				}
			}
		}

		public class GetServiceInstance_NetworkConfig
		{

			private string endpointServiceId;

			private string endpointId;

			private List<GetServiceInstance_PrivateVpcConnection> privateVpcConnections;

			private List<GetServiceInstance_ReversePrivateVpcConnection> reversePrivateVpcConnections;

			public string EndpointServiceId
			{
				get
				{
					return endpointServiceId;
				}
				set	
				{
					endpointServiceId = value;
				}
			}

			public string EndpointId
			{
				get
				{
					return endpointId;
				}
				set	
				{
					endpointId = value;
				}
			}

			public List<GetServiceInstance_PrivateVpcConnection> PrivateVpcConnections
			{
				get
				{
					return privateVpcConnections;
				}
				set	
				{
					privateVpcConnections = value;
				}
			}

			public List<GetServiceInstance_ReversePrivateVpcConnection> ReversePrivateVpcConnections
			{
				get
				{
					return reversePrivateVpcConnections;
				}
				set	
				{
					reversePrivateVpcConnections = value;
				}
			}

			public class GetServiceInstance_PrivateVpcConnection
			{

				private string endpointId;

				private string endpointServiceId;

				private string privateZoneName;

				private List<GetServiceInstance_ConnectionConfig> connectionConfigs;

				public string EndpointId
				{
					get
					{
						return endpointId;
					}
					set	
					{
						endpointId = value;
					}
				}

				public string EndpointServiceId
				{
					get
					{
						return endpointServiceId;
					}
					set	
					{
						endpointServiceId = value;
					}
				}

				public string PrivateZoneName
				{
					get
					{
						return privateZoneName;
					}
					set	
					{
						privateZoneName = value;
					}
				}

				public List<GetServiceInstance_ConnectionConfig> ConnectionConfigs
				{
					get
					{
						return connectionConfigs;
					}
					set	
					{
						connectionConfigs = value;
					}
				}

				public class GetServiceInstance_ConnectionConfig
				{

					private string vpcId;

					private string ingressEndpointStatus;

					private string networkServiceStatus;

					private string domainName;

					private int? connectBandwidth;

					private List<string> securityGroups;

					private List<string> vSwitches;

					private List<string> endpointIps;

					public string VpcId
					{
						get
						{
							return vpcId;
						}
						set	
						{
							vpcId = value;
						}
					}

					public string IngressEndpointStatus
					{
						get
						{
							return ingressEndpointStatus;
						}
						set	
						{
							ingressEndpointStatus = value;
						}
					}

					public string NetworkServiceStatus
					{
						get
						{
							return networkServiceStatus;
						}
						set	
						{
							networkServiceStatus = value;
						}
					}

					public string DomainName
					{
						get
						{
							return domainName;
						}
						set	
						{
							domainName = value;
						}
					}

					public int? ConnectBandwidth
					{
						get
						{
							return connectBandwidth;
						}
						set	
						{
							connectBandwidth = value;
						}
					}

					public List<string> SecurityGroups
					{
						get
						{
							return securityGroups;
						}
						set	
						{
							securityGroups = value;
						}
					}

					public List<string> VSwitches
					{
						get
						{
							return vSwitches;
						}
						set	
						{
							vSwitches = value;
						}
					}

					public List<string> EndpointIps
					{
						get
						{
							return endpointIps;
						}
						set	
						{
							endpointIps = value;
						}
					}
				}
			}

			public class GetServiceInstance_ReversePrivateVpcConnection
			{

				private string endpointId;

				private string endpointServiceId;

				public string EndpointId
				{
					get
					{
						return endpointId;
					}
					set	
					{
						endpointId = value;
					}
				}

				public string EndpointServiceId
				{
					get
					{
						return endpointServiceId;
					}
					set	
					{
						endpointServiceId = value;
					}
				}
			}
		}
	}
}
