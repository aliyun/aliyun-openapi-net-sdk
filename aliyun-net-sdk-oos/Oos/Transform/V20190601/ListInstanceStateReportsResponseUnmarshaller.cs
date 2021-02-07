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
using Aliyun.Acs.oos.Model.V20190601;

namespace Aliyun.Acs.oos.Transform.V20190601
{
    public class ListInstanceStateReportsResponseUnmarshaller
    {
        public static ListInstanceStateReportsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListInstanceStateReportsResponse listInstanceStateReportsResponse = new ListInstanceStateReportsResponse();

			listInstanceStateReportsResponse.HttpResponse = _ctx.HttpResponse;
			listInstanceStateReportsResponse.RequestId = _ctx.StringValue("ListInstanceStateReports.RequestId");
			listInstanceStateReportsResponse.MaxResults = _ctx.IntegerValue("ListInstanceStateReports.MaxResults");
			listInstanceStateReportsResponse.NextToken = _ctx.StringValue("ListInstanceStateReports.NextToken");

			List<ListInstanceStateReportsResponse.ListInstanceStateReports_StateReport> listInstanceStateReportsResponse_stateReports = new List<ListInstanceStateReportsResponse.ListInstanceStateReports_StateReport>();
			for (int i = 0; i < _ctx.Length("ListInstanceStateReports.StateReports.Length"); i++) {
				ListInstanceStateReportsResponse.ListInstanceStateReports_StateReport stateReport = new ListInstanceStateReportsResponse.ListInstanceStateReports_StateReport();
				stateReport.ReportTime = _ctx.StringValue("ListInstanceStateReports.StateReports["+ i +"].ReportTime");
				stateReport.InstanceId = _ctx.StringValue("ListInstanceStateReports.StateReports["+ i +"].InstanceId");
				stateReport.StateConfigurationId = _ctx.StringValue("ListInstanceStateReports.StateReports["+ i +"].StateConfigurationId");
				stateReport.Mode = _ctx.StringValue("ListInstanceStateReports.StateReports["+ i +"].Mode");
				stateReport.ReportStatus = _ctx.StringValue("ListInstanceStateReports.StateReports["+ i +"].ReportStatus");
				stateReport.SuccessApplyTime = _ctx.StringValue("ListInstanceStateReports.StateReports["+ i +"].SuccessApplyTime");
				stateReport.ReportInfo = _ctx.StringValue("ListInstanceStateReports.StateReports["+ i +"].ReportInfo");

				listInstanceStateReportsResponse_stateReports.Add(stateReport);
			}
			listInstanceStateReportsResponse.StateReports = listInstanceStateReportsResponse_stateReports;
        
			return listInstanceStateReportsResponse;
        }
    }
}
