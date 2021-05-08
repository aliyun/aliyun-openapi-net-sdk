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

namespace Aliyun.Acs.dataworks_public.Model.V20200518
{
	public class GetInstanceStatusStatisticResponse : AcsResponse
	{

		private string requestId;

		private GetInstanceStatusStatistic_StatusCount statusCount;

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

		public GetInstanceStatusStatistic_StatusCount StatusCount
		{
			get
			{
				return statusCount;
			}
			set	
			{
				statusCount = value;
			}
		}

		public class GetInstanceStatusStatistic_StatusCount
		{

			private int? totalCount;

			private int? notRunCount;

			private int? waitTimeCount;

			private int? waitResCount;

			private int? runningCount;

			private int? failureCount;

			private int? successCount;

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

			public int? NotRunCount
			{
				get
				{
					return notRunCount;
				}
				set	
				{
					notRunCount = value;
				}
			}

			public int? WaitTimeCount
			{
				get
				{
					return waitTimeCount;
				}
				set	
				{
					waitTimeCount = value;
				}
			}

			public int? WaitResCount
			{
				get
				{
					return waitResCount;
				}
				set	
				{
					waitResCount = value;
				}
			}

			public int? RunningCount
			{
				get
				{
					return runningCount;
				}
				set	
				{
					runningCount = value;
				}
			}

			public int? FailureCount
			{
				get
				{
					return failureCount;
				}
				set	
				{
					failureCount = value;
				}
			}

			public int? SuccessCount
			{
				get
				{
					return successCount;
				}
				set	
				{
					successCount = value;
				}
			}
		}
	}
}
