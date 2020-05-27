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
	public class DescribeAvailableResourceResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeAvailableResource_AvailableZone> availableZones;

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

		public List<DescribeAvailableResource_AvailableZone> AvailableZones
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

		public class DescribeAvailableResource_AvailableZone
		{

			private string regionId;

			private string zoneId;

			private List<DescribeAvailableResource_SupportedEngine> supportedEngines;

			private List<DescribeAvailableResource_MasterResource> masterResources;

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

			public List<DescribeAvailableResource_SupportedEngine> SupportedEngines
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

			public List<DescribeAvailableResource_MasterResource> MasterResources
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

			public class DescribeAvailableResource_SupportedEngine
			{

				private string engine;

				private List<DescribeAvailableResource_SupportedEngineVersion> supportedEngineVersions;

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

				public List<DescribeAvailableResource_SupportedEngineVersion> SupportedEngineVersions
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

				public class DescribeAvailableResource_SupportedEngineVersion
				{

					private string version;

					private List<DescribeAvailableResource_SupportedCategoriesItem> supportedCategories;

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

					public List<DescribeAvailableResource_SupportedCategoriesItem> SupportedCategories
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

					public class DescribeAvailableResource_SupportedCategoriesItem
					{

						private string category;

						private List<DescribeAvailableResource_SupportedStorageType> supportedStorageTypes;

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

						public List<DescribeAvailableResource_SupportedStorageType> SupportedStorageTypes
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

						public class DescribeAvailableResource_SupportedStorageType
						{

							private string storageType;

							private List<DescribeAvailableResource_CoreResource> coreResources;

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

							public List<DescribeAvailableResource_CoreResource> CoreResources
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

							public class DescribeAvailableResource_CoreResource
							{

								private string instanceType;

								private int? maxCoreCount;

								private DescribeAvailableResource_DBInstanceStorageRange dBInstanceStorageRange;

								private DescribeAvailableResource_InstanceTypeDetail instanceTypeDetail;

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

								public DescribeAvailableResource_DBInstanceStorageRange DBInstanceStorageRange
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

								public DescribeAvailableResource_InstanceTypeDetail InstanceTypeDetail
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

								public class DescribeAvailableResource_DBInstanceStorageRange
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

								public class DescribeAvailableResource_InstanceTypeDetail
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

			public class DescribeAvailableResource_MasterResource
			{

				private string instanceType;

				private DescribeAvailableResource_InstanceTypeDetail1 instanceTypeDetail1;

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

				public DescribeAvailableResource_InstanceTypeDetail1 InstanceTypeDetail1
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

				public class DescribeAvailableResource_InstanceTypeDetail1
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
