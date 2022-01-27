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

namespace Aliyun.Acs.Iot.Model.V20180120
{
	public class QueryJobStatisticsResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string errorMessage;

		private QueryJobStatistics_Data data;

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

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

		public QueryJobStatistics_Data Data
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

		public class QueryJobStatistics_Data
		{

			private int? total;

			private int? queued;

			private int? sent;

			private int? inProgress;

			private int? succeeded;

			private int? failed;

			private int? rejected;

			private int? timeOut;

			private int? cancelled;

			public int? Total
			{
				get
				{
					return total;
				}
				set	
				{
					total = value;
				}
			}

			public int? Queued
			{
				get
				{
					return queued;
				}
				set	
				{
					queued = value;
				}
			}

			public int? Sent
			{
				get
				{
					return sent;
				}
				set	
				{
					sent = value;
				}
			}

			public int? InProgress
			{
				get
				{
					return inProgress;
				}
				set	
				{
					inProgress = value;
				}
			}

			public int? Succeeded
			{
				get
				{
					return succeeded;
				}
				set	
				{
					succeeded = value;
				}
			}

			public int? Failed
			{
				get
				{
					return failed;
				}
				set	
				{
					failed = value;
				}
			}

			public int? Rejected
			{
				get
				{
					return rejected;
				}
				set	
				{
					rejected = value;
				}
			}

			public int? TimeOut
			{
				get
				{
					return timeOut;
				}
				set	
				{
					timeOut = value;
				}
			}

			public int? Cancelled
			{
				get
				{
					return cancelled;
				}
				set	
				{
					cancelled = value;
				}
			}
		}
	}
}
