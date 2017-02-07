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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Push.Model.V20160801
{
	public class ListPushRecordsResponse : AcsResponse
	{

		private int? total;

		private int? page;

		private int? pageSize;

		private List<PushMessageInfo> pushMessageInfos;

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

		public List<PushMessageInfo> PushMessageInfos
		{
			get
			{
				return pushMessageInfos;
			}
			set	
			{
				pushMessageInfos = value;
			}
		}

		public class PushMessageInfo{

			private long? appKey;

			private string appName;

			private string messageId;

			private string type;

			private string deviceType;

			private string pushTime;

			private string title;

			private string body;

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

			public string AppName
			{
				get
				{
					return appName;
				}
				set	
				{
					appName = value;
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

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
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
		}
	}
}