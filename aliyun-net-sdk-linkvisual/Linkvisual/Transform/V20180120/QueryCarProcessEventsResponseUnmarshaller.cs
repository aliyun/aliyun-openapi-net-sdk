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
    public class QueryCarProcessEventsResponseUnmarshaller
    {
        public static QueryCarProcessEventsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryCarProcessEventsResponse queryCarProcessEventsResponse = new QueryCarProcessEventsResponse();

			queryCarProcessEventsResponse.HttpResponse = _ctx.HttpResponse;
			queryCarProcessEventsResponse.Code = _ctx.StringValue("QueryCarProcessEvents.Code");
			queryCarProcessEventsResponse.ErrorMessage = _ctx.StringValue("QueryCarProcessEvents.ErrorMessage");
			queryCarProcessEventsResponse.RequestId = _ctx.StringValue("QueryCarProcessEvents.RequestId");
			queryCarProcessEventsResponse.Success = _ctx.BooleanValue("QueryCarProcessEvents.Success");

			QueryCarProcessEventsResponse.QueryCarProcessEvents_Data data = new QueryCarProcessEventsResponse.QueryCarProcessEvents_Data();
			data.CurrentPage = _ctx.IntegerValue("QueryCarProcessEvents.Data.CurrentPage");
			data.PageSize = _ctx.IntegerValue("QueryCarProcessEvents.Data.PageSize");
			data.Total = _ctx.IntegerValue("QueryCarProcessEvents.Data.Total");
			data.PageCount = _ctx.IntegerValue("QueryCarProcessEvents.Data.PageCount");

			List<QueryCarProcessEventsResponse.QueryCarProcessEvents_Data.QueryCarProcessEvents_PageDataItem> data_pageData = new List<QueryCarProcessEventsResponse.QueryCarProcessEvents_Data.QueryCarProcessEvents_PageDataItem>();
			for (int i = 0; i < _ctx.Length("QueryCarProcessEvents.Data.PageData.Length"); i++) {
				QueryCarProcessEventsResponse.QueryCarProcessEvents_Data.QueryCarProcessEvents_PageDataItem pageDataItem = new QueryCarProcessEventsResponse.QueryCarProcessEvents_Data.QueryCarProcessEvents_PageDataItem();
				pageDataItem.EventPicUrl = _ctx.StringValue("QueryCarProcessEvents.Data.PageData["+ i +"].EventPicUrl");
				pageDataItem.EventTime = _ctx.LongValue("QueryCarProcessEvents.Data.PageData["+ i +"].EventTime");
				pageDataItem.ActionType = _ctx.IntegerValue("QueryCarProcessEvents.Data.PageData["+ i +"].ActionType");
				pageDataItem.Confidence = _ctx.IntegerValue("QueryCarProcessEvents.Data.PageData["+ i +"].Confidence");
				pageDataItem.SubProductKey = _ctx.StringValue("QueryCarProcessEvents.Data.PageData["+ i +"].SubProductKey");
				pageDataItem.EventId = _ctx.StringValue("QueryCarProcessEvents.Data.PageData["+ i +"].EventId");
				pageDataItem.SubIotId = _ctx.StringValue("QueryCarProcessEvents.Data.PageData["+ i +"].SubIotId");
				pageDataItem.AreaIndex = _ctx.IntegerValue("QueryCarProcessEvents.Data.PageData["+ i +"].AreaIndex");
				pageDataItem.EventType = _ctx.IntegerValue("QueryCarProcessEvents.Data.PageData["+ i +"].EventType");
				pageDataItem.EventPicId = _ctx.StringValue("QueryCarProcessEvents.Data.PageData["+ i +"].EventPicId");
				pageDataItem.TaskId = _ctx.StringValue("QueryCarProcessEvents.Data.PageData["+ i +"].TaskId");
				pageDataItem.SubDeviceName = _ctx.StringValue("QueryCarProcessEvents.Data.PageData["+ i +"].SubDeviceName");
				pageDataItem.IotId = _ctx.StringValue("QueryCarProcessEvents.Data.PageData["+ i +"].IotId");
				pageDataItem.SubDeviceNickName = _ctx.StringValue("QueryCarProcessEvents.Data.PageData["+ i +"].SubDeviceNickName");
				pageDataItem.PlateNo = _ctx.StringValue("QueryCarProcessEvents.Data.PageData["+ i +"].PlateNo");

				data_pageData.Add(pageDataItem);
			}
			data.PageData = data_pageData;
			queryCarProcessEventsResponse.Data = data;
        
			return queryCarProcessEventsResponse;
        }
    }
}
