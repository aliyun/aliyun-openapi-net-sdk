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

namespace Aliyun.Acs.videosearch.Model.V20200225
{
	public class GetTaskStatusResponse : AcsResponse
	{

		private string requestId;

		private int? data;

		private GetTaskStatus_TaskInfo taskInfo;

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

		public int? Data
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

		public GetTaskStatus_TaskInfo TaskInfo
		{
			get
			{
				return taskInfo;
			}
			set	
			{
				taskInfo = value;
			}
		}

		public class GetTaskStatus_TaskInfo
		{

			private long? analysisUseTime;

			private float? duration;

			private string processResultOss;

			private string resolution;

			private int? status;

			private long? submitTime;

			private long? finishTime;

			private long? taskId;

			private string errorInfo;

			private int? storageInfo;

			private string description;

			private string videoId;

			private string videoTags;

			private string videoUrl;

			private string queryTags;

			public long? AnalysisUseTime
			{
				get
				{
					return analysisUseTime;
				}
				set	
				{
					analysisUseTime = value;
				}
			}

			public float? Duration
			{
				get
				{
					return duration;
				}
				set	
				{
					duration = value;
				}
			}

			public string ProcessResultOss
			{
				get
				{
					return processResultOss;
				}
				set	
				{
					processResultOss = value;
				}
			}

			public string Resolution
			{
				get
				{
					return resolution;
				}
				set	
				{
					resolution = value;
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

			public long? SubmitTime
			{
				get
				{
					return submitTime;
				}
				set	
				{
					submitTime = value;
				}
			}

			public long? FinishTime
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

			public long? TaskId
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

			public string ErrorInfo
			{
				get
				{
					return errorInfo;
				}
				set	
				{
					errorInfo = value;
				}
			}

			public int? StorageInfo
			{
				get
				{
					return storageInfo;
				}
				set	
				{
					storageInfo = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
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

			public string VideoTags
			{
				get
				{
					return videoTags;
				}
				set	
				{
					videoTags = value;
				}
			}

			public string VideoUrl
			{
				get
				{
					return videoUrl;
				}
				set	
				{
					videoUrl = value;
				}
			}

			public string QueryTags
			{
				get
				{
					return queryTags;
				}
				set	
				{
					queryTags = value;
				}
			}
		}
	}
}
