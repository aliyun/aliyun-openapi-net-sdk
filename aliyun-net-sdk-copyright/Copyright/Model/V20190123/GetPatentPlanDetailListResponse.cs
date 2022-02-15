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

namespace Aliyun.Acs.Copyright.Model.V20190123
{
	public class GetPatentPlanDetailListResponse : AcsResponse
	{

		private int? pageNum;

		private string requestId;

		private bool? success;

		private int? totalItemNum;

		private int? pageSize;

		private int? totalPageNum;

		private List<GetPatentPlanDetailList_DataItem> data;

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

		public int? TotalItemNum
		{
			get
			{
				return totalItemNum;
			}
			set	
			{
				totalItemNum = value;
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

		public int? TotalPageNum
		{
			get
			{
				return totalPageNum;
			}
			set	
			{
				totalPageNum = value;
			}
		}

		public List<GetPatentPlanDetailList_DataItem> Data
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

		public class GetPatentPlanDetailList_DataItem
		{

			private int? type;

			private string owner;

			private string paidDate;

			private string endPayDate;

			private string planPayDate;

			private int? soldStatus;

			private string applyNumber;

			private string gmtExpireDate;

			private string bizId;

			private int? label;

			private long? planId;

			private int? year;

			private long? planDetailId;

			private int? payStatus;

			private string patentStatus;

			private string agency;

			private int? discount;

			private bool? uidAgreement;

			private bool? patentDiscard;

			private string name;

			private long? updateTime;

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

			public string Owner
			{
				get
				{
					return owner;
				}
				set	
				{
					owner = value;
				}
			}

			public string PaidDate
			{
				get
				{
					return paidDate;
				}
				set	
				{
					paidDate = value;
				}
			}

			public string EndPayDate
			{
				get
				{
					return endPayDate;
				}
				set	
				{
					endPayDate = value;
				}
			}

			public string PlanPayDate
			{
				get
				{
					return planPayDate;
				}
				set	
				{
					planPayDate = value;
				}
			}

			public int? SoldStatus
			{
				get
				{
					return soldStatus;
				}
				set	
				{
					soldStatus = value;
				}
			}

			public string ApplyNumber
			{
				get
				{
					return applyNumber;
				}
				set	
				{
					applyNumber = value;
				}
			}

			public string GmtExpireDate
			{
				get
				{
					return gmtExpireDate;
				}
				set	
				{
					gmtExpireDate = value;
				}
			}

			public string BizId
			{
				get
				{
					return bizId;
				}
				set	
				{
					bizId = value;
				}
			}

			public int? Label
			{
				get
				{
					return label;
				}
				set	
				{
					label = value;
				}
			}

			public long? PlanId
			{
				get
				{
					return planId;
				}
				set	
				{
					planId = value;
				}
			}

			public int? Year
			{
				get
				{
					return year;
				}
				set	
				{
					year = value;
				}
			}

			public long? PlanDetailId
			{
				get
				{
					return planDetailId;
				}
				set	
				{
					planDetailId = value;
				}
			}

			public int? PayStatus
			{
				get
				{
					return payStatus;
				}
				set	
				{
					payStatus = value;
				}
			}

			public string PatentStatus
			{
				get
				{
					return patentStatus;
				}
				set	
				{
					patentStatus = value;
				}
			}

			public string Agency
			{
				get
				{
					return agency;
				}
				set	
				{
					agency = value;
				}
			}

			public int? Discount
			{
				get
				{
					return discount;
				}
				set	
				{
					discount = value;
				}
			}

			public bool? UidAgreement
			{
				get
				{
					return uidAgreement;
				}
				set	
				{
					uidAgreement = value;
				}
			}

			public bool? PatentDiscard
			{
				get
				{
					return patentDiscard;
				}
				set	
				{
					patentDiscard = value;
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

			public long? UpdateTime
			{
				get
				{
					return updateTime;
				}
				set	
				{
					updateTime = value;
				}
			}
		}
	}
}
