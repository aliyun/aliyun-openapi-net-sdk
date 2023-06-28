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

namespace Aliyun.Acs.Mns_open.Model.V20220119
{
	public class ListSubscriptionByTopicResponse : AcsResponse
	{

		private string requestId;

		private long? code;

		private string status;

		private string message;

		private bool? success;

		private ListSubscriptionByTopic_Data data;

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

		public long? Code
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

		public ListSubscriptionByTopic_Data Data
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

		public class ListSubscriptionByTopic_Data
		{

			private long? pageNum;

			private long? pageSize;

			private long? size;

			private long? pages;

			private long? total;

			private List<ListSubscriptionByTopic_PageDataItem> pageData;

			public long? PageNum
			{
				get
				{
					return pageNum;
				}
				set	
				{
					pageNum = value;
				}
			}

			public long? PageSize
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

			public long? Size
			{
				get
				{
					return size;
				}
				set	
				{
					size = value;
				}
			}

			public long? Pages
			{
				get
				{
					return pages;
				}
				set	
				{
					pages = value;
				}
			}

			public long? Total
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

			public List<ListSubscriptionByTopic_PageDataItem> PageData
			{
				get
				{
					return pageData;
				}
				set	
				{
					pageData = value;
				}
			}

			public class ListSubscriptionByTopic_PageDataItem
			{

				private string subscriptionName;

				private string topicOwner;

				private string topicName;

				private string endpoint;

				private string filterTag;

				private long? createTime;

				private long? lastModifyTime;

				private string notifyStrategy;

				private string notifyContentFormat;

				public string SubscriptionName
				{
					get
					{
						return subscriptionName;
					}
					set	
					{
						subscriptionName = value;
					}
				}

				public string TopicOwner
				{
					get
					{
						return topicOwner;
					}
					set	
					{
						topicOwner = value;
					}
				}

				public string TopicName
				{
					get
					{
						return topicName;
					}
					set	
					{
						topicName = value;
					}
				}

				public string Endpoint
				{
					get
					{
						return endpoint;
					}
					set	
					{
						endpoint = value;
					}
				}

				public string FilterTag
				{
					get
					{
						return filterTag;
					}
					set	
					{
						filterTag = value;
					}
				}

				public long? CreateTime
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

				public long? LastModifyTime
				{
					get
					{
						return lastModifyTime;
					}
					set	
					{
						lastModifyTime = value;
					}
				}

				public string NotifyStrategy
				{
					get
					{
						return notifyStrategy;
					}
					set	
					{
						notifyStrategy = value;
					}
				}

				public string NotifyContentFormat
				{
					get
					{
						return notifyContentFormat;
					}
					set	
					{
						notifyContentFormat = value;
					}
				}
			}
		}
	}
}
