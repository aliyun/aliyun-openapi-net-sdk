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
	public class GetResultToReviewResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private bool? success;

		private GetResultToReview_Data data;

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

			private int? status;

			private string audioScheme;

			private string audioURL;

			private int? hitNumber;

			private bool? audio;

			private int? totalScore;

			private int? businessType;

			private string fileId;

			private string fileMergeName;

			private string comments;

			private bool? deleted;

			private string vid;

			private int? reviewNumber;

			private List<GetResultToReview_Dialogue> dialogues;

			private List<GetResultToReview_ScorePo> handScoreInfoList;

			private List<GetResultToReview_HitRuleReviewInfo> hitRuleReviewInfoList;

			private List<GetResultToReview_ManualScoreInfo> manualScoreInfoList;

			private List<GetResultToReview_ReviewHistory> reviewHistoryList;

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

			public class GetResultToReview_HitRuleReviewInfo
			{

				private int? ruleScoreType;

				private int? ruleType;

				private string scoreSubName;

				private int? scoreNum;

				private int? autoReview;

				private long? scoreSubId;

				private bool? complainable;

				private int? totalNumber;

				private long? scoreId;

				private string ruleName;

				private long? rid;

				private List<GetResultToReview_ConditionHitInfo> conditionHitInfoList;

				private List<GetResultToReview_ComplainHistoriesItem> complainHistories;

				private GetResultToReview_ReviewInfo reviewInfo;

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

						private int? from;

						private string val;

						private int? pid;

						private string tid;

						private string cid;

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

					public class GetResultToReview_Phrase
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

				public class GetResultToReview_ComplainHistoriesItem
				{

					private string comments;

					private long? _operator;

					private string operationTime;

					private int? operationType;

					private string operatorName;

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
				}

				public class GetResultToReview_ReviewInfo
				{

					private int? reviewResult;

					private string reviewTime;

					private string hitId;

					private string reviewer;

					private long? rid;

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

			public class GetResultToReview_ManualScoreInfo
			{

				private string scoreSubName;

				private bool? complainable;

				private int? scoreNum;

				private long? scoreSubId;

				private long? scoreId;

				private List<GetResultToReview_ComplainHistoriesItem2> complainHistories1;

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

					private long? _operator;

					private string operationTime;

					private int? operationType;

					private string operatorName;

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
				}
			}

			public class GetResultToReview_ReviewHistory
			{

				private int? type;

				private string operatorName;

				private string timeStr;

				private int? score;

				private int? reviewResult;

				private int? complainResult;

				private int? oldScore;

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
			}
		}
	}
}
