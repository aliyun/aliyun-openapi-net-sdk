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
	public class QueryInvoicingCustomerListResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private QueryInvoicingCustomerList_Data data;

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

		public QueryInvoicingCustomerList_Data Data
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

		public class QueryInvoicingCustomerList_Data
		{

			private List<QueryInvoicingCustomerList_CustomerInvoice> customerInvoiceList;

			public List<QueryInvoicingCustomerList_CustomerInvoice> CustomerInvoiceList
			{
				get
				{
					return customerInvoiceList;
				}
				set	
				{
					customerInvoiceList = value;
				}
			}

			public class QueryInvoicingCustomerList_CustomerInvoice
			{

				private long? id;

				private long? userId;

				private string userNick;

				private string invoiceTitle;

				private long? customerType;

				private long? taxpayerType;

				private string bank;

				private string bankNo;

				private string operatingLicenseAddress;

				private string operatingLicensePhone;

				private string registerNo;

				private long? startCycle;

				private long? status;

				private string gmtCreate;

				private string taxationLicense;

				private long? adjustType;

				private long? endCycle;

				private string titleChangeInstructions;

				private long? issueType;

				private long? type;

				private string defaultRemark;

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

				public string InvoiceTitle
				{
					get
					{
						return invoiceTitle;
					}
					set	
					{
						invoiceTitle = value;
					}
				}

				public long? CustomerType
				{
					get
					{
						return customerType;
					}
					set	
					{
						customerType = value;
					}
				}

				public long? TaxpayerType
				{
					get
					{
						return taxpayerType;
					}
					set	
					{
						taxpayerType = value;
					}
				}

				public string Bank
				{
					get
					{
						return bank;
					}
					set	
					{
						bank = value;
					}
				}

				public string BankNo
				{
					get
					{
						return bankNo;
					}
					set	
					{
						bankNo = value;
					}
				}

				public string OperatingLicenseAddress
				{
					get
					{
						return operatingLicenseAddress;
					}
					set	
					{
						operatingLicenseAddress = value;
					}
				}

				public string OperatingLicensePhone
				{
					get
					{
						return operatingLicensePhone;
					}
					set	
					{
						operatingLicensePhone = value;
					}
				}

				public string RegisterNo
				{
					get
					{
						return registerNo;
					}
					set	
					{
						registerNo = value;
					}
				}

				public long? StartCycle
				{
					get
					{
						return startCycle;
					}
					set	
					{
						startCycle = value;
					}
				}

				public long? Status
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

				public string TaxationLicense
				{
					get
					{
						return taxationLicense;
					}
					set	
					{
						taxationLicense = value;
					}
				}

				public long? AdjustType
				{
					get
					{
						return adjustType;
					}
					set	
					{
						adjustType = value;
					}
				}

				public long? EndCycle
				{
					get
					{
						return endCycle;
					}
					set	
					{
						endCycle = value;
					}
				}

				public string TitleChangeInstructions
				{
					get
					{
						return titleChangeInstructions;
					}
					set	
					{
						titleChangeInstructions = value;
					}
				}

				public long? IssueType
				{
					get
					{
						return issueType;
					}
					set	
					{
						issueType = value;
					}
				}

				public long? Type
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

				public string DefaultRemark
				{
					get
					{
						return defaultRemark;
					}
					set	
					{
						defaultRemark = value;
					}
				}
			}
		}
	}
}
