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
    public class GetSpeechModelResponseUnmarshaller
    {
        public static GetSpeechModelResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetSpeechModelResponse getSpeechModelResponse = new GetSpeechModelResponse();

			getSpeechModelResponse.HttpResponse = _ctx.HttpResponse;
			getSpeechModelResponse.RequestId = _ctx.StringValue("GetSpeechModel.RequestId");
			getSpeechModelResponse.Success = _ctx.BooleanValue("GetSpeechModel.Success");
			getSpeechModelResponse.Code = _ctx.StringValue("GetSpeechModel.Code");
			getSpeechModelResponse.ErrorMessage = _ctx.StringValue("GetSpeechModel.ErrorMessage");

			GetSpeechModelResponse.GetSpeechModel_Data data = new GetSpeechModelResponse.GetSpeechModel_Data();
			data.Code = _ctx.StringValue("GetSpeechModel.Data.Code");
			data.BizCode = _ctx.StringValue("GetSpeechModel.Data.BizCode");
			data.Voice = _ctx.StringValue("GetSpeechModel.Data.Voice");
			data.Volume = _ctx.IntegerValue("GetSpeechModel.Data.Volume");
			data.SpeechRate = _ctx.IntegerValue("GetSpeechModel.Data.SpeechRate");
			data.Text = _ctx.StringValue("GetSpeechModel.Data.Text");
			data.AudioFormat = _ctx.StringValue("GetSpeechModel.Data.AudioFormat");
			getSpeechModelResponse.Data = data;
        
			return getSpeechModelResponse;
        }
    }
}
