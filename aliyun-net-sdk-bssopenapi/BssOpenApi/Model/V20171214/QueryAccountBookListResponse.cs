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
	public class QueryAccountBookListResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private bool? success;

		private int? count;

		private List<QueryAccountBookList_Data> datas;

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

		public int? Count
		{
			get
			{
				return count;
			}
			set	
			{
				count = value;
			}
		}

		public List<QueryAccountBookList_Data> Datas
		{
			get
			{
				return datas;
			}
			set	
			{
				datas = value;
			}
		}

		public class QueryAccountBookList_Data
		{

			private long? userId;

			private string bid;

			private string itemCode;

			private string amount;

			private long? effectTimeStamp;

			private long? invalidTimeStamp;

			private string currency;

			public long? UserId
			{
				get
				{
					return userId;
				}
				set	
				{
					userId = value;
				}
			}

			public string Bid
			{
				get
				{
					return bid;
				}
				set	
				{
					bid = value;
				}
			}

			public string ItemCode
			{
				get
				{
					return itemCode;
				}
				set	
				{
					itemCode = value;
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

			public long? EffectTimeStamp
			{
				get
				{
					return effectTimeStamp;
				}
				set	
				{
					effectTimeStamp = value;
				}
			}

			public long? InvalidTimeStamp
			{
				get
				{
					return invalidTimeStamp;
				}
				set	
				{
					invalidTimeStamp = value;
				}
			}

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
		}
	}
}
