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
    public class ListMessageAppResponseUnmarshaller
    {
        public static ListMessageAppResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListMessageAppResponse listMessageAppResponse = new ListMessageAppResponse();

			listMessageAppResponse.HttpResponse = _ctx.HttpResponse;
			listMessageAppResponse.RequestId = _ctx.StringValue("ListMessageApp.RequestId");

			ListMessageAppResponse.ListMessageApp_Result result = new ListMessageAppResponse.ListMessageApp_Result();
			result.Total = _ctx.IntegerValue("ListMessageApp.Result.Total");
			result.HasMore = _ctx.BooleanValue("ListMessageApp.Result.HasMore");

			List<ListMessageAppResponse.ListMessageApp_Result.ListMessageApp_AppListItem> result_appList = new List<ListMessageAppResponse.ListMessageApp_Result.ListMessageApp_AppListItem>();
			for (int i = 0; i < _ctx.Length("ListMessageApp.Result.AppList.Length"); i++) {
				ListMessageAppResponse.ListMessageApp_Result.ListMessageApp_AppListItem appListItem = new ListMessageAppResponse.ListMessageApp_Result.ListMessageApp_AppListItem();
				appListItem.AppId = _ctx.StringValue("ListMessageApp.Result.AppList["+ i +"].AppId");
				appListItem.AppName = _ctx.StringValue("ListMessageApp.Result.AppList["+ i +"].AppName");
				appListItem.CreateTime = _ctx.LongValue("ListMessageApp.Result.AppList["+ i +"].CreateTime");
				appListItem.Status = _ctx.IntegerValue("ListMessageApp.Result.AppList["+ i +"].Status");
				appListItem.AppConfig = _ctx.StringValue("ListMessageApp.Result.AppList["+ i +"].AppConfig");
				appListItem.Extension = _ctx.StringValue("ListMessageApp.Result.AppList["+ i +"].Extension");

				result_appList.Add(appListItem);
			}
			result.AppList = result_appList;
			listMessageAppResponse.Result = result;
        
			return listMessageAppResponse;
        }
    }
}
