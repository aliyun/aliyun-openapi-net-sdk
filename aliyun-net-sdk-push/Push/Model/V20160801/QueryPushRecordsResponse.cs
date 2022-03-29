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

namespace Aliyun.Acs.Push.Model.V20160801
{
	public class QueryPushRecordsResponse : AcsResponse
	{

		private string nextToken;

		private int? pageSize;

		private string requestId;

		private int? total;

		private int? page;

		private List<QueryPushRecords_PushInfo> pushInfos;

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
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

		public int? Total
		{
			get
			{
				return total;
			}
			set	
			{
				total = value;
			}
		}

		public int? Page
		{
			get
			{
				return page;
			}
			set	
			{
				page = value;
			}
		}

		public List<QueryPushRecords_PushInfo> PushInfos
		{
			get
			{
				return pushInfos;
			}
			set	
			{
				pushInfos = value;
			}
		}

		public class QueryPushRecords_PushInfo
		{

			private string status;

			private string messageId;

			private long? appKey;

			private string deviceType;

			private string pushType;

			private string body;

			private string title;

			private string source;

			private string pushTime;

			private string target;

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public string MessageId
			{
				get
				{
					return messageId;
				}
				set	
				{
					messageId = value;
				}
			}

			public long? AppKey
			{
				get
				{
					return appKey;
				}
				set	
				{
					appKey = value;
				}
			}

			public string DeviceType
			{
				get
				{
					return deviceType;
				}
				set	
				{
					deviceType = value;
				}
			}

			public string PushType
			{
				get
				{
					return pushType;
				}
				set	
				{
					pushType = value;
				}
			}

			public string Body
			{
				get
				{
					return body;
				}
				set	
				{
					body = value;
				}
			}

			public string Title
			{
				get
				{
					return title;
				}
				set	
				{
					title = value;
				}
			}

			public string Source
			{
				get
				{
					return source;
				}
				set	
				{
					source = value;
				}
			}

			public string PushTime
			{
				get
				{
					return pushTime;
				}
				set	
				{
					pushTime = value;
				}
			}

			public string Target
			{
				get
				{
					return target;
				}
				set	
				{
					target = value;
				}
			}
		}
	}
}
