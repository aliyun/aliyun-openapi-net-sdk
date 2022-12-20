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
using Aliyun.Acs.viapi_oxs_cross.Model.V20200701;

namespace Aliyun.Acs.viapi_oxs_cross.Transform.V20200701
{
    public class QuerySDKInstancesResponseUnmarshaller
    {
        public static QuerySDKInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QuerySDKInstancesResponse querySDKInstancesResponse = new QuerySDKInstancesResponse();

			querySDKInstancesResponse.HttpResponse = _ctx.HttpResponse;
			querySDKInstancesResponse.Ok = _ctx.BooleanValue("QuerySDKInstances.Ok");
			querySDKInstancesResponse.Code = _ctx.StringValue("QuerySDKInstances.Code");
			querySDKInstancesResponse.HttpCode = _ctx.IntegerValue("QuerySDKInstances.HttpCode");
			querySDKInstancesResponse.ErrorMessage = _ctx.StringValue("QuerySDKInstances.ErrorMessage");
			querySDKInstancesResponse.RequestId = _ctx.StringValue("QuerySDKInstances.RequestId");

			QuerySDKInstancesResponse.QuerySDKInstances_Data data = new QuerySDKInstancesResponse.QuerySDKInstances_Data();
			data.PageNumber = _ctx.IntegerValue("QuerySDKInstances.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("QuerySDKInstances.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("QuerySDKInstances.Data.TotalCount");

			List<QuerySDKInstancesResponse.QuerySDKInstances_Data.QuerySDKInstances_SDKInstance> data_content = new List<QuerySDKInstancesResponse.QuerySDKInstances_Data.QuerySDKInstances_SDKInstance>();
			for (int i = 0; i < _ctx.Length("QuerySDKInstances.Data.Content.Length"); i++) {
				QuerySDKInstancesResponse.QuerySDKInstances_Data.QuerySDKInstances_SDKInstance sDKInstance = new QuerySDKInstancesResponse.QuerySDKInstances_Data.QuerySDKInstances_SDKInstance();
				sDKInstance.Status = _ctx.StringValue("QuerySDKInstances.Data.Content["+ i +"].Status");
				sDKInstance.LatestBuild = _ctx.StringValue("QuerySDKInstances.Data.Content["+ i +"].LatestBuild");
				sDKInstance.ValidFromDate = _ctx.StringValue("QuerySDKInstances.Data.Content["+ i +"].ValidFromDate");
				sDKInstance.ValidToDate = _ctx.StringValue("QuerySDKInstances.Data.Content["+ i +"].ValidToDate");
				sDKInstance.UserId = _ctx.StringValue("QuerySDKInstances.Data.Content["+ i +"].UserId");
				sDKInstance.Platform = _ctx.StringValue("QuerySDKInstances.Data.Content["+ i +"].Platform");
				sDKInstance.CreatedAt = _ctx.StringValue("QuerySDKInstances.Data.Content["+ i +"].CreatedAt");
				sDKInstance.Recipe = _ctx.StringValue("QuerySDKInstances.Data.Content["+ i +"].Recipe");
				sDKInstance.UpdatedAt = _ctx.StringValue("QuerySDKInstances.Data.Content["+ i +"].UpdatedAt");
				sDKInstance.InstanceId = _ctx.StringValue("QuerySDKInstances.Data.Content["+ i +"].InstanceId");
				sDKInstance.BundleId = _ctx.StringValue("QuerySDKInstances.Data.Content["+ i +"].BundleId");

				data_content.Add(sDKInstance);
			}
			data.Content = data_content;
			querySDKInstancesResponse.Data = data;
        
			return querySDKInstancesResponse;
        }
    }
}
