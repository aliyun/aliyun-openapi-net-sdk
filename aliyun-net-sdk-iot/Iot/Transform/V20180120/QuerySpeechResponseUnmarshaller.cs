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
    public class QuerySpeechResponseUnmarshaller
    {
        public static QuerySpeechResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QuerySpeechResponse querySpeechResponse = new QuerySpeechResponse();

			querySpeechResponse.HttpResponse = _ctx.HttpResponse;
			querySpeechResponse.RequestId = _ctx.StringValue("QuerySpeech.RequestId");
			querySpeechResponse.Success = _ctx.BooleanValue("QuerySpeech.Success");
			querySpeechResponse.Code = _ctx.StringValue("QuerySpeech.Code");
			querySpeechResponse.ErrorMessage = _ctx.StringValue("QuerySpeech.ErrorMessage");

			QuerySpeechResponse.QuerySpeech_Data data = new QuerySpeechResponse.QuerySpeech_Data();
			data.SpeechCode = _ctx.StringValue("QuerySpeech.Data.SpeechCode");
			data.BizCode = _ctx.StringValue("QuerySpeech.Data.BizCode");
			data.Voice = _ctx.StringValue("QuerySpeech.Data.Voice");
			data.Volume = _ctx.IntegerValue("QuerySpeech.Data.Volume");
			data.SpeechRate = _ctx.IntegerValue("QuerySpeech.Data.SpeechRate");
			data.Text = _ctx.StringValue("QuerySpeech.Data.Text");
			data.AudioFormat = _ctx.StringValue("QuerySpeech.Data.AudioFormat");
			data.SpeechType = _ctx.StringValue("QuerySpeech.Data.SpeechType");
			querySpeechResponse.Data = data;
        
			return querySpeechResponse;
        }
    }
}
