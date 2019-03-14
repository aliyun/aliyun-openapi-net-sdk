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

namespace Aliyun.Acs.Emr.Model.V20160408
{
	public class ListResourcePoolResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageSize;

		private int? total;

		private List<ListResourcePool_PoolInfo> poolInfoList;

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

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public int? Total
		{
			get
			{
				return total;
			}
			set	
			{
				total = value;
			}
		}

		public List<ListResourcePool_PoolInfo> PoolInfoList
		{
			get
			{
				return poolInfoList;
			}
			set	
			{
				poolInfoList = value;
			}
		}

		public class ListResourcePool_PoolInfo
		{

			private List<ListResourcePool_Queue> queueList;

			private List<ListResourcePool_EcmResourcePoolConfig2> ecmResourcePoolConfigList;

			private ListResourcePool_EcmResourcePool ecmResourcePool;

			public List<ListResourcePool_Queue> QueueList
			{
				get
				{
					return queueList;
				}
				set	
				{
					queueList = value;
				}
			}

			public List<ListResourcePool_EcmResourcePoolConfig2> EcmResourcePoolConfigList
			{
				get
				{
					return ecmResourcePoolConfigList;
				}
				set	
				{
					ecmResourcePoolConfigList = value;
				}
			}

			public ListResourcePool_EcmResourcePool EcmResourcePool
			{
				get
				{
					return ecmResourcePool;
				}
				set	
				{
					ecmResourcePool = value;
				}
			}

			public class ListResourcePool_Queue
			{

				private List<ListResourcePool_EcmResourcePoolConfig> ecmResourcePoolConfigList1;

				private ListResourcePool_EcmResourceQueue ecmResourceQueue;

				public List<ListResourcePool_EcmResourcePoolConfig> EcmResourcePoolConfigList1
				{
					get
					{
						return ecmResourcePoolConfigList1;
					}
					set	
					{
						ecmResourcePoolConfigList1 = value;
					}
				}

				public ListResourcePool_EcmResourceQueue EcmResourceQueue
				{
					get
					{
						return ecmResourceQueue;
					}
					set	
					{
						ecmResourceQueue = value;
					}
				}

				public class ListResourcePool_EcmResourcePoolConfig
				{

					private long? id;

					private string configKey;

					private string configValue;

					private string configType;

					private string category;

					private string status;

					private string note;

					public long? Id
					{
						get
						{
							return id;
						}
						set	
						{
							id = value;
						}
					}

					public string ConfigKey
					{
						get
						{
							return configKey;
						}
						set	
						{
							configKey = value;
						}
					}

					public string ConfigValue
					{
						get
						{
							return configValue;
						}
						set	
						{
							configValue = value;
						}
					}

					public string ConfigType
					{
						get
						{
							return configType;
						}
						set	
						{
							configType = value;
						}
					}

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

					public string Note
					{
						get
						{
							return note;
						}
						set	
						{
							note = value;
						}
					}
				}

				public class ListResourcePool_EcmResourceQueue
				{

					private long? id;

					private string name;

					private string qualifiedName;

					private string queueType;

					private long? parentQueueId;

					private bool? leaf;

					private string status;

					private string userId;

					private long? resourcePoolId;

					public long? Id
					{
						get
						{
							return id;
						}
						set	
						{
							id = value;
						}
					}

					public string Name
					{
						get
						{
							return name;
						}
						set	
						{
							name = value;
						}
					}

					public string QualifiedName
					{
						get
						{
							return qualifiedName;
						}
						set	
						{
							qualifiedName = value;
						}
					}

					public string QueueType
					{
						get
						{
							return queueType;
						}
						set	
						{
							queueType = value;
						}
					}

					public long? ParentQueueId
					{
						get
						{
							return parentQueueId;
						}
						set	
						{
							parentQueueId = value;
						}
					}

					public bool? Leaf
					{
						get
						{
							return leaf;
						}
						set	
						{
							leaf = value;
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

					public string UserId
					{
						get
						{
							return userId;
						}
						set	
						{
							userId = value;
						}
					}

					public long? ResourcePoolId
					{
						get
						{
							return resourcePoolId;
						}
						set	
						{
							resourcePoolId = value;
						}
					}
				}
			}

			public class ListResourcePool_EcmResourcePoolConfig2
			{

				private long? id;

				private string configKey;

				private string configValue;

				private string configType;

				private string category;

				private string status;

				private string note;

				public long? Id
				{
					get
					{
						return id;
					}
					set	
					{
						id = value;
					}
				}

				public string ConfigKey
				{
					get
					{
						return configKey;
					}
					set	
					{
						configKey = value;
					}
				}

				public string ConfigValue
				{
					get
					{
						return configValue;
					}
					set	
					{
						configValue = value;
					}
				}

				public string ConfigType
				{
					get
					{
						return configType;
					}
					set	
					{
						configType = value;
					}
				}

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

				public string Note
				{
					get
					{
						return note;
					}
					set	
					{
						note = value;
					}
				}
			}

			public class ListResourcePool_EcmResourcePool
			{

				private long? id;

				private string name;

				private string poolType;

				private bool? active;

				private string note;

				private string userId;

				private string yarnSiteConfig;

				public long? Id
				{
					get
					{
						return id;
					}
					set	
					{
						id = value;
					}
				}

				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}

				public string PoolType
				{
					get
					{
						return poolType;
					}
					set	
					{
						poolType = value;
					}
				}

				public bool? Active
				{
					get
					{
						return active;
					}
					set	
					{
						active = value;
					}
				}

				public string Note
				{
					get
					{
						return note;
					}
					set	
					{
						note = value;
					}
				}

				public string UserId
				{
					get
					{
						return userId;
					}
					set	
					{
						userId = value;
					}
				}

				public string YarnSiteConfig
				{
					get
					{
						return yarnSiteConfig;
					}
					set	
					{
						yarnSiteConfig = value;
					}
				}
			}
		}
	}
}
