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
	public class GetCustomerVerifyInfoResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private GetCustomerVerifyInfo_Data data;

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

		public GetCustomerVerifyInfo_Data Data
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

		public class GetCustomerVerifyInfo_Data
		{

			private string legalPersonName;

			private string idCardNumber;

			private string enterpriseName;

			private string businessLicense;

			private string address;

			private string phoneNumber;

			private string bankCard;

			private string loanSubject;

			private string idCardFrontPage;

			private string idCardBackPage;

			private string validateTime;

			private string validateState;

			private string email;

			public string LegalPersonName
			{
				get
				{
					return legalPersonName;
				}
				set	
				{
					legalPersonName = value;
				}
			}

			public string IdCardNumber
			{
				get
				{
					return idCardNumber;
				}
				set	
				{
					idCardNumber = value;
				}
			}

			public string EnterpriseName
			{
				get
				{
					return enterpriseName;
				}
				set	
				{
					enterpriseName = value;
				}
			}

			public string BusinessLicense
			{
				get
				{
					return businessLicense;
				}
				set	
				{
					businessLicense = value;
				}
			}

			public string Address
			{
				get
				{
					return address;
				}
				set	
				{
					address = value;
				}
			}

			public string PhoneNumber
			{
				get
				{
					return phoneNumber;
				}
				set	
				{
					phoneNumber = value;
				}
			}

			public string BankCard
			{
				get
				{
					return bankCard;
				}
				set	
				{
					bankCard = value;
				}
			}

			public string LoanSubject
			{
				get
				{
					return loanSubject;
				}
				set	
				{
					loanSubject = value;
				}
			}

			public string IdCardFrontPage
			{
				get
				{
					return idCardFrontPage;
				}
				set	
				{
					idCardFrontPage = value;
				}
			}

			public string IdCardBackPage
			{
				get
				{
					return idCardBackPage;
				}
				set	
				{
					idCardBackPage = value;
				}
			}

			public string ValidateTime
			{
				get
				{
					return validateTime;
				}
				set	
				{
					validateTime = value;
				}
			}

			public string ValidateState
			{
				get
				{
					return validateState;
				}
				set	
				{
					validateState = value;
				}
			}

			public string Email
			{
				get
				{
					return email;
				}
				set	
				{
					email = value;
				}
			}
		}
	}
}
