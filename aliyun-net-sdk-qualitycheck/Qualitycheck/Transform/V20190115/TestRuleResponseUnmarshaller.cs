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
    public class TestRuleResponseUnmarshaller
    {
        public static TestRuleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			TestRuleResponse testRuleResponse = new TestRuleResponse();

			testRuleResponse.HttpResponse = _ctx.HttpResponse;
			testRuleResponse.Code = _ctx.StringValue("TestRule.Code");
			testRuleResponse.Message = _ctx.StringValue("TestRule.Message");
			testRuleResponse.RequestId = _ctx.StringValue("TestRule.RequestId");
			testRuleResponse.Success = _ctx.BooleanValue("TestRule.Success");

			TestRuleResponse.TestRule_Data data = new TestRuleResponse.TestRule_Data();
			data.Poc = _ctx.BooleanValue("TestRule.Data.Poc");

			List<TestRuleResponse.TestRule_Data.TestRule_HitRuleReviewInfo> data_hitRuleReviewInfoList = new List<TestRuleResponse.TestRule_Data.TestRule_HitRuleReviewInfo>();
			for (int i = 0; i < _ctx.Length("TestRule.Data.HitRuleReviewInfoList.Length"); i++) {
				TestRuleResponse.TestRule_Data.TestRule_HitRuleReviewInfo hitRuleReviewInfo = new TestRuleResponse.TestRule_Data.TestRule_HitRuleReviewInfo();
				hitRuleReviewInfo.Rid = _ctx.LongValue("TestRule.Data.HitRuleReviewInfoList["+ i +"].Rid");

				List<TestRuleResponse.TestRule_Data.TestRule_HitRuleReviewInfo.TestRule_ConditionHitInfo> hitRuleReviewInfo_conditionHitInfoList = new List<TestRuleResponse.TestRule_Data.TestRule_HitRuleReviewInfo.TestRule_ConditionHitInfo>();
				for (int j = 0; j < _ctx.Length("TestRule.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList.Length"); j++) {
					TestRuleResponse.TestRule_Data.TestRule_HitRuleReviewInfo.TestRule_ConditionHitInfo conditionHitInfo = new TestRuleResponse.TestRule_Data.TestRule_HitRuleReviewInfo.TestRule_ConditionHitInfo();

					List<string> conditionHitInfo_cid = new List<string>();
					for (int k = 0; k < _ctx.Length("TestRule.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].Cid.Length"); k++) {
						conditionHitInfo_cid.Add(_ctx.StringValue("TestRule.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].Cid["+ k +"]"));
					}
					conditionHitInfo.Cid = conditionHitInfo_cid;

					TestRuleResponse.TestRule_Data.TestRule_HitRuleReviewInfo.TestRule_ConditionHitInfo.TestRule_Phrase phrase = new TestRuleResponse.TestRule_Data.TestRule_HitRuleReviewInfo.TestRule_ConditionHitInfo.TestRule_Phrase();
					phrase.Words = _ctx.StringValue("TestRule.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].Phrase.Words");
					phrase.Begin = _ctx.LongValue("TestRule.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].Phrase.Begin");
					phrase.Identity = _ctx.StringValue("TestRule.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].Phrase.Identity");
					phrase.Pid = _ctx.IntegerValue("TestRule.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].Phrase.Pid");
					phrase.EmotionValue = _ctx.IntegerValue("TestRule.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].Phrase.EmotionValue");
					phrase.End = _ctx.LongValue("TestRule.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].Phrase.End");
					phrase.Role = _ctx.StringValue("TestRule.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].Phrase.Role");
					conditionHitInfo.Phrase = phrase;

					List<TestRuleResponse.TestRule_Data.TestRule_HitRuleReviewInfo.TestRule_ConditionHitInfo.TestRule_KeyWord> conditionHitInfo_keyWords = new List<TestRuleResponse.TestRule_Data.TestRule_HitRuleReviewInfo.TestRule_ConditionHitInfo.TestRule_KeyWord>();
					for (int k = 0; k < _ctx.Length("TestRule.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].KeyWords.Length"); k++) {
						TestRuleResponse.TestRule_Data.TestRule_HitRuleReviewInfo.TestRule_ConditionHitInfo.TestRule_KeyWord keyWord = new TestRuleResponse.TestRule_Data.TestRule_HitRuleReviewInfo.TestRule_ConditionHitInfo.TestRule_KeyWord();
						keyWord.To = _ctx.IntegerValue("TestRule.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].KeyWords["+ k +"].To");
						keyWord.From = _ctx.IntegerValue("TestRule.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].KeyWords["+ k +"].From");
						keyWord.Val = _ctx.StringValue("TestRule.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].KeyWords["+ k +"].Val");
						keyWord.Tid = _ctx.StringValue("TestRule.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].KeyWords["+ k +"].Tid");
						keyWord.Pid = _ctx.IntegerValue("TestRule.Data.HitRuleReviewInfoList["+ i +"].ConditionHitInfoList["+ j +"].KeyWords["+ k +"].Pid");

						conditionHitInfo_keyWords.Add(keyWord);
					}
					conditionHitInfo.KeyWords = conditionHitInfo_keyWords;

					hitRuleReviewInfo_conditionHitInfoList.Add(conditionHitInfo);
				}
				hitRuleReviewInfo.ConditionHitInfoList = hitRuleReviewInfo_conditionHitInfoList;

				data_hitRuleReviewInfoList.Add(hitRuleReviewInfo);
			}
			data.HitRuleReviewInfoList = data_hitRuleReviewInfoList;
			testRuleResponse.Data = data;
        
			return testRuleResponse;
        }
    }
}
