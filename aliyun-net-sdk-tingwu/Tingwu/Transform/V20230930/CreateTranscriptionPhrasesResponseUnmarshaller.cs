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
using Aliyun.Acs.tingwu.Model.V20230930;

namespace Aliyun.Acs.tingwu.Transform.V20230930
{
    public class CreateTranscriptionPhrasesResponseUnmarshaller
    {
        public static CreateTranscriptionPhrasesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateTranscriptionPhrasesResponse createTranscriptionPhrasesResponse = new CreateTranscriptionPhrasesResponse();

			createTranscriptionPhrasesResponse.HttpResponse = _ctx.HttpResponse;
			createTranscriptionPhrasesResponse.RequestId = _ctx.StringValue("CreateTranscriptionPhrases.RequestId");
			createTranscriptionPhrasesResponse.Code = _ctx.StringValue("CreateTranscriptionPhrases.Code");
			createTranscriptionPhrasesResponse.Message = _ctx.StringValue("CreateTranscriptionPhrases.Message");

			CreateTranscriptionPhrasesResponse.CreateTranscriptionPhrases_Data data = new CreateTranscriptionPhrasesResponse.CreateTranscriptionPhrases_Data();
			data.Status = _ctx.StringValue("CreateTranscriptionPhrases.Data.Status");
			data.PhraseId = _ctx.StringValue("CreateTranscriptionPhrases.Data.PhraseId");
			data.ErrorCode = _ctx.StringValue("CreateTranscriptionPhrases.Data.ErrorCode");
			data.ErrorMessage = _ctx.StringValue("CreateTranscriptionPhrases.Data.ErrorMessage");
			createTranscriptionPhrasesResponse.Data = data;
        
			return createTranscriptionPhrasesResponse;
        }
    }
}
