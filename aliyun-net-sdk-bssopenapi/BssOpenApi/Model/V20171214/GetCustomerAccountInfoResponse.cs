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
	public class GetCustomerAccountInfoResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private GetCustomerAccountInfo_Data data;

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

			private long? mpk;

			private string loginEmail;

			private string hostingStatus;

			private string accountType;

			private string creditLimitStatus;

			private bool? isCertified;

			[JsonProperty(PropertyName = "Mpk")]
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

			[JsonProperty(PropertyName = "LoginEmail")]
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

			[JsonProperty(PropertyName = "HostingStatus")]
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

			[JsonProperty(PropertyName = "AccountType")]
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

			[JsonProperty(PropertyName = "CreditLimitStatus")]
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

			[JsonProperty(PropertyName = "IsCertified")]
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
