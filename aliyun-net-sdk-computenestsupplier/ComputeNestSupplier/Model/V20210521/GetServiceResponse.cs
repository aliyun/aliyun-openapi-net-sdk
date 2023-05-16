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
	public class GetServiceResponse : AcsResponse
	{

		private string status;

		private string deployMetadata;

		private string publishTime;

		private string requestId;

		private string version;

		private string deployType;

		private string serviceId;

		private string supplierUrl;

		private string serviceDocUrl;

		private string serviceProductUrl;

		private string serviceType;

		private string supplierName;

		private string commodityCode;

		private bool? isSupportOperated;

		private string policyNames;

		private long? duration;

		private long? progress;

		private string statusDetail;

		private string createTime;

		private string updateTime;

		private string shareType;

		private string alarmMetadata;

		private string upgradeMetadata;

		private string versionName;

		private string payFromType;

		private string payType;

		private long? defaultLicenseDays;

		private long? trialDuration;

		private string trialType;

		private string tenantType;

		private string licenseMetadata;

		private string operationMetadata;

		private string testStatus;

		private string approvalType;

		private string registrationId;

		private string resourceGroupId;

		private string permission;

		private List<GetService_ServiceInfo> serviceInfos;

		private List<GetService_CommoditySpecification> commoditySpecifications;

		private List<GetService_Tag> tags;

		private List<GetService_CommodityEntitiesItem> commodityEntities;

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

		public string CommodityCode
		{
			get
			{
				return commodityCode;
			}
			set	
			{
				commodityCode = value;
			}
		}

		public bool? IsSupportOperated
		{
			get
			{
				return isSupportOperated;
			}
			set	
			{
				isSupportOperated = value;
			}
		}

		public string PolicyNames
		{
			get
			{
				return policyNames;
			}
			set	
			{
				policyNames = value;
			}
		}

		public long? Duration
		{
			get
			{
				return duration;
			}
			set	
			{
				duration = value;
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

		public string ShareType
		{
			get
			{
				return shareType;
			}
			set	
			{
				shareType = value;
			}
		}

		public string AlarmMetadata
		{
			get
			{
				return alarmMetadata;
			}
			set	
			{
				alarmMetadata = value;
			}
		}

		public string UpgradeMetadata
		{
			get
			{
				return upgradeMetadata;
			}
			set	
			{
				upgradeMetadata = value;
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

		public string PayFromType
		{
			get
			{
				return payFromType;
			}
			set	
			{
				payFromType = value;
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

		public long? DefaultLicenseDays
		{
			get
			{
				return defaultLicenseDays;
			}
			set	
			{
				defaultLicenseDays = value;
			}
		}

		public long? TrialDuration
		{
			get
			{
				return trialDuration;
			}
			set	
			{
				trialDuration = value;
			}
		}

		public string TrialType
		{
			get
			{
				return trialType;
			}
			set	
			{
				trialType = value;
			}
		}

		public string TenantType
		{
			get
			{
				return tenantType;
			}
			set	
			{
				tenantType = value;
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

		public string OperationMetadata
		{
			get
			{
				return operationMetadata;
			}
			set	
			{
				operationMetadata = value;
			}
		}

		public string TestStatus
		{
			get
			{
				return testStatus;
			}
			set	
			{
				testStatus = value;
			}
		}

		public string ApprovalType
		{
			get
			{
				return approvalType;
			}
			set	
			{
				approvalType = value;
			}
		}

		public string RegistrationId
		{
			get
			{
				return registrationId;
			}
			set	
			{
				registrationId = value;
			}
		}

		public string ResourceGroupId
		{
			get
			{
				return resourceGroupId;
			}
			set	
			{
				resourceGroupId = value;
			}
		}

		public string Permission
		{
			get
			{
				return permission;
			}
			set	
			{
				permission = value;
			}
		}

		public List<GetService_ServiceInfo> ServiceInfos
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

		public List<GetService_CommoditySpecification> CommoditySpecifications
		{
			get
			{
				return commoditySpecifications;
			}
			set	
			{
				commoditySpecifications = value;
			}
		}

		public List<GetService_Tag> Tags
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

		public List<GetService_CommodityEntitiesItem> CommodityEntities
		{
			get
			{
				return commodityEntities;
			}
			set	
			{
				commodityEntities = value;
			}
		}

		public class GetService_ServiceInfo
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

		public class GetService_CommoditySpecification
		{

			private string specificationCode;

			private string templateName;

			private string predefinedParameterName;

			public string SpecificationCode
			{
				get
				{
					return specificationCode;
				}
				set	
				{
					specificationCode = value;
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

			public string PredefinedParameterName
			{
				get
				{
					return predefinedParameterName;
				}
				set	
				{
					predefinedParameterName = value;
				}
			}
		}

		public class GetService_Tag
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

		public class GetService_CommodityEntitiesItem
		{

			private string templateName;

			private string predefinedParameterName;

			private List<string> entityIds;

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

			public string PredefinedParameterName
			{
				get
				{
					return predefinedParameterName;
				}
				set	
				{
					predefinedParameterName = value;
				}
			}

			public List<string> EntityIds
			{
				get
				{
					return entityIds;
				}
				set	
				{
					entityIds = value;
				}
			}
		}
	}
}
