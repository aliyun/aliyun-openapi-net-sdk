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
using Aliyun.Acs.adb.Model.V20211201;

namespace Aliyun.Acs.adb.Transform.V20211201
{
    public class ListSparkAppsResponseUnmarshaller
    {
        public static ListSparkAppsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSparkAppsResponse listSparkAppsResponse = new ListSparkAppsResponse();

			listSparkAppsResponse.HttpResponse = _ctx.HttpResponse;
			listSparkAppsResponse.PageNumber = _ctx.LongValue("ListSparkApps.PageNumber");
			listSparkAppsResponse.PageSize = _ctx.LongValue("ListSparkApps.PageSize");
			listSparkAppsResponse.TotalCount = _ctx.LongValue("ListSparkApps.TotalCount");
			listSparkAppsResponse.RequestId = _ctx.StringValue("ListSparkApps.RequestId");

			ListSparkAppsResponse.ListSparkApps_Data data = new ListSparkAppsResponse.ListSparkApps_Data();
			data.PageNumber = _ctx.LongValue("ListSparkApps.Data.PageNumber");
			data.PageSize = _ctx.LongValue("ListSparkApps.Data.PageSize");
			data.TotalCount = _ctx.LongValue("ListSparkApps.Data.TotalCount");

			List<ListSparkAppsResponse.ListSparkApps_Data.ListSparkApps_AppInfo> data_appInfoList = new List<ListSparkAppsResponse.ListSparkApps_Data.ListSparkApps_AppInfo>();
			for (int i = 0; i < _ctx.Length("ListSparkApps.Data.AppInfoList.Length"); i++) {
				ListSparkAppsResponse.ListSparkApps_Data.ListSparkApps_AppInfo appInfo = new ListSparkAppsResponse.ListSparkApps_Data.ListSparkApps_AppInfo();
				appInfo.AppId = _ctx.StringValue("ListSparkApps.Data.AppInfoList["+ i +"].AppId");
				appInfo.AppName = _ctx.StringValue("ListSparkApps.Data.AppInfoList["+ i +"].AppName");
				appInfo.State = _ctx.StringValue("ListSparkApps.Data.AppInfoList["+ i +"].State");
				appInfo.Message = _ctx.StringValue("ListSparkApps.Data.AppInfoList["+ i +"].Message");
				appInfo.DBClusterId = _ctx.StringValue("ListSparkApps.Data.AppInfoList["+ i +"].DBClusterId");

				ListSparkAppsResponse.ListSparkApps_Data.ListSparkApps_AppInfo.ListSparkApps_Detail detail = new ListSparkAppsResponse.ListSparkApps_Data.ListSparkApps_AppInfo.ListSparkApps_Detail();
				detail.Data = _ctx.StringValue("ListSparkApps.Data.AppInfoList["+ i +"].Detail.Data");
				detail.EstimateExecutionCpuTimeInSeconds = _ctx.LongValue("ListSparkApps.Data.AppInfoList["+ i +"].Detail.EstimateExecutionCpuTimeInSeconds");
				detail.LogRootPath = _ctx.StringValue("ListSparkApps.Data.AppInfoList["+ i +"].Detail.LogRootPath");
				detail.LastAttemptId = _ctx.StringValue("ListSparkApps.Data.AppInfoList["+ i +"].Detail.LastAttemptId");
				detail.WebUiAddress = _ctx.StringValue("ListSparkApps.Data.AppInfoList["+ i +"].Detail.WebUiAddress");
				detail.SubmittedTimeInMillis = _ctx.LongValue("ListSparkApps.Data.AppInfoList["+ i +"].Detail.SubmittedTimeInMillis");
				detail.StartedTimeInMillis = _ctx.LongValue("ListSparkApps.Data.AppInfoList["+ i +"].Detail.StartedTimeInMillis");
				detail.LastUpdatedTimeInMillis = _ctx.LongValue("ListSparkApps.Data.AppInfoList["+ i +"].Detail.LastUpdatedTimeInMillis");
				detail.TerminatedTimeInMillis = _ctx.LongValue("ListSparkApps.Data.AppInfoList["+ i +"].Detail.TerminatedTimeInMillis");
				detail.DBClusterId = _ctx.StringValue("ListSparkApps.Data.AppInfoList["+ i +"].Detail.DBClusterId");
				detail.ResourceGroupName = _ctx.StringValue("ListSparkApps.Data.AppInfoList["+ i +"].Detail.ResourceGroupName");
				detail.DurationInMillis = _ctx.LongValue("ListSparkApps.Data.AppInfoList["+ i +"].Detail.DurationInMillis");
				appInfo.Detail = detail;

				data_appInfoList.Add(appInfo);
			}
			data.AppInfoList = data_appInfoList;
			listSparkAppsResponse.Data = data;
        
			return listSparkAppsResponse;
        }
    }
}
