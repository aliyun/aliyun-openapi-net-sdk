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
	public class QueryInvoicingCustomerListResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private QueryInvoicingCustomerList_Data data;

		[JsonProperty(PropertyName = "Code")]
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

		[JsonProperty(PropertyName = "Message")]
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

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "Success")]
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

		[JsonProperty(PropertyName = "Data")]
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

			[JsonProperty(PropertyName = "CustomerInvoiceList")]
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

				private long? type;

				private long? status;

				private long? adjustType;

				private string bank;

				private long? startCycle;

				private string titleChangeInstructions;

				private long? userId;

				private string operatingLicenseAddress;

				private string invoiceTitle;

				private string userNick;

				private string operatingLicensePhone;

				private long? endCycle;

				private string defaultRemark;

				private string taxationLicense;

				private string registerNo;

				private string gmtCreate;

				private long? taxpayerType;

				private long? customerType;

				private long? issueType;

				private long? id;

				private string bankNo;

				[JsonProperty(PropertyName = "Type")]
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

				[JsonProperty(PropertyName = "Status")]
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

				[JsonProperty(PropertyName = "AdjustType")]
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

				[JsonProperty(PropertyName = "Bank")]
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

				[JsonProperty(PropertyName = "StartCycle")]
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

				[JsonProperty(PropertyName = "TitleChangeInstructions")]
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

				[JsonProperty(PropertyName = "UserId")]
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

				[JsonProperty(PropertyName = "OperatingLicenseAddress")]
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

				[JsonProperty(PropertyName = "InvoiceTitle")]
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

				[JsonProperty(PropertyName = "UserNick")]
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

				[JsonProperty(PropertyName = "OperatingLicensePhone")]
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

				[JsonProperty(PropertyName = "EndCycle")]
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

				[JsonProperty(PropertyName = "DefaultRemark")]
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

				[JsonProperty(PropertyName = "TaxationLicense")]
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

				[JsonProperty(PropertyName = "RegisterNo")]
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

				[JsonProperty(PropertyName = "GmtCreate")]
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

				[JsonProperty(PropertyName = "TaxpayerType")]
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

				[JsonProperty(PropertyName = "CustomerType")]
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

				[JsonProperty(PropertyName = "IssueType")]
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

				[JsonProperty(PropertyName = "Id")]
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

				[JsonProperty(PropertyName = "BankNo")]
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
			}
		}
	}
}
