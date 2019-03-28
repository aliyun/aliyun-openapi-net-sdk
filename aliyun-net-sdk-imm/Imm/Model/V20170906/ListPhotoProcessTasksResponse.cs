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

namespace Aliyun.Acs.imm.Model.V20170906
{
	public class ListPhotoProcessTasksResponse : AcsResponse
	{

		private string requestId;

		private string nextMarker;

		private List<ListPhotoProcessTasks_TasksItem> tasks;

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

		public string NextMarker
		{
			get
			{
				return nextMarker;
			}
			set	
			{
				nextMarker = value;
			}
		}

		public List<ListPhotoProcessTasks_TasksItem> Tasks
		{
			get
			{
				return tasks;
			}
			set	
			{
				tasks = value;
			}
		}

		public class ListPhotoProcessTasks_TasksItem
		{

			private string taskId;

			private string status;

			private string srcUri;

			private string tgtUri;

			private string style;

			private string notifyTopicName;

			private string notifyEndpoint;

			private string externalID;

			private string createTime;

			private string finishTime;

			private int? percent;

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

			public string SrcUri
			{
				get
				{
					return srcUri;
				}
				set	
				{
					srcUri = value;
				}
			}

			public string TgtUri
			{
				get
				{
					return tgtUri;
				}
				set	
				{
					tgtUri = value;
				}
			}

			public string Style
			{
				get
				{
					return style;
				}
				set	
				{
					style = value;
				}
			}

			public string NotifyTopicName
			{
				get
				{
					return notifyTopicName;
				}
				set	
				{
					notifyTopicName = value;
				}
			}

			public string NotifyEndpoint
			{
				get
				{
					return notifyEndpoint;
				}
				set	
				{
					notifyEndpoint = value;
				}
			}

			public string ExternalID
			{
				get
				{
					return externalID;
				}
				set	
				{
					externalID = value;
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

			public string FinishTime
			{
				get
				{
					return finishTime;
				}
				set	
				{
					finishTime = value;
				}
			}

			public int? Percent
			{
				get
				{
					return percent;
				}
				set	
				{
					percent = value;
				}
			}
		}
	}
}
