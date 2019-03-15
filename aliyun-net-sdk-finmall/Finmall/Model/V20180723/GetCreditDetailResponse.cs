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

namespace Aliyun.Acs.finmall.Model.V20180723
{
	public class GetCreditDetailResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private GetCreditDetail_Data data;

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

		public GetCreditDetail_Data Data
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

		public class GetCreditDetail_Data
		{

			private string creditId;

			private string productName;

			private string lineOfCredit;

			private string amount;

			private string debtorName;

			private string loanBalance;

			private string repayPhase;

			private string state;

			private string createDate;

			private string updateDate;

			private string productId;

			private string fundPartyId;

			private string downPaymentAmount;

			private string downPaymentRate;

			public string CreditId
			{
				get
				{
					return creditId;
				}
				set	
				{
					creditId = value;
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

			public string LineOfCredit
			{
				get
				{
					return lineOfCredit;
				}
				set	
				{
					lineOfCredit = value;
				}
			}

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

			public string DebtorName
			{
				get
				{
					return debtorName;
				}
				set	
				{
					debtorName = value;
				}
			}

			public string LoanBalance
			{
				get
				{
					return loanBalance;
				}
				set	
				{
					loanBalance = value;
				}
			}

			public string RepayPhase
			{
				get
				{
					return repayPhase;
				}
				set	
				{
					repayPhase = value;
				}
			}

			public string State
			{
				get
				{
					return state;
				}
				set	
				{
					state = value;
				}
			}

			public string CreateDate
			{
				get
				{
					return createDate;
				}
				set	
				{
					createDate = value;
				}
			}

			public string UpdateDate
			{
				get
				{
					return updateDate;
				}
				set	
				{
					updateDate = value;
				}
			}

			public string ProductId
			{
				get
				{
					return productId;
				}
				set	
				{
					productId = value;
				}
			}

			public string FundPartyId
			{
				get
				{
					return fundPartyId;
				}
				set	
				{
					fundPartyId = value;
				}
			}

			public string DownPaymentAmount
			{
				get
				{
					return downPaymentAmount;
				}
				set	
				{
					downPaymentAmount = value;
				}
			}

			public string DownPaymentRate
			{
				get
				{
					return downPaymentRate;
				}
				set	
				{
					downPaymentRate = value;
				}
			}
		}
	}
}
