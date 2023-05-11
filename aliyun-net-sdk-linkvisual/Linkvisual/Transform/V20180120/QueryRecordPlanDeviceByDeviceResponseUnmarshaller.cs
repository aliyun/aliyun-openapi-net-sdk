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
    public class QueryRecordPlanDeviceByDeviceResponseUnmarshaller
    {
        public static QueryRecordPlanDeviceByDeviceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryRecordPlanDeviceByDeviceResponse queryRecordPlanDeviceByDeviceResponse = new QueryRecordPlanDeviceByDeviceResponse();

			queryRecordPlanDeviceByDeviceResponse.HttpResponse = _ctx.HttpResponse;
			queryRecordPlanDeviceByDeviceResponse.Code = _ctx.StringValue("QueryRecordPlanDeviceByDevice.Code");
			queryRecordPlanDeviceByDeviceResponse.RequestId = _ctx.StringValue("QueryRecordPlanDeviceByDevice.RequestId");
			queryRecordPlanDeviceByDeviceResponse.ErrorMessage = _ctx.StringValue("QueryRecordPlanDeviceByDevice.ErrorMessage");
			queryRecordPlanDeviceByDeviceResponse.Success = _ctx.BooleanValue("QueryRecordPlanDeviceByDevice.Success");

			QueryRecordPlanDeviceByDeviceResponse.QueryRecordPlanDeviceByDevice_Data data = new QueryRecordPlanDeviceByDeviceResponse.QueryRecordPlanDeviceByDevice_Data();
			data.PlanId = _ctx.StringValue("QueryRecordPlanDeviceByDevice.Data.PlanId");
			data.Name = _ctx.StringValue("QueryRecordPlanDeviceByDevice.Data.Name");
			data.TemplateId = _ctx.StringValue("QueryRecordPlanDeviceByDevice.Data.TemplateId");

			QueryRecordPlanDeviceByDeviceResponse.QueryRecordPlanDeviceByDevice_Data.QueryRecordPlanDeviceByDevice_TemplateInfo templateInfo = new QueryRecordPlanDeviceByDeviceResponse.QueryRecordPlanDeviceByDevice_Data.QueryRecordPlanDeviceByDevice_TemplateInfo();
			templateInfo.AllDay = _ctx.IntegerValue("QueryRecordPlanDeviceByDevice.Data.TemplateInfo.AllDay");
			templateInfo._Default = _ctx.IntegerValue("QueryRecordPlanDeviceByDevice.Data.TemplateInfo.Default");
			templateInfo.Name = _ctx.StringValue("QueryRecordPlanDeviceByDevice.Data.TemplateInfo.Name");
			templateInfo.TemplateId = _ctx.StringValue("QueryRecordPlanDeviceByDevice.Data.TemplateInfo.TemplateId");

			List<QueryRecordPlanDeviceByDeviceResponse.QueryRecordPlanDeviceByDevice_Data.QueryRecordPlanDeviceByDevice_TemplateInfo.QueryRecordPlanDeviceByDevice_TimeSectionListItem> templateInfo_timeSectionList = new List<QueryRecordPlanDeviceByDeviceResponse.QueryRecordPlanDeviceByDevice_Data.QueryRecordPlanDeviceByDevice_TemplateInfo.QueryRecordPlanDeviceByDevice_TimeSectionListItem>();
			for (int i = 0; i < _ctx.Length("QueryRecordPlanDeviceByDevice.Data.TemplateInfo.TimeSectionList.Length"); i++) {
				QueryRecordPlanDeviceByDeviceResponse.QueryRecordPlanDeviceByDevice_Data.QueryRecordPlanDeviceByDevice_TemplateInfo.QueryRecordPlanDeviceByDevice_TimeSectionListItem timeSectionListItem = new QueryRecordPlanDeviceByDeviceResponse.QueryRecordPlanDeviceByDevice_Data.QueryRecordPlanDeviceByDevice_TemplateInfo.QueryRecordPlanDeviceByDevice_TimeSectionListItem();
				timeSectionListItem.End = _ctx.IntegerValue("QueryRecordPlanDeviceByDevice.Data.TemplateInfo.TimeSectionList["+ i +"].End");
				timeSectionListItem.DayOfWeek = _ctx.IntegerValue("QueryRecordPlanDeviceByDevice.Data.TemplateInfo.TimeSectionList["+ i +"].DayOfWeek");
				timeSectionListItem.Begin = _ctx.IntegerValue("QueryRecordPlanDeviceByDevice.Data.TemplateInfo.TimeSectionList["+ i +"].Begin");

				templateInfo_timeSectionList.Add(timeSectionListItem);
			}
			templateInfo.TimeSectionList = templateInfo_timeSectionList;
			data.TemplateInfo = templateInfo;
			queryRecordPlanDeviceByDeviceResponse.Data = data;
        
			return queryRecordPlanDeviceByDeviceResponse;
        }
    }
}
