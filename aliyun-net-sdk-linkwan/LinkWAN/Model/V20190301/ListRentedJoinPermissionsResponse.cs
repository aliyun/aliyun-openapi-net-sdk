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

namespace Aliyun.Acs.LinkWAN.Model.V20190301
{
	public class ListRentedJoinPermissionsResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private ListRentedJoinPermissions_Data data;

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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public ListRentedJoinPermissions_Data Data
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

		public class ListRentedJoinPermissions_Data
		{

			private long? totalCount;

			private List<ListRentedJoinPermissions_JoinPermission> list;

			public long? TotalCount
			{
				get
				{
					return totalCount;
				}
				set	
				{
					totalCount = value;
				}
			}

			public List<ListRentedJoinPermissions_JoinPermission> List
			{
				get
				{
					return list;
				}
				set	
				{
					list = value;
				}
			}

			public class ListRentedJoinPermissions_JoinPermission
			{

				private string joinPermissionId;

				private string ownerAliyunId;

				private string joinEui;

				private string freqBandPlanGroupId;

				private string classMode;

				private bool? enabled;

				private bool? boundNodeGroup;

				private string type;

				private string boundNodeGroupName;

				private string boundNodeGroupId;

				private string rxDelay;

				private string dataRate;

				private string joinPermissionName;

				private ListRentedJoinPermissions_DataDispatchConfig dataDispatchConfig;

				public string JoinPermissionId
				{
					get
					{
						return joinPermissionId;
					}
					set	
					{
						joinPermissionId = value;
					}
				}

				public string OwnerAliyunId
				{
					get
					{
						return ownerAliyunId;
					}
					set	
					{
						ownerAliyunId = value;
					}
				}

				public string JoinEui
				{
					get
					{
						return joinEui;
					}
					set	
					{
						joinEui = value;
					}
				}

				public string FreqBandPlanGroupId
				{
					get
					{
						return freqBandPlanGroupId;
					}
					set	
					{
						freqBandPlanGroupId = value;
					}
				}

				public string ClassMode
				{
					get
					{
						return classMode;
					}
					set	
					{
						classMode = value;
					}
				}

				public bool? Enabled
				{
					get
					{
						return enabled;
					}
					set	
					{
						enabled = value;
					}
				}

				public bool? BoundNodeGroup
				{
					get
					{
						return boundNodeGroup;
					}
					set	
					{
						boundNodeGroup = value;
					}
				}

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

				public string BoundNodeGroupName
				{
					get
					{
						return boundNodeGroupName;
					}
					set	
					{
						boundNodeGroupName = value;
					}
				}

				public string BoundNodeGroupId
				{
					get
					{
						return boundNodeGroupId;
					}
					set	
					{
						boundNodeGroupId = value;
					}
				}

				public string RxDelay
				{
					get
					{
						return rxDelay;
					}
					set	
					{
						rxDelay = value;
					}
				}

				public string DataRate
				{
					get
					{
						return dataRate;
					}
					set	
					{
						dataRate = value;
					}
				}

				public string JoinPermissionName
				{
					get
					{
						return joinPermissionName;
					}
					set	
					{
						joinPermissionName = value;
					}
				}

				public ListRentedJoinPermissions_DataDispatchConfig DataDispatchConfig
				{
					get
					{
						return dataDispatchConfig;
					}
					set	
					{
						dataDispatchConfig = value;
					}
				}

				public class ListRentedJoinPermissions_DataDispatchConfig
				{

					private string destination;

					private ListRentedJoinPermissions_IotProduct iotProduct;

					private ListRentedJoinPermissions_OnsTopics onsTopics;

					public string Destination
					{
						get
						{
							return destination;
						}
						set	
						{
							destination = value;
						}
					}

					public ListRentedJoinPermissions_IotProduct IotProduct
					{
						get
						{
							return iotProduct;
						}
						set	
						{
							iotProduct = value;
						}
					}

					public ListRentedJoinPermissions_OnsTopics OnsTopics
					{
						get
						{
							return onsTopics;
						}
						set	
						{
							onsTopics = value;
						}
					}

					public class ListRentedJoinPermissions_IotProduct
					{

						private string productName;

						private string productKey;

						private string productType;

						private bool? debugSwitch;

						public string ProductName
						{
							get
							{
								return productName;
							}
							set	
							{
								productName = value;
							}
						}

						public string ProductKey
						{
							get
							{
								return productKey;
							}
							set	
							{
								productKey = value;
							}
						}

						public string ProductType
						{
							get
							{
								return productType;
							}
							set	
							{
								productType = value;
							}
						}

						public bool? DebugSwitch
						{
							get
							{
								return debugSwitch;
							}
							set	
							{
								debugSwitch = value;
							}
						}
					}

					public class ListRentedJoinPermissions_OnsTopics
					{

						private string downlinkRegionName;

						private string downlinkTopic;

						private string uplinkRegionName;

						private string uplinkTopic;

						public string DownlinkRegionName
						{
							get
							{
								return downlinkRegionName;
							}
							set	
							{
								downlinkRegionName = value;
							}
						}

						public string DownlinkTopic
						{
							get
							{
								return downlinkTopic;
							}
							set	
							{
								downlinkTopic = value;
							}
						}

						public string UplinkRegionName
						{
							get
							{
								return uplinkRegionName;
							}
							set	
							{
								uplinkRegionName = value;
							}
						}

						public string UplinkTopic
						{
							get
							{
								return uplinkTopic;
							}
							set	
							{
								uplinkTopic = value;
							}
						}
					}
				}
			}
		}
	}
}
