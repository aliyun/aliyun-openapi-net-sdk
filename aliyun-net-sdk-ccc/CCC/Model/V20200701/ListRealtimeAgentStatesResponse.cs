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
	public class ListRealtimeAgentStatesResponse : AcsResponse
	{

		private string code;

		private int? httpStatusCode;

		private string message;

		private string requestId;

		private ListRealtimeAgentStates_Data data;

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

		public ListRealtimeAgentStates_Data Data
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

		public class ListRealtimeAgentStates_Data
		{

			private int? pageNumber;

			private int? pageSize;

			private int? totalCount;

			private List<ListRealtimeAgentStates_AgentState> list;

			public int? PageNumber
			{
				get
				{
					return pageNumber;
				}
				set	
				{
					pageNumber = value;
				}
			}

			public int? PageSize
			{
				get
				{
					return pageSize;
				}
				set	
				{
					pageSize = value;
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

			public List<ListRealtimeAgentStates_AgentState> List
			{
				get
				{
					return list;
				}
				set	
				{
					list = value;
				}
			}

			public class ListRealtimeAgentStates_AgentState
			{

				private string agentId;

				private string agentName;

				private string counterParty;

				private string extension;

				private string instanceId;

				private string state;

				private string stateCode;

				private long? stateTime;

				private List<string> skillGroupIdList;

				public string AgentId
				{
					get
					{
						return agentId;
					}
					set	
					{
						agentId = value;
					}
				}

				public string AgentName
				{
					get
					{
						return agentName;
					}
					set	
					{
						agentName = value;
					}
				}

				public string CounterParty
				{
					get
					{
						return counterParty;
					}
					set	
					{
						counterParty = value;
					}
				}

				public string Extension
				{
					get
					{
						return extension;
					}
					set	
					{
						extension = value;
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

				public string StateCode
				{
					get
					{
						return stateCode;
					}
					set	
					{
						stateCode = value;
					}
				}

				public long? StateTime
				{
					get
					{
						return stateTime;
					}
					set	
					{
						stateTime = value;
					}
				}

				public List<string> SkillGroupIdList
				{
					get
					{
						return skillGroupIdList;
					}
					set	
					{
						skillGroupIdList = value;
					}
				}
			}
		}
	}
}
