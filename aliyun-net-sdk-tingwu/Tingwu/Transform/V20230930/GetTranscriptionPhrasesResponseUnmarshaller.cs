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
    public class GetTranscriptionPhrasesResponseUnmarshaller
    {
        public static GetTranscriptionPhrasesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetTranscriptionPhrasesResponse getTranscriptionPhrasesResponse = new GetTranscriptionPhrasesResponse();

			getTranscriptionPhrasesResponse.HttpResponse = _ctx.HttpResponse;
			getTranscriptionPhrasesResponse.RequestId = _ctx.StringValue("GetTranscriptionPhrases.RequestId");
			getTranscriptionPhrasesResponse.Code = _ctx.StringValue("GetTranscriptionPhrases.Code");
			getTranscriptionPhrasesResponse.Message = _ctx.StringValue("GetTranscriptionPhrases.Message");

			GetTranscriptionPhrasesResponse.GetTranscriptionPhrases_Data data = new GetTranscriptionPhrasesResponse.GetTranscriptionPhrases_Data();
			data.Status = _ctx.StringValue("GetTranscriptionPhrases.Data.Status");
			data.ErrorCode = _ctx.StringValue("GetTranscriptionPhrases.Data.ErrorCode");
			data.ErrorMessage = _ctx.StringValue("GetTranscriptionPhrases.Data.ErrorMessage");

			List<GetTranscriptionPhrasesResponse.GetTranscriptionPhrases_Data.GetTranscriptionPhrases_热词列表> data_phrases = new List<GetTranscriptionPhrasesResponse.GetTranscriptionPhrases_Data.GetTranscriptionPhrases_热词列表>();
			for (int i = 0; i < _ctx.Length("GetTranscriptionPhrases.Data.Phrases.Length"); i++) {
				GetTranscriptionPhrasesResponse.GetTranscriptionPhrases_Data.GetTranscriptionPhrases_热词列表 热词列表 = new GetTranscriptionPhrasesResponse.GetTranscriptionPhrases_Data.GetTranscriptionPhrases_热词列表();
				热词列表.PhraseId = _ctx.StringValue("GetTranscriptionPhrases.Data.Phrases["+ i +"].PhraseId");
				热词列表.Name = _ctx.StringValue("GetTranscriptionPhrases.Data.Phrases["+ i +"].Name");
				热词列表.Description = _ctx.StringValue("GetTranscriptionPhrases.Data.Phrases["+ i +"].Description");
				热词列表.WordWeights = _ctx.StringValue("GetTranscriptionPhrases.Data.Phrases["+ i +"].WordWeights");

				data_phrases.Add(热词列表);
			}
			data.Phrases = data_phrases;
			getTranscriptionPhrasesResponse.Data = data;
        
			return getTranscriptionPhrasesResponse;
        }
    }
}
