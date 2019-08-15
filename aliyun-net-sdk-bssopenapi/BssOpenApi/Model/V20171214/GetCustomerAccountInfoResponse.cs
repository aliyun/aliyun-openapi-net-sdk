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
	public class GetCustomerAccountInfoResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private GetCustomerAccountInfo_Data data;

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

		public GetCustomerAccountInfo_Data Data
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

		public class GetCustomerAccountInfo_Data
		{

			private string loginEmail;

			private string accountType;

			private long? mpk;

			private string hostingStatus;

			private string creditLimitStatus;

			private bool? isCertified;

			public string LoginEmail
			{
				get
				{
					return loginEmail;
				}
				set	
				{
					loginEmail = value;
				}
			}

			public string AccountType
			{
				get
				{
					return accountType;
				}
				set	
				{
					accountType = value;
				}
			}

			public long? Mpk
			{
				get
				{
					return mpk;
				}
				set	
				{
					mpk = value;
				}
			}

			public string HostingStatus
			{
				get
				{
					return hostingStatus;
				}
				set	
				{
					hostingStatus = value;
				}
			}

			public string CreditLimitStatus
			{
				get
				{
					return creditLimitStatus;
				}
				set	
				{
					creditLimitStatus = value;
				}
			}

			public bool? IsCertified
			{
				get
				{
					return isCertified;
				}
				set	
				{
					isCertified = value;
				}
			}
		}
	}
}
