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
	public class GetRuleResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private GetRule_Data data;

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

		public GetRule_Data Data
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

		public class GetRule_Data
		{

			private List<GetRule_RuleInfo> rules;

			public List<GetRule_RuleInfo> Rules
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

			public class GetRule_RuleInfo
			{

				private int? status;

				private int? type;

				private int? scoreSubId;

				private int? isOnline;

				private string createTime;

				private string createEmpid;

				private string lastUpdateEmpid;

				private int? isDelete;

				private string rid;

				private int? ruleScoreType;

				private string endTime;

				private string weight;

				private string startTime;

				private string ruleLambda;

				private string scoreSubName;

				private int? autoReview;

				private string comments;

				private string lastUpdateTime;

				private string scoreName;

				private string name;

				private int? scoreId;

				private List<string> businessCategoryNameList;

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

				public int? ScoreSubId
				{
					get
					{
						return scoreSubId;
					}
					set	
					{
						scoreSubId = value;
					}
				}

				public int? IsOnline
				{
					get
					{
						return isOnline;
					}
					set	
					{
						isOnline = value;
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

				public string CreateEmpid
				{
					get
					{
						return createEmpid;
					}
					set	
					{
						createEmpid = value;
					}
				}

				public string LastUpdateEmpid
				{
					get
					{
						return lastUpdateEmpid;
					}
					set	
					{
						lastUpdateEmpid = value;
					}
				}

				public int? IsDelete
				{
					get
					{
						return isDelete;
					}
					set	
					{
						isDelete = value;
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

				public string EndTime
				{
					get
					{
						return endTime;
					}
					set	
					{
						endTime = value;
					}
				}

				public string Weight
				{
					get
					{
						return weight;
					}
					set	
					{
						weight = value;
					}
				}

				public string StartTime
				{
					get
					{
						return startTime;
					}
					set	
					{
						startTime = value;
					}
				}

				public string RuleLambda
				{
					get
					{
						return ruleLambda;
					}
					set	
					{
						ruleLambda = value;
					}
				}

				public string ScoreSubName
				{
					get
					{
						return scoreSubName;
					}
					set	
					{
						scoreSubName = value;
					}
				}

				public int? AutoReview
				{
					get
					{
						return autoReview;
					}
					set	
					{
						autoReview = value;
					}
				}

				public string Comments
				{
					get
					{
						return comments;
					}
					set	
					{
						comments = value;
					}
				}

				public string LastUpdateTime
				{
					get
					{
						return lastUpdateTime;
					}
					set	
					{
						lastUpdateTime = value;
					}
				}

				public string ScoreName
				{
					get
					{
						return scoreName;
					}
					set	
					{
						scoreName = value;
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

				public int? ScoreId
				{
					get
					{
						return scoreId;
					}
					set	
					{
						scoreId = value;
					}
				}

				public List<string> BusinessCategoryNameList
				{
					get
					{
						return businessCategoryNameList;
					}
					set	
					{
						businessCategoryNameList = value;
					}
				}
			}
		}
	}
}
