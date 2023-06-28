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

		[JsonProperty(PropertyName = "Code")]
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

		[JsonProperty(PropertyName = "Message")]
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

		[JsonProperty(PropertyName = "Success")]
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

		[JsonProperty(PropertyName = "Data")]
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

			[JsonProperty(PropertyName = "PageNum")]
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

			[JsonProperty(PropertyName = "PageSize")]
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

			[JsonProperty(PropertyName = "TotalCount")]
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

			[JsonProperty(PropertyName = "Items")]
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

				private string deductCycleType;

				private string restPoolValue;

				private List<QuerySavingsPlansInstance_Tag> tags;

				[JsonProperty(PropertyName = "Status")]
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

				[JsonProperty(PropertyName = "Cycle")]
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

				[JsonProperty(PropertyName = "StartTimestamp")]
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

				[JsonProperty(PropertyName = "SavingsType")]
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

				[JsonProperty(PropertyName = "Utilization")]
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

				[JsonProperty(PropertyName = "PrepayFee")]
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

				[JsonProperty(PropertyName = "InstanceId")]
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

				[JsonProperty(PropertyName = "Currency")]
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

				[JsonProperty(PropertyName = "EndTimestamp")]
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

				[JsonProperty(PropertyName = "EndTime")]
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

				[JsonProperty(PropertyName = "StartTime")]
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

				[JsonProperty(PropertyName = "AllocationStatus")]
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

				[JsonProperty(PropertyName = "InstanceFamily")]
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

				[JsonProperty(PropertyName = "LastBillTotalUsage")]
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

				[JsonProperty(PropertyName = "LastBillUtilization")]
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

				[JsonProperty(PropertyName = "TotalSave")]
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

				[JsonProperty(PropertyName = "PoolValue")]
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

				[JsonProperty(PropertyName = "PayMode")]
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

				[JsonProperty(PropertyName = "DeductCycleType")]
				public string DeductCycleType
				{
					get
					{
						return deductCycleType;
					}
					set	
					{
						deductCycleType = value;
					}
				}

				[JsonProperty(PropertyName = "RestPoolValue")]
				public string RestPoolValue
				{
					get
					{
						return restPoolValue;
					}
					set	
					{
						restPoolValue = value;
					}
				}

				[JsonProperty(PropertyName = "Tags")]
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

					[JsonProperty(PropertyName = "Key")]
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

					[JsonProperty(PropertyName = "_Value")]
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
