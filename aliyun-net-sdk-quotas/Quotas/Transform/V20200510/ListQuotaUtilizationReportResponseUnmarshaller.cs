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
    public class ListQuotaUtilizationReportResponseUnmarshaller
    {
        public static ListQuotaUtilizationReportResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListQuotaUtilizationReportResponse listQuotaUtilizationReportResponse = new ListQuotaUtilizationReportResponse();

			listQuotaUtilizationReportResponse.HttpResponse = _ctx.HttpResponse;
			listQuotaUtilizationReportResponse.Status = _ctx.StringValue("ListQuotaUtilizationReport.Status");
			listQuotaUtilizationReportResponse.TotalCount = _ctx.IntegerValue("ListQuotaUtilizationReport.TotalCount");
			listQuotaUtilizationReportResponse.Message = _ctx.StringValue("ListQuotaUtilizationReport.Message");
			listQuotaUtilizationReportResponse.NextToken = _ctx.StringValue("ListQuotaUtilizationReport.NextToken");
			listQuotaUtilizationReportResponse.RequestId = _ctx.StringValue("ListQuotaUtilizationReport.RequestId");
			listQuotaUtilizationReportResponse.GeneratedAt = _ctx.StringValue("ListQuotaUtilizationReport.GeneratedAt");
			listQuotaUtilizationReportResponse.ErrorMsg = _ctx.StringValue("ListQuotaUtilizationReport.ErrorMsg");
			listQuotaUtilizationReportResponse.ErrorCode = _ctx.StringValue("ListQuotaUtilizationReport.ErrorCode");
			listQuotaUtilizationReportResponse.Success = _ctx.BooleanValue("ListQuotaUtilizationReport.Success");

			List<ListQuotaUtilizationReportResponse.ListQuotaUtilizationReport_QuotasItem> listQuotaUtilizationReportResponse_quotas = new List<ListQuotaUtilizationReportResponse.ListQuotaUtilizationReport_QuotasItem>();
			for (int i = 0; i < _ctx.Length("ListQuotaUtilizationReport.Quotas.Length"); i++) {
				ListQuotaUtilizationReportResponse.ListQuotaUtilizationReport_QuotasItem quotasItem = new ListQuotaUtilizationReportResponse.ListQuotaUtilizationReport_QuotasItem();
				quotasItem.QuotaDescription = _ctx.StringValue("ListQuotaUtilizationReport.Quotas["+ i +"].QuotaDescription");
				quotasItem.Consumable = _ctx.BooleanValue("ListQuotaUtilizationReport.Quotas["+ i +"].Consumable");
				quotasItem.UnadjustableDetail = _ctx.StringValue("ListQuotaUtilizationReport.Quotas["+ i +"].UnadjustableDetail");
				quotasItem.ProductCode = _ctx.StringValue("ListQuotaUtilizationReport.Quotas["+ i +"].ProductCode");
				quotasItem.TotalUsage = _ctx.DoubleValue("ListQuotaUtilizationReport.Quotas["+ i +"].TotalUsage");
				quotasItem.Dimensions = _ctx.StringValue("ListQuotaUtilizationReport.Quotas["+ i +"].Dimensions");
				quotasItem.UtilizationStatus = _ctx.StringValue("ListQuotaUtilizationReport.Quotas["+ i +"].UtilizationStatus");
				quotasItem.Adjustable = _ctx.BooleanValue("ListQuotaUtilizationReport.Quotas["+ i +"].Adjustable");
				quotasItem.QuotaActionCode = _ctx.StringValue("ListQuotaUtilizationReport.Quotas["+ i +"].QuotaActionCode");
				quotasItem.QuotaName = _ctx.StringValue("ListQuotaUtilizationReport.Quotas["+ i +"].QuotaName");
				quotasItem.Utilization = _ctx.DoubleValue("ListQuotaUtilizationReport.Quotas["+ i +"].Utilization");
				quotasItem.QuotaArn = _ctx.StringValue("ListQuotaUtilizationReport.Quotas["+ i +"].QuotaArn");
				quotasItem.TotalQuota = _ctx.DoubleValue("ListQuotaUtilizationReport.Quotas["+ i +"].TotalQuota");
				quotasItem.QuotaCategory = _ctx.StringValue("ListQuotaUtilizationReport.Quotas["+ i +"].QuotaCategory");

				ListQuotaUtilizationReportResponse.ListQuotaUtilizationReport_QuotasItem.ListQuotaUtilizationReport_UsageMetric usageMetric = new ListQuotaUtilizationReportResponse.ListQuotaUtilizationReport_QuotasItem.ListQuotaUtilizationReport_UsageMetric();
				usageMetric.MetricName = _ctx.StringValue("ListQuotaUtilizationReport.Quotas["+ i +"].UsageMetric.MetricName");
				usageMetric.MetricDimensions = _ctx.StringValue("ListQuotaUtilizationReport.Quotas["+ i +"].UsageMetric.MetricDimensions");
				usageMetric.MetricNamespace = _ctx.StringValue("ListQuotaUtilizationReport.Quotas["+ i +"].UsageMetric.MetricNamespace");
				quotasItem.UsageMetric = usageMetric;

				ListQuotaUtilizationReportResponse.ListQuotaUtilizationReport_QuotasItem.ListQuotaUtilizationReport_FlowControlAlgo flowControlAlgo = new ListQuotaUtilizationReportResponse.ListQuotaUtilizationReport_QuotasItem.ListQuotaUtilizationReport_FlowControlAlgo();
				flowControlAlgo.TotalQuota = _ctx.DoubleValue("ListQuotaUtilizationReport.Quotas["+ i +"].FlowControlAlgo.TotalQuota");
				flowControlAlgo.AlgoType = _ctx.StringValue("ListQuotaUtilizationReport.Quotas["+ i +"].FlowControlAlgo.AlgoType");
				flowControlAlgo.TokensPerRefill = _ctx.IntegerValue("ListQuotaUtilizationReport.Quotas["+ i +"].FlowControlAlgo.TokensPerRefill");
				flowControlAlgo.RefillInterval = _ctx.IntegerValue("ListQuotaUtilizationReport.Quotas["+ i +"].FlowControlAlgo.RefillInterval");

				ListQuotaUtilizationReportResponse.ListQuotaUtilizationReport_QuotasItem.ListQuotaUtilizationReport_FlowControlAlgo.ListQuotaUtilizationReport_Period period = new ListQuotaUtilizationReportResponse.ListQuotaUtilizationReport_QuotasItem.ListQuotaUtilizationReport_FlowControlAlgo.ListQuotaUtilizationReport_Period();
				period.PeriodValue = _ctx.IntegerValue("ListQuotaUtilizationReport.Quotas["+ i +"].FlowControlAlgo.Period.PeriodValue");
				period.PeriodUnit = _ctx.StringValue("ListQuotaUtilizationReport.Quotas["+ i +"].FlowControlAlgo.Period.PeriodUnit");
				flowControlAlgo.Period = period;
				quotasItem.FlowControlAlgo = flowControlAlgo;

				listQuotaUtilizationReportResponse_quotas.Add(quotasItem);
			}
			listQuotaUtilizationReportResponse.Quotas = listQuotaUtilizationReportResponse_quotas;
        
			return listQuotaUtilizationReportResponse;
        }
    }
}
