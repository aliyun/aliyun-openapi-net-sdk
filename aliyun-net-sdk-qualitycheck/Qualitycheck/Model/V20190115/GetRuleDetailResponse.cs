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
	public class GetRuleDetailResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private GetRuleDetail_Data data;

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

			private List<GetRuleDetail_ConditionBasicInfo> conditions;

			private List<GetRuleDetail_RuleBasicInfo> rules;

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

					private string oid;

					private string type;

					private string operName;

					private GetRuleDetail_Param param;

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

						private string regex;

						private string phrase;

						private int? interval;

						private float? threshold;

						private bool? inSentence;

						private int? target;

						private bool? fromEnd;

						private bool? differentRole;

						private string targetRole;

						private int? score;

						private bool? contextChatMatch;

						private int? keywordMatchSize;

						private bool? average;

						private int? velocityInMint;

						private int? minWordSize;

						private bool? keywordExtension;

						private int? hitTime;

						private int? from;

						private string beginType;

						private string compareOperator;

						private int? checkType;

						private int? maxEmotionChangeValue;

						private int? checkType1;

						private int? maxEmotionChangeValue2;

						private string notRegex;

						private float? similarity_threshold;

						private int? delayTime;

						private List<string> operKeyWords;

						private List<string> references;

						private List<string> similarlySentences;

						private List<string> excludes;

						private List<string> pvalues;

						private List<string> antModelInfo;

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

						public int? CheckType1
						{
							get
							{
								return checkType1;
							}
							set	
							{
								checkType1 = value;
							}
						}

						public int? MaxEmotionChangeValue2
						{
							get
							{
								return maxEmotionChangeValue2;
							}
							set	
							{
								maxEmotionChangeValue2 = value;
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
					}
				}

				public class GetRuleDetail_CheckRange
				{

					private string role;

					private bool? absolute;

					private GetRuleDetail_Anchor anchor;

					private GetRuleDetail_Range range;

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

						private string anchorCid;

						private string location;

						private int? hitTime;

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
					}

					public class GetRuleDetail_Range
					{

						private int? from;

						private int? to;

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
					}
				}
			}

			public class GetRuleDetail_RuleBasicInfo
			{

				private string rid;

				private string ruleLambda;

				private List<GetRuleDetail_BusinessCategoryBasicInfo> businessCategories;

				private List<string> triggers;

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

					private int? bid;

					private int? serviceType;

					private string businessName;

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
				}
			}
		}
	}
}
