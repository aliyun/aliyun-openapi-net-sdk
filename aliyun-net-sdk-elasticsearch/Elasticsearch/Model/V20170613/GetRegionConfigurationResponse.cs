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
	public class GetRegionConfigurationResponse : AcsResponse
	{

		private string requestId;

		private GetRegionConfiguration_Result result;

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

		public GetRegionConfiguration_Result Result
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

		public class GetRegionConfiguration_Result
		{

			private string env;

			private string regionId;

			private string createUrl;

			private List<GetRegionConfiguration_DataDiskListItem> dataDiskList;

			private List<GetRegionConfiguration_EsVersionsLatestListItem> esVersionsLatestList;

			private List<GetRegionConfiguration_NodeSpecListItem> nodeSpecList;

			private List<GetRegionConfiguration_Disk> clientNodeDiskList;

			private List<GetRegionConfiguration_Disk> masterDiskList;

			private List<GetRegionConfiguration_CategoryEntity> supportVersions;

			private List<string> zones;

			private List<string> esVersions;

			private List<string> masterSpec;

			private List<string> clientNodeSpec;

			private List<string> instanceSupportNodes;

			private GetRegionConfiguration_Node node;

			private GetRegionConfiguration_JvmConfine jvmConfine;

			private GetRegionConfiguration_ClientNodeAmountRange clientNodeAmountRange;

			private GetRegionConfiguration_WarmNodeProperties warmNodeProperties;

			private GetRegionConfiguration_KibanaNodeProperties kibanaNodeProperties;

			private GetRegionConfiguration_ElasticNodeProperties elasticNodeProperties;

			public string Env
			{
				get
				{
					return env;
				}
				set	
				{
					env = value;
				}
			}

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
				}
			}

			public string CreateUrl
			{
				get
				{
					return createUrl;
				}
				set	
				{
					createUrl = value;
				}
			}

			public List<GetRegionConfiguration_DataDiskListItem> DataDiskList
			{
				get
				{
					return dataDiskList;
				}
				set	
				{
					dataDiskList = value;
				}
			}

			public List<GetRegionConfiguration_EsVersionsLatestListItem> EsVersionsLatestList
			{
				get
				{
					return esVersionsLatestList;
				}
				set	
				{
					esVersionsLatestList = value;
				}
			}

			public List<GetRegionConfiguration_NodeSpecListItem> NodeSpecList
			{
				get
				{
					return nodeSpecList;
				}
				set	
				{
					nodeSpecList = value;
				}
			}

			public List<GetRegionConfiguration_Disk> ClientNodeDiskList
			{
				get
				{
					return clientNodeDiskList;
				}
				set	
				{
					clientNodeDiskList = value;
				}
			}

			public List<GetRegionConfiguration_Disk> MasterDiskList
			{
				get
				{
					return masterDiskList;
				}
				set	
				{
					masterDiskList = value;
				}
			}

			public List<GetRegionConfiguration_CategoryEntity> SupportVersions
			{
				get
				{
					return supportVersions;
				}
				set	
				{
					supportVersions = value;
				}
			}

			public List<string> Zones
			{
				get
				{
					return zones;
				}
				set	
				{
					zones = value;
				}
			}

			public List<string> EsVersions
			{
				get
				{
					return esVersions;
				}
				set	
				{
					esVersions = value;
				}
			}

			public List<string> MasterSpec
			{
				get
				{
					return masterSpec;
				}
				set	
				{
					masterSpec = value;
				}
			}

			public List<string> ClientNodeSpec
			{
				get
				{
					return clientNodeSpec;
				}
				set	
				{
					clientNodeSpec = value;
				}
			}

			public List<string> InstanceSupportNodes
			{
				get
				{
					return instanceSupportNodes;
				}
				set	
				{
					instanceSupportNodes = value;
				}
			}

			public GetRegionConfiguration_Node Node
			{
				get
				{
					return node;
				}
				set	
				{
					node = value;
				}
			}

			public GetRegionConfiguration_JvmConfine JvmConfine
			{
				get
				{
					return jvmConfine;
				}
				set	
				{
					jvmConfine = value;
				}
			}

			public GetRegionConfiguration_ClientNodeAmountRange ClientNodeAmountRange
			{
				get
				{
					return clientNodeAmountRange;
				}
				set	
				{
					clientNodeAmountRange = value;
				}
			}

			public GetRegionConfiguration_WarmNodeProperties WarmNodeProperties
			{
				get
				{
					return warmNodeProperties;
				}
				set	
				{
					warmNodeProperties = value;
				}
			}

			public GetRegionConfiguration_KibanaNodeProperties KibanaNodeProperties
			{
				get
				{
					return kibanaNodeProperties;
				}
				set	
				{
					kibanaNodeProperties = value;
				}
			}

			public GetRegionConfiguration_ElasticNodeProperties ElasticNodeProperties
			{
				get
				{
					return elasticNodeProperties;
				}
				set	
				{
					elasticNodeProperties = value;
				}
			}

			public class GetRegionConfiguration_DataDiskListItem
			{

				private string diskType;

				private int? minSize;

				private int? maxSize;

				private int? scaleLimit;

				private List<string> valueLimitSet;

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

				public int? MinSize
				{
					get
					{
						return minSize;
					}
					set	
					{
						minSize = value;
					}
				}

				public int? MaxSize
				{
					get
					{
						return maxSize;
					}
					set	
					{
						maxSize = value;
					}
				}

				public int? ScaleLimit
				{
					get
					{
						return scaleLimit;
					}
					set	
					{
						scaleLimit = value;
					}
				}

				public List<string> ValueLimitSet
				{
					get
					{
						return valueLimitSet;
					}
					set	
					{
						valueLimitSet = value;
					}
				}
			}

			public class GetRegionConfiguration_EsVersionsLatestListItem
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

			public class GetRegionConfiguration_NodeSpecListItem
			{

				private int? cpuCount;

				private int? memorySize;

				private bool? enable;

				private string spec;

				private string diskType;

				private int? disk;

				private string specGroupType;

				public int? CpuCount
				{
					get
					{
						return cpuCount;
					}
					set	
					{
						cpuCount = value;
					}
				}

				public int? MemorySize
				{
					get
					{
						return memorySize;
					}
					set	
					{
						memorySize = value;
					}
				}

				public bool? Enable
				{
					get
					{
						return enable;
					}
					set	
					{
						enable = value;
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

				public string SpecGroupType
				{
					get
					{
						return specGroupType;
					}
					set	
					{
						specGroupType = value;
					}
				}
			}

			public class GetRegionConfiguration_Disk
			{

				private string diskType;

				private int? minSize;

				private int? maxSize;

				private int? scaleLimit;

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

				public int? MinSize
				{
					get
					{
						return minSize;
					}
					set	
					{
						minSize = value;
					}
				}

				public int? MaxSize
				{
					get
					{
						return maxSize;
					}
					set	
					{
						maxSize = value;
					}
				}

				public int? ScaleLimit
				{
					get
					{
						return scaleLimit;
					}
					set	
					{
						scaleLimit = value;
					}
				}
			}

			public class GetRegionConfiguration_CategoryEntity
			{

				private string instanceCategory;

				private List<GetRegionConfiguration_VersionEntity> supportVersionList;

				public string InstanceCategory
				{
					get
					{
						return instanceCategory;
					}
					set	
					{
						instanceCategory = value;
					}
				}

				public List<GetRegionConfiguration_VersionEntity> SupportVersionList
				{
					get
					{
						return supportVersionList;
					}
					set	
					{
						supportVersionList = value;
					}
				}

				public class GetRegionConfiguration_VersionEntity
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

			public class GetRegionConfiguration_Node
			{

				private int? minAmount;

				private int? maxAmount;

				public int? MinAmount
				{
					get
					{
						return minAmount;
					}
					set	
					{
						minAmount = value;
					}
				}

				public int? MaxAmount
				{
					get
					{
						return maxAmount;
					}
					set	
					{
						maxAmount = value;
					}
				}
			}

			public class GetRegionConfiguration_JvmConfine
			{

				private int? memory;

				private List<string> supportGcs;

				private List<string> supportEsVersions;

				public int? Memory
				{
					get
					{
						return memory;
					}
					set	
					{
						memory = value;
					}
				}

				public List<string> SupportGcs
				{
					get
					{
						return supportGcs;
					}
					set	
					{
						supportGcs = value;
					}
				}

				public List<string> SupportEsVersions
				{
					get
					{
						return supportEsVersions;
					}
					set	
					{
						supportEsVersions = value;
					}
				}
			}

			public class GetRegionConfiguration_ClientNodeAmountRange
			{

				private int? minAmount;

				private int? maxAmount;

				public int? MinAmount
				{
					get
					{
						return minAmount;
					}
					set	
					{
						minAmount = value;
					}
				}

				public int? MaxAmount
				{
					get
					{
						return maxAmount;
					}
					set	
					{
						maxAmount = value;
					}
				}
			}

			public class GetRegionConfiguration_WarmNodeProperties
			{

				private List<GetRegionConfiguration_Disk1> diskList;

				private List<string> spec;

				private GetRegionConfiguration_AmountRange amountRange;

				public List<GetRegionConfiguration_Disk1> DiskList
				{
					get
					{
						return diskList;
					}
					set	
					{
						diskList = value;
					}
				}

				public List<string> Spec
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

				public GetRegionConfiguration_AmountRange AmountRange
				{
					get
					{
						return amountRange;
					}
					set	
					{
						amountRange = value;
					}
				}

				public class GetRegionConfiguration_Disk1
				{

					private string diskType;

					private int? maxSize;

					private int? minSize;

					private int? scaleLimit;

					private bool? diskEncryption;

					private List<string> valueLimitSet2;

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

					public int? MaxSize
					{
						get
						{
							return maxSize;
						}
						set	
						{
							maxSize = value;
						}
					}

					public int? MinSize
					{
						get
						{
							return minSize;
						}
						set	
						{
							minSize = value;
						}
					}

					public int? ScaleLimit
					{
						get
						{
							return scaleLimit;
						}
						set	
						{
							scaleLimit = value;
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

					public List<string> ValueLimitSet2
					{
						get
						{
							return valueLimitSet2;
						}
						set	
						{
							valueLimitSet2 = value;
						}
					}
				}

				public class GetRegionConfiguration_AmountRange
				{

					private int? maxAmount;

					private int? minAmount;

					public int? MaxAmount
					{
						get
						{
							return maxAmount;
						}
						set	
						{
							maxAmount = value;
						}
					}

					public int? MinAmount
					{
						get
						{
							return minAmount;
						}
						set	
						{
							minAmount = value;
						}
					}
				}
			}

			public class GetRegionConfiguration_KibanaNodeProperties
			{

				private List<string> spec3;

				private GetRegionConfiguration_AmountRange4 amountRange4;

				public List<string> Spec3
				{
					get
					{
						return spec3;
					}
					set	
					{
						spec3 = value;
					}
				}

				public GetRegionConfiguration_AmountRange4 AmountRange4
				{
					get
					{
						return amountRange4;
					}
					set	
					{
						amountRange4 = value;
					}
				}

				public class GetRegionConfiguration_AmountRange4
				{

					private int? maxAmount;

					private int? minAmount;

					public int? MaxAmount
					{
						get
						{
							return maxAmount;
						}
						set	
						{
							maxAmount = value;
						}
					}

					public int? MinAmount
					{
						get
						{
							return minAmount;
						}
						set	
						{
							minAmount = value;
						}
					}
				}
			}

			public class GetRegionConfiguration_ElasticNodeProperties
			{

				private List<GetRegionConfiguration_Disk8> diskList7;

				private List<string> spec5;

				private GetRegionConfiguration_AmountRange6 amountRange6;

				public List<GetRegionConfiguration_Disk8> DiskList7
				{
					get
					{
						return diskList7;
					}
					set	
					{
						diskList7 = value;
					}
				}

				public List<string> Spec5
				{
					get
					{
						return spec5;
					}
					set	
					{
						spec5 = value;
					}
				}

				public GetRegionConfiguration_AmountRange6 AmountRange6
				{
					get
					{
						return amountRange6;
					}
					set	
					{
						amountRange6 = value;
					}
				}

				public class GetRegionConfiguration_Disk8
				{

					private string diskType;

					private int? maxSize;

					private int? minSize;

					private int? scaleLimit;

					private bool? diskEncryption;

					private List<string> valueLimitSet9;

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

					public int? MaxSize
					{
						get
						{
							return maxSize;
						}
						set	
						{
							maxSize = value;
						}
					}

					public int? MinSize
					{
						get
						{
							return minSize;
						}
						set	
						{
							minSize = value;
						}
					}

					public int? ScaleLimit
					{
						get
						{
							return scaleLimit;
						}
						set	
						{
							scaleLimit = value;
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

					public List<string> ValueLimitSet9
					{
						get
						{
							return valueLimitSet9;
						}
						set	
						{
							valueLimitSet9 = value;
						}
					}
				}

				public class GetRegionConfiguration_AmountRange6
				{

					private int? maxAmount;

					private int? minAmount;

					public int? MaxAmount
					{
						get
						{
							return maxAmount;
						}
						set	
						{
							maxAmount = value;
						}
					}

					public int? MinAmount
					{
						get
						{
							return minAmount;
						}
						set	
						{
							minAmount = value;
						}
					}
				}
			}
		}
	}
}
