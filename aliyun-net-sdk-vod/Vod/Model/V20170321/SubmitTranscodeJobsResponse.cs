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
	public class SubmitTranscodeJobsResponse : AcsResponse
	{

		private string transcodeTaskId;

		private string requestId;

		private List<SubmitTranscodeJobs_TranscodeJob> transcodeJobs;

		[JsonProperty(PropertyName = "TranscodeTaskId")]
		public string TranscodeTaskId
		{
			get
			{
				return transcodeTaskId;
			}
			set	
			{
				transcodeTaskId = value;
			}
		}

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "TranscodeJobs")]
		public List<SubmitTranscodeJobs_TranscodeJob> TranscodeJobs
		{
			get
			{
				return transcodeJobs;
			}
			set	
			{
				transcodeJobs = value;
			}
		}

		public class SubmitTranscodeJobs_TranscodeJob
		{

			private string jobId;

			[JsonProperty(PropertyName = "JobId")]
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
		}
	}
}
