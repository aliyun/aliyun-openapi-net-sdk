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
    public class ListLiveMessageAppsResponseUnmarshaller
    {
        public static ListLiveMessageAppsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListLiveMessageAppsResponse listLiveMessageAppsResponse = new ListLiveMessageAppsResponse();

			listLiveMessageAppsResponse.HttpResponse = _ctx.HttpResponse;
			listLiveMessageAppsResponse.HasMore = _ctx.BooleanValue("ListLiveMessageApps.HasMore");
			listLiveMessageAppsResponse.NextPageToken = _ctx.LongValue("ListLiveMessageApps.NextPageToken");
			listLiveMessageAppsResponse.RequestId = _ctx.StringValue("ListLiveMessageApps.RequestId");

			List<ListLiveMessageAppsResponse.ListLiveMessageApps_Apps> listLiveMessageAppsResponse_appList = new List<ListLiveMessageAppsResponse.ListLiveMessageApps_Apps>();
			for (int i = 0; i < _ctx.Length("ListLiveMessageApps.AppList.Length"); i++) {
				ListLiveMessageAppsResponse.ListLiveMessageApps_Apps apps = new ListLiveMessageAppsResponse.ListLiveMessageApps_Apps();
				apps.AppId = _ctx.StringValue("ListLiveMessageApps.AppList["+ i +"].AppId");
				apps.AppKey = _ctx.StringValue("ListLiveMessageApps.AppList["+ i +"].AppKey");
				apps.AppName = _ctx.StringValue("ListLiveMessageApps.AppList["+ i +"].AppName");
				apps.AppSign = _ctx.StringValue("ListLiveMessageApps.AppList["+ i +"].AppSign");
				apps.CreateTime = _ctx.LongValue("ListLiveMessageApps.AppList["+ i +"].CreateTime");
				apps.DataCenter = _ctx.StringValue("ListLiveMessageApps.AppList["+ i +"].DataCenter");
				apps.Disable = _ctx.StringValue("ListLiveMessageApps.AppList["+ i +"].Disable");
				apps.ModifyTime = _ctx.LongValue("ListLiveMessageApps.AppList["+ i +"].ModifyTime");
				apps.MsgLifeCycle = _ctx.IntegerValue("ListLiveMessageApps.AppList["+ i +"].MsgLifeCycle");

				listLiveMessageAppsResponse_appList.Add(apps);
			}
			listLiveMessageAppsResponse.AppList = listLiveMessageAppsResponse_appList;
        
			return listLiveMessageAppsResponse;
        }
    }
}
