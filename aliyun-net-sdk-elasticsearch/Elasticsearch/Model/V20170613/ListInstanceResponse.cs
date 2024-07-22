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

namespace Aliyun.Acs.elasticsearch.Model.V20170613
{
	public class ListInstanceResponse : AcsResponse
	{

		private string requestId;

		private List<ListInstance_Instance> result;

		private ListInstance_Headers headers;

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

		public List<ListInstance_Instance> Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public ListInstance_Headers Headers
		{
			get
			{
				return headers;
			}
			set	
			{
				headers = value;
			}
		}

		public class ListInstance_Instance
		{

			private bool? advancedDedicateMaster;

			private int? nodeAmount;

			private string createdAt;

			private string status;

			private bool? dedicateMaster;

			private bool? serviceVpc;

			private string paymentType;

			private string resourceGroupId;

			private string postpaidServiceStatus;

			private string description;

			private string esVersion;

			private string isNewDeployment;

			private string updatedAt;

			private string instanceId;

			private string vpcInstanceId;

			private long? endTime;

			private string archType;

			private List<ListInstance_Tag> tags;

			private List<Dictionary<string, string>> extendConfigs;

			private List<string> kibanaIPWhitelist;

			private List<string> kibanaPrivateIPWhitelist;

			private List<string> publicIpWhitelist;

			private List<string> privateNetworkIpWhiteList;

			private ListInstance_ClientNodeConfiguration clientNodeConfiguration;

			private ListInstance_ElasticDataNodeConfiguration elasticDataNodeConfiguration;

			private ListInstance_KibanaConfiguration kibanaConfiguration;

			private ListInstance_MasterConfiguration masterConfiguration;

			private ListInstance_NetworkConfig networkConfig;

			private ListInstance_NodeSpec nodeSpec;

			public bool? AdvancedDedicateMaster
			{
				get
				{
					return advancedDedicateMaster;
				}
				set	
				{
					advancedDedicateMaster = value;
				}
			}

			public int? NodeAmount
			{
				get
				{
					return nodeAmount;
				}
				set	
				{
					nodeAmount = value;
				}
			}

			public string CreatedAt
			{
				get
				{
					return createdAt;
				}
				set	
				{
					createdAt = value;
				}
			}

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

			public bool? DedicateMaster
			{
				get
				{
					return dedicateMaster;
				}
				set	
				{
					dedicateMaster = value;
				}
			}

			public bool? ServiceVpc
			{
				get
				{
					return serviceVpc;
				}
				set	
				{
					serviceVpc = value;
				}
			}

