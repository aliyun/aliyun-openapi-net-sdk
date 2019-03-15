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
	public class GetCurrentTermRepayInfoResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private GetCurrentTermRepayInfo_Data data;

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

		public GetCurrentTermRepayInfo_Data Data
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

		public class GetCurrentTermRepayInfo_Data
		{

			private string creditId;

			private string balAmt;

			private string interAmt;

			private string fineAmt;

			private string interInter;

			private string fineInter;

			private string expiryDate;

			private string loanBalance;

			private string totalLoanAmount;

			private string repayPrincipalAmount;

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

			public string BalAmt
			{
				get
				{
					return balAmt;
				}
				set	
				{
					balAmt = value;
				}
			}

			public string InterAmt
			{
				get
				{
					return interAmt;
				}
				set	
				{
					interAmt = value;
				}
			}

			public string FineAmt
			{
				get
				{
					return fineAmt;
				}
				set	
				{
					fineAmt = value;
				}
			}

			public string InterInter
			{
				get
				{
					return interInter;
				}
				set	
				{
					interInter = value;
				}
			}

			public string FineInter
			{
				get
				{
					return fineInter;
				}
				set	
				{
					fineInter = value;
				}
			}

			public string ExpiryDate
			{
				get
				{
					return expiryDate;
				}
				set	
				{
					expiryDate = value;
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

			public string TotalLoanAmount
			{
				get
				{
					return totalLoanAmount;
				}
				set	
				{
					totalLoanAmount = value;
				}
			}

			public string RepayPrincipalAmount
			{
				get
				{
					return repayPrincipalAmount;
				}
				set	
				{
					repayPrincipalAmount = value;
				}
			}
		}
	}
}
