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

namespace Aliyun.Acs.Rds.Model.V20140815
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

			private string networkTypes;

			private string regionId;

			private string status;

			private string zoneId;

			private List<DescribeAvailableResource_SupportedEngine> supportedEngines;

			public string NetworkTypes
			{
				get
				{
					return networkTypes;
				}
				set	
				{
					networkTypes = value;
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

					private List<DescribeAvailableResource_SupportedCategory> supportedCategorys;

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

					public List<DescribeAvailableResource_SupportedCategory> SupportedCategorys
					{
						get
						{
							return supportedCategorys;
						}
						set	
						{
							supportedCategorys = value;
						}
					}

					public class DescribeAvailableResource_SupportedCategory
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

							private List<DescribeAvailableResource_AvailableResource> availableResources;

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

							public List<DescribeAvailableResource_AvailableResource> AvailableResources
							{
								get
								{
									return availableResources;
								}
								set	
								{
									availableResources = value;
								}
							}

							public class DescribeAvailableResource_AvailableResource
							{

								private string dBInstanceClass;

								private string storageRange;

								private DescribeAvailableResource_DBInstanceStorageRange dBInstanceStorageRange;

								public string DBInstanceClass
								{
									get
									{
										return dBInstanceClass;
									}
									set	
									{
										dBInstanceClass = value;
									}
								}

								public string StorageRange
								{
									get
									{
										return storageRange;
									}
									set	
									{
										storageRange = value;
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

								public class DescribeAvailableResource_DBInstanceStorageRange
								{

									private int? max;

									private int? min;

									private int? step;

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

									public int? Step
									{
										get
										{
											return step;
										}
										set	
										{
											step = value;
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
