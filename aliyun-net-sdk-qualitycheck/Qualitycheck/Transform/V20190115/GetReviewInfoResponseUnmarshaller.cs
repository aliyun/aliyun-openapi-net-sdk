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
    public class GetReviewInfoResponseUnmarshaller
    {
        public static GetReviewInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetReviewInfoResponse getReviewInfoResponse = new GetReviewInfoResponse();

			getReviewInfoResponse.HttpResponse = _ctx.HttpResponse;
			getReviewInfoResponse.Code = _ctx.StringValue("GetReviewInfo.Code");
			getReviewInfoResponse.Message = _ctx.StringValue("GetReviewInfo.Message");
			getReviewInfoResponse.RequestId = _ctx.StringValue("GetReviewInfo.RequestId");
			getReviewInfoResponse.Success = _ctx.BooleanValue("GetReviewInfo.Success");

			GetReviewInfoResponse.GetReviewInfo_Data data = new GetReviewInfoResponse.GetReviewInfo_Data();
			data.AudioURL = _ctx.StringValue("GetReviewInfo.Data.AudioURL");
			data.HitNumber = _ctx.IntegerValue("GetReviewInfo.Data.HitNumber");
			data.NextVid = _ctx.StringValue("GetReviewInfo.Data.NextVid");
			data.PreVid = _ctx.StringValue("GetReviewInfo.Data.PreVid");
			data.IsAudio = _ctx.BooleanValue("GetReviewInfo.Data.IsAudio");
			data.AsrWordsCount = _ctx.IntegerValue("GetReviewInfo.Data.AsrWordsCount");
			data.Audio = _ctx.BooleanValue("GetReviewInfo.Data.Audio");
			data.TotalScore = _ctx.IntegerValue("GetReviewInfo.Data.TotalScore");
			data.BusinessType = _ctx.IntegerValue("GetReviewInfo.Data.BusinessType");
			data.FileMergeName = _ctx.StringValue("GetReviewInfo.Data.FileMergeName");
			data.IsDeleted = _ctx.BooleanValue("GetReviewInfo.Data.IsDeleted");
			data.Deleted = _ctx.BooleanValue("GetReviewInfo.Data.Deleted");
			data.Vid = _ctx.StringValue("GetReviewInfo.Data.Vid");
			data.ReviewNumber = _ctx.IntegerValue("GetReviewInfo.Data.ReviewNumber");

			List<string> data_manualScoreMappingList = new List<string>();
			for (int i = 0; i < _ctx.Length("GetReviewInfo.Data.ManualScoreMappingList.Length"); i++) {
				data_manualScoreMappingList.Add(_ctx.StringValue("GetReviewInfo.Data.ManualScoreMappingList["+ i +"]"));
			}
			data.ManualScoreMappingList = data_manualScoreMappingList;

			List<GetReviewInfoResponse.GetReviewInfo_Data.GetReviewInfo_Dialogue> data_dialogues = new List<GetReviewInfoResponse.GetReviewInfo_Data.GetReviewInfo_Dialogue>();
			for (int i = 0; i < _ctx.Length("GetReviewInfo.Data.Dialogues.Length"); i++) {
				GetReviewInfoResponse.GetReviewInfo_Data.GetReviewInfo_Dialogue dialogue = new GetReviewInfoResponse.GetReviewInfo_Data.GetReviewInfo_Dialogue();
				dialogue.Words = _ctx.StringValue("GetReviewInfo.Data.Dialogues["+ i +"].Words");
				dialogue.Identity = _ctx.StringValue("GetReviewInfo.Data.Dialogues["+ i +"].Identity");
				dialogue.Begin = _ctx.LongValue("GetReviewInfo.Data.Dialogues["+ i +"].Begin");
				dialogue.BeginTime = _ctx.StringValue("GetReviewInfo.Data.Dialogues["+ i +"].BeginTime");
				dialogue.EmotionValue = _ctx.IntegerValue("GetReviewInfo.Data.Dialogues["+ i +"].EmotionValue");
				dialogue.End = _ctx.LongValue("GetReviewInfo.Data.Dialogues["+ i +"].End");
				dialogue.SpeechRate = _ctx.IntegerValue("GetReviewInfo.Data.Dialogues["+ i +"].SpeechRate");
				dialogue.Role = _ctx.StringValue("GetReviewInfo.Data.Dialogues["+ i +"].Role");
				dialogue.SilenceDuration = _ctx.IntegerValue("GetReviewInfo.Data.Dialogues["+ i +"].SilenceDuration");
				dialogue.HourMinSec = _ctx.StringValue("GetReviewInfo.Data.Dialogues["+ i +"].HourMinSec");

				data_dialogues.Add(dialogue);
			}
			data.Dialogues = data_dialogues;

			List<GetReviewInfoResponse.GetReviewInfo_Data.GetReviewInfo_ScorePo> data_handScoreInfoList = new List<GetReviewInfoResponse.GetReviewInfo_Data.GetReviewInfo_ScorePo>();
			for (int i = 0; i < _ctx.Length("GetReviewInfo.Data.HandScoreInfoList.Length"); i++) {
				GetReviewInfoResponse.GetReviewInfo_Data.GetReviewInfo_ScorePo scorePo = new GetReviewInfoResponse.GetReviewInfo_Data.GetReviewInfo_ScorePo();
				scorePo.ScoreId = _ctx.LongValue("GetReviewInfo.Data.HandScoreInfoList["+ i +"].ScoreId");
				scorePo.ScoreName = _ctx.StringValue("GetReviewInfo.Data.HandScoreInfoList["+ i +"].ScoreName");

				List<GetReviewInfoResponse.GetReviewInfo_Data.GetReviewInfo_ScorePo.GetReviewInfo_ScoreParam> scorePo_scoreInfos = new List<GetReviewInfoResponse.GetReviewInfo_Data.GetReviewInfo_ScorePo.GetReviewInfo_ScoreParam>();
				for (int j = 0; j < _ctx.Length("GetReviewInfo.Data.HandScoreInfoList["+ i +"].ScoreInfos.Length"); j++) {
					GetReviewInfoResponse.GetReviewInfo_Data.GetReviewInfo_ScorePo.GetReviewInfo_ScoreParam scoreParam = new GetReviewInfoResponse.GetReviewInfo_Data.GetReviewInfo_ScorePo.GetReviewInfo_ScoreParam();
					scoreParam.ScoreSubName = _ctx.StringValue("GetReviewInfo.Data.HandScoreInfoList["+ i +"].ScoreInfos["+ j +"].ScoreSubName");
					scoreParam.ScoreNum = _ctx.IntegerValue("GetReviewInfo.Data.HandScoreInfoList["+ i +"].ScoreInfos["+ j +"].ScoreNum");
					scoreParam.Hit = _ctx.IntegerValue("GetReviewInfo.Data.HandScoreInfoList["+ i +"].ScoreInfos["+ j +"].Hit");
					scoreParam.ScoreSubId = _ctx.LongValue("GetReviewInfo.Data.HandScoreInfoList["+ i +"].ScoreInfos["+ j +"].ScoreSubId");
					scoreParam.ScoreType = _ctx.IntegerValue("GetReviewInfo.Data.HandScoreInfoList["+ i +"].ScoreInfos["+ j +"].ScoreType");

					scorePo_scoreInfos.Add(scoreParam);
				}
				scorePo.ScoreInfos = scorePo_scoreInfos;

				data_handScoreInfoList.Add(scorePo);
			}
			data.HandScoreInfoList = data_handScoreInfoList;

			List<GetReviewInfoResponse.GetReviewInfo_Data.GetReviewInfo_HitRuleReviewInfo> data_hitRuleReviewInfoList = new List<GetReviewInfoResponse.GetReviewInfo_Data.GetReviewInfo_HitRuleReviewInfo>();
			for (int i = 0; i < _ctx.Length("GetReviewInfo.Data.HitRuleReviewInfoList.Length"); i++) {
				GetReviewInfoResponse.GetReviewInfo_Data.GetReviewInfo_HitRuleReviewInfo hitRuleReviewInfo = new GetReviewInfoResponse.GetReviewInfo_Data.GetReviewInfo_HitRuleReviewInfo();
				hitRuleReviewInfo.RuleScoreType = _ctx.IntegerValue("GetReviewInfo.Data.HitRuleReviewInfoList["+ i +"].RuleScoreType");
				hitRuleReviewInfo.RuleType = _ctx.IntegerValue("GetReviewInfo.Data.HitRuleReviewInfoList["+ i +"].RuleType");
				hitRuleReviewInfo.AutoReview = _ctx.IntegerValue("GetReviewInfo.Data.HitRuleReviewInfoList["+ i +"].AutoReview");
				hitRuleReviewInfo.ScoreSubId = _ctx.LongValue("GetReviewInfo.Data.HitRuleReviewInfoList["+ i +"].ScoreSubId");
				hitRuleReviewInfo.TotalNumber = _ctx.IntegerValue("GetReviewInfo.Data.HitRuleReviewInfoList["+ i +"].TotalNumber");
				hitRuleReviewInfo.ScoreId = _ctx.LongValue("GetReviewInfo.Data.HitRuleReviewInfoList["+ i +"].ScoreId");
				hitRuleReviewInfo.Rid = _ctx.LongValue("GetReviewInfo.Data.HitRuleReviewInfoList["+ i +"].Rid");
				hitRuleReviewInfo.RuleName = _ctx.StringValue("GetReviewInfo.Data.HitRuleReviewInfoList["+ i +"].RuleName");

				GetReviewInfoResponse.GetReviewInfo_Data.GetReviewInfo_HitRuleReviewInfo.GetReviewInfo_ReviewInfo reviewInfo = new GetReviewInfoResponse.GetReviewInfo_Data.GetReviewInfo_HitRuleReviewInfo.GetReviewInfo_ReviewInfo();
				reviewInfo.Rid = _ctx.LongValue("GetReviewInfo.Data.HitRuleReviewInfoList["+ i +"].ReviewInfo.Rid");
				reviewInfo.HitId = _ctx.StringValue("GetReviewInfo.Data.HitRuleReviewInfoList["+ i +"].ReviewInfo.HitId");
				hitRuleReviewInfo.ReviewInfo = reviewInfo;

				List<GetReviewInfoResponse.GetReviewInfo_Data.GetReviewInfo_HitRuleReviewInfo.GetReviewInfo_ConditionHitInfo> hitRuleReviewInfo_conditionHitInfoList = new List<GetReviewInfoResponse.GetReviewInfo_Data.GetReviewInfo_HitRuleReviewInfo.GetReviewInfo_ConditionHitInfo>();
				for (int j = 0; j < _ctx.Length("GetReviewInfo.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList.Length"); j++) {
					GetReviewInfoResponse.GetReviewInfo_Data.GetReviewInfo_HitRuleReviewInfo.GetReviewInfo_ConditionHitInfo conditionHitInfo = new GetReviewInfoResponse.GetReviewInfo_Data.GetReviewInfo_HitRuleReviewInfo.GetReviewInfo_ConditionHitInfo();

					List<string> conditionHitInfo_cid = new List<string>();
					for (int k = 0; k < _ctx.Length("GetReviewInfo.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].Cid.Length"); k++) {
						conditionHitInfo_cid.Add(_ctx.StringValue("GetReviewInfo.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].Cid["+ k +"]"));
					}
					conditionHitInfo.Cid = conditionHitInfo_cid;

					GetReviewInfoResponse.GetReviewInfo_Data.GetReviewInfo_HitRuleReviewInfo.GetReviewInfo_ConditionHitInfo.GetReviewInfo_Phrase phrase = new GetReviewInfoResponse.GetReviewInfo_Data.GetReviewInfo_HitRuleReviewInfo.GetReviewInfo_ConditionHitInfo.GetReviewInfo_Phrase();
					phrase.Words = _ctx.StringValue("GetReviewInfo.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].Phrase.Words");
					phrase.Begin = _ctx.LongValue("GetReviewInfo.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].Phrase.Begin");
					phrase.Identity = _ctx.StringValue("GetReviewInfo.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].Phrase.Identity");
					phrase.Pid = _ctx.IntegerValue("GetReviewInfo.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].Phrase.Pid");
					phrase.EmotionValue = _ctx.IntegerValue("GetReviewInfo.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].Phrase.EmotionValue");
					phrase.End = _ctx.LongValue("GetReviewInfo.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].Phrase.End");
					phrase.Role = _ctx.StringValue("GetReviewInfo.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].Phrase.Role");
					conditionHitInfo.Phrase = phrase;

					List<GetReviewInfoResponse.GetReviewInfo_Data.GetReviewInfo_HitRuleReviewInfo.GetReviewInfo_ConditionHitInfo.GetReviewInfo_KeyWord> conditionHitInfo_keyWords = new List<GetReviewInfoResponse.GetReviewInfo_Data.GetReviewInfo_HitRuleReviewInfo.GetReviewInfo_ConditionHitInfo.GetReviewInfo_KeyWord>();
					for (int k = 0; k < _ctx.Length("GetReviewInfo.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].KeyWords.Length"); k++) {
						GetReviewInfoResponse.GetReviewInfo_Data.GetReviewInfo_HitRuleReviewInfo.GetReviewInfo_ConditionHitInfo.GetReviewInfo_KeyWord keyWord = new GetReviewInfoResponse.GetReviewInfo_Data.GetReviewInfo_HitRuleReviewInfo.GetReviewInfo_ConditionHitInfo.GetReviewInfo_KeyWord();
						keyWord.To = _ctx.IntegerValue("GetReviewInfo.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].KeyWords["+ k +"].To");
						keyWord.From = _ctx.IntegerValue("GetReviewInfo.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].KeyWords["+ k +"].From");
						keyWord.Val = _ctx.StringValue("GetReviewInfo.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].KeyWords["+ k +"].Val");
						keyWord.Tid = _ctx.StringValue("GetReviewInfo.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].KeyWords["+ k +"].Tid");
						keyWord.Pid = _ctx.IntegerValue("GetReviewInfo.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].KeyWords["+ k +"].Pid");

						conditionHitInfo_keyWords.Add(keyWord);
					}
					conditionHitInfo.KeyWords = conditionHitInfo_keyWords;

					hitRuleReviewInfo_conditionHitInfoList.Add(conditionHitInfo);
				}
				hitRuleReviewInfo.ConditionHitInfoList = hitRuleReviewInfo_conditionHitInfoList;

				data_hitRuleReviewInfoList.Add(hitRuleReviewInfo);
			}
			data.HitRuleReviewInfoList = data_hitRuleReviewInfoList;
			getReviewInfoResponse.Data = data;
        
			return getReviewInfoResponse;
        }
    }
}
