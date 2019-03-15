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
	public class QueryImageSearchJobListResponse : AcsResponse
	{

		private string requestId;

		private List<QueryImageSearchJobList_ImageSearchJob> imageSearchJobList;

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

		public List<QueryImageSearchJobList_ImageSearchJob> ImageSearchJobList
		{
			get
			{
				return imageSearchJobList;
			}
			set	
			{
				imageSearchJobList = value;
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

		public class QueryImageSearchJobList_ImageSearchJob
		{

			private string id;

			private string userData;

			private string pipelineId;

			private string state;

			private string code;

			private string message;

			private string creationTime;

			private string finishTime;

			private QueryImageSearchJobList_InputVideo inputVideo;

			private QueryImageSearchJobList_InputImage inputImage;

			private QueryImageSearchJobList_Result result;

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

			public QueryImageSearchJobList_InputVideo InputVideo
			{
				get
				{
					return inputVideo;
				}
				set	
				{
					inputVideo = value;
				}
			}

			public QueryImageSearchJobList_InputImage InputImage
			{
				get
				{
					return inputImage;
				}
				set	
				{
					inputImage = value;
				}
			}

			public QueryImageSearchJobList_Result Result
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

			public class QueryImageSearchJobList_InputVideo
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

			public class QueryImageSearchJobList_InputImage
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

			public class QueryImageSearchJobList_Result
			{

				private List<QueryImageSearchJobList_ImageSearchShotsItem> imageSearchShots;

				public List<QueryImageSearchJobList_ImageSearchShotsItem> ImageSearchShots
				{
					get
					{
						return imageSearchShots;
					}
					set	
					{
						imageSearchShots = value;
					}
				}

				public class QueryImageSearchJobList_ImageSearchShotsItem
				{

					private string matchedTimestamp;

					private string matchedFrame;

					private string similarity;

					public string MatchedTimestamp
					{
						get
						{
							return matchedTimestamp;
						}
						set	
						{
							matchedTimestamp = value;
						}
					}

					public string MatchedFrame
					{
						get
						{
							return matchedFrame;
						}
						set	
						{
							matchedFrame = value;
						}
					}

					public string Similarity
					{
						get
						{
							return similarity;
						}
						set	
						{
							similarity = value;
						}
					}
				}
			}
		}
	}
}
