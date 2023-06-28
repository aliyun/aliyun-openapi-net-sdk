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
	public class ListServicesResponse : AcsResponse
	{

		private string nextToken;

		private string requestId;

		private string totalCount;

		private int? maxResults;

		private List<ListServices_Service> services;

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
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

		public string TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public int? MaxResults
		{
			get
			{
				return maxResults;
			}
			set	
			{
				maxResults = value;
			}
		}

		public List<ListServices_Service> Services
		{
			get
			{
				return services;
			}
			set	
			{
				services = value;
			}
		}

		public class ListServices_Service
		{

			private string status;

			private bool? defaultVersion;

			private string publishTime;

			private string version;

			private string deployType;

			private string serviceId;

			private string supplierUrl;

			private string serviceType;

			private string supplierName;

			private string commodityCode;

			private string createTime;

			private string updateTime;

			private string shareType;

			private string approvalType;

			private string versionName;

			private string artifactId;

			private string artifactVersion;

			private string sourceImage;

			private string relationType;

			private string trialType;

			private string tenantType;

			private string resourceGroupId;

			private List<ListServices_ServiceInfo> serviceInfos;

			private List<ListServices_Tag> tags;

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

			public bool? DefaultVersion
			{
				get
				{
					return defaultVersion;
				}
				set	
				{
					defaultVersion = value;
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

			public string ArtifactId
			{
				get
				{
					return artifactId;
				}
				set	
				{
					artifactId = value;
				}
			}

			public string ArtifactVersion
			{
				get
				{
					return artifactVersion;
				}
				set	
				{
					artifactVersion = value;
				}
			}

			public string SourceImage
			{
				get
				{
					return sourceImage;
				}
				set	
				{
					sourceImage = value;
				}
			}

			public string RelationType
			{
				get
				{
					return relationType;
				}
				set	
				{
					relationType = value;
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

			public List<ListServices_ServiceInfo> ServiceInfos
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

			public List<ListServices_Tag> Tags
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

			public class ListServices_ServiceInfo
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

			public class ListServices_Tag
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
		}
	}
}
