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
	public class GetSpeechModelPushJobStatisticsResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string errorMessage;

		private GetSpeechModelPushJobStatistics_Data data;

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

		public GetSpeechModelPushJobStatistics_Data Data
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

		public class GetSpeechModelPushJobStatistics_Data
		{

			private int? totalNum;

			private int? successNum;

			private int? timeoutNum;

			private int? cancelNum;

			private int? runningNum;

			public int? TotalNum
			{
				get
				{
					return totalNum;
				}
				set	
				{
					totalNum = value;
				}
			}

			public int? SuccessNum
			{
				get
				{
					return successNum;
				}
				set	
				{
					successNum = value;
				}
			}

			public int? TimeoutNum
			{
				get
				{
					return timeoutNum;
				}
				set	
				{
					timeoutNum = value;
				}
			}

			public int? CancelNum
			{
				get
				{
					return cancelNum;
				}
				set	
				{
					cancelNum = value;
				}
			}

			public int? RunningNum
			{
				get
				{
					return runningNum;
				}
				set	
				{
					runningNum = value;
				}
			}
		}
	}
}
