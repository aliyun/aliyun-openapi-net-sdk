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
    public class BatchTranslateForHtmlResponseUnmarshaller
    {
        public static BatchTranslateForHtmlResponse Unmarshall(UnmarshallerContext _ctx)
        {
			BatchTranslateForHtmlResponse batchTranslateForHtmlResponse = new BatchTranslateForHtmlResponse();

			batchTranslateForHtmlResponse.HttpResponse = _ctx.HttpResponse;
			batchTranslateForHtmlResponse.Code = _ctx.StringValue("BatchTranslateForHtml.code");
			batchTranslateForHtmlResponse.Message = _ctx.StringValue("BatchTranslateForHtml.message");
			batchTranslateForHtmlResponse.RequestId = _ctx.StringValue("BatchTranslateForHtml.requestId");
			batchTranslateForHtmlResponse.Success = _ctx.BooleanValue("BatchTranslateForHtml.success");
			batchTranslateForHtmlResponse.HttpStatusCode = _ctx.StringValue("BatchTranslateForHtml.httpStatusCode");

			BatchTranslateForHtmlResponse.BatchTranslateForHtml_Data data = new BatchTranslateForHtmlResponse.BatchTranslateForHtml_Data();

			List<BatchTranslateForHtmlResponse.BatchTranslateForHtml_Data.BatchTranslateForHtml_TranslationListItem> data_translationList = new List<BatchTranslateForHtmlResponse.BatchTranslateForHtml_Data.BatchTranslateForHtml_TranslationListItem>();
			for (int i = 0; i < _ctx.Length("BatchTranslateForHtml.Data.TranslationList.Length"); i++) {
				BatchTranslateForHtmlResponse.BatchTranslateForHtml_Data.BatchTranslateForHtml_TranslationListItem translationListItem = new BatchTranslateForHtmlResponse.BatchTranslateForHtml_Data.BatchTranslateForHtml_TranslationListItem();
				translationListItem.Code = _ctx.LongValue("BatchTranslateForHtml.Data.TranslationList["+ i +"].code");
				translationListItem.Message = _ctx.StringValue("BatchTranslateForHtml.Data.TranslationList["+ i +"].message");
				translationListItem.Index = _ctx.StringValue("BatchTranslateForHtml.Data.TranslationList["+ i +"].index");
				translationListItem.Translation = _ctx.StringValue("BatchTranslateForHtml.Data.TranslationList["+ i +"].translation");

				BatchTranslateForHtmlResponse.BatchTranslateForHtml_Data.BatchTranslateForHtml_TranslationListItem.BatchTranslateForHtml_Usage usage = new BatchTranslateForHtmlResponse.BatchTranslateForHtml_Data.BatchTranslateForHtml_TranslationListItem.BatchTranslateForHtml_Usage();
				usage.InputTokens = _ctx.LongValue("BatchTranslateForHtml.Data.TranslationList["+ i +"].Usage.inputTokens");
				usage.OutputTokens = _ctx.LongValue("BatchTranslateForHtml.Data.TranslationList["+ i +"].Usage.outputTokens");
				usage.TotalTokens = _ctx.LongValue("BatchTranslateForHtml.Data.TranslationList["+ i +"].Usage.totalTokens");
				translationListItem.Usage = usage;

				data_translationList.Add(translationListItem);
			}
			data.TranslationList = data_translationList;
			batchTranslateForHtmlResponse.Data = data;
        
			return batchTranslateForHtmlResponse;
        }
    }
}
