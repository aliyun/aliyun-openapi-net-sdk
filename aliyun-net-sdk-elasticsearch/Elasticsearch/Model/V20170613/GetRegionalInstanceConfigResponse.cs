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
	public class GetRegionalInstanceConfigResponse : AcsResponse
	{

		private string requestId;

		private GetRegionalInstanceConfig_Result result;

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

		public GetRegionalInstanceConfig_Result Result
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

		public class GetRegionalInstanceConfig_Result
		{

			private string specInfoMap;

			private List<GetRegionalInstanceConfig_MasterDiskListItem> masterDiskList;

			private List<GetRegionalInstanceConfig_ClientNodeDiskListItem> clientNodeDiskList;

			private List<GetRegionalInstanceConfig_DataNodeDiskListItem> dataNodeDiskList;

			private List<string> clientSpecs;

			private List<string> dataNodeSpecs;

			private List<string> kibanaSpecs;

			private List<string> masterSpecs;

			private List<string> versions;

			private List<string> masterAmountRange;

			private GetRegionalInstanceConfig_ClientNodeAmountRange clientNodeAmountRange;

			private GetRegionalInstanceConfig_DataNodeAmountRange dataNodeAmountRange;

			public string SpecInfoMap
			{
				get
				{
					return specInfoMap;
				}
				set	
				{
					specInfoMap = value;
				}
			}

			public List<GetRegionalInstanceConfig_MasterDiskListItem> MasterDiskList
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

			public List<GetRegionalInstanceConfig_ClientNodeDiskListItem> ClientNodeDiskList
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

			public List<GetRegionalInstanceConfig_DataNodeDiskListItem> DataNodeDiskList
			{
				get
				{
					return dataNodeDiskList;
				}
				set	
				{
					dataNodeDiskList = value;
				}
			}

			public List<string> ClientSpecs
			{
				get
				{
					return clientSpecs;
				}
				set	
				{
					clientSpecs = value;
				}
			}

			public List<string> DataNodeSpecs
			{
				get
				{
					return dataNodeSpecs;
				}
				set	
				{
					dataNodeSpecs = value;
				}
			}

			public List<string> KibanaSpecs
			{
				get
				{
					return kibanaSpecs;
				}
				set	
				{
					kibanaSpecs = value;
				}
			}

			public List<string> MasterSpecs
			{
				get
				{
					return masterSpecs;
				}
				set	
				{
					masterSpecs = value;
				}
			}

			public List<string> Versions
			{
				get
				{
					return versions;
				}
				set	
				{
					versions = value;
				}
			}

			public List<string> MasterAmountRange
			{
				get
				{
					return masterAmountRange;
				}
				set	
				{
					masterAmountRange = value;
				}
			}

			public GetRegionalInstanceConfig_ClientNodeAmountRange ClientNodeAmountRange
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

			public GetRegionalInstanceConfig_DataNodeAmountRange DataNodeAmountRange
			{
				get
				{
					return dataNodeAmountRange;
				}
				set	
				{
					dataNodeAmountRange = value;
				}
			}

			public class GetRegionalInstanceConfig_MasterDiskListItem
			{

				private int? minSize;

				private int? maxSize;

				private int? scaleLimit;

				private string diskType;

				private List<GetRegionalInstanceConfig_SubClassificationConfinesItem> subClassificationConfines;

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

				public List<GetRegionalInstanceConfig_SubClassificationConfinesItem> SubClassificationConfines
				{
					get
					{
						return subClassificationConfines;
					}
					set	
					{
						subClassificationConfines = value;
					}
				}

				public class GetRegionalInstanceConfig_SubClassificationConfinesItem
				{

					private int? minSize;

					private int? maxSize;

					private string performanceLevel;

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
				}
			}

			public class GetRegionalInstanceConfig_ClientNodeDiskListItem
			{

				private int? minSize;

				private int? maxSize;

				private int? scaleLimit;

				private string diskType;

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

			public class GetRegionalInstanceConfig_DataNodeDiskListItem
			{

				private int? minSize;

				private int? maxSize;

				private int? scaleLimit;

				private string diskType;

				private List<GetRegionalInstanceConfig_SubClassificationConfinesItem2> subClassificationConfines1;

				private List<string> valueLimitSet;

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

				public List<GetRegionalInstanceConfig_SubClassificationConfinesItem2> SubClassificationConfines1
				{
					get
					{
						return subClassificationConfines1;
					}
					set	
					{
						subClassificationConfines1 = value;
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

				public class GetRegionalInstanceConfig_SubClassificationConfinesItem2
				{

					private int? minSize;

					private int? maxSize;

					private string performanceLevel;

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
				}
			}

			public class GetRegionalInstanceConfig_ClientNodeAmountRange
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

			public class GetRegionalInstanceConfig_DataNodeAmountRange
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
		}
	}
}
