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
	public class QueryFpCompareJobListResponse : AcsResponse
	{

		private string requestId;

		private List<QueryFpCompareJobList_FpCompareJob> fpCompareJobList;

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

		public List<QueryFpCompareJobList_FpCompareJob> FpCompareJobList
		{
			get
			{
				return fpCompareJobList;
			}
			set	
			{
				fpCompareJobList = value;
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

		public class QueryFpCompareJobList_FpCompareJob
		{

			private string id;

			private string userData;

			private string pipelineId;

			private string fpDBId;

			private string state;

			private string code;

			private string message;

			private string creationTime;

			private string finishTime;

			private QueryFpCompareJobList_MasterFile masterFile;

			private QueryFpCompareJobList_QueryFile queryFile;

			private QueryFpCompareJobList_MatchFrameStorage matchFrameStorage;

			private QueryFpCompareJobList_FpCompareResult fpCompareResult;

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

			public string FpDBId
			{
				get
				{
					return fpDBId;
				}
				set	
				{
					fpDBId = value;
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

			public QueryFpCompareJobList_MasterFile MasterFile
			{
				get
				{
					return masterFile;
				}
				set	
				{
					masterFile = value;
				}
			}

			public QueryFpCompareJobList_QueryFile QueryFile
			{
				get
				{
					return queryFile;
				}
				set	
				{
					queryFile = value;
				}
			}

			public QueryFpCompareJobList_MatchFrameStorage MatchFrameStorage
			{
				get
				{
					return matchFrameStorage;
				}
				set	
				{
					matchFrameStorage = value;
				}
			}

			public QueryFpCompareJobList_FpCompareResult FpCompareResult
			{
				get
				{
					return fpCompareResult;
				}
				set	
				{
					fpCompareResult = value;
				}
			}

			public class QueryFpCompareJobList_MasterFile
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

			public class QueryFpCompareJobList_QueryFile
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

			public class QueryFpCompareJobList_MatchFrameStorage
			{

				private QueryFpCompareJobList_MasterMediaFrames masterMediaFrames;

				private QueryFpCompareJobList_QueryMediaFrames queryMediaFrames;

				private QueryFpCompareJobList_MatchedFramesDescFile matchedFramesDescFile;

				public QueryFpCompareJobList_MasterMediaFrames MasterMediaFrames
				{
					get
					{
						return masterMediaFrames;
					}
					set	
					{
						masterMediaFrames = value;
					}
				}

				public QueryFpCompareJobList_QueryMediaFrames QueryMediaFrames
				{
					get
					{
						return queryMediaFrames;
					}
					set	
					{
						queryMediaFrames = value;
					}
				}

				public QueryFpCompareJobList_MatchedFramesDescFile MatchedFramesDescFile
				{
					get
					{
						return matchedFramesDescFile;
					}
					set	
					{
						matchedFramesDescFile = value;
					}
				}

				public class QueryFpCompareJobList_MasterMediaFrames
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

				public class QueryFpCompareJobList_QueryMediaFrames
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

				public class QueryFpCompareJobList_MatchedFramesDescFile
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

			public class QueryFpCompareJobList_FpCompareResult
			{

				private List<QueryFpCompareJobList_MediaMatchSegment> mediaMatchSegments;

				private QueryFpCompareJobList_MasterMediaInfo masterMediaInfo;

				private QueryFpCompareJobList_QueryMediaInfo queryMediaInfo;

				public List<QueryFpCompareJobList_MediaMatchSegment> MediaMatchSegments
				{
					get
					{
						return mediaMatchSegments;
					}
					set	
					{
						mediaMatchSegments = value;
					}
				}

				public QueryFpCompareJobList_MasterMediaInfo MasterMediaInfo
				{
					get
					{
						return masterMediaInfo;
					}
					set	
					{
						masterMediaInfo = value;
					}
				}

				public QueryFpCompareJobList_QueryMediaInfo QueryMediaInfo
				{
					get
					{
						return queryMediaInfo;
					}
					set	
					{
						queryMediaInfo = value;
					}
				}

				public class QueryFpCompareJobList_MediaMatchSegment
				{

					private string queryStartFrame;

					private string queryEndFrame;

					private string masterStartFrame;

					private string masterEndFrame;

					private string queryStartTime;

					private string queryEndTime;

					private string masterStartTime;

					private string masterEndTime;

					private string totalMatchFrameNum;

					private string score;

					public string QueryStartFrame
					{
						get
						{
							return queryStartFrame;
						}
						set	
						{
							queryStartFrame = value;
						}
					}

					public string QueryEndFrame
					{
						get
						{
							return queryEndFrame;
						}
						set	
						{
							queryEndFrame = value;
						}
					}

					public string MasterStartFrame
					{
						get
						{
							return masterStartFrame;
						}
						set	
						{
							masterStartFrame = value;
						}
					}

					public string MasterEndFrame
					{
						get
						{
							return masterEndFrame;
						}
						set	
						{
							masterEndFrame = value;
						}
					}

					public string QueryStartTime
					{
						get
						{
							return queryStartTime;
						}
						set	
						{
							queryStartTime = value;
						}
					}

					public string QueryEndTime
					{
						get
						{
							return queryEndTime;
						}
						set	
						{
							queryEndTime = value;
						}
					}

					public string MasterStartTime
					{
						get
						{
							return masterStartTime;
						}
						set	
						{
							masterStartTime = value;
						}
					}

					public string MasterEndTime
					{
						get
						{
							return masterEndTime;
						}
						set	
						{
							masterEndTime = value;
						}
					}

					public string TotalMatchFrameNum
					{
						get
						{
							return totalMatchFrameNum;
						}
						set	
						{
							totalMatchFrameNum = value;
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

				public class QueryFpCompareJobList_MasterMediaInfo
				{

					private string duration;

					private string fpNum;

					private string width;

					private string height;

					private string fps;

					private string totalVideoFrame;

					private string audioBitRate;

					private string audioChannels;

					private string audioSampleRate;

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

					public string FpNum
					{
						get
						{
							return fpNum;
						}
						set	
						{
							fpNum = value;
						}
					}

					public string Width
					{
						get
						{
							return width;
						}
						set	
						{
							width = value;
						}
					}

					public string Height
					{
						get
						{
							return height;
						}
						set	
						{
							height = value;
						}
					}

					public string Fps
					{
						get
						{
							return fps;
						}
						set	
						{
							fps = value;
						}
					}

					public string TotalVideoFrame
					{
						get
						{
							return totalVideoFrame;
						}
						set	
						{
							totalVideoFrame = value;
						}
					}

					public string AudioBitRate
					{
						get
						{
							return audioBitRate;
						}
						set	
						{
							audioBitRate = value;
						}
					}

					public string AudioChannels
					{
						get
						{
							return audioChannels;
						}
						set	
						{
							audioChannels = value;
						}
					}

					public string AudioSampleRate
					{
						get
						{
							return audioSampleRate;
						}
						set	
						{
							audioSampleRate = value;
						}
					}
				}

				public class QueryFpCompareJobList_QueryMediaInfo
				{

					private string duration;

					private string fpNum;

					private string width;

					private string height;

					private string fps;

					private string totalVideoFrame;

					private string audioBitRate;

					private string audioChannels;

					private string audioSampleRate;

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

					public string FpNum
					{
						get
						{
							return fpNum;
						}
						set	
						{
							fpNum = value;
						}
					}

					public string Width
					{
						get
						{
							return width;
						}
						set	
						{
							width = value;
						}
					}

					public string Height
					{
						get
						{
							return height;
						}
						set	
						{
							height = value;
						}
					}

					public string Fps
					{
						get
						{
							return fps;
						}
						set	
						{
							fps = value;
						}
					}

					public string TotalVideoFrame
					{
						get
						{
							return totalVideoFrame;
						}
						set	
						{
							totalVideoFrame = value;
						}
					}

					public string AudioBitRate
					{
						get
						{
							return audioBitRate;
						}
						set	
						{
							audioBitRate = value;
						}
					}

					public string AudioChannels
					{
						get
						{
							return audioChannels;
						}
						set	
						{
							audioChannels = value;
						}
					}

					public string AudioSampleRate
					{
						get
						{
							return audioSampleRate;
						}
						set	
						{
							audioSampleRate = value;
						}
					}
				}
			}
		}
	}
}
