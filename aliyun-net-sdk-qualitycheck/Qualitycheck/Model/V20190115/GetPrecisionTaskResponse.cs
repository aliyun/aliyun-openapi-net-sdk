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
	public class GetPrecisionTaskResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private GetPrecisionTask_Data data;

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

		public GetPrecisionTask_Data Data
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

		public class GetPrecisionTask_Data
		{

			private string name;

			private int? source;

			private long? dataSetId;

			private string dataSetName;

			private string taskId;

			private int? duration;

			private string updateTime;

			private int? status;

			private int? totalCount;

			private int? verifiedCount;

			private int? incorrectWords;

			private List<GetPrecisionTask_Precision> precisions;

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

			public List<GetPrecisionTask_Precision> Precisions
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

			public class GetPrecisionTask_Precision
			{

				private string modelName;

				private long? modelId;

				private float? precision;

				private int? status;

				private string taskId;

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
			}
		}
	}
}
