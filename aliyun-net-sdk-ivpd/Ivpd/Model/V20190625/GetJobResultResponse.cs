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
	public class GetJobResultResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private GetJobResult_Data data;

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

		public GetJobResult_Data Data
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

		public class GetJobResult_Data
		{

			private string status;

			private string batchSize;

			private bool? finish;

			private float? progress;

			private string message;

			private bool? completed;

			private long? totalUsedTime;

			private List<Dictionary<string, string>> resultList;

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

			public string BatchSize
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

			public bool? Finish
			{
				get
				{
					return finish;
				}
				set	
				{
					finish = value;
				}
			}

			public float? Progress
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

			public List<Dictionary<string, string>> ResultList
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
		}
	}
}
