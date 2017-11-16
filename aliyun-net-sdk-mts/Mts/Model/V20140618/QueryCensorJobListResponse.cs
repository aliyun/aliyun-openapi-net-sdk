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
	public class QueryCensorJobListResponse : AcsResponse
	{

		private string requestId;

		private List<QueryCensorJobList_CensorJob> censorJobList;

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

		public List<QueryCensorJobList_CensorJob> CensorJobList
		{
			get
			{
				return censorJobList;
			}
			set	
			{
				censorJobList = value;
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

		public class QueryCensorJobList_CensorJob
		{

			private string id;

			private string userData;

			private string pipelineId;

			private string state;

			private string code;

			private string message;

			private string creationTime;

			private QueryCensorJobList_Input input;

			private QueryCensorJobList_CensorConfig censorConfig;

			private QueryCensorJobList_CensorPornResult censorPornResult;

			private QueryCensorJobList_CensorTerrorismResult censorTerrorismResult;

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

			public QueryCensorJobList_Input Input
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

			public QueryCensorJobList_CensorConfig CensorConfig
			{
				get
				{
					return censorConfig;
				}
				set	
				{
					censorConfig = value;
				}
			}

			public QueryCensorJobList_CensorPornResult CensorPornResult
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

			public QueryCensorJobList_CensorTerrorismResult CensorTerrorismResult
			{
				get
				{
					return censorTerrorismResult;
				}
				set	
				{
					censorTerrorismResult = value;
				}
			}

			public class QueryCensorJobList_Input
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

			public class QueryCensorJobList_CensorConfig
			{

				private string interval;

				private string bizType;

				private QueryCensorJobList_OutputFile outputFile;

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

				public QueryCensorJobList_OutputFile OutputFile
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

				public class QueryCensorJobList_OutputFile
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

			public class QueryCensorJobList_CensorPornResult
			{

				private string label;

				private string suggestion;

				private string maxScore;

				private string averageScore;

				private List<QueryCensorJobList_Counter> pornCounterList;

				private List<QueryCensorJobList_Top> pornTopList;

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

				public List<QueryCensorJobList_Counter> PornCounterList
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

				public List<QueryCensorJobList_Top> PornTopList
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

				public class QueryCensorJobList_Counter
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

				public class QueryCensorJobList_Top
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

			public class QueryCensorJobList_CensorTerrorismResult
			{

				private string label;

				private string suggestion;

				private string maxScore;

				private string averageScore;

				private List<QueryCensorJobList_Counter1> terrorismCounterList;

				private List<QueryCensorJobList_Top2> terrorismTopList;

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

				public List<QueryCensorJobList_Counter1> TerrorismCounterList
				{
					get
					{
						return terrorismCounterList;
					}
					set	
					{
						terrorismCounterList = value;
					}
				}

				public List<QueryCensorJobList_Top2> TerrorismTopList
				{
					get
					{
						return terrorismTopList;
					}
					set	
					{
						terrorismTopList = value;
					}
				}

				public class QueryCensorJobList_Counter1
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

				public class QueryCensorJobList_Top2
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