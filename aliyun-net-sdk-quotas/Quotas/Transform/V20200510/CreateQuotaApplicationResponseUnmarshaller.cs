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
    public class CreateQuotaApplicationResponseUnmarshaller
    {
        public static CreateQuotaApplicationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateQuotaApplicationResponse createQuotaApplicationResponse = new CreateQuotaApplicationResponse();

			createQuotaApplicationResponse.HttpResponse = _ctx.HttpResponse;
			createQuotaApplicationResponse.Status = _ctx.StringValue("CreateQuotaApplication.Status");
			createQuotaApplicationResponse.ApplyTime = _ctx.StringValue("CreateQuotaApplication.ApplyTime");
			createQuotaApplicationResponse.QuotaDescription = _ctx.StringValue("CreateQuotaApplication.QuotaDescription");
			createQuotaApplicationResponse.RequestId = _ctx.StringValue("CreateQuotaApplication.RequestId");
			createQuotaApplicationResponse.EffectiveTime = _ctx.StringValue("CreateQuotaApplication.EffectiveTime");
			createQuotaApplicationResponse.ProductCode = _ctx.StringValue("CreateQuotaApplication.ProductCode");
			createQuotaApplicationResponse.QuotaUnit = _ctx.StringValue("CreateQuotaApplication.QuotaUnit");
			createQuotaApplicationResponse.AuditReason = _ctx.StringValue("CreateQuotaApplication.AuditReason");
			createQuotaApplicationResponse.Dimension = _ctx.StringValue("CreateQuotaApplication.Dimension");
			createQuotaApplicationResponse.ApproveValue = _ctx.FloatValue("CreateQuotaApplication.ApproveValue");
			createQuotaApplicationResponse.Reason = _ctx.StringValue("CreateQuotaApplication.Reason");
			createQuotaApplicationResponse.QuotaActionCode = _ctx.StringValue("CreateQuotaApplication.QuotaActionCode");
			createQuotaApplicationResponse.QuotaName = _ctx.StringValue("CreateQuotaApplication.QuotaName");
			createQuotaApplicationResponse.QuotaArn = _ctx.StringValue("CreateQuotaApplication.QuotaArn");
			createQuotaApplicationResponse.NoticeType = _ctx.LongValue("CreateQuotaApplication.NoticeType");
			createQuotaApplicationResponse.ExpireTime = _ctx.StringValue("CreateQuotaApplication.ExpireTime");
			createQuotaApplicationResponse.ApplicationId = _ctx.StringValue("CreateQuotaApplication.ApplicationId");
			createQuotaApplicationResponse.DesireValue = _ctx.IntegerValue("CreateQuotaApplication.DesireValue");
        
			return createQuotaApplicationResponse;
        }
    }
}
