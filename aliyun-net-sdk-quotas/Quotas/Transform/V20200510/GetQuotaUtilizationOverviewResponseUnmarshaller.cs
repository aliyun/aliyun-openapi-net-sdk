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
    public class GetQuotaUtilizationOverviewResponseUnmarshaller
    {
        public static GetQuotaUtilizationOverviewResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetQuotaUtilizationOverviewResponse getQuotaUtilizationOverviewResponse = new GetQuotaUtilizationOverviewResponse();

			getQuotaUtilizationOverviewResponse.HttpResponse = _ctx.HttpResponse;
			getQuotaUtilizationOverviewResponse.Status = _ctx.StringValue("GetQuotaUtilizationOverview.Status");
			getQuotaUtilizationOverviewResponse.Message = _ctx.StringValue("GetQuotaUtilizationOverview.Message");
			getQuotaUtilizationOverviewResponse.RequestId = _ctx.StringValue("GetQuotaUtilizationOverview.RequestId");
			getQuotaUtilizationOverviewResponse.GeneratedAt = _ctx.StringValue("GetQuotaUtilizationOverview.GeneratedAt");
			getQuotaUtilizationOverviewResponse.ErrorMsg = _ctx.StringValue("GetQuotaUtilizationOverview.ErrorMsg");
			getQuotaUtilizationOverviewResponse.ErrorCode = _ctx.StringValue("GetQuotaUtilizationOverview.ErrorCode");
			getQuotaUtilizationOverviewResponse.Success = _ctx.BooleanValue("GetQuotaUtilizationOverview.Success");

			GetQuotaUtilizationOverviewResponse.GetQuotaUtilizationOverview_QuotaOverview quotaOverview = new GetQuotaUtilizationOverviewResponse.GetQuotaUtilizationOverview_QuotaOverview();

			GetQuotaUtilizationOverviewResponse.GetQuotaUtilizationOverview_QuotaOverview.GetQuotaUtilizationOverview_Over80Percent over80Percent = new GetQuotaUtilizationOverviewResponse.GetQuotaUtilizationOverview_QuotaOverview.GetQuotaUtilizationOverview_Over80Percent();
			over80Percent.Total = _ctx.LongValue("GetQuotaUtilizationOverview.QuotaOverview.Over80Percent.Total");
			over80Percent.AdjustableRatio = _ctx.DoubleValue("GetQuotaUtilizationOverview.QuotaOverview.Over80Percent.AdjustableRatio");
			over80Percent.Adjustable = _ctx.LongValue("GetQuotaUtilizationOverview.QuotaOverview.Over80Percent.Adjustable");
			quotaOverview.Over80Percent = over80Percent;

			GetQuotaUtilizationOverviewResponse.GetQuotaUtilizationOverview_QuotaOverview.GetQuotaUtilizationOverview_Over95Percent over95Percent = new GetQuotaUtilizationOverviewResponse.GetQuotaUtilizationOverview_QuotaOverview.GetQuotaUtilizationOverview_Over95Percent();
			over95Percent.Total = _ctx.LongValue("GetQuotaUtilizationOverview.QuotaOverview.Over95Percent.Total");
			over95Percent.AdjustableRatio = _ctx.DoubleValue("GetQuotaUtilizationOverview.QuotaOverview.Over95Percent.AdjustableRatio");
			over95Percent.Adjustable = _ctx.LongValue("GetQuotaUtilizationOverview.QuotaOverview.Over95Percent.Adjustable");
			quotaOverview.Over95Percent = over95Percent;

			GetQuotaUtilizationOverviewResponse.GetQuotaUtilizationOverview_QuotaOverview.GetQuotaUtilizationOverview_InUse inUse = new GetQuotaUtilizationOverviewResponse.GetQuotaUtilizationOverview_QuotaOverview.GetQuotaUtilizationOverview_InUse();
			inUse.Total = _ctx.LongValue("GetQuotaUtilizationOverview.QuotaOverview.InUse.Total");
			inUse.AdjustableRatio = _ctx.DoubleValue("GetQuotaUtilizationOverview.QuotaOverview.InUse.AdjustableRatio");
			inUse.Adjustable = _ctx.LongValue("GetQuotaUtilizationOverview.QuotaOverview.InUse.Adjustable");
			quotaOverview.InUse = inUse;
			getQuotaUtilizationOverviewResponse.QuotaOverview = quotaOverview;
        
			return getQuotaUtilizationOverviewResponse;
        }
    }
}
