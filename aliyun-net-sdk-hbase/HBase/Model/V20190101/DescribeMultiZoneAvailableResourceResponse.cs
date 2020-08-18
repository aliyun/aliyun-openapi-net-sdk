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

namespace Aliyun.Acs.HBase.Model.V20190101
{
	public class DescribeMultiZoneAvailableResourceResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeMultiZoneAvailableResource_AvailableZone> availableZones;

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

		public List<DescribeMultiZoneAvailableResource_AvailableZone> AvailableZones
		{
			get
			{
				return availableZones;
			}
			set	
			{
				availableZones = value;
			}
		}

		public class DescribeMultiZoneAvailableResource_AvailableZone
		{

			private string regionId;

			private string zoneCombination;

			private List<DescribeMultiZoneAvailableResource_MasterResource> masterResources;

			private List<DescribeMultiZoneAvailableResource_SupportedEngine> supportedEngines;

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

			public string ZoneCombination
			{
				get
				{
					return zoneCombination;
				}
				set	
				{
					zoneCombination = value;
				}
			}

			public List<DescribeMultiZoneAvailableResource_MasterResource> MasterResources
			{
				get
				{
					return masterResources;
				}
				set	
				{
					masterResources = value;
				}
			}

			public List<DescribeMultiZoneAvailableResource_SupportedEngine> SupportedEngines
			{
				get
				{
					return supportedEngines;
				}
				set	
				{
					supportedEngines = value;
				}
			}

			public class DescribeMultiZoneAvailableResource_MasterResource
			{

				private string instanceType;

				private DescribeMultiZoneAvailableResource_InstanceTypeDetail instanceTypeDetail;

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

				public DescribeMultiZoneAvailableResource_InstanceTypeDetail InstanceTypeDetail
				{
					get
					{
						return instanceTypeDetail;
					}
					set	
					{
						instanceTypeDetail = value;
					}
				}

				public class DescribeMultiZoneAvailableResource_InstanceTypeDetail
				{

					private int? cpu;

					private int? mem;

					public int? Cpu
					{
						get
						{
							return cpu;
						}
						set	
						{
							cpu = value;
						}
					}

					public int? Mem
					{
						get
						{
							return mem;
						}
						set	
						{
							mem = value;
						}
					}
				}
			}

			public class DescribeMultiZoneAvailableResource_SupportedEngine
			{

				private string engine;

				private List<DescribeMultiZoneAvailableResource_SupportedEngineVersion> supportedEngineVersions;

				public string Engine
				{
					get
					{
						return engine;
					}
					set	
					{
						engine = value;
					}
				}

				public List<DescribeMultiZoneAvailableResource_SupportedEngineVersion> SupportedEngineVersions
				{
					get
					{
						return supportedEngineVersions;
					}
					set	
					{
						supportedEngineVersions = value;
					}
				}

				public class DescribeMultiZoneAvailableResource_SupportedEngineVersion
				{

					private string version;

					private List<DescribeMultiZoneAvailableResource_SupportedCategoriesItem> supportedCategories;

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

					public List<DescribeMultiZoneAvailableResource_SupportedCategoriesItem> SupportedCategories
					{
						get
						{
							return supportedCategories;
						}
						set	
						{
							supportedCategories = value;
						}
					}

					public class DescribeMultiZoneAvailableResource_SupportedCategoriesItem
					{

						private string category;

						private List<DescribeMultiZoneAvailableResource_SupportedStorageType> supportedStorageTypes;

						public string Category
						{
							get
							{
								return category;
							}
							set	
							{
								category = value;
							}
						}

						public List<DescribeMultiZoneAvailableResource_SupportedStorageType> SupportedStorageTypes
						{
							get
							{
								return supportedStorageTypes;
							}
							set	
							{
								supportedStorageTypes = value;
							}
						}

						public class DescribeMultiZoneAvailableResource_SupportedStorageType
						{

							private string storageType;

							private List<DescribeMultiZoneAvailableResource_CoreResource> coreResources;

							public string StorageType
							{
								get
								{
									return storageType;
								}
								set	
								{
									storageType = value;
								}
							}

							public List<DescribeMultiZoneAvailableResource_CoreResource> CoreResources
							{
								get
								{
									return coreResources;
								}
								set	
								{
									coreResources = value;
								}
							}

							public class DescribeMultiZoneAvailableResource_CoreResource
							{

								private string instanceType;

								private int? maxCoreCount;

								private DescribeMultiZoneAvailableResource_DBInstanceStorageRange dBInstanceStorageRange;

								private DescribeMultiZoneAvailableResource_InstanceTypeDetail1 instanceTypeDetail1;

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

								public int? MaxCoreCount
								{
									get
									{
										return maxCoreCount;
									}
									set	
									{
										maxCoreCount = value;
									}
								}

								public DescribeMultiZoneAvailableResource_DBInstanceStorageRange DBInstanceStorageRange
								{
									get
									{
										return dBInstanceStorageRange;
									}
									set	
									{
										dBInstanceStorageRange = value;
									}
								}

								public DescribeMultiZoneAvailableResource_InstanceTypeDetail1 InstanceTypeDetail1
								{
									get
									{
										return instanceTypeDetail1;
									}
									set	
									{
										instanceTypeDetail1 = value;
									}
								}

								public class DescribeMultiZoneAvailableResource_DBInstanceStorageRange
								{

									private int? maxSize;

									private int? minSize;

									private int? stepSize;

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

									public int? StepSize
									{
										get
										{
											return stepSize;
										}
										set	
										{
											stepSize = value;
										}
									}
								}

								public class DescribeMultiZoneAvailableResource_InstanceTypeDetail1
								{

									private int? cpu;

									private int? mem;

									public int? Cpu
									{
										get
										{
											return cpu;
										}
										set	
										{
											cpu = value;
										}
									}

									public int? Mem
									{
										get
										{
											return mem;
										}
										set	
										{
											mem = value;
										}
									}
								}
							}
						}
					}
				}
			}
		}
	}
}
