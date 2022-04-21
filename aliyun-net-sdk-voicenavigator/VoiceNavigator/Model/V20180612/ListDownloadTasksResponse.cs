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

namespace Aliyun.Acs.VoiceNavigator.Model.V20180612
{
	public class ListDownloadTasksResponse : AcsResponse
	{

		private int? httpStatusCode;

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private ListDownloadTasks_DownloadTasks downloadTasks;

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

		public ListDownloadTasks_DownloadTasks DownloadTasks
		{
			get
			{
				return downloadTasks;
			}
			set	
			{
				downloadTasks = value;
			}
		}

		public class ListDownloadTasks_DownloadTasks
		{

			private int? pageNumber;

			private int? pageSize;

			private int? totalCount;

			private List<ListDownloadTasks_DownloadTask> list;

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

			public List<ListDownloadTasks_DownloadTask> List
			{
				get
				{
					return list;
				}
				set	
				{
					list = value;
				}
			}

			public class ListDownloadTasks_DownloadTask
			{

				private string status;

				private string title;

				private long? expireTime;

				private string taskId;

				private List<ListDownloadTasks_DownloadTaskFile0> downloadTaskFiles;

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

				public long? ExpireTime
				{
					get
					{
						return expireTime;
					}
					set	
					{
						expireTime = value;
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

				public List<ListDownloadTasks_DownloadTaskFile0> DownloadTaskFiles
				{
					get
					{
						return downloadTaskFiles;
					}
					set	
					{
						downloadTaskFiles = value;
					}
				}

				public class ListDownloadTasks_DownloadTaskFile0
				{

					private string status;

					private string title;

					private int? progress;

					private string fileId;

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

					public int? Progress
					{
						get
						{
							return progress;
						}
						set	
						{
							progress = value;
						}
					}

					public string FileId
					{
						get
						{
							return fileId;
						}
						set	
						{
							fileId = value;
						}
					}
				}
			}
		}
	}
}
