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
	public class ListInvoiceResponse : AcsResponse
	{

		private string amount;

		private int? count;

		private string requestId;

		private List<ListInvoice_DataItem> data;

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

		public List<ListInvoice_DataItem> Data
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

		public class ListInvoice_DataItem
		{

			private string amount;

			private string date;

			private long? id;

			private string invoiceNo;

			private bool? isSaveVoucher;

			private string orgName;

			private string productName;

			private string tax;

			private string taxAndAmount;

			private string type;

			private string url;

			private bool? use;

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

			public string Date
			{
				get
				{
					return date;
				}
				set	
				{
					date = value;
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

			public string InvoiceNo
			{
				get
				{
					return invoiceNo;
				}
				set	
				{
					invoiceNo = value;
				}
			}

			public bool? IsSaveVoucher
			{
				get
				{
					return isSaveVoucher;
				}
				set	
				{
					isSaveVoucher = value;
				}
			}

			public string OrgName
			{
				get
				{
					return orgName;
				}
				set	
				{
					orgName = value;
				}
			}

			public string ProductName
			{
				get
				{
					return productName;
				}
				set	
				{
					productName = value;
				}
			}

			public string Tax
			{
				get
				{
					return tax;
				}
				set	
				{
					tax = value;
				}
			}

			public string TaxAndAmount
			{
				get
				{
					return taxAndAmount;
				}
				set	
				{
					taxAndAmount = value;
				}
			}

			public string Type
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

			public string Url
			{
				get
				{
					return url;
				}
				set	
				{
					url = value;
				}
			}

			public bool? Use
			{
				get
				{
					return use;
				}
				set	
				{
					use = value;
				}
			}
		}
	}
}
