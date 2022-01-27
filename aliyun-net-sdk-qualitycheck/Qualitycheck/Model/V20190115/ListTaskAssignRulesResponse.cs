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

namespace Aliyun.Acs.Qualitycheck.Model.V20190115
{
	public class ListTaskAssignRulesResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? pageNumber;

		private int? pageSize;

		private int? count;

		private List<ListTaskAssignRules_TaskAssignRuleInfo> data;

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

		public int? Count
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

		public List<ListTaskAssignRules_TaskAssignRuleInfo> Data
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

		public class ListTaskAssignRules_TaskAssignRuleInfo
		{

			private string updateTime;

			private string skillGroupsStr;

			private long? callTimeEnd;

			private int? durationMax;

			private string createTime;

			private int? priority;

			private int? durationMin;

			private string agentsStr;

			private string ruleName;

			private long? ruleId;

			private int? assignmentType;

			private int? callType;

			private int? enabled;

			private long? callTimeStart;

			private List<ListTaskAssignRules_Agent> agents;

			private List<ListTaskAssignRules_SkillGroup> skillGroups;

			private List<ListTaskAssignRules_Reviewer> reviewers;

			private List<ListTaskAssignRules_RuleBasicInfo> rules;

			private ListTaskAssignRules_SamplingMode samplingMode;

			public string UpdateTime
			{
				get
				{
					return updateTime;
				}
				set	
				{
					updateTime = value;
				}
			}

			public string SkillGroupsStr
			{
				get
				{
					return skillGroupsStr;
				}
				set	
				{
					skillGroupsStr = value;
				}
			}

			public long? CallTimeEnd
			{
				get
				{
					return callTimeEnd;
				}
				set	
				{
					callTimeEnd = value;
				}
			}

			public int? DurationMax
			{
				get
				{
					return durationMax;
				}
				set	
				{
					durationMax = value;
				}
			}

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public int? Priority
			{
				get
				{
					return priority;
				}
				set	
				{
					priority = value;
				}
			}

			public int? DurationMin
			{
				get
				{
					return durationMin;
				}
				set	
				{
					durationMin = value;
				}
			}

			public string AgentsStr
			{
				get
				{
					return agentsStr;
				}
				set	
				{
					agentsStr = value;
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

			public long? RuleId
			{
				get
				{
					return ruleId;
				}
				set	
				{
					ruleId = value;
				}
			}

			public int? AssignmentType
			{
				get
				{
					return assignmentType;
				}
				set	
				{
					assignmentType = value;
				}
			}

			public int? CallType
			{
				get
				{
					return callType;
				}
				set	
				{
					callType = value;
				}
			}

			public int? Enabled
			{
				get
				{
					return enabled;
				}
				set	
				{
					enabled = value;
				}
			}

			public long? CallTimeStart
			{
				get
				{
					return callTimeStart;
				}
				set	
				{
					callTimeStart = value;
				}
			}

			public List<ListTaskAssignRules_Agent> Agents
			{
				get
				{
					return agents;
				}
				set	
				{
					agents = value;
				}
			}

			public List<ListTaskAssignRules_SkillGroup> SkillGroups
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

			public List<ListTaskAssignRules_Reviewer> Reviewers
			{
				get
				{
					return reviewers;
				}
				set	
				{
					reviewers = value;
				}
			}

			public List<ListTaskAssignRules_RuleBasicInfo> Rules
			{
				get
				{
					return rules;
				}
				set	
				{
					rules = value;
				}
			}

			public ListTaskAssignRules_SamplingMode SamplingMode
			{
				get
				{
					return samplingMode;
				}
				set	
				{
					samplingMode = value;
				}
			}

			public class ListTaskAssignRules_Agent
			{

				private string agentName;

				private string agentId;

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
			}

			public class ListTaskAssignRules_SkillGroup
			{

				private string skillName;

				private string skillId;

				public string SkillName
				{
					get
					{
						return skillName;
					}
					set	
					{
						skillName = value;
					}
				}

				public string SkillId
				{
					get
					{
						return skillId;
					}
					set	
					{
						skillId = value;
					}
				}
			}

			public class ListTaskAssignRules_Reviewer
			{

				private string reviewerId;

				private string reviewerName;

				public string ReviewerId
				{
					get
					{
						return reviewerId;
					}
					set	
					{
						reviewerId = value;
					}
				}

				public string ReviewerName
				{
					get
					{
						return reviewerName;
					}
					set	
					{
						reviewerName = value;
					}
				}
			}

			public class ListTaskAssignRules_RuleBasicInfo
			{

				private string name;

				private string rid;

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

				public string Rid
				{
					get
					{
						return rid;
					}
					set	
					{
						rid = value;
					}
				}
			}

			public class ListTaskAssignRules_SamplingMode
			{

				private int? numberOfDraws;

				private int? anyNumberOfDraws;

				private int? limit;

				private float? proportion;

				private int? dimension;

				private bool? designated;

				private int? randomInspectionNumber;

				private List<ListTaskAssignRules_SamplingModeAgent> samplingModeAgents;

				public int? NumberOfDraws
				{
					get
					{
						return numberOfDraws;
					}
					set	
					{
						numberOfDraws = value;
					}
				}

				public int? AnyNumberOfDraws
				{
					get
					{
						return anyNumberOfDraws;
					}
					set	
					{
						anyNumberOfDraws = value;
					}
				}

				public int? Limit
				{
					get
					{
						return limit;
					}
					set	
					{
						limit = value;
					}
				}

				public float? Proportion
				{
					get
					{
						return proportion;
					}
					set	
					{
						proportion = value;
					}
				}

				public int? Dimension
				{
					get
					{
						return dimension;
					}
					set	
					{
						dimension = value;
					}
				}

				public bool? Designated
				{
					get
					{
						return designated;
					}
					set	
					{
						designated = value;
					}
				}

				public int? RandomInspectionNumber
				{
					get
					{
						return randomInspectionNumber;
					}
					set	
					{
						randomInspectionNumber = value;
					}
				}

				public List<ListTaskAssignRules_SamplingModeAgent> SamplingModeAgents
				{
					get
					{
						return samplingModeAgents;
					}
					set	
					{
						samplingModeAgents = value;
					}
				}

				public class ListTaskAssignRules_SamplingModeAgent
				{

					private string agentName;

					private string agentId;

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
				}
			}
		}
	}
}
