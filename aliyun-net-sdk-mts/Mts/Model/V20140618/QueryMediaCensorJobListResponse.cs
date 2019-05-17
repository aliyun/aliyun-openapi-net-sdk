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
	public class QueryMediaCensorJobListResponse : AcsResponse
	{

		private string requestId;

		private string nextPageToken;

		private List<QueryMediaCensorJobList_MediaCensorJob> mediaCensorJobList;

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

		public List<QueryMediaCensorJobList_MediaCensorJob> MediaCensorJobList
		{
			get
			{
				return mediaCensorJobList;
			}
			set	
			{
				mediaCensorJobList = value;
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

		public class QueryMediaCensorJobList_MediaCensorJob
		{

			private string jobId;

			private string userData;

			private string pipelineId;

			private string state;

			private string code;

			private string suggestion;

			private string message;

			private string creationTime;

			private string finishTime;

			private List<QueryMediaCensorJobList_CoverImageCensorResult> coverImageCensorResults;

			private QueryMediaCensorJobList_TitleCensorResult titleCensorResult;

			private QueryMediaCensorJobList_DescCensorResult descCensorResult;

			private QueryMediaCensorJobList_BarrageCensorResult barrageCensorResult;

			private QueryMediaCensorJobList_Input input;

			private QueryMediaCensorJobList_VideoCensorConfig videoCensorConfig;

			private QueryMediaCensorJobList_VensorCensorResult vensorCensorResult;

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

			public string Suggestion
			{
				get
				{
					return suggestion;
				}
				set	
				{
					suggestion = value;
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

			public string FinishTime
			{
				get
				{
					return finishTime;
				}
				set	
				{
					finishTime = value;
				}
			}

			public List<QueryMediaCensorJobList_CoverImageCensorResult> CoverImageCensorResults
			{
				get
				{
					return coverImageCensorResults;
				}
				set	
				{
					coverImageCensorResults = value;
				}
			}

			public QueryMediaCensorJobList_TitleCensorResult TitleCensorResult
			{
				get
				{
					return titleCensorResult;
				}
				set	
				{
					titleCensorResult = value;
				}
			}

			public QueryMediaCensorJobList_DescCensorResult DescCensorResult
			{
				get
				{
					return descCensorResult;
				}
				set	
				{
					descCensorResult = value;
				}
			}

			public QueryMediaCensorJobList_BarrageCensorResult BarrageCensorResult
			{
				get
				{
					return barrageCensorResult;
				}
				set	
				{
					barrageCensorResult = value;
				}
			}

			public QueryMediaCensorJobList_Input Input
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

			public QueryMediaCensorJobList_VideoCensorConfig VideoCensorConfig
			{
				get
				{
					return videoCensorConfig;
				}
				set	
				{
					videoCensorConfig = value;
				}
			}

			public QueryMediaCensorJobList_VensorCensorResult VensorCensorResult
			{
				get
				{
					return vensorCensorResult;
				}
				set	
				{
					vensorCensorResult = value;
				}
			}

			public class QueryMediaCensorJobList_CoverImageCensorResult
			{

				private string location;

				private string bucket;

				private string _object;

				private List<QueryMediaCensorJobList_Result> results;

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

				public List<QueryMediaCensorJobList_Result> Results
				{
					get
					{
						return results;
					}
					set	
					{
						results = value;
					}
				}

				public class QueryMediaCensorJobList_Result
				{

					private string rate;

					private string scene;

					private string label;

					private string suggestion;

					public string Rate
					{
						get
						{
							return rate;
						}
						set	
						{
							rate = value;
						}
					}

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

					public string Label
					{
						get
						{
							return label;
						}
						set	
						{
							label = value;
						}
					}

					public string Suggestion
					{
						get
						{
							return suggestion;
						}
						set	
						{
							suggestion = value;
						}
					}
				}
			}

			public class QueryMediaCensorJobList_TitleCensorResult
			{

				private string rate;

				private string scene;

				private string label;

				private string suggestion;

				public string Rate
				{
					get
					{
						return rate;
					}
					set	
					{
						rate = value;
					}
				}

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

				public string Label
				{
					get
					{
						return label;
					}
					set	
					{
						label = value;
					}
				}

				public string Suggestion
				{
					get
					{
						return suggestion;
					}
					set	
					{
						suggestion = value;
					}
				}
			}

			public class QueryMediaCensorJobList_DescCensorResult
			{

				private string rate;

				private string scene;

				private string label;

				private string suggestion;

				public string Rate
				{
					get
					{
						return rate;
					}
					set	
					{
						rate = value;
					}
				}

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

				public string Label
				{
					get
					{
						return label;
					}
					set	
					{
						label = value;
					}
				}

				public string Suggestion
				{
					get
					{
						return suggestion;
					}
					set	
					{
						suggestion = value;
					}
				}
			}

			public class QueryMediaCensorJobList_BarrageCensorResult
			{

				private string rate;

				private string scene;

				private string label;

				private string suggestion;

				public string Rate
				{
					get
					{
						return rate;
					}
					set	
					{
						rate = value;
					}
				}

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

				public string Label
				{
					get
					{
						return label;
					}
					set	
					{
						label = value;
					}
				}

				public string Suggestion
				{
					get
					{
						return suggestion;
					}
					set	
					{
						suggestion = value;
					}
				}
			}

			public class QueryMediaCensorJobList_Input
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

			public class QueryMediaCensorJobList_VideoCensorConfig
			{

				private string bizType;

				private string videoCensor;

				private QueryMediaCensorJobList_OutputFile outputFile;

				public string BizType
				{
					get
					{
						return bizType;
					}
					set	
					{
						bizType = value;
					}
				}

				public string VideoCensor
				{
					get
					{
						return videoCensor;
					}
					set	
					{
						videoCensor = value;
					}
				}

				public QueryMediaCensorJobList_OutputFile OutputFile
				{
					get
					{
						return outputFile;
					}
					set	
					{
						outputFile = value;
					}
				}

				public class QueryMediaCensorJobList_OutputFile
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

			public class QueryMediaCensorJobList_VensorCensorResult
			{

				private string nextPageToken;

				private List<QueryMediaCensorJobList_CensorResult> censorResults;

				private List<QueryMediaCensorJobList_VideoTimeline> videoTimelines;

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

				public List<QueryMediaCensorJobList_CensorResult> CensorResults
				{
					get
					{
						return censorResults;
					}
					set	
					{
						censorResults = value;
					}
				}

				public List<QueryMediaCensorJobList_VideoTimeline> VideoTimelines
				{
					get
					{
						return videoTimelines;
					}
					set	
					{
						videoTimelines = value;
					}
				}

				public class QueryMediaCensorJobList_CensorResult
				{

					private string rate;

					private string scene;

					private string label;

					private string suggestion;

					public string Rate
					{
						get
						{
							return rate;
						}
						set	
						{
							rate = value;
						}
					}

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

					public string Label
					{
						get
						{
							return label;
						}
						set	
						{
							label = value;
						}
					}

					public string Suggestion
					{
						get
						{
							return suggestion;
						}
						set	
						{
							suggestion = value;
						}
					}
				}

				public class QueryMediaCensorJobList_VideoTimeline
				{

					private string _object;

					private string timestamp;

					private List<QueryMediaCensorJobList_CensorResult2> censorResults1;

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

					public string Timestamp
					{
						get
						{
							return timestamp;
						}
						set	
						{
							timestamp = value;
						}
					}

					public List<QueryMediaCensorJobList_CensorResult2> CensorResults1
					{
						get
						{
							return censorResults1;
						}
						set	
						{
							censorResults1 = value;
						}
					}

					public class QueryMediaCensorJobList_CensorResult2
					{

						private string rate;

						private string scene;

						private string label;

						private string suggestion;

						public string Rate
						{
							get
							{
								return rate;
							}
							set	
							{
								rate = value;
							}
						}

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

						public string Label
						{
							get
							{
								return label;
							}
							set	
							{
								label = value;
							}
						}

						public string Suggestion
						{
							get
							{
								return suggestion;
							}
							set	
							{
								suggestion = value;
							}
						}
					}
				}
			}
		}
	}
}
