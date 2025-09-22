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
using Aliyun.Acs.AnyTrans.Model.V20250707;

namespace Aliyun.Acs.AnyTrans.Transform.V20250707
{
    public class TextTranslateResponseUnmarshaller
    {
        public static TextTranslateResponse Unmarshall(UnmarshallerContext _ctx)
        {
			TextTranslateResponse textTranslateResponse = new TextTranslateResponse();

			textTranslateResponse.HttpResponse = _ctx.HttpResponse;
			textTranslateResponse.Code = _ctx.StringValue("TextTranslate.code");
			textTranslateResponse.Message = _ctx.StringValue("TextTranslate.message");
			textTranslateResponse.RequestId = _ctx.StringValue("TextTranslate.requestId");
			textTranslateResponse.Success = _ctx.BooleanValue("TextTranslate.success");
			textTranslateResponse.HttpStatusCode = _ctx.StringValue("TextTranslate.httpStatusCode");

			TextTranslateResponse.TextTranslate_Data data = new TextTranslateResponse.TextTranslate_Data();
			data.Translation = _ctx.StringValue("TextTranslate.Data.translation");

			TextTranslateResponse.TextTranslate_Data.TextTranslate_Usage usage = new TextTranslateResponse.TextTranslate_Data.TextTranslate_Usage();
			usage.InputTokens = _ctx.LongValue("TextTranslate.Data.Usage.inputTokens");
			usage.OutputTokens = _ctx.LongValue("TextTranslate.Data.Usage.outputTokens");
			usage.TotalTokens = _ctx.LongValue("TextTranslate.Data.Usage.totalTokens");
			data.Usage = usage;
			textTranslateResponse.Data = data;
        
			return textTranslateResponse;
        }
    }
}
