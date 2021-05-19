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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Qualitycheck.Model.V20190115;

namespace Aliyun.Acs.Qualitycheck.Transform.V20190115
{
    public class GetResultToReviewResponseUnmarshaller
    {
        public static GetResultToReviewResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetResultToReviewResponse getResultToReviewResponse = new GetResultToReviewResponse();

			getResultToReviewResponse.HttpResponse = _ctx.HttpResponse;
			getResultToReviewResponse.RequestId = _ctx.StringValue("GetResultToReview.RequestId");
			getResultToReviewResponse.Success = _ctx.BooleanValue("GetResultToReview.Success");
			getResultToReviewResponse.Code = _ctx.StringValue("GetResultToReview.Code");
			getResultToReviewResponse.Message = _ctx.StringValue("GetResultToReview.Message");

			GetResultToReviewResponse.GetResultToReview_Data data = new GetResultToReviewResponse.GetResultToReview_Data();
			data.Audio = _ctx.BooleanValue("GetResultToReview.Data.Audio");
			data.AudioScheme = _ctx.StringValue("GetResultToReview.Data.AudioScheme");
			data.AudioURL = _ctx.StringValue("GetResultToReview.Data.AudioURL");
			data.BusinessType = _ctx.IntegerValue("GetResultToReview.Data.BusinessType");
			data.Deleted = _ctx.BooleanValue("GetResultToReview.Data.Deleted");
			data.FileMergeName = _ctx.StringValue("GetResultToReview.Data.FileMergeName");
			data.HitNumber = _ctx.IntegerValue("GetResultToReview.Data.HitNumber");
			data.ReviewNumber = _ctx.IntegerValue("GetResultToReview.Data.ReviewNumber");
			data.TotalScore = _ctx.IntegerValue("GetResultToReview.Data.TotalScore");
			data.Vid = _ctx.StringValue("GetResultToReview.Data.Vid");
			data.Comments = _ctx.StringValue("GetResultToReview.Data.Comments");
			data.FileId = _ctx.StringValue("GetResultToReview.Data.FileId");
			data.Status = _ctx.IntegerValue("GetResultToReview.Data.Status");

			List<GetResultToReviewResponse.GetResultToReview_Data.GetResultToReview_Dialogue> data_dialogues = new List<GetResultToReviewResponse.GetResultToReview_Data.GetResultToReview_Dialogue>();
			for (int i = 0; i < _ctx.Length("GetResultToReview.Data.Dialogues.Length"); i++) {
				GetResultToReviewResponse.GetResultToReview_Data.GetResultToReview_Dialogue dialogue = new GetResultToReviewResponse.GetResultToReview_Data.GetResultToReview_Dialogue();
				dialogue.Begin = _ctx.LongValue("GetResultToReview.Data.Dialogues["+ i +"].Begin");
				dialogue.BeginTime = _ctx.StringValue("GetResultToReview.Data.Dialogues["+ i +"].BeginTime");
				dialogue.EmotionValue = _ctx.IntegerValue("GetResultToReview.Data.Dialogues["+ i +"].EmotionValue");
				dialogue.End = _ctx.LongValue("GetResultToReview.Data.Dialogues["+ i +"].End");
				dialogue.HourMinSec = _ctx.StringValue("GetResultToReview.Data.Dialogues["+ i +"].HourMinSec");
				dialogue.Identity = _ctx.StringValue("GetResultToReview.Data.Dialogues["+ i +"].Identity");
				dialogue.Role = _ctx.StringValue("GetResultToReview.Data.Dialogues["+ i +"].Role");
				dialogue.SilenceDuration = _ctx.IntegerValue("GetResultToReview.Data.Dialogues["+ i +"].SilenceDuration");
				dialogue.SpeechRate = _ctx.IntegerValue("GetResultToReview.Data.Dialogues["+ i +"].SpeechRate");
				dialogue.Words = _ctx.StringValue("GetResultToReview.Data.Dialogues["+ i +"].Words");

				data_dialogues.Add(dialogue);
			}
			data.Dialogues = data_dialogues;

