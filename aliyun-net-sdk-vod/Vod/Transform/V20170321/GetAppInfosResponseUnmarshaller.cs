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
    public class GetAppInfosResponseUnmarshaller
    {
        public static GetAppInfosResponse Unmarshall(UnmarshallerContext context)
        {
			GetAppInfosResponse getAppInfosResponse = new GetAppInfosResponse();

			getAppInfosResponse.HttpResponse = context.HttpResponse;
			getAppInfosResponse.RequestId = context.StringValue("GetAppInfos.RequestId");

			List<string> getAppInfosResponse_nonExistAppIds = new List<string>();
			for (int i = 0; i < context.Length("GetAppInfos.NonExistAppIds.Length"); i++) {
				getAppInfosResponse_nonExistAppIds.Add(context.StringValue("GetAppInfos.NonExistAppIds["+ i +"]"));
			}
			getAppInfosResponse.NonExistAppIds = getAppInfosResponse_nonExistAppIds;

			List<GetAppInfosResponse.GetAppInfos_AppInfo> getAppInfosResponse_appInfoList = new List<GetAppInfosResponse.GetAppInfos_AppInfo>();
			for (int i = 0; i < context.Length("GetAppInfos.AppInfoList.Length"); i++) {
				GetAppInfosResponse.GetAppInfos_AppInfo appInfo = new GetAppInfosResponse.GetAppInfos_AppInfo();
				appInfo.AppId = context.StringValue("GetAppInfos.AppInfoList["+ i +"].AppId");
				appInfo.AppName = context.StringValue("GetAppInfos.AppInfoList["+ i +"].AppName");
				appInfo.Type = context.StringValue("GetAppInfos.AppInfoList["+ i +"].Type");
				appInfo.Description = context.StringValue("GetAppInfos.AppInfoList["+ i +"].Description");
				appInfo.Status = context.StringValue("GetAppInfos.AppInfoList["+ i +"].Status");
				appInfo.CreationTime = context.StringValue("GetAppInfos.AppInfoList["+ i +"].CreationTime");
				appInfo.ModificationTime = context.StringValue("GetAppInfos.AppInfoList["+ i +"].ModificationTime");

				getAppInfosResponse_appInfoList.Add(appInfo);
			}
			getAppInfosResponse.AppInfoList = getAppInfosResponse_appInfoList;
        
			return getAppInfosResponse;
        }
    }
}
