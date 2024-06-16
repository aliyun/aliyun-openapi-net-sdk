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
    public class ListQuotaApplicationsDetailForTemplateResponseUnmarshaller
    {
        public static ListQuotaApplicationsDetailForTemplateResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListQuotaApplicationsDetailForTemplateResponse listQuotaApplicationsDetailForTemplateResponse = new ListQuotaApplicationsDetailForTemplateResponse();

			listQuotaApplicationsDetailForTemplateResponse.HttpResponse = _ctx.HttpResponse;
			listQuotaApplicationsDetailForTemplateResponse.NextToken = _ctx.StringValue("ListQuotaApplicationsDetailForTemplate.NextToken");
			listQuotaApplicationsDetailForTemplateResponse.TotalCount = _ctx.IntegerValue("ListQuotaApplicationsDetailForTemplate.TotalCount");
			listQuotaApplicationsDetailForTemplateResponse.MaxResults = _ctx.IntegerValue("ListQuotaApplicationsDetailForTemplate.MaxResults");
			listQuotaApplicationsDetailForTemplateResponse.RequestId = _ctx.StringValue("ListQuotaApplicationsDetailForTemplate.RequestId");

			List<ListQuotaApplicationsDetailForTemplateResponse.ListQuotaApplicationsDetailForTemplate_QuotaBatchApplicationDetailVos> listQuotaApplicationsDetailForTemplateResponse_quotaApplications = new List<ListQuotaApplicationsDetailForTemplateResponse.ListQuotaApplicationsDetailForTemplate_QuotaBatchApplicationDetailVos>();
			for (int i = 0; i < _ctx.Length("ListQuotaApplicationsDetailForTemplate.QuotaApplications.Length"); i++) {
				ListQuotaApplicationsDetailForTemplateResponse.ListQuotaApplicationsDetailForTemplate_QuotaBatchApplicationDetailVos quotaBatchApplicationDetailVos = new ListQuotaApplicationsDetailForTemplateResponse.ListQuotaApplicationsDetailForTemplate_QuotaBatchApplicationDetailVos();
				quotaBatchApplicationDetailVos.BatchQuotaApplicationId = _ctx.StringValue("ListQuotaApplicationsDetailForTemplate.QuotaApplications["+ i +"].BatchQuotaApplicationId");
				quotaBatchApplicationDetailVos.ProductCode = _ctx.StringValue("ListQuotaApplicationsDetailForTemplate.QuotaApplications["+ i +"].ProductCode");
				quotaBatchApplicationDetailVos.QuotaActionCode = _ctx.StringValue("ListQuotaApplicationsDetailForTemplate.QuotaApplications["+ i +"].QuotaActionCode");
				quotaBatchApplicationDetailVos.QuotaName = _ctx.StringValue("ListQuotaApplicationsDetailForTemplate.QuotaApplications["+ i +"].QuotaName");
				quotaBatchApplicationDetailVos.QuotaDescription = _ctx.StringValue("ListQuotaApplicationsDetailForTemplate.QuotaApplications["+ i +"].QuotaDescription");
				quotaBatchApplicationDetailVos.QuotaUnit = _ctx.StringValue("ListQuotaApplicationsDetailForTemplate.QuotaApplications["+ i +"].QuotaUnit");
				quotaBatchApplicationDetailVos.QuotaArn = _ctx.StringValue("ListQuotaApplicationsDetailForTemplate.QuotaApplications["+ i +"].QuotaArn");
				quotaBatchApplicationDetailVos.QuotaDimension = _ctx.StringValue("ListQuotaApplicationsDetailForTemplate.QuotaApplications["+ i +"].QuotaDimension");
				quotaBatchApplicationDetailVos.ApplicationId = _ctx.StringValue("ListQuotaApplicationsDetailForTemplate.QuotaApplications["+ i +"].ApplicationId");
				quotaBatchApplicationDetailVos.DesireValue = _ctx.DoubleValue("ListQuotaApplicationsDetailForTemplate.QuotaApplications["+ i +"].DesireValue");
				quotaBatchApplicationDetailVos.Reason = _ctx.StringValue("ListQuotaApplicationsDetailForTemplate.QuotaApplications["+ i +"].Reason");
				quotaBatchApplicationDetailVos.Status = _ctx.StringValue("ListQuotaApplicationsDetailForTemplate.QuotaApplications["+ i +"].Status");
				quotaBatchApplicationDetailVos.ApproveValue = _ctx.DoubleValue("ListQuotaApplicationsDetailForTemplate.QuotaApplications["+ i +"].ApproveValue");
				quotaBatchApplicationDetailVos.EffectiveTime = _ctx.StringValue("ListQuotaApplicationsDetailForTemplate.QuotaApplications["+ i +"].EffectiveTime");
				quotaBatchApplicationDetailVos.ExpireTime = _ctx.StringValue("ListQuotaApplicationsDetailForTemplate.QuotaApplications["+ i +"].ExpireTime");
				quotaBatchApplicationDetailVos.ApplyTime = _ctx.StringValue("ListQuotaApplicationsDetailForTemplate.QuotaApplications["+ i +"].ApplyTime");
				quotaBatchApplicationDetailVos.AuditReason = _ctx.StringValue("ListQuotaApplicationsDetailForTemplate.QuotaApplications["+ i +"].AuditReason");
				quotaBatchApplicationDetailVos.NoticeType = _ctx.IntegerValue("ListQuotaApplicationsDetailForTemplate.QuotaApplications["+ i +"].NoticeType");
				quotaBatchApplicationDetailVos.AliyunUid = _ctx.StringValue("ListQuotaApplicationsDetailForTemplate.QuotaApplications["+ i +"].AliyunUid");
				quotaBatchApplicationDetailVos.QuotaCategory = _ctx.StringValue("ListQuotaApplicationsDetailForTemplate.QuotaApplications["+ i +"].QuotaCategory");
				quotaBatchApplicationDetailVos.EnvLanguage = _ctx.StringValue("ListQuotaApplicationsDetailForTemplate.QuotaApplications["+ i +"].EnvLanguage");

				ListQuotaApplicationsDetailForTemplateResponse.ListQuotaApplicationsDetailForTemplate_QuotaBatchApplicationDetailVos.ListQuotaApplicationsDetailForTemplate_Period period = new ListQuotaApplicationsDetailForTemplateResponse.ListQuotaApplicationsDetailForTemplate_QuotaBatchApplicationDetailVos.ListQuotaApplicationsDetailForTemplate_Period();
				period.PeriodUnit = _ctx.StringValue("ListQuotaApplicationsDetailForTemplate.QuotaApplications["+ i +"].Period.PeriodUnit");
				period.PeriodValue = _ctx.IntegerValue("ListQuotaApplicationsDetailForTemplate.QuotaApplications["+ i +"].Period.PeriodValue");
				quotaBatchApplicationDetailVos.Period = period;

				listQuotaApplicationsDetailForTemplateResponse_quotaApplications.Add(quotaBatchApplicationDetailVos);
			}
			listQuotaApplicationsDetailForTemplateResponse.QuotaApplications = listQuotaApplicationsDetailForTemplateResponse_quotaApplications;
        
			return listQuotaApplicationsDetailForTemplateResponse;
        }
    }
}
