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

namespace Aliyun.Acs.Qualitycheck.Model.V20190115
{
	public class ListSkillGroupConfigResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private List<ListSkillGroupConfig_SkillGroupConfig> data;

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

		public List<ListSkillGroupConfig_SkillGroupConfig> Data
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

		public class ListSkillGroupConfig_SkillGroupConfig
		{

			private long? id;

			private string instanceId;

			private long? modelId;

			private string modelName;

			private string name;

			private string rid;

			private string skillGroupId;

			private string skillGroupName;

			private int? status;

			private int? type;

			private long? vocabId;

			private string vocabName;

			private string createTime;

			private string updateTime;

			private int? qualityCheckType;

			private int? allContentQualityCheck;

			private string allRids;

			private int? skillGroupFrom;

			private bool? screenSwitch;

			private List<ListSkillGroupConfig_RuleNameInfo> ruleList;

			private List<ListSkillGroupConfig_RuleNameInfo> allRuleList;

			private List<ListSkillGroupConfig_SkillGroupScreen> skillGroupScreens;

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

			public long? ModelId
			{
				get
				{
					return modelId;
				}
				set	
				{
					modelId = value;
				}
			}

			public string ModelName
			{
				get
				{
					return modelName;
				}
				set	
				{
					modelName = value;
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

			public int? Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public long? VocabId
			{
				get
				{
					return vocabId;
				}
				set	
				{
					vocabId = value;
				}
			}

			public string VocabName
			{
				get
				{
					return vocabName;
				}
				set	
				{
					vocabName = value;
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

			public int? QualityCheckType
			{
				get
				{
					return qualityCheckType;
				}
				set	
				{
					qualityCheckType = value;
				}
			}

			public int? AllContentQualityCheck
			{
				get
				{
					return allContentQualityCheck;
				}
				set	
				{
					allContentQualityCheck = value;
				}
			}

			public string AllRids
			{
				get
				{
					return allRids;
				}
				set	
				{
					allRids = value;
				}
			}

			public int? SkillGroupFrom
			{
				get
				{
					return skillGroupFrom;
				}
				set	
				{
					skillGroupFrom = value;
				}
			}

			public bool? ScreenSwitch
			{
				get
				{
					return screenSwitch;
				}
				set	
				{
					screenSwitch = value;
				}
			}

			public List<ListSkillGroupConfig_RuleNameInfo> RuleList
			{
				get
				{
					return ruleList;
				}
				set	
				{
					ruleList = value;
				}
			}

			public List<ListSkillGroupConfig_RuleNameInfo> AllRuleList
			{
				get
				{
					return allRuleList;
				}
				set	
				{
					allRuleList = value;
				}
			}

			public List<ListSkillGroupConfig_SkillGroupScreen> SkillGroupScreens
			{
				get
				{
					return skillGroupScreens;
				}
				set	
				{
					skillGroupScreens = value;
				}
			}

			public class ListSkillGroupConfig_RuleNameInfo
			{

				private long? rid;

				private string ruleName;

				public long? Rid
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

			public class ListSkillGroupConfig_SkillGroupScreen
			{

				private string name;

				private int? dataType;

				private int? symbol;

				private string _value;

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

				public int? DataType
				{
					get
					{
						return dataType;
					}
					set	
					{
						dataType = value;
					}
				}

				public int? Symbol
				{
					get
					{
						return symbol;
					}
					set	
					{
						symbol = value;
					}
				}

				public string _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}
			}
		}
	}
}
