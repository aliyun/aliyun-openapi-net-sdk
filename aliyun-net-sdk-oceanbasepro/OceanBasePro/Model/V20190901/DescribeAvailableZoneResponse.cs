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

namespace Aliyun.Acs.OceanBasePro.Model.V20190901
{
	public class DescribeAvailableZoneResponse : AcsResponse
	{

		private string requestId;

		private DescribeAvailableZone_Data data;

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

		[JsonProperty(PropertyName = "Data")]
		public DescribeAvailableZone_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class DescribeAvailableZone_Data
		{

			private List<DescribeAvailableZone_AvailableZonesItem> availableZones;

			[JsonProperty(PropertyName = "AvailableZones")]
			public List<DescribeAvailableZone_AvailableZonesItem> AvailableZones
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

			public class DescribeAvailableZone_AvailableZonesItem
			{

				private string region;

				private string zones;

				private string channel;

				private string deployType;

				private string instanceType;

				private string series;

				private List<DescribeAvailableZone_SupportSpecificationsItem> supportSpecifications;

				[JsonProperty(PropertyName = "Region")]
				public string Region
				{
					get
					{
						return region;
					}
					set	
					{
						region = value;
					}
				}

				[JsonProperty(PropertyName = "Zones")]
				public string Zones
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

				[JsonProperty(PropertyName = "Channel")]
				public string Channel
				{
					get
					{
						return channel;
					}
					set	
					{
						channel = value;
					}
				}

				[JsonProperty(PropertyName = "DeployType")]
				public string DeployType
				{
					get
					{
						return deployType;
					}
					set	
					{
						deployType = value;
					}
				}

				[JsonProperty(PropertyName = "InstanceType")]
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

				[JsonProperty(PropertyName = "Series")]
				public string Series
				{
					get
					{
						return series;
					}
					set	
					{
						series = value;
					}
				}

				[JsonProperty(PropertyName = "SupportSpecifications")]
				public List<DescribeAvailableZone_SupportSpecificationsItem> SupportSpecifications
				{
					get
					{
						return supportSpecifications;
					}
					set	
					{
						supportSpecifications = value;
					}
				}

				public class DescribeAvailableZone_SupportSpecificationsItem
				{

					private string spec;

					private string instanceClass;

					private List<DescribeAvailableZone_SupportEngineVersionsItem> supportEngineVersions;

					private List<string> diskTypes;

					private DescribeAvailableZone_DiskSizeRange diskSizeRange;

					[JsonProperty(PropertyName = "Spec")]
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

					[JsonProperty(PropertyName = "InstanceClass")]
					public string InstanceClass
					{
						get
						{
							return instanceClass;
						}
						set	
						{
							instanceClass = value;
						}
					}

					[JsonProperty(PropertyName = "SupportEngineVersions")]
					public List<DescribeAvailableZone_SupportEngineVersionsItem> SupportEngineVersions
					{
						get
						{
							return supportEngineVersions;
						}
						set	
						{
							supportEngineVersions = value;
						}
					}

					[JsonProperty(PropertyName = "DiskTypes")]
					public List<string> DiskTypes
					{
						get
						{
							return diskTypes;
						}
						set	
						{
							diskTypes = value;
						}
					}

					[JsonProperty(PropertyName = "DiskSizeRange")]
					public DescribeAvailableZone_DiskSizeRange DiskSizeRange
					{
						get
						{
							return diskSizeRange;
						}
						set	
						{
							diskSizeRange = value;
						}
					}

					public class DescribeAvailableZone_SupportEngineVersionsItem
					{

						private string obVersion;

						private bool? supportIsolationOptimization;

						private List<string> supportReplicaModes;

						[JsonProperty(PropertyName = "ObVersion")]
						public string ObVersion
						{
							get
							{
								return obVersion;
							}
							set	
							{
								obVersion = value;
							}
						}

						[JsonProperty(PropertyName = "SupportIsolationOptimization")]
						public bool? SupportIsolationOptimization
						{
							get
							{
								return supportIsolationOptimization;
							}
							set	
							{
								supportIsolationOptimization = value;
							}
						}

						[JsonProperty(PropertyName = "SupportReplicaModes")]
						public List<string> SupportReplicaModes
						{
							get
							{
								return supportReplicaModes;
							}
							set	
							{
								supportReplicaModes = value;
							}
						}
					}

					public class DescribeAvailableZone_DiskSizeRange
					{

						private long? step;

						private long? max;

						private long? min;

						[JsonProperty(PropertyName = "Step")]
						public long? Step
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

						[JsonProperty(PropertyName = "Max")]
						public long? Max
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

						[JsonProperty(PropertyName = "Min")]
						public long? Min
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
					}
				}
			}
		}
	}
}
