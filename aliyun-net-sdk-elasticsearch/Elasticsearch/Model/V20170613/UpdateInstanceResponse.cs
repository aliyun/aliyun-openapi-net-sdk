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
	public class UpdateInstanceResponse : AcsResponse
	{

		private string requestId;

		private UpdateInstance_Result result;

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

		public UpdateInstance_Result Result
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

		public class UpdateInstance_Result
		{

			private string instanceId;

			private string domain;

			private string description;

			private int? nodeAmount;

			private string paymentType;

			private string status;

			private string esVersion;

			private string createdAt;

			private string updatedAt;

			private string kibanaDomain;

			private int? kibanaPort;

			private string publicDomain;

			private int? publicPort;

			private List<UpdateInstance_DictListItem> dictList;

			private List<UpdateInstance_SynonymsDictsItem> synonymsDicts;

			private UpdateInstance_NodeSpec nodeSpec;

			private UpdateInstance_NetworkConfig networkConfig;

			private UpdateInstance_KibanaConfiguration kibanaConfiguration;

			private UpdateInstance_MasterConfiguration masterConfiguration;

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

			public string Domain
			{
				get
				{
					return domain;
				}
				set	
				{
					domain = value;
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

			public string KibanaDomain
			{
				get
				{
					return kibanaDomain;
				}
				set	
				{
					kibanaDomain = value;
				}
			}

			public int? KibanaPort
			{
				get
				{
					return kibanaPort;
				}
				set	
				{
					kibanaPort = value;
				}
			}

			public string PublicDomain
			{
				get
				{
					return publicDomain;
				}
				set	
				{
					publicDomain = value;
				}
			}

			public int? PublicPort
			{
				get
				{
					return publicPort;
				}
				set	
				{
					publicPort = value;
				}
			}

			public List<UpdateInstance_DictListItem> DictList
			{
				get
				{
					return dictList;
				}
				set	
				{
					dictList = value;
				}
			}

			public List<UpdateInstance_SynonymsDictsItem> SynonymsDicts
			{
				get
				{
					return synonymsDicts;
				}
				set	
				{
					synonymsDicts = value;
				}
			}

			public UpdateInstance_NodeSpec NodeSpec
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

			public UpdateInstance_NetworkConfig NetworkConfig
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

			public UpdateInstance_KibanaConfiguration KibanaConfiguration
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

			public UpdateInstance_MasterConfiguration MasterConfiguration
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

			public class UpdateInstance_DictListItem
			{

				private string name;

				private long? fileSize;

				private string type;

				private string sourceType;

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

				public long? FileSize
				{
					get
					{
						return fileSize;
					}
					set	
					{
						fileSize = value;
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

				public string SourceType
				{
					get
					{
						return sourceType;
					}
					set	
					{
						sourceType = value;
					}
				}
			}

			public class UpdateInstance_SynonymsDictsItem
			{

				private string name;

				private long? fileSize;

				private string type;

				private string sourceType;

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

				public long? FileSize
				{
					get
					{
						return fileSize;
					}
					set	
					{
						fileSize = value;
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

				public string SourceType
				{
					get
					{
						return sourceType;
					}
					set	
					{
						sourceType = value;
					}
				}
			}

			public class UpdateInstance_NodeSpec
			{

				private string spec;

				private int? disk;

				private string diskType;

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
			}

			public class UpdateInstance_NetworkConfig
			{

				private string type;

				private string vpcId;

				private string vswitchId;

				private string vsArea;

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
			}

			public class UpdateInstance_KibanaConfiguration
			{

				private string spec;

				private int? amount;

				private string diskType;

				private int? disk;

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
			}

			public class UpdateInstance_MasterConfiguration
			{

				private string spec;

				private int? amount;

				private string diskType;

				private int? disk;

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
			}
		}
	}
}
