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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Mts.Model.V20140618
{
	public class QueryMediaWorkflowExecutionListResponse : AcsResponse
	{

		private string requestId;

		private List<QueryMediaWorkflowExecutionList_MediaWorkflowExecution> mediaWorkflowExecutionList;

		private List<string> nonExistRunIds;

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

		public List<QueryMediaWorkflowExecutionList_MediaWorkflowExecution> MediaWorkflowExecutionList
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

		public List<string> NonExistRunIds
		{
			get
			{
				return nonExistRunIds;
			}
			set	
			{
				nonExistRunIds = value;
			}
		}

		public class QueryMediaWorkflowExecutionList_MediaWorkflowExecution
		{

			private string runId;

			private string mediaWorkflowId;

			private string name;

			private string state;

			private string mediaId;

			private string creationTime;

			private List<QueryMediaWorkflowExecutionList_Activity> activityList;

			private QueryMediaWorkflowExecutionList_Input input;

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

			public List<QueryMediaWorkflowExecutionList_Activity> ActivityList
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

			public QueryMediaWorkflowExecutionList_Input Input
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

			public class QueryMediaWorkflowExecutionList_Activity
			{

				private string name;

				private string type;

				private string jobId;

				private string state;

				private string code;

				private string message;

				private string startTime;

				private string endTime;

				private QueryMediaWorkflowExecutionList_MNSMessageResult mNSMessageResult;

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

				public QueryMediaWorkflowExecutionList_MNSMessageResult MNSMessageResult
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

				public class QueryMediaWorkflowExecutionList_MNSMessageResult
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

			public class QueryMediaWorkflowExecutionList_Input
			{

				private string userData;

				private QueryMediaWorkflowExecutionList_InputFile inputFile;

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

				public QueryMediaWorkflowExecutionList_InputFile InputFile
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

				public class QueryMediaWorkflowExecutionList_InputFile
				{

					private string bucket;

					private string location;

					private string _object;

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
				}
			}
		}
	}
}