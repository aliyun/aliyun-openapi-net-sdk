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
	public class GetSkillGroupConfigResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private GetSkillGroupConfig_Data data;

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

		public GetSkillGroupConfig_Data Data
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

		public class GetSkillGroupConfig_Data
		{

			private int? type;

			private int? status;

			private string updateTime;

			private int? allContentQualityCheck;

			private string createTime;

			private string skillGroupId;

			private string instanceId;

			private long? vocabId;

			private int? skillGroupFrom;

			private string rid;

			private string skillGroupName;

			private string modelName;

			private string allRids;

			private string name;

			private long? modelId;

			private long? id;

			private int? qualityCheckType;

			private string vocabName;

			private List<GetSkillGroupConfig_RuleNameInfo> ruleList;

			private List<GetSkillGroupConfig_RuleNameInfo> allRuleList;

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

			public List<GetSkillGroupConfig_RuleNameInfo> RuleList
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

			public List<GetSkillGroupConfig_RuleNameInfo> AllRuleList
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

			public class GetSkillGroupConfig_RuleNameInfo
			{

				private string ruleName;

				private long? rid;

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
			}
		}
	}
}
