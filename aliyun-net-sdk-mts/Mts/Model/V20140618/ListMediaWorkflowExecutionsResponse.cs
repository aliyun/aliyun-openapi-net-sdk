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

namespace Aliyun.Acs.Mts.Model.V20140618
{
	public class ListMediaWorkflowExecutionsResponse : AcsResponse
	{

		private string requestId;

		private string nextPageToken;

		private List<ListMediaWorkflowExecutions_MediaWorkflowExecution> mediaWorkflowExecutionList;

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

		public string NextPageToken
		{
			get
			{
				return nextPageToken;
			}
			set	
			{
				nextPageToken = value;
			}
		}

		public List<ListMediaWorkflowExecutions_MediaWorkflowExecution> MediaWorkflowExecutionList
		{
			get
			{
				return mediaWorkflowExecutionList;
			}
			set	
			{
				mediaWorkflowExecutionList = value;
			}
		}

		public class ListMediaWorkflowExecutions_MediaWorkflowExecution
		{

			private string creationTime;

			private string mediaWorkflowId;

			private string state;

			private string name;

			private string mediaId;

			private string runId;

			private List<ListMediaWorkflowExecutions_Activity> activityList;

			private ListMediaWorkflowExecutions_Input input;

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

			public string MediaWorkflowId
			{
				get
				{
					return mediaWorkflowId;
				}
				set	
				{
					mediaWorkflowId = value;
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

			public string RunId
			{
				get
				{
					return runId;
				}
				set	
				{
					runId = value;
				}
			}

			public List<ListMediaWorkflowExecutions_Activity> ActivityList
			{
				get
				{
					return activityList;
				}
				set	
				{
					activityList = value;
				}
			}

			public ListMediaWorkflowExecutions_Input Input
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

			public class ListMediaWorkflowExecutions_Activity
			{

				private string endTime;

				private string type;

				private string startTime;

				private string state;

				private string jobId;

				private string code;

				private string message;

				private string name;

				private ListMediaWorkflowExecutions_MNSMessageResult mNSMessageResult;

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

				public string StartTime
				{
					get
					{
						return startTime;
					}
					set	
					{
						startTime = value;
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

				public ListMediaWorkflowExecutions_MNSMessageResult MNSMessageResult
				{
					get
					{
						return mNSMessageResult;
					}
					set	
					{
						mNSMessageResult = value;
					}
				}

				public class ListMediaWorkflowExecutions_MNSMessageResult
				{

					private string messageId;

					private string errorMessage;

					private string errorCode;

					public string MessageId
					{
						get
						{
							return messageId;
						}
						set	
						{
							messageId = value;
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
				}
			}

			public class ListMediaWorkflowExecutions_Input
			{

				private string userData;

				private ListMediaWorkflowExecutions_InputFile inputFile;

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

				public ListMediaWorkflowExecutions_InputFile InputFile
				{
					get
					{
						return inputFile;
					}
					set	
					{
						inputFile = value;
					}
				}

				public class ListMediaWorkflowExecutions_InputFile
				{

					private string _object;

					private string location;

					private string bucket;

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
				}
			}
		}
	}
}
