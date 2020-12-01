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
	public class ListAgentStateLogsResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? httpStatusCode;

		private ListAgentStateLogs_AgentStateLogPage agentStateLogPage;

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

		public ListAgentStateLogs_AgentStateLogPage AgentStateLogPage
		{
			get
			{
				return agentStateLogPage;
			}
			set	
			{
				agentStateLogPage = value;
			}
		}

		public class ListAgentStateLogs_AgentStateLogPage
		{

			private int? totalCount;

			private int? pageNumber;

			private int? pageSize;

			private List<ListAgentStateLogs_AgentStateLog> list;

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

			public List<ListAgentStateLogs_AgentStateLog> List
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

			public class ListAgentStateLogs_AgentStateLog
			{

				private string instanceId;

				private long? ramId;

				private string state;

				private string stateCode;

				private long? stateTime;

				private string contactId;

				private string connectId;

				private string skillGroupIds;

				private string counterParty;

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

				public long? RamId
				{
					get
					{
						return ramId;
					}
					set	
					{
						ramId = value;
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

				public string ContactId
				{
					get
					{
						return contactId;
					}
					set	
					{
						contactId = value;
					}
				}

				public string ConnectId
				{
					get
					{
						return connectId;
					}
					set	
					{
						connectId = value;
					}
				}

				public string SkillGroupIds
				{
					get
					{
						return skillGroupIds;
					}
					set	
					{
						skillGroupIds = value;
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
			}
		}
	}
}