			List<GetResultToReviewResponse.GetResultToReview_Data.GetResultToReview_ScorePo> data_handScoreInfoList = new List<GetResultToReviewResponse.GetResultToReview_Data.GetResultToReview_ScorePo>();
			for (int i = 0; i < _ctx.Length("GetResultToReview.Data.HandScoreInfoList.Length"); i++) {
				GetResultToReviewResponse.GetResultToReview_Data.GetResultToReview_ScorePo scorePo = new GetResultToReviewResponse.GetResultToReview_Data.GetResultToReview_ScorePo();
				scorePo.ScoreId = _ctx.LongValue("GetResultToReview.Data.HandScoreInfoList["+ i +"].ScoreId");
				scorePo.ScoreName = _ctx.StringValue("GetResultToReview.Data.HandScoreInfoList["+ i +"].ScoreName");

				List<GetResultToReviewResponse.GetResultToReview_Data.GetResultToReview_ScorePo.GetResultToReview_ScoreParam> scorePo_scoreInfos = new List<GetResultToReviewResponse.GetResultToReview_Data.GetResultToReview_ScorePo.GetResultToReview_ScoreParam>();
				for (int j = 0; j < _ctx.Length("GetResultToReview.Data.HandScoreInfoList["+ i +"].ScoreInfos.Length"); j++) {
					GetResultToReviewResponse.GetResultToReview_Data.GetResultToReview_ScorePo.GetResultToReview_ScoreParam scoreParam = new GetResultToReviewResponse.GetResultToReview_Data.GetResultToReview_ScorePo.GetResultToReview_ScoreParam();
					scoreParam.Hit = _ctx.IntegerValue("GetResultToReview.Data.HandScoreInfoList["+ i +"].ScoreInfos["+ j +"].Hit");
					scoreParam.ScoreNum = _ctx.IntegerValue("GetResultToReview.Data.HandScoreInfoList["+ i +"].ScoreInfos["+ j +"].ScoreNum");
					scoreParam.ScoreSubId = _ctx.LongValue("GetResultToReview.Data.HandScoreInfoList["+ i +"].ScoreInfos["+ j +"].ScoreSubId");
					scoreParam.ScoreSubName = _ctx.StringValue("GetResultToReview.Data.HandScoreInfoList["+ i +"].ScoreInfos["+ j +"].ScoreSubName");
					scoreParam.ScoreType = _ctx.IntegerValue("GetResultToReview.Data.HandScoreInfoList["+ i +"].ScoreInfos["+ j +"].ScoreType");

					scorePo_scoreInfos.Add(scoreParam);
				}
				scorePo.ScoreInfos = scorePo_scoreInfos;

				data_handScoreInfoList.Add(scorePo);
			}
			data.HandScoreInfoList = data_handScoreInfoList;

