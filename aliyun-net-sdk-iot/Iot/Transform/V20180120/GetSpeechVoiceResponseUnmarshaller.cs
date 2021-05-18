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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class GetSpeechVoiceResponseUnmarshaller
    {
        public static GetSpeechVoiceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetSpeechVoiceResponse getSpeechVoiceResponse = new GetSpeechVoiceResponse();

			getSpeechVoiceResponse.HttpResponse = _ctx.HttpResponse;
			getSpeechVoiceResponse.RequestId = _ctx.StringValue("GetSpeechVoice.RequestId");
			getSpeechVoiceResponse.Success = _ctx.BooleanValue("GetSpeechVoice.Success");
			getSpeechVoiceResponse.Code = _ctx.StringValue("GetSpeechVoice.Code");
			getSpeechVoiceResponse.ErrorMessage = _ctx.StringValue("GetSpeechVoice.ErrorMessage");

			List<GetSpeechVoiceResponse.GetSpeechVoice_Items> getSpeechVoiceResponse_data = new List<GetSpeechVoiceResponse.GetSpeechVoice_Items>();
			for (int i = 0; i < _ctx.Length("GetSpeechVoice.Data.Length"); i++) {
				GetSpeechVoiceResponse.GetSpeechVoice_Items items = new GetSpeechVoiceResponse.GetSpeechVoice_Items();
				items._Value = _ctx.StringValue("GetSpeechVoice.Data["+ i +"].Value");
				items.Label = _ctx.StringValue("GetSpeechVoice.Data["+ i +"].Label");

				List<GetSpeechVoiceResponse.GetSpeechVoice_Items.GetSpeechVoice_Items1> items_voiceList = new List<GetSpeechVoiceResponse.GetSpeechVoice_Items.GetSpeechVoice_Items1>();
				for (int j = 0; j < _ctx.Length("GetSpeechVoice.Data["+ i +"].VoiceList.Length"); j++) {
					GetSpeechVoiceResponse.GetSpeechVoice_Items.GetSpeechVoice_Items1 items1 = new GetSpeechVoiceResponse.GetSpeechVoice_Items.GetSpeechVoice_Items1();
					items1._Value = _ctx.StringValue("GetSpeechVoice.Data["+ i +"].VoiceList["+ j +"].Value");
					items1.Label = _ctx.StringValue("GetSpeechVoice.Data["+ i +"].VoiceList["+ j +"].Label");

					items_voiceList.Add(items1);
				}
				items.VoiceList = items_voiceList;

				getSpeechVoiceResponse_data.Add(items);
			}
			getSpeechVoiceResponse.Data = getSpeechVoiceResponse_data;
        
			return getSpeechVoiceResponse;
        }
    }
}
