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
using Aliyun.Acs.es_serverless.Model.V20220822;

namespace Aliyun.Acs.es_serverless.Transform.V20220822
{
    public class ListAppsResponseUnmarshaller
    {
        public static ListAppsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAppsResponse listAppsResponse = new ListAppsResponse();

			listAppsResponse.HttpResponse = _ctx.HttpResponse;
			listAppsResponse.TotalCount = _ctx.IntegerValue("ListApps.totalCount");
			listAppsResponse.RequestId = _ctx.StringValue("ListApps.requestId");

			List<ListAppsResponse.ListApps_App> listAppsResponse_result = new List<ListAppsResponse.ListApps_App>();
			for (int i = 0; i < _ctx.Length("ListApps.Result.Length"); i++) {
				ListAppsResponse.ListApps_App app = new ListAppsResponse.ListApps_App();
				app.AppName = _ctx.StringValue("ListApps.Result["+ i +"].appName");
				app.OwnerId = _ctx.StringValue("ListApps.Result["+ i +"].ownerId");
				app.StorageQuota = _ctx.StringValue("ListApps.Result["+ i +"].storageQuota");
				app.RegionId = _ctx.StringValue("ListApps.Result["+ i +"].regionId");
				app.Status = _ctx.StringValue("ListApps.Result["+ i +"].status");
				app.CreateTime = _ctx.StringValue("ListApps.Result["+ i +"].createTime");
				app.FlowQuota = _ctx.StringValue("ListApps.Result["+ i +"].flowQuota");
				app.Description = _ctx.StringValue("ListApps.Result["+ i +"].description");

				listAppsResponse_result.Add(app);
			}
			listAppsResponse.Result = listAppsResponse_result;
        
			return listAppsResponse;
        }
    }
}
