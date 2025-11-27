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
	public class GetJobDetailResponse : AcsResponse
	{

		private string requestId;

		private string jobType;

		private GetJobDetail_TranscodeJobDetail transcodeJobDetail;

		private GetJobDetail_SnapshotJobDetail snapshotJobDetail;

		private GetJobDetail_AIJobDetail aIJobDetail;

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

		public string JobType
		{
			get
			{
				return jobType;
			}
			set	
			{
				jobType = value;
			}
		}

		public GetJobDetail_TranscodeJobDetail TranscodeJobDetail
		{
			get
			{
				return transcodeJobDetail;
			}
			set	
			{
				transcodeJobDetail = value;
			}
		}

		public GetJobDetail_SnapshotJobDetail SnapshotJobDetail
		{
			get
			{
				return snapshotJobDetail;
			}
			set	
			{
				snapshotJobDetail = value;
			}
		}

		public GetJobDetail_AIJobDetail AIJobDetail
		{
			get
			{
				return aIJobDetail;
			}
			set	
			{
				aIJobDetail = value;
			}
		}

		public class GetJobDetail_TranscodeJobDetail
		{

			private string jobId;

			private long? userId;

			private string videoId;

			private string status;

			private string templateId;

			private string definition;

			private string createTime;

			private string completeTime;

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

			public long? UserId
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

			public string Definition
			{
				get
				{
					return definition;
				}
				set	
				{
					definition = value;
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

			public string CompleteTime
			{
				get
				{
					return completeTime;
				}
				set	
				{
					completeTime = value;
				}
			}
		}

		public class GetJobDetail_SnapshotJobDetail
		{

			private string jobId;

			private long? userId;

			private string videoId;

			private string status;

			private string trigger;

			private string normalConfig;

			private string spriteConfig;

			private string createTime;

			private string completeTime;

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

			public long? UserId
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

			public string Trigger
			{
				get
				{
					return trigger;
				}
				set	
				{
					trigger = value;
				}
			}

			public string NormalConfig
			{
				get
				{
					return normalConfig;
				}
				set	
				{
					normalConfig = value;
				}
			}

			public string SpriteConfig
			{
				get
				{
					return spriteConfig;
				}
				set	
				{
					spriteConfig = value;
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

			public string CompleteTime
			{
				get
				{
					return completeTime;
				}
				set	
				{
					completeTime = value;
				}
			}
		}

		public class GetJobDetail_AIJobDetail
		{

			private string jobId;

			private long? userId;

			private string mediaId;

			private string jobType;

			private string status;

			private string trigger;

			private string templateConfig;

			private string createTime;

			private string completeTime;

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

			public long? UserId
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

			public string JobType
			{
				get
				{
					return jobType;
				}
				set	
				{
					jobType = value;
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

			public string Trigger
			{
				get
				{
					return trigger;
				}
				set	
				{
					trigger = value;
				}
			}

			public string TemplateConfig
			{
				get
				{
					return templateConfig;
				}
				set	
				{
					templateConfig = value;
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

			public string CompleteTime
			{
				get
				{
					return completeTime;
				}
				set	
				{
					completeTime = value;
				}
			}
		}
	}
}
