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
    public class GetQuotaApplicationResponseUnmarshaller
    {
        public static GetQuotaApplicationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetQuotaApplicationResponse getQuotaApplicationResponse = new GetQuotaApplicationResponse();

			getQuotaApplicationResponse.HttpResponse = _ctx.HttpResponse;
			getQuotaApplicationResponse.RequestId = _ctx.StringValue("GetQuotaApplication.RequestId");

			GetQuotaApplicationResponse.GetQuotaApplication_QuotaApplication quotaApplication = new GetQuotaApplicationResponse.GetQuotaApplication_QuotaApplication();
			quotaApplication.Status = _ctx.StringValue("GetQuotaApplication.QuotaApplication.Status");
			quotaApplication.ApplyTime = _ctx.StringValue("GetQuotaApplication.QuotaApplication.ApplyTime");
			quotaApplication.QuotaDescription = _ctx.StringValue("GetQuotaApplication.QuotaApplication.QuotaDescription");
			quotaApplication.EffectiveTime = _ctx.StringValue("GetQuotaApplication.QuotaApplication.EffectiveTime");
			quotaApplication.ProductCode = _ctx.StringValue("GetQuotaApplication.QuotaApplication.ProductCode");
			quotaApplication.QuotaUnit = _ctx.StringValue("GetQuotaApplication.QuotaApplication.QuotaUnit");
			quotaApplication.AuditReason = _ctx.StringValue("GetQuotaApplication.QuotaApplication.AuditReason");
			quotaApplication.Dimension = _ctx.StringValue("GetQuotaApplication.QuotaApplication.Dimension");
			quotaApplication.ApproveValue = _ctx.FloatValue("GetQuotaApplication.QuotaApplication.ApproveValue");
			quotaApplication.Reason = _ctx.StringValue("GetQuotaApplication.QuotaApplication.Reason");
			quotaApplication.QuotaActionCode = _ctx.StringValue("GetQuotaApplication.QuotaApplication.QuotaActionCode");
			quotaApplication.QuotaName = _ctx.StringValue("GetQuotaApplication.QuotaApplication.QuotaName");
			quotaApplication.QuotaArn = _ctx.StringValue("GetQuotaApplication.QuotaApplication.QuotaArn");
			quotaApplication.NoticeType = _ctx.LongValue("GetQuotaApplication.QuotaApplication.NoticeType");
			quotaApplication.ExpireTime = _ctx.StringValue("GetQuotaApplication.QuotaApplication.ExpireTime");
			quotaApplication.ApplicationId = _ctx.StringValue("GetQuotaApplication.QuotaApplication.ApplicationId");
			quotaApplication.DesireValue = _ctx.IntegerValue("GetQuotaApplication.QuotaApplication.DesireValue");
			getQuotaApplicationResponse.QuotaApplication = quotaApplication;
        
			return getQuotaApplicationResponse;
        }
    }
}
