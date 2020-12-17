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

			private long? taskConfigId;

			private string name;

			private int? status;

			private int? type;

			private string startTime;

			private int? timeInterval;

			private int? timeUnit;

			private string endTime;

			private int? instanceStatus;

			private string lastExecutionTime;

			private string message;

			private ListHotWordsTasks_DialogueParam dialogueParam;

			private ListHotWordsTasks_WordsParam wordsParam;

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

				private long? dialogueId;

				private int? role;

				private int? startIndex;

				private int? endIndex;

				private int? sourceType;

				private string dataSetIds;

				private string startTime;

				private string endTime;

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
			}

			public class ListHotWordsTasks_WordsParam
			{

				private long? extraConfigId;

				private string excludes;

				private string includes;

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
			}
		}
	}
}
