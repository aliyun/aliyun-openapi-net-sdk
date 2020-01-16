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

namespace Aliyun.Acs.R_kvstore.Model.V20150101
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

			private string status;

			private string networkTypes;

			private string zoneName;

			private List<DescribeAvailableResource_SupportedEngine> supportedEngines;

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

			public string ZoneName
			{
				get
				{
					return zoneName;
				}
				set	
				{
					zoneName = value;
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

				private List<DescribeAvailableResource_SupportedEditionType> supportedEditionTypes;

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

				public List<DescribeAvailableResource_SupportedEditionType> SupportedEditionTypes
				{
					get
					{
						return supportedEditionTypes;
					}
					set	
					{
						supportedEditionTypes = value;
					}
				}

				public class DescribeAvailableResource_SupportedEditionType
				{

					private string editionType;

					private List<DescribeAvailableResource_SupportedSeriesType> supportedSeriesTypes;

					public string EditionType
					{
						get
						{
							return editionType;
						}
						set	
						{
							editionType = value;
						}
					}

					public List<DescribeAvailableResource_SupportedSeriesType> SupportedSeriesTypes
					{
						get
						{
							return supportedSeriesTypes;
						}
						set	
						{
							supportedSeriesTypes = value;
						}
					}

					public class DescribeAvailableResource_SupportedSeriesType
					{

						private string seriesType;

						private List<DescribeAvailableResource_SupportedEngineVersion> supportedEngineVersions;

						public string SeriesType
						{
							get
							{
								return seriesType;
							}
							set	
							{
								seriesType = value;
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

							private List<DescribeAvailableResource_SupportedArchitectureType> supportedArchitectureTypes;

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

							public List<DescribeAvailableResource_SupportedArchitectureType> SupportedArchitectureTypes
							{
								get
								{
									return supportedArchitectureTypes;
								}
								set	
								{
									supportedArchitectureTypes = value;
								}
							}

							public class DescribeAvailableResource_SupportedArchitectureType
							{

								private string architecture;

								private List<DescribeAvailableResource_SupportedShardNumber> supportedShardNumbers;

								public string Architecture
								{
									get
									{
										return architecture;
									}
									set	
									{
										architecture = value;
									}
								}

								public List<DescribeAvailableResource_SupportedShardNumber> SupportedShardNumbers
								{
									get
									{
										return supportedShardNumbers;
									}
									set	
									{
										supportedShardNumbers = value;
									}
								}

								public class DescribeAvailableResource_SupportedShardNumber
								{

									private string shardNumber;

									private List<DescribeAvailableResource_SupportedNodeType> supportedNodeTypes;

									public string ShardNumber
									{
										get
										{
											return shardNumber;
										}
										set	
										{
											shardNumber = value;
										}
									}

									public List<DescribeAvailableResource_SupportedNodeType> SupportedNodeTypes
									{
										get
										{
											return supportedNodeTypes;
										}
										set	
										{
											supportedNodeTypes = value;
										}
									}

									public class DescribeAvailableResource_SupportedNodeType
									{

										private string supportedNodeType;

										private List<DescribeAvailableResource_AvailableResource> availableResources;

										public string SupportedNodeType
										{
											get
											{
												return supportedNodeType;
											}
											set	
											{
												supportedNodeType = value;
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

											private string instanceClass;

											private string instanceClassRemark;

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

											public string InstanceClassRemark
											{
												get
												{
													return instanceClassRemark;
												}
												set	
												{
													instanceClassRemark = value;
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
	}
}
