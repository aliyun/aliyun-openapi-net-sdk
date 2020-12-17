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
    public class GetRecognizeResultResponseUnmarshaller
    {
        public static GetRecognizeResultResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetRecognizeResultResponse getRecognizeResultResponse = new GetRecognizeResultResponse();

			getRecognizeResultResponse.HttpResponse = _ctx.HttpResponse;
			getRecognizeResultResponse.RequestId = _ctx.StringValue("GetRecognizeResult.RequestId");
			getRecognizeResultResponse.Success = _ctx.BooleanValue("GetRecognizeResult.Success");
			getRecognizeResultResponse.Code = _ctx.StringValue("GetRecognizeResult.Code");
			getRecognizeResultResponse.Message = _ctx.StringValue("GetRecognizeResult.Message");

			GetRecognizeResultResponse.GetRecognizeResult_Data data = new GetRecognizeResultResponse.GetRecognizeResult_Data();
			data.TaskAsrRequestId = _ctx.LongValue("GetRecognizeResult.Data.TaskAsrRequestId");

			List<GetRecognizeResultResponse.GetRecognizeResult_Data.GetRecognizeResult_Dialogue> data_dialogues = new List<GetRecognizeResultResponse.GetRecognizeResult_Data.GetRecognizeResult_Dialogue>();
			for (int i = 0; i < _ctx.Length("GetRecognizeResult.Data.Dialogues.Length"); i++) {
				GetRecognizeResultResponse.GetRecognizeResult_Data.GetRecognizeResult_Dialogue dialogue = new GetRecognizeResultResponse.GetRecognizeResult_Data.GetRecognizeResult_Dialogue();
				dialogue.Begin = _ctx.LongValue("GetRecognizeResult.Data.Dialogues["+ i +"].Begin");
				dialogue.BeginTime = _ctx.StringValue("GetRecognizeResult.Data.Dialogues["+ i +"].BeginTime");
				dialogue.EmotionValue = _ctx.IntegerValue("GetRecognizeResult.Data.Dialogues["+ i +"].EmotionValue");
				dialogue.End = _ctx.LongValue("GetRecognizeResult.Data.Dialogues["+ i +"].End");
				dialogue.HourMinSec = _ctx.StringValue("GetRecognizeResult.Data.Dialogues["+ i +"].HourMinSec");
				dialogue.Identity = _ctx.StringValue("GetRecognizeResult.Data.Dialogues["+ i +"].Identity");
				dialogue.Role = _ctx.StringValue("GetRecognizeResult.Data.Dialogues["+ i +"].Role");
				dialogue.SilenceDuration = _ctx.IntegerValue("GetRecognizeResult.Data.Dialogues["+ i +"].SilenceDuration");
				dialogue.SpeechRate = _ctx.IntegerValue("GetRecognizeResult.Data.Dialogues["+ i +"].SpeechRate");
				dialogue.Words = _ctx.StringValue("GetRecognizeResult.Data.Dialogues["+ i +"].Words");

				data_dialogues.Add(dialogue);
			}
			data.Dialogues = data_dialogues;
			getRecognizeResultResponse.Data = data;
        
			return getRecognizeResultResponse;
        }
    }
}
