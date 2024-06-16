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
    public class ListTranscriptionPhrasesResponseUnmarshaller
    {
        public static ListTranscriptionPhrasesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTranscriptionPhrasesResponse listTranscriptionPhrasesResponse = new ListTranscriptionPhrasesResponse();

			listTranscriptionPhrasesResponse.HttpResponse = _ctx.HttpResponse;
			listTranscriptionPhrasesResponse.RequestId = _ctx.StringValue("ListTranscriptionPhrases.RequestId");
			listTranscriptionPhrasesResponse.Code = _ctx.StringValue("ListTranscriptionPhrases.Code");
			listTranscriptionPhrasesResponse.Message = _ctx.StringValue("ListTranscriptionPhrases.Message");

			ListTranscriptionPhrasesResponse.ListTranscriptionPhrases_Data data = new ListTranscriptionPhrasesResponse.ListTranscriptionPhrases_Data();
			data.Status = _ctx.StringValue("ListTranscriptionPhrases.Data.Status");
			data.ErrorCode = _ctx.StringValue("ListTranscriptionPhrases.Data.ErrorCode");
			data.ErrorMessage = _ctx.StringValue("ListTranscriptionPhrases.Data.ErrorMessage");

			List<ListTranscriptionPhrasesResponse.ListTranscriptionPhrases_Data.ListTranscriptionPhrases_热词列表> data_phrases = new List<ListTranscriptionPhrasesResponse.ListTranscriptionPhrases_Data.ListTranscriptionPhrases_热词列表>();
			for (int i = 0; i < _ctx.Length("ListTranscriptionPhrases.Data.Phrases.Length"); i++) {
				ListTranscriptionPhrasesResponse.ListTranscriptionPhrases_Data.ListTranscriptionPhrases_热词列表 热词列表 = new ListTranscriptionPhrasesResponse.ListTranscriptionPhrases_Data.ListTranscriptionPhrases_热词列表();
				热词列表.PhraseId = _ctx.StringValue("ListTranscriptionPhrases.Data.Phrases["+ i +"].PhraseId");
				热词列表.Name = _ctx.StringValue("ListTranscriptionPhrases.Data.Phrases["+ i +"].Name");
				热词列表.Description = _ctx.StringValue("ListTranscriptionPhrases.Data.Phrases["+ i +"].Description");

				data_phrases.Add(热词列表);
			}
			data.Phrases = data_phrases;
			listTranscriptionPhrasesResponse.Data = data;
        
			return listTranscriptionPhrasesResponse;
        }
    }
}
