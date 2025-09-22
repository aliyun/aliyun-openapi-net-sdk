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
    public class BatchTranslateResponseUnmarshaller
    {
        public static BatchTranslateResponse Unmarshall(UnmarshallerContext _ctx)
        {
			BatchTranslateResponse batchTranslateResponse = new BatchTranslateResponse();

			batchTranslateResponse.HttpResponse = _ctx.HttpResponse;
			batchTranslateResponse.Code = _ctx.StringValue("BatchTranslate.code");
			batchTranslateResponse.Message = _ctx.StringValue("BatchTranslate.message");
			batchTranslateResponse.RequestId = _ctx.StringValue("BatchTranslate.requestId");
			batchTranslateResponse.Success = _ctx.BooleanValue("BatchTranslate.success");
			batchTranslateResponse.HttpStatusCode = _ctx.StringValue("BatchTranslate.httpStatusCode");

			BatchTranslateResponse.BatchTranslate_Data data = new BatchTranslateResponse.BatchTranslate_Data();

			List<BatchTranslateResponse.BatchTranslate_Data.BatchTranslate_TranslationListItem> data_translationList = new List<BatchTranslateResponse.BatchTranslate_Data.BatchTranslate_TranslationListItem>();
			for (int i = 0; i < _ctx.Length("BatchTranslate.Data.TranslationList.Length"); i++) {
				BatchTranslateResponse.BatchTranslate_Data.BatchTranslate_TranslationListItem translationListItem = new BatchTranslateResponse.BatchTranslate_Data.BatchTranslate_TranslationListItem();
				translationListItem.Code = _ctx.LongValue("BatchTranslate.Data.TranslationList["+ i +"].code");
				translationListItem.Message = _ctx.StringValue("BatchTranslate.Data.TranslationList["+ i +"].message");
				translationListItem.Index = _ctx.StringValue("BatchTranslate.Data.TranslationList["+ i +"].index");
				translationListItem.Translation = _ctx.StringValue("BatchTranslate.Data.TranslationList["+ i +"].translation");

				BatchTranslateResponse.BatchTranslate_Data.BatchTranslate_TranslationListItem.BatchTranslate_Usage usage = new BatchTranslateResponse.BatchTranslate_Data.BatchTranslate_TranslationListItem.BatchTranslate_Usage();
				usage.InputTokens = _ctx.LongValue("BatchTranslate.Data.TranslationList["+ i +"].Usage.inputTokens");
				usage.OutputTokens = _ctx.LongValue("BatchTranslate.Data.TranslationList["+ i +"].Usage.outputTokens");
				usage.TotalTokens = _ctx.LongValue("BatchTranslate.Data.TranslationList["+ i +"].Usage.totalTokens");
				translationListItem.Usage = usage;

				data_translationList.Add(translationListItem);
			}
			data.TranslationList = data_translationList;
			batchTranslateResponse.Data = data;
        
			return batchTranslateResponse;
        }
    }
}
