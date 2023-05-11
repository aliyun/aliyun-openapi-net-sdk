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
    public class QueryTimeTemplateResponseUnmarshaller
    {
        public static QueryTimeTemplateResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryTimeTemplateResponse queryTimeTemplateResponse = new QueryTimeTemplateResponse();

			queryTimeTemplateResponse.HttpResponse = _ctx.HttpResponse;
			queryTimeTemplateResponse.Code = _ctx.StringValue("QueryTimeTemplate.Code");
			queryTimeTemplateResponse.RequestId = _ctx.StringValue("QueryTimeTemplate.RequestId");
			queryTimeTemplateResponse.ErrorMessage = _ctx.StringValue("QueryTimeTemplate.ErrorMessage");
			queryTimeTemplateResponse.Success = _ctx.BooleanValue("QueryTimeTemplate.Success");

			QueryTimeTemplateResponse.QueryTimeTemplate_Data data = new QueryTimeTemplateResponse.QueryTimeTemplate_Data();
			data.PageSize = _ctx.IntegerValue("QueryTimeTemplate.Data.PageSize");
			data.Total = _ctx.IntegerValue("QueryTimeTemplate.Data.Total");
			data.PageCount = _ctx.IntegerValue("QueryTimeTemplate.Data.PageCount");
			data.Page = _ctx.IntegerValue("QueryTimeTemplate.Data.Page");

			List<QueryTimeTemplateResponse.QueryTimeTemplate_Data.QueryTimeTemplate_ListItem> data_list = new List<QueryTimeTemplateResponse.QueryTimeTemplate_Data.QueryTimeTemplate_ListItem>();
			for (int i = 0; i < _ctx.Length("QueryTimeTemplate.Data.List.Length"); i++) {
				QueryTimeTemplateResponse.QueryTimeTemplate_Data.QueryTimeTemplate_ListItem listItem = new QueryTimeTemplateResponse.QueryTimeTemplate_Data.QueryTimeTemplate_ListItem();
				listItem.AllDay = _ctx.IntegerValue("QueryTimeTemplate.Data.List["+ i +"].AllDay");
				listItem._Default = _ctx.IntegerValue("QueryTimeTemplate.Data.List["+ i +"].Default");
				listItem.Name = _ctx.StringValue("QueryTimeTemplate.Data.List["+ i +"].Name");
				listItem.TemplateId = _ctx.StringValue("QueryTimeTemplate.Data.List["+ i +"].TemplateId");

				List<QueryTimeTemplateResponse.QueryTimeTemplate_Data.QueryTimeTemplate_ListItem.QueryTimeTemplate_TimeSectionListItem> listItem_timeSectionList = new List<QueryTimeTemplateResponse.QueryTimeTemplate_Data.QueryTimeTemplate_ListItem.QueryTimeTemplate_TimeSectionListItem>();
				for (int j = 0; j < _ctx.Length("QueryTimeTemplate.Data.List["+ i +"].TimeSectionList.Length"); j++) {
					QueryTimeTemplateResponse.QueryTimeTemplate_Data.QueryTimeTemplate_ListItem.QueryTimeTemplate_TimeSectionListItem timeSectionListItem = new QueryTimeTemplateResponse.QueryTimeTemplate_Data.QueryTimeTemplate_ListItem.QueryTimeTemplate_TimeSectionListItem();
					timeSectionListItem.End = _ctx.IntegerValue("QueryTimeTemplate.Data.List["+ i +"].TimeSectionList["+ j +"].End");
					timeSectionListItem.DayOfWeek = _ctx.IntegerValue("QueryTimeTemplate.Data.List["+ i +"].TimeSectionList["+ j +"].DayOfWeek");
					timeSectionListItem.Begin = _ctx.IntegerValue("QueryTimeTemplate.Data.List["+ i +"].TimeSectionList["+ j +"].Begin");

					listItem_timeSectionList.Add(timeSectionListItem);
				}
				listItem.TimeSectionList = listItem_timeSectionList;

				data_list.Add(listItem);
			}
			data.List = data_list;
			queryTimeTemplateResponse.Data = data;
        
			return queryTimeTemplateResponse;
        }
    }
}
