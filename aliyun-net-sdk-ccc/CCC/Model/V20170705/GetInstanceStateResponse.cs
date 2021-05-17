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

namespace Aliyun.Acs.CCC.Model.V20170705
{
	public class GetInstanceStateResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? httpStatusCode;

		private GetInstanceState_RealTimeInstanceState realTimeInstanceState;

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

		public GetInstanceState_RealTimeInstanceState RealTimeInstanceState
		{
			get
			{
				return realTimeInstanceState;
			}
			set	
			{
				realTimeInstanceState = value;
			}
		}

		public class GetInstanceState_RealTimeInstanceState
		{

			private List<GetInstanceState_AgentStateCount> agentStateDistributions;

			public List<GetInstanceState_AgentStateCount> AgentStateDistributions
			{
				get
				{
					return agentStateDistributions;
				}
				set	
				{
					agentStateDistributions = value;
				}
			}

			public class GetInstanceState_AgentStateCount
			{

				private string state;

				private long? count;

				public string State
				{
					get
					{
						return state;
					}
					set	
					{
						state = value;
					}
				}

				public long? Count
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
			}
		}
	}
}
