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
    public class QueryTimeTemplateDetailResponseUnmarshaller
    {
        public static QueryTimeTemplateDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryTimeTemplateDetailResponse queryTimeTemplateDetailResponse = new QueryTimeTemplateDetailResponse();

			queryTimeTemplateDetailResponse.HttpResponse = _ctx.HttpResponse;
			queryTimeTemplateDetailResponse.Code = _ctx.StringValue("QueryTimeTemplateDetail.Code");
			queryTimeTemplateDetailResponse.RequestId = _ctx.StringValue("QueryTimeTemplateDetail.RequestId");
			queryTimeTemplateDetailResponse.ErrorMessage = _ctx.StringValue("QueryTimeTemplateDetail.ErrorMessage");
			queryTimeTemplateDetailResponse.Success = _ctx.BooleanValue("QueryTimeTemplateDetail.Success");

			QueryTimeTemplateDetailResponse.QueryTimeTemplateDetail_Data data = new QueryTimeTemplateDetailResponse.QueryTimeTemplateDetail_Data();
			data.AllDay = _ctx.IntegerValue("QueryTimeTemplateDetail.Data.AllDay");
			data._Default = _ctx.IntegerValue("QueryTimeTemplateDetail.Data.Default");
			data.Name = _ctx.StringValue("QueryTimeTemplateDetail.Data.Name");
			data.TemplateId = _ctx.StringValue("QueryTimeTemplateDetail.Data.TemplateId");

			List<QueryTimeTemplateDetailResponse.QueryTimeTemplateDetail_Data.QueryTimeTemplateDetail_TimeSectionListItem> data_timeSectionList = new List<QueryTimeTemplateDetailResponse.QueryTimeTemplateDetail_Data.QueryTimeTemplateDetail_TimeSectionListItem>();
			for (int i = 0; i < _ctx.Length("QueryTimeTemplateDetail.Data.TimeSectionList.Length"); i++) {
				QueryTimeTemplateDetailResponse.QueryTimeTemplateDetail_Data.QueryTimeTemplateDetail_TimeSectionListItem timeSectionListItem = new QueryTimeTemplateDetailResponse.QueryTimeTemplateDetail_Data.QueryTimeTemplateDetail_TimeSectionListItem();
				timeSectionListItem.End = _ctx.IntegerValue("QueryTimeTemplateDetail.Data.TimeSectionList["+ i +"].End");
				timeSectionListItem.DayOfWeek = _ctx.IntegerValue("QueryTimeTemplateDetail.Data.TimeSectionList["+ i +"].DayOfWeek");
				timeSectionListItem.Begin = _ctx.IntegerValue("QueryTimeTemplateDetail.Data.TimeSectionList["+ i +"].Begin");

				data_timeSectionList.Add(timeSectionListItem);
			}
			data.TimeSectionList = data_timeSectionList;
			queryTimeTemplateDetailResponse.Data = data;
        
			return queryTimeTemplateDetailResponse;
        }
    }
}
