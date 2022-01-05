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
    public class GetHistoricalCallerReportResponseUnmarshaller
    {
        public static GetHistoricalCallerReportResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetHistoricalCallerReportResponse getHistoricalCallerReportResponse = new GetHistoricalCallerReportResponse();

			getHistoricalCallerReportResponse.HttpResponse = _ctx.HttpResponse;
			getHistoricalCallerReportResponse.Code = _ctx.StringValue("GetHistoricalCallerReport.Code");
			getHistoricalCallerReportResponse.HttpStatusCode = _ctx.IntegerValue("GetHistoricalCallerReport.HttpStatusCode");
			getHistoricalCallerReportResponse.Message = _ctx.StringValue("GetHistoricalCallerReport.Message");
			getHistoricalCallerReportResponse.RequestId = _ctx.StringValue("GetHistoricalCallerReport.RequestId");

			GetHistoricalCallerReportResponse.GetHistoricalCallerReport_Data data = new GetHistoricalCallerReportResponse.GetHistoricalCallerReport_Data();
			data.LastCallingTime = _ctx.LongValue("GetHistoricalCallerReport.Data.LastCallingTime");
			data.TotalCalls = _ctx.LongValue("GetHistoricalCallerReport.Data.TotalCalls");
			getHistoricalCallerReportResponse.Data = data;
        
			return getHistoricalCallerReportResponse;
        }
    }
}
