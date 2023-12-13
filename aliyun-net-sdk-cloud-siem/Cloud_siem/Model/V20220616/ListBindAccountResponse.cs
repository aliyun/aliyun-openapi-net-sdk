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
	public class ListBindAccountResponse : AcsResponse
	{

		private string requestId;

		private List<ListBindAccount_DataItem> data;

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

		public List<ListBindAccount_DataItem> Data
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

		public class ListBindAccount_DataItem
		{

			private string accountName;

			private string accessId;

			private long? dataSourceCount;

			private string modifyTime;

			private string createUser;

			private long? bindId;

			private string accountId;

			private string cloudCode;

			public string AccountName
			{
				get
				{
					return accountName;
				}
				set	
				{
					accountName = value;
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

			public long? DataSourceCount
			{
				get
				{
					return dataSourceCount;
				}
				set	
				{
					dataSourceCount = value;
				}
			}

			public string ModifyTime
			{
				get
				{
					return modifyTime;
				}
				set	
				{
					modifyTime = value;
				}
			}

			public string CreateUser
			{
				get
				{
					return createUser;
				}
				set	
				{
					createUser = value;
				}
			}

			public long? BindId
			{
				get
				{
					return bindId;
				}
				set	
				{
					bindId = value;
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
