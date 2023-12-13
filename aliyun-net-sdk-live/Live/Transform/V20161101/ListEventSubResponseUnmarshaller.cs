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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class ListEventSubResponseUnmarshaller
    {
        public static ListEventSubResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListEventSubResponse listEventSubResponse = new ListEventSubResponse();

			listEventSubResponse.HttpResponse = _ctx.HttpResponse;
			listEventSubResponse.RequestId = _ctx.StringValue("ListEventSub.RequestId");

			List<ListEventSubResponse.ListEventSub_Data> listEventSubResponse_subscribers = new List<ListEventSubResponse.ListEventSub_Data>();
			for (int i = 0; i < _ctx.Length("ListEventSub.Subscribers.Length"); i++) {
				ListEventSubResponse.ListEventSub_Data data = new ListEventSubResponse.ListEventSub_Data();
				data.SubId = _ctx.StringValue("ListEventSub.Subscribers["+ i +"].SubId");
				data.ChannelId = _ctx.StringValue("ListEventSub.Subscribers["+ i +"].ChannelId");
				data.CallbackUrl = _ctx.StringValue("ListEventSub.Subscribers["+ i +"].CallbackUrl");
				data.CreateTime = _ctx.StringValue("ListEventSub.Subscribers["+ i +"].CreateTime");
				data.ModifyTime = _ctx.StringValue("ListEventSub.Subscribers["+ i +"].ModifyTime");
				data.Roles = _ctx.IntegerValue("ListEventSub.Subscribers["+ i +"].Roles");

				List<string> data_events = new List<string>();
				for (int j = 0; j < _ctx.Length("ListEventSub.Subscribers["+ i +"].Events.Length"); j++) {
					data_events.Add(_ctx.StringValue("ListEventSub.Subscribers["+ i +"].Events["+ j +"]"));
				}
				data.Events = data_events;

				List<string> data_users = new List<string>();
				for (int j = 0; j < _ctx.Length("ListEventSub.Subscribers["+ i +"].Users.Length"); j++) {
					data_users.Add(_ctx.StringValue("ListEventSub.Subscribers["+ i +"].Users["+ j +"]"));
				}
				data.Users = data_users;

				listEventSubResponse_subscribers.Add(data);
			}
			listEventSubResponse.Subscribers = listEventSubResponse_subscribers;
        
			return listEventSubResponse;
        }
    }
}
