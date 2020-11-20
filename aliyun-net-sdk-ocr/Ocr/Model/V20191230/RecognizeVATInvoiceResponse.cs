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

namespace Aliyun.Acs.ocr.Model.V20191230
{
	public class RecognizeVATInvoiceResponse : AcsResponse
	{

		private string requestId;

		private RecognizeVATInvoice_Data data;

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

		public RecognizeVATInvoice_Data Data
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

		public class RecognizeVATInvoice_Data
		{

			private RecognizeVATInvoice_Content content;

			private RecognizeVATInvoice_Box box;

			public RecognizeVATInvoice_Content Content
			{
				get
				{
					return content;
				}
				set	
				{
					content = value;
				}
			}

			public RecognizeVATInvoice_Box Box
			{
				get
				{
					return box;
				}
				set	
				{
					box = value;
				}
			}

			public class RecognizeVATInvoice_Content
			{

				private string invoiceCode;

				private string invoiceNo;

				private string invoiceDate;

				private string antiFakeCode;

				private string payerName;

				private string payerRegisterNo;

				private string payerAddress;

				private string payerBankName;

				private string withoutTaxAmount;

				private string taxAmount;

				private string sumAmount;

				private string invoiceAmount;

				private string payeeName;

				private string payeeRegisterNo;

				private string payeeAddress;

				private string payeeBankName;

				private string payee;

				private string checker;

				private string clerk;

				public string InvoiceCode
				{
					get
					{
						return invoiceCode;
					}
					set	
					{
						invoiceCode = value;
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

				public string InvoiceDate
				{
					get
					{
						return invoiceDate;
					}
					set	
					{
						invoiceDate = value;
					}
				}

				public string AntiFakeCode
				{
					get
					{
						return antiFakeCode;
					}
					set	
					{
						antiFakeCode = value;
					}
				}

				public string PayerName
				{
					get
					{
						return payerName;
					}
					set	
					{
						payerName = value;
					}
				}

				public string PayerRegisterNo
				{
					get
					{
						return payerRegisterNo;
					}
					set	
					{
						payerRegisterNo = value;
					}
				}

				public string PayerAddress
				{
					get
					{
						return payerAddress;
					}
					set	
					{
						payerAddress = value;
					}
				}

				public string PayerBankName
				{
					get
					{
						return payerBankName;
					}
					set	
					{
						payerBankName = value;
					}
				}

				public string WithoutTaxAmount
				{
					get
					{
						return withoutTaxAmount;
					}
					set	
					{
						withoutTaxAmount = value;
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

				public string SumAmount
				{
					get
					{
						return sumAmount;
					}
					set	
					{
						sumAmount = value;
					}
				}

				public string InvoiceAmount
				{
					get
					{
						return invoiceAmount;
					}
					set	
					{
						invoiceAmount = value;
					}
				}

				public string PayeeName
				{
					get
					{
						return payeeName;
					}
					set	
					{
						payeeName = value;
					}
				}

				public string PayeeRegisterNo
				{
					get
					{
						return payeeRegisterNo;
					}
					set	
					{
						payeeRegisterNo = value;
					}
				}

				public string PayeeAddress
				{
					get
					{
						return payeeAddress;
					}
					set	
					{
						payeeAddress = value;
					}
				}

				public string PayeeBankName
				{
					get
					{
						return payeeBankName;
					}
					set	
					{
						payeeBankName = value;
					}
				}

				public string Payee
				{
					get
					{
						return payee;
					}
					set	
					{
						payee = value;
					}
				}

				public string Checker
				{
					get
					{
						return checker;
					}
					set	
					{
						checker = value;
					}
				}

				public string Clerk
				{
					get
					{
						return clerk;
					}
					set	
					{
						clerk = value;
					}
				}
			}

			public class RecognizeVATInvoice_Box
			{

				private List<string> invoiceCodes;

				private List<string> invoiceNoes;

				private List<string> invoiceDates;

				private List<string> invoiceFakeCodes;

				private List<string> payerNames;

				private List<string> payerRegisterNoes;

				private List<string> payerAddresses;

				private List<string> payerBankNames;

				private List<string> withoutTaxAmounts;

				private List<string> taxAmounts;

				private List<string> sumAmounts;

				private List<string> invoiceAmounts;

				private List<string> payeeNames;

				private List<string> payeeRegisterNoes;

				private List<string> payeeAddresses;

				private List<string> payeeBankNames;

				private List<string> payees;

				private List<string> checkers;

				private List<string> clerks;

				public List<string> InvoiceCodes
				{
					get
					{
						return invoiceCodes;
					}
					set	
					{
						invoiceCodes = value;
					}
				}

				public List<string> InvoiceNoes
				{
					get
					{
						return invoiceNoes;
					}
					set	
					{
						invoiceNoes = value;
					}
				}

				public List<string> InvoiceDates
				{
					get
					{
						return invoiceDates;
					}
					set	
					{
						invoiceDates = value;
					}
				}

				public List<string> InvoiceFakeCodes
				{
					get
					{
						return invoiceFakeCodes;
					}
					set	
					{
						invoiceFakeCodes = value;
					}
				}

				public List<string> PayerNames
				{
					get
					{
						return payerNames;
					}
					set	
					{
						payerNames = value;
					}
				}

				public List<string> PayerRegisterNoes
				{
					get
					{
						return payerRegisterNoes;
					}
					set	
					{
						payerRegisterNoes = value;
					}
				}

				public List<string> PayerAddresses
				{
					get
					{
						return payerAddresses;
					}
					set	
					{
						payerAddresses = value;
					}
				}

				public List<string> PayerBankNames
				{
					get
					{
						return payerBankNames;
					}
					set	
					{
						payerBankNames = value;
					}
				}

				public List<string> WithoutTaxAmounts
				{
					get
					{
						return withoutTaxAmounts;
					}
					set	
					{
						withoutTaxAmounts = value;
					}
				}

				public List<string> TaxAmounts
				{
					get
					{
						return taxAmounts;
					}
					set	
					{
						taxAmounts = value;
					}
				}

				public List<string> SumAmounts
				{
					get
					{
						return sumAmounts;
					}
					set	
					{
						sumAmounts = value;
					}
				}

				public List<string> InvoiceAmounts
				{
					get
					{
						return invoiceAmounts;
					}
					set	
					{
						invoiceAmounts = value;
					}
				}

				public List<string> PayeeNames
				{
					get
					{
						return payeeNames;
					}
					set	
					{
						payeeNames = value;
					}
				}

				public List<string> PayeeRegisterNoes
				{
					get
					{
						return payeeRegisterNoes;
					}
					set	
					{
						payeeRegisterNoes = value;
					}
				}

				public List<string> PayeeAddresses
				{
					get
					{
						return payeeAddresses;
					}
					set	
					{
						payeeAddresses = value;
					}
				}

				public List<string> PayeeBankNames
				{
					get
					{
						return payeeBankNames;
					}
					set	
					{
						payeeBankNames = value;
					}
				}

				public List<string> Payees
				{
					get
					{
						return payees;
					}
					set	
					{
						payees = value;
					}
				}

				public List<string> Checkers
				{
					get
					{
						return checkers;
					}
					set	
					{
						checkers = value;
					}
				}

				public List<string> Clerks
				{
					get
					{
						return clerks;
					}
					set	
					{
						clerks = value;
					}
				}
			}
		}
	}
}
