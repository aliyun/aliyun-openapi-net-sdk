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
	public class QueryFpShotJobListResponse : AcsResponse
	{

		private string requestId;

		private List<QueryFpShotJobList_FpShotJob> fpShotJobList;

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

		public List<QueryFpShotJobList_FpShotJob> FpShotJobList
		{
			get
			{
				return fpShotJobList;
			}
			set	
			{
				fpShotJobList = value;
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

		public class QueryFpShotJobList_FpShotJob
		{

			private string id;

			private string userData;

			private string pipelineId;

			private string state;

			private string code;

			private string message;

			private string creationTime;

			private QueryFpShotJobList_InputFile inputFile;

			private QueryFpShotJobList_FpShotResult fpShotResult;

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

			public QueryFpShotJobList_InputFile InputFile
			{
				get
				{
					return inputFile;
				}
				set	
				{
					inputFile = value;
				}
			}

			public QueryFpShotJobList_FpShotResult FpShotResult
			{
				get
				{
					return fpShotResult;
				}
				set	
				{
					fpShotResult = value;
				}
			}

			public class QueryFpShotJobList_InputFile
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

			public class QueryFpShotJobList_FpShotResult
			{

				private List<QueryFpShotJobList_FpShot> fpShots;

				public List<QueryFpShotJobList_FpShot> FpShots
				{
					get
					{
						return fpShots;
					}
					set	
					{
						fpShots = value;
					}
				}

				public class QueryFpShotJobList_FpShot
				{

					private string primaryKey;

					private string similarity;

					private List<QueryFpShotJobList_FpShotSlice> fpShotSlices;

					public string PrimaryKey
					{
						get
						{
							return primaryKey;
						}
						set	
						{
							primaryKey = value;
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

					public List<QueryFpShotJobList_FpShotSlice> FpShotSlices
					{
						get
						{
							return fpShotSlices;
						}
						set	
						{
							fpShotSlices = value;
						}
					}

					public class QueryFpShotJobList_FpShotSlice
					{

						private QueryFpShotJobList_Input input;

						private QueryFpShotJobList_Duplication duplication;

						public QueryFpShotJobList_Input Input
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

						public QueryFpShotJobList_Duplication Duplication
						{
							get
							{
								return duplication;
							}
							set	
							{
								duplication = value;
							}
						}

						public class QueryFpShotJobList_Input
						{

							private string start;

							private string duration;

							public string Start
							{
								get
								{
									return start;
								}
								set	
								{
									start = value;
								}
							}

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
						}

						public class QueryFpShotJobList_Duplication
						{

							private string start;

							private string duration;

							public string Start
							{
								get
								{
									return start;
								}
								set	
								{
									start = value;
								}
							}

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
						}
					}
				}
			}
		}
	}
}