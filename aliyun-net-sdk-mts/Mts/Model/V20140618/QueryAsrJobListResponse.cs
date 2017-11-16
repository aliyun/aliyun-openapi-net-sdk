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
	public class QueryAsrJobListResponse : AcsResponse
	{

		private string requestId;

		private List<QueryAsrJobList_Job> jobList;

		private List<string> nonExistIds;

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

		public List<QueryAsrJobList_Job> JobList
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

		public List<string> NonExistIds
		{
			get
			{
				return nonExistIds;
			}
			set	
			{
				nonExistIds = value;
			}
		}

		public class QueryAsrJobList_Job
		{

			private string id;

			private string userData;

			private string pipelineId;

			private string state;

			private string code;

			private string message;

			private string creationTime;

			private QueryAsrJobList_Input input;

			private QueryAsrJobList_AsrConfig asrConfig;

			private QueryAsrJobList_AsrResult asrResult;

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

			public QueryAsrJobList_Input Input
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

			public QueryAsrJobList_AsrConfig AsrConfig
			{
				get
				{
					return asrConfig;
				}
				set	
				{
					asrConfig = value;
				}
			}

			public QueryAsrJobList_AsrResult AsrResult
			{
				get
				{
					return asrResult;
				}
				set	
				{
					asrResult = value;
				}
			}

			public class QueryAsrJobList_Input
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

			public class QueryAsrJobList_AsrConfig
			{

				private string scene;

				public string Scene
				{
					get
					{
						return scene;
					}
					set	
					{
						scene = value;
					}
				}
			}

			public class QueryAsrJobList_AsrResult
			{

				private string duration;

				private List<QueryAsrJobList_AsrText> asrTextList;

				public string Duration
				{
					get
					{
						return duration;
					}
					set	
					{
						duration = value;
					}
				}

				public List<QueryAsrJobList_AsrText> AsrTextList
				{
					get
					{
						return asrTextList;
					}
					set	
					{
						asrTextList = value;
					}
				}

				public class QueryAsrJobList_AsrText
				{

					private int? startTime;

					private string endTime;

					private string channelId;

					private string speechRate;

					private string text;

					public int? StartTime
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

					public string ChannelId
					{
						get
						{
							return channelId;
						}
						set	
						{
							channelId = value;
						}
					}

					public string SpeechRate
					{
						get
						{
							return speechRate;
						}
						set	
						{
							speechRate = value;
						}
					}

					public string Text
					{
						get
						{
							return text;
						}
						set	
						{
							text = value;
						}
					}
				}
			}
		}
	}
}