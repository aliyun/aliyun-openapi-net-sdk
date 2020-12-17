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
    public class SyncQualityCheckResponseUnmarshaller
    {
        public static SyncQualityCheckResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SyncQualityCheckResponse syncQualityCheckResponse = new SyncQualityCheckResponse();

			syncQualityCheckResponse.HttpResponse = _ctx.HttpResponse;
			syncQualityCheckResponse.RequestId = _ctx.StringValue("SyncQualityCheck.RequestId");
			syncQualityCheckResponse.Success = _ctx.BooleanValue("SyncQualityCheck.Success");
			syncQualityCheckResponse.Code = _ctx.StringValue("SyncQualityCheck.Code");
			syncQualityCheckResponse.Message = _ctx.StringValue("SyncQualityCheck.Message");

			SyncQualityCheckResponse.SyncQualityCheck_Data data = new SyncQualityCheckResponse.SyncQualityCheck_Data();
			data.Score = _ctx.IntegerValue("SyncQualityCheck.Data.Score");
			data.Tid = _ctx.StringValue("SyncQualityCheck.Data.Tid");
			data.BeginTime = _ctx.LongValue("SyncQualityCheck.Data.BeginTime");
			data.TaskId = _ctx.StringValue("SyncQualityCheck.Data.TaskId");

			List<SyncQualityCheckResponse.SyncQualityCheck_Data.SyncQualityCheck_RuleHitInfo> data_rules = new List<SyncQualityCheckResponse.SyncQualityCheck_Data.SyncQualityCheck_RuleHitInfo>();
			for (int i = 0; i < _ctx.Length("SyncQualityCheck.Data.Rules.Length"); i++) {
				SyncQualityCheckResponse.SyncQualityCheck_Data.SyncQualityCheck_RuleHitInfo ruleHitInfo = new SyncQualityCheckResponse.SyncQualityCheck_Data.SyncQualityCheck_RuleHitInfo();
				ruleHitInfo.Rid = _ctx.StringValue("SyncQualityCheck.Data.Rules["+ i +"].Rid");
				ruleHitInfo.RuleName = _ctx.StringValue("SyncQualityCheck.Data.Rules["+ i +"].RuleName");

				List<SyncQualityCheckResponse.SyncQualityCheck_Data.SyncQualityCheck_RuleHitInfo.SyncQualityCheck_ConditionHitInfo> ruleHitInfo_hit = new List<SyncQualityCheckResponse.SyncQualityCheck_Data.SyncQualityCheck_RuleHitInfo.SyncQualityCheck_ConditionHitInfo>();
				for (int j = 0; j < _ctx.Length("SyncQualityCheck.Data.Rules["+ i +"].Hit.Length"); j++) {
					SyncQualityCheckResponse.SyncQualityCheck_Data.SyncQualityCheck_RuleHitInfo.SyncQualityCheck_ConditionHitInfo conditionHitInfo = new SyncQualityCheckResponse.SyncQualityCheck_Data.SyncQualityCheck_RuleHitInfo.SyncQualityCheck_ConditionHitInfo();

					SyncQualityCheckResponse.SyncQualityCheck_Data.SyncQualityCheck_RuleHitInfo.SyncQualityCheck_ConditionHitInfo.SyncQualityCheck_Phrase phrase = new SyncQualityCheckResponse.SyncQualityCheck_Data.SyncQualityCheck_RuleHitInfo.SyncQualityCheck_ConditionHitInfo.SyncQualityCheck_Phrase();
					phrase.Role = _ctx.StringValue("SyncQualityCheck.Data.Rules["+ i +"].Hit["+ j +"].Phrase.Role");
					phrase.Identity = _ctx.StringValue("SyncQualityCheck.Data.Rules["+ i +"].Hit["+ j +"].Phrase.Identity");
					phrase.Words = _ctx.StringValue("SyncQualityCheck.Data.Rules["+ i +"].Hit["+ j +"].Phrase.Words");
					phrase.Begin = _ctx.LongValue("SyncQualityCheck.Data.Rules["+ i +"].Hit["+ j +"].Phrase.Begin");
					phrase.End = _ctx.LongValue("SyncQualityCheck.Data.Rules["+ i +"].Hit["+ j +"].Phrase.End");
					phrase.EmotionValue = _ctx.IntegerValue("SyncQualityCheck.Data.Rules["+ i +"].Hit["+ j +"].Phrase.EmotionValue");
					phrase.SpeechRate = _ctx.IntegerValue("SyncQualityCheck.Data.Rules["+ i +"].Hit["+ j +"].Phrase.SpeechRate");
					phrase.SilenceDuration = _ctx.IntegerValue("SyncQualityCheck.Data.Rules["+ i +"].Hit["+ j +"].Phrase.SilenceDuration");
					conditionHitInfo.Phrase = phrase;

					List<SyncQualityCheckResponse.SyncQualityCheck_Data.SyncQualityCheck_RuleHitInfo.SyncQualityCheck_ConditionHitInfo.SyncQualityCheck_HitKeyWord> conditionHitInfo_hitKeyWords = new List<SyncQualityCheckResponse.SyncQualityCheck_Data.SyncQualityCheck_RuleHitInfo.SyncQualityCheck_ConditionHitInfo.SyncQualityCheck_HitKeyWord>();
					for (int k = 0; k < _ctx.Length("SyncQualityCheck.Data.Rules["+ i +"].Hit["+ j +"].HitKeyWords.Length"); k++) {
						SyncQualityCheckResponse.SyncQualityCheck_Data.SyncQualityCheck_RuleHitInfo.SyncQualityCheck_ConditionHitInfo.SyncQualityCheck_HitKeyWord hitKeyWord = new SyncQualityCheckResponse.SyncQualityCheck_Data.SyncQualityCheck_RuleHitInfo.SyncQualityCheck_ConditionHitInfo.SyncQualityCheck_HitKeyWord();
						hitKeyWord.Val = _ctx.StringValue("SyncQualityCheck.Data.Rules["+ i +"].Hit["+ j +"].HitKeyWords["+ k +"].Val");
						hitKeyWord.Pid = _ctx.IntegerValue("SyncQualityCheck.Data.Rules["+ i +"].Hit["+ j +"].HitKeyWords["+ k +"].Pid");
						hitKeyWord.From = _ctx.IntegerValue("SyncQualityCheck.Data.Rules["+ i +"].Hit["+ j +"].HitKeyWords["+ k +"].From");
						hitKeyWord.To = _ctx.IntegerValue("SyncQualityCheck.Data.Rules["+ i +"].Hit["+ j +"].HitKeyWords["+ k +"].To");
						hitKeyWord.Cid = _ctx.IntegerValue("SyncQualityCheck.Data.Rules["+ i +"].Hit["+ j +"].HitKeyWords["+ k +"].Cid");

						conditionHitInfo_hitKeyWords.Add(hitKeyWord);
					}
					conditionHitInfo.HitKeyWords = conditionHitInfo_hitKeyWords;

					ruleHitInfo_hit.Add(conditionHitInfo);
				}
				ruleHitInfo.Hit = ruleHitInfo_hit;

				data_rules.Add(ruleHitInfo);
			}
			data.Rules = data_rules;
			syncQualityCheckResponse.Data = data;
        
			return syncQualityCheckResponse;
        }
    }
}
