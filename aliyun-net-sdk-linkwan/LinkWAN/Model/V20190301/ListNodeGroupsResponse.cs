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
	public class ListNodeGroupsResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private ListNodeGroups_Data data;

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

		public ListNodeGroups_Data Data
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

		public class ListNodeGroups_Data
		{

			private long? totalCount;

			private List<ListNodeGroups_NodeGroup> list;

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

			public List<ListNodeGroups_NodeGroup> List
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

			public class ListNodeGroups_NodeGroup
			{

				private string nodeGroupId;

				private string nodeGroupName;

				private long? nodesCnt;

				private bool? dataDispatchEnabled;

				private string joinPermissionId;

				private string joinPermissionOwnerAliyunId;

				private string joinEui;

				private long? freqBandPlanGroupId;

				private string classMode;

				private string joinPermissionType;

				private bool? joinPermissionEnabled;

				private long? rxDailySum;

				private long? rxMonthSum;

				private long? txDailySum;

				private long? txMonthSum;

				private long? createMillis;

				private string joinPermissionName;

				private List<ListNodeGroups__Lock> locks;

				private ListNodeGroups_DataDispatchConfig dataDispatchConfig;

				public string NodeGroupId
				{
					get
					{
						return nodeGroupId;
					}
					set	
					{
						nodeGroupId = value;
					}
				}

				public string NodeGroupName
				{
					get
					{
						return nodeGroupName;
					}
					set	
					{
						nodeGroupName = value;
					}
				}

				public long? NodesCnt
				{
					get
					{
						return nodesCnt;
					}
					set	
					{
						nodesCnt = value;
					}
				}

				public bool? DataDispatchEnabled
				{
					get
					{
						return dataDispatchEnabled;
					}
					set	
					{
						dataDispatchEnabled = value;
					}
				}

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

				public string JoinPermissionOwnerAliyunId
				{
					get
					{
						return joinPermissionOwnerAliyunId;
					}
					set	
					{
						joinPermissionOwnerAliyunId = value;
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

				public long? FreqBandPlanGroupId
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

				public string JoinPermissionType
				{
					get
					{
						return joinPermissionType;
					}
					set	
					{
						joinPermissionType = value;
					}
				}

				public bool? JoinPermissionEnabled
				{
					get
					{
						return joinPermissionEnabled;
					}
					set	
					{
						joinPermissionEnabled = value;
					}
				}

				public long? RxDailySum
				{
					get
					{
						return rxDailySum;
					}
					set	
					{
						rxDailySum = value;
					}
				}

				public long? RxMonthSum
				{
					get
					{
						return rxMonthSum;
					}
					set	
					{
						rxMonthSum = value;
					}
				}

				public long? TxDailySum
				{
					get
					{
						return txDailySum;
					}
					set	
					{
						txDailySum = value;
					}
				}

				public long? TxMonthSum
				{
					get
					{
						return txMonthSum;
					}
					set	
					{
						txMonthSum = value;
					}
				}

				public long? CreateMillis
				{
					get
					{
						return createMillis;
					}
					set	
					{
						createMillis = value;
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

				public List<ListNodeGroups__Lock> Locks
				{
					get
					{
						return locks;
					}
					set	
					{
						locks = value;
					}
				}

				public ListNodeGroups_DataDispatchConfig DataDispatchConfig
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

				public class ListNodeGroups__Lock
				{

					private string lockId;

					private string lockType;

					private bool? enabled;

					private long? createMillis;

					public string LockId
					{
						get
						{
							return lockId;
						}
						set	
						{
							lockId = value;
						}
					}

					public string LockType
					{
						get
						{
							return lockType;
						}
						set	
						{
							lockType = value;
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

					public long? CreateMillis
					{
						get
						{
							return createMillis;
						}
						set	
						{
							createMillis = value;
						}
					}
				}

				public class ListNodeGroups_DataDispatchConfig
				{

					private string destination;

					private ListNodeGroups_IotProduct iotProduct;

					private ListNodeGroups_OnsTopics onsTopics;

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

					public ListNodeGroups_IotProduct IotProduct
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

					public ListNodeGroups_OnsTopics OnsTopics
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

					public class ListNodeGroups_IotProduct
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

					public class ListNodeGroups_OnsTopics
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
