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

			private string createdAt;

			private bool? dedicateMaster;

			private string description;

			private string esVersion;

			private string instanceId;

			private int? nodeAmount;

			private string paymentType;

			private string resourceGroupId;

			private string status;

			private string updatedAt;

			private string postpaidServiceStatus;

			private List<ListInstance_Tag> tags;

			private List<Dictionary<string, string>> extendConfigs;

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

				private int? amount;

				private int? disk;

				private string diskType;

				private string spec;

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
			}

			public class ListInstance_ElasticDataNodeConfiguration
			{

				private int? amount;

				private int? disk;

				private bool? diskEncryption;

				private string diskType;

				private string spec;

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
			}

			public class ListInstance_KibanaConfiguration
			{

				private int? amount;

				private int? disk;

				private string diskType;

				private string spec;

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
			}

			public class ListInstance_MasterConfiguration
			{

				private int? amount;

				private int? disk;

				private string diskType;

				private string spec;

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
			}

			public class ListInstance_NetworkConfig
			{

				private string type;

				private string vpcId;

				private string vsArea;

				private string vswitchId;

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
			}

			public class ListInstance_NodeSpec
			{

				private int? disk;

				private bool? diskEncryption;

				private string diskType;

				private string spec;

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
