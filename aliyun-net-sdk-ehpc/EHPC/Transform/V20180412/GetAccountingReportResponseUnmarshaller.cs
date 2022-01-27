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
using Aliyun.Acs.EHPC.Model.V20180412;

namespace Aliyun.Acs.EHPC.Transform.V20180412
{
    public class GetAccountingReportResponseUnmarshaller
    {
        public static GetAccountingReportResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetAccountingReportResponse getAccountingReportResponse = new GetAccountingReportResponse();

			getAccountingReportResponse.HttpResponse = _ctx.HttpResponse;
			getAccountingReportResponse.RequestId = _ctx.StringValue("GetAccountingReport.RequestId");
			getAccountingReportResponse.Metrics = _ctx.StringValue("GetAccountingReport.Metrics");
			getAccountingReportResponse.TotalCoreTime = _ctx.IntegerValue("GetAccountingReport.TotalCoreTime");
			getAccountingReportResponse.TotalCount = _ctx.IntegerValue("GetAccountingReport.TotalCount");
			getAccountingReportResponse.PageSize = _ctx.IntegerValue("GetAccountingReport.PageSize");
			getAccountingReportResponse.PageNumber = _ctx.IntegerValue("GetAccountingReport.PageNumber");

			List<string> getAccountingReportResponse_data = new List<string>();
			for (int i = 0; i < _ctx.Length("GetAccountingReport.Data.Length"); i++) {
				getAccountingReportResponse_data.Add(_ctx.StringValue("GetAccountingReport.Data["+ i +"]"));
			}
			getAccountingReportResponse.Data = getAccountingReportResponse_data;
        
			return getAccountingReportResponse;
        }
    }
}
