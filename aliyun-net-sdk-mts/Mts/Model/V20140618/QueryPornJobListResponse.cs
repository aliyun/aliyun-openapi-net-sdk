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
	public class QueryPornJobListResponse : AcsResponse
	{

		private string requestId;

		private List<QueryPornJobList_PornJob> pornJobList;

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

		public List<QueryPornJobList_PornJob> PornJobList
		{
			get
			{
				return pornJobList;
			}
			set	
			{
				pornJobList = value;
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

		public class QueryPornJobList_PornJob
		{

			private string id;

			private string userData;

			private string pipelineId;

			private string state;

			private string code;

			private string message;

			private string creationTime;

			private QueryPornJobList_Input input;

			private QueryPornJobList_PornConfig pornConfig;

			private QueryPornJobList_CensorPornResult censorPornResult;

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

			public QueryPornJobList_Input Input
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

			public QueryPornJobList_PornConfig PornConfig
			{
				get
				{
					return pornConfig;
				}
				set	
				{
					pornConfig = value;
				}
			}

			public QueryPornJobList_CensorPornResult CensorPornResult
			{
				get
				{
					return censorPornResult;
				}
				set	
				{
					censorPornResult = value;
				}
			}

			public class QueryPornJobList_Input
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

			public class QueryPornJobList_PornConfig
			{

				private string interval;

				private string bizType;

				private QueryPornJobList_OutputFile outputFile;

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

				public QueryPornJobList_OutputFile OutputFile
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

				public class QueryPornJobList_OutputFile
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

			public class QueryPornJobList_CensorPornResult
			{

				private string label;

				private string suggestion;

				private string maxScore;

				private string averageScore;

				private List<QueryPornJobList_Counter> pornCounterList;

				private List<QueryPornJobList_Top> pornTopList;

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

				public string MaxScore
				{
					get
					{
						return maxScore;
					}
					set	
					{
						maxScore = value;
					}
				}

				public string AverageScore
				{
					get
					{
						return averageScore;
					}
					set	
					{
						averageScore = value;
					}
				}

				public List<QueryPornJobList_Counter> PornCounterList
				{
					get
					{
						return pornCounterList;
					}
					set	
					{
						pornCounterList = value;
					}
				}

				public List<QueryPornJobList_Top> PornTopList
				{
					get
					{
						return pornTopList;
					}
					set	
					{
						pornTopList = value;
					}
				}

				public class QueryPornJobList_Counter
				{

					private int? count;

					private string label;

					public int? Count
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
				}

				public class QueryPornJobList_Top
				{

					private string label;

					private string score;

					private string timestamp;

					private string index;

					private string _object;

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

					public string Index
					{
						get
						{
							return index;
						}
						set	
						{
							index = value;
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