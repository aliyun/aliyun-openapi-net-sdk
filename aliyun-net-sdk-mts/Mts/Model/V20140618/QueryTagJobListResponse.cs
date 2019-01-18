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
	public class QueryTagJobListResponse : AcsResponse
	{

		private string requestId;

		private List<QueryTagJobList_TagJob> tagJobList;

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

		public List<QueryTagJobList_TagJob> TagJobList
		{
			get
			{
				return tagJobList;
			}
			set	
			{
				tagJobList = value;
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

		public class QueryTagJobList_TagJob
		{

			private string id;

			private string userData;

			private string pipelineId;

			private string state;

			private string code;

			private string message;

			private string creationTime;

			private QueryTagJobList_Input input;

			private QueryTagJobList_VideoTagResult videoTagResult;

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

			public QueryTagJobList_Input Input
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

			public QueryTagJobList_VideoTagResult VideoTagResult
			{
				get
				{
					return videoTagResult;
				}
				set	
				{
					videoTagResult = value;
				}
			}

			public class QueryTagJobList_Input
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

			public class QueryTagJobList_VideoTagResult
			{

				private string details;

				private List<QueryTagJobList_TagAnResult> tagAnResults;

				private List<QueryTagJobList_TagFrResult> tagFrResults;

				public string Details
				{
					get
					{
						return details;
					}
					set	
					{
						details = value;
					}
				}

				public List<QueryTagJobList_TagAnResult> TagAnResults
				{
					get
					{
						return tagAnResults;
					}
					set	
					{
						tagAnResults = value;
					}
				}

				public List<QueryTagJobList_TagFrResult> TagFrResults
				{
					get
					{
						return tagFrResults;
					}
					set	
					{
						tagFrResults = value;
					}
				}

				public class QueryTagJobList_TagAnResult
				{

					private string label;

					private string score;

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
				}

				public class QueryTagJobList_TagFrResult
				{

					private string time;

					private List<QueryTagJobList_TagFace> tagFaces;

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

					public List<QueryTagJobList_TagFace> TagFaces
					{
						get
						{
							return tagFaces;
						}
						set	
						{
							tagFaces = value;
						}
					}

					public class QueryTagJobList_TagFace
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
				}
			}
		}
	}
}