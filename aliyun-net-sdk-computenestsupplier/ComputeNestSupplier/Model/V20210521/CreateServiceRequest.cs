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

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.ComputeNestSupplier;
using Aliyun.Acs.ComputeNestSupplier.Transform;
using Aliyun.Acs.ComputeNestSupplier.Transform.V20210521;

namespace Aliyun.Acs.ComputeNestSupplier.Model.V20210521
{
    public class CreateServiceRequest : RpcAcsRequest<CreateServiceResponse>
    {
        public CreateServiceRequest()
            : base("ComputeNestSupplier", "2021-05-21", "CreateService")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.ComputeNestSupplier.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.ComputeNestSupplier.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string alarmMetadata;

		private string clientToken;

		private string policyNames;

		private string licenseMetadata;

		private long? duration;

		private string resourceGroupId;

		private string approvalType;

		private long? trialDuration;

		private string shareType;

		private List<string> tags = new List<string>(){ };

		private string upgradeMetadata;

		private string deployMetadata;

		private string serviceType;

		private bool? isSupportOperated;

		private string tenantType;

		private List<string> serviceInfos = new List<string>(){ };

		private string serviceId;

		private string versionName;

		private string operationMetadata;

		private string deployType;

		public string AlarmMetadata
		{
			get
			{
				return alarmMetadata;
			}
			set	
			{
				alarmMetadata = value;
				DictionaryUtil.Add(QueryParameters, "AlarmMetadata", value);
			}
		}

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
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
				DictionaryUtil.Add(QueryParameters, "PolicyNames", value);
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
				DictionaryUtil.Add(QueryParameters, "LicenseMetadata", value);
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
				DictionaryUtil.Add(QueryParameters, "Duration", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "ResourceGroupId", value);
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
				DictionaryUtil.Add(QueryParameters, "ApprovalType", value);
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
				DictionaryUtil.Add(QueryParameters, "TrialDuration", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "ShareType", value);
			}
		}

		public List<string> Tags
		{
			get
			{
				return tags;
			}

			set
			{
				tags = value;
				if(tags != null)
				{
					for (int depth1 = 0; depth1 < tags.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"Tag." + (depth1 + 1), tags[depth1]);
						DictionaryUtil.Add(QueryParameters,"Tag." + (depth1 + 1), tags[depth1]);
					}
				}
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
				DictionaryUtil.Add(QueryParameters, "UpgradeMetadata", value);
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
				DictionaryUtil.Add(QueryParameters, "DeployMetadata", value);
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
				DictionaryUtil.Add(QueryParameters, "ServiceType", value);
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
				DictionaryUtil.Add(QueryParameters, "IsSupportOperated", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "TenantType", value);
			}
		}

		public List<string> ServiceInfos
		{
			get
			{
				return serviceInfos;
			}

			set
			{
				serviceInfos = value;
				if(serviceInfos != null)
				{
					for (int depth1 = 0; depth1 < serviceInfos.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"ServiceInfo." + (depth1 + 1), serviceInfos[depth1]);
						DictionaryUtil.Add(QueryParameters,"ServiceInfo." + (depth1 + 1), serviceInfos[depth1]);
						DictionaryUtil.Add(QueryParameters,"ServiceInfo." + (depth1 + 1), serviceInfos[depth1]);
						DictionaryUtil.Add(QueryParameters,"ServiceInfo." + (depth1 + 1), serviceInfos[depth1]);
					}
				}
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
				DictionaryUtil.Add(QueryParameters, "ServiceId", value);
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
				DictionaryUtil.Add(QueryParameters, "VersionName", value);
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
				DictionaryUtil.Add(QueryParameters, "OperationMetadata", value);
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
				DictionaryUtil.Add(QueryParameters, "DeployType", value);
			}
		}

		public class Tag
		{

			private string value_;

			private string key;

			public string Value_
			{
				get
				{
					return value_;
				}
				set	
				{
					value_ = value;
				}
			}

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
		}

		public class ServiceInfo
		{

			private string shortDescription;

			private string image;

			private string name;

			private string locale;

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
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateServiceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateServiceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
