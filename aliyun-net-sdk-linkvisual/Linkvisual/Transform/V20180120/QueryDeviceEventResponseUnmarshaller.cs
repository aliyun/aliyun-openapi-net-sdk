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
    public class QueryDeviceEventResponseUnmarshaller
    {
        public static QueryDeviceEventResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryDeviceEventResponse queryDeviceEventResponse = new QueryDeviceEventResponse();

			queryDeviceEventResponse.HttpResponse = _ctx.HttpResponse;
			queryDeviceEventResponse.Code = _ctx.StringValue("QueryDeviceEvent.Code");
			queryDeviceEventResponse.RequestId = _ctx.StringValue("QueryDeviceEvent.RequestId");
			queryDeviceEventResponse.ErrorMessage = _ctx.StringValue("QueryDeviceEvent.ErrorMessage");
			queryDeviceEventResponse.Success = _ctx.BooleanValue("QueryDeviceEvent.Success");

			QueryDeviceEventResponse.QueryDeviceEvent_Data data = new QueryDeviceEventResponse.QueryDeviceEvent_Data();
			data.PageSize = _ctx.IntegerValue("QueryDeviceEvent.Data.PageSize");
			data.PageCount = _ctx.IntegerValue("QueryDeviceEvent.Data.PageCount");
			data.Total = _ctx.IntegerValue("QueryDeviceEvent.Data.Total");
			data.Page = _ctx.IntegerValue("QueryDeviceEvent.Data.Page");

			List<QueryDeviceEventResponse.QueryDeviceEvent_Data.QueryDeviceEvent_ListItem> data_list = new List<QueryDeviceEventResponse.QueryDeviceEvent_Data.QueryDeviceEvent_ListItem>();
			for (int i = 0; i < _ctx.Length("QueryDeviceEvent.Data.List.Length"); i++) {
				QueryDeviceEventResponse.QueryDeviceEvent_Data.QueryDeviceEvent_ListItem listItem = new QueryDeviceEventResponse.QueryDeviceEvent_Data.QueryDeviceEvent_ListItem();
				listItem.EventId = _ctx.StringValue("QueryDeviceEvent.Data.List["+ i +"].EventId");
				listItem.EventTime = _ctx.StringValue("QueryDeviceEvent.Data.List["+ i +"].EventTime");
				listItem.EventType = _ctx.IntegerValue("QueryDeviceEvent.Data.List["+ i +"].EventType");
				listItem.EventPicId = _ctx.StringValue("QueryDeviceEvent.Data.List["+ i +"].EventPicId");
				listItem.EventDesc = _ctx.StringValue("QueryDeviceEvent.Data.List["+ i +"].EventDesc");
				listItem.EventData = _ctx.StringValue("QueryDeviceEvent.Data.List["+ i +"].EventData");

				data_list.Add(listItem);
			}
			data.List = data_list;
			queryDeviceEventResponse.Data = data;
        
			return queryDeviceEventResponse;
        }
    }
}
