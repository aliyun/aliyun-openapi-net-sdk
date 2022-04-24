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

namespace Aliyun.Acs.BssOpenApi.Model.V20171214
{
	public class QuerySavingsPlansInstanceResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private QuerySavingsPlansInstance_Data data;

		public string Code
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

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

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

		public QuerySavingsPlansInstance_Data Data
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

		public class QuerySavingsPlansInstance_Data
		{

			private int? pageNum;

			private int? pageSize;

			private int? totalCount;

			private List<QuerySavingsPlansInstance_SavingsPlansDetailResponse> items;

			public int? PageNum
			{
				get
				{
					return pageNum;
				}
				set	
				{
					pageNum = value;
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

			public int? TotalCount
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

			public List<QuerySavingsPlansInstance_SavingsPlansDetailResponse> Items
			{
				get
				{
					return items;
				}
				set	
				{
					items = value;
				}
			}

			public class QuerySavingsPlansInstance_SavingsPlansDetailResponse
			{

				private string status;

				private string cycle;

				private long? startTimestamp;

				private string savingsType;

				private string utilization;

				private string prepayFee;

				private string instanceId;

				private string currency;

				private long? endTimestamp;

				private string endTime;

				private string startTime;

				private string allocationStatus;

				private string instanceFamily;

				private string region;

				private string lastBillTotalUsage;

				private string lastBillUtilization;

				private string totalSave;

				private string poolValue;

				private string payMode;

				private List<QuerySavingsPlansInstance_Tag> tags;

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

				public string Cycle
				{
					get
					{
						return cycle;
					}
					set	
					{
						cycle = value;
					}
				}

				public long? StartTimestamp
				{
					get
					{
						return startTimestamp;
					}
					set	
					{
						startTimestamp = value;
					}
				}

				public string SavingsType
				{
					get
					{
						return savingsType;
					}
					set	
					{
						savingsType = value;
					}
				}

				public string Utilization
				{
					get
					{
						return utilization;
					}
					set	
					{
						utilization = value;
					}
				}

				public string PrepayFee
				{
					get
					{
						return prepayFee;
					}
					set	
					{
						prepayFee = value;
					}
				}

				public string InstanceId
				{
					get
					{
						return instanceId;
					}
					set	
					{
						instanceId = value;
					}
				}

				public string Currency
				{
					get
					{
						return currency;
					}
					set	
					{
						currency = value;
					}
				}

				public long? EndTimestamp
				{
					get
					{
						return endTimestamp;
					}
					set	
					{
						endTimestamp = value;
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

				public string AllocationStatus
				{
					get
					{
						return allocationStatus;
					}
					set	
					{
						allocationStatus = value;
					}
				}

				public string InstanceFamily
				{
					get
					{
						return instanceFamily;
					}
					set	
					{
						instanceFamily = value;
					}
				}

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

				public string LastBillTotalUsage
				{
					get
					{
						return lastBillTotalUsage;
					}
					set	
					{
						lastBillTotalUsage = value;
					}
				}

				public string LastBillUtilization
				{
					get
					{
						return lastBillUtilization;
					}
					set	
					{
						lastBillUtilization = value;
					}
				}

				public string TotalSave
				{
					get
					{
						return totalSave;
					}
					set	
					{
						totalSave = value;
					}
				}

				public string PoolValue
				{
					get
					{
						return poolValue;
					}
					set	
					{
						poolValue = value;
					}
				}

				public string PayMode
				{
					get
					{
						return payMode;
					}
					set	
					{
						payMode = value;
					}
				}

				public List<QuerySavingsPlansInstance_Tag> Tags
				{
					get
					{
						return tags;
					}
					set	
					{
						tags = value;
					}
				}

				public class QuerySavingsPlansInstance_Tag
				{

					private string key;

					private string _value;

					public string Key
					{
						get
						{
							return key;
						}
						set	
						{
							key = value;
						}
					}

					public string _Value
					{
						get
						{
							return _value;
						}
						set	
						{
							_value = value;
						}
					}
				}
			}
		}
	}
}
