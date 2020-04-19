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

namespace Aliyun.Acs.multimediaai.Model.V20190810
{
	public class GetTaskResultResponse : AcsResponse
	{

		private string requestId;

		private int? status;

		private GetTaskResult_Result result;

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

		public GetTaskResult_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class GetTaskResult_Result
		{

			private string applicationId;

			private string videoName;

			private string processResultUrl;

			private long? analysisUseTime;

			private string videoUrl;

			private string errorName;

			private string errorReason;

			private string errorCode;

			private string errorMessage;

			public string ApplicationId
			{
				get
				{
					return applicationId;
				}
				set	
				{
					applicationId = value;
				}
			}

			public string VideoName
			{
				get
				{
					return videoName;
				}
				set	
				{
					videoName = value;
				}
			}

			public string ProcessResultUrl
			{
				get
				{
					return processResultUrl;
				}
				set	
				{
					processResultUrl = value;
				}
			}

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

			public string ErrorName
			{
				get
				{
					return errorName;
				}
				set	
				{
					errorName = value;
				}
			}

			public string ErrorReason
			{
				get
				{
					return errorReason;
				}
				set	
				{
					errorReason = value;
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
		}
	}
}
