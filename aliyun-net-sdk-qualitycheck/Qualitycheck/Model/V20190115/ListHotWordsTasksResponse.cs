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

namespace Aliyun.Acs.Qualitycheck.Model.V20190115
{
	public class ListHotWordsTasksResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? pageNumber;

		private int? pageSize;

		private int? count;

		private List<ListHotWordsTasks_HotWordsTaskPo> data;

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

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

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

		public List<ListHotWordsTasks_HotWordsTaskPo> Data
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

		public class ListHotWordsTasks_HotWordsTaskPo
		{

			private string endTime;

			private int? type;

			private int? status;

			private int? timeInterval;

			private string startTime;

			private long? taskConfigId;

			private string message;

			private int? instanceStatus;

			private string lastExecutionTime;

			private string name;

			private int? timeUnit;

			private ListHotWordsTasks_DialogueParam dialogueParam;

			private ListHotWordsTasks_WordsParam wordsParam;

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

			public int? Type
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

			public int? Status
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

			public int? TimeInterval
			{
				get
				{
					return timeInterval;
				}
				set	
				{
					timeInterval = value;
				}
			}

			public string StartTime
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

			public long? TaskConfigId
			{
				get
				{
					return taskConfigId;
				}
				set	
				{
					taskConfigId = value;
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

			public int? InstanceStatus
			{
				get
				{
					return instanceStatus;
				}
				set	
				{
					instanceStatus = value;
				}
			}

			public string LastExecutionTime
			{
				get
				{
					return lastExecutionTime;
				}
				set	
				{
					lastExecutionTime = value;
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

			public int? TimeUnit
			{
				get
				{
					return timeUnit;
				}
				set	
				{
					timeUnit = value;
				}
			}

			public ListHotWordsTasks_DialogueParam DialogueParam
			{
				get
				{
					return dialogueParam;
				}
				set	
				{
					dialogueParam = value;
				}
			}

			public ListHotWordsTasks_WordsParam WordsParam
			{
				get
				{
					return wordsParam;
				}
				set	
				{
					wordsParam = value;
				}
			}

			public class ListHotWordsTasks_DialogueParam
			{

				private string endTime;

				private long? dialogueId;

				private int? endIndex;

				private string startTime;

				private int? sourceType;

				private int? startIndex;

				private int? role;

				private string dataSetIds;

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

				public long? DialogueId
				{
					get
					{
						return dialogueId;
					}
					set	
					{
						dialogueId = value;
					}
				}

				public int? EndIndex
				{
					get
					{
						return endIndex;
					}
					set	
					{
						endIndex = value;
					}
				}

				public string StartTime
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

				public int? SourceType
				{
					get
					{
						return sourceType;
					}
					set	
					{
						sourceType = value;
					}
				}

				public int? StartIndex
				{
					get
					{
						return startIndex;
					}
					set	
					{
						startIndex = value;
					}
				}

				public int? Role
				{
					get
					{
						return role;
					}
					set	
					{
						role = value;
					}
				}

				public string DataSetIds
				{
					get
					{
						return dataSetIds;
					}
					set	
					{
						dataSetIds = value;
					}
				}
			}

			public class ListHotWordsTasks_WordsParam
			{

				private string excludes;

				private string includes;

				private long? extraConfigId;

				public string Excludes
				{
					get
					{
						return excludes;
					}
					set	
					{
						excludes = value;
					}
				}

				public string Includes
				{
					get
					{
						return includes;
					}
					set	
					{
						includes = value;
					}
				}

				public long? ExtraConfigId
				{
					get
					{
						return extraConfigId;
					}
					set	
					{
						extraConfigId = value;
					}
				}
			}
		}
	}
}
