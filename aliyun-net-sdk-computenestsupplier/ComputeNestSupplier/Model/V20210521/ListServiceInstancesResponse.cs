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
	public class ListServiceInstancesResponse : AcsResponse
	{

		private string nextToken;

		private string requestId;

		private int? totalCount;

		private string maxResults;

		private List<ListServiceInstances_ServiceInstance> serviceInstances;

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

		public int? TotalCount
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

		public string MaxResults
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

		public List<ListServiceInstances_ServiceInstance> ServiceInstances
		{
			get
			{
				return serviceInstances;
			}
			set	
			{
				serviceInstances = value;
			}
		}

		public class ListServiceInstances_ServiceInstance
		{

			private string status;

			private string updateTime;

			private string name;

			private string serviceInstanceId;

			private string createTime;

			private long? userId;

			private string parameters;

			private long? progress;

			private string statusDetail;

			private string templateName;

			private string operatedServiceInstanceId;

			private string operationStartTime;

			private string operationEndTime;

			private bool? enableInstanceOps;

			private string source;

			private string endTime;

			private string serviceType;

			private string payType;

			private bool? isOperated;

			private List<ListServiceInstances_Tag> tags;

			private ListServiceInstances_Service service;

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

			public List<ListServiceInstances_Tag> Tags
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

			public ListServiceInstances_Service Service
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

			public class ListServiceInstances_Tag
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

			public class ListServiceInstances_Service
			{

				private string status;

				private string publishTime;

				private string version;

				private string deployType;

				private string serviceId;

				private string supplierUrl;

				private string serviceType;

				private string supplierName;

				private string versionName;

				private string deployMetadata;

				private List<ListServiceInstances_ServiceInfo> serviceInfos;

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

				public List<ListServiceInstances_ServiceInfo> ServiceInfos
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

				public class ListServiceInstances_ServiceInfo
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
		}
	}
}
