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
	public class ListPrecisionTaskResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? pageNumber;

		private int? pageSize;

		private int? count;

		private List<ListPrecisionTask_PrecisionTask> data;

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

		public List<ListPrecisionTask_PrecisionTask> Data
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

		public class ListPrecisionTask_PrecisionTask
		{

			private string name;

			private string taskId;

			private int? source;

			private long? dataSetId;

			private string dataSetName;

			private int? duration;

			private int? status;

			private int? totalCount;

			private int? verifiedCount;

			private int? incorrectWords;

			private string createTime;

			private string updateTime;

			private List<ListPrecisionTask_Precision> precisions;

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

			public string TaskId
			{
				get
				{
					return taskId;
				}
				set	
				{
					taskId = value;
				}
			}

			public int? Source
			{
				get
				{
					return source;
				}
				set	
				{
					source = value;
				}
			}

			public long? DataSetId
			{
				get
				{
					return dataSetId;
				}
				set	
				{
					dataSetId = value;
				}
			}

			public string DataSetName
			{
				get
				{
					return dataSetName;
				}
				set	
				{
					dataSetName = value;
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

			public int? TotalCount
			{
				get
				{
					return totalCount;
				}
				set	
				{
					totalCount = value;
				}
			}

			public int? VerifiedCount
			{
				get
				{
					return verifiedCount;
				}
				set	
				{
					verifiedCount = value;
				}
			}

			public int? IncorrectWords
			{
				get
				{
					return incorrectWords;
				}
				set	
				{
					incorrectWords = value;
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

			public string UpdateTime
			{
				get
				{
					return updateTime;
				}
				set	
				{
					updateTime = value;
				}
			}

			public List<ListPrecisionTask_Precision> Precisions
			{
				get
				{
					return precisions;
				}
				set	
				{
					precisions = value;
				}
			}

			public class ListPrecisionTask_Precision
			{

				private string modelName;

				private long? modelId;

				private float? precision;

				private int? status;

				private string taskId;

				private string createTime;

				public string ModelName
				{
					get
					{
						return modelName;
					}
					set	
					{
						modelName = value;
					}
				}

				public long? ModelId
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

				public float? Precision
				{
					get
					{
						return precision;
					}
					set	
					{
						precision = value;
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

				public string TaskId
				{
					get
					{
						return taskId;
					}
					set	
					{
						taskId = value;
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
			}
		}
	}
}
