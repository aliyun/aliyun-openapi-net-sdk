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

namespace Aliyun.Acs.Dyvmsapi.Model.V20170525
{
	public class ListOutboundStrategiesResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private List<ListOutboundStrategies_OutboundStrategy> outboundStrategies;

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

		public List<ListOutboundStrategies_OutboundStrategy> OutboundStrategies
		{
			get
			{
				return outboundStrategies;
			}
			set	
			{
				outboundStrategies = value;
			}
		}

		public class ListOutboundStrategies_OutboundStrategy
		{

			private long? id;

			private string gmtCreateStr;

			private string gmtModifiedStr;

			private long? creatorId;

			private string creatorName;

			private long? modifierId;

			private string modifierName;

			private long? buId;

			private long? departmentId;

			private string name;

			private int? numType;

			private string outboundNum;

			private int? robotType;

			private string robotId;

			private string robotName;

			private int? resourceAllocation;

			private string sceneName;

			private long? ruleCode;

			private int? status;

			private string extAttr;

			private int? process;

			private int? successRate;

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

			public string GmtCreateStr
			{
				get
				{
					return gmtCreateStr;
				}
				set	
				{
					gmtCreateStr = value;
				}
			}

			public string GmtModifiedStr
			{
				get
				{
					return gmtModifiedStr;
				}
				set	
				{
					gmtModifiedStr = value;
				}
			}

			public long? CreatorId
			{
				get
				{
					return creatorId;
				}
				set	
				{
					creatorId = value;
				}
			}

			public string CreatorName
			{
				get
				{
					return creatorName;
				}
				set	
				{
					creatorName = value;
				}
			}

			public long? ModifierId
			{
				get
				{
					return modifierId;
				}
				set	
				{
					modifierId = value;
				}
			}

			public string ModifierName
			{
				get
				{
					return modifierName;
				}
				set	
				{
					modifierName = value;
				}
			}

			public long? BuId
			{
				get
				{
					return buId;
				}
				set	
				{
					buId = value;
				}
			}

			public long? DepartmentId
			{
				get
				{
					return departmentId;
				}
				set	
				{
					departmentId = value;
				}
			}

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public int? NumType
			{
				get
				{
					return numType;
				}
				set	
				{
					numType = value;
				}
			}

			public string OutboundNum
			{
				get
				{
					return outboundNum;
				}
				set	
				{
					outboundNum = value;
				}
			}

			public int? RobotType
			{
				get
				{
					return robotType;
				}
				set	
				{
					robotType = value;
				}
			}

			public string RobotId
			{
				get
				{
					return robotId;
				}
				set	
				{
					robotId = value;
				}
			}

			public string RobotName
			{
				get
				{
					return robotName;
				}
				set	
				{
					robotName = value;
				}
			}

			public int? ResourceAllocation
			{
				get
				{
					return resourceAllocation;
				}
				set	
				{
					resourceAllocation = value;
				}
			}

			public string SceneName
			{
				get
				{
					return sceneName;
				}
				set	
				{
					sceneName = value;
				}
			}

			public long? RuleCode
			{
				get
				{
					return ruleCode;
				}
				set	
				{
					ruleCode = value;
				}
			}

			public int? Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public string ExtAttr
			{
				get
				{
					return extAttr;
				}
				set	
				{
					extAttr = value;
				}
			}

			public int? Process
			{
				get
				{
					return process;
				}
				set	
				{
					process = value;
				}
			}

			public int? SuccessRate
			{
				get
				{
					return successRate;
				}
				set	
				{
					successRate = value;
				}
			}
		}
	}
}
