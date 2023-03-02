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
using Aliyun.Acs.lto.Model.V20210707;

namespace Aliyun.Acs.lto.Transform.V20210707
{
    public class ListPrivacyRuleResponseUnmarshaller
    {
        public static ListPrivacyRuleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListPrivacyRuleResponse listPrivacyRuleResponse = new ListPrivacyRuleResponse();

			listPrivacyRuleResponse.HttpResponse = _ctx.HttpResponse;
			listPrivacyRuleResponse.Code = _ctx.StringValue("ListPrivacyRule.Code");
			listPrivacyRuleResponse.HttpStatusCode = _ctx.IntegerValue("ListPrivacyRule.HttpStatusCode");
			listPrivacyRuleResponse.Message = _ctx.StringValue("ListPrivacyRule.Message");
			listPrivacyRuleResponse.RequestId = _ctx.StringValue("ListPrivacyRule.RequestId");
			listPrivacyRuleResponse.Success = _ctx.BooleanValue("ListPrivacyRule.Success");

			ListPrivacyRuleResponse.ListPrivacyRule_Data data = new ListPrivacyRuleResponse.ListPrivacyRule_Data();
			data.Num = _ctx.IntegerValue("ListPrivacyRule.Data.Num");
			data.Total = _ctx.IntegerValue("ListPrivacyRule.Data.Total");
			data.Size = _ctx.IntegerValue("ListPrivacyRule.Data.Size");

			List<ListPrivacyRuleResponse.ListPrivacyRule_Data.ListPrivacyRule_PrivacyRuleInfo> data_pageData = new List<ListPrivacyRuleResponse.ListPrivacyRule_Data.ListPrivacyRule_PrivacyRuleInfo>();
			for (int i = 0; i < _ctx.Length("ListPrivacyRule.Data.PageData.Length"); i++) {
				ListPrivacyRuleResponse.ListPrivacyRule_Data.ListPrivacyRule_PrivacyRuleInfo privacyRuleInfo = new ListPrivacyRuleResponse.ListPrivacyRule_Data.ListPrivacyRule_PrivacyRuleInfo();
				privacyRuleInfo.Status = _ctx.StringValue("ListPrivacyRule.Data.PageData["+ i +"].Status");
				privacyRuleInfo.CurrentUser = _ctx.BooleanValue("ListPrivacyRule.Data.PageData["+ i +"].CurrentUser");
				privacyRuleInfo.AlgType = _ctx.StringValue("ListPrivacyRule.Data.PageData["+ i +"].AlgType");
				privacyRuleInfo.Remark = _ctx.StringValue("ListPrivacyRule.Data.PageData["+ i +"].Remark");
				privacyRuleInfo.MemberName = _ctx.StringValue("ListPrivacyRule.Data.PageData["+ i +"].MemberName");
				privacyRuleInfo.PrivacyRuleId = _ctx.StringValue("ListPrivacyRule.Data.PageData["+ i +"].PrivacyRuleId");
				privacyRuleInfo.Name = _ctx.StringValue("ListPrivacyRule.Data.PageData["+ i +"].Name");
				privacyRuleInfo.AlgImpl = _ctx.StringValue("ListPrivacyRule.Data.PageData["+ i +"].AlgImpl");

				data_pageData.Add(privacyRuleInfo);
			}
			data.PageData = data_pageData;
			listPrivacyRuleResponse.Data = data;
        
			return listPrivacyRuleResponse;
        }
    }
}