			List<GetResultToReviewResponse.GetResultToReview_Data.GetResultToReview_HitRuleReviewInfo> data_hitRuleReviewInfoList = new List<GetResultToReviewResponse.GetResultToReview_Data.GetResultToReview_HitRuleReviewInfo>();
			for (int i = 0; i < _ctx.Length("GetResultToReview.Data.HitRuleReviewInfoList.Length"); i++) {
				GetResultToReviewResponse.GetResultToReview_Data.GetResultToReview_HitRuleReviewInfo hitRuleReviewInfo = new GetResultToReviewResponse.GetResultToReview_Data.GetResultToReview_HitRuleReviewInfo();
				hitRuleReviewInfo.AutoReview = _ctx.IntegerValue("GetResultToReview.Data.HitRuleReviewInfoList["+ i +"].AutoReview");
				hitRuleReviewInfo.Rid = _ctx.LongValue("GetResultToReview.Data.HitRuleReviewInfoList["+ i +"].Rid");
				hitRuleReviewInfo.RuleName = _ctx.StringValue("GetResultToReview.Data.HitRuleReviewInfoList["+ i +"].RuleName");
				hitRuleReviewInfo.RuleScoreType = _ctx.IntegerValue("GetResultToReview.Data.HitRuleReviewInfoList["+ i +"].RuleScoreType");
				hitRuleReviewInfo.RuleType = _ctx.IntegerValue("GetResultToReview.Data.HitRuleReviewInfoList["+ i +"].RuleType");
				hitRuleReviewInfo.ScoreId = _ctx.LongValue("GetResultToReview.Data.HitRuleReviewInfoList["+ i +"].ScoreId");
				hitRuleReviewInfo.ScoreSubId = _ctx.LongValue("GetResultToReview.Data.HitRuleReviewInfoList["+ i +"].ScoreSubId");
				hitRuleReviewInfo.TotalNumber = _ctx.IntegerValue("GetResultToReview.Data.HitRuleReviewInfoList["+ i +"].TotalNumber");
				hitRuleReviewInfo.ScoreSubName = _ctx.StringValue("GetResultToReview.Data.HitRuleReviewInfoList["+ i +"].ScoreSubName");
				hitRuleReviewInfo.ScoreNum = _ctx.IntegerValue("GetResultToReview.Data.HitRuleReviewInfoList["+ i +"].ScoreNum");
				hitRuleReviewInfo.Complainable = _ctx.BooleanValue("GetResultToReview.Data.HitRuleReviewInfoList["+ i +"].Complainable");

				GetResultToReviewResponse.GetResultToReview_Data.GetResultToReview_HitRuleReviewInfo.GetResultToReview_ReviewInfo reviewInfo = new GetResultToReviewResponse.GetResultToReview_Data.GetResultToReview_HitRuleReviewInfo.GetResultToReview_ReviewInfo();
				reviewInfo.HitId = _ctx.StringValue("GetResultToReview.Data.HitRuleReviewInfoList["+ i +"].ReviewInfo.HitId");
				reviewInfo.Rid = _ctx.LongValue("GetResultToReview.Data.HitRuleReviewInfoList["+ i +"].ReviewInfo.Rid");
				reviewInfo.ReviewResult = _ctx.IntegerValue("GetResultToReview.Data.HitRuleReviewInfoList["+ i +"].ReviewInfo.ReviewResult");
				reviewInfo.Reviewer = _ctx.StringValue("GetResultToReview.Data.HitRuleReviewInfoList["+ i +"].ReviewInfo.Reviewer");
				reviewInfo.ReviewTime = _ctx.StringValue("GetResultToReview.Data.HitRuleReviewInfoList["+ i +"].ReviewInfo.ReviewTime");
				hitRuleReviewInfo.ReviewInfo = reviewInfo;

				List<GetResultToReviewResponse.GetResultToReview_Data.GetResultToReview_HitRuleReviewInfo.GetResultToReview_ConditionHitInfo> hitRuleReviewInfo_conditionHitInfoList = new List<GetResultToReviewResponse.GetResultToReview_Data.GetResultToReview_HitRuleReviewInfo.GetResultToReview_ConditionHitInfo>();
				for (int j = 0; j < _ctx.Length("GetResultToReview.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList.Length"); j++) {
					GetResultToReviewResponse.GetResultToReview_Data.GetResultToReview_HitRuleReviewInfo.GetResultToReview_ConditionHitInfo conditionHitInfo = new GetResultToReviewResponse.GetResultToReview_Data.GetResultToReview_HitRuleReviewInfo.GetResultToReview_ConditionHitInfo();

					List<string> conditionHitInfo_cid = new List<string>();
					for (int k = 0; k < _ctx.Length("GetResultToReview.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].Cid.Length"); k++) {
						conditionHitInfo_cid.Add(_ctx.StringValue("GetResultToReview.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].Cid["+ k +"]"));
					}
					conditionHitInfo.Cid = conditionHitInfo_cid;

					GetResultToReviewResponse.GetResultToReview_Data.GetResultToReview_HitRuleReviewInfo.GetResultToReview_ConditionHitInfo.GetResultToReview_Phrase phrase = new GetResultToReviewResponse.GetResultToReview_Data.GetResultToReview_HitRuleReviewInfo.GetResultToReview_ConditionHitInfo.GetResultToReview_Phrase();
					phrase.Role = _ctx.StringValue("GetResultToReview.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].Phrase.Role");
					phrase.Identity = _ctx.StringValue("GetResultToReview.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].Phrase.Identity");
					phrase.EmotionValue = _ctx.IntegerValue("GetResultToReview.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].Phrase.EmotionValue");
					phrase.Words = _ctx.StringValue("GetResultToReview.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].Phrase.Words");
					phrase.End = _ctx.LongValue("GetResultToReview.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].Phrase.End");
					phrase.Pid = _ctx.IntegerValue("GetResultToReview.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].Phrase.Pid");
					phrase.Begin = _ctx.LongValue("GetResultToReview.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].Phrase.Begin");
					conditionHitInfo.Phrase = phrase;

					List<GetResultToReviewResponse.GetResultToReview_Data.GetResultToReview_HitRuleReviewInfo.GetResultToReview_ConditionHitInfo.GetResultToReview_KeyWord> conditionHitInfo_keyWords = new List<GetResultToReviewResponse.GetResultToReview_Data.GetResultToReview_HitRuleReviewInfo.GetResultToReview_ConditionHitInfo.GetResultToReview_KeyWord>();
					for (int k = 0; k < _ctx.Length("GetResultToReview.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].KeyWords.Length"); k++) {
						GetResultToReviewResponse.GetResultToReview_Data.GetResultToReview_HitRuleReviewInfo.GetResultToReview_ConditionHitInfo.GetResultToReview_KeyWord keyWord = new GetResultToReviewResponse.GetResultToReview_Data.GetResultToReview_HitRuleReviewInfo.GetResultToReview_ConditionHitInfo.GetResultToReview_KeyWord();
						keyWord.Val = _ctx.StringValue("GetResultToReview.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].KeyWords["+ k +"].Val");
						keyWord.Pid = _ctx.IntegerValue("GetResultToReview.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].KeyWords["+ k +"].Pid");
						keyWord.From = _ctx.IntegerValue("GetResultToReview.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].KeyWords["+ k +"].From");
						keyWord.To = _ctx.IntegerValue("GetResultToReview.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].KeyWords["+ k +"].To");
						keyWord.Tid = _ctx.StringValue("GetResultToReview.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].KeyWords["+ k +"].Tid");
						keyWord.Cid = _ctx.StringValue("GetResultToReview.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].KeyWords["+ k +"].Cid");

						conditionHitInfo_keyWords.Add(keyWord);
					}
					conditionHitInfo.KeyWords = conditionHitInfo_keyWords;

					hitRuleReviewInfo_conditionHitInfoList.Add(conditionHitInfo);
				}
				hitRuleReviewInfo.ConditionHitInfoList = hitRuleReviewInfo_conditionHitInfoList;

				List<GetResultToReviewResponse.GetResultToReview_Data.GetResultToReview_HitRuleReviewInfo.GetResultToReview_ComplainHistoriesItem> hitRuleReviewInfo_complainHistories = new List<GetResultToReviewResponse.GetResultToReview_Data.GetResultToReview_HitRuleReviewInfo.GetResultToReview_ComplainHistoriesItem>();
				for (int j = 0; j < _ctx.Length("GetResultToReview.Data.HitRuleReviewInfoList["+ i +"].ComplainHistories.Length"); j++) {
					GetResultToReviewResponse.GetResultToReview_Data.GetResultToReview_HitRuleReviewInfo.GetResultToReview_ComplainHistoriesItem complainHistoriesItem = new GetResultToReviewResponse.GetResultToReview_Data.GetResultToReview_HitRuleReviewInfo.GetResultToReview_ComplainHistoriesItem();
					complainHistoriesItem.Comments = _ctx.StringValue("GetResultToReview.Data.HitRuleReviewInfoList["+ i +"].ComplainHistories["+ j +"].Comments");
					complainHistoriesItem.OperatorName = _ctx.StringValue("GetResultToReview.Data.HitRuleReviewInfoList["+ i +"].ComplainHistories["+ j +"].OperatorName");
					complainHistoriesItem._Operator = _ctx.LongValue("GetResultToReview.Data.HitRuleReviewInfoList["+ i +"].ComplainHistories["+ j +"].Operator");
					complainHistoriesItem.OperationType = _ctx.IntegerValue("GetResultToReview.Data.HitRuleReviewInfoList["+ i +"].ComplainHistories["+ j +"].OperationType");
					complainHistoriesItem.OperationTime = _ctx.StringValue("GetResultToReview.Data.HitRuleReviewInfoList["+ i +"].ComplainHistories["+ j +"].OperationTime");

					hitRuleReviewInfo_complainHistories.Add(complainHistoriesItem);
				}
				hitRuleReviewInfo.ComplainHistories = hitRuleReviewInfo_complainHistories;

				data_hitRuleReviewInfoList.Add(hitRuleReviewInfo);
			}
			data.HitRuleReviewInfoList = data_hitRuleReviewInfoList;

