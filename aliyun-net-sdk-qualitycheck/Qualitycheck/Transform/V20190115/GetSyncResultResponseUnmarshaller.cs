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
    public class GetSyncResultResponseUnmarshaller
    {
        public static GetSyncResultResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetSyncResultResponse getSyncResultResponse = new GetSyncResultResponse();

			getSyncResultResponse.HttpResponse = _ctx.HttpResponse;
			getSyncResultResponse.RequestId = _ctx.StringValue("GetSyncResult.RequestId");
			getSyncResultResponse.Success = _ctx.BooleanValue("GetSyncResult.Success");
			getSyncResultResponse.Code = _ctx.StringValue("GetSyncResult.Code");
			getSyncResultResponse.Message = _ctx.StringValue("GetSyncResult.Message");
			getSyncResultResponse.Count = _ctx.IntegerValue("GetSyncResult.Count");
			getSyncResultResponse.PageSize = _ctx.IntegerValue("GetSyncResult.PageSize");
			getSyncResultResponse.PageNumber = _ctx.IntegerValue("GetSyncResult.PageNumber");
			getSyncResultResponse.ResultCountId = _ctx.StringValue("GetSyncResult.ResultCountId");

			List<GetSyncResultResponse.GetSyncResult_ResultInfo> getSyncResultResponse_data = new List<GetSyncResultResponse.GetSyncResult_ResultInfo>();
			for (int i = 0; i < _ctx.Length("GetSyncResult.Data.Length"); i++) {
				GetSyncResultResponse.GetSyncResult_ResultInfo resultInfo = new GetSyncResultResponse.GetSyncResult_ResultInfo();
				resultInfo.Score = _ctx.IntegerValue("GetSyncResult.Data["+ i +"].Score");
				resultInfo.Comments = _ctx.StringValue("GetSyncResult.Data["+ i +"].Comments");
				resultInfo.ErrorMessage = _ctx.StringValue("GetSyncResult.Data["+ i +"].ErrorMessage");
				resultInfo.Status = _ctx.IntegerValue("GetSyncResult.Data["+ i +"].Status");
				resultInfo.ReviewStatus = _ctx.IntegerValue("GetSyncResult.Data["+ i +"].ReviewStatus");
				resultInfo.ReviewResult = _ctx.IntegerValue("GetSyncResult.Data["+ i +"].ReviewResult");
				resultInfo.TaskId = _ctx.StringValue("GetSyncResult.Data["+ i +"].TaskId");
				resultInfo.TaskName = _ctx.StringValue("GetSyncResult.Data["+ i +"].TaskName");
				resultInfo.CreateTime = _ctx.StringValue("GetSyncResult.Data["+ i +"].CreateTime");
				resultInfo.Reviewer = _ctx.StringValue("GetSyncResult.Data["+ i +"].Reviewer");
				resultInfo.Resolver = _ctx.StringValue("GetSyncResult.Data["+ i +"].Resolver");

				GetSyncResultResponse.GetSyncResult_ResultInfo.GetSyncResult_Recording recording = new GetSyncResultResponse.GetSyncResult_ResultInfo.GetSyncResult_Recording();
				recording.Id = _ctx.StringValue("GetSyncResult.Data["+ i +"].Recording.Id");
				recording.PrimaryId = _ctx.StringValue("GetSyncResult.Data["+ i +"].Recording.PrimaryId");
				recording.CallId = _ctx.StringValue("GetSyncResult.Data["+ i +"].Recording.CallId");
				recording.Name = _ctx.StringValue("GetSyncResult.Data["+ i +"].Recording.Name");
				recording.Url = _ctx.StringValue("GetSyncResult.Data["+ i +"].Recording.Url");
				recording.DataSetName = _ctx.StringValue("GetSyncResult.Data["+ i +"].Recording.DataSetName");
				recording.Duration = _ctx.LongValue("GetSyncResult.Data["+ i +"].Recording.Duration");
				recording.Caller = _ctx.StringValue("GetSyncResult.Data["+ i +"].Recording.Caller");
				recording.Callee = _ctx.StringValue("GetSyncResult.Data["+ i +"].Recording.Callee");
				recording.CallTime = _ctx.StringValue("GetSyncResult.Data["+ i +"].Recording.CallTime");
				recording.CallType = _ctx.IntegerValue("GetSyncResult.Data["+ i +"].Recording.CallType");
				recording.Business = _ctx.StringValue("GetSyncResult.Data["+ i +"].Recording.Business");
				recording.Remark1 = _ctx.StringValue("GetSyncResult.Data["+ i +"].Recording.Remark1");
				recording.Remark2 = _ctx.StringValue("GetSyncResult.Data["+ i +"].Recording.Remark2");
				recording.Remark3 = _ctx.StringValue("GetSyncResult.Data["+ i +"].Recording.Remark3");
				resultInfo.Recording = recording;

				GetSyncResultResponse.GetSyncResult_ResultInfo.GetSyncResult_Agent agent = new GetSyncResultResponse.GetSyncResult_ResultInfo.GetSyncResult_Agent();
				agent.Id = _ctx.StringValue("GetSyncResult.Data["+ i +"].Agent.Id");
				agent.Name = _ctx.StringValue("GetSyncResult.Data["+ i +"].Agent.Name");
				agent.SkillGroup = _ctx.StringValue("GetSyncResult.Data["+ i +"].Agent.SkillGroup");
				resultInfo.Agent = agent;

				List<GetSyncResultResponse.GetSyncResult_ResultInfo.GetSyncResult_AsrResultItem> resultInfo_asrResult = new List<GetSyncResultResponse.GetSyncResult_ResultInfo.GetSyncResult_AsrResultItem>();
				for (int j = 0; j < _ctx.Length("GetSyncResult.Data["+ i +"].AsrResult.Length"); j++) {
					GetSyncResultResponse.GetSyncResult_ResultInfo.GetSyncResult_AsrResultItem asrResultItem = new GetSyncResultResponse.GetSyncResult_ResultInfo.GetSyncResult_AsrResultItem();
					asrResultItem.Role = _ctx.StringValue("GetSyncResult.Data["+ i +"].AsrResult["+ j +"].Role");
					asrResultItem.Words = _ctx.StringValue("GetSyncResult.Data["+ i +"].AsrResult["+ j +"].Words");
					asrResultItem.Begin = _ctx.LongValue("GetSyncResult.Data["+ i +"].AsrResult["+ j +"].Begin");
					asrResultItem.End = _ctx.LongValue("GetSyncResult.Data["+ i +"].AsrResult["+ j +"].End");
					asrResultItem.EmotionValue = _ctx.IntegerValue("GetSyncResult.Data["+ i +"].AsrResult["+ j +"].EmotionValue");
					asrResultItem.SilenceDuration = _ctx.IntegerValue("GetSyncResult.Data["+ i +"].AsrResult["+ j +"].SilenceDuration");
					asrResultItem.SpeechRate = _ctx.IntegerValue("GetSyncResult.Data["+ i +"].AsrResult["+ j +"].SpeechRate");

					resultInfo_asrResult.Add(asrResultItem);
				}
				resultInfo.AsrResult = resultInfo_asrResult;

				List<GetSyncResultResponse.GetSyncResult_ResultInfo.GetSyncResult_HitResultItem> resultInfo_hitResult = new List<GetSyncResultResponse.GetSyncResult_ResultInfo.GetSyncResult_HitResultItem>();
				for (int j = 0; j < _ctx.Length("GetSyncResult.Data["+ i +"].HitResult.Length"); j++) {
					GetSyncResultResponse.GetSyncResult_ResultInfo.GetSyncResult_HitResultItem hitResultItem = new GetSyncResultResponse.GetSyncResult_ResultInfo.GetSyncResult_HitResultItem();
					hitResultItem.Rid = _ctx.StringValue("GetSyncResult.Data["+ i +"].HitResult["+ j +"].Rid");
					hitResultItem.Name = _ctx.StringValue("GetSyncResult.Data["+ i +"].HitResult["+ j +"].Name");
					hitResultItem.Type = _ctx.StringValue("GetSyncResult.Data["+ i +"].HitResult["+ j +"].Type");
					hitResultItem.ReviewResult = _ctx.IntegerValue("GetSyncResult.Data["+ i +"].HitResult["+ j +"].ReviewResult");

					List<GetSyncResultResponse.GetSyncResult_ResultInfo.GetSyncResult_HitResultItem.GetSyncResult_Hit> hitResultItem_hits = new List<GetSyncResultResponse.GetSyncResult_ResultInfo.GetSyncResult_HitResultItem.GetSyncResult_Hit>();
					for (int k = 0; k < _ctx.Length("GetSyncResult.Data["+ i +"].HitResult["+ j +"].Hits.Length"); k++) {
						GetSyncResultResponse.GetSyncResult_ResultInfo.GetSyncResult_HitResultItem.GetSyncResult_Hit hit = new GetSyncResultResponse.GetSyncResult_ResultInfo.GetSyncResult_HitResultItem.GetSyncResult_Hit();

						List<string> hit_cid = new List<string>();
						for (int l = 0; l < _ctx.Length("GetSyncResult.Data["+ i +"].HitResult["+ j +"].Hits["+ k +"].Cid.Length"); l++) {
							hit_cid.Add(_ctx.StringValue("GetSyncResult.Data["+ i +"].HitResult["+ j +"].Hits["+ k +"].Cid["+ l +"]"));
						}
						hit.Cid = hit_cid;

						GetSyncResultResponse.GetSyncResult_ResultInfo.GetSyncResult_HitResultItem.GetSyncResult_Hit.GetSyncResult_Phrase phrase = new GetSyncResultResponse.GetSyncResult_ResultInfo.GetSyncResult_HitResultItem.GetSyncResult_Hit.GetSyncResult_Phrase();
						phrase.Role = _ctx.StringValue("GetSyncResult.Data["+ i +"].HitResult["+ j +"].Hits["+ k +"].Phrase.Role");
						phrase.Words = _ctx.StringValue("GetSyncResult.Data["+ i +"].HitResult["+ j +"].Hits["+ k +"].Phrase.Words");
						phrase.Begin = _ctx.LongValue("GetSyncResult.Data["+ i +"].HitResult["+ j +"].Hits["+ k +"].Phrase.Begin");
						phrase.End = _ctx.IntegerValue("GetSyncResult.Data["+ i +"].HitResult["+ j +"].Hits["+ k +"].Phrase.End");
						phrase.EmotionValue = _ctx.IntegerValue("GetSyncResult.Data["+ i +"].HitResult["+ j +"].Hits["+ k +"].Phrase.EmotionValue");
						phrase.SilenceDuration = _ctx.IntegerValue("GetSyncResult.Data["+ i +"].HitResult["+ j +"].Hits["+ k +"].Phrase.SilenceDuration");
						phrase.SpeechRate = _ctx.IntegerValue("GetSyncResult.Data["+ i +"].HitResult["+ j +"].Hits["+ k +"].Phrase.SpeechRate");
						hit.Phrase = phrase;

						List<GetSyncResultResponse.GetSyncResult_ResultInfo.GetSyncResult_HitResultItem.GetSyncResult_Hit.GetSyncResult_KeyWord> hit_keyWords = new List<GetSyncResultResponse.GetSyncResult_ResultInfo.GetSyncResult_HitResultItem.GetSyncResult_Hit.GetSyncResult_KeyWord>();
						for (int l = 0; l < _ctx.Length("GetSyncResult.Data["+ i +"].HitResult["+ j +"].Hits["+ k +"].KeyWords.Length"); l++) {
							GetSyncResultResponse.GetSyncResult_ResultInfo.GetSyncResult_HitResultItem.GetSyncResult_Hit.GetSyncResult_KeyWord keyWord = new GetSyncResultResponse.GetSyncResult_ResultInfo.GetSyncResult_HitResultItem.GetSyncResult_Hit.GetSyncResult_KeyWord();
							keyWord.Cid = _ctx.StringValue("GetSyncResult.Data["+ i +"].HitResult["+ j +"].Hits["+ k +"].KeyWords["+ l +"].Cid");
							keyWord.From = _ctx.IntegerValue("GetSyncResult.Data["+ i +"].HitResult["+ j +"].Hits["+ k +"].KeyWords["+ l +"].From");
							keyWord.To = _ctx.IntegerValue("GetSyncResult.Data["+ i +"].HitResult["+ j +"].Hits["+ k +"].KeyWords["+ l +"].To");
							keyWord.Val = _ctx.StringValue("GetSyncResult.Data["+ i +"].HitResult["+ j +"].Hits["+ k +"].KeyWords["+ l +"].Val");

							hit_keyWords.Add(keyWord);
						}
						hit.KeyWords = hit_keyWords;

						hitResultItem_hits.Add(hit);
					}
					hitResultItem.Hits = hitResultItem_hits;

					resultInfo_hitResult.Add(hitResultItem);
				}
				resultInfo.HitResult = resultInfo_hitResult;

				getSyncResultResponse_data.Add(resultInfo);
			}
			getSyncResultResponse.Data = getSyncResultResponse_data;
        
			return getSyncResultResponse;
        }
    }
}
