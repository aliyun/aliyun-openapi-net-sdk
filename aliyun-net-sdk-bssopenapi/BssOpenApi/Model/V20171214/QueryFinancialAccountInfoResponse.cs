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
	public class QueryFinancialAccountInfoResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private QueryFinancialAccountInfo_Data data;

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
		public QueryFinancialAccountInfo_Data Data
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

		public class QueryFinancialAccountInfo_Data
		{

			private string memberNickName;

			private bool? isFinancialAccount;

			private string memberGroupName;

			private string userName;

			private string accountType;

			private long? memberGroupId;

			[JsonProperty(PropertyName = "MemberNickName")]
			public string MemberNickName
			{
				get
				{
					return memberNickName;
				}
				set	
				{
					memberNickName = value;
				}
			}

			[JsonProperty(PropertyName = "IsFinancialAccount")]
			public bool? IsFinancialAccount
			{
				get
				{
					return isFinancialAccount;
				}
				set	
				{
					isFinancialAccount = value;
				}
			}

			[JsonProperty(PropertyName = "MemberGroupName")]
			public string MemberGroupName
			{
				get
				{
					return memberGroupName;
				}
				set	
				{
					memberGroupName = value;
				}
			}

			[JsonProperty(PropertyName = "UserName")]
			public string UserName
			{
				get
				{
					return userName;
				}
				set	
				{
					userName = value;
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

			[JsonProperty(PropertyName = "MemberGroupId")]
			public long? MemberGroupId
			{
				get
				{
					return memberGroupId;
				}
				set	
				{
					memberGroupId = value;
				}
			}
		}
	}
}
