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

namespace Aliyun.Acs.rtc.Model.V20180111
{
	public class DescribeRecordTasksResponse : AcsResponse
	{

		private string requestId;

		private long? totalNum;

		private long? totalPage;

		private List<DescribeRecordTasks_RecordTask> recordTasks;

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

		public long? TotalNum
		{
			get
			{
				return totalNum;
			}
			set	
			{
				totalNum = value;
			}
		}

		public long? TotalPage
		{
			get
			{
				return totalPage;
			}
			set	
			{
				totalPage = value;
			}
		}

		public List<DescribeRecordTasks_RecordTask> RecordTasks
		{
			get
			{
				return recordTasks;
			}
			set	
			{
				recordTasks = value;
			}
		}

		public class DescribeRecordTasks_RecordTask
		{

			private string createTime;

			private string appId;

			private string channelId;

			private string taskId;

			private string templateId;

			private int? status;

			private List<DescribeRecordTasks_UserPanesItem> userPanes;

			private List<string> subSpecUsers;

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

			public string AppId
			{
				get
				{
					return appId;
				}
				set	
				{
					appId = value;
				}
			}

			public string ChannelId
			{
				get
				{
					return channelId;
				}
				set	
				{
					channelId = value;
				}
			}

			public string TaskId
			{
				get
				{
					return taskId;
				}
				set	
				{
					taskId = value;
				}
			}

			public string TemplateId
			{
				get
				{
					return templateId;
				}
				set	
				{
					templateId = value;
				}
			}

			public int? Status
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

			public List<DescribeRecordTasks_UserPanesItem> UserPanes
			{
				get
				{
					return userPanes;
				}
				set	
				{
					userPanes = value;
				}
			}

			public List<string> SubSpecUsers
			{
				get
				{
					return subSpecUsers;
				}
				set	
				{
					subSpecUsers = value;
				}
			}

			public class DescribeRecordTasks_UserPanesItem
			{

				private int? paneId;

				private string userId;

				private string source;

				public int? PaneId
				{
					get
					{
						return paneId;
					}
					set	
					{
						paneId = value;
					}
				}

				public string UserId
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
			}
		}
	}
}
