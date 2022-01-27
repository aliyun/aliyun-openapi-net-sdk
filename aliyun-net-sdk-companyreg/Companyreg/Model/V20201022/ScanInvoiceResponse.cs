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
	public class ScanInvoiceResponse : AcsResponse
	{

		private string code;

		private bool? isFee;

		private string requestId;

		private bool? success;

		private ScanInvoice_Invoice invoice;

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

		public bool? IsFee
		{
			get
			{
				return isFee;
			}
			set	
			{
				isFee = value;
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

		public ScanInvoice_Invoice Invoice
		{
			get
			{
				return invoice;
			}
			set	
			{
				invoice = value;
			}
		}

		public class ScanInvoice_Invoice
		{

			private long? id;

			private string baseTotalAmountWithoutTax;

			private string invoiceNo;

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

			public string BaseTotalAmountWithoutTax
			{
				get
				{
					return baseTotalAmountWithoutTax;
				}
				set	
				{
					baseTotalAmountWithoutTax = value;
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
		}
	}
}
