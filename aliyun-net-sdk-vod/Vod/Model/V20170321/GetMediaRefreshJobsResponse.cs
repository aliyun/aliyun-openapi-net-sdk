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

namespace Aliyun.Acs.vod.Model.V20170321
{
	public class GetMediaRefreshJobsResponse : AcsResponse
	{

		private string requestId;

		private List<GetMediaRefreshJobs_MediaRefreshJob> mediaRefreshJobs;

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

		public List<GetMediaRefreshJobs_MediaRefreshJob> MediaRefreshJobs
		{
			get
			{
				return mediaRefreshJobs;
			}
			set	
			{
				mediaRefreshJobs = value;
			}
		}

		public class GetMediaRefreshJobs_MediaRefreshJob
		{

			private string mediaRefreshJobId;

			private string mediaId;

			private string taskType;

			private string filterPolicy;

			private string status;

			private string successPlayUrls;

			private string taskIds;

			private string errorCode;

			private string errorMessage;

			private string userData;

			private string gmtCreate;

			private string gmtModified;

			public string MediaRefreshJobId
			{
				get
				{
					return mediaRefreshJobId;
				}
				set	
				{
					mediaRefreshJobId = value;
				}
			}

			public string MediaId
			{
				get
				{
					return mediaId;
				}
				set	
				{
					mediaId = value;
				}
			}

			public string TaskType
			{
				get
				{
					return taskType;
				}
				set	
				{
					taskType = value;
				}
			}

			public string FilterPolicy
			{
				get
				{
					return filterPolicy;
				}
				set	
				{
					filterPolicy = value;
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

			public string SuccessPlayUrls
			{
				get
				{
					return successPlayUrls;
				}
				set	
				{
					successPlayUrls = value;
				}
			}

			public string TaskIds
			{
				get
				{
					return taskIds;
				}
				set	
				{
					taskIds = value;
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

			public string UserData
			{
				get
				{
					return userData;
				}
				set	
				{
					userData = value;
				}
			}

			public string GmtCreate
			{
				get
				{
					return gmtCreate;
				}
				set	
				{
					gmtCreate = value;
				}
			}

			public string GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
				}
			}
		}
	}
}
