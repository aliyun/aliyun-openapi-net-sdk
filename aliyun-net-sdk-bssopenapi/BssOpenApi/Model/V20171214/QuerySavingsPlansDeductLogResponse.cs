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
	public class QuerySavingsPlansDeductLogResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private QuerySavingsPlansDeductLog_Data data;

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
		public QuerySavingsPlansDeductLog_Data Data
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

		public class QuerySavingsPlansDeductLog_Data
		{

			private int? pageNum;

			private int? pageSize;

			private int? totalCount;

			private List<QuerySavingsPlansDeductLog_SavingsPlansDeductDetailResponse> items;

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
			public List<QuerySavingsPlansDeductLog_SavingsPlansDeductDetailResponse> Items
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

			public class QuerySavingsPlansDeductLog_SavingsPlansDeductDetailResponse
			{

				private string endTime;

				private string startTime;

				private string savingsType;

				private long? userId;

				private string discountRate;

				private string billModule;

				private string instanceId;

				private string deductInstanceId;

				private string deductCommodity;

				private string deductRate;

				private string deductFee;

				private long? ownerId;

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

				[JsonProperty(PropertyName = "UserId")]
				public long? UserId
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

				[JsonProperty(PropertyName = "DiscountRate")]
				public string DiscountRate
				{
					get
					{
						return discountRate;
					}
					set	
					{
						discountRate = value;
					}
				}

				[JsonProperty(PropertyName = "BillModule")]
				public string BillModule
				{
					get
					{
						return billModule;
					}
					set	
					{
						billModule = value;
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

				[JsonProperty(PropertyName = "DeductInstanceId")]
				public string DeductInstanceId
				{
					get
					{
						return deductInstanceId;
					}
					set	
					{
						deductInstanceId = value;
					}
				}

				[JsonProperty(PropertyName = "DeductCommodity")]
				public string DeductCommodity
				{
					get
					{
						return deductCommodity;
					}
					set	
					{
						deductCommodity = value;
					}
				}

				[JsonProperty(PropertyName = "DeductRate")]
				public string DeductRate
				{
					get
					{
						return deductRate;
					}
					set	
					{
						deductRate = value;
					}
				}

				[JsonProperty(PropertyName = "DeductFee")]
				public string DeductFee
				{
					get
					{
						return deductFee;
					}
					set	
					{
						deductFee = value;
					}
				}

				[JsonProperty(PropertyName = "OwnerId")]
				public long? OwnerId
				{
					get
					{
						return ownerId;
					}
					set	
					{
						ownerId = value;
					}
				}
			}
		}
	}
}
