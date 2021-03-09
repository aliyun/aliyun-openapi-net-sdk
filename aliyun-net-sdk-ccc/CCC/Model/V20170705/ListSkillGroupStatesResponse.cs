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
	public class ListSkillGroupStatesResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? httpStatusCode;

		private ListSkillGroupStates_Data data;

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

			private int? totalCount;

			private int? pageNumber;

			private int? pageSize;

			private List<ListSkillGroupStates_RealTimeSkillGroupState> list;

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

				private string instanceId;

				private string skillGroupId;

				private string skillGroupName;

				private long? waitingCalls;

				private long? longestCall;

				private long? loggedInAgents;

				private long? readyAgents;

				private long? breakingAgents;

				private long? talkingAgents;

				private long? workingAgents;

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
}
