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

namespace Aliyun.Acs.live.Model.V20161101
{
	public class ListEdgeTranscodeJobResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private List<ListEdgeTranscodeJob_Job> jobList;

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

		[JsonProperty(PropertyName = "TotalCount")]
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

		[JsonProperty(PropertyName = "JobList")]
		public List<ListEdgeTranscodeJob_Job> JobList
		{
			get
			{
				return jobList;
			}
			set	
			{
				jobList = value;
			}
		}

		public class ListEdgeTranscodeJob_Job
		{

			private string createTime;

			private string jobId;

			private string lastStartAt;

			private string lastStopAt;

			private string name;

			private string status;

			private string streamInput;

			private string streamOutput;

			private string templateId;

			private string templateName;

			private string type;

			[JsonProperty(PropertyName = "CreateTime")]
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

			[JsonProperty(PropertyName = "LastStartAt")]
			public string LastStartAt
			{
				get
				{
					return lastStartAt;
				}
				set	
				{
					lastStartAt = value;
				}
			}

			[JsonProperty(PropertyName = "LastStopAt")]
			public string LastStopAt
			{
				get
				{
					return lastStopAt;
				}
				set	
				{
					lastStopAt = value;
				}
			}

			[JsonProperty(PropertyName = "Name")]
			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			[JsonProperty(PropertyName = "Status")]
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

			[JsonProperty(PropertyName = "StreamInput")]
			public string StreamInput
			{
				get
				{
					return streamInput;
				}
				set	
				{
					streamInput = value;
				}
			}

			[JsonProperty(PropertyName = "StreamOutput")]
			public string StreamOutput
			{
				get
				{
					return streamOutput;
				}
				set	
				{
					streamOutput = value;
				}
			}

			[JsonProperty(PropertyName = "TemplateId")]
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

			[JsonProperty(PropertyName = "TemplateName")]
			public string TemplateName
			{
				get
				{
					return templateName;
				}
				set	
				{
					templateName = value;
				}
			}

			[JsonProperty(PropertyName = "Type")]
			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}
		}
	}
}
