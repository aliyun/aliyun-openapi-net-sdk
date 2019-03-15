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
	public class GetProductDetailResponse : AcsResponse
	{

		private string requestId;

		private string message;

		private string code;

		private GetProductDetail_Data data;

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

		public GetProductDetail_Data Data
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

		public class GetProductDetail_Data
		{

			private string productId;

			private string productName;

			private string lendingOrganizations;

			private string terms;

			private string dailyRate;

			private string yearRate;

			private string foundPartyName;

			private string foundPartyId;

			private string interestRate;

			private string principalLimit;

			private string financialInfo;

			private string fineAmount;

			private string comment;

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

			public string LendingOrganizations
			{
				get
				{
					return lendingOrganizations;
				}
				set	
				{
					lendingOrganizations = value;
				}
			}

			public string Terms
			{
				get
				{
					return terms;
				}
				set	
				{
					terms = value;
				}
			}

			public string DailyRate
			{
				get
				{
					return dailyRate;
				}
				set	
				{
					dailyRate = value;
				}
			}

			public string YearRate
			{
				get
				{
					return yearRate;
				}
				set	
				{
					yearRate = value;
				}
			}

			public string FoundPartyName
			{
				get
				{
					return foundPartyName;
				}
				set	
				{
					foundPartyName = value;
				}
			}

			public string FoundPartyId
			{
				get
				{
					return foundPartyId;
				}
				set	
				{
					foundPartyId = value;
				}
			}

			public string InterestRate
			{
				get
				{
					return interestRate;
				}
				set	
				{
					interestRate = value;
				}
			}

			public string PrincipalLimit
			{
				get
				{
					return principalLimit;
				}
				set	
				{
					principalLimit = value;
				}
			}

			public string FinancialInfo
			{
				get
				{
					return financialInfo;
				}
				set	
				{
					financialInfo = value;
				}
			}

			public string FineAmount
			{
				get
				{
					return fineAmount;
				}
				set	
				{
					fineAmount = value;
				}
			}

			public string Comment
			{
				get
				{
					return comment;
				}
				set	
				{
					comment = value;
				}
			}
		}
	}
}
