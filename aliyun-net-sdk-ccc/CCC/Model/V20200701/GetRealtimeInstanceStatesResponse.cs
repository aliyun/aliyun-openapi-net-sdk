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

namespace Aliyun.Acs.CCC.Model.V20200701
{
	public class GetRealtimeInstanceStatesResponse : AcsResponse
	{

		private string code;

		private int? httpStatusCode;

		private string message;

		private string requestId;

		private GetRealtimeInstanceStates_Data data;

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

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
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

		public GetRealtimeInstanceStates_Data Data
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

		public class GetRealtimeInstanceStates_Data
		{

			private long? breakingAgents;

			private string instanceId;

			private long? interactiveCalls;

			private long? loggedInAgents;

			private long? longestCall;

			private long? readyAgents;

			private long? talkingAgents;

			private long? totalAgents;

			private long? waitingCalls;

			private long? workingAgents;

			public long? BreakingAgents
			{
				get
				{
					return breakingAgents;
				}
				set	
				{
					breakingAgents = value;
				}
			}

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public long? InteractiveCalls
			{
				get
				{
					return interactiveCalls;
				}
				set	
				{
					interactiveCalls = value;
				}
			}

			public long? LoggedInAgents
			{
				get
				{
					return loggedInAgents;
				}
				set	
				{
					loggedInAgents = value;
				}
			}

			public long? LongestCall
			{
				get
				{
					return longestCall;
				}
				set	
				{
					longestCall = value;
				}
			}

			public long? ReadyAgents
			{
				get
				{
					return readyAgents;
				}
				set	
				{
					readyAgents = value;
				}
			}

			public long? TalkingAgents
			{
				get
				{
					return talkingAgents;
				}
				set	
				{
					talkingAgents = value;
				}
			}

			public long? TotalAgents
			{
				get
				{
					return totalAgents;
				}
				set	
				{
					totalAgents = value;
				}
			}

			public long? WaitingCalls
			{
				get
				{
					return waitingCalls;
				}
				set	
				{
					waitingCalls = value;
				}
			}

			public long? WorkingAgents
			{
				get
				{
					return workingAgents;
				}
				set	
				{
					workingAgents = value;
				}
			}
		}
	}
}
