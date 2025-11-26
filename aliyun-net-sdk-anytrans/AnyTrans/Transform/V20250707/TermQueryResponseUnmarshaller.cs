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
    public class TermQueryResponseUnmarshaller
    {
        public static TermQueryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			TermQueryResponse termQueryResponse = new TermQueryResponse();

			termQueryResponse.HttpResponse = _ctx.HttpResponse;
			termQueryResponse.Code = _ctx.StringValue("TermQuery.code");
			termQueryResponse.Message = _ctx.StringValue("TermQuery.message");
			termQueryResponse.RequestId = _ctx.StringValue("TermQuery.requestId");
			termQueryResponse.Success = _ctx.BooleanValue("TermQuery.success");
			termQueryResponse.HttpStatusCode = _ctx.StringValue("TermQuery.httpStatusCode");

			TermQueryResponse.TermQuery_Data data = new TermQueryResponse.TermQuery_Data();
			data.FailCount = _ctx.LongValue("TermQuery.Data.failCount");

			List<TermQueryResponse.TermQuery_Data.TermQuery_TermsItem> data_terms = new List<TermQueryResponse.TermQuery_Data.TermQuery_TermsItem>();
			for (int i = 0; i < _ctx.Length("TermQuery.Data.Terms.Length"); i++) {
				TermQueryResponse.TermQuery_Data.TermQuery_TermsItem termsItem = new TermQueryResponse.TermQuery_Data.TermQuery_TermsItem();
				termsItem.TermId = _ctx.StringValue("TermQuery.Data.Terms["+ i +"].termId");
				termsItem.Src = _ctx.StringValue("TermQuery.Data.Terms["+ i +"].src");
				termsItem.Tgt = _ctx.StringValue("TermQuery.Data.Terms["+ i +"].tgt");

				data_terms.Add(termsItem);
			}
			data.Terms = data_terms;
			termQueryResponse.Data = data;
        
			return termQueryResponse;
        }
    }
}
