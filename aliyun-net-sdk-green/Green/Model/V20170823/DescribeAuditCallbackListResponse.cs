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

namespace Aliyun.Acs.Green.Model.V20170823
{
	public class DescribeAuditCallbackListResponse : AcsResponse
	{

		private int? totalCount;

		private string requestId;

		private List<DescribeAuditCallbackList_Callback> callbackList;

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
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

		public List<DescribeAuditCallbackList_Callback> CallbackList
		{
			get
			{
				return callbackList;
			}
			set	
			{
				callbackList = value;
			}
		}

		public class DescribeAuditCallbackList_Callback
		{

			private string modifiedTime;

			private string seed;

			private string createTime;

			private string url;

			private string name;

			private string cryptType;

			private long? id;

			private List<string> callbackTypes;

			private List<string> callbackSuggestions;

			public string ModifiedTime
			{
				get
				{
					return modifiedTime;
				}
				set	
				{
					modifiedTime = value;
				}
			}

			public string Seed
			{
				get
				{
					return seed;
				}
				set	
				{
					seed = value;
				}
			}

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public string Url
			{
				get
				{
					return url;
				}
				set	
				{
					url = value;
				}
			}

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string CryptType
			{
				get
				{
					return cryptType;
				}
				set	
				{
					cryptType = value;
				}
			}

			public long? Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public List<string> CallbackTypes
			{
				get
				{
					return callbackTypes;
				}
				set	
				{
					callbackTypes = value;
				}
			}

			public List<string> CallbackSuggestions
			{
				get
				{
					return callbackSuggestions;
				}
				set	
				{
					callbackSuggestions = value;
				}
			}
		}
	}
}
