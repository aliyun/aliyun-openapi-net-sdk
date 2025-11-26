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
    public class TermEditResponseUnmarshaller
    {
        public static TermEditResponse Unmarshall(UnmarshallerContext _ctx)
        {
			TermEditResponse termEditResponse = new TermEditResponse();

			termEditResponse.HttpResponse = _ctx.HttpResponse;
			termEditResponse.Code = _ctx.StringValue("TermEdit.code");
			termEditResponse.Message = _ctx.StringValue("TermEdit.message");
			termEditResponse.RequestId = _ctx.StringValue("TermEdit.requestId");
			termEditResponse.Success = _ctx.BooleanValue("TermEdit.success");
			termEditResponse.HttpStatusCode = _ctx.StringValue("TermEdit.httpStatusCode");

			TermEditResponse.TermEdit_Data data = new TermEditResponse.TermEdit_Data();
			data.FailCount = _ctx.LongValue("TermEdit.Data.failCount");

			List<TermEditResponse.TermEdit_Data.TermEdit_TermsItem> data_terms = new List<TermEditResponse.TermEdit_Data.TermEdit_TermsItem>();
			for (int i = 0; i < _ctx.Length("TermEdit.Data.Terms.Length"); i++) {
				TermEditResponse.TermEdit_Data.TermEdit_TermsItem termsItem = new TermEditResponse.TermEdit_Data.TermEdit_TermsItem();
				termsItem.TermId = _ctx.StringValue("TermEdit.Data.Terms["+ i +"].termId");
				termsItem.Src = _ctx.StringValue("TermEdit.Data.Terms["+ i +"].src");
				termsItem.Tgt = _ctx.StringValue("TermEdit.Data.Terms["+ i +"].tgt");

				data_terms.Add(termsItem);
			}
			data.Terms = data_terms;
			termEditResponse.Data = data;
        
			return termEditResponse;
        }
    }
}
