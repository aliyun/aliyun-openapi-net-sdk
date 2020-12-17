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
    public class ListAsrVocabResponseUnmarshaller
    {
        public static ListAsrVocabResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAsrVocabResponse listAsrVocabResponse = new ListAsrVocabResponse();

			listAsrVocabResponse.HttpResponse = _ctx.HttpResponse;
			listAsrVocabResponse.RequestId = _ctx.StringValue("ListAsrVocab.RequestId");
			listAsrVocabResponse.Success = _ctx.BooleanValue("ListAsrVocab.Success");
			listAsrVocabResponse.Code = _ctx.StringValue("ListAsrVocab.Code");
			listAsrVocabResponse.Message = _ctx.StringValue("ListAsrVocab.Message");

			List<ListAsrVocabResponse.ListAsrVocab_AsrVocab> listAsrVocabResponse_data = new List<ListAsrVocabResponse.ListAsrVocab_AsrVocab>();
			for (int i = 0; i < _ctx.Length("ListAsrVocab.Data.Length"); i++) {
				ListAsrVocabResponse.ListAsrVocab_AsrVocab asrVocab = new ListAsrVocabResponse.ListAsrVocab_AsrVocab();
				asrVocab.Id = _ctx.StringValue("ListAsrVocab.Data["+ i +"].Id");
				asrVocab.Name = _ctx.StringValue("ListAsrVocab.Data["+ i +"].Name");
				asrVocab.CreateTime = _ctx.StringValue("ListAsrVocab.Data["+ i +"].CreateTime");
				asrVocab.UpdateTime = _ctx.StringValue("ListAsrVocab.Data["+ i +"].UpdateTime");
				asrVocab.VocabularyId = _ctx.StringValue("ListAsrVocab.Data["+ i +"].VocabularyId");

				listAsrVocabResponse_data.Add(asrVocab);
			}
			listAsrVocabResponse.Data = listAsrVocabResponse_data;
        
			return listAsrVocabResponse;
        }
    }
}
