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
	public class GetRuleDetailResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private GetRuleDetail_Data data;

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

		public GetRuleDetail_Data Data
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

		public class GetRuleDetail_Data
		{

			private int? pageSize;

			private int? pageNumber;

			private int? count;

			private List<GetRuleDetail_ConditionBasicInfo> conditions;

			private List<GetRuleDetail_RuleBasicInfo> rules;

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

			public List<GetRuleDetail_ConditionBasicInfo> Conditions
			{
				get
				{
					return conditions;
				}
				set	
				{
					conditions = value;
				}
			}

			public List<GetRuleDetail_RuleBasicInfo> Rules
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

			public class GetRuleDetail_ConditionBasicInfo
			{

				private string conditionInfoCid;

				private string operLambda;

				private List<GetRuleDetail_OperatorBasicInfo> operators;

				private GetRuleDetail_CheckRange checkRange;

				public string ConditionInfoCid
				{
					get
					{
						return conditionInfoCid;
					}
					set	
					{
						conditionInfoCid = value;
					}
				}

				public string OperLambda
				{
					get
					{
						return operLambda;
					}
					set	
					{
						operLambda = value;
					}
				}

				public List<GetRuleDetail_OperatorBasicInfo> Operators
				{
					get
					{
						return operators;
					}
					set	
					{
						operators = value;
					}
				}

				public GetRuleDetail_CheckRange CheckRange
				{
					get
					{
						return checkRange;
					}
					set	
					{
						checkRange = value;
					}
				}

				public class GetRuleDetail_OperatorBasicInfo
				{

					private string type;

					private string oid;

					private string operName;

					private GetRuleDetail_Param param;

					public string Type
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

					public string Oid
					{
						get
						{
							return oid;
						}
						set	
						{
							oid = value;
						}
					}

					public string OperName
					{
						get
						{
							return operName;
						}
						set	
						{
							operName = value;
						}
					}

					public GetRuleDetail_Param Param
					{
						get
						{
							return param;
						}
						set	
						{
							param = value;
						}
					}

					public class GetRuleDetail_Param
					{

						private bool? differentRole;

						private string regex;

						private string targetRole;

						private int? velocityInMint;

						private bool? average;

						private bool? keywordExtension;

						private int? score;

						private string notRegex;

						private string compareOperator;

						private int? delayTime;

						private int? keywordMatchSize;

						private int? hitTime;

						private string beginType;

						private int? target;

						private int? maxEmotionChangeValue;

						private float? threshold;

						private int? from;

						private bool? fromEnd;

						private int? minWordSize;

						private bool? inSentence;

						private string phrase;

						private float? similarity_threshold;

						private int? checkType;

						private int? interval;

						private bool? contextChatMatch;

						private List<string> excludes;

						private List<string> antModelInfo;

						private List<string> pvalues;

						private List<string> references;

						private List<string> similarlySentences;

						private List<string> operKeyWords;

						public bool? DifferentRole
						{
							get
							{
								return differentRole;
							}
							set	
							{
								differentRole = value;
							}
						}

						public string Regex
						{
							get
							{
								return regex;
							}
							set	
							{
								regex = value;
							}
						}

						public string TargetRole
						{
							get
							{
								return targetRole;
							}
							set	
							{
								targetRole = value;
							}
						}

						public int? VelocityInMint
						{
							get
							{
								return velocityInMint;
							}
							set	
							{
								velocityInMint = value;
							}
						}

						public bool? Average
						{
							get
							{
								return average;
							}
							set	
							{
								average = value;
							}
						}

						public bool? KeywordExtension
						{
							get
							{
								return keywordExtension;
							}
							set	
							{
								keywordExtension = value;
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

						public string NotRegex
						{
							get
							{
								return notRegex;
							}
							set	
							{
								notRegex = value;
							}
						}

						public string CompareOperator
						{
							get
							{
								return compareOperator;
							}
							set	
							{
								compareOperator = value;
							}
						}

						public int? DelayTime
						{
							get
							{
								return delayTime;
							}
							set	
							{
								delayTime = value;
							}
						}

						public int? KeywordMatchSize
						{
							get
							{
								return keywordMatchSize;
							}
							set	
							{
								keywordMatchSize = value;
							}
						}

						public int? HitTime
						{
							get
							{
								return hitTime;
							}
							set	
							{
								hitTime = value;
							}
						}

						public string BeginType
						{
							get
							{
								return beginType;
							}
							set	
							{
								beginType = value;
							}
						}

						public int? Target
						{
							get
							{
								return target;
							}
							set	
							{
								target = value;
							}
						}

						public int? MaxEmotionChangeValue
						{
							get
							{
								return maxEmotionChangeValue;
							}
							set	
							{
								maxEmotionChangeValue = value;
							}
						}

						public float? Threshold
						{
							get
							{
								return threshold;
							}
							set	
							{
								threshold = value;
							}
						}

						public int? From
						{
							get
							{
								return from;
							}
							set	
							{
								from = value;
							}
						}

						public bool? FromEnd
						{
							get
							{
								return fromEnd;
							}
							set	
							{
								fromEnd = value;
							}
						}

						public int? MinWordSize
						{
							get
							{
								return minWordSize;
							}
							set	
							{
								minWordSize = value;
							}
						}

						public bool? InSentence
						{
							get
							{
								return inSentence;
							}
							set	
							{
								inSentence = value;
							}
						}

						public string Phrase
						{
							get
							{
								return phrase;
							}
							set	
							{
								phrase = value;
							}
						}

						public float? Similarity_threshold
						{
							get
							{
								return similarity_threshold;
							}
							set	
							{
								similarity_threshold = value;
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

						public int? Interval
						{
							get
							{
								return interval;
							}
							set	
							{
								interval = value;
							}
						}

						public bool? ContextChatMatch
						{
							get
							{
								return contextChatMatch;
							}
							set	
							{
								contextChatMatch = value;
							}
						}

						public List<string> Excludes
						{
							get
							{
								return excludes;
							}
							set	
							{
								excludes = value;
							}
						}

						public List<string> AntModelInfo
						{
							get
							{
								return antModelInfo;
							}
							set	
							{
								antModelInfo = value;
							}
						}

						public List<string> Pvalues
						{
							get
							{
								return pvalues;
							}
							set	
							{
								pvalues = value;
							}
						}

						public List<string> References
						{
							get
							{
								return references;
							}
							set	
							{
								references = value;
							}
						}

						public List<string> SimilarlySentences
						{
							get
							{
								return similarlySentences;
							}
							set	
							{
								similarlySentences = value;
							}
						}

						public List<string> OperKeyWords
						{
							get
							{
								return operKeyWords;
							}
							set	
							{
								operKeyWords = value;
							}
						}
					}
				}

				public class GetRuleDetail_CheckRange
				{

					private bool? absolute;

					private string role;

					private GetRuleDetail_Anchor anchor;

					private GetRuleDetail_Range range;

					public bool? Absolute
					{
						get
						{
							return absolute;
						}
						set	
						{
							absolute = value;
						}
					}

					public string Role
					{
						get
						{
							return role;
						}
						set	
						{
							role = value;
						}
					}

					public GetRuleDetail_Anchor Anchor
					{
						get
						{
							return anchor;
						}
						set	
						{
							anchor = value;
						}
					}

					public GetRuleDetail_Range Range
					{
						get
						{
							return range;
						}
						set	
						{
							range = value;
						}
					}

					public class GetRuleDetail_Anchor
					{

						private int? hitTime;

						private string location;

						private string anchorCid;

						public int? HitTime
						{
							get
							{
								return hitTime;
							}
							set	
							{
								hitTime = value;
							}
						}

						public string Location
						{
							get
							{
								return location;
							}
							set	
							{
								location = value;
							}
						}

						public string AnchorCid
						{
							get
							{
								return anchorCid;
							}
							set	
							{
								anchorCid = value;
							}
						}
					}

					public class GetRuleDetail_Range
					{

						private int? to;

						private int? from;

						public int? To
						{
							get
							{
								return to;
							}
							set	
							{
								to = value;
							}
						}

						public int? From
						{
							get
							{
								return from;
							}
							set	
							{
								from = value;
							}
						}
					}
				}
			}

			public class GetRuleDetail_RuleBasicInfo
			{

				private string ruleLambda;

				private string rid;

				private List<GetRuleDetail_BusinessCategoryBasicInfo> businessCategories;

				private List<string> triggers;

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

				public List<GetRuleDetail_BusinessCategoryBasicInfo> BusinessCategories
				{
					get
					{
						return businessCategories;
					}
					set	
					{
						businessCategories = value;
					}
				}

				public List<string> Triggers
				{
					get
					{
						return triggers;
					}
					set	
					{
						triggers = value;
					}
				}

				public class GetRuleDetail_BusinessCategoryBasicInfo
				{

					private string businessName;

					private int? serviceType;

					private int? bid;

					public string BusinessName
					{
						get
						{
							return businessName;
						}
						set	
						{
							businessName = value;
						}
					}

					public int? ServiceType
					{
						get
						{
							return serviceType;
						}
						set	
						{
							serviceType = value;
						}
					}

					public int? Bid
					{
						get
						{
							return bid;
						}
						set	
						{
							bid = value;
						}
					}
				}
			}
		}
	}
}
