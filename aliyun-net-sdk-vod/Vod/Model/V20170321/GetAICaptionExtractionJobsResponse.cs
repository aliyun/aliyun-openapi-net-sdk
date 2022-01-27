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
	public class GetAICaptionExtractionJobsResponse : AcsResponse
	{

		private string requestId;

		private List<GetAICaptionExtractionJobs_AICaptionExtractionJob> aICaptionExtractionJobList;

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

		public List<GetAICaptionExtractionJobs_AICaptionExtractionJob> AICaptionExtractionJobList
		{
			get
			{
				return aICaptionExtractionJobList;
			}
			set	
			{
				aICaptionExtractionJobList = value;
			}
		}

		public class GetAICaptionExtractionJobs_AICaptionExtractionJob
		{

			private string creationTime;

			private string jobId;

			private string videoId;

			private string aICaptionExtractionResult;

			private string userData;

			private string code;

			private string message;

			private string status;

			private string templateConfig;

			public string CreationTime
			{
				get
				{
					return creationTime;
				}
				set	
				{
					creationTime = value;
				}
			}

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

			public string AICaptionExtractionResult
			{
				get
				{
					return aICaptionExtractionResult;
				}
				set	
				{
					aICaptionExtractionResult = value;
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
		}
	}
}
