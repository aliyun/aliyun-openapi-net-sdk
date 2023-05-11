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
    public class QueryEventRecordPlanDetailResponseUnmarshaller
    {
        public static QueryEventRecordPlanDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryEventRecordPlanDetailResponse queryEventRecordPlanDetailResponse = new QueryEventRecordPlanDetailResponse();

			queryEventRecordPlanDetailResponse.HttpResponse = _ctx.HttpResponse;
			queryEventRecordPlanDetailResponse.Code = _ctx.StringValue("QueryEventRecordPlanDetail.Code");
			queryEventRecordPlanDetailResponse.RequestId = _ctx.StringValue("QueryEventRecordPlanDetail.RequestId");
			queryEventRecordPlanDetailResponse.ErrorMessage = _ctx.StringValue("QueryEventRecordPlanDetail.ErrorMessage");
			queryEventRecordPlanDetailResponse.Success = _ctx.BooleanValue("QueryEventRecordPlanDetail.Success");

			QueryEventRecordPlanDetailResponse.QueryEventRecordPlanDetail_Data data = new QueryEventRecordPlanDetailResponse.QueryEventRecordPlanDetail_Data();
			data.PreRecordDuration = _ctx.IntegerValue("QueryEventRecordPlanDetail.Data.PreRecordDuration");
			data.Name = _ctx.StringValue("QueryEventRecordPlanDetail.Data.Name");
			data.PlanId = _ctx.StringValue("QueryEventRecordPlanDetail.Data.PlanId");
			data.TemplateId = _ctx.StringValue("QueryEventRecordPlanDetail.Data.TemplateId");
			data.RecordDuration = _ctx.IntegerValue("QueryEventRecordPlanDetail.Data.RecordDuration");

			QueryEventRecordPlanDetailResponse.QueryEventRecordPlanDetail_Data.QueryEventRecordPlanDetail_TemplateInfo templateInfo = new QueryEventRecordPlanDetailResponse.QueryEventRecordPlanDetail_Data.QueryEventRecordPlanDetail_TemplateInfo();
			templateInfo.AllDay = _ctx.IntegerValue("QueryEventRecordPlanDetail.Data.TemplateInfo.AllDay");
			templateInfo._Default = _ctx.IntegerValue("QueryEventRecordPlanDetail.Data.TemplateInfo.Default");
			templateInfo.Name = _ctx.StringValue("QueryEventRecordPlanDetail.Data.TemplateInfo.Name");
			templateInfo.TemplateId = _ctx.StringValue("QueryEventRecordPlanDetail.Data.TemplateInfo.TemplateId");

			List<QueryEventRecordPlanDetailResponse.QueryEventRecordPlanDetail_Data.QueryEventRecordPlanDetail_TemplateInfo.QueryEventRecordPlanDetail_TimeSectionListItem> templateInfo_timeSectionList = new List<QueryEventRecordPlanDetailResponse.QueryEventRecordPlanDetail_Data.QueryEventRecordPlanDetail_TemplateInfo.QueryEventRecordPlanDetail_TimeSectionListItem>();
			for (int i = 0; i < _ctx.Length("QueryEventRecordPlanDetail.Data.TemplateInfo.TimeSectionList.Length"); i++) {
				QueryEventRecordPlanDetailResponse.QueryEventRecordPlanDetail_Data.QueryEventRecordPlanDetail_TemplateInfo.QueryEventRecordPlanDetail_TimeSectionListItem timeSectionListItem = new QueryEventRecordPlanDetailResponse.QueryEventRecordPlanDetail_Data.QueryEventRecordPlanDetail_TemplateInfo.QueryEventRecordPlanDetail_TimeSectionListItem();
				timeSectionListItem.End = _ctx.IntegerValue("QueryEventRecordPlanDetail.Data.TemplateInfo.TimeSectionList["+ i +"].End");
				timeSectionListItem.DayOfWeek = _ctx.IntegerValue("QueryEventRecordPlanDetail.Data.TemplateInfo.TimeSectionList["+ i +"].DayOfWeek");
				timeSectionListItem.Begin = _ctx.IntegerValue("QueryEventRecordPlanDetail.Data.TemplateInfo.TimeSectionList["+ i +"].Begin");

				templateInfo_timeSectionList.Add(timeSectionListItem);
			}
			templateInfo.TimeSectionList = templateInfo_timeSectionList;
			data.TemplateInfo = templateInfo;
			queryEventRecordPlanDetailResponse.Data = data;
        
			return queryEventRecordPlanDetailResponse;
        }
    }
}
