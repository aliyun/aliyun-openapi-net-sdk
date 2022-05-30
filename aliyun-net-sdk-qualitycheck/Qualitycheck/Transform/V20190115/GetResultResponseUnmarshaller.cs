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
    public class GetResultResponseUnmarshaller
    {
        public static GetResultResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetResultResponse getResultResponse = new GetResultResponse();

			getResultResponse.HttpResponse = _ctx.HttpResponse;
			getResultResponse.RequestId = _ctx.StringValue("GetResult.RequestId");
			getResultResponse.Success = _ctx.BooleanValue("GetResult.Success");
			getResultResponse.ResultCountId = _ctx.StringValue("GetResult.ResultCountId");
			getResultResponse.Code = _ctx.StringValue("GetResult.Code");
			getResultResponse.Message = _ctx.StringValue("GetResult.Message");
			getResultResponse.PageNumber = _ctx.IntegerValue("GetResult.PageNumber");
			getResultResponse.PageSize = _ctx.IntegerValue("GetResult.PageSize");
			getResultResponse.Count = _ctx.IntegerValue("GetResult.Count");

			List<GetResultResponse.GetResult_ResultInfo> getResultResponse_data = new List<GetResultResponse.GetResult_ResultInfo>();
			for (int i = 0; i < _ctx.Length("GetResult.Data.Length"); i++) {
				GetResultResponse.GetResult_ResultInfo resultInfo = new GetResultResponse.GetResult_ResultInfo();
				resultInfo.Status = _ctx.IntegerValue("GetResult.Data["+ i +"].Status");
				resultInfo.AssignmentTime = _ctx.StringValue("GetResult.Data["+ i +"].AssignmentTime");
				resultInfo.LastDataId = _ctx.StringValue("GetResult.Data["+ i +"].LastDataId");
				resultInfo.ErrorMessage = _ctx.StringValue("GetResult.Data["+ i +"].ErrorMessage");
				resultInfo.Reviewer = _ctx.StringValue("GetResult.Data["+ i +"].Reviewer");
				resultInfo.CreateTime = _ctx.StringValue("GetResult.Data["+ i +"].CreateTime");
				resultInfo.ReviewStatus = _ctx.IntegerValue("GetResult.Data["+ i +"].ReviewStatus");
				resultInfo.ReviewTimeLong = _ctx.StringValue("GetResult.Data["+ i +"].ReviewTimeLong");
				resultInfo.TaskName = _ctx.StringValue("GetResult.Data["+ i +"].TaskName");
				resultInfo.ReviewResult = _ctx.IntegerValue("GetResult.Data["+ i +"].ReviewResult");
				resultInfo.Score = _ctx.IntegerValue("GetResult.Data["+ i +"].Score");
				resultInfo.CreateTimeLong = _ctx.StringValue("GetResult.Data["+ i +"].CreateTimeLong");
				resultInfo.ReviewTime = _ctx.StringValue("GetResult.Data["+ i +"].ReviewTime");
				resultInfo.Comments = _ctx.StringValue("GetResult.Data["+ i +"].Comments");
				resultInfo.TaskId = _ctx.StringValue("GetResult.Data["+ i +"].TaskId");
				resultInfo.ReviewType = _ctx.IntegerValue("GetResult.Data["+ i +"].ReviewType");
				resultInfo.Resolver = _ctx.StringValue("GetResult.Data["+ i +"].Resolver");

				List<string> resultInfo_schemeIdList = new List<string>();
				for (int j = 0; j < _ctx.Length("GetResult.Data["+ i +"].SchemeIdList.Length"); j++) {
					resultInfo_schemeIdList.Add(_ctx.StringValue("GetResult.Data["+ i +"].SchemeIdList["+ j +"]"));
				}
				resultInfo.SchemeIdList = resultInfo_schemeIdList;

				List<string> resultInfo_schemeNameList = new List<string>();
				for (int j = 0; j < _ctx.Length("GetResult.Data["+ i +"].SchemeNameList.Length"); j++) {
					resultInfo_schemeNameList.Add(_ctx.StringValue("GetResult.Data["+ i +"].SchemeNameList["+ j +"]"));
				}
				resultInfo.SchemeNameList = resultInfo_schemeNameList;

				GetResultResponse.GetResult_ResultInfo.GetResult_Recording recording = new GetResultResponse.GetResult_ResultInfo.GetResult_Recording();
				recording.Remark13 = _ctx.StringValue("GetResult.Data["+ i +"].Recording.Remark13");
				recording.Callee = _ctx.StringValue("GetResult.Data["+ i +"].Recording.Callee");
				recording.DialogueSize = _ctx.IntegerValue("GetResult.Data["+ i +"].Recording.DialogueSize");
				recording.PrimaryId = _ctx.StringValue("GetResult.Data["+ i +"].Recording.PrimaryId");
				recording.Remark12 = _ctx.StringValue("GetResult.Data["+ i +"].Recording.Remark12");
				recording.Remark1 = _ctx.StringValue("GetResult.Data["+ i +"].Recording.Remark1");
				recording.Remark7 = _ctx.StringValue("GetResult.Data["+ i +"].Recording.Remark7");
				recording.Remark8 = _ctx.StringValue("GetResult.Data["+ i +"].Recording.Remark8");
				recording.Remark2 = _ctx.StringValue("GetResult.Data["+ i +"].Recording.Remark2");
				recording.CallId = _ctx.StringValue("GetResult.Data["+ i +"].Recording.CallId");
				recording.Remark9 = _ctx.StringValue("GetResult.Data["+ i +"].Recording.Remark9");
				recording.Name = _ctx.StringValue("GetResult.Data["+ i +"].Recording.Name");
				recording.Remark6 = _ctx.StringValue("GetResult.Data["+ i +"].Recording.Remark6");
				recording.Remark10 = _ctx.StringValue("GetResult.Data["+ i +"].Recording.Remark10");
				recording.Business = _ctx.StringValue("GetResult.Data["+ i +"].Recording.Business");
				recording.Remark3 = _ctx.StringValue("GetResult.Data["+ i +"].Recording.Remark3");
				recording.Url = _ctx.StringValue("GetResult.Data["+ i +"].Recording.Url");
				recording.Remark11 = _ctx.StringValue("GetResult.Data["+ i +"].Recording.Remark11");
				recording.Remark4 = _ctx.StringValue("GetResult.Data["+ i +"].Recording.Remark4");
				recording.CallType = _ctx.IntegerValue("GetResult.Data["+ i +"].Recording.CallType");
				recording.Caller = _ctx.StringValue("GetResult.Data["+ i +"].Recording.Caller");
				recording.DataSetName = _ctx.StringValue("GetResult.Data["+ i +"].Recording.DataSetName");
				recording.Duration = _ctx.LongValue("GetResult.Data["+ i +"].Recording.Duration");
				recording.Remark5 = _ctx.LongValue("GetResult.Data["+ i +"].Recording.Remark5");
				recording.Id = _ctx.StringValue("GetResult.Data["+ i +"].Recording.Id");
				recording.CallTime = _ctx.StringValue("GetResult.Data["+ i +"].Recording.CallTime");
				resultInfo.Recording = recording;

				GetResultResponse.GetResult_ResultInfo.GetResult_Agent agent = new GetResultResponse.GetResult_ResultInfo.GetResult_Agent();
				agent.Name = _ctx.StringValue("GetResult.Data["+ i +"].Agent.Name");
				agent.SkillGroup = _ctx.StringValue("GetResult.Data["+ i +"].Agent.SkillGroup");
				agent.Id = _ctx.StringValue("GetResult.Data["+ i +"].Agent.Id");
				resultInfo.Agent = agent;

				List<GetResultResponse.GetResult_ResultInfo.GetResult_AsrResultItem> resultInfo_asrResult = new List<GetResultResponse.GetResult_ResultInfo.GetResult_AsrResultItem>();
				for (int j = 0; j < _ctx.Length("GetResult.Data["+ i +"].AsrResult.Length"); j++) {
					GetResultResponse.GetResult_ResultInfo.GetResult_AsrResultItem asrResultItem = new GetResultResponse.GetResult_ResultInfo.GetResult_AsrResultItem();
					asrResultItem.Words = _ctx.StringValue("GetResult.Data["+ i +"].AsrResult["+ j +"].Words");
					asrResultItem.Begin = _ctx.LongValue("GetResult.Data["+ i +"].AsrResult["+ j +"].Begin");
					asrResultItem.EmotionValue = _ctx.IntegerValue("GetResult.Data["+ i +"].AsrResult["+ j +"].EmotionValue");
					asrResultItem.End = _ctx.LongValue("GetResult.Data["+ i +"].AsrResult["+ j +"].End");
					asrResultItem.SpeechRate = _ctx.IntegerValue("GetResult.Data["+ i +"].AsrResult["+ j +"].SpeechRate");
					asrResultItem.Role = _ctx.StringValue("GetResult.Data["+ i +"].AsrResult["+ j +"].Role");

					resultInfo_asrResult.Add(asrResultItem);
				}
				resultInfo.AsrResult = resultInfo_asrResult;

				List<GetResultResponse.GetResult_ResultInfo.GetResult_HitResultItem> resultInfo_hitResult = new List<GetResultResponse.GetResult_ResultInfo.GetResult_HitResultItem>();
				for (int j = 0; j < _ctx.Length("GetResult.Data["+ i +"].HitResult.Length"); j++) {
					GetResultResponse.GetResult_ResultInfo.GetResult_HitResultItem hitResultItem = new GetResultResponse.GetResult_ResultInfo.GetResult_HitResultItem();
					hitResultItem.Type = _ctx.StringValue("GetResult.Data["+ i +"].HitResult["+ j +"].Type");
					hitResultItem.ReviewResult = _ctx.IntegerValue("GetResult.Data["+ i +"].HitResult["+ j +"].ReviewResult");
					hitResultItem.Name = _ctx.StringValue("GetResult.Data["+ i +"].HitResult["+ j +"].Name");
					hitResultItem.Rid = _ctx.StringValue("GetResult.Data["+ i +"].HitResult["+ j +"].Rid");
					hitResultItem.SchemeId = _ctx.LongValue("GetResult.Data["+ i +"].HitResult["+ j +"].SchemeId");
					hitResultItem.SchemeVersion = _ctx.LongValue("GetResult.Data["+ i +"].HitResult["+ j +"].SchemeVersion");

					List<GetResultResponse.GetResult_ResultInfo.GetResult_HitResultItem.GetResult_Hit> hitResultItem_hits = new List<GetResultResponse.GetResult_ResultInfo.GetResult_HitResultItem.GetResult_Hit>();
					for (int k = 0; k < _ctx.Length("GetResult.Data["+ i +"].HitResult["+ j +"].Hits.Length"); k++) {
						GetResultResponse.GetResult_ResultInfo.GetResult_HitResultItem.GetResult_Hit hit = new GetResultResponse.GetResult_ResultInfo.GetResult_HitResultItem.GetResult_Hit();

						List<string> hit_cid = new List<string>();
						for (int l = 0; l < _ctx.Length("GetResult.Data["+ i +"].HitResult["+ j +"].Hits["+ k +"].Cid.Length"); l++) {
							hit_cid.Add(_ctx.StringValue("GetResult.Data["+ i +"].HitResult["+ j +"].Hits["+ k +"].Cid["+ l +"]"));
						}
						hit.Cid = hit_cid;

						GetResultResponse.GetResult_ResultInfo.GetResult_HitResultItem.GetResult_Hit.GetResult_Phrase phrase = new GetResultResponse.GetResult_ResultInfo.GetResult_HitResultItem.GetResult_Hit.GetResult_Phrase();
						phrase.EmotionValue = _ctx.IntegerValue("GetResult.Data["+ i +"].HitResult["+ j +"].Hits["+ k +"].Phrase.EmotionValue");
						phrase.End = _ctx.IntegerValue("GetResult.Data["+ i +"].HitResult["+ j +"].Hits["+ k +"].Phrase.End");
						phrase.Words = _ctx.StringValue("GetResult.Data["+ i +"].HitResult["+ j +"].Hits["+ k +"].Phrase.Words");
						phrase.Role = _ctx.StringValue("GetResult.Data["+ i +"].HitResult["+ j +"].Hits["+ k +"].Phrase.Role");
						phrase.Begin = _ctx.LongValue("GetResult.Data["+ i +"].HitResult["+ j +"].Hits["+ k +"].Phrase.Begin");
						hit.Phrase = phrase;

						List<GetResultResponse.GetResult_ResultInfo.GetResult_HitResultItem.GetResult_Hit.GetResult_KeyWord> hit_keyWords = new List<GetResultResponse.GetResult_ResultInfo.GetResult_HitResultItem.GetResult_Hit.GetResult_KeyWord>();
						for (int l = 0; l < _ctx.Length("GetResult.Data["+ i +"].HitResult["+ j +"].Hits["+ k +"].KeyWords.Length"); l++) {
							GetResultResponse.GetResult_ResultInfo.GetResult_HitResultItem.GetResult_Hit.GetResult_KeyWord keyWord = new GetResultResponse.GetResult_ResultInfo.GetResult_HitResultItem.GetResult_Hit.GetResult_KeyWord();
							keyWord.From = _ctx.IntegerValue("GetResult.Data["+ i +"].HitResult["+ j +"].Hits["+ k +"].KeyWords["+ l +"].From");
							keyWord.To = _ctx.IntegerValue("GetResult.Data["+ i +"].HitResult["+ j +"].Hits["+ k +"].KeyWords["+ l +"].To");
							keyWord.Val = _ctx.StringValue("GetResult.Data["+ i +"].HitResult["+ j +"].Hits["+ k +"].KeyWords["+ l +"].Val");
							keyWord.Cid = _ctx.StringValue("GetResult.Data["+ i +"].HitResult["+ j +"].Hits["+ k +"].KeyWords["+ l +"].Cid");

							hit_keyWords.Add(keyWord);
						}
						hit.KeyWords = hit_keyWords;

						hitResultItem_hits.Add(hit);
					}
					hitResultItem.Hits = hitResultItem_hits;

					resultInfo_hitResult.Add(hitResultItem);
				}
				resultInfo.HitResult = resultInfo_hitResult;

				List<GetResultResponse.GetResult_ResultInfo.GetResult_HitScoreItem> resultInfo_hitScore = new List<GetResultResponse.GetResult_ResultInfo.GetResult_HitScoreItem>();
				for (int j = 0; j < _ctx.Length("GetResult.Data["+ i +"].HitScore.Length"); j++) {
					GetResultResponse.GetResult_ResultInfo.GetResult_HitScoreItem hitScoreItem = new GetResultResponse.GetResult_ResultInfo.GetResult_HitScoreItem();
					hitScoreItem.ScoreName = _ctx.StringValue("GetResult.Data["+ i +"].HitScore["+ j +"].ScoreName");
					hitScoreItem.ScoreNumber = _ctx.StringValue("GetResult.Data["+ i +"].HitScore["+ j +"].ScoreNumber");
					hitScoreItem.ScoreId = _ctx.StringValue("GetResult.Data["+ i +"].HitScore["+ j +"].ScoreId");
					hitScoreItem.RuleId = _ctx.StringValue("GetResult.Data["+ i +"].HitScore["+ j +"].RuleId");

					resultInfo_hitScore.Add(hitScoreItem);
				}
				resultInfo.HitScore = resultInfo_hitScore;

				getResultResponse_data.Add(resultInfo);
			}
			getResultResponse.Data = getResultResponse_data;
        
			return getResultResponse;
        }
    }
}
