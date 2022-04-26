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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.CCC.Model.V20200701
{
	public class ListSkillGroupStatesResponse : AcsResponse
	{

		private int? httpStatusCode;

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private ListSkillGroupStates_Data data;

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

		public ListSkillGroupStates_Data Data
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

		public class ListSkillGroupStates_Data
		{

			private int? pageNumber;

			private int? pageSize;

			private int? totalCount;

			private List<ListSkillGroupStates_RealTimeSkillGroupState> list;

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

			public List<ListSkillGroupStates_RealTimeSkillGroupState> List
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

			public class ListSkillGroupStates_RealTimeSkillGroupState
			{

				private long? workingAgents;

				private long? loggedInAgents;

				private long? breakingAgents;

				private long? longestCall;

				private long? waitingCalls;

				private long? talkingAgents;

				private string skillGroupName;

				private string skillGroupId;

				private long? readyAgents;

				private string instanceId;

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

				public string SkillGroupName
				{
					get
					{
						return skillGroupName;
					}
					set	
					{
						skillGroupName = value;
					}
				}

				public string SkillGroupId
				{
					get
					{
						return skillGroupId;
					}
					set	
					{
						skillGroupId = value;
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
			}
		}
	}
}
