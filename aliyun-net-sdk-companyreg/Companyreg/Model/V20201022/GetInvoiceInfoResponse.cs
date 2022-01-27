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
	public class GetInvoiceInfoResponse : AcsResponse
	{

		private string acctgPeriod;

		private string baseTotalAmountWithTax;

		private string baseTotalAmountWithoutTax;

		private string baseTotalTax;

		private long? bizDate;

		private string comments;

		private long? createdStamp;

		private long? dueDate;

		private string elecInvoiceUrl;

		private long? id;

		private string invoiceCode;

		private string invoiceNo;

		private bool? isElectronic;

		private bool? isAuth;

		private bool? isFee;

		private string orgName;

		private string requestId;

		private bool? simulationCertified;

		private string taxNo;

		private string taxPct;

		private string type;

		private string payer;

		private bool? canUpdate;

		private string labelData;

		private List<GetInvoiceInfo_DetailsItem> details;

		private List<GetInvoiceInfo_AcctgTransList> voucherTransList;

		private GetInvoiceInfo_BuyMethod buyMethod;

		private GetInvoiceInfo_BuyTarget buyTarget;

		private GetInvoiceInfo_CustVendorId custVendorId;

		private GetInvoiceInfo_FixedAssetType fixedAssetType;

		private GetInvoiceInfo_IncomeOutType incomeOutType;

		private GetInvoiceInfo_Kind kind;

		private GetInvoiceInfo_PayMethod payMethod;

		private GetInvoiceInfo_ShellMethod shellMethod;

		private GetInvoiceInfo_Use use;

		public string AcctgPeriod
		{
			get
			{
				return acctgPeriod;
			}
			set	
			{
				acctgPeriod = value;
			}
		}

		public string BaseTotalAmountWithTax
		{
			get
			{
				return baseTotalAmountWithTax;
			}
			set	
			{
				baseTotalAmountWithTax = value;
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

		public string BaseTotalTax
		{
			get
			{
				return baseTotalTax;
			}
			set	
			{
				baseTotalTax = value;
			}
		}

		public long? BizDate
		{
			get
			{
				return bizDate;
			}
			set	
			{
				bizDate = value;
			}
		}

		public string Comments
		{
			get
			{
				return comments;
			}
			set	
			{
				comments = value;
			}
		}

		public long? CreatedStamp
		{
			get
			{
				return createdStamp;
			}
			set	
			{
				createdStamp = value;
			}
		}

		public long? DueDate
		{
			get
			{
				return dueDate;
			}
			set	
			{
				dueDate = value;
			}
		}

		public string ElecInvoiceUrl
		{
			get
			{
				return elecInvoiceUrl;
			}
			set	
			{
				elecInvoiceUrl = value;
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

		public bool? IsElectronic
		{
			get
			{
				return isElectronic;
			}
			set	
			{
				isElectronic = value;
			}
		}

		public bool? IsAuth
		{
			get
			{
				return isAuth;
			}
			set	
			{
				isAuth = value;
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

		public bool? SimulationCertified
		{
			get
			{
				return simulationCertified;
			}
			set	
			{
				simulationCertified = value;
			}
		}

		public string TaxNo
		{
			get
			{
				return taxNo;
			}
			set	
			{
				taxNo = value;
			}
		}

		public string TaxPct
		{
			get
			{
				return taxPct;
			}
			set	
			{
				taxPct = value;
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

		public string Payer
		{
			get
			{
				return payer;
			}
			set	
			{
				payer = value;
			}
		}

		public bool? CanUpdate
		{
			get
			{
				return canUpdate;
			}
			set	
			{
				canUpdate = value;
			}
		}

		public string LabelData
		{
			get
			{
				return labelData;
			}
			set	
			{
				labelData = value;
			}
		}

		public List<GetInvoiceInfo_DetailsItem> Details
		{
			get
			{
				return details;
			}
			set	
			{
				details = value;
			}
		}

		public List<GetInvoiceInfo_AcctgTransList> VoucherTransList
		{
			get
			{
				return voucherTransList;
			}
			set	
			{
				voucherTransList = value;
			}
		}

		public GetInvoiceInfo_BuyMethod BuyMethod
		{
			get
			{
				return buyMethod;
			}
			set	
			{
				buyMethod = value;
			}
		}

		public GetInvoiceInfo_BuyTarget BuyTarget
		{
			get
			{
				return buyTarget;
			}
			set	
			{
				buyTarget = value;
			}
		}

		public GetInvoiceInfo_CustVendorId CustVendorId
		{
			get
			{
				return custVendorId;
			}
			set	
			{
				custVendorId = value;
			}
		}

		public GetInvoiceInfo_FixedAssetType FixedAssetType
		{
			get
			{
				return fixedAssetType;
			}
			set	
			{
				fixedAssetType = value;
			}
		}

		public GetInvoiceInfo_IncomeOutType IncomeOutType
		{
			get
			{
				return incomeOutType;
			}
			set	
			{
				incomeOutType = value;
			}
		}

		public GetInvoiceInfo_Kind Kind
		{
			get
			{
				return kind;
			}
			set	
			{
				kind = value;
			}
		}

		public GetInvoiceInfo_PayMethod PayMethod
		{
			get
			{
				return payMethod;
			}
			set	
			{
				payMethod = value;
			}
		}

		public GetInvoiceInfo_ShellMethod ShellMethod
		{
			get
			{
				return shellMethod;
			}
			set	
			{
				shellMethod = value;
			}
		}

		public GetInvoiceInfo_Use Use
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

		public class GetInvoiceInfo_DetailsItem
		{

			private GetInvoiceInfo_Product product;

			public GetInvoiceInfo_Product Product
			{
				get
				{
					return product;
				}
				set	
				{
					product = value;
				}
			}

			public class GetInvoiceInfo_Product
			{

				private long? id;

				private string name;

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
			}
		}

		public class GetInvoiceInfo_AcctgTransList
		{

			private GetInvoiceInfo_VoucherTransId voucherTransId;

			public GetInvoiceInfo_VoucherTransId VoucherTransId
			{
				get
				{
					return voucherTransId;
				}
				set	
				{
					voucherTransId = value;
				}
			}

			public class GetInvoiceInfo_VoucherTransId
			{

				private long? id;

				private string refVoucherIds;

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

				public string RefVoucherIds
				{
					get
					{
						return refVoucherIds;
					}
					set	
					{
						refVoucherIds = value;
					}
				}
			}
		}

		public class GetInvoiceInfo_BuyMethod
		{

			private string key;

			private string _value;

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}

			public string _Value
			{
				get
				{
					return _value;
				}
				set	
				{
					_value = value;
				}
			}
		}

		public class GetInvoiceInfo_BuyTarget
		{

			private string key;

			private string _value;

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}

			public string _Value
			{
				get
				{
					return _value;
				}
				set	
				{
					_value = value;
				}
			}
		}

		public class GetInvoiceInfo_CustVendorId
		{

			private string partyName;

			public string PartyName
			{
				get
				{
					return partyName;
				}
				set	
				{
					partyName = value;
				}
			}
		}

		public class GetInvoiceInfo_FixedAssetType
		{

			private string key;

			private string _value;

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}

			public string _Value
			{
				get
				{
					return _value;
				}
				set	
				{
					_value = value;
				}
			}
		}

		public class GetInvoiceInfo_IncomeOutType
		{

			private string label;

			private string _value;

			public string Label
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

			public string _Value
			{
				get
				{
					return _value;
				}
				set	
				{
					_value = value;
				}
			}
		}

		public class GetInvoiceInfo_Kind
		{

			private string key;

			private string _value;

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}

			public string _Value
			{
				get
				{
					return _value;
				}
				set	
				{
					_value = value;
				}
			}
		}

		public class GetInvoiceInfo_PayMethod
		{

			private string key;

			private string _value;

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}

			public string _Value
			{
				get
				{
					return _value;
				}
				set	
				{
					_value = value;
				}
			}
		}

		public class GetInvoiceInfo_ShellMethod
		{

			private string key;

			private string _value;

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}

			public string _Value
			{
				get
				{
					return _value;
				}
				set	
				{
					_value = value;
				}
			}
		}

		public class GetInvoiceInfo_Use
		{

			private string key;

			private string _value;

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}

			public string _Value
			{
				get
				{
					return _value;
				}
				set	
				{
					_value = value;
				}
			}
		}
	}
}
