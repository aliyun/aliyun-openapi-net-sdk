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
	public class ListAgentEventsResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? httpStatusCode;

		private ListAgentEvents_Data data;

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

		public ListAgentEvents_Data Data
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

		public class ListAgentEvents_Data
		{

			private int? totalCount;

			private int? pageNumber;

			private int? pageSize;

			private List<ListAgentEvents_AgentEvent> list;

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

			public List<ListAgentEvents_AgentEvent> List
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

			public class ListAgentEvents_AgentEvent
			{

				private string instanceId;

				private long? ramId;

				private string loginName;

				private string _event;

				private long? eventTime;

				private List<ListAgentEvents_SkillGroup> skillGroupIds;

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

				public string LoginName
				{
					get
					{
						return loginName;
					}
					set	
					{
						loginName = value;
					}
				}

				public string _Event
				{
					get
					{
						return _event;
					}
					set	
					{
						_event = value;
					}
				}

				public long? EventTime
				{
					get
					{
						return eventTime;
					}
					set	
					{
						eventTime = value;
					}
				}

				public List<ListAgentEvents_SkillGroup> SkillGroupIds
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

				public class ListAgentEvents_SkillGroup
				{

					private string skillGroupId;

					private string skillGroupName;

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
				}
			}
		}
	}
}
