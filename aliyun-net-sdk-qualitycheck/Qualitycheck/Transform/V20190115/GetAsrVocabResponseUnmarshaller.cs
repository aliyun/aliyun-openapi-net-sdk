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
    public class GetAsrVocabResponseUnmarshaller
    {
        public static GetAsrVocabResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetAsrVocabResponse getAsrVocabResponse = new GetAsrVocabResponse();

			getAsrVocabResponse.HttpResponse = _ctx.HttpResponse;
			getAsrVocabResponse.Code = _ctx.StringValue("GetAsrVocab.Code");
			getAsrVocabResponse.Message = _ctx.StringValue("GetAsrVocab.Message");
			getAsrVocabResponse.RequestId = _ctx.StringValue("GetAsrVocab.RequestId");
			getAsrVocabResponse.Success = _ctx.BooleanValue("GetAsrVocab.Success");

			GetAsrVocabResponse.GetAsrVocab_Data data = new GetAsrVocabResponse.GetAsrVocab_Data();
			data.Name = _ctx.StringValue("GetAsrVocab.Data.Name");

			List<GetAsrVocabResponse.GetAsrVocab_Data.GetAsrVocab_Word> data_words = new List<GetAsrVocabResponse.GetAsrVocab_Data.GetAsrVocab_Word>();
			for (int i = 0; i < _ctx.Length("GetAsrVocab.Data.Words.Length"); i++) {
				GetAsrVocabResponse.GetAsrVocab_Data.GetAsrVocab_Word word = new GetAsrVocabResponse.GetAsrVocab_Data.GetAsrVocab_Word();
				word.Weight = _ctx.IntegerValue("GetAsrVocab.Data.Words["+ i +"].Weight");
				word.Word = _ctx.StringValue("GetAsrVocab.Data.Words["+ i +"].Word");

				data_words.Add(word);
			}
			data.Words = data_words;
			getAsrVocabResponse.Data = data;
        
			return getAsrVocabResponse;
        }
    }
}
