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

namespace Aliyun.Acs.adb.Model.V20190315
{
	public class DescribeAvailableResourceResponse : AcsResponse
	{

		private string requestId;

		private string regionId;

		private List<DescribeAvailableResource_AvailableZone> availableZoneList;

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

		public List<DescribeAvailableResource_AvailableZone> AvailableZoneList
		{
			get
			{
				return availableZoneList;
			}
			set	
			{
				availableZoneList = value;
			}
		}

		public class DescribeAvailableResource_AvailableZone
		{

			private string zoneId;

			private List<DescribeAvailableResource_SupportedModeItem> supportedMode;

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

			public List<DescribeAvailableResource_SupportedModeItem> SupportedMode
			{
				get
				{
					return supportedMode;
				}
				set	
				{
					supportedMode = value;
				}
			}

			public class DescribeAvailableResource_SupportedModeItem
			{

				private string mode;

				private List<DescribeAvailableResource_SupportedSerialListItem> supportedSerialList;

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

				public List<DescribeAvailableResource_SupportedSerialListItem> SupportedSerialList
				{
					get
					{
						return supportedSerialList;
					}
					set	
					{
						supportedSerialList = value;
					}
				}

				public class DescribeAvailableResource_SupportedSerialListItem
				{

					private string serial;

					private List<DescribeAvailableResource_SupportedFlexibleResourceItem> supportedFlexibleResource;

					private List<DescribeAvailableResource_SupportedInstanceClass> supportedInstanceClassList;

					public string Serial
					{
						get
						{
							return serial;
						}
						set	
						{
							serial = value;
						}
					}

					public List<DescribeAvailableResource_SupportedFlexibleResourceItem> SupportedFlexibleResource
					{
						get
						{
							return supportedFlexibleResource;
						}
						set	
						{
							supportedFlexibleResource = value;
						}
					}

					public List<DescribeAvailableResource_SupportedInstanceClass> SupportedInstanceClassList
					{
						get
						{
							return supportedInstanceClassList;
						}
						set	
						{
							supportedInstanceClassList = value;
						}
					}

					public class DescribeAvailableResource_SupportedFlexibleResourceItem
					{

						private string storageType;

						private List<string> supportedStorageResource;

						private List<string> supportedComputeResource;

						private DescribeAvailableResource_SupportedElasticIOResource supportedElasticIOResource;

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

						public List<string> SupportedStorageResource
						{
							get
							{
								return supportedStorageResource;
							}
							set	
							{
								supportedStorageResource = value;
							}
						}

						public List<string> SupportedComputeResource
						{
							get
							{
								return supportedComputeResource;
							}
							set	
							{
								supportedComputeResource = value;
							}
						}

						public DescribeAvailableResource_SupportedElasticIOResource SupportedElasticIOResource
						{
							get
							{
								return supportedElasticIOResource;
							}
							set	
							{
								supportedElasticIOResource = value;
							}
						}

						public class DescribeAvailableResource_SupportedElasticIOResource
						{

							private string minCount;

							private string maxCount;

							private string step;

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
						}
					}

					public class DescribeAvailableResource_SupportedInstanceClass
					{

						private string instanceClass;

						private string tips;

						private List<DescribeAvailableResource_SupportedNodeCount> supportedNodeCountList;

						private List<DescribeAvailableResource_SupportedExecutor> supportedExecutorList;

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

						public string Tips
						{
							get
							{
								return tips;
							}
							set	
							{
								tips = value;
							}
						}

						public List<DescribeAvailableResource_SupportedNodeCount> SupportedNodeCountList
						{
							get
							{
								return supportedNodeCountList;
							}
							set	
							{
								supportedNodeCountList = value;
							}
						}

						public List<DescribeAvailableResource_SupportedExecutor> SupportedExecutorList
						{
							get
							{
								return supportedExecutorList;
							}
							set	
							{
								supportedExecutorList = value;
							}
						}

						public class DescribeAvailableResource_SupportedNodeCount
						{

							private List<string> storageSize;

							private DescribeAvailableResource_NodeCount nodeCount;

							public List<string> StorageSize
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

							public DescribeAvailableResource_NodeCount NodeCount
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

							public class DescribeAvailableResource_NodeCount
							{

								private string minCount;

								private string maxCount;

								private string step;

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
							}
						}

						public class DescribeAvailableResource_SupportedExecutor
						{

							private DescribeAvailableResource_NodeCount1 nodeCount1;

							public DescribeAvailableResource_NodeCount1 NodeCount1
							{
								get
								{
									return nodeCount1;
								}
								set	
								{
									nodeCount1 = value;
								}
							}

							public class DescribeAvailableResource_NodeCount1
							{

								private string minCount;

								private string maxCount;

								private string step;

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
							}
						}
					}
				}
			}
		}
	}
}
