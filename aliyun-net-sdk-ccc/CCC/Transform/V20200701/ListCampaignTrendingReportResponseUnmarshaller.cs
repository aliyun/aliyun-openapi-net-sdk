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
    public class ListCampaignTrendingReportResponseUnmarshaller
    {
        public static ListCampaignTrendingReportResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListCampaignTrendingReportResponse listCampaignTrendingReportResponse = new ListCampaignTrendingReportResponse();

			listCampaignTrendingReportResponse.HttpResponse = _ctx.HttpResponse;
			listCampaignTrendingReportResponse.Code = _ctx.StringValue("ListCampaignTrendingReport.Code");
			listCampaignTrendingReportResponse.HttpStatusCode = _ctx.IntegerValue("ListCampaignTrendingReport.HttpStatusCode");
			listCampaignTrendingReportResponse.Message = _ctx.StringValue("ListCampaignTrendingReport.Message");
			listCampaignTrendingReportResponse.RequestId = _ctx.StringValue("ListCampaignTrendingReport.RequestId");

			List<ListCampaignTrendingReportResponse.ListCampaignTrendingReport_TrendingList> listCampaignTrendingReportResponse_data = new List<ListCampaignTrendingReportResponse.ListCampaignTrendingReport_TrendingList>();
			for (int i = 0; i < _ctx.Length("ListCampaignTrendingReport.Data.Length"); i++) {
				ListCampaignTrendingReportResponse.ListCampaignTrendingReport_TrendingList trendingList = new ListCampaignTrendingReportResponse.ListCampaignTrendingReport_TrendingList();
				trendingList.Datetime = _ctx.LongValue("ListCampaignTrendingReport.Data["+ i +"].Datetime");
				trendingList.Concurrency = _ctx.LongValue("ListCampaignTrendingReport.Data["+ i +"].Concurrency");
				trendingList.TalkAgents = _ctx.LongValue("ListCampaignTrendingReport.Data["+ i +"].TalkAgents");
				trendingList.ReadyAgents = _ctx.LongValue("ListCampaignTrendingReport.Data["+ i +"].ReadyAgents");
				trendingList.WorkAgents = _ctx.LongValue("ListCampaignTrendingReport.Data["+ i +"].WorkAgents");
				trendingList.LoggedInAgents = _ctx.LongValue("ListCampaignTrendingReport.Data["+ i +"].LoggedInAgents");
				trendingList.BreakAgents = _ctx.LongValue("ListCampaignTrendingReport.Data["+ i +"].BreakAgents");

				listCampaignTrendingReportResponse_data.Add(trendingList);
			}
			listCampaignTrendingReportResponse.Data = listCampaignTrendingReportResponse_data;
        
			return listCampaignTrendingReportResponse;
        }
    }
}
