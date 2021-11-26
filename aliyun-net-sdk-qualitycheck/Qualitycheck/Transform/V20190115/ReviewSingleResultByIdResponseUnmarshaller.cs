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
    public class ReviewSingleResultByIdResponseUnmarshaller
    {
        public static ReviewSingleResultByIdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ReviewSingleResultByIdResponse reviewSingleResultByIdResponse = new ReviewSingleResultByIdResponse();

			reviewSingleResultByIdResponse.HttpResponse = _ctx.HttpResponse;
			reviewSingleResultByIdResponse.Code = _ctx.StringValue("ReviewSingleResultById.Code");
			reviewSingleResultByIdResponse.Message = _ctx.StringValue("ReviewSingleResultById.Message");
			reviewSingleResultByIdResponse.RequestId = _ctx.StringValue("ReviewSingleResultById.RequestId");
			reviewSingleResultByIdResponse.Success = _ctx.BooleanValue("ReviewSingleResultById.Success");

			ReviewSingleResultByIdResponse.ReviewSingleResultById_Data data = new ReviewSingleResultByIdResponse.ReviewSingleResultById_Data();
			data.AudioURL = _ctx.StringValue("ReviewSingleResultById.Data.AudioURL");
			data.HitNumber = _ctx.IntegerValue("ReviewSingleResultById.Data.HitNumber");
			data.NextVid = _ctx.StringValue("ReviewSingleResultById.Data.NextVid");
			data.PreVid = _ctx.StringValue("ReviewSingleResultById.Data.PreVid");
			data.IsAudio = _ctx.BooleanValue("ReviewSingleResultById.Data.IsAudio");
			data.AsrWordsCount = _ctx.IntegerValue("ReviewSingleResultById.Data.AsrWordsCount");
			data.Audio = _ctx.BooleanValue("ReviewSingleResultById.Data.Audio");
			data.TotalScore = _ctx.IntegerValue("ReviewSingleResultById.Data.TotalScore");
			data.BusinessType = _ctx.IntegerValue("ReviewSingleResultById.Data.BusinessType");
			data.FileMergeName = _ctx.StringValue("ReviewSingleResultById.Data.FileMergeName");
			data.IsDeleted = _ctx.BooleanValue("ReviewSingleResultById.Data.IsDeleted");
			data.Deleted = _ctx.BooleanValue("ReviewSingleResultById.Data.Deleted");
			data.Vid = _ctx.IntegerValue("ReviewSingleResultById.Data.Vid");
			data.ReviewNumber = _ctx.IntegerValue("ReviewSingleResultById.Data.ReviewNumber");

			List<string> data_manualScoreMappingList = new List<string>();
			for (int i = 0; i < _ctx.Length("ReviewSingleResultById.Data.ManualScoreMappingList.Length"); i++) {
				data_manualScoreMappingList.Add(_ctx.StringValue("ReviewSingleResultById.Data.ManualScoreMappingList["+ i +"]"));
			}
			data.ManualScoreMappingList = data_manualScoreMappingList;

			List<ReviewSingleResultByIdResponse.ReviewSingleResultById_Data.ReviewSingleResultById_Dialogue> data_dialogues = new List<ReviewSingleResultByIdResponse.ReviewSingleResultById_Data.ReviewSingleResultById_Dialogue>();
			for (int i = 0; i < _ctx.Length("ReviewSingleResultById.Data.Dialogues.Length"); i++) {
				ReviewSingleResultByIdResponse.ReviewSingleResultById_Data.ReviewSingleResultById_Dialogue dialogue = new ReviewSingleResultByIdResponse.ReviewSingleResultById_Data.ReviewSingleResultById_Dialogue();
				dialogue.Words = _ctx.StringValue("ReviewSingleResultById.Data.Dialogues["+ i +"].Words");
				dialogue.Identity = _ctx.StringValue("ReviewSingleResultById.Data.Dialogues["+ i +"].Identity");
				dialogue.Begin = _ctx.LongValue("ReviewSingleResultById.Data.Dialogues["+ i +"].Begin");
				dialogue.BeginTime = _ctx.LongValue("ReviewSingleResultById.Data.Dialogues["+ i +"].BeginTime");
				dialogue.EmotionValue = _ctx.IntegerValue("ReviewSingleResultById.Data.Dialogues["+ i +"].EmotionValue");
				dialogue.End = _ctx.LongValue("ReviewSingleResultById.Data.Dialogues["+ i +"].End");
				dialogue.SpeechRate = _ctx.IntegerValue("ReviewSingleResultById.Data.Dialogues["+ i +"].SpeechRate");
				dialogue.Role = _ctx.StringValue("ReviewSingleResultById.Data.Dialogues["+ i +"].Role");
				dialogue.SilenceDuration = _ctx.IntegerValue("ReviewSingleResultById.Data.Dialogues["+ i +"].SilenceDuration");
				dialogue.HourMinSec = _ctx.StringValue("ReviewSingleResultById.Data.Dialogues["+ i +"].HourMinSec");

				data_dialogues.Add(dialogue);
			}
			data.Dialogues = data_dialogues;

			List<ReviewSingleResultByIdResponse.ReviewSingleResultById_Data.ReviewSingleResultById_ScorePo> data_handScoreInfoList = new List<ReviewSingleResultByIdResponse.ReviewSingleResultById_Data.ReviewSingleResultById_ScorePo>();
			for (int i = 0; i < _ctx.Length("ReviewSingleResultById.Data.HandScoreInfoList.Length"); i++) {
				ReviewSingleResultByIdResponse.ReviewSingleResultById_Data.ReviewSingleResultById_ScorePo scorePo = new ReviewSingleResultByIdResponse.ReviewSingleResultById_Data.ReviewSingleResultById_ScorePo();
				scorePo.ScoreId = _ctx.LongValue("ReviewSingleResultById.Data.HandScoreInfoList["+ i +"].ScoreId");
				scorePo.ScoreName = _ctx.StringValue("ReviewSingleResultById.Data.HandScoreInfoList["+ i +"].ScoreName");

				List<ReviewSingleResultByIdResponse.ReviewSingleResultById_Data.ReviewSingleResultById_ScorePo.ReviewSingleResultById_ScoreParam> scorePo_scoreInfos = new List<ReviewSingleResultByIdResponse.ReviewSingleResultById_Data.ReviewSingleResultById_ScorePo.ReviewSingleResultById_ScoreParam>();
				for (int j = 0; j < _ctx.Length("ReviewSingleResultById.Data.HandScoreInfoList["+ i +"].ScoreInfos.Length"); j++) {
					ReviewSingleResultByIdResponse.ReviewSingleResultById_Data.ReviewSingleResultById_ScorePo.ReviewSingleResultById_ScoreParam scoreParam = new ReviewSingleResultByIdResponse.ReviewSingleResultById_Data.ReviewSingleResultById_ScorePo.ReviewSingleResultById_ScoreParam();
					scoreParam.ScoreSubName = _ctx.StringValue("ReviewSingleResultById.Data.HandScoreInfoList["+ i +"].ScoreInfos["+ j +"].ScoreSubName");
					scoreParam.ScoreNum = _ctx.IntegerValue("ReviewSingleResultById.Data.HandScoreInfoList["+ i +"].ScoreInfos["+ j +"].ScoreNum");
					scoreParam.Hit = _ctx.IntegerValue("ReviewSingleResultById.Data.HandScoreInfoList["+ i +"].ScoreInfos["+ j +"].Hit");
					scoreParam.ScoreSubId = _ctx.LongValue("ReviewSingleResultById.Data.HandScoreInfoList["+ i +"].ScoreInfos["+ j +"].ScoreSubId");
					scoreParam.ScoreType = _ctx.IntegerValue("ReviewSingleResultById.Data.HandScoreInfoList["+ i +"].ScoreInfos["+ j +"].ScoreType");

					scorePo_scoreInfos.Add(scoreParam);
				}
				scorePo.ScoreInfos = scorePo_scoreInfos;

				data_handScoreInfoList.Add(scorePo);
			}
			data.HandScoreInfoList = data_handScoreInfoList;

			List<ReviewSingleResultByIdResponse.ReviewSingleResultById_Data.ReviewSingleResultById_HitRuleReviewInfo> data_hitRuleReviewInfoList = new List<ReviewSingleResultByIdResponse.ReviewSingleResultById_Data.ReviewSingleResultById_HitRuleReviewInfo>();
			for (int i = 0; i < _ctx.Length("ReviewSingleResultById.Data.HitRuleReviewInfoList.Length"); i++) {
				ReviewSingleResultByIdResponse.ReviewSingleResultById_Data.ReviewSingleResultById_HitRuleReviewInfo hitRuleReviewInfo = new ReviewSingleResultByIdResponse.ReviewSingleResultById_Data.ReviewSingleResultById_HitRuleReviewInfo();
				hitRuleReviewInfo.RuleScoreType = _ctx.IntegerValue("ReviewSingleResultById.Data.HitRuleReviewInfoList["+ i +"].RuleScoreType");
				hitRuleReviewInfo.RuleType = _ctx.IntegerValue("ReviewSingleResultById.Data.HitRuleReviewInfoList["+ i +"].RuleType");
				hitRuleReviewInfo.AutoReview = _ctx.IntegerValue("ReviewSingleResultById.Data.HitRuleReviewInfoList["+ i +"].AutoReview");
				hitRuleReviewInfo.ScoreSubId = _ctx.LongValue("ReviewSingleResultById.Data.HitRuleReviewInfoList["+ i +"].ScoreSubId");
				hitRuleReviewInfo.Comments = _ctx.StringValue("ReviewSingleResultById.Data.HitRuleReviewInfoList["+ i +"].Comments");
				hitRuleReviewInfo.TotalNumber = _ctx.IntegerValue("ReviewSingleResultById.Data.HitRuleReviewInfoList["+ i +"].TotalNumber");
				hitRuleReviewInfo.ScoreId = _ctx.LongValue("ReviewSingleResultById.Data.HitRuleReviewInfoList["+ i +"].ScoreId");
				hitRuleReviewInfo.RuleName = _ctx.StringValue("ReviewSingleResultById.Data.HitRuleReviewInfoList["+ i +"].RuleName");
				hitRuleReviewInfo.Rid = _ctx.LongValue("ReviewSingleResultById.Data.HitRuleReviewInfoList["+ i +"].Rid");

				ReviewSingleResultByIdResponse.ReviewSingleResultById_Data.ReviewSingleResultById_HitRuleReviewInfo.ReviewSingleResultById_ReviewInfo reviewInfo = new ReviewSingleResultByIdResponse.ReviewSingleResultById_Data.ReviewSingleResultById_HitRuleReviewInfo.ReviewSingleResultById_ReviewInfo();
				reviewInfo.Rid = _ctx.LongValue("ReviewSingleResultById.Data.HitRuleReviewInfoList["+ i +"].ReviewInfo.Rid");
				reviewInfo.HitId = _ctx.StringValue("ReviewSingleResultById.Data.HitRuleReviewInfoList["+ i +"].ReviewInfo.HitId");
				hitRuleReviewInfo.ReviewInfo = reviewInfo;

				List<ReviewSingleResultByIdResponse.ReviewSingleResultById_Data.ReviewSingleResultById_HitRuleReviewInfo.ReviewSingleResultById_ConditionHitInfo> hitRuleReviewInfo_conditionHitInfoList = new List<ReviewSingleResultByIdResponse.ReviewSingleResultById_Data.ReviewSingleResultById_HitRuleReviewInfo.ReviewSingleResultById_ConditionHitInfo>();
				for (int j = 0; j < _ctx.Length("ReviewSingleResultById.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList.Length"); j++) {
					ReviewSingleResultByIdResponse.ReviewSingleResultById_Data.ReviewSingleResultById_HitRuleReviewInfo.ReviewSingleResultById_ConditionHitInfo conditionHitInfo = new ReviewSingleResultByIdResponse.ReviewSingleResultById_Data.ReviewSingleResultById_HitRuleReviewInfo.ReviewSingleResultById_ConditionHitInfo();

					List<string> conditionHitInfo_cid = new List<string>();
					for (int k = 0; k < _ctx.Length("ReviewSingleResultById.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].Cid.Length"); k++) {
						conditionHitInfo_cid.Add(_ctx.StringValue("ReviewSingleResultById.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].Cid["+ k +"]"));
					}
					conditionHitInfo.Cid = conditionHitInfo_cid;

					ReviewSingleResultByIdResponse.ReviewSingleResultById_Data.ReviewSingleResultById_HitRuleReviewInfo.ReviewSingleResultById_ConditionHitInfo.ReviewSingleResultById_Phrase phrase = new ReviewSingleResultByIdResponse.ReviewSingleResultById_Data.ReviewSingleResultById_HitRuleReviewInfo.ReviewSingleResultById_ConditionHitInfo.ReviewSingleResultById_Phrase();
					phrase.Words = _ctx.StringValue("ReviewSingleResultById.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].Phrase.Words");
					phrase.Begin = _ctx.LongValue("ReviewSingleResultById.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].Phrase.Begin");
					phrase.Identity = _ctx.StringValue("ReviewSingleResultById.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].Phrase.Identity");
					phrase.Pid = _ctx.IntegerValue("ReviewSingleResultById.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].Phrase.Pid");
					phrase.EmotionValue = _ctx.IntegerValue("ReviewSingleResultById.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].Phrase.EmotionValue");
					phrase.End = _ctx.LongValue("ReviewSingleResultById.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].Phrase.End");
					phrase.Role = _ctx.StringValue("ReviewSingleResultById.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].Phrase.Role");
					conditionHitInfo.Phrase = phrase;

					List<ReviewSingleResultByIdResponse.ReviewSingleResultById_Data.ReviewSingleResultById_HitRuleReviewInfo.ReviewSingleResultById_ConditionHitInfo.ReviewSingleResultById_KeyWord> conditionHitInfo_keyWords = new List<ReviewSingleResultByIdResponse.ReviewSingleResultById_Data.ReviewSingleResultById_HitRuleReviewInfo.ReviewSingleResultById_ConditionHitInfo.ReviewSingleResultById_KeyWord>();
					for (int k = 0; k < _ctx.Length("ReviewSingleResultById.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].KeyWords.Length"); k++) {
						ReviewSingleResultByIdResponse.ReviewSingleResultById_Data.ReviewSingleResultById_HitRuleReviewInfo.ReviewSingleResultById_ConditionHitInfo.ReviewSingleResultById_KeyWord keyWord = new ReviewSingleResultByIdResponse.ReviewSingleResultById_Data.ReviewSingleResultById_HitRuleReviewInfo.ReviewSingleResultById_ConditionHitInfo.ReviewSingleResultById_KeyWord();
						keyWord.To = _ctx.IntegerValue("ReviewSingleResultById.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].KeyWords["+ k +"].To");
						keyWord.From = _ctx.IntegerValue("ReviewSingleResultById.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].KeyWords["+ k +"].From");
						keyWord.Val = _ctx.StringValue("ReviewSingleResultById.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].KeyWords["+ k +"].Val");
						keyWord.Tid = _ctx.StringValue("ReviewSingleResultById.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].KeyWords["+ k +"].Tid");
						keyWord.Pid = _ctx.IntegerValue("ReviewSingleResultById.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].KeyWords["+ k +"].Pid");

						conditionHitInfo_keyWords.Add(keyWord);
					}
					conditionHitInfo.KeyWords = conditionHitInfo_keyWords;

					hitRuleReviewInfo_conditionHitInfoList.Add(conditionHitInfo);
				}
				hitRuleReviewInfo.ConditionHitInfoList = hitRuleReviewInfo_conditionHitInfoList;

				data_hitRuleReviewInfoList.Add(hitRuleReviewInfo);
			}
			data.HitRuleReviewInfoList = data_hitRuleReviewInfoList;
			reviewSingleResultByIdResponse.Data = data;
        
			return reviewSingleResultByIdResponse;
        }
    }
}
