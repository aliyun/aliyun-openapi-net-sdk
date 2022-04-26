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
using Aliyun.Acs.CCC.Model.V20200701;

namespace Aliyun.Acs.CCC.Transform.V20200701
{
    public class GetHistoricalCampaignReportResponseUnmarshaller
    {
        public static GetHistoricalCampaignReportResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetHistoricalCampaignReportResponse getHistoricalCampaignReportResponse = new GetHistoricalCampaignReportResponse();

			getHistoricalCampaignReportResponse.HttpResponse = _ctx.HttpResponse;
			getHistoricalCampaignReportResponse.Code = _ctx.StringValue("GetHistoricalCampaignReport.Code");
			getHistoricalCampaignReportResponse.HttpStatusCode = _ctx.IntegerValue("GetHistoricalCampaignReport.HttpStatusCode");
			getHistoricalCampaignReportResponse.Message = _ctx.StringValue("GetHistoricalCampaignReport.Message");
			getHistoricalCampaignReportResponse.RequestId = _ctx.StringValue("GetHistoricalCampaignReport.RequestId");

			GetHistoricalCampaignReportResponse.GetHistoricalCampaignReport_Data data = new GetHistoricalCampaignReportResponse.GetHistoricalCampaignReport_Data();
			data.CallsConnected = _ctx.LongValue("GetHistoricalCampaignReport.Data.CallsConnected");
			data.CallsDialed = _ctx.LongValue("GetHistoricalCampaignReport.Data.CallsDialed");
			data.CallsAbandoned = _ctx.LongValue("GetHistoricalCampaignReport.Data.CallsAbandoned");
			data.ConnectedRate = _ctx.FloatValue("GetHistoricalCampaignReport.Data.ConnectedRate");
			data.AbandonedRate = _ctx.FloatValue("GetHistoricalCampaignReport.Data.AbandonedRate");
			data.OccupancyRate = _ctx.FloatValue("GetHistoricalCampaignReport.Data.OccupancyRate");
			getHistoricalCampaignReportResponse.Data = data;
        
			return getHistoricalCampaignReportResponse;
        }
    }
}
