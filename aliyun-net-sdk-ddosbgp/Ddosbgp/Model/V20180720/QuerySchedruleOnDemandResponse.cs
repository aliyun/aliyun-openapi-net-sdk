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

namespace Aliyun.Acs.ddosbgp.Model.V20180720
{
	public class QuerySchedruleOnDemandResponse : AcsResponse
	{

		private string requestId;

		private string instanceId;

		private string userId;

		private List<QuerySchedruleOnDemand_Config> ruleConfig;

		private List<QuerySchedruleOnDemand_Status> ruleStatus;

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

		public string UserId
		{
			get
			{
				return userId;
			}
			set	
			{
				userId = value;
			}
		}

		public List<QuerySchedruleOnDemand_Config> RuleConfig
		{
			get
			{
				return ruleConfig;
			}
			set	
			{
				ruleConfig = value;
			}
		}

		public List<QuerySchedruleOnDemand_Status> RuleStatus
		{
			get
			{
				return ruleStatus;
			}
			set	
			{
				ruleStatus = value;
			}
		}

		public class QuerySchedruleOnDemand_Config
		{

			private string ruleSwitch;

			private string ruleConditionMbps;

			private string timeZone;

			private string ruleAction;

			private string ruleConditionKpps;

			private string ruleUndoMode;

			private string ruleUndoBeginTime;

			private string ruleConditionCnt;

			private string ruleUndoEndTime;

			private string ruleName;

			public string RuleSwitch
			{
				get
				{
					return ruleSwitch;
				}
				set	
				{
					ruleSwitch = value;
				}
			}

			public string RuleConditionMbps
			{
				get
				{
					return ruleConditionMbps;
				}
				set	
				{
					ruleConditionMbps = value;
				}
			}

			public string TimeZone
			{
				get
				{
					return timeZone;
				}
				set	
				{
					timeZone = value;
				}
			}

			public string RuleAction
			{
				get
				{
					return ruleAction;
				}
				set	
				{
					ruleAction = value;
				}
			}

			public string RuleConditionKpps
			{
				get
				{
					return ruleConditionKpps;
				}
				set	
				{
					ruleConditionKpps = value;
				}
			}

			public string RuleUndoMode
			{
				get
				{
					return ruleUndoMode;
				}
				set	
				{
					ruleUndoMode = value;
				}
			}

			public string RuleUndoBeginTime
			{
				get
				{
					return ruleUndoBeginTime;
				}
				set	
				{
					ruleUndoBeginTime = value;
				}
			}

			public string RuleConditionCnt
			{
				get
				{
					return ruleConditionCnt;
				}
				set	
				{
					ruleConditionCnt = value;
				}
			}

			public string RuleUndoEndTime
			{
				get
				{
					return ruleUndoEndTime;
				}
				set	
				{
					ruleUndoEndTime = value;
				}
			}

			public string RuleName
			{
				get
				{
					return ruleName;
				}
				set	
				{
					ruleName = value;
				}
			}
		}

		public class QuerySchedruleOnDemand_Status
		{

			private string ruleSchedStatus;

			private string net;

			public string RuleSchedStatus
			{
				get
				{
					return ruleSchedStatus;
				}
				set	
				{
					ruleSchedStatus = value;
				}
			}

			public string Net
			{
				get
				{
					return net;
				}
				set	
				{
					net = value;
				}
			}
		}
	}
}
