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
using Aliyun.Acs.PTS.Model.V20201020;

namespace Aliyun.Acs.PTS.Transform.V20201020
{
    public class GetPtsReportsBySceneIdResponseUnmarshaller
    {
        public static GetPtsReportsBySceneIdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetPtsReportsBySceneIdResponse getPtsReportsBySceneIdResponse = new GetPtsReportsBySceneIdResponse();

			getPtsReportsBySceneIdResponse.HttpResponse = _ctx.HttpResponse;
			getPtsReportsBySceneIdResponse.Message = _ctx.StringValue("GetPtsReportsBySceneId.Message");
			getPtsReportsBySceneIdResponse.RequestId = _ctx.StringValue("GetPtsReportsBySceneId.RequestId");
			getPtsReportsBySceneIdResponse.HttpStatusCode = _ctx.IntegerValue("GetPtsReportsBySceneId.HttpStatusCode");
			getPtsReportsBySceneIdResponse.Code = _ctx.StringValue("GetPtsReportsBySceneId.Code");
			getPtsReportsBySceneIdResponse.Success = _ctx.BooleanValue("GetPtsReportsBySceneId.Success");

			List<GetPtsReportsBySceneIdResponse.GetPtsReportsBySceneId_ReportOverView> getPtsReportsBySceneIdResponse_reportOverViewList = new List<GetPtsReportsBySceneIdResponse.GetPtsReportsBySceneId_ReportOverView>();
			for (int i = 0; i < _ctx.Length("GetPtsReportsBySceneId.ReportOverViewList.Length"); i++) {
				GetPtsReportsBySceneIdResponse.GetPtsReportsBySceneId_ReportOverView reportOverView = new GetPtsReportsBySceneIdResponse.GetPtsReportsBySceneId_ReportOverView();
				reportOverView.ReportName = _ctx.StringValue("GetPtsReportsBySceneId.ReportOverViewList["+ i +"].ReportName");
				reportOverView.EndTime = _ctx.StringValue("GetPtsReportsBySceneId.ReportOverViewList["+ i +"].EndTime");
				reportOverView.StartTime = _ctx.StringValue("GetPtsReportsBySceneId.ReportOverViewList["+ i +"].StartTime");
				reportOverView.AgentCount = _ctx.IntegerValue("GetPtsReportsBySceneId.ReportOverViewList["+ i +"].AgentCount");
				reportOverView.ReportId = _ctx.StringValue("GetPtsReportsBySceneId.ReportOverViewList["+ i +"].ReportId");
				reportOverView.Vum = _ctx.LongValue("GetPtsReportsBySceneId.ReportOverViewList["+ i +"].Vum");

				getPtsReportsBySceneIdResponse_reportOverViewList.Add(reportOverView);
			}
			getPtsReportsBySceneIdResponse.ReportOverViewList = getPtsReportsBySceneIdResponse_reportOverViewList;
        
			return getPtsReportsBySceneIdResponse;
        }
    }
}
