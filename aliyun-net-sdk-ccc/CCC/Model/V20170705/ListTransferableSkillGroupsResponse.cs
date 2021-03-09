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
	public class ListTransferableSkillGroupsResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? httpStatusCode;

		private List<ListTransferableSkillGroups_SkillGroup> skillGroups;

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

		public List<ListTransferableSkillGroups_SkillGroup> SkillGroups
		{
			get
			{
				return skillGroups;
			}
			set	
			{
				skillGroups = value;
			}
		}

		public class ListTransferableSkillGroups_SkillGroup
		{

			private string skillGroupId;

			private string instanceId;

			private string skillGroupName;

			private string accSkillGroupName;

			private string accQueueName;

			private string skillGroupDescription;

			private string routingStrategy;

			private bool? allowPrivateOutboundNumber;

			private int? userCount;

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

			public string AccSkillGroupName
			{
				get
				{
					return accSkillGroupName;
				}
				set	
				{
					accSkillGroupName = value;
				}
			}

			public string AccQueueName
			{
				get
				{
					return accQueueName;
				}
				set	
				{
					accQueueName = value;
				}
			}

			public string SkillGroupDescription
			{
				get
				{
					return skillGroupDescription;
				}
				set	
				{
					skillGroupDescription = value;
				}
			}

			public string RoutingStrategy
			{
				get
				{
					return routingStrategy;
				}
				set	
				{
					routingStrategy = value;
				}
			}

			public bool? AllowPrivateOutboundNumber
			{
				get
				{
					return allowPrivateOutboundNumber;
				}
				set	
				{
					allowPrivateOutboundNumber = value;
				}
			}

			public int? UserCount
			{
				get
				{
					return userCount;
				}
				set	
				{
					userCount = value;
				}
			}
		}
	}
}
