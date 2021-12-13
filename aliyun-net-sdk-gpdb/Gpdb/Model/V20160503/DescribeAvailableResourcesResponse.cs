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

namespace Aliyun.Acs.gpdb.Model.V20160503
{
	public class DescribeAvailableResourcesResponse : AcsResponse
	{

		private string requestId;

		private string regionId;

		private List<DescribeAvailableResources_Resource> resources;

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

		public List<DescribeAvailableResources_Resource> Resources
		{
			get
			{
				return resources;
			}
			set	
			{
				resources = value;
			}
		}

		public class DescribeAvailableResources_Resource
		{

			private string zoneId;

			private List<DescribeAvailableResources_SupportedEngine> supportedEngines;

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

			public List<DescribeAvailableResources_SupportedEngine> SupportedEngines
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

			public class DescribeAvailableResources_SupportedEngine
			{

				private string supportedEngineVersion;

				private string mode;

				private List<DescribeAvailableResources_SupportedInstanceClass> supportedInstanceClasses;

				public string SupportedEngineVersion
				{
					get
					{
						return supportedEngineVersion;
					}
					set	
					{
						supportedEngineVersion = value;
					}
				}

				public string Mode
				{
					get
					{
						return mode;
					}
					set	
					{
						mode = value;
					}
				}

				public List<DescribeAvailableResources_SupportedInstanceClass> SupportedInstanceClasses
				{
					get
					{
						return supportedInstanceClasses;
					}
					set	
					{
						supportedInstanceClasses = value;
					}
				}

				public class DescribeAvailableResources_SupportedInstanceClass
				{

					private string description;

					private string displayClass;

					private string instanceClass;

					private string storageType;

					private DescribeAvailableResources_NodeCount nodeCount;

					private DescribeAvailableResources_StorageSize storageSize;

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

					public string DisplayClass
					{
						get
						{
							return displayClass;
						}
						set	
						{
							displayClass = value;
						}
					}

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

					public DescribeAvailableResources_NodeCount NodeCount
					{
						get
						{
							return nodeCount;
						}
						set	
						{
							nodeCount = value;
						}
					}

					public DescribeAvailableResources_StorageSize StorageSize
					{
						get
						{
							return storageSize;
						}
						set	
						{
							storageSize = value;
						}
					}

					public class DescribeAvailableResources_NodeCount
					{

						private string step;

						private string minCount;

						private string maxCount;

						public string Step
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

						public string MinCount
						{
							get
							{
								return minCount;
							}
							set	
							{
								minCount = value;
							}
						}

						public string MaxCount
						{
							get
							{
								return maxCount;
							}
							set	
							{
								maxCount = value;
							}
						}
					}

					public class DescribeAvailableResources_StorageSize
					{

						private string step;

						private string minCount;

						private string maxCount;

						public string Step
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

						public string MinCount
						{
							get
							{
								return minCount;
							}
							set	
							{
								minCount = value;
							}
						}

						public string MaxCount
						{
							get
							{
								return maxCount;
							}
							set	
							{
								maxCount = value;
							}
						}
					}
				}
			}
		}
	}
}
