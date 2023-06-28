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
using Aliyun.Acs.Linkvisual.Model.V20180120;

namespace Aliyun.Acs.Linkvisual.Transform.V20180120
{
    public class QueryRecordPlanDetailResponseUnmarshaller
    {
        public static QueryRecordPlanDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryRecordPlanDetailResponse queryRecordPlanDetailResponse = new QueryRecordPlanDetailResponse();

			queryRecordPlanDetailResponse.HttpResponse = _ctx.HttpResponse;
			queryRecordPlanDetailResponse.Code = _ctx.StringValue("QueryRecordPlanDetail.Code");
			queryRecordPlanDetailResponse.RequestId = _ctx.StringValue("QueryRecordPlanDetail.RequestId");
			queryRecordPlanDetailResponse.ErrorMessage = _ctx.StringValue("QueryRecordPlanDetail.ErrorMessage");
			queryRecordPlanDetailResponse.Success = _ctx.BooleanValue("QueryRecordPlanDetail.Success");

			QueryRecordPlanDetailResponse.QueryRecordPlanDetail_Data data = new QueryRecordPlanDetailResponse.QueryRecordPlanDetail_Data();
			data.PlanId = _ctx.StringValue("QueryRecordPlanDetail.Data.PlanId");
			data.Name = _ctx.StringValue("QueryRecordPlanDetail.Data.Name");
			data.TemplateId = _ctx.StringValue("QueryRecordPlanDetail.Data.TemplateId");

			QueryRecordPlanDetailResponse.QueryRecordPlanDetail_Data.QueryRecordPlanDetail_TemplateInfo templateInfo = new QueryRecordPlanDetailResponse.QueryRecordPlanDetail_Data.QueryRecordPlanDetail_TemplateInfo();
			templateInfo.AllDay = _ctx.IntegerValue("QueryRecordPlanDetail.Data.TemplateInfo.AllDay");
			templateInfo._Default = _ctx.IntegerValue("QueryRecordPlanDetail.Data.TemplateInfo.Default");
			templateInfo.Name = _ctx.StringValue("QueryRecordPlanDetail.Data.TemplateInfo.Name");
			templateInfo.TemplateId = _ctx.StringValue("QueryRecordPlanDetail.Data.TemplateInfo.TemplateId");

			List<QueryRecordPlanDetailResponse.QueryRecordPlanDetail_Data.QueryRecordPlanDetail_TemplateInfo.QueryRecordPlanDetail_TimeSectionListItem> templateInfo_timeSectionList = new List<QueryRecordPlanDetailResponse.QueryRecordPlanDetail_Data.QueryRecordPlanDetail_TemplateInfo.QueryRecordPlanDetail_TimeSectionListItem>();
			for (int i = 0; i < _ctx.Length("QueryRecordPlanDetail.Data.TemplateInfo.TimeSectionList.Length"); i++) {
				QueryRecordPlanDetailResponse.QueryRecordPlanDetail_Data.QueryRecordPlanDetail_TemplateInfo.QueryRecordPlanDetail_TimeSectionListItem timeSectionListItem = new QueryRecordPlanDetailResponse.QueryRecordPlanDetail_Data.QueryRecordPlanDetail_TemplateInfo.QueryRecordPlanDetail_TimeSectionListItem();
				timeSectionListItem.End = _ctx.IntegerValue("QueryRecordPlanDetail.Data.TemplateInfo.TimeSectionList["+ i +"].End");
				timeSectionListItem.DayOfWeek = _ctx.IntegerValue("QueryRecordPlanDetail.Data.TemplateInfo.TimeSectionList["+ i +"].DayOfWeek");
				timeSectionListItem.Begin = _ctx.IntegerValue("QueryRecordPlanDetail.Data.TemplateInfo.TimeSectionList["+ i +"].Begin");

				templateInfo_timeSectionList.Add(timeSectionListItem);
			}
			templateInfo.TimeSectionList = templateInfo_timeSectionList;
			data.TemplateInfo = templateInfo;
			queryRecordPlanDetailResponse.Data = data;
        
			return queryRecordPlanDetailResponse;
        }
    }
}
