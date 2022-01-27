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

namespace Aliyun.Acs.dms_enterprise.Model.V20181101
{
	public class GetSparkJobDetailResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string errorMessage;

		private string errorCode;

		private GetSparkJobDetail_JobDetail jobDetail;

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

		[JsonProperty(PropertyName = "Success")]
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

		[JsonProperty(PropertyName = "ErrorMessage")]
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

		[JsonProperty(PropertyName = "ErrorCode")]
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

		[JsonProperty(PropertyName = "JobDetail")]
		public GetSparkJobDetail_JobDetail JobDetail
		{
			get
			{
				return jobDetail;
			}
			set	
			{
				jobDetail = value;
			}
		}

		public class GetSparkJobDetail_JobDetail
		{

			private string jobId;

			private string name;

			private string status;

			private string mainClass;

			private string mainFile;

			private string arguments;

			private string configuration;

			private string submitTime;

			private string beginTime;

			private string endTime;

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

			[JsonProperty(PropertyName = "MainClass")]
			public string MainClass
			{
				get
				{
					return mainClass;
				}
				set	
				{
					mainClass = value;
				}
			}

			[JsonProperty(PropertyName = "MainFile")]
			public string MainFile
			{
				get
				{
					return mainFile;
				}
				set	
				{
					mainFile = value;
				}
			}

			[JsonProperty(PropertyName = "Arguments")]
			public string Arguments
			{
				get
				{
					return arguments;
				}
				set	
				{
					arguments = value;
				}
			}

			[JsonProperty(PropertyName = "Configuration")]
			public string Configuration
			{
				get
				{
					return configuration;
				}
				set	
				{
					configuration = value;
				}
			}

			[JsonProperty(PropertyName = "SubmitTime")]
			public string SubmitTime
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

			[JsonProperty(PropertyName = "BeginTime")]
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

			[JsonProperty(PropertyName = "EndTime")]
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
		}
	}
}
