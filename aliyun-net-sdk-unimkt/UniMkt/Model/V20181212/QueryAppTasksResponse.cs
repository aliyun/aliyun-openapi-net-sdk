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

namespace Aliyun.Acs.UniMkt.Model.V20181212
{
	public class QueryAppTasksResponse : AcsResponse
	{

		private string requestId;

		private int? code;

		private bool? success;

		private QueryAppTasks_Data data;

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

		public int? Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
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

		public QueryAppTasks_Data Data
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

		public class QueryAppTasks_Data
		{

			private int? count;

			private List<QueryAppTasks_ListItem> list;

			public int? Count
			{
				get
				{
					return count;
				}
				set	
				{
					count = value;
				}
			}

			public List<QueryAppTasks_ListItem> List
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

			public class QueryAppTasks_ListItem
			{

				private long? id;

				private string name;

				private int? openScene;

				private int? allContentStatus;

				private int? popularizePosition;

				private string priceType;

				private string contentIds;

				private long? brandUserId;

				private long? proxyUserId;

				private string accountNo;

				private long? quota;

				private long? quotaDay;

				private long? balance;

				private long? balanceDay;

				private string startTime;

				private string endTime;

				private int? status;

				private long? chargeCost;

				private int? priority;

				private string timeSchema;

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

				public int? OpenScene
				{
					get
					{
						return openScene;
					}
					set	
					{
						openScene = value;
					}
				}

				public int? AllContentStatus
				{
					get
					{
						return allContentStatus;
					}
					set	
					{
						allContentStatus = value;
					}
				}

				public int? PopularizePosition
				{
					get
					{
						return popularizePosition;
					}
					set	
					{
						popularizePosition = value;
					}
				}

				public string PriceType
				{
					get
					{
						return priceType;
					}
					set	
					{
						priceType = value;
					}
				}

				public string ContentIds
				{
					get
					{
						return contentIds;
					}
					set	
					{
						contentIds = value;
					}
				}

				public long? BrandUserId
				{
					get
					{
						return brandUserId;
					}
					set	
					{
						brandUserId = value;
					}
				}

				public long? ProxyUserId
				{
					get
					{
						return proxyUserId;
					}
					set	
					{
						proxyUserId = value;
					}
				}

				public string AccountNo
				{
					get
					{
						return accountNo;
					}
					set	
					{
						accountNo = value;
					}
				}

				public long? Quota
				{
					get
					{
						return quota;
					}
					set	
					{
						quota = value;
					}
				}

				public long? QuotaDay
				{
					get
					{
						return quotaDay;
					}
					set	
					{
						quotaDay = value;
					}
				}

				public long? Balance
				{
					get
					{
						return balance;
					}
					set	
					{
						balance = value;
					}
				}

				public long? BalanceDay
				{
					get
					{
						return balanceDay;
					}
					set	
					{
						balanceDay = value;
					}
				}

				public string StartTime
				{
					get
					{
						return startTime;
					}
					set	
					{
						startTime = value;
					}
				}

				public string EndTime
				{
					get
					{
						return endTime;
					}
					set	
					{
						endTime = value;
					}
				}

				public int? Status
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

				public long? ChargeCost
				{
					get
					{
						return chargeCost;
					}
					set	
					{
						chargeCost = value;
					}
				}

				public int? Priority
				{
					get
					{
						return priority;
					}
					set	
					{
						priority = value;
					}
				}

				public string TimeSchema
				{
					get
					{
						return timeSchema;
					}
					set	
					{
						timeSchema = value;
					}
				}
			}
		}
	}
}
