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

namespace Aliyun.Acs.foas.Model.V20181111
{
	public class BatchGetInstanceRunSummaryResponse : AcsResponse
	{

		private string requestId;

		private List<BatchGetInstanceRunSummary_RunSummary> runSummarys;

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

		public List<BatchGetInstanceRunSummary_RunSummary> RunSummarys
		{
			get
			{
				return runSummarys;
			}
			set	
			{
				runSummarys = value;
			}
		}

		public class BatchGetInstanceRunSummary_RunSummary
		{

			private long? id;

			private string actualState;

			private string expectState;

			private long? lastErrorTime;

			private string lastErrorMessage;

			private string engineJobHandler;

			private long? inputDelay;

			private string jobName;

			public long? Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public string ActualState
			{
				get
				{
					return actualState;
				}
				set	
				{
					actualState = value;
				}
			}

			public string ExpectState
			{
				get
				{
					return expectState;
				}
				set	
				{
					expectState = value;
				}
			}

			public long? LastErrorTime
			{
				get
				{
					return lastErrorTime;
				}
				set	
				{
					lastErrorTime = value;
				}
			}

			public string LastErrorMessage
			{
				get
				{
					return lastErrorMessage;
				}
				set	
				{
					lastErrorMessage = value;
				}
			}

			public string EngineJobHandler
			{
				get
				{
					return engineJobHandler;
				}
				set	
				{
					engineJobHandler = value;
				}
			}

			public long? InputDelay
			{
				get
				{
					return inputDelay;
				}
				set	
				{
					inputDelay = value;
				}
			}

			public string JobName
			{
				get
				{
					return jobName;
				}
				set	
				{
					jobName = value;
				}
			}
		}
	}
}
