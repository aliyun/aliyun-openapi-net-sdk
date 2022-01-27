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

namespace Aliyun.Acs.BssOpenApi.Model.V20171214
{
	public class QuerySavingsPlansDeductLogResponse : AcsResponse
	{

		private string code;

		private string requestId;

		private bool? success;

		private string message;

		private QuerySavingsPlansDeductLog_Data data;

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

				private string instanceId;

				private string startTime;

				private string endTime;

				private string savingsType;

				private string billModule;

				private string deductFee;

				private string deductRate;

				private long? userId;

				private string deductCommodity;

				private string deductInstanceId;

				private string discountRate;

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
			}
		}
	}
}
