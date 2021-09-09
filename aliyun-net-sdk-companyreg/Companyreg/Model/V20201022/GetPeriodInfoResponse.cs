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

namespace Aliyun.Acs.companyreg.Model.V20201022
{
	public class GetPeriodInfoResponse : AcsResponse
	{

		private int? employeeCount;

		private string requestId;

		private List<string> taxSteps;

		private GetPeriodInfo_InvoiceInfo invoiceInfo;

		private GetPeriodInfo_BankSummaryInfo bankSummaryInfo;

		public int? EmployeeCount
		{
			get
			{
				return employeeCount;
			}
			set	
			{
				employeeCount = value;
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

		public List<string> TaxSteps
		{
			get
			{
				return taxSteps;
			}
			set	
			{
				taxSteps = value;
			}
		}

		public GetPeriodInfo_InvoiceInfo InvoiceInfo
		{
			get
			{
				return invoiceInfo;
			}
			set	
			{
				invoiceInfo = value;
			}
		}

		public GetPeriodInfo_BankSummaryInfo BankSummaryInfo
		{
			get
			{
				return bankSummaryInfo;
			}
			set	
			{
				bankSummaryInfo = value;
			}
		}

		public class GetPeriodInfo_InvoiceInfo
		{

			private GetPeriodInfo_Fee fee;

			private GetPeriodInfo_InvoiceIncome invoiceIncome;

			private GetPeriodInfo_InvoiceOut invoiceOut;

			public GetPeriodInfo_Fee Fee
			{
				get
				{
					return fee;
				}
				set	
				{
					fee = value;
				}
			}

			public GetPeriodInfo_InvoiceIncome InvoiceIncome
			{
				get
				{
					return invoiceIncome;
				}
				set	
				{
					invoiceIncome = value;
				}
			}

			public GetPeriodInfo_InvoiceOut InvoiceOut
			{
				get
				{
					return invoiceOut;
				}
				set	
				{
					invoiceOut = value;
				}
			}

			public class GetPeriodInfo_Fee
			{

				private string amount;

				private string amountWithTax;

				private int? count;

				private string taxAmount;

				public string Amount
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

				public string AmountWithTax
				{
					get
					{
						return amountWithTax;
					}
					set	
					{
						amountWithTax = value;
					}
				}

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

				public string TaxAmount
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
			}

			public class GetPeriodInfo_InvoiceIncome
			{

				private string amount;

				private string amountWithTax;

				private int? count;

				private string taxAmount;

				public string Amount
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

				public string AmountWithTax
				{
					get
					{
						return amountWithTax;
					}
					set	
					{
						amountWithTax = value;
					}
				}

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

				public string TaxAmount
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
			}

			public class GetPeriodInfo_InvoiceOut
			{

				private string amount;

				private string amountWithTax;

				private int? count;

				private string taxAmount;

				public string Amount
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

				public string AmountWithTax
				{
					get
					{
						return amountWithTax;
					}
					set	
					{
						amountWithTax = value;
					}
				}

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

				public string TaxAmount
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
			}
		}

		public class GetPeriodInfo_BankSummaryInfo
		{

			private GetPeriodInfo_Income income;

			private GetPeriodInfo_Expend expend;

			public GetPeriodInfo_Income Income
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

			public GetPeriodInfo_Expend Expend
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

			public class GetPeriodInfo_Income
			{

				private string amount;

				private int? count;

				public string Amount
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
			}

			public class GetPeriodInfo_Expend
			{

				private string amount;

				private int? count;

				public string Amount
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
			}
		}
	}
}
