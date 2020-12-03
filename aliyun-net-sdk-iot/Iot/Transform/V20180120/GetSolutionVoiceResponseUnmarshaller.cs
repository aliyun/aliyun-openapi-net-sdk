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
    public class GetSolutionVoiceResponseUnmarshaller
    {
        public static GetSolutionVoiceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetSolutionVoiceResponse getSolutionVoiceResponse = new GetSolutionVoiceResponse();

			getSolutionVoiceResponse.HttpResponse = _ctx.HttpResponse;
			getSolutionVoiceResponse.RequestId = _ctx.StringValue("GetSolutionVoice.RequestId");
			getSolutionVoiceResponse.Success = _ctx.BooleanValue("GetSolutionVoice.Success");
			getSolutionVoiceResponse.Code = _ctx.StringValue("GetSolutionVoice.Code");
			getSolutionVoiceResponse.ErrorMessage = _ctx.StringValue("GetSolutionVoice.ErrorMessage");

			GetSolutionVoiceResponse.GetSolutionVoice_Data data = new GetSolutionVoiceResponse.GetSolutionVoice_Data();

			List<GetSolutionVoiceResponse.GetSolutionVoice_Data.GetSolutionVoice_Items> data_speechModelVoiceVOList = new List<GetSolutionVoiceResponse.GetSolutionVoice_Data.GetSolutionVoice_Items>();
			for (int i = 0; i < _ctx.Length("GetSolutionVoice.Data.SpeechModelVoiceVOList.Length"); i++) {
				GetSolutionVoiceResponse.GetSolutionVoice_Data.GetSolutionVoice_Items items = new GetSolutionVoiceResponse.GetSolutionVoice_Data.GetSolutionVoice_Items();
				items._Value = _ctx.StringValue("GetSolutionVoice.Data.SpeechModelVoiceVOList["+ i +"].Value");
				items.Label = _ctx.StringValue("GetSolutionVoice.Data.SpeechModelVoiceVOList["+ i +"].Label");
				items.Children = _ctx.StringValue("GetSolutionVoice.Data.SpeechModelVoiceVOList["+ i +"].Children");

				data_speechModelVoiceVOList.Add(items);
			}
			data.SpeechModelVoiceVOList = data_speechModelVoiceVOList;
			getSolutionVoiceResponse.Data = data;
        
			return getSolutionVoiceResponse;
        }
    }
}
