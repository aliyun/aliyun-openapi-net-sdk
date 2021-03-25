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
using Aliyun.Acs.sae.Model.V20190506;

namespace Aliyun.Acs.sae.Transform.V20190506
{
    public class ListAppEventsResponseUnmarshaller
    {
        public static ListAppEventsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAppEventsResponse listAppEventsResponse = new ListAppEventsResponse();

			listAppEventsResponse.HttpResponse = _ctx.HttpResponse;
			listAppEventsResponse.RequestId = _ctx.StringValue("ListAppEvents.RequestId");
			listAppEventsResponse.Code = _ctx.StringValue("ListAppEvents.Code");
			listAppEventsResponse.Message = _ctx.StringValue("ListAppEvents.Message");
			listAppEventsResponse.Success = _ctx.BooleanValue("ListAppEvents.Success");
			listAppEventsResponse.ErrorCode = _ctx.StringValue("ListAppEvents.ErrorCode");

			ListAppEventsResponse.ListAppEvents_Data data = new ListAppEventsResponse.ListAppEvents_Data();
			data.CurrentPage = _ctx.IntegerValue("ListAppEvents.Data.CurrentPage");
			data.PageSize = _ctx.IntegerValue("ListAppEvents.Data.PageSize");
			data.TotalSize = _ctx.IntegerValue("ListAppEvents.Data.TotalSize");

			List<ListAppEventsResponse.ListAppEvents_Data.ListAppEvents_AppEventEntityItem> data_appEventEntity = new List<ListAppEventsResponse.ListAppEvents_Data.ListAppEvents_AppEventEntityItem>();
			for (int i = 0; i < _ctx.Length("ListAppEvents.Data.AppEventEntity.Length"); i++) {
				ListAppEventsResponse.ListAppEvents_Data.ListAppEvents_AppEventEntityItem appEventEntityItem = new ListAppEventsResponse.ListAppEvents_Data.ListAppEvents_AppEventEntityItem();
				appEventEntityItem.ObjectKind = _ctx.StringValue("ListAppEvents.Data.AppEventEntity["+ i +"].ObjectKind");
				appEventEntityItem.ObjectName = _ctx.StringValue("ListAppEvents.Data.AppEventEntity["+ i +"].ObjectName");
				appEventEntityItem.EventType = _ctx.StringValue("ListAppEvents.Data.AppEventEntity["+ i +"].EventType");
				appEventEntityItem.Message = _ctx.StringValue("ListAppEvents.Data.AppEventEntity["+ i +"].Message");
				appEventEntityItem.FirstTimestamp = _ctx.StringValue("ListAppEvents.Data.AppEventEntity["+ i +"].FirstTimestamp");
				appEventEntityItem.LastTimestamp = _ctx.StringValue("ListAppEvents.Data.AppEventEntity["+ i +"].LastTimestamp");
				appEventEntityItem.Reason = _ctx.StringValue("ListAppEvents.Data.AppEventEntity["+ i +"].Reason");

				data_appEventEntity.Add(appEventEntityItem);
			}
			data.AppEventEntity = data_appEventEntity;
			listAppEventsResponse.Data = data;
        
			return listAppEventsResponse;
        }
    }
}
