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
    public class QueryEventRecordPlanDeviceByDeviceResponseUnmarshaller
    {
        public static QueryEventRecordPlanDeviceByDeviceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryEventRecordPlanDeviceByDeviceResponse queryEventRecordPlanDeviceByDeviceResponse = new QueryEventRecordPlanDeviceByDeviceResponse();

			queryEventRecordPlanDeviceByDeviceResponse.HttpResponse = _ctx.HttpResponse;
			queryEventRecordPlanDeviceByDeviceResponse.Code = _ctx.StringValue("QueryEventRecordPlanDeviceByDevice.Code");
			queryEventRecordPlanDeviceByDeviceResponse.RequestId = _ctx.StringValue("QueryEventRecordPlanDeviceByDevice.RequestId");
			queryEventRecordPlanDeviceByDeviceResponse.ErrorMessage = _ctx.StringValue("QueryEventRecordPlanDeviceByDevice.ErrorMessage");
			queryEventRecordPlanDeviceByDeviceResponse.Success = _ctx.BooleanValue("QueryEventRecordPlanDeviceByDevice.Success");

			QueryEventRecordPlanDeviceByDeviceResponse.QueryEventRecordPlanDeviceByDevice_Data data = new QueryEventRecordPlanDeviceByDeviceResponse.QueryEventRecordPlanDeviceByDevice_Data();
			data.PreRecordDuration = _ctx.IntegerValue("QueryEventRecordPlanDeviceByDevice.Data.PreRecordDuration");
			data.Name = _ctx.StringValue("QueryEventRecordPlanDeviceByDevice.Data.Name");
			data.PlanId = _ctx.StringValue("QueryEventRecordPlanDeviceByDevice.Data.PlanId");
			data.TemplateId = _ctx.StringValue("QueryEventRecordPlanDeviceByDevice.Data.TemplateId");
			data.RecordDuration = _ctx.IntegerValue("QueryEventRecordPlanDeviceByDevice.Data.RecordDuration");

			QueryEventRecordPlanDeviceByDeviceResponse.QueryEventRecordPlanDeviceByDevice_Data.QueryEventRecordPlanDeviceByDevice_TemplateInfo templateInfo = new QueryEventRecordPlanDeviceByDeviceResponse.QueryEventRecordPlanDeviceByDevice_Data.QueryEventRecordPlanDeviceByDevice_TemplateInfo();
			templateInfo.AllDay = _ctx.IntegerValue("QueryEventRecordPlanDeviceByDevice.Data.TemplateInfo.AllDay");
			templateInfo._Default = _ctx.IntegerValue("QueryEventRecordPlanDeviceByDevice.Data.TemplateInfo.Default");
			templateInfo.Name = _ctx.StringValue("QueryEventRecordPlanDeviceByDevice.Data.TemplateInfo.Name");
			templateInfo.TemplateId = _ctx.StringValue("QueryEventRecordPlanDeviceByDevice.Data.TemplateInfo.TemplateId");

			List<QueryEventRecordPlanDeviceByDeviceResponse.QueryEventRecordPlanDeviceByDevice_Data.QueryEventRecordPlanDeviceByDevice_TemplateInfo.QueryEventRecordPlanDeviceByDevice_TimeSectionListItem> templateInfo_timeSectionList = new List<QueryEventRecordPlanDeviceByDeviceResponse.QueryEventRecordPlanDeviceByDevice_Data.QueryEventRecordPlanDeviceByDevice_TemplateInfo.QueryEventRecordPlanDeviceByDevice_TimeSectionListItem>();
			for (int i = 0; i < _ctx.Length("QueryEventRecordPlanDeviceByDevice.Data.TemplateInfo.TimeSectionList.Length"); i++) {
				QueryEventRecordPlanDeviceByDeviceResponse.QueryEventRecordPlanDeviceByDevice_Data.QueryEventRecordPlanDeviceByDevice_TemplateInfo.QueryEventRecordPlanDeviceByDevice_TimeSectionListItem timeSectionListItem = new QueryEventRecordPlanDeviceByDeviceResponse.QueryEventRecordPlanDeviceByDevice_Data.QueryEventRecordPlanDeviceByDevice_TemplateInfo.QueryEventRecordPlanDeviceByDevice_TimeSectionListItem();
				timeSectionListItem.End = _ctx.IntegerValue("QueryEventRecordPlanDeviceByDevice.Data.TemplateInfo.TimeSectionList["+ i +"].End");
				timeSectionListItem.DayOfWeek = _ctx.IntegerValue("QueryEventRecordPlanDeviceByDevice.Data.TemplateInfo.TimeSectionList["+ i +"].DayOfWeek");
				timeSectionListItem.Begin = _ctx.IntegerValue("QueryEventRecordPlanDeviceByDevice.Data.TemplateInfo.TimeSectionList["+ i +"].Begin");

				templateInfo_timeSectionList.Add(timeSectionListItem);
			}
			templateInfo.TimeSectionList = templateInfo_timeSectionList;
			data.TemplateInfo = templateInfo;
			queryEventRecordPlanDeviceByDeviceResponse.Data = data;
        
			return queryEventRecordPlanDeviceByDeviceResponse;
        }
    }
}
