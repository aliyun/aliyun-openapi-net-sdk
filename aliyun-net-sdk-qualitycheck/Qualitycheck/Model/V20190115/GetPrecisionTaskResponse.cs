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
	public class GetPrecisionTaskResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private GetPrecisionTask_Data data;

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

			private int? status;

			private string updateTime;

			private int? incorrectWords;

			private long? dataSetId;

			private int? verifiedCount;

			private int? duration;

			private string dataSetName;

			private int? totalCount;

			private int? source;

			private string name;

			private string taskId;

			private List<GetPrecisionTask_Precision> precisions;

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

				private int? status;

				private string modelName;

				private string taskId;

				private float? precision;

				private long? modelId;

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
			}
		}
	}
}
