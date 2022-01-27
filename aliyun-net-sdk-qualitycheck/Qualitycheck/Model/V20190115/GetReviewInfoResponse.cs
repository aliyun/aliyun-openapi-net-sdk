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
	public class GetReviewInfoResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private GetReviewInfo_Data data;

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

		public GetReviewInfo_Data Data
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

		public class GetReviewInfo_Data
		{

			private string audioURL;

			private int? hitNumber;

			private string nextVid;

			private string preVid;

			private bool? isAudio;

			private int? asrWordsCount;

			private bool? audio;

			private int? totalScore;

			private int? businessType;

			private string fileMergeName;

			private bool? isDeleted;

			private bool? deleted;

			private string vid;

			private int? reviewNumber;

			private List<GetReviewInfo_Dialogue> dialogues;

			private List<GetReviewInfo_ScorePo> handScoreInfoList;

			private List<GetReviewInfo_HitRuleReviewInfo> hitRuleReviewInfoList;

			private List<string> manualScoreMappingList;

			public string AudioURL
			{
				get
				{
					return audioURL;
				}
				set	
				{
					audioURL = value;
				}
			}

			public int? HitNumber
			{
				get
				{
					return hitNumber;
				}
				set	
				{
					hitNumber = value;
				}
			}

			public string NextVid
			{
				get
				{
					return nextVid;
				}
				set	
				{
					nextVid = value;
				}
			}

			public string PreVid
			{
				get
				{
					return preVid;
				}
				set	
				{
					preVid = value;
				}
			}

			public bool? IsAudio
			{
				get
				{
					return isAudio;
				}
				set	
				{
					isAudio = value;
				}
			}

			public int? AsrWordsCount
			{
				get
				{
					return asrWordsCount;
				}
				set	
				{
					asrWordsCount = value;
				}
			}

			public bool? Audio
			{
				get
				{
					return audio;
				}
				set	
				{
					audio = value;
				}
			}

			public int? TotalScore
			{
				get
				{
					return totalScore;
				}
				set	
				{
					totalScore = value;
				}
			}

			public int? BusinessType
			{
				get
				{
					return businessType;
				}
				set	
				{
					businessType = value;
				}
			}

			public string FileMergeName
			{
				get
				{
					return fileMergeName;
				}
				set	
				{
					fileMergeName = value;
				}
			}

			public bool? IsDeleted
			{
				get
				{
					return isDeleted;
				}
				set	
				{
					isDeleted = value;
				}
			}

			public bool? Deleted
			{
				get
				{
					return deleted;
				}
				set	
				{
					deleted = value;
				}
			}

			public string Vid
			{
				get
				{
					return vid;
				}
				set	
				{
					vid = value;
				}
			}

			public int? ReviewNumber
			{
				get
				{
					return reviewNumber;
				}
				set	
				{
					reviewNumber = value;
				}
			}

			public List<GetReviewInfo_Dialogue> Dialogues
			{
				get
				{
					return dialogues;
				}
				set	
				{
					dialogues = value;
				}
			}

			public List<GetReviewInfo_ScorePo> HandScoreInfoList
			{
				get
				{
					return handScoreInfoList;
				}
				set	
				{
					handScoreInfoList = value;
				}
			}

			public List<GetReviewInfo_HitRuleReviewInfo> HitRuleReviewInfoList
			{
				get
				{
					return hitRuleReviewInfoList;
				}
				set	
				{
					hitRuleReviewInfoList = value;
				}
			}

			public List<string> ManualScoreMappingList
			{
				get
				{
					return manualScoreMappingList;
				}
				set	
				{
					manualScoreMappingList = value;
				}
			}

			public class GetReviewInfo_Dialogue
			{

				private string words;

				private string identity;

				private long? begin;

				private string beginTime;

				private int? emotionValue;

				private long? end;

				private int? speechRate;

				private string role;

				private int? silenceDuration;

				private string hourMinSec;

				public string Words
				{
					get
					{
						return words;
					}
					set	
					{
						words = value;
					}
				}

				public string Identity
				{
					get
					{
						return identity;
					}
					set	
					{
						identity = value;
					}
				}

				public long? Begin
				{
					get
					{
						return begin;
					}
					set	
					{
						begin = value;
					}
				}

				public string BeginTime
				{
					get
					{
						return beginTime;
					}
					set	
					{
						beginTime = value;
					}
				}

				public int? EmotionValue
				{
					get
					{
						return emotionValue;
					}
					set	
					{
						emotionValue = value;
					}
				}

				public long? End
				{
					get
					{
						return end;
					}
					set	
					{
						end = value;
					}
				}

				public int? SpeechRate
				{
					get
					{
						return speechRate;
					}
					set	
					{
						speechRate = value;
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

				public int? SilenceDuration
				{
					get
					{
						return silenceDuration;
					}
					set	
					{
						silenceDuration = value;
					}
				}

				public string HourMinSec
				{
					get
					{
						return hourMinSec;
					}
					set	
					{
						hourMinSec = value;
					}
				}
			}

			public class GetReviewInfo_ScorePo
			{

				private long? scoreId;

				private string scoreName;

				private List<GetReviewInfo_ScoreParam> scoreInfos;

				public long? ScoreId
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

				public List<GetReviewInfo_ScoreParam> ScoreInfos
				{
					get
					{
						return scoreInfos;
					}
					set	
					{
						scoreInfos = value;
					}
				}

				public class GetReviewInfo_ScoreParam
				{

					private string scoreSubName;

					private int? scoreNum;

					private int? hit;

					private long? scoreSubId;

					private int? scoreType;

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

					public int? Hit
					{
						get
						{
							return hit;
						}
						set	
						{
							hit = value;
						}
					}

					public long? ScoreSubId
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
				}
			}

			public class GetReviewInfo_HitRuleReviewInfo
			{

				private int? ruleScoreType;

				private int? ruleType;

				private int? autoReview;

				private long? scoreSubId;

				private int? totalNumber;

				private long? scoreId;

				private long? rid;

				private string ruleName;

				private List<GetReviewInfo_ConditionHitInfo> conditionHitInfoList;

				private GetReviewInfo_ReviewInfo reviewInfo;

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

				public int? RuleType
				{
					get
					{
						return ruleType;
					}
					set	
					{
						ruleType = value;
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

				public long? ScoreSubId
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

				public int? TotalNumber
				{
					get
					{
						return totalNumber;
					}
					set	
					{
						totalNumber = value;
					}
				}

				public long? ScoreId
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

				public List<GetReviewInfo_ConditionHitInfo> ConditionHitInfoList
				{
					get
					{
						return conditionHitInfoList;
					}
					set	
					{
						conditionHitInfoList = value;
					}
				}

				public GetReviewInfo_ReviewInfo ReviewInfo
				{
					get
					{
						return reviewInfo;
					}
					set	
					{
						reviewInfo = value;
					}
				}

				public class GetReviewInfo_ConditionHitInfo
				{

					private List<GetReviewInfo_KeyWord> keyWords;

					private List<string> cid;

					private GetReviewInfo_Phrase phrase;

					public List<GetReviewInfo_KeyWord> KeyWords
					{
						get
						{
							return keyWords;
						}
						set	
						{
							keyWords = value;
						}
					}

					public List<string> Cid
					{
						get
						{
							return cid;
						}
						set	
						{
							cid = value;
						}
					}

					public GetReviewInfo_Phrase Phrase
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

					public class GetReviewInfo_KeyWord
					{

						private int? to;

						private int? from;

						private string val;

						private string tid;

						private int? pid;

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

						public string Val
						{
							get
							{
								return val;
							}
							set	
							{
								val = value;
							}
						}

						public string Tid
						{
							get
							{
								return tid;
							}
							set	
							{
								tid = value;
							}
						}

						public int? Pid
						{
							get
							{
								return pid;
							}
							set	
							{
								pid = value;
							}
						}
					}

					public class GetReviewInfo_Phrase
					{

						private string words;

						private long? begin;

						private string identity;

						private int? pid;

						private int? emotionValue;

						private long? end;

						private string role;

						public string Words
						{
							get
							{
								return words;
							}
							set	
							{
								words = value;
							}
						}

						public long? Begin
						{
							get
							{
								return begin;
							}
							set	
							{
								begin = value;
							}
						}

						public string Identity
						{
							get
							{
								return identity;
							}
							set	
							{
								identity = value;
							}
						}

						public int? Pid
						{
							get
							{
								return pid;
							}
							set	
							{
								pid = value;
							}
						}

						public int? EmotionValue
						{
							get
							{
								return emotionValue;
							}
							set	
							{
								emotionValue = value;
							}
						}

						public long? End
						{
							get
							{
								return end;
							}
							set	
							{
								end = value;
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
					}
				}

				public class GetReviewInfo_ReviewInfo
				{

					private long? rid;

					private string hitId;

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

					public string HitId
					{
						get
						{
							return hitId;
						}
						set	
						{
							hitId = value;
						}
					}
				}
			}
		}
	}
}
