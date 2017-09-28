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
	public class QuerySnapshotJobListResponse : AcsResponse
	{

		private List<SnapshotJob> snapshotJobList;

		private List<string> nonExistSnapshotJobIds;

		public List<SnapshotJob> SnapshotJobList
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

		public class SnapshotJob{

			private string id;

			private string userData;

			private string pipelineId;

			private string state;

			private string code;

			private string count;

			private string message;

			private string creationTime;

			private Input_ input;

			private SnapshotConfig_ snapshotConfig;

			private MNSMessageResult_ mNSMessageResult;

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

			public Input_ Input
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

			public SnapshotConfig_ SnapshotConfig
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

			public MNSMessageResult_ MNSMessageResult
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

			public class Input_{

				private string bucket;

				private string location;

				private string object_;

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

				public string Object
				{
					get
					{
						return object_;
					}
					set	
					{
						object_ = value;
					}
				}
			}

			public class SnapshotConfig_{

				private string time;

				private string interval;

				private string num;

				private string width;

				private string height;

				private string frameType;

				private OutputFile_ outputFile;

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

				public OutputFile_ OutputFile
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

				public class OutputFile_{

					private string bucket;

					private string location;

					private string object_;

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

					public string Object
					{
						get
						{
							return object_;
						}
						set	
						{
							object_ = value;
						}
					}
				}
			}

			public class MNSMessageResult_{

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
	}
}