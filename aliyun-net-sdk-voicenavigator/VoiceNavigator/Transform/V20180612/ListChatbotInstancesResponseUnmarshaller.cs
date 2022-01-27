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
using Aliyun.Acs.VoiceNavigator.Model.V20180612;

namespace Aliyun.Acs.VoiceNavigator.Transform.V20180612
{
    public class ListChatbotInstancesResponseUnmarshaller
    {
        public static ListChatbotInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListChatbotInstancesResponse listChatbotInstancesResponse = new ListChatbotInstancesResponse();

			listChatbotInstancesResponse.HttpResponse = _ctx.HttpResponse;
			listChatbotInstancesResponse.RequestId = _ctx.StringValue("ListChatbotInstances.RequestId");
			listChatbotInstancesResponse.PageNumber = _ctx.IntegerValue("ListChatbotInstances.PageNumber");
			listChatbotInstancesResponse.TotalCount = _ctx.LongValue("ListChatbotInstances.TotalCount");
			listChatbotInstancesResponse.PageSize = _ctx.LongValue("ListChatbotInstances.PageSize");

			List<ListChatbotInstancesResponse.ListChatbotInstances_Bot> listChatbotInstancesResponse_bots = new List<ListChatbotInstancesResponse.ListChatbotInstances_Bot>();
			for (int i = 0; i < _ctx.Length("ListChatbotInstances.Bots.Length"); i++) {
				ListChatbotInstancesResponse.ListChatbotInstances_Bot bot = new ListChatbotInstancesResponse.ListChatbotInstances_Bot();
				bot.InstanceId = _ctx.StringValue("ListChatbotInstances.Bots["+ i +"].InstanceId");
				bot.TimeZone = _ctx.StringValue("ListChatbotInstances.Bots["+ i +"].TimeZone");
				bot.Avatar = _ctx.StringValue("ListChatbotInstances.Bots["+ i +"].Avatar");
				bot.LanguageCode = _ctx.StringValue("ListChatbotInstances.Bots["+ i +"].LanguageCode");
				bot.Name = _ctx.StringValue("ListChatbotInstances.Bots["+ i +"].Name");
				bot.Introduction = _ctx.StringValue("ListChatbotInstances.Bots["+ i +"].Introduction");
				bot.CreateTime = _ctx.StringValue("ListChatbotInstances.Bots["+ i +"].CreateTime");

				listChatbotInstancesResponse_bots.Add(bot);
			}
			listChatbotInstancesResponse.Bots = listChatbotInstancesResponse_bots;
        
			return listChatbotInstancesResponse;
        }
    }
}
