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
	public class QueryVideoSummaryJobListResponse : AcsResponse
	{

		private string requestId;

		private List<QueryVideoSummaryJobList_Job> jobList;

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

		public List<QueryVideoSummaryJobList_Job> JobList
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

		public class QueryVideoSummaryJobList_Job
		{

			private string id;

			private string userData;

			private string pipelineId;

			private string state;

			private string code;

			private string message;

			private string creationTime;

			private QueryVideoSummaryJobList_Input input;

			private QueryVideoSummaryJobList_VideoSummaryResult videoSummaryResult;

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

			public QueryVideoSummaryJobList_Input Input
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

			public QueryVideoSummaryJobList_VideoSummaryResult VideoSummaryResult
			{
				get
				{
					return videoSummaryResult;
				}
				set	
				{
					videoSummaryResult = value;
				}
			}

			public class QueryVideoSummaryJobList_Input
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

			public class QueryVideoSummaryJobList_VideoSummaryResult
			{

				private List<QueryVideoSummaryJobList_VideoSummary> videoSummaryList;

				public List<QueryVideoSummaryJobList_VideoSummary> VideoSummaryList
				{
					get
					{
						return videoSummaryList;
					}
					set	
					{
						videoSummaryList = value;
					}
				}

				public class QueryVideoSummaryJobList_VideoSummary
				{

					private string startTime;

					private string endTime;

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
				}
			}
		}
	}
}