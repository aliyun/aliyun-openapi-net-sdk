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
        public static ListAppInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAppInfoResponse listAppInfoResponse = new ListAppInfoResponse();

			listAppInfoResponse.HttpResponse = _ctx.HttpResponse;
			listAppInfoResponse.Total = _ctx.IntegerValue("ListAppInfo.Total");
			listAppInfoResponse.RequestId = _ctx.StringValue("ListAppInfo.RequestId");

			List<ListAppInfoResponse.ListAppInfo_AppInfo> listAppInfoResponse_appInfoList = new List<ListAppInfoResponse.ListAppInfo_AppInfo>();
			for (int i = 0; i < _ctx.Length("ListAppInfo.AppInfoList.Length"); i++) {
				ListAppInfoResponse.ListAppInfo_AppInfo appInfo = new ListAppInfoResponse.ListAppInfo_AppInfo();
				appInfo.Type = _ctx.StringValue("ListAppInfo.AppInfoList["+ i +"].Type");
				appInfo.Status = _ctx.StringValue("ListAppInfo.AppInfoList["+ i +"].Status");
				appInfo.CreationTime = _ctx.StringValue("ListAppInfo.AppInfoList["+ i +"].CreationTime");
				appInfo.AppName = _ctx.StringValue("ListAppInfo.AppInfoList["+ i +"].AppName");
				appInfo.Description = _ctx.StringValue("ListAppInfo.AppInfoList["+ i +"].Description");
				appInfo.AppId = _ctx.StringValue("ListAppInfo.AppInfoList["+ i +"].AppId");
				appInfo.ModificationTime = _ctx.StringValue("ListAppInfo.AppInfoList["+ i +"].ModificationTime");

				List<ListAppInfoResponse.ListAppInfo_AppInfo.ListAppInfo_TagsItem> appInfo_tags = new List<ListAppInfoResponse.ListAppInfo_AppInfo.ListAppInfo_TagsItem>();
				for (int j = 0; j < _ctx.Length("ListAppInfo.AppInfoList["+ i +"].Tags.Length"); j++) {
					ListAppInfoResponse.ListAppInfo_AppInfo.ListAppInfo_TagsItem tagsItem = new ListAppInfoResponse.ListAppInfo_AppInfo.ListAppInfo_TagsItem();
					tagsItem.TagKey = _ctx.StringValue("ListAppInfo.AppInfoList["+ i +"].Tags["+ j +"].TagKey");
					tagsItem.TagValue = _ctx.StringValue("ListAppInfo.AppInfoList["+ i +"].Tags["+ j +"].TagValue");

					appInfo_tags.Add(tagsItem);
				}
				appInfo.Tags = appInfo_tags;

				listAppInfoResponse_appInfoList.Add(appInfo);
			}
			listAppInfoResponse.AppInfoList = listAppInfoResponse_appInfoList;
        
			return listAppInfoResponse;
        }
    }
}
