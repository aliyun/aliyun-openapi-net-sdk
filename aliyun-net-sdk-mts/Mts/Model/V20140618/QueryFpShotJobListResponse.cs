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
	public class QueryFpShotJobListResponse : AcsResponse
	{

		private string requestId;

		private string nextPageToken;

		private List<QueryFpShotJobList_FpShotJob> fpShotJobList;

		private List<string> nonExistPrimaryKeys;

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

		public List<string> NonExistPrimaryKeys
		{
			get
			{
				return nonExistPrimaryKeys;
			}
			set	
			{
				nonExistPrimaryKeys = value;
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

			private string creationTime;

			private string finishTime;

			private string state;

			private string message;

			private string txHash;

			private string transactionId;

			private string fileId;

			private string userData;

			private int? duration;

			private string code;

			private string pipelineId;

			private string id;

			private string input;

			private QueryFpShotJobList_FpShotResult fpShotResult;

			private QueryFpShotJobList_FpShotConfig fpShotConfig;

			private QueryFpShotJobList_InputFile inputFile;

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

			public string TxHash
			{
				get
				{
					return txHash;
				}
				set	
				{
					txHash = value;
				}
			}

			public string TransactionId
			{
				get
				{
					return transactionId;
				}
				set	
				{
					transactionId = value;
				}
			}

			public string FileId
			{
				get
				{
					return fileId;
				}
				set	
				{
					fileId = value;
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

			public int? Duration
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

			public string Input
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

			public QueryFpShotJobList_FpShotConfig FpShotConfig
			{
				get
				{
					return fpShotConfig;
				}
				set	
				{
					fpShotConfig = value;
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

			public class QueryFpShotJobList_FpShotResult
			{

				private List<QueryFpShotJobList_FpShot> audioFpShots;

				private List<QueryFpShotJobList_FpShot> fpShots;

				private List<QueryFpShotJobList_TextFpShot> textFpShots;

				public List<QueryFpShotJobList_FpShot> AudioFpShots
				{
					get
					{
						return audioFpShots;
					}
					set	
					{
						audioFpShots = value;
					}
				}

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

				public List<QueryFpShotJobList_TextFpShot> TextFpShots
				{
					get
					{
						return textFpShots;
					}
					set	
					{
						textFpShots = value;
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

						private string similarity;

						private QueryFpShotJobList_Duplication duplication;

						private QueryFpShotJobList_Input input;

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
					}
				}

				public class QueryFpShotJobList_TextFpShot
				{

					private string primaryKey;

					private string similarity;

					private List<QueryFpShotJobList_TextFpShotSlice> textFpShotSlices;

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

					public List<QueryFpShotJobList_TextFpShotSlice> TextFpShotSlices
					{
						get
						{
							return textFpShotSlices;
						}
						set	
						{
							textFpShotSlices = value;
						}
					}

					public class QueryFpShotJobList_TextFpShotSlice
					{

						private string similarity;

						private string inputText;

						private string duplicationText;

						private QueryFpShotJobList_InputFragment inputFragment;

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

						public string InputText
						{
							get
							{
								return inputText;
							}
							set	
							{
								inputText = value;
							}
						}

						public string DuplicationText
						{
							get
							{
								return duplicationText;
							}
							set	
							{
								duplicationText = value;
							}
						}

						public QueryFpShotJobList_InputFragment InputFragment
						{
							get
							{
								return inputFragment;
							}
							set	
							{
								inputFragment = value;
							}
						}

						public class QueryFpShotJobList_InputFragment
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

			public class QueryFpShotJobList_FpShotConfig
			{

				private string primaryKey;

				private string saveType;

				private string notary;

				private string fpDBId;

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

				public string SaveType
				{
					get
					{
						return saveType;
					}
					set	
					{
						saveType = value;
					}
				}

				public string Notary
				{
					get
					{
						return notary;
					}
					set	
					{
						notary = value;
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
			}

			public class QueryFpShotJobList_InputFile
			{

				private string _object;

				private string location;

				private string bucket;

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