			public string PaymentType
			{
				get
				{
					return paymentType;
				}
				set	
				{
					paymentType = value;
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

			public string PostpaidServiceStatus
			{
				get
				{
					return postpaidServiceStatus;
				}
				set	
				{
					postpaidServiceStatus = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public string EsVersion
			{
				get
				{
					return esVersion;
				}
				set	
				{
					esVersion = value;
				}
			}

			public string IsNewDeployment
			{
				get
				{
					return isNewDeployment;
				}
				set	
				{
					isNewDeployment = value;
				}
			}

			public string UpdatedAt
			{
				get
				{
					return updatedAt;
				}
				set	
				{
					updatedAt = value;
				}
			}

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public string VpcInstanceId
			{
				get
				{
					return vpcInstanceId;
				}
				set	
				{
					vpcInstanceId = value;
				}
			}

			public long? EndTime
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

			public string ArchType
			{
				get
				{
					return archType;
				}
				set	
				{
					archType = value;
				}
			}

			public List<ListInstance_Tag> Tags
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

			public List<Dictionary<string, string>> ExtendConfigs
			{
				get
				{
					return extendConfigs;
				}
				set	
				{
					extendConfigs = value;
				}
			}

			public List<string> KibanaIPWhitelist
			{
				get
				{
					return kibanaIPWhitelist;
				}
				set	
				{
					kibanaIPWhitelist = value;
				}
			}

			public List<string> KibanaPrivateIPWhitelist
			{
				get
				{
					return kibanaPrivateIPWhitelist;
				}
				set	
				{
					kibanaPrivateIPWhitelist = value;
				}
			}

			public List<string> PublicIpWhitelist
			{
				get
				{
					return publicIpWhitelist;
				}
				set	
				{
					publicIpWhitelist = value;
				}
			}

			public List<string> PrivateNetworkIpWhiteList
			{
				get
				{
					return privateNetworkIpWhiteList;
				}
				set	
				{
					privateNetworkIpWhiteList = value;
				}
			}

			public ListInstance_ClientNodeConfiguration ClientNodeConfiguration
			{
				get
				{
					return clientNodeConfiguration;
				}
				set	
				{
					clientNodeConfiguration = value;
				}
			}

			public ListInstance_ElasticDataNodeConfiguration ElasticDataNodeConfiguration
			{
				get
				{
					return elasticDataNodeConfiguration;
				}
				set	
				{
					elasticDataNodeConfiguration = value;
				}
			}

			public ListInstance_KibanaConfiguration KibanaConfiguration
			{
				get
				{
					return kibanaConfiguration;
				}
				set	
				{
					kibanaConfiguration = value;
				}
			}

			public ListInstance_MasterConfiguration MasterConfiguration
			{
				get
				{
					return masterConfiguration;
				}
				set	
				{
					masterConfiguration = value;
				}
			}

			public ListInstance_NetworkConfig NetworkConfig
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

			public ListInstance_NodeSpec NodeSpec
			{
				get
				{
					return nodeSpec;
				}
				set	
				{
					nodeSpec = value;
				}
			}

			public class ListInstance_Tag
			{

				private string tagKey;

				private string tagValue;

				public string TagKey
				{
					get
					{
						return tagKey;
					}
					set	
					{
						tagKey = value;
					}
				}

				public string TagValue
				{
					get
					{
						return tagValue;
					}
					set	
					{
						tagValue = value;
					}
				}
			}

			public class ListInstance_ClientNodeConfiguration
			{

				private string spec;

				private int? amount;

				private int? disk;

				private string diskType;

				private string specInfo;

				public string Spec
				{
					get
					{
						return spec;
					}
					set	
					{
						spec = value;
					}
				}

				public int? Amount
				{
					get
					{
						return amount;
					}
					set	
					{
						amount = value;
					}
				}

				public int? Disk
				{
					get
					{
						return disk;
					}
					set	
					{
						disk = value;
					}
				}

				public string DiskType
				{
					get
					{
						return diskType;
					}
					set	
					{
						diskType = value;
					}
				}

				public string SpecInfo
				{
					get
					{
						return specInfo;
					}
					set	
					{
						specInfo = value;
					}
				}
			}

			public class ListInstance_ElasticDataNodeConfiguration
			{

				private string spec;

				private int? amount;

				private int? disk;

				private bool? diskEncryption;

				private string diskType;

				private string specInfo;

				public string Spec
				{
					get
					{
						return spec;
					}
					set	
					{
						spec = value;
					}
				}

				public int? Amount
				{
					get
					{
						return amount;
					}
					set	
					{
						amount = value;
					}
				}

				public int? Disk
				{
					get
					{
						return disk;
					}
					set	
					{
						disk = value;
					}
				}

				public bool? DiskEncryption
				{
					get
					{
						return diskEncryption;
					}
					set	
					{
						diskEncryption = value;
					}
				}

				public string DiskType
				{
					get
					{
						return diskType;
					}
					set	
					{
						diskType = value;
					}
				}

				public string SpecInfo
				{
					get
					{
						return specInfo;
					}
					set	
					{
						specInfo = value;
					}
				}
			}

			public class ListInstance_KibanaConfiguration
			{

				private string spec;

				private int? amount;

				private int? disk;

				private string diskType;

				private string specInfo;

				public string Spec
				{
					get
					{
						return spec;
					}
					set	
					{
						spec = value;
					}
				}

				public int? Amount
				{
					get
					{
						return amount;
					}
					set	
					{
						amount = value;
					}
				}

				public int? Disk
				{
					get
					{
						return disk;
					}
					set	
					{
						disk = value;
					}
				}

				public string DiskType
				{
					get
					{
						return diskType;
					}
					set	
					{
						diskType = value;
					}
				}

				public string SpecInfo
				{
					get
					{
						return specInfo;
					}
					set	
					{
						specInfo = value;
					}
				}
			}

			public class ListInstance_MasterConfiguration
			{

				private string spec;

				private int? amount;

				private int? disk;

				private string diskType;

				private string specInfo;

				public string Spec
				{
					get
					{
						return spec;
					}
					set	
					{
						spec = value;
					}
				}

				public int? Amount
				{
					get
					{
						return amount;
					}
					set	
					{
						amount = value;
					}
				}

				public int? Disk
				{
					get
					{
						return disk;
					}
					set	
					{
						disk = value;
					}
				}

				public string DiskType
				{
					get
					{
						return diskType;
					}
					set	
					{
						diskType = value;
					}
				}

				public string SpecInfo
				{
					get
					{
						return specInfo;
					}
					set	
					{
						specInfo = value;
					}
				}
			}

			public class ListInstance_NetworkConfig
			{

				private string vpcId;

				private string vsArea;

				private string type;

				private string vswitchId;

				private List<ListInstance_WhiteIpGroupListItem> whiteIpGroupList;

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

				public string VsArea
				{
					get
					{
						return vsArea;
					}
					set	
					{
						vsArea = value;
					}
				}

				public string Type
				{
					get
					{
						return type;
					}
					set	
					{
						type = value;
					}
				}

				public string VswitchId
				{
					get
					{
						return vswitchId;
					}
					set	
					{
						vswitchId = value;
					}
				}

				public List<ListInstance_WhiteIpGroupListItem> WhiteIpGroupList
				{
					get
					{
						return whiteIpGroupList;
					}
					set	
					{
						whiteIpGroupList = value;
					}
				}

				public class ListInstance_WhiteIpGroupListItem
				{

					private string groupName;

					private string whiteIpType;

					private List<string> ips;

					public string GroupName
					{
						get
						{
							return groupName;
						}
						set	
						{
							groupName = value;
						}
					}

					public string WhiteIpType
					{
						get
						{
							return whiteIpType;
						}
						set	
						{
							whiteIpType = value;
						}
					}

					public List<string> Ips
					{
						get
						{
							return ips;
						}
						set	
						{
							ips = value;
						}
					}
				}
			}

			public class ListInstance_NodeSpec
			{

				private string spec;

				private int? disk;

				private bool? diskEncryption;

				private string diskType;

				private string performanceLevel;

				private string specInfo;

				public string Spec
				{
					get
					{
						return spec;
					}
					set	
					{
						spec = value;
					}
				}

				public int? Disk
				{
					get
					{
						return disk;
					}
					set	
					{
						disk = value;
					}
				}

				public bool? DiskEncryption
				{
					get
					{
						return diskEncryption;
					}
					set	
					{
						diskEncryption = value;
					}
				}

				public string DiskType
				{
					get
					{
						return diskType;
					}
					set	
					{
						diskType = value;
					}
				}

				public string PerformanceLevel
				{
					get
					{
						return performanceLevel;
					}
					set	
					{
						performanceLevel = value;
					}
				}

				public string SpecInfo
				{
					get
					{
						return specInfo;
					}
					set	
					{
						specInfo = value;
					}
				}
			}
		}

		public class ListInstance_Headers
		{

			private int? xTotalCount;

			public int? XTotalCount
			{
				get
				{
					return xTotalCount;
				}
				set	
				{
					xTotalCount = value;
				}
			}
		}
	}
}
