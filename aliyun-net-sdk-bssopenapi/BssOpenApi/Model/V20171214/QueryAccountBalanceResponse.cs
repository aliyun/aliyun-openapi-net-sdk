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
	public class QueryAccountBalanceResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private QueryAccountBalance_Data data;

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
		public QueryAccountBalance_Data Data
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

		public class QueryAccountBalance_Data
		{

			private string availableAmount;

			private string creditAmount;

			private string mybankCreditAmount;

			private string currency;

			private string availableCashAmount;

			[JsonProperty(PropertyName = "AvailableAmount")]
			public string AvailableAmount
			{
				get
				{
					return availableAmount;
				}
				set	
				{
					availableAmount = value;
				}
			}

			[JsonProperty(PropertyName = "CreditAmount")]
			public string CreditAmount
			{
				get
				{
					return creditAmount;
				}
				set	
				{
					creditAmount = value;
				}
			}

			[JsonProperty(PropertyName = "MybankCreditAmount")]
			public string MybankCreditAmount
			{
				get
				{
					return mybankCreditAmount;
				}
				set	
				{
					mybankCreditAmount = value;
				}
			}

			[JsonProperty(PropertyName = "Currency")]
			public string Currency
			{
				get
				{
					return currency;
				}
				set	
				{
					currency = value;
				}
			}

			[JsonProperty(PropertyName = "AvailableCashAmount")]
			public string AvailableCashAmount
			{
				get
				{
					return availableCashAmount;
				}
				set	
				{
					availableCashAmount = value;
				}
			}
		}
	}
}
