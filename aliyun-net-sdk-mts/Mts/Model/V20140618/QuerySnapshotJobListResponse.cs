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
	public class QuerySnapshotJobListResponse : AcsResponse
	{

		private string requestId;

		private string nextPageToken;

		private List<QuerySnapshotJobList_SnapshotJob> snapshotJobList;

		private List<string> nonExistSnapshotJobIds;

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

		public List<QuerySnapshotJobList_SnapshotJob> SnapshotJobList
		{
			get
			{
				return snapshotJobList;
			}
			set	
			{
				snapshotJobList = value;
			}
		}

		public List<string> NonExistSnapshotJobIds
		{
			get
			{
				return nonExistSnapshotJobIds;
			}
			set	
			{
				nonExistSnapshotJobIds = value;
			}
		}

		public class QuerySnapshotJobList_SnapshotJob
		{

			private string creationTime;

			private string state;

			private string message;

			private string count;

			private string tileCount;

			private string userData;

			private string code;

			private string pipelineId;

			private string id;

			private QuerySnapshotJobList_SnapshotConfig snapshotConfig;

			private QuerySnapshotJobList_MNSMessageResult mNSMessageResult;

			private QuerySnapshotJobList_Input input;

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

			public string Count
			{
				get
				{
					return count;
				}
				set	
				{
					count = value;
				}
			}

			public string TileCount
			{
				get
				{
					return tileCount;
				}
				set	
				{
					tileCount = value;
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

			public QuerySnapshotJobList_SnapshotConfig SnapshotConfig
			{
				get
				{
					return snapshotConfig;
				}
				set	
				{
					snapshotConfig = value;
				}
			}

			public QuerySnapshotJobList_MNSMessageResult MNSMessageResult
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

			public QuerySnapshotJobList_Input Input
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

			public class QuerySnapshotJobList_SnapshotConfig
			{

				private string time;

				private string interval;

				private string frameType;

				private string width;

				private string height;

				private string num;

				private List<string> timeArray;

				private QuerySnapshotJobList_TileOut tileOut;

				private QuerySnapshotJobList_OutputFile outputFile;

				private QuerySnapshotJobList_TileOutputFile tileOutputFile;

				public string Time
				{
					get
					{
						return time;
					}
					set	
					{
						time = value;
					}
				}

				public string Interval
				{
					get
					{
						return interval;
					}
					set	
					{
						interval = value;
					}
				}

				public string FrameType
				{
					get
					{
						return frameType;
					}
					set	
					{
						frameType = value;
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

				public string Num
				{
					get
					{
						return num;
					}
					set	
					{
						num = value;
					}
				}

				public List<string> TimeArray
				{
					get
					{
						return timeArray;
					}
					set	
					{
						timeArray = value;
					}
				}

				public QuerySnapshotJobList_TileOut TileOut
				{
					get
					{
						return tileOut;
					}
					set	
					{
						tileOut = value;
					}
				}

				public QuerySnapshotJobList_OutputFile OutputFile
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

				public QuerySnapshotJobList_TileOutputFile TileOutputFile
				{
					get
					{
						return tileOutputFile;
					}
					set	
					{
						tileOutputFile = value;
					}
				}

				public class QuerySnapshotJobList_TileOut
				{

					private string padding;

					private string color;

					private string cellSelStep;

					private string cellHeight;

					private string cellWidth;

					private string margin;

					private string columns;

					private string isKeepCellPic;

					private string lines;

					public string Padding
					{
						get
						{
							return padding;
						}
						set	
						{
							padding = value;
						}
					}

					public string Color
					{
						get
						{
							return color;
						}
						set	
						{
							color = value;
						}
					}

					public string CellSelStep
					{
						get
						{
							return cellSelStep;
						}
						set	
						{
							cellSelStep = value;
						}
					}

					public string CellHeight
					{
						get
						{
							return cellHeight;
						}
						set	
						{
							cellHeight = value;
						}
					}

					public string CellWidth
					{
						get
						{
							return cellWidth;
						}
						set	
						{
							cellWidth = value;
						}
					}

					public string Margin
					{
						get
						{
							return margin;
						}
						set	
						{
							margin = value;
						}
					}

					public string Columns
					{
						get
						{
							return columns;
						}
						set	
						{
							columns = value;
						}
					}

					public string IsKeepCellPic
					{
						get
						{
							return isKeepCellPic;
						}
						set	
						{
							isKeepCellPic = value;
						}
					}

					public string Lines
					{
						get
						{
							return lines;
						}
						set	
						{
							lines = value;
						}
					}
				}

				public class QuerySnapshotJobList_OutputFile
				{

					private string roleArn;

					private string _object;

					private string location;

					private string bucket;

					public string RoleArn
					{
						get
						{
							return roleArn;
						}
						set	
						{
							roleArn = value;
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

				public class QuerySnapshotJobList_TileOutputFile
				{

					private string roleArn;

					private string _object;

					private string location;

					private string bucket;

					public string RoleArn
					{
						get
						{
							return roleArn;
						}
						set	
						{
							roleArn = value;
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

			public class QuerySnapshotJobList_MNSMessageResult
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

			public class QuerySnapshotJobList_Input
			{

				private string roleArn;

				private string _object;

				private string location;

				private string bucket;

				public string RoleArn
				{
					get
					{
						return roleArn;
					}
					set	
					{
						roleArn = value;
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
