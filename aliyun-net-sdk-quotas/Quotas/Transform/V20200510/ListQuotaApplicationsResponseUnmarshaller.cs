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
    public class ListQuotaApplicationsResponseUnmarshaller
    {
        public static ListQuotaApplicationsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListQuotaApplicationsResponse listQuotaApplicationsResponse = new ListQuotaApplicationsResponse();

			listQuotaApplicationsResponse.HttpResponse = _ctx.HttpResponse;
			listQuotaApplicationsResponse.MaxResults = _ctx.IntegerValue("ListQuotaApplications.MaxResults");
			listQuotaApplicationsResponse.NextToken = _ctx.StringValue("ListQuotaApplications.NextToken");
			listQuotaApplicationsResponse.RequestId = _ctx.StringValue("ListQuotaApplications.RequestId");
			listQuotaApplicationsResponse.TotalCount = _ctx.IntegerValue("ListQuotaApplications.TotalCount");

			List<ListQuotaApplicationsResponse.ListQuotaApplications_QuotaApplicationsItem> listQuotaApplicationsResponse_quotaApplications = new List<ListQuotaApplicationsResponse.ListQuotaApplications_QuotaApplicationsItem>();
			for (int i = 0; i < _ctx.Length("ListQuotaApplications.QuotaApplications.Length"); i++) {
				ListQuotaApplicationsResponse.ListQuotaApplications_QuotaApplicationsItem quotaApplicationsItem = new ListQuotaApplicationsResponse.ListQuotaApplications_QuotaApplicationsItem();
				quotaApplicationsItem.ApplicationId = _ctx.StringValue("ListQuotaApplications.QuotaApplications["+ i +"].ApplicationId");
				quotaApplicationsItem.ApplyTime = _ctx.StringValue("ListQuotaApplications.QuotaApplications["+ i +"].ApplyTime");
				quotaApplicationsItem.ApproveValue = _ctx.FloatValue("ListQuotaApplications.QuotaApplications["+ i +"].ApproveValue");
				quotaApplicationsItem.AuditReason = _ctx.StringValue("ListQuotaApplications.QuotaApplications["+ i +"].AuditReason");
				quotaApplicationsItem.Comment = _ctx.StringValue("ListQuotaApplications.QuotaApplications["+ i +"].Comment");
				quotaApplicationsItem.DesireValue = _ctx.FloatValue("ListQuotaApplications.QuotaApplications["+ i +"].DesireValue");
				quotaApplicationsItem.Dimension = _ctx.StringValue("ListQuotaApplications.QuotaApplications["+ i +"].Dimension");
				quotaApplicationsItem.EffectiveTime = _ctx.StringValue("ListQuotaApplications.QuotaApplications["+ i +"].EffectiveTime");
				quotaApplicationsItem.ExpireTime = _ctx.StringValue("ListQuotaApplications.QuotaApplications["+ i +"].ExpireTime");
				quotaApplicationsItem.NoticeType = _ctx.IntegerValue("ListQuotaApplications.QuotaApplications["+ i +"].NoticeType");
				quotaApplicationsItem.ProductCode = _ctx.StringValue("ListQuotaApplications.QuotaApplications["+ i +"].ProductCode");
				quotaApplicationsItem.QuotaActionCode = _ctx.StringValue("ListQuotaApplications.QuotaApplications["+ i +"].QuotaActionCode");
				quotaApplicationsItem.QuotaArn = _ctx.StringValue("ListQuotaApplications.QuotaApplications["+ i +"].QuotaArn");
				quotaApplicationsItem.QuotaCategory = _ctx.StringValue("ListQuotaApplications.QuotaApplications["+ i +"].QuotaCategory");
				quotaApplicationsItem.QuotaDescription = _ctx.StringValue("ListQuotaApplications.QuotaApplications["+ i +"].QuotaDescription");
				quotaApplicationsItem.QuotaName = _ctx.StringValue("ListQuotaApplications.QuotaApplications["+ i +"].QuotaName");
				quotaApplicationsItem.QuotaUnit = _ctx.StringValue("ListQuotaApplications.QuotaApplications["+ i +"].QuotaUnit");
				quotaApplicationsItem.Reason = _ctx.StringValue("ListQuotaApplications.QuotaApplications["+ i +"].Reason");
				quotaApplicationsItem.Status = _ctx.StringValue("ListQuotaApplications.QuotaApplications["+ i +"].Status");

				ListQuotaApplicationsResponse.ListQuotaApplications_QuotaApplicationsItem.ListQuotaApplications_Period period = new ListQuotaApplicationsResponse.ListQuotaApplications_QuotaApplicationsItem.ListQuotaApplications_Period();
				period.PeriodUnit = _ctx.StringValue("ListQuotaApplications.QuotaApplications["+ i +"].Period.PeriodUnit");
				period.PeriodValue = _ctx.LongValue("ListQuotaApplications.QuotaApplications["+ i +"].Period.PeriodValue");
				quotaApplicationsItem.Period = period;

				listQuotaApplicationsResponse_quotaApplications.Add(quotaApplicationsItem);
			}
			listQuotaApplicationsResponse.QuotaApplications = listQuotaApplicationsResponse_quotaApplications;
        
			return listQuotaApplicationsResponse;
        }
    }
}
