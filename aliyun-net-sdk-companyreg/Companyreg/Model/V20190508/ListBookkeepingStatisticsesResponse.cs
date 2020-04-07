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

namespace Aliyun.Acs.companyreg.Model.V20190508
{
	public class ListBookkeepingStatisticsesResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageSize;

		private int? pageNumber;

		private float? incomeSum;

		private float? expendSum;

		private float? profitSum;

		private float? taxAmountSum;

		private List<ListBookkeepingStatisticses_BookkeepingStatistics> bookkeepingStatisticses;

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

		public float? IncomeSum
		{
			get
			{
				return incomeSum;
			}
			set	
			{
				incomeSum = value;
			}
		}

		public float? ExpendSum
		{
			get
			{
				return expendSum;
			}
			set	
			{
				expendSum = value;
			}
		}

		public float? ProfitSum
		{
			get
			{
				return profitSum;
			}
			set	
			{
				profitSum = value;
			}
		}

		public float? TaxAmountSum
		{
			get
			{
				return taxAmountSum;
			}
			set	
			{
				taxAmountSum = value;
			}
		}

		public List<ListBookkeepingStatisticses_BookkeepingStatistics> BookkeepingStatisticses
		{
			get
			{
				return bookkeepingStatisticses;
			}
			set	
			{
				bookkeepingStatisticses = value;
			}
		}

		public class ListBookkeepingStatisticses_BookkeepingStatistics
		{

			private string produceBizId;

			private int? year;

			private int? month;

			private float? income;

			private float? expend;

			private float? profit;

			private float? taxAmount;

			private float? taxZzs;

			private float? taxFjs;

			private float? taxQysds;

			private float? taxYhs;

			private float? taxGhjf;

			private float? taxSljj;

			private float? taxCjrbzj;

			private float? taxOther;

			private string taxAmountNote;

			private string taxZzsNote;

			private string taxFjsNote;

			private string taxQysdsNote;

			private string taxYhsNote;

			private string taxGhjfNote;

			private string taxSljjNote;

			private string taxCjrbzjNote;

			private string taxOtherNote;

			private int? voucherCount;

			private int? subjectCount;

			private List<ListBookkeepingStatisticses_TaxDetail> taxDetails;

			public string ProduceBizId
			{
				get
				{
					return produceBizId;
				}
				set	
				{
					produceBizId = value;
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

			public int? Month
			{
				get
				{
					return month;
				}
				set	
				{
					month = value;
				}
			}

			public float? Income
			{
				get
				{
					return income;
				}
				set	
				{
					income = value;
				}
			}

			public float? Expend
			{
				get
				{
					return expend;
				}
				set	
				{
					expend = value;
				}
			}

			public float? Profit
			{
				get
				{
					return profit;
				}
				set	
				{
					profit = value;
				}
			}

			public float? TaxAmount
			{
				get
				{
					return taxAmount;
				}
				set	
				{
					taxAmount = value;
				}
			}

			public float? TaxZzs
			{
				get
				{
					return taxZzs;
				}
				set	
				{
					taxZzs = value;
				}
			}

			public float? TaxFjs
			{
				get
				{
					return taxFjs;
				}
				set	
				{
					taxFjs = value;
				}
			}

			public float? TaxQysds
			{
				get
				{
					return taxQysds;
				}
				set	
				{
					taxQysds = value;
				}
			}

			public float? TaxYhs
			{
				get
				{
					return taxYhs;
				}
				set	
				{
					taxYhs = value;
				}
			}

			public float? TaxGhjf
			{
				get
				{
					return taxGhjf;
				}
				set	
				{
					taxGhjf = value;
				}
			}

			public float? TaxSljj
			{
				get
				{
					return taxSljj;
				}
				set	
				{
					taxSljj = value;
				}
			}

			public float? TaxCjrbzj
			{
				get
				{
					return taxCjrbzj;
				}
				set	
				{
					taxCjrbzj = value;
				}
			}

			public float? TaxOther
			{
				get
				{
					return taxOther;
				}
				set	
				{
					taxOther = value;
				}
			}

			public string TaxAmountNote
			{
				get
				{
					return taxAmountNote;
				}
				set	
				{
					taxAmountNote = value;
				}
			}

			public string TaxZzsNote
			{
				get
				{
					return taxZzsNote;
				}
				set	
				{
					taxZzsNote = value;
				}
			}

			public string TaxFjsNote
			{
				get
				{
					return taxFjsNote;
				}
				set	
				{
					taxFjsNote = value;
				}
			}

			public string TaxQysdsNote
			{
				get
				{
					return taxQysdsNote;
				}
				set	
				{
					taxQysdsNote = value;
				}
			}

			public string TaxYhsNote
			{
				get
				{
					return taxYhsNote;
				}
				set	
				{
					taxYhsNote = value;
				}
			}

			public string TaxGhjfNote
			{
				get
				{
					return taxGhjfNote;
				}
				set	
				{
					taxGhjfNote = value;
				}
			}

			public string TaxSljjNote
			{
				get
				{
					return taxSljjNote;
				}
				set	
				{
					taxSljjNote = value;
				}
			}

			public string TaxCjrbzjNote
			{
				get
				{
					return taxCjrbzjNote;
				}
				set	
				{
					taxCjrbzjNote = value;
				}
			}

			public string TaxOtherNote
			{
				get
				{
					return taxOtherNote;
				}
				set	
				{
					taxOtherNote = value;
				}
			}

			public int? VoucherCount
			{
				get
				{
					return voucherCount;
				}
				set	
				{
					voucherCount = value;
				}
			}

			public int? SubjectCount
			{
				get
				{
					return subjectCount;
				}
				set	
				{
					subjectCount = value;
				}
			}

			public List<ListBookkeepingStatisticses_TaxDetail> TaxDetails
			{
				get
				{
					return taxDetails;
				}
				set	
				{
					taxDetails = value;
				}
			}

			public class ListBookkeepingStatisticses_TaxDetail
			{

				private string taxName;

				private int? year;

				private int? month;

				private float? amount;

				private string remark;

				public string TaxName
				{
					get
					{
						return taxName;
					}
					set	
					{
						taxName = value;
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

				public int? Month
				{
					get
					{
						return month;
					}
					set	
					{
						month = value;
					}
				}

				public float? Amount
				{
					get
					{
						return amount;
					}
					set	
					{
						amount = value;
					}
				}

				public string Remark
				{
					get
					{
						return remark;
					}
					set	
					{
						remark = value;
					}
				}
			}
		}
	}
}