			List<GetResultToReviewResponse.GetResultToReview_Data.GetResultToReview_ManualScoreInfo> data_manualScoreInfoList = new List<GetResultToReviewResponse.GetResultToReview_Data.GetResultToReview_ManualScoreInfo>();
			for (int i = 0; i < _ctx.Length("GetResultToReview.Data.ManualScoreInfoList.Length"); i++) {
				GetResultToReviewResponse.GetResultToReview_Data.GetResultToReview_ManualScoreInfo manualScoreInfo = new GetResultToReviewResponse.GetResultToReview_Data.GetResultToReview_ManualScoreInfo();
				manualScoreInfo.ScoreId = _ctx.LongValue("GetResultToReview.Data.ManualScoreInfoList["+ i +"].ScoreId");
				manualScoreInfo.ScoreSubId = _ctx.LongValue("GetResultToReview.Data.ManualScoreInfoList["+ i +"].ScoreSubId");
				manualScoreInfo.ScoreSubName = _ctx.StringValue("GetResultToReview.Data.ManualScoreInfoList["+ i +"].ScoreSubName");
				manualScoreInfo.ScoreNum = _ctx.IntegerValue("GetResultToReview.Data.ManualScoreInfoList["+ i +"].ScoreNum");
				manualScoreInfo.Complainable = _ctx.BooleanValue("GetResultToReview.Data.ManualScoreInfoList["+ i +"].Complainable");

				List<GetResultToReviewResponse.GetResultToReview_Data.GetResultToReview_ManualScoreInfo.GetResultToReview_ComplainHistoriesItem2> manualScoreInfo_complainHistories1 = new List<GetResultToReviewResponse.GetResultToReview_Data.GetResultToReview_ManualScoreInfo.GetResultToReview_ComplainHistoriesItem2>();
				for (int j = 0; j < _ctx.Length("GetResultToReview.Data.ManualScoreInfoList["+ i +"].ComplainHistories.Length"); j++) {
					GetResultToReviewResponse.GetResultToReview_Data.GetResultToReview_ManualScoreInfo.GetResultToReview_ComplainHistoriesItem2 complainHistoriesItem2 = new GetResultToReviewResponse.GetResultToReview_Data.GetResultToReview_ManualScoreInfo.GetResultToReview_ComplainHistoriesItem2();
					complainHistoriesItem2.Comments = _ctx.StringValue("GetResultToReview.Data.ManualScoreInfoList["+ i +"].ComplainHistories["+ j +"].Comments");
					complainHistoriesItem2.OperatorName = _ctx.StringValue("GetResultToReview.Data.ManualScoreInfoList["+ i +"].ComplainHistories["+ j +"].OperatorName");
					complainHistoriesItem2._Operator = _ctx.LongValue("GetResultToReview.Data.ManualScoreInfoList["+ i +"].ComplainHistories["+ j +"].Operator");
					complainHistoriesItem2.OperationType = _ctx.IntegerValue("GetResultToReview.Data.ManualScoreInfoList["+ i +"].ComplainHistories["+ j +"].OperationType");
					complainHistoriesItem2.OperationTime = _ctx.StringValue("GetResultToReview.Data.ManualScoreInfoList["+ i +"].ComplainHistories["+ j +"].OperationTime");

					manualScoreInfo_complainHistories1.Add(complainHistoriesItem2);
				}
				manualScoreInfo.ComplainHistories1 = manualScoreInfo_complainHistories1;

				data_manualScoreInfoList.Add(manualScoreInfo);
			}
			data.ManualScoreInfoList = data_manualScoreInfoList;

