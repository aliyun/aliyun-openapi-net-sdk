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

namespace Aliyun.Acs.AiContent.Model.V20240611
{
	public class AliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string errCode;

		private string errMessage;

		private List<AliyunConsoleOpenApiQueryAliyunConsoleServcieList_DataItem> data;

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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public string ErrCode
		{
			get
			{
				return errCode;
			}
			set	
			{
				errCode = value;
			}
		}

		public string ErrMessage
		{
			get
			{
				return errMessage;
			}
			set	
			{
				errMessage = value;
			}
		}

		public List<AliyunConsoleOpenApiQueryAliyunConsoleServcieList_DataItem> Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class AliyunConsoleOpenApiQueryAliyunConsoleServcieList_DataItem
		{

			private string id;

			private string modelId;

			private string name;

			private string objectType;

			private string jobStatus;

			private double? jobTrainProgress;

			private int? inferenceImageCount;

			private string createTime;

			private List<AliyunConsoleOpenApiQueryAliyunConsoleServcieList_InferenceJobListItem> inferenceJobList;

			private List<string> imageUrl;

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

			public string ModelId
			{
				get
				{
					return modelId;
				}
				set	
				{
					modelId = value;
				}
			}

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

			public string ObjectType
			{
				get
				{
					return objectType;
				}
				set	
				{
					objectType = value;
				}
			}

			public string JobStatus
			{
				get
				{
					return jobStatus;
				}
				set	
				{
					jobStatus = value;
				}
			}

			public double? JobTrainProgress
			{
				get
				{
					return jobTrainProgress;
				}
				set	
				{
					jobTrainProgress = value;
				}
			}

			public int? InferenceImageCount
			{
				get
				{
					return inferenceImageCount;
				}
				set	
				{
					inferenceImageCount = value;
				}
			}

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public List<AliyunConsoleOpenApiQueryAliyunConsoleServcieList_InferenceJobListItem> InferenceJobList
			{
				get
				{
					return inferenceJobList;
				}
				set	
				{
					inferenceJobList = value;
				}
			}

			public List<string> ImageUrl
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

			public class AliyunConsoleOpenApiQueryAliyunConsoleServcieList_InferenceJobListItem
			{

				private string id;

				private string promptId;

				private string modelId;

				private string jobStatus;

				private double? jobTrainProgress;

				private string createTime;

				private List<string> resultImageUrl;

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

				public string PromptId
				{
					get
					{
						return promptId;
					}
					set	
					{
						promptId = value;
					}
				}

				public string ModelId
				{
					get
					{
						return modelId;
					}
					set	
					{
						modelId = value;
					}
				}

				public string JobStatus
				{
					get
					{
						return jobStatus;
					}
					set	
					{
						jobStatus = value;
					}
				}

				public double? JobTrainProgress
				{
					get
					{
						return jobTrainProgress;
					}
					set	
					{
						jobTrainProgress = value;
					}
				}

				public string CreateTime
				{
					get
					{
						return createTime;
					}
					set	
					{
						createTime = value;
					}
				}

				public List<string> ResultImageUrl
				{
					get
					{
						return resultImageUrl;
					}
					set	
					{
						resultImageUrl = value;
					}
				}
			}
		}
	}
}
