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
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class ListAppInfoResponseUnmarshaller
    {
        public static ListAppInfoResponse Unmarshall(UnmarshallerContext context)
        {
			ListAppInfoResponse listAppInfoResponse = new ListAppInfoResponse();

			listAppInfoResponse.HttpResponse = context.HttpResponse;
			listAppInfoResponse.RequestId = context.StringValue("ListAppInfo.RequestId");
			listAppInfoResponse.Total = context.IntegerValue("ListAppInfo.Total");

			List<ListAppInfoResponse.ListAppInfo_AppInfo> listAppInfoResponse_appInfoList = new List<ListAppInfoResponse.ListAppInfo_AppInfo>();
			for (int i = 0; i < context.Length("ListAppInfo.AppInfoList.Length"); i++) {
				ListAppInfoResponse.ListAppInfo_AppInfo appInfo = new ListAppInfoResponse.ListAppInfo_AppInfo();
				appInfo.AppId = context.StringValue("ListAppInfo.AppInfoList["+ i +"].AppId");
				appInfo.AppName = context.StringValue("ListAppInfo.AppInfoList["+ i +"].AppName");
				appInfo.Type = context.StringValue("ListAppInfo.AppInfoList["+ i +"].Type");
				appInfo.Description = context.StringValue("ListAppInfo.AppInfoList["+ i +"].Description");
				appInfo.Status = context.StringValue("ListAppInfo.AppInfoList["+ i +"].Status");
				appInfo.CreationTime = context.StringValue("ListAppInfo.AppInfoList["+ i +"].CreationTime");
				appInfo.ModificationTime = context.StringValue("ListAppInfo.AppInfoList["+ i +"].ModificationTime");

				listAppInfoResponse_appInfoList.Add(appInfo);
			}
			listAppInfoResponse.AppInfoList = listAppInfoResponse_appInfoList;
        
			return listAppInfoResponse;
        }
    }
}
