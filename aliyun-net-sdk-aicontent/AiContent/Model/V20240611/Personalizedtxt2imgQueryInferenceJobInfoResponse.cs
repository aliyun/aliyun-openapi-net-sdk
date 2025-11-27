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

namespace Aliyun.Acs.AiContent.Model.V20240611
{
	public class Personalizedtxt2imgQueryInferenceJobInfoResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string errCode;

		private string errMessage;

		private int? httpStatusCode;

		private Personalizedtxt2imgQueryInferenceJobInfo_Data data;

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

		public string ErrCode
		{
			get
			{
				return errCode;
			}
			set	
			{
				errCode = value;
			}
		}

		public string ErrMessage
		{
			get
			{
				return errMessage;
			}
			set	
			{
				errMessage = value;
			}
		}

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

		public Personalizedtxt2imgQueryInferenceJobInfo_Data Data
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

		public class Personalizedtxt2imgQueryInferenceJobInfo_Data
		{

			private string id;

			private string promptId;

			private string modelId;

			private string jobStatus;

			private double? jobTrainProgress;

			private string createTime;

			private List<string> resultImageUrl;

			public string Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public string PromptId
			{
				get
				{
					return promptId;
				}
				set	
				{
					promptId = value;
				}
			}

			public string ModelId
			{
				get
				{
					return modelId;
				}
				set	
				{
					modelId = value;
				}
			}

			public string JobStatus
			{
				get
				{
					return jobStatus;
				}
				set	
				{
					jobStatus = value;
				}
			}

			public double? JobTrainProgress
			{
				get
				{
					return jobTrainProgress;
				}
				set	
				{
					jobTrainProgress = value;
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

			public List<string> ResultImageUrl
			{
				get
				{
					return resultImageUrl;
				}
				set	
				{
					resultImageUrl = value;
				}
			}
		}
	}
}
