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
    public class ListQuotaApplicationsForTemplateResponseUnmarshaller
    {
        public static ListQuotaApplicationsForTemplateResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListQuotaApplicationsForTemplateResponse listQuotaApplicationsForTemplateResponse = new ListQuotaApplicationsForTemplateResponse();

			listQuotaApplicationsForTemplateResponse.HttpResponse = _ctx.HttpResponse;
			listQuotaApplicationsForTemplateResponse.RequestId = _ctx.StringValue("ListQuotaApplicationsForTemplate.RequestId");
			listQuotaApplicationsForTemplateResponse.NextToken = _ctx.StringValue("ListQuotaApplicationsForTemplate.NextToken");
			listQuotaApplicationsForTemplateResponse.TotalCount = _ctx.IntegerValue("ListQuotaApplicationsForTemplate.TotalCount");
			listQuotaApplicationsForTemplateResponse.MaxResults = _ctx.IntegerValue("ListQuotaApplicationsForTemplate.MaxResults");

			List<ListQuotaApplicationsForTemplateResponse.ListQuotaApplicationsForTemplate_QuotaBatchApplicationsItem> listQuotaApplicationsForTemplateResponse_quotaBatchApplications = new List<ListQuotaApplicationsForTemplateResponse.ListQuotaApplicationsForTemplate_QuotaBatchApplicationsItem>();
			for (int i = 0; i < _ctx.Length("ListQuotaApplicationsForTemplate.QuotaBatchApplications.Length"); i++) {
				ListQuotaApplicationsForTemplateResponse.ListQuotaApplicationsForTemplate_QuotaBatchApplicationsItem quotaBatchApplicationsItem = new ListQuotaApplicationsForTemplateResponse.ListQuotaApplicationsForTemplate_QuotaBatchApplicationsItem();
				quotaBatchApplicationsItem.ProductCode = _ctx.StringValue("ListQuotaApplicationsForTemplate.QuotaBatchApplications["+ i +"].ProductCode");
				quotaBatchApplicationsItem.QuotaActionCode = _ctx.StringValue("ListQuotaApplicationsForTemplate.QuotaBatchApplications["+ i +"].QuotaActionCode");
				quotaBatchApplicationsItem.BatchQuotaApplicationId = _ctx.StringValue("ListQuotaApplicationsForTemplate.QuotaBatchApplications["+ i +"].BatchQuotaApplicationId");
				quotaBatchApplicationsItem.EffectiveTime = _ctx.StringValue("ListQuotaApplicationsForTemplate.QuotaBatchApplications["+ i +"].EffectiveTime");
				quotaBatchApplicationsItem.ExpireTime = _ctx.StringValue("ListQuotaApplicationsForTemplate.QuotaBatchApplications["+ i +"].ExpireTime");
				quotaBatchApplicationsItem.ApplyTime = _ctx.StringValue("ListQuotaApplicationsForTemplate.QuotaBatchApplications["+ i +"].ApplyTime");
				quotaBatchApplicationsItem.DesireValue = _ctx.DoubleValue("ListQuotaApplicationsForTemplate.QuotaBatchApplications["+ i +"].DesireValue");
				quotaBatchApplicationsItem.QuotaCategory = _ctx.StringValue("ListQuotaApplicationsForTemplate.QuotaBatchApplications["+ i +"].QuotaCategory");
				quotaBatchApplicationsItem.Dimensions = _ctx.StringValue("ListQuotaApplicationsForTemplate.QuotaBatchApplications["+ i +"].Dimensions");
				quotaBatchApplicationsItem.Reason = _ctx.StringValue("ListQuotaApplicationsForTemplate.QuotaBatchApplications["+ i +"].Reason");

				List<string> quotaBatchApplicationsItem_aliyunUids = new List<string>();
				for (int j = 0; j < _ctx.Length("ListQuotaApplicationsForTemplate.QuotaBatchApplications["+ i +"].AliyunUids.Length"); j++) {
					quotaBatchApplicationsItem_aliyunUids.Add(_ctx.StringValue("ListQuotaApplicationsForTemplate.QuotaBatchApplications["+ i +"].AliyunUids["+ j +"]"));
				}
				quotaBatchApplicationsItem.AliyunUids = quotaBatchApplicationsItem_aliyunUids;

				List<ListQuotaApplicationsForTemplateResponse.ListQuotaApplicationsForTemplate_QuotaBatchApplicationsItem.ListQuotaApplicationsForTemplate_AuditStatusVo> quotaBatchApplicationsItem_auditStatusVos = new List<ListQuotaApplicationsForTemplateResponse.ListQuotaApplicationsForTemplate_QuotaBatchApplicationsItem.ListQuotaApplicationsForTemplate_AuditStatusVo>();
				for (int j = 0; j < _ctx.Length("ListQuotaApplicationsForTemplate.QuotaBatchApplications["+ i +"].AuditStatusVos.Length"); j++) {
					ListQuotaApplicationsForTemplateResponse.ListQuotaApplicationsForTemplate_QuotaBatchApplicationsItem.ListQuotaApplicationsForTemplate_AuditStatusVo auditStatusVo = new ListQuotaApplicationsForTemplateResponse.ListQuotaApplicationsForTemplate_QuotaBatchApplicationsItem.ListQuotaApplicationsForTemplate_AuditStatusVo();
					auditStatusVo.Status = _ctx.StringValue("ListQuotaApplicationsForTemplate.QuotaBatchApplications["+ i +"].AuditStatusVos["+ j +"].Status");
					auditStatusVo.Count = _ctx.IntegerValue("ListQuotaApplicationsForTemplate.QuotaBatchApplications["+ i +"].AuditStatusVos["+ j +"].Count");

					quotaBatchApplicationsItem_auditStatusVos.Add(auditStatusVo);
				}
				quotaBatchApplicationsItem.AuditStatusVos = quotaBatchApplicationsItem_auditStatusVos;

				listQuotaApplicationsForTemplateResponse_quotaBatchApplications.Add(quotaBatchApplicationsItem);
			}
			listQuotaApplicationsForTemplateResponse.QuotaBatchApplications = listQuotaApplicationsForTemplateResponse_quotaBatchApplications;
        
			return listQuotaApplicationsForTemplateResponse;
        }
    }
}
