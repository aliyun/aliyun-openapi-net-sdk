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
    public class UploadDataSyncResponseUnmarshaller
    {
        public static UploadDataSyncResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UploadDataSyncResponse uploadDataSyncResponse = new UploadDataSyncResponse();

			uploadDataSyncResponse.HttpResponse = _ctx.HttpResponse;
			uploadDataSyncResponse.RequestId = _ctx.StringValue("UploadDataSync.RequestId");
			uploadDataSyncResponse.Success = _ctx.BooleanValue("UploadDataSync.Success");
			uploadDataSyncResponse.Code = _ctx.StringValue("UploadDataSync.Code");
			uploadDataSyncResponse.Message = _ctx.StringValue("UploadDataSync.Message");

			List<UploadDataSyncResponse.UploadDataSync_ResultInfo> uploadDataSyncResponse_data = new List<UploadDataSyncResponse.UploadDataSync_ResultInfo>();
			for (int i = 0; i < _ctx.Length("UploadDataSync.Data.Length"); i++) {
				UploadDataSyncResponse.UploadDataSync_ResultInfo resultInfo = new UploadDataSyncResponse.UploadDataSync_ResultInfo();
				resultInfo.Score = _ctx.IntegerValue("UploadDataSync.Data["+ i +"].Score");

				List<string> resultInfo_handScoreIdList = new List<string>();
				for (int j = 0; j < _ctx.Length("UploadDataSync.Data["+ i +"].HandScoreIdList.Length"); j++) {
					resultInfo_handScoreIdList.Add(_ctx.StringValue("UploadDataSync.Data["+ i +"].HandScoreIdList["+ j +"]"));
				}
				resultInfo.HandScoreIdList = resultInfo_handScoreIdList;

				List<UploadDataSyncResponse.UploadDataSync_ResultInfo.UploadDataSync_RuleHitInfo> resultInfo_rules = new List<UploadDataSyncResponse.UploadDataSync_ResultInfo.UploadDataSync_RuleHitInfo>();
				for (int j = 0; j < _ctx.Length("UploadDataSync.Data["+ i +"].Rules.Length"); j++) {
					UploadDataSyncResponse.UploadDataSync_ResultInfo.UploadDataSync_RuleHitInfo ruleHitInfo = new UploadDataSyncResponse.UploadDataSync_ResultInfo.UploadDataSync_RuleHitInfo();
					ruleHitInfo.Rid = _ctx.StringValue("UploadDataSync.Data["+ i +"].Rules["+ j +"].Rid");
					ruleHitInfo.Tid = _ctx.StringValue("UploadDataSync.Data["+ i +"].Rules["+ j +"].Tid");

					List<UploadDataSyncResponse.UploadDataSync_ResultInfo.UploadDataSync_RuleHitInfo.UploadDataSync_ConditionHitInfo> ruleHitInfo_hit = new List<UploadDataSyncResponse.UploadDataSync_ResultInfo.UploadDataSync_RuleHitInfo.UploadDataSync_ConditionHitInfo>();
					for (int k = 0; k < _ctx.Length("UploadDataSync.Data["+ i +"].Rules["+ j +"].Hit.Length"); k++) {
						UploadDataSyncResponse.UploadDataSync_ResultInfo.UploadDataSync_RuleHitInfo.UploadDataSync_ConditionHitInfo conditionHitInfo = new UploadDataSyncResponse.UploadDataSync_ResultInfo.UploadDataSync_RuleHitInfo.UploadDataSync_ConditionHitInfo();

						List<string> conditionHitInfo_hitCids = new List<string>();
						for (int l = 0; l < _ctx.Length("UploadDataSync.Data["+ i +"].Rules["+ j +"].Hit["+ k +"].HitCids.Length"); l++) {
							conditionHitInfo_hitCids.Add(_ctx.StringValue("UploadDataSync.Data["+ i +"].Rules["+ j +"].Hit["+ k +"].HitCids["+ l +"]"));
						}
						conditionHitInfo.HitCids = conditionHitInfo_hitCids;

						UploadDataSyncResponse.UploadDataSync_ResultInfo.UploadDataSync_RuleHitInfo.UploadDataSync_ConditionHitInfo.UploadDataSync_Phrase phrase = new UploadDataSyncResponse.UploadDataSync_ResultInfo.UploadDataSync_RuleHitInfo.UploadDataSync_ConditionHitInfo.UploadDataSync_Phrase();
						phrase.Role = _ctx.StringValue("UploadDataSync.Data["+ i +"].Rules["+ j +"].Hit["+ k +"].Phrase.Role");
						phrase.Identity = _ctx.StringValue("UploadDataSync.Data["+ i +"].Rules["+ j +"].Hit["+ k +"].Phrase.Identity");
						phrase.Words = _ctx.StringValue("UploadDataSync.Data["+ i +"].Rules["+ j +"].Hit["+ k +"].Phrase.Words");
						phrase.Begin = _ctx.LongValue("UploadDataSync.Data["+ i +"].Rules["+ j +"].Hit["+ k +"].Phrase.Begin");
						phrase.End = _ctx.LongValue("UploadDataSync.Data["+ i +"].Rules["+ j +"].Hit["+ k +"].Phrase.End");
						phrase.BeginTime = _ctx.StringValue("UploadDataSync.Data["+ i +"].Rules["+ j +"].Hit["+ k +"].Phrase.BeginTime");
						conditionHitInfo.Phrase = phrase;

						List<UploadDataSyncResponse.UploadDataSync_ResultInfo.UploadDataSync_RuleHitInfo.UploadDataSync_ConditionHitInfo.UploadDataSync_HitKeyWord> conditionHitInfo_hitKeyWords = new List<UploadDataSyncResponse.UploadDataSync_ResultInfo.UploadDataSync_RuleHitInfo.UploadDataSync_ConditionHitInfo.UploadDataSync_HitKeyWord>();
						for (int l = 0; l < _ctx.Length("UploadDataSync.Data["+ i +"].Rules["+ j +"].Hit["+ k +"].HitKeyWords.Length"); l++) {
							UploadDataSyncResponse.UploadDataSync_ResultInfo.UploadDataSync_RuleHitInfo.UploadDataSync_ConditionHitInfo.UploadDataSync_HitKeyWord hitKeyWord = new UploadDataSyncResponse.UploadDataSync_ResultInfo.UploadDataSync_RuleHitInfo.UploadDataSync_ConditionHitInfo.UploadDataSync_HitKeyWord();
							hitKeyWord.Val = _ctx.StringValue("UploadDataSync.Data["+ i +"].Rules["+ j +"].Hit["+ k +"].HitKeyWords["+ l +"].Val");
							hitKeyWord.Pid = _ctx.IntegerValue("UploadDataSync.Data["+ i +"].Rules["+ j +"].Hit["+ k +"].HitKeyWords["+ l +"].Pid");
							hitKeyWord.From = _ctx.IntegerValue("UploadDataSync.Data["+ i +"].Rules["+ j +"].Hit["+ k +"].HitKeyWords["+ l +"].From");
							hitKeyWord.To = _ctx.IntegerValue("UploadDataSync.Data["+ i +"].Rules["+ j +"].Hit["+ k +"].HitKeyWords["+ l +"].To");
							hitKeyWord.Tid = _ctx.StringValue("UploadDataSync.Data["+ i +"].Rules["+ j +"].Hit["+ k +"].HitKeyWords["+ l +"].Tid");

							conditionHitInfo_hitKeyWords.Add(hitKeyWord);
						}
						conditionHitInfo.HitKeyWords = conditionHitInfo_hitKeyWords;

						ruleHitInfo_hit.Add(conditionHitInfo);
					}
					ruleHitInfo.Hit = ruleHitInfo_hit;

					List<UploadDataSyncResponse.UploadDataSync_ResultInfo.UploadDataSync_RuleHitInfo.UploadDataSync_ConditionBasicInfo> ruleHitInfo_conditionInfo = new List<UploadDataSyncResponse.UploadDataSync_ResultInfo.UploadDataSync_RuleHitInfo.UploadDataSync_ConditionBasicInfo>();
					for (int k = 0; k < _ctx.Length("UploadDataSync.Data["+ i +"].Rules["+ j +"].ConditionInfo.Length"); k++) {
						UploadDataSyncResponse.UploadDataSync_ResultInfo.UploadDataSync_RuleHitInfo.UploadDataSync_ConditionBasicInfo conditionBasicInfo = new UploadDataSyncResponse.UploadDataSync_ResultInfo.UploadDataSync_RuleHitInfo.UploadDataSync_ConditionBasicInfo();
						conditionBasicInfo.ConditionInfoCid = _ctx.StringValue("UploadDataSync.Data["+ i +"].Rules["+ j +"].ConditionInfo["+ k +"].ConditionInfoCid");

						ruleHitInfo_conditionInfo.Add(conditionBasicInfo);
					}
					ruleHitInfo.ConditionInfo = ruleHitInfo_conditionInfo;

					resultInfo_rules.Add(ruleHitInfo);
				}
				resultInfo.Rules = resultInfo_rules;

				uploadDataSyncResponse_data.Add(resultInfo);
			}
			uploadDataSyncResponse.Data = uploadDataSyncResponse_data;
        
			return uploadDataSyncResponse;
        }
    }
}
