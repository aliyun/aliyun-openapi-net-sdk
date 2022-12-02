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
    public class QueryMessageAppResponseUnmarshaller
    {
        public static QueryMessageAppResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryMessageAppResponse queryMessageAppResponse = new QueryMessageAppResponse();

			queryMessageAppResponse.HttpResponse = _ctx.HttpResponse;
			queryMessageAppResponse.RequestId = _ctx.StringValue("QueryMessageApp.RequestId");

			List<QueryMessageAppResponse.QueryMessageApp_ResultItem> queryMessageAppResponse_result = new List<QueryMessageAppResponse.QueryMessageApp_ResultItem>();
			for (int i = 0; i < _ctx.Length("QueryMessageApp.Result.Length"); i++) {
				QueryMessageAppResponse.QueryMessageApp_ResultItem resultItem = new QueryMessageAppResponse.QueryMessageApp_ResultItem();
				resultItem.TotalCount = _ctx.IntegerValue("QueryMessageApp.Result["+ i +"].TotalCount");
				resultItem.HasMore = _ctx.BooleanValue("QueryMessageApp.Result["+ i +"].HasMore");

				List<QueryMessageAppResponse.QueryMessageApp_ResultItem.QueryMessageApp_AppListItem> resultItem_appList = new List<QueryMessageAppResponse.QueryMessageApp_ResultItem.QueryMessageApp_AppListItem>();
				for (int j = 0; j < _ctx.Length("QueryMessageApp.Result["+ i +"].AppList.Length"); j++) {
					QueryMessageAppResponse.QueryMessageApp_ResultItem.QueryMessageApp_AppListItem appListItem = new QueryMessageAppResponse.QueryMessageApp_ResultItem.QueryMessageApp_AppListItem();
					appListItem.AppId = _ctx.StringValue("QueryMessageApp.Result["+ i +"].AppList["+ j +"].AppId");
					appListItem.AppName = _ctx.StringValue("QueryMessageApp.Result["+ i +"].AppList["+ j +"].AppName");
					appListItem.CreateTime = _ctx.LongValue("QueryMessageApp.Result["+ i +"].AppList["+ j +"].CreateTime");
					appListItem.Status = _ctx.IntegerValue("QueryMessageApp.Result["+ i +"].AppList["+ j +"].Status");
					appListItem.AppConfig = _ctx.StringValue("QueryMessageApp.Result["+ i +"].AppList["+ j +"].AppConfig");
					appListItem.Extension = _ctx.StringValue("QueryMessageApp.Result["+ i +"].AppList["+ j +"].Extension");

					resultItem_appList.Add(appListItem);
				}
				resultItem.AppList = resultItem_appList;

				queryMessageAppResponse_result.Add(resultItem);
			}
			queryMessageAppResponse.Result = queryMessageAppResponse_result;
        
			return queryMessageAppResponse;
        }
    }
}
