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
	public class QueryMediaDetailJobListResponse : AcsResponse
	{

		private string requestId;

		private List<QueryMediaDetailJobList_Job> jobList;

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

		public List<QueryMediaDetailJobList_Job> JobList
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

		public class QueryMediaDetailJobList_Job
		{

			private string id;

			private string userData;

			private string pipelineId;

			private string state;

			private string code;

			private string message;

			private string creationTime;

			private QueryMediaDetailJobList_Input input;

			private QueryMediaDetailJobList_MediaDetailConfig mediaDetailConfig;

			private QueryMediaDetailJobList_MediaDetailResult mediaDetailResult;

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

			public QueryMediaDetailJobList_Input Input
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

			public QueryMediaDetailJobList_MediaDetailConfig MediaDetailConfig
			{
				get
				{
					return mediaDetailConfig;
				}
				set	
				{
					mediaDetailConfig = value;
				}
			}

			public QueryMediaDetailJobList_MediaDetailResult MediaDetailResult
			{
				get
				{
					return mediaDetailResult;
				}
				set	
				{
					mediaDetailResult = value;
				}
			}

			public class QueryMediaDetailJobList_Input
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

			public class QueryMediaDetailJobList_MediaDetailConfig
			{

				private string scenario;

				private string detailType;

				private QueryMediaDetailJobList_OutputFile outputFile;

				public string Scenario
				{
					get
					{
						return scenario;
					}
					set	
					{
						scenario = value;
					}
				}

				public string DetailType
				{
					get
					{
						return detailType;
					}
					set	
					{
						detailType = value;
					}
				}

				public QueryMediaDetailJobList_OutputFile OutputFile
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

				public class QueryMediaDetailJobList_OutputFile
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

			public class QueryMediaDetailJobList_MediaDetailResult
			{

				private string status;

				private List<QueryMediaDetailJobList_MediaDetailRecgResult> mediaDetailRecgResults;

				private List<string> tags;

				public string Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}

				public List<QueryMediaDetailJobList_MediaDetailRecgResult> MediaDetailRecgResults
				{
					get
					{
						return mediaDetailRecgResults;
					}
					set	
					{
						mediaDetailRecgResults = value;
					}
				}

				public List<string> Tags
				{
					get
					{
						return tags;
					}
					set	
					{
						tags = value;
					}
				}

				public class QueryMediaDetailJobList_MediaDetailRecgResult
				{

					private string imageUrl;

					private string time;

					private string ocrText;

					private List<QueryMediaDetailJobList_Celebrity> celebrities;

					private List<QueryMediaDetailJobList_Sensitive> sensitives;

					private List<QueryMediaDetailJobList_Politician> politicians;

					private List<QueryMediaDetailJobList_FrameTagInfo> frameTagInfos;

					private List<string> frameTags;

					public string ImageUrl
					{
						get
						{
							return imageUrl;
						}
						set	
						{
							imageUrl = value;
						}
					}

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

					public string OcrText
					{
						get
						{
							return ocrText;
						}
						set	
						{
							ocrText = value;
						}
					}

					public List<QueryMediaDetailJobList_Celebrity> Celebrities
					{
						get
						{
							return celebrities;
						}
						set	
						{
							celebrities = value;
						}
					}

					public List<QueryMediaDetailJobList_Sensitive> Sensitives
					{
						get
						{
							return sensitives;
						}
						set	
						{
							sensitives = value;
						}
					}

					public List<QueryMediaDetailJobList_Politician> Politicians
					{
						get
						{
							return politicians;
						}
						set	
						{
							politicians = value;
						}
					}

					public List<QueryMediaDetailJobList_FrameTagInfo> FrameTagInfos
					{
						get
						{
							return frameTagInfos;
						}
						set	
						{
							frameTagInfos = value;
						}
					}

					public List<string> FrameTags
					{
						get
						{
							return frameTags;
						}
						set	
						{
							frameTags = value;
						}
					}

					public class QueryMediaDetailJobList_Celebrity
					{

						private string name;

						private string score;

						private string target;

						public string Name
						{
							get
							{
								return name;
							}
							set	
							{
								name = value;
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

						public string Target
						{
							get
							{
								return target;
							}
							set	
							{
								target = value;
							}
						}
					}

					public class QueryMediaDetailJobList_Sensitive
					{

						private string name;

						private string score;

						private string target;

						public string Name
						{
							get
							{
								return name;
							}
							set	
							{
								name = value;
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

						public string Target
						{
							get
							{
								return target;
							}
							set	
							{
								target = value;
							}
						}
					}

					public class QueryMediaDetailJobList_Politician
					{

						private string name;

						private string score;

						private string target;

						public string Name
						{
							get
							{
								return name;
							}
							set	
							{
								name = value;
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

						public string Target
						{
							get
							{
								return target;
							}
							set	
							{
								target = value;
							}
						}
					}

					public class QueryMediaDetailJobList_FrameTagInfo
					{

						private string tag;

						private string score;

						private string category;

						public string Tag
						{
							get
							{
								return tag;
							}
							set	
							{
								tag = value;
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

						public string Category
						{
							get
							{
								return category;
							}
							set	
							{
								category = value;
							}
						}
					}
				}
			}
		}
	}
}