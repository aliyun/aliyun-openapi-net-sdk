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
using Aliyun.Acs.CloudPhoto.Model.V20170711;

namespace Aliyun.Acs.CloudPhoto.Transform.V20170711
{
    public class ListEventsResponseUnmarshaller
    {
        public static ListEventsResponse Unmarshall(UnmarshallerContext context)
        {
			ListEventsResponse listEventsResponse = new ListEventsResponse();

			listEventsResponse.HttpResponse = context.HttpResponse;
			listEventsResponse.Code = context.StringValue("ListEvents.Code");
			listEventsResponse.Message = context.StringValue("ListEvents.Message");
			listEventsResponse.NextCursor = context.StringValue("ListEvents.NextCursor");
			listEventsResponse.TotalCount = context.IntegerValue("ListEvents.TotalCount");
			listEventsResponse.RequestId = context.StringValue("ListEvents.RequestId");
			listEventsResponse.Action = context.StringValue("ListEvents.Action");

			List<ListEventsResponse.ListEvents__Event> listEventsResponse_events = new List<ListEventsResponse.ListEvents__Event>();
			for (int i = 0; i < context.Length("ListEvents.Events.Length"); i++) {
				ListEventsResponse.ListEvents__Event _event = new ListEventsResponse.ListEvents__Event();
				_event.Id = context.LongValue("ListEvents.Events["+ i +"].Id");
				_event.IdStr = context.StringValue("ListEvents.Events["+ i +"].IdStr");
				_event.Title = context.StringValue("ListEvents.Events["+ i +"].Title");
				_event.BannerPhotoId = context.StringValue("ListEvents.Events["+ i +"].BannerPhotoId");
				_event.Identity = context.StringValue("ListEvents.Events["+ i +"].Identity");
				_event.SplashPhotoId = context.StringValue("ListEvents.Events["+ i +"].SplashPhotoId");
				_event.State = context.StringValue("ListEvents.Events["+ i +"].State");
				_event.WeixinTitle = context.StringValue("ListEvents.Events["+ i +"].WeixinTitle");
				_event.WatermarkPhotoId = context.StringValue("ListEvents.Events["+ i +"].WatermarkPhotoId");
				_event.StartAt = context.LongValue("ListEvents.Events["+ i +"].StartAt");
				_event.EndAt = context.LongValue("ListEvents.Events["+ i +"].EndAt");
				_event.Ctime = context.LongValue("ListEvents.Events["+ i +"].Ctime");
				_event.Mtime = context.LongValue("ListEvents.Events["+ i +"].Mtime");
				_event.ViewsCount = context.LongValue("ListEvents.Events["+ i +"].ViewsCount");
				_event.LibraryId = context.StringValue("ListEvents.Events["+ i +"].LibraryId");
				_event.IdStr1 = context.StringValue("ListEvents.Events["+ i +"].IdStr");

				listEventsResponse_events.Add(_event);
			}
			listEventsResponse.Events = listEventsResponse_events;
        
			return listEventsResponse;
        }
    }
}
