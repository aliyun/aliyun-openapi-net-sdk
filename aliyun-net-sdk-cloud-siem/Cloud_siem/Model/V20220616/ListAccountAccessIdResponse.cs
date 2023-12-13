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

namespace Aliyun.Acs.cloud_siem.Model.V20220616
{
	public class ListAccountAccessIdResponse : AcsResponse
	{

		private bool? success;

		private int? code;

		private string message;

		private string requestId;

		private List<ListAccountAccessId_DataItem> data;

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

		public int? Code
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

		public List<ListAccountAccessId_DataItem> Data
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

		public class ListAccountAccessId_DataItem
		{

			private long? subUserId;

			private string accessIdMd5;

			private string accountStr;

			private int? bound;

			private string accessId;

			private string accountId;

			private string cloudCode;

			public long? SubUserId
			{
				get
				{
					return subUserId;
				}
				set	
				{
					subUserId = value;
				}
			}

			public string AccessIdMd5
			{
				get
				{
					return accessIdMd5;
				}
				set	
				{
					accessIdMd5 = value;
				}
			}

			public string AccountStr
			{
				get
				{
					return accountStr;
				}
				set	
				{
					accountStr = value;
				}
			}

			public int? Bound
			{
				get
				{
					return bound;
				}
				set	
				{
					bound = value;
				}
			}

			public string AccessId
			{
				get
				{
					return accessId;
				}
				set	
				{
					accessId = value;
				}
			}

			public string AccountId
			{
				get
				{
					return accountId;
				}
				set	
				{
					accountId = value;
				}
			}

			public string CloudCode
			{
				get
				{
					return cloudCode;
				}
				set	
				{
					cloudCode = value;
				}
			}
		}
	}
}
