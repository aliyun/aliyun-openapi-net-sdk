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
	public class GetResultToReviewResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private GetResultToReview_Data data;

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

		public GetResultToReview_Data Data
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

		public class GetResultToReview_Data
		{

			private bool? audio;

			private string audioScheme;

			private string audioURL;

			private int? businessType;

			private bool? deleted;

			private string fileMergeName;

			private int? hitNumber;

			private int? reviewNumber;

			private int? totalScore;

			private string vid;

			private string comments;

			private string fileId;

			private int? status;

			private List<GetResultToReview_Dialogue> dialogues;

			private List<GetResultToReview_ScorePo> handScoreInfoList;

			private List<GetResultToReview_HitRuleReviewInfo> hitRuleReviewInfoList;

			private List<GetResultToReview_ManualScoreInfo> manualScoreInfoList;

			private List<GetResultToReview_ReviewHistory> reviewHistoryList;

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

			public string AudioScheme
			{
				get
				{
					return audioScheme;
				}
				set	
				{
					audioScheme = value;
				}
			}

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

			public string FileId
			{
				get
				{
					return fileId;
				}
				set	
				{
					fileId = value;
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

			public List<GetResultToReview_Dialogue> Dialogues
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

			public List<GetResultToReview_ScorePo> HandScoreInfoList
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

			public List<GetResultToReview_HitRuleReviewInfo> HitRuleReviewInfoList
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

			public List<GetResultToReview_ManualScoreInfo> ManualScoreInfoList
			{
				get
				{
					return manualScoreInfoList;
				}
				set	
				{
					manualScoreInfoList = value;
				}
			}

			public List<GetResultToReview_ReviewHistory> ReviewHistoryList
			{
				get
				{
					return reviewHistoryList;
				}
				set	
				{
					reviewHistoryList = value;
				}
			}

			public class GetResultToReview_Dialogue
			{

				private long? begin;

				private string beginTime;

				private int? emotionValue;

				private long? end;

				private string hourMinSec;

				private string identity;

				private string role;

				private int? silenceDuration;

				private int? speechRate;

				private string words;

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
			}

			public class GetResultToReview_ScorePo
			{

				private long? scoreId;

				private string scoreName;

				private List<GetResultToReview_ScoreParam> scoreInfos;

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

				public List<GetResultToReview_ScoreParam> ScoreInfos
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

				public class GetResultToReview_ScoreParam
				{

					private int? hit;

					private int? scoreNum;

					private long? scoreSubId;

					private string scoreSubName;

					private int? scoreType;

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

			public class GetResultToReview_HitRuleReviewInfo
			{

				private int? autoReview;

				private long? rid;

				private string ruleName;

				private int? ruleScoreType;

				private int? ruleType;

				private long? scoreId;

				private long? scoreSubId;

				private int? totalNumber;

				private string scoreSubName;

				private int? scoreNum;

				private bool? complainable;

				private List<GetResultToReview_ConditionHitInfo> conditionHitInfoList;

				private List<GetResultToReview_ComplainHistoriesItem> complainHistories;

				private GetResultToReview_ReviewInfo reviewInfo;

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

				public bool? Complainable
				{
					get
					{
						return complainable;
					}
					set	
					{
						complainable = value;
					}
				}

				public List<GetResultToReview_ConditionHitInfo> ConditionHitInfoList
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

				public List<GetResultToReview_ComplainHistoriesItem> ComplainHistories
				{
					get
					{
						return complainHistories;
					}
					set	
					{
						complainHistories = value;
					}
				}

				public GetResultToReview_ReviewInfo ReviewInfo
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

				public class GetResultToReview_ConditionHitInfo
				{

					private List<GetResultToReview_KeyWord> keyWords;

					private List<string> cid;

					private GetResultToReview_Phrase phrase;

					public List<GetResultToReview_KeyWord> KeyWords
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

					public GetResultToReview_Phrase Phrase
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

					public class GetResultToReview_KeyWord
					{

						private string val;

						private int? pid;

						private int? from;

						private int? to;

						private string tid;

						private string cid;

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

						public string Cid
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
					}

					public class GetResultToReview_Phrase
					{

						private string role;

						private string identity;

						private int? emotionValue;

						private string words;

						private long? end;

						private int? pid;

						private long? begin;

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
					}
				}

				public class GetResultToReview_ComplainHistoriesItem
				{

					private string comments;

					private string operatorName;

					private long? _operator;

					private int? operationType;

					private string operationTime;

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

					public string OperatorName
					{
						get
						{
							return operatorName;
						}
						set	
						{
							operatorName = value;
						}
					}

					public long? _Operator
					{
						get
						{
							return _operator;
						}
						set	
						{
							_operator = value;
						}
					}

					public int? OperationType
					{
						get
						{
							return operationType;
						}
						set	
						{
							operationType = value;
						}
					}

					public string OperationTime
					{
						get
						{
							return operationTime;
						}
						set	
						{
							operationTime = value;
						}
					}
				}

				public class GetResultToReview_ReviewInfo
				{

					private string hitId;

					private long? rid;

					private int? reviewResult;

					private string reviewer;

					private string reviewTime;

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

					public int? ReviewResult
					{
						get
						{
							return reviewResult;
						}
						set	
						{
							reviewResult = value;
						}
					}

					public string Reviewer
					{
						get
						{
							return reviewer;
						}
						set	
						{
							reviewer = value;
						}
					}

					public string ReviewTime
					{
						get
						{
							return reviewTime;
						}
						set	
						{
							reviewTime = value;
						}
					}
				}
			}

			public class GetResultToReview_ManualScoreInfo
			{

				private long? scoreId;

				private long? scoreSubId;

				private string scoreSubName;

				private int? scoreNum;

				private bool? complainable;

				private List<GetResultToReview_ComplainHistoriesItem2> complainHistories1;

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

				public bool? Complainable
				{
					get
					{
						return complainable;
					}
					set	
					{
						complainable = value;
					}
				}

				public List<GetResultToReview_ComplainHistoriesItem2> ComplainHistories1
				{
					get
					{
						return complainHistories1;
					}
					set	
					{
						complainHistories1 = value;
					}
				}

				public class GetResultToReview_ComplainHistoriesItem2
				{

					private string comments;

					private string operatorName;

					private long? _operator;

					private int? operationType;

					private string operationTime;

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

					public string OperatorName
					{
						get
						{
							return operatorName;
						}
						set	
						{
							operatorName = value;
						}
					}

					public long? _Operator
					{
						get
						{
							return _operator;
						}
						set	
						{
							_operator = value;
						}
					}

					public int? OperationType
					{
						get
						{
							return operationType;
						}
						set	
						{
							operationType = value;
						}
					}

					public string OperationTime
					{
						get
						{
							return operationTime;
						}
						set	
						{
							operationTime = value;
						}
					}
				}
			}

			public class GetResultToReview_ReviewHistory
			{

				private string timeStr;

				private string operatorName;

				private int? type;

				private int? reviewResult;

				private int? complainResult;

				private int? oldScore;

				private int? score;

				public string TimeStr
				{
					get
					{
						return timeStr;
					}
					set	
					{
						timeStr = value;
					}
				}

				public string OperatorName
				{
					get
					{
						return operatorName;
					}
					set	
					{
						operatorName = value;
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

				public int? ReviewResult
				{
					get
					{
						return reviewResult;
					}
					set	
					{
						reviewResult = value;
					}
				}

				public int? ComplainResult
				{
					get
					{
						return complainResult;
					}
					set	
					{
						complainResult = value;
					}
				}

				public int? OldScore
				{
					get
					{
						return oldScore;
					}
					set	
					{
						oldScore = value;
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
		}
	}
}
