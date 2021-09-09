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
	public class GetLastMonthInvoiceCountResponse : AcsResponse
	{

		private string requestId;

		private GetLastMonthInvoiceCount_InvoiceIncome invoiceIncome;

		private GetLastMonthInvoiceCount_InvoiceOut invoiceOut;

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

		public GetLastMonthInvoiceCount_InvoiceIncome InvoiceIncome
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

		public GetLastMonthInvoiceCount_InvoiceOut InvoiceOut
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

		public class GetLastMonthInvoiceCount_InvoiceIncome
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

		public class GetLastMonthInvoiceCount_InvoiceOut
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
}
