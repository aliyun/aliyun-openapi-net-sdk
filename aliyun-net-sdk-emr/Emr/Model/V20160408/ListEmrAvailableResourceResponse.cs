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

namespace Aliyun.Acs.Emr.Model.V20160408
{
	public class ListEmrAvailableResourceResponse : AcsResponse
	{

		private string requestId;

		private string regionId;

		private List<ListEmrAvailableResource_EmrZoneInfo> emrZoneInfoList;

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

		public List<ListEmrAvailableResource_EmrZoneInfo> EmrZoneInfoList
		{
			get
			{
				return emrZoneInfoList;
			}
			set	
			{
				emrZoneInfoList = value;
			}
		}

		public class ListEmrAvailableResource_EmrZoneInfo
		{

			private string zoneId;

			private List<ListEmrAvailableResource_EmrResourceInfo> emrResourceInfoList;

			public string ZoneId
			{
				get
				{
					return zoneId;
				}
				set	
				{
					zoneId = value;
				}
			}

			public List<ListEmrAvailableResource_EmrResourceInfo> EmrResourceInfoList
			{
				get
				{
					return emrResourceInfoList;
				}
				set	
				{
					emrResourceInfoList = value;
				}
			}

			public class ListEmrAvailableResource_EmrResourceInfo
			{

				private string type;

				private List<ListEmrAvailableResource_SupportedResource> supportedResourceList;

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

				public List<ListEmrAvailableResource_SupportedResource> SupportedResourceList
				{
					get
					{
						return supportedResourceList;
					}
					set	
					{
						supportedResourceList = value;
					}
				}

				public class ListEmrAvailableResource_SupportedResource
				{

					private string _value;

					private int? min;

					private int? max;

					private string unit;

					private List<string> supportNodeTypeList;

					private ListEmrAvailableResource_EmrInstanceType emrInstanceType;

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

					public int? Min
					{
						get
						{
							return min;
						}
						set	
						{
							min = value;
						}
					}

					public int? Max
					{
						get
						{
							return max;
						}
						set	
						{
							max = value;
						}
					}

					public string Unit
					{
						get
						{
							return unit;
						}
						set	
						{
							unit = value;
						}
					}

					public List<string> SupportNodeTypeList
					{
						get
						{
							return supportNodeTypeList;
						}
						set	
						{
							supportNodeTypeList = value;
						}
					}

					public ListEmrAvailableResource_EmrInstanceType EmrInstanceType
					{
						get
						{
							return emrInstanceType;
						}
						set	
						{
							emrInstanceType = value;
						}
					}

					public class ListEmrAvailableResource_EmrInstanceType
					{

						private string instanceType;

						private int? cpuCoreCount;

						private int? memorySize;

						private string instanceTypeFamily;

						private long? localStorageCapacity;

						private int? localStorageAmount;

						private string localStorageCategory;

						private int? gPUAmount;

						private string gPUSpec;

						private int? initialCredit;

						private int? baselineCredit;

						private int? eniQuantity;

						private int? instanceBandwidthRx;

						private int? instanceBandwidthTx;

						private long? instancePpsRx;

						private long? instancePpsTx;

						public string InstanceType
						{
							get
							{
								return instanceType;
							}
							set	
							{
								instanceType = value;
							}
						}

						public int? CpuCoreCount
						{
							get
							{
								return cpuCoreCount;
							}
							set	
							{
								cpuCoreCount = value;
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

						public string InstanceTypeFamily
						{
							get
							{
								return instanceTypeFamily;
							}
							set	
							{
								instanceTypeFamily = value;
							}
						}

						public long? LocalStorageCapacity
						{
							get
							{
								return localStorageCapacity;
							}
							set	
							{
								localStorageCapacity = value;
							}
						}

						public int? LocalStorageAmount
						{
							get
							{
								return localStorageAmount;
							}
							set	
							{
								localStorageAmount = value;
							}
						}

						public string LocalStorageCategory
						{
							get
							{
								return localStorageCategory;
							}
							set	
							{
								localStorageCategory = value;
							}
						}

						public int? GPUAmount
						{
							get
							{
								return gPUAmount;
							}
							set	
							{
								gPUAmount = value;
							}
						}

						public string GPUSpec
						{
							get
							{
								return gPUSpec;
							}
							set	
							{
								gPUSpec = value;
							}
						}

						public int? InitialCredit
						{
							get
							{
								return initialCredit;
							}
							set	
							{
								initialCredit = value;
							}
						}

						public int? BaselineCredit
						{
							get
							{
								return baselineCredit;
							}
							set	
							{
								baselineCredit = value;
							}
						}

						public int? EniQuantity
						{
							get
							{
								return eniQuantity;
							}
							set	
							{
								eniQuantity = value;
							}
						}

						public int? InstanceBandwidthRx
						{
							get
							{
								return instanceBandwidthRx;
							}
							set	
							{
								instanceBandwidthRx = value;
							}
						}

						public int? InstanceBandwidthTx
						{
							get
							{
								return instanceBandwidthTx;
							}
							set	
							{
								instanceBandwidthTx = value;
							}
						}

						public long? InstancePpsRx
						{
							get
							{
								return instancePpsRx;
							}
							set	
							{
								instancePpsRx = value;
							}
						}

						public long? InstancePpsTx
						{
							get
							{
								return instancePpsTx;
							}
							set	
							{
								instancePpsTx = value;
							}
						}
					}
				}
			}
		}
	}
}