			List<GetResultToReviewResponse.GetResultToReview_Data.GetResultToReview_ReviewHistory> data_reviewHistoryList = new List<GetResultToReviewResponse.GetResultToReview_Data.GetResultToReview_ReviewHistory>();
			for (int i = 0; i < _ctx.Length("GetResultToReview.Data.ReviewHistoryList.Length"); i++) {
				GetResultToReviewResponse.GetResultToReview_Data.GetResultToReview_ReviewHistory reviewHistory = new GetResultToReviewResponse.GetResultToReview_Data.GetResultToReview_ReviewHistory();
				reviewHistory.TimeStr = _ctx.StringValue("GetResultToReview.Data.ReviewHistoryList["+ i +"].TimeStr");
				reviewHistory.OperatorName = _ctx.StringValue("GetResultToReview.Data.ReviewHistoryList["+ i +"].OperatorName");
				reviewHistory.Type = _ctx.IntegerValue("GetResultToReview.Data.ReviewHistoryList["+ i +"].Type");
				reviewHistory.ReviewResult = _ctx.IntegerValue("GetResultToReview.Data.ReviewHistoryList["+ i +"].ReviewResult");
				reviewHistory.ComplainResult = _ctx.IntegerValue("GetResultToReview.Data.ReviewHistoryList["+ i +"].ComplainResult");
				reviewHistory.OldScore = _ctx.IntegerValue("GetResultToReview.Data.ReviewHistoryList["+ i +"].OldScore");
				reviewHistory.Score = _ctx.IntegerValue("GetResultToReview.Data.ReviewHistoryList["+ i +"].Score");

				data_reviewHistoryList.Add(reviewHistory);
			}
			data.ReviewHistoryList = data_reviewHistoryList;
			getResultToReviewResponse.Data = data;
        
			return getResultToReviewResponse;
        }
    }
}
