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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeAvailableZonesResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeAvailableZones_AvailableZone> availableZones;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "AvailableZones")]
		public List<DescribeAvailableZones_AvailableZone> AvailableZones
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

		public class DescribeAvailableZones_AvailableZone
		{

			private string zoneId;

			private string networkTypes;

			private string regionId;

			private List<DescribeAvailableZones_SupportedEngine> supportedEngines;

			[JsonProperty(PropertyName = "ZoneId")]
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

			[JsonProperty(PropertyName = "NetworkTypes")]
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

			[JsonProperty(PropertyName = "RegionId")]
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

			[JsonProperty(PropertyName = "SupportedEngines")]
			public List<DescribeAvailableZones_SupportedEngine> SupportedEngines
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

			public class DescribeAvailableZones_SupportedEngine
			{

				private string engine;

				private List<DescribeAvailableZones_SupportedEngineVersion> supportedEngineVersions;

				[JsonProperty(PropertyName = "Engine")]
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

				[JsonProperty(PropertyName = "SupportedEngineVersions")]
				public List<DescribeAvailableZones_SupportedEngineVersion> SupportedEngineVersions
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

				public class DescribeAvailableZones_SupportedEngineVersion
				{

					private string version;

					private List<DescribeAvailableZones_SupportedCategory> supportedCategorys;

					[JsonProperty(PropertyName = "Version")]
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

					[JsonProperty(PropertyName = "SupportedCategorys")]
					public List<DescribeAvailableZones_SupportedCategory> SupportedCategorys
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

					public class DescribeAvailableZones_SupportedCategory
					{

						private string category;

						private List<DescribeAvailableZones_SupportedStorageType> supportedStorageTypes;

						[JsonProperty(PropertyName = "Category")]
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

						[JsonProperty(PropertyName = "SupportedStorageTypes")]
						public List<DescribeAvailableZones_SupportedStorageType> SupportedStorageTypes
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

						public class DescribeAvailableZones_SupportedStorageType
						{

							private string storageType;

							[JsonProperty(PropertyName = "StorageType")]
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
						}
					}
				}
			}
		}
	}
}
