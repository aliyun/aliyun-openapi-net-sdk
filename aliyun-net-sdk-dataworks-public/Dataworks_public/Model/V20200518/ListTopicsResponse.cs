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

namespace Aliyun.Acs.dataworks_public.Model.V20200518
{
	public class ListTopicsResponse : AcsResponse
	{

		private int? httpStatusCode;

		private string requestId;

		private string errorMessage;

		private string errorCode;

		private bool? success;

		private ListTopics_Data data;

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
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

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
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

		public ListTopics_Data Data
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

		public class ListTopics_Data
		{

			private int? pageNumber;

			private int? pageSize;

			private int? totalCount;

			private List<ListTopics_TopicsItem> topics;

			public int? PageNumber
			{
				get
				{
					return pageNumber;
				}
				set	
				{
					pageNumber = value;
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

			public List<ListTopics_TopicsItem> Topics
			{
				get
				{
					return topics;
				}
				set	
				{
					topics = value;
				}
			}

			public class ListTopics_TopicsItem
			{

				private string topicName;

				private long? projectId;

				private string nodeOwner;

				private long? instanceId;

				private long? fixTime;

				private string topicType;

				private string topicStatus;

				private long? happenTime;

				private string nodeName;

				private long? topicId;

				private long? addTime;

				private long? nodeId;

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

				public long? ProjectId
				{
					get
					{
						return projectId;
					}
					set	
					{
						projectId = value;
					}
				}

				public string NodeOwner
				{
					get
					{
						return nodeOwner;
					}
					set	
					{
						nodeOwner = value;
					}
				}

				public long? InstanceId
				{
					get
					{
						return instanceId;
					}
					set	
					{
						instanceId = value;
					}
				}

				public long? FixTime
				{
					get
					{
						return fixTime;
					}
					set	
					{
						fixTime = value;
					}
				}

				public string TopicType
				{
					get
					{
						return topicType;
					}
					set	
					{
						topicType = value;
					}
				}

				public string TopicStatus
				{
					get
					{
						return topicStatus;
					}
					set	
					{
						topicStatus = value;
					}
				}

				public long? HappenTime
				{
					get
					{
						return happenTime;
					}
					set	
					{
						happenTime = value;
					}
				}

				public string NodeName
				{
					get
					{
						return nodeName;
					}
					set	
					{
						nodeName = value;
					}
				}

				public long? TopicId
				{
					get
					{
						return topicId;
					}
					set	
					{
						topicId = value;
					}
				}

				public long? AddTime
				{
					get
					{
						return addTime;
					}
					set	
					{
						addTime = value;
					}
				}

				public long? NodeId
				{
					get
					{
						return nodeId;
					}
					set	
					{
						nodeId = value;
					}
				}
			}
		}
	}
}
