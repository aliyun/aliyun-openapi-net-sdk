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

namespace Aliyun.Acs.tingwu.Model.V20230930
{
	public class GetTaskInfoResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private GetTaskInfo_Data data;

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

		public GetTaskInfo_Data Data
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

		public class GetTaskInfo_Data
		{

			private string taskId;

			private string taskKey;

			private string taskStatus;

			private string errorCode;

			private string errorMessage;

			private GetTaskInfo_Result result;

			public string TaskId
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

			public string TaskKey
			{
				get
				{
					return taskKey;
				}
				set	
				{
					taskKey = value;
				}
			}

			public string TaskStatus
			{
				get
				{
					return taskStatus;
				}
				set	
				{
					taskStatus = value;
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

			public GetTaskInfo_Result Result
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

			public class GetTaskInfo_Result
			{

				private string transcription;

				private string autoChapters;

				private string meetingAssistance;

				private string summarization;

				private string translation;

				private string pptExtraction;

				public string Transcription
				{
					get
					{
						return transcription;
					}
					set	
					{
						transcription = value;
					}
				}

				public string AutoChapters
				{
					get
					{
						return autoChapters;
					}
					set	
					{
						autoChapters = value;
					}
				}

				public string MeetingAssistance
				{
					get
					{
						return meetingAssistance;
					}
					set	
					{
						meetingAssistance = value;
					}
				}

				public string Summarization
				{
					get
					{
						return summarization;
					}
					set	
					{
						summarization = value;
					}
				}

				public string Translation
				{
					get
					{
						return translation;
					}
					set	
					{
						translation = value;
					}
				}

				public string PptExtraction
				{
					get
					{
						return pptExtraction;
					}
					set	
					{
						pptExtraction = value;
					}
				}
			}
		}
	}
}
