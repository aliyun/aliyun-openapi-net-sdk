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
	public class QueryEvaluateListResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private QueryEvaluateList_Data data;

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

		public QueryEvaluateList_Data Data
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

		public class QueryEvaluateList_Data
		{

			private int? pageNum;

			private long? totalUnAppliedInvoiceAmount;

			private int? pageSize;

			private int? totalCount;

			private long? totalInvoiceAmount;

			private string hostId;

			private List<QueryEvaluateList_Evaluate> evaluateList;

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

			public long? TotalUnAppliedInvoiceAmount
			{
				get
				{
					return totalUnAppliedInvoiceAmount;
				}
				set	
				{
					totalUnAppliedInvoiceAmount = value;
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

			public long? TotalInvoiceAmount
			{
				get
				{
					return totalInvoiceAmount;
				}
				set	
				{
					totalInvoiceAmount = value;
				}
			}

			public string HostId
			{
				get
				{
					return hostId;
				}
				set	
				{
					hostId = value;
				}
			}

			public List<QueryEvaluateList_Evaluate> EvaluateList
			{
				get
				{
					return evaluateList;
				}
				set	
				{
					evaluateList = value;
				}
			}

			public class QueryEvaluateList_Evaluate
			{

				private int? type;

				private int? status;

				private long? billId;

				private long? userId;

				private string billCycle;

				private long? canInvoiceAmount;

				private long? offsetAcceptAmount;

				private long? itemId;

				private string outBizId;

				private string userNick;

				private string gmtModified;

				private string opId;

				private string bizType;

				private long? originalAmount;

				private long? invoicedAmount;

				private string gmtCreate;

				private long? presentAmount;

				private string bizTime;

				private string name;

				private long? offsetCostAmount;

				private long? id;

				public int? Type
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

				public long? BillId
				{
					get
					{
						return billId;
					}
					set	
					{
						billId = value;
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

				public string BillCycle
				{
					get
					{
						return billCycle;
					}
					set	
					{
						billCycle = value;
					}
				}

				public long? CanInvoiceAmount
				{
					get
					{
						return canInvoiceAmount;
					}
					set	
					{
						canInvoiceAmount = value;
					}
				}

				public long? OffsetAcceptAmount
				{
					get
					{
						return offsetAcceptAmount;
					}
					set	
					{
						offsetAcceptAmount = value;
					}
				}

				public long? ItemId
				{
					get
					{
						return itemId;
					}
					set	
					{
						itemId = value;
					}
				}

				public string OutBizId
				{
					get
					{
						return outBizId;
					}
					set	
					{
						outBizId = value;
					}
				}

				public string UserNick
				{
					get
					{
						return userNick;
					}
					set	
					{
						userNick = value;
					}
				}

				public string GmtModified
				{
					get
					{
						return gmtModified;
					}
					set	
					{
						gmtModified = value;
					}
				}

				public string OpId
				{
					get
					{
						return opId;
					}
					set	
					{
						opId = value;
					}
				}

				public string BizType
				{
					get
					{
						return bizType;
					}
					set	
					{
						bizType = value;
					}
				}

				public long? OriginalAmount
				{
					get
					{
						return originalAmount;
					}
					set	
					{
						originalAmount = value;
					}
				}

				public long? InvoicedAmount
				{
					get
					{
						return invoicedAmount;
					}
					set	
					{
						invoicedAmount = value;
					}
				}

				public string GmtCreate
				{
					get
					{
						return gmtCreate;
					}
					set	
					{
						gmtCreate = value;
					}
				}

				public long? PresentAmount
				{
					get
					{
						return presentAmount;
					}
					set	
					{
						presentAmount = value;
					}
				}

				public string BizTime
				{
					get
					{
						return bizTime;
					}
					set	
					{
						bizTime = value;
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

				public long? OffsetCostAmount
				{
					get
					{
						return offsetCostAmount;
					}
					set	
					{
						offsetCostAmount = value;
					}
				}

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
			}
		}
	}
}
