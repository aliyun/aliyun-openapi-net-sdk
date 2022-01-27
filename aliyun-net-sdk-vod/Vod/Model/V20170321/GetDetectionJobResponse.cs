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

namespace Aliyun.Acs.vod.Model.V20170321
{
	public class GetDetectionJobResponse : AcsResponse
	{

		private string requestId;

		private GetDetectionJob_DetectionJob detectionJob;

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

		public GetDetectionJob_DetectionJob DetectionJob
		{
			get
			{
				return detectionJob;
			}
			set	
			{
				detectionJob = value;
			}
		}

		public class GetDetectionJob_DetectionJob
		{

			private string jobId;

			private string createTime;

			private string modifyTime;

			private string beginTime;

			private string endTime;

			private string videoId;

			private string copyrightStatus;

			private string copyrightBeginTime;

			private string copyrightEndTime;

			private string copyrightFile;

			private string whitelistUrls;

			private string templateId;

			public string JobId
			{
				get
				{
					return jobId;
				}
				set	
				{
					jobId = value;
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

			public string BeginTime
			{
				get
				{
					return beginTime;
				}
				set	
				{
					beginTime = value;
				}
			}

			public string EndTime
			{
				get
				{
					return endTime;
				}
				set	
				{
					endTime = value;
				}
			}

			public string VideoId
			{
				get
				{
					return videoId;
				}
				set	
				{
					videoId = value;
				}
			}

			public string CopyrightStatus
			{
				get
				{
					return copyrightStatus;
				}
				set	
				{
					copyrightStatus = value;
				}
			}

			public string CopyrightBeginTime
			{
				get
				{
					return copyrightBeginTime;
				}
				set	
				{
					copyrightBeginTime = value;
				}
			}

			public string CopyrightEndTime
			{
				get
				{
					return copyrightEndTime;
				}
				set	
				{
					copyrightEndTime = value;
				}
			}

			public string CopyrightFile
			{
				get
				{
					return copyrightFile;
				}
				set	
				{
					copyrightFile = value;
				}
			}

			public string WhitelistUrls
			{
				get
				{
					return whitelistUrls;
				}
				set	
				{
					whitelistUrls = value;
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
		}
	}
}
