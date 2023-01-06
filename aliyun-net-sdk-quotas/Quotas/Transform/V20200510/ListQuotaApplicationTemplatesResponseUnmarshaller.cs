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
using Aliyun.Acs.quotas.Model.V20200510;

namespace Aliyun.Acs.quotas.Transform.V20200510
{
    public class ListQuotaApplicationTemplatesResponseUnmarshaller
    {
        public static ListQuotaApplicationTemplatesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListQuotaApplicationTemplatesResponse listQuotaApplicationTemplatesResponse = new ListQuotaApplicationTemplatesResponse();

			listQuotaApplicationTemplatesResponse.HttpResponse = _ctx.HttpResponse;
			listQuotaApplicationTemplatesResponse.RequestId = _ctx.StringValue("ListQuotaApplicationTemplates.RequestId");
			listQuotaApplicationTemplatesResponse.MaxResults = _ctx.IntegerValue("ListQuotaApplicationTemplates.MaxResults");
			listQuotaApplicationTemplatesResponse.NextToken = _ctx.StringValue("ListQuotaApplicationTemplates.NextToken");
			listQuotaApplicationTemplatesResponse.TotalCount = _ctx.IntegerValue("ListQuotaApplicationTemplates.TotalCount");

			List<ListQuotaApplicationTemplatesResponse.ListQuotaApplicationTemplates_QuotaApplicationTemplatesItem> listQuotaApplicationTemplatesResponse_quotaApplicationTemplates = new List<ListQuotaApplicationTemplatesResponse.ListQuotaApplicationTemplates_QuotaApplicationTemplatesItem>();
			for (int i = 0; i < _ctx.Length("ListQuotaApplicationTemplates.QuotaApplicationTemplates.Length"); i++) {
				ListQuotaApplicationTemplatesResponse.ListQuotaApplicationTemplates_QuotaApplicationTemplatesItem quotaApplicationTemplatesItem = new ListQuotaApplicationTemplatesResponse.ListQuotaApplicationTemplates_QuotaApplicationTemplatesItem();
				quotaApplicationTemplatesItem.Id = _ctx.StringValue("ListQuotaApplicationTemplates.QuotaApplicationTemplates["+ i +"].Id");
				quotaApplicationTemplatesItem.ProductCode = _ctx.StringValue("ListQuotaApplicationTemplates.QuotaApplicationTemplates["+ i +"].ProductCode");
				quotaApplicationTemplatesItem.Dimensions = _ctx.StringValue("ListQuotaApplicationTemplates.QuotaApplicationTemplates["+ i +"].Dimensions");
				quotaApplicationTemplatesItem.DesireValue = _ctx.FloatValue("ListQuotaApplicationTemplates.QuotaApplicationTemplates["+ i +"].DesireValue");
				quotaApplicationTemplatesItem.NoticeType = _ctx.IntegerValue("ListQuotaApplicationTemplates.QuotaApplicationTemplates["+ i +"].NoticeType");
				quotaApplicationTemplatesItem.QuotaActionCode = _ctx.StringValue("ListQuotaApplicationTemplates.QuotaApplicationTemplates["+ i +"].QuotaActionCode");
				quotaApplicationTemplatesItem.ApplicableType = _ctx.StringValue("ListQuotaApplicationTemplates.QuotaApplicationTemplates["+ i +"].ApplicableType");
				quotaApplicationTemplatesItem.EnvLanguage = _ctx.StringValue("ListQuotaApplicationTemplates.QuotaApplicationTemplates["+ i +"].EnvLanguage");
				quotaApplicationTemplatesItem.QuotaName = _ctx.StringValue("ListQuotaApplicationTemplates.QuotaApplicationTemplates["+ i +"].QuotaName");
				quotaApplicationTemplatesItem.QuotaDescription = _ctx.StringValue("ListQuotaApplicationTemplates.QuotaApplicationTemplates["+ i +"].QuotaDescription");
				quotaApplicationTemplatesItem.EffectiveTime = _ctx.StringValue("ListQuotaApplicationTemplates.QuotaApplicationTemplates["+ i +"].EffectiveTime");
				quotaApplicationTemplatesItem.ExpireTime = _ctx.StringValue("ListQuotaApplicationTemplates.QuotaApplicationTemplates["+ i +"].ExpireTime");
				quotaApplicationTemplatesItem.QuotaCategory = _ctx.StringValue("ListQuotaApplicationTemplates.QuotaApplicationTemplates["+ i +"].QuotaCategory");

				List<string> quotaApplicationTemplatesItem_applicableRange = new List<string>();
				for (int j = 0; j < _ctx.Length("ListQuotaApplicationTemplates.QuotaApplicationTemplates["+ i +"].ApplicableRange.Length"); j++) {
					quotaApplicationTemplatesItem_applicableRange.Add(_ctx.StringValue("ListQuotaApplicationTemplates.QuotaApplicationTemplates["+ i +"].ApplicableRange["+ j +"]"));
				}
				quotaApplicationTemplatesItem.ApplicableRange = quotaApplicationTemplatesItem_applicableRange;

				listQuotaApplicationTemplatesResponse_quotaApplicationTemplates.Add(quotaApplicationTemplatesItem);
			}
			listQuotaApplicationTemplatesResponse.QuotaApplicationTemplates = listQuotaApplicationTemplatesResponse_quotaApplicationTemplates;
        
			return listQuotaApplicationTemplatesResponse;
        }
    }
}
