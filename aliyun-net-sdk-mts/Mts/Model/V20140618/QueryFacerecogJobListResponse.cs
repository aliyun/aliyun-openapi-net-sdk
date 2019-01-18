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
	public class QueryFacerecogJobListResponse : AcsResponse
	{

		private string requestId;

		private List<QueryFacerecogJobList_FacerecogJob> facerecogJobList;

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

		public List<QueryFacerecogJobList_FacerecogJob> FacerecogJobList
		{
			get
			{
				return facerecogJobList;
			}
			set	
			{
				facerecogJobList = value;
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

		public class QueryFacerecogJobList_FacerecogJob
		{

			private string id;

			private string userData;

			private string pipelineId;

			private string state;

			private string code;

			private string message;

			private string creationTime;

			private QueryFacerecogJobList_Input input;

			private QueryFacerecogJobList_VideoFacerecogResult videoFacerecogResult;

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

			public QueryFacerecogJobList_Input Input
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

			public QueryFacerecogJobList_VideoFacerecogResult VideoFacerecogResult
			{
				get
				{
					return videoFacerecogResult;
				}
				set	
				{
					videoFacerecogResult = value;
				}
			}

			public class QueryFacerecogJobList_Input
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

			public class QueryFacerecogJobList_VideoFacerecogResult
			{

				private List<QueryFacerecogJobList_Facerecog> facerecogs;

				public List<QueryFacerecogJobList_Facerecog> Facerecogs
				{
					get
					{
						return facerecogs;
					}
					set	
					{
						facerecogs = value;
					}
				}

				public class QueryFacerecogJobList_Facerecog
				{

					private string time;

					private List<QueryFacerecogJobList_Face> faces;

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

					public List<QueryFacerecogJobList_Face> Faces
					{
						get
						{
							return faces;
						}
						set	
						{
							faces = value;
						}
					}

					public class QueryFacerecogJobList_Face
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