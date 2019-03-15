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

namespace Aliyun.Acs.Mts.Model.V20140618
{
	public class SubmitImageQualityJobResponse : AcsResponse
	{

		private string requestId;

		private SubmitImageQualityJob_ImageQualityJob imageQualityJob;

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

		public SubmitImageQualityJob_ImageQualityJob ImageQualityJob
		{
			get
			{
				return imageQualityJob;
			}
			set	
			{
				imageQualityJob = value;
			}
		}

		public class SubmitImageQualityJob_ImageQualityJob
		{

			private string jobId;

			private string userData;

			private string pipelineId;

			private string state;

			private string creationTime;

			private SubmitImageQualityJob_Input input;

			private SubmitImageQualityJob_Result result;

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

			public string PipelineId
			{
				get
				{
					return pipelineId;
				}
				set	
				{
					pipelineId = value;
				}
			}

			public string State
			{
				get
				{
					return state;
				}
				set	
				{
					state = value;
				}
			}

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

			public SubmitImageQualityJob_Input Input
			{
				get
				{
					return input;
				}
				set	
				{
					input = value;
				}
			}

			public SubmitImageQualityJob_Result Result
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

			public class SubmitImageQualityJob_Input
			{

				private string bucket;

				private string location;

				private string _object;

				private string url;

				public string Bucket
				{
					get
					{
						return bucket;
					}
					set	
					{
						bucket = value;
					}
				}

				public string Location
				{
					get
					{
						return location;
					}
					set	
					{
						location = value;
					}
				}

				public string _Object
				{
					get
					{
						return _object;
					}
					set	
					{
						_object = value;
					}
				}

				public string Url
				{
					get
					{
						return url;
					}
					set	
					{
						url = value;
					}
				}
			}

			public class SubmitImageQualityJob_Result
			{

				private string code;

				private string message;

				private string score;

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

				public string Score
				{
					get
					{
						return score;
					}
					set	
					{
						score = value;
					}
				}
			}
		}
	}
}
