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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Push.Model.V20160801;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Push.Transform.V20160801
{
    public class ListAppsResponseUnmarshaller
    {
        public static ListAppsResponse Unmarshall(UnmarshallerContext context)
        {
			ListAppsResponse listAppsResponse = new ListAppsResponse();

			listAppsResponse.HttpResponse = context.HttpResponse;
			listAppsResponse.RequestId = context.StringValue("ListApps.RequestId");

			List<ListAppsResponse.AppInfo> appInfos = new List<ListAppsResponse.AppInfo>();
			for (int i = 0; i < context.Length("ListApps.AppInfos.Length"); i++) {
				ListAppsResponse.AppInfo appInfo = new ListAppsResponse.AppInfo();
				appInfo.AppId = context.StringValue("ListApps.AppInfos["+ i +"].AppId");
				appInfo.AppKey = context.LongValue("ListApps.AppInfos["+ i +"].AppKey");
				appInfo.AppName = context.StringValue("ListApps.AppInfos["+ i +"].AppName");
				appInfo.Description = context.StringValue("ListApps.AppInfos["+ i +"].Description");
				appInfo.IndustryId = context.IntegerValue("ListApps.AppInfos["+ i +"].IndustryId");
				appInfo.AndroidStatus = context.IntegerValue("ListApps.AppInfos["+ i +"].AndroidStatus");
				appInfo.IOSStatus = context.IntegerValue("ListApps.AppInfos["+ i +"].IOSStatus");
				appInfo.DeviceCount = context.LongValue("ListApps.AppInfos["+ i +"].DeviceCount");
				appInfo.AppStatus = context.IntegerValue("ListApps.AppInfos["+ i +"].AppStatus");
				appInfo.Status = context.IntegerValue("ListApps.AppInfos["+ i +"].Status");
				appInfo.PushAppId = context.StringValue("ListApps.AppInfos["+ i +"].PushAppId");
				appInfo.Source = context.StringValue("ListApps.AppInfos["+ i +"].Source");

				ListAppsResponse.AppInfo.Extension_ extension = new ListAppsResponse.AppInfo.Extension_();
				extension.XmAppSecretKey = context.StringValue("ListApps.AppInfos["+ i +"].Extension.XmAppSecretKey");
				extension.HwAppKey = context.LongValue("ListApps.AppInfos["+ i +"].Extension.HwAppKey");
				extension.HwAppSecretKey = context.StringValue("ListApps.AppInfos["+ i +"].Extension.HwAppSecretKey");
				appInfo.Extension = extension;

				appInfos.Add(appInfo);
			}
			listAppsResponse.AppInfos = appInfos;
        
			return listAppsResponse;
        }
    }
}