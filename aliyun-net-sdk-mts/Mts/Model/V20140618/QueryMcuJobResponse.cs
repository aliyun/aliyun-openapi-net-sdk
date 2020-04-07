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
	public class QueryMcuJobResponse : AcsResponse
	{

		private string requestId;

		private List<QueryMcuJob_Job> jobResult;

		private List<string> nonExistJobIds;

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

		public List<QueryMcuJob_Job> JobResult
		{
			get
			{
				return jobResult;
			}
			set	
			{
				jobResult = value;
			}
		}

		public List<string> NonExistJobIds
		{
			get
			{
				return nonExistJobIds;
			}
			set	
			{
				nonExistJobIds = value;
			}
		}

		public class QueryMcuJob_Job
		{

			private string jobId;

			private string userData;

			private string templateId;

			private string template;

			private List<QueryMcuJob_Ocr> ocrResult;

			private List<QueryMcuJob_Tag> tagResult;

			private List<QueryMcuJob_Face> faceResult;

			private List<QueryMcuJob_SubTask> subTaskInfo;

			private QueryMcuJob_Input input;

			private QueryMcuJob_AsrResult asrResult;

			private QueryMcuJob_CategoryResult categoryResult;

			public string JobId
			{
				get
				{
					return jobId;
				}
				set	
				{
					jobId = value;
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

			public string TemplateId
			{
				get
				{
					return templateId;
				}
				set	
				{
					templateId = value;
				}
			}

			public string Template
			{
				get
				{
					return template;
				}
				set	
				{
					template = value;
				}
			}

			public List<QueryMcuJob_Ocr> OcrResult
			{
				get
				{
					return ocrResult;
				}
				set	
				{
					ocrResult = value;
				}
			}

			public List<QueryMcuJob_Tag> TagResult
			{
				get
				{
					return tagResult;
				}
				set	
				{
					tagResult = value;
				}
			}

			public List<QueryMcuJob_Face> FaceResult
			{
				get
				{
					return faceResult;
				}
				set	
				{
					faceResult = value;
				}
			}

			public List<QueryMcuJob_SubTask> SubTaskInfo
			{
				get
				{
					return subTaskInfo;
				}
				set	
				{
					subTaskInfo = value;
				}
			}

			public QueryMcuJob_Input Input
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

			public QueryMcuJob_AsrResult AsrResult
			{
				get
				{
					return asrResult;
				}
				set	
				{
					asrResult = value;
				}
			}

			public QueryMcuJob_CategoryResult CategoryResult
			{
				get
				{
					return categoryResult;
				}
				set	
				{
					categoryResult = value;
				}
			}

			public class QueryMcuJob_Ocr
			{

				private string time;

				private string ocrText;

				private string imageUrl;

				private string imageId;

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

				public string ImageId
				{
					get
					{
						return imageId;
					}
					set	
					{
						imageId = value;
					}
				}
			}

			public class QueryMcuJob_Tag
			{

				private string time;

				private string imageUrl;

				private string imageId;

				private List<QueryMcuJob_FrameTagInfo> frameTagInfos;

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

				public string ImageId
				{
					get
					{
						return imageId;
					}
					set	
					{
						imageId = value;
					}
				}

				public List<QueryMcuJob_FrameTagInfo> FrameTagInfos
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

				public class QueryMcuJob_FrameTagInfo
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

			public class QueryMcuJob_Face
			{

				private string time;

				private string imageUrl;

				private string imageId;

				private List<QueryMcuJob_Celebrity> celebrities;

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

				public string ImageId
				{
					get
					{
						return imageId;
					}
					set	
					{
						imageId = value;
					}
				}

				public List<QueryMcuJob_Celebrity> Celebrities
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

				public class QueryMcuJob_Celebrity
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

			public class QueryMcuJob_SubTask
			{

				private string type;

				private string code;

				private string message;

				public string Type
				{
					get
					{
						return type;
					}
					set	
					{
						type = value;
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
			}

			public class QueryMcuJob_Input
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

			public class QueryMcuJob_AsrResult
			{

				private string duration;

				private List<QueryMcuJob_AsrText> asrTextList;

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

				public List<QueryMcuJob_AsrText> AsrTextList
				{
					get
					{
						return asrTextList;
					}
					set	
					{
						asrTextList = value;
					}
				}

				public class QueryMcuJob_AsrText
				{

					private int? startTime;

					private string endTime;

					private string channelId;

					private string speechRate;

					private string text;

					public int? StartTime
					{
						get
						{
							return startTime;
						}
						set	
						{
							startTime = value;
						}
					}

					public string EndTime
					{
						get
						{
							return endTime;
						}
						set	
						{
							endTime = value;
						}
					}

					public string ChannelId
					{
						get
						{
							return channelId;
						}
						set	
						{
							channelId = value;
						}
					}

					public string SpeechRate
					{
						get
						{
							return speechRate;
						}
						set	
						{
							speechRate = value;
						}
					}

					public string Text
					{
						get
						{
							return text;
						}
						set	
						{
							text = value;
						}
					}
				}
			}

			public class QueryMcuJob_CategoryResult
			{

				private string details;

				private List<QueryMcuJob_Category> categories;

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

				public List<QueryMcuJob_Category> Categories
				{
					get
					{
						return categories;
					}
					set	
					{
						categories = value;
					}
				}

				public class QueryMcuJob_Category
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
			}
		}
	}
}
