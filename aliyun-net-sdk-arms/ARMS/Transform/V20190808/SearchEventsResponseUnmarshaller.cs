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
using Aliyun.Acs.ARMS.Model.V20190808;

namespace Aliyun.Acs.ARMS.Transform.V20190808
{
    public class SearchEventsResponseUnmarshaller
    {
        public static SearchEventsResponse Unmarshall(UnmarshallerContext context)
        {
			SearchEventsResponse searchEventsResponse = new SearchEventsResponse();

			searchEventsResponse.HttpResponse = context.HttpResponse;
			searchEventsResponse.RequestId = context.StringValue("SearchEvents.RequestId");
			searchEventsResponse.IsTrigger = context.IntegerValue("SearchEvents.IsTrigger");

			SearchEventsResponse.SearchEvents_PageBean pageBean = new SearchEventsResponse.SearchEvents_PageBean();
			pageBean.TotalCount = context.IntegerValue("SearchEvents.PageBean.TotalCount");
			pageBean.PageNumber = context.IntegerValue("SearchEvents.PageBean.PageNumber");
			pageBean.PageSize = context.IntegerValue("SearchEvents.PageBean.PageSize");

			List<SearchEventsResponse.SearchEvents_PageBean.SearchEvents_EventItem> pageBean_event = new List<SearchEventsResponse.SearchEvents_PageBean.SearchEvents_EventItem>();
			for (int i = 0; i < context.Length("SearchEvents.PageBean.Event.Length"); i++) {
				SearchEventsResponse.SearchEvents_PageBean.SearchEvents_EventItem eventItem = new SearchEventsResponse.SearchEvents_PageBean.SearchEvents_EventItem();
				eventItem.Id = context.LongValue("SearchEvents.PageBean.Event["+ i +"].Id");
				eventItem.EventTime = context.LongValue("SearchEvents.PageBean.Event["+ i +"].EventTime");
				eventItem.AlertType = context.IntegerValue("SearchEvents.PageBean.Event["+ i +"].AlertType");
				eventItem.EventLevel = context.IntegerValue("SearchEvents.PageBean.Event["+ i +"].EventLevel");
				eventItem.Message = context.StringValue("SearchEvents.PageBean.Event["+ i +"].Message");
				eventItem.AlertId = context.LongValue("SearchEvents.PageBean.Event["+ i +"].AlertId");
				eventItem.AlertName = context.StringValue("SearchEvents.PageBean.Event["+ i +"].AlertName");
				eventItem.AlertRule = context.StringValue("SearchEvents.PageBean.Event["+ i +"].AlertRule");

				List<string> eventItem_links = new List<string>();
				for (int j = 0; j < context.Length("SearchEvents.PageBean.Event["+ i +"].Links.Length"); j++) {
					eventItem_links.Add(context.StringValue("SearchEvents.PageBean.Event["+ i +"].Links["+ j +"]"));
				}
				eventItem.Links = eventItem_links;

				pageBean_event.Add(eventItem);
			}
			pageBean._Event = pageBean_event;
			searchEventsResponse.PageBean = pageBean;
        
			return searchEventsResponse;
        }
    }
}
