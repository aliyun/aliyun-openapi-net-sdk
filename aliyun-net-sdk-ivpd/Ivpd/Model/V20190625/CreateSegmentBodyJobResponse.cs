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

namespace Aliyun.Acs.ivpd.Model.V20190625
{
	public class CreateSegmentBodyJobResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private CreateSegmentBodyJob_Data data;

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

		public CreateSegmentBodyJob_Data Data
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

		public class CreateSegmentBodyJob_Data
		{

			private string status;

			private bool? completed;

			private int? batchSize;

			private long? totalUsedTime;

			private int? progress;

			private string jobId;

			private List<CreateSegmentBodyJob_Result> resultList;

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

			public bool? Completed
			{
				get
				{
					return completed;
				}
				set	
				{
					completed = value;
				}
			}

			public int? BatchSize
			{
				get
				{
					return batchSize;
				}
				set	
				{
					batchSize = value;
				}
			}

			public long? TotalUsedTime
			{
				get
				{
					return totalUsedTime;
				}
				set	
				{
					totalUsedTime = value;
				}
			}

			public int? Progress
			{
				get
				{
					return progress;
				}
				set	
				{
					progress = value;
				}
			}

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

			public List<CreateSegmentBodyJob_Result> ResultList
			{
				get
				{
					return resultList;
				}
				set	
				{
					resultList = value;
				}
			}

			public class CreateSegmentBodyJob_Result
			{

				private string dataId;

				private bool? success;

				private string code;

				private string message;

				private CreateSegmentBodyJob_ResultData resultData;

				public string DataId
				{
					get
					{
						return dataId;
					}
					set	
					{
						dataId = value;
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

				public CreateSegmentBodyJob_ResultData ResultData
				{
					get
					{
						return resultData;
					}
					set	
					{
						resultData = value;
					}
				}

				public class CreateSegmentBodyJob_ResultData
				{

					private string imageUrl;

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
				}
			}
		}
	}
}
