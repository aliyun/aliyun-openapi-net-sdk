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
	public class ListQualityCheckSchemeResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string resultCountId;

		private string code;

		private string message;

		private int? pageNumber;

		private int? pageSize;

		private int? count;

		private List<ListQualityCheckScheme_DataItem> data;

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

		public string ResultCountId
		{
			get
			{
				return resultCountId;
			}
			set	
			{
				resultCountId = value;
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

		public List<ListQualityCheckScheme_DataItem> Data
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

		public class ListQualityCheckScheme_DataItem
		{

			private long? schemeId;

			private string name;

			private string description;

			private int? dataType;

			private int? type;

			private int? templateType;

			private int? status;

			private string createUserName;

			private string createTime;

			private string updateUserName;

			private string updateTime;

			private long? version;

			private List<ListQualityCheckScheme_SchemeCheckTypeListItem> schemeCheckTypeList;

			private List<ListQualityCheckScheme_RuleListItem> ruleList;

			public long? SchemeId
			{
				get
				{
					return schemeId;
				}
				set	
				{
					schemeId = value;
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

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
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

			public int? TemplateType
			{
				get
				{
					return templateType;
				}
				set	
				{
					templateType = value;
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

			public string CreateUserName
			{
				get
				{
					return createUserName;
				}
				set	
				{
					createUserName = value;
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

			public string UpdateUserName
			{
				get
				{
					return updateUserName;
				}
				set	
				{
					updateUserName = value;
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

			public long? Version
			{
				get
				{
					return version;
				}
				set	
				{
					version = value;
				}
			}

			public List<ListQualityCheckScheme_SchemeCheckTypeListItem> SchemeCheckTypeList
			{
				get
				{
					return schemeCheckTypeList;
				}
				set	
				{
					schemeCheckTypeList = value;
				}
			}

			public List<ListQualityCheckScheme_RuleListItem> RuleList
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

			public class ListQualityCheckScheme_SchemeCheckTypeListItem
			{

				private int? checkType;

				private int? enable;

				private string checkName;

				private int? targetType;

				private int? score;

				public int? CheckType
				{
					get
					{
						return checkType;
					}
					set	
					{
						checkType = value;
					}
				}

				public int? Enable
				{
					get
					{
						return enable;
					}
					set	
					{
						enable = value;
					}
				}

				public string CheckName
				{
					get
					{
						return checkName;
					}
					set	
					{
						checkName = value;
					}
				}

				public int? TargetType
				{
					get
					{
						return targetType;
					}
					set	
					{
						targetType = value;
					}
				}

				public int? Score
				{
					get
					{
						return score;
					}
					set	
					{
						score = value;
					}
				}
			}

			public class ListQualityCheckScheme_RuleListItem
			{

				private List<ListQualityCheckScheme_RulesItem> rules;

				public List<ListQualityCheckScheme_RulesItem> Rules
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

				public class ListQualityCheckScheme_RulesItem
				{

					private long? rid;

					private string name;

					private int? ruleScoreType;

					private int? scoreNum;

					private int? scoreType;

					private int? checkType;

					private int? targetType;

					private int? scoreNumType;

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

					public int? RuleScoreType
					{
						get
						{
							return ruleScoreType;
						}
						set	
						{
							ruleScoreType = value;
						}
					}

					public int? ScoreNum
					{
						get
						{
							return scoreNum;
						}
						set	
						{
							scoreNum = value;
						}
					}

					public int? ScoreType
					{
						get
						{
							return scoreType;
						}
						set	
						{
							scoreType = value;
						}
					}

					public int? CheckType
					{
						get
						{
							return checkType;
						}
						set	
						{
							checkType = value;
						}
					}

					public int? TargetType
					{
						get
						{
							return targetType;
						}
						set	
						{
							targetType = value;
						}
					}

					public int? ScoreNumType
					{
						get
						{
							return scoreNumType;
						}
						set	
						{
							scoreNumType = value;
						}
					}
				}
			}
		}
	}
}
