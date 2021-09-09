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
	public class GetFeeResponse : AcsResponse
	{

		private string acctgPeriod;

		private string baseTotalAmount;

		private string baseTotalAmountWithoutTax;

		private string baseTotalTax;

		private long? createdStamp;

		private long? id;

		private string requestId;

		private string url;

		private string payer;

		private bool? canUpdate;

		private string labelData;

		private List<GetFee_AcctgTransList> voucherTransList;

		private GetFee_FeeTypeEnum feeTypeEnum;

		private GetFee_Kind kind;

		private GetFee_PayMethod payMethod;

		private GetFee_Use use;

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

		public string BaseTotalAmount
		{
			get
			{
				return baseTotalAmount;
			}
			set	
			{
				baseTotalAmount = value;
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

		public List<GetFee_AcctgTransList> VoucherTransList
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

		public GetFee_FeeTypeEnum FeeTypeEnum
		{
			get
			{
				return feeTypeEnum;
			}
			set	
			{
				feeTypeEnum = value;
			}
		}

		public GetFee_Kind Kind
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

		public GetFee_PayMethod PayMethod
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

		public GetFee_Use Use
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

		public class GetFee_AcctgTransList
		{

			private GetFee_VoucherTransId voucherTransId;

			public GetFee_VoucherTransId VoucherTransId
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

			public class GetFee_VoucherTransId
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

		public class GetFee_FeeTypeEnum
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

		public class GetFee_Kind
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

		public class GetFee_PayMethod
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

		public class GetFee_Use
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
