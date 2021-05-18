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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class QueryStudioAppListResponseUnmarshaller
    {
        public static QueryStudioAppListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryStudioAppListResponse queryStudioAppListResponse = new QueryStudioAppListResponse();

			queryStudioAppListResponse.HttpResponse = _ctx.HttpResponse;
			queryStudioAppListResponse.RequestId = _ctx.StringValue("QueryStudioAppList.RequestId");
			queryStudioAppListResponse.Success = _ctx.BooleanValue("QueryStudioAppList.Success");
			queryStudioAppListResponse.Code = _ctx.StringValue("QueryStudioAppList.Code");
			queryStudioAppListResponse.ErrorMessage = _ctx.StringValue("QueryStudioAppList.ErrorMessage");

			QueryStudioAppListResponse.QueryStudioAppList_Data data = new QueryStudioAppListResponse.QueryStudioAppList_Data();
			data.PageSize = _ctx.IntegerValue("QueryStudioAppList.Data.PageSize");
			data.PageNo = _ctx.IntegerValue("QueryStudioAppList.Data.PageNo");
			data.Total = _ctx.IntegerValue("QueryStudioAppList.Data.Total");
			data.TotalPage = _ctx.IntegerValue("QueryStudioAppList.Data.TotalPage");

			List<QueryStudioAppListResponse.QueryStudioAppList_Data.QueryStudioAppList_AppInfo> data_list = new List<QueryStudioAppListResponse.QueryStudioAppList_Data.QueryStudioAppList_AppInfo>();
			for (int i = 0; i < _ctx.Length("QueryStudioAppList.Data.List.Length"); i++) {
				QueryStudioAppListResponse.QueryStudioAppList_Data.QueryStudioAppList_AppInfo appInfo = new QueryStudioAppListResponse.QueryStudioAppList_Data.QueryStudioAppList_AppInfo();
				appInfo.Name = _ctx.StringValue("QueryStudioAppList.Data.List["+ i +"].Name");
				appInfo.AppId = _ctx.StringValue("QueryStudioAppList.Data.List["+ i +"].AppId");
				appInfo.AppKey = _ctx.StringValue("QueryStudioAppList.Data.List["+ i +"].AppKey");
				appInfo.AppSecret = _ctx.StringValue("QueryStudioAppList.Data.List["+ i +"].AppSecret");
				appInfo.ProjectId = _ctx.StringValue("QueryStudioAppList.Data.List["+ i +"].ProjectId");
				appInfo.Type = _ctx.StringValue("QueryStudioAppList.Data.List["+ i +"].Type");
				appInfo.Description = _ctx.StringValue("QueryStudioAppList.Data.List["+ i +"].Description");
				appInfo.GmtCreate = _ctx.StringValue("QueryStudioAppList.Data.List["+ i +"].GmtCreate");
				appInfo.GmtModified = _ctx.StringValue("QueryStudioAppList.Data.List["+ i +"].GmtModified");
				appInfo.GmtRelease = _ctx.StringValue("QueryStudioAppList.Data.List["+ i +"].GmtRelease");

				data_list.Add(appInfo);
			}
			data.List = data_list;
			queryStudioAppListResponse.Data = data;
        
			return queryStudioAppListResponse;
        }
    }
}
