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
    public class GetInstanceTrendingReportResponseUnmarshaller
    {
        public static GetInstanceTrendingReportResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetInstanceTrendingReportResponse getInstanceTrendingReportResponse = new GetInstanceTrendingReportResponse();

			getInstanceTrendingReportResponse.HttpResponse = _ctx.HttpResponse;
			getInstanceTrendingReportResponse.Code = _ctx.StringValue("GetInstanceTrendingReport.Code");
			getInstanceTrendingReportResponse.HttpStatusCode = _ctx.IntegerValue("GetInstanceTrendingReport.HttpStatusCode");
			getInstanceTrendingReportResponse.Message = _ctx.StringValue("GetInstanceTrendingReport.Message");
			getInstanceTrendingReportResponse.RequestId = _ctx.StringValue("GetInstanceTrendingReport.RequestId");

			GetInstanceTrendingReportResponse.GetInstanceTrendingReport_Data data = new GetInstanceTrendingReportResponse.GetInstanceTrendingReport_Data();

			List<GetInstanceTrendingReportResponse.GetInstanceTrendingReport_Data.GetInstanceTrendingReport_InboundItem> data_inbound = new List<GetInstanceTrendingReportResponse.GetInstanceTrendingReport_Data.GetInstanceTrendingReport_InboundItem>();
			for (int i = 0; i < _ctx.Length("GetInstanceTrendingReport.Data.Inbound.Length"); i++) {
				GetInstanceTrendingReportResponse.GetInstanceTrendingReport_Data.GetInstanceTrendingReport_InboundItem inboundItem = new GetInstanceTrendingReportResponse.GetInstanceTrendingReport_Data.GetInstanceTrendingReport_InboundItem();
				inboundItem.CallsAbandonedInIVR = _ctx.LongValue("GetInstanceTrendingReport.Data.Inbound["+ i +"].CallsAbandonedInIVR");
				inboundItem.CallsAbandonedInQueue = _ctx.LongValue("GetInstanceTrendingReport.Data.Inbound["+ i +"].CallsAbandonedInQueue");
				inboundItem.CallsAbandonedInRinging = _ctx.LongValue("GetInstanceTrendingReport.Data.Inbound["+ i +"].CallsAbandonedInRinging");
				inboundItem.CallsHandled = _ctx.LongValue("GetInstanceTrendingReport.Data.Inbound["+ i +"].CallsHandled");
				inboundItem.CallsQueued = _ctx.LongValue("GetInstanceTrendingReport.Data.Inbound["+ i +"].CallsQueued");
				inboundItem.StatsTime = _ctx.LongValue("GetInstanceTrendingReport.Data.Inbound["+ i +"].StatsTime");
				inboundItem.TotalCalls = _ctx.LongValue("GetInstanceTrendingReport.Data.Inbound["+ i +"].TotalCalls");

				data_inbound.Add(inboundItem);
			}
			data.Inbound = data_inbound;

			List<GetInstanceTrendingReportResponse.GetInstanceTrendingReport_Data.GetInstanceTrendingReport_OutboundItem> data_outbound = new List<GetInstanceTrendingReportResponse.GetInstanceTrendingReport_Data.GetInstanceTrendingReport_OutboundItem>();
			for (int i = 0; i < _ctx.Length("GetInstanceTrendingReport.Data.Outbound.Length"); i++) {
				GetInstanceTrendingReportResponse.GetInstanceTrendingReport_Data.GetInstanceTrendingReport_OutboundItem outboundItem = new GetInstanceTrendingReportResponse.GetInstanceTrendingReport_Data.GetInstanceTrendingReport_OutboundItem();
				outboundItem.CallsAnswered = _ctx.LongValue("GetInstanceTrendingReport.Data.Outbound["+ i +"].CallsAnswered");
				outboundItem.StatsTime = _ctx.LongValue("GetInstanceTrendingReport.Data.Outbound["+ i +"].StatsTime");
				outboundItem.TotalCalls = _ctx.LongValue("GetInstanceTrendingReport.Data.Outbound["+ i +"].TotalCalls");

				data_outbound.Add(outboundItem);
			}
			data.Outbound = data_outbound;
			getInstanceTrendingReportResponse.Data = data;
        
			return getInstanceTrendingReportResponse;
        }
    }
}
