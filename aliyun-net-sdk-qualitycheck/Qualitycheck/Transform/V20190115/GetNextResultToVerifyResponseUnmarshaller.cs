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
    public class GetNextResultToVerifyResponseUnmarshaller
    {
        public static GetNextResultToVerifyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetNextResultToVerifyResponse getNextResultToVerifyResponse = new GetNextResultToVerifyResponse();

			getNextResultToVerifyResponse.HttpResponse = _ctx.HttpResponse;
			getNextResultToVerifyResponse.RequestId = _ctx.StringValue("GetNextResultToVerify.RequestId");
			getNextResultToVerifyResponse.Success = _ctx.BooleanValue("GetNextResultToVerify.Success");
			getNextResultToVerifyResponse.Code = _ctx.StringValue("GetNextResultToVerify.Code");
			getNextResultToVerifyResponse.Message = _ctx.StringValue("GetNextResultToVerify.Message");

			GetNextResultToVerifyResponse.GetNextResultToVerify_Data data = new GetNextResultToVerifyResponse.GetNextResultToVerify_Data();
			data.Status = _ctx.IntegerValue("GetNextResultToVerify.Data.Status");
			data.AudioURL = _ctx.StringValue("GetNextResultToVerify.Data.AudioURL");
			data.AudioScheme = _ctx.StringValue("GetNextResultToVerify.Data.AudioScheme");
			data.FileName = _ctx.StringValue("GetNextResultToVerify.Data.FileName");
			data.FileId = _ctx.StringValue("GetNextResultToVerify.Data.FileId");
			data.Verified = _ctx.BooleanValue("GetNextResultToVerify.Data.Verified");
			data.TotalCount = _ctx.IntegerValue("GetNextResultToVerify.Data.TotalCount");
			data.VerifiedCount = _ctx.IntegerValue("GetNextResultToVerify.Data.VerifiedCount");
			data.IncorrectWords = _ctx.IntegerValue("GetNextResultToVerify.Data.IncorrectWords");
			data.Precision = _ctx.FloatValue("GetNextResultToVerify.Data.Precision");
			data.UpdateTime = _ctx.StringValue("GetNextResultToVerify.Data.UpdateTime");
			data.Duration = _ctx.IntegerValue("GetNextResultToVerify.Data.Duration");
			data.Index = _ctx.IntegerValue("GetNextResultToVerify.Data.Index");

			List<GetNextResultToVerifyResponse.GetNextResultToVerify_Data.GetNextResultToVerify_Dialogue> data_dialogues = new List<GetNextResultToVerifyResponse.GetNextResultToVerify_Data.GetNextResultToVerify_Dialogue>();
			for (int i = 0; i < _ctx.Length("GetNextResultToVerify.Data.Dialogues.Length"); i++) {
				GetNextResultToVerifyResponse.GetNextResultToVerify_Data.GetNextResultToVerify_Dialogue dialogue = new GetNextResultToVerifyResponse.GetNextResultToVerify_Data.GetNextResultToVerify_Dialogue();
				dialogue.Begin = _ctx.LongValue("GetNextResultToVerify.Data.Dialogues["+ i +"].Begin");
				dialogue.BeginTime = _ctx.StringValue("GetNextResultToVerify.Data.Dialogues["+ i +"].BeginTime");
				dialogue.EmotionValue = _ctx.IntegerValue("GetNextResultToVerify.Data.Dialogues["+ i +"].EmotionValue");
				dialogue.End = _ctx.LongValue("GetNextResultToVerify.Data.Dialogues["+ i +"].End");
				dialogue.HourMinSec = _ctx.StringValue("GetNextResultToVerify.Data.Dialogues["+ i +"].HourMinSec");
				dialogue.Identity = _ctx.StringValue("GetNextResultToVerify.Data.Dialogues["+ i +"].Identity");
				dialogue.Role = _ctx.StringValue("GetNextResultToVerify.Data.Dialogues["+ i +"].Role");
				dialogue.SourceRole = _ctx.StringValue("GetNextResultToVerify.Data.Dialogues["+ i +"].SourceRole");
				dialogue.SilenceDuration = _ctx.IntegerValue("GetNextResultToVerify.Data.Dialogues["+ i +"].SilenceDuration");
				dialogue.SpeechRate = _ctx.IntegerValue("GetNextResultToVerify.Data.Dialogues["+ i +"].SpeechRate");
				dialogue.Words = _ctx.StringValue("GetNextResultToVerify.Data.Dialogues["+ i +"].Words");
				dialogue.SourceWords = _ctx.StringValue("GetNextResultToVerify.Data.Dialogues["+ i +"].SourceWords");
				dialogue.IncorrectWords = _ctx.IntegerValue("GetNextResultToVerify.Data.Dialogues["+ i +"].IncorrectWords");

				List<GetNextResultToVerifyResponse.GetNextResultToVerify_Data.GetNextResultToVerify_Dialogue.GetNextResultToVerify_Delta> dialogue_deltas = new List<GetNextResultToVerifyResponse.GetNextResultToVerify_Data.GetNextResultToVerify_Dialogue.GetNextResultToVerify_Delta>();
				for (int j = 0; j < _ctx.Length("GetNextResultToVerify.Data.Dialogues["+ i +"].Deltas.Length"); j++) {
					GetNextResultToVerifyResponse.GetNextResultToVerify_Data.GetNextResultToVerify_Dialogue.GetNextResultToVerify_Delta delta = new GetNextResultToVerifyResponse.GetNextResultToVerify_Data.GetNextResultToVerify_Dialogue.GetNextResultToVerify_Delta();
					delta.Type = _ctx.StringValue("GetNextResultToVerify.Data.Dialogues["+ i +"].Deltas["+ j +"].Type");

					GetNextResultToVerifyResponse.GetNextResultToVerify_Data.GetNextResultToVerify_Dialogue.GetNextResultToVerify_Delta.GetNextResultToVerify_Source source = new GetNextResultToVerifyResponse.GetNextResultToVerify_Data.GetNextResultToVerify_Dialogue.GetNextResultToVerify_Delta.GetNextResultToVerify_Source();
					source.Position = _ctx.IntegerValue("GetNextResultToVerify.Data.Dialogues["+ i +"].Deltas["+ j +"].Source.Position");

					List<string> source_line = new List<string>();
					for (int k = 0; k < _ctx.Length("GetNextResultToVerify.Data.Dialogues["+ i +"].Deltas["+ j +"].Source.Line.Length"); k++) {
						source_line.Add(_ctx.StringValue("GetNextResultToVerify.Data.Dialogues["+ i +"].Deltas["+ j +"].Source.Line["+ k +"]"));
					}
					source.Line = source_line;
					delta.Source = source;

					GetNextResultToVerifyResponse.GetNextResultToVerify_Data.GetNextResultToVerify_Dialogue.GetNextResultToVerify_Delta.GetNextResultToVerify_Target target = new GetNextResultToVerifyResponse.GetNextResultToVerify_Data.GetNextResultToVerify_Dialogue.GetNextResultToVerify_Delta.GetNextResultToVerify_Target();
					target.Position = _ctx.IntegerValue("GetNextResultToVerify.Data.Dialogues["+ i +"].Deltas["+ j +"].Target.Position");

					List<string> target_line1 = new List<string>();
					for (int k = 0; k < _ctx.Length("GetNextResultToVerify.Data.Dialogues["+ i +"].Deltas["+ j +"].Target.Line.Length"); k++) {
						target_line1.Add(_ctx.StringValue("GetNextResultToVerify.Data.Dialogues["+ i +"].Deltas["+ j +"].Target.Line["+ k +"]"));
					}
					target.Line1 = target_line1;
					delta.Target = target;

					dialogue_deltas.Add(delta);
				}
				dialogue.Deltas = dialogue_deltas;

				data_dialogues.Add(dialogue);
			}
			data.Dialogues = data_dialogues;
			getNextResultToVerifyResponse.Data = data;
        
			return getNextResultToVerifyResponse;
        }
    }
}
