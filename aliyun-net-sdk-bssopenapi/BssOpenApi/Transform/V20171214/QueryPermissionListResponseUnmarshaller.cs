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
using Aliyun.Acs.BssOpenApi.Model.V20171214;

namespace Aliyun.Acs.BssOpenApi.Transform.V20171214
{
    public class QueryPermissionListResponseUnmarshaller
    {
        public static QueryPermissionListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryPermissionListResponse queryPermissionListResponse = new QueryPermissionListResponse();

			queryPermissionListResponse.HttpResponse = _ctx.HttpResponse;
			queryPermissionListResponse.Code = _ctx.StringValue("QueryPermissionList.Code");
			queryPermissionListResponse.RequestId = _ctx.StringValue("QueryPermissionList.RequestId");
			queryPermissionListResponse.Success = _ctx.BooleanValue("QueryPermissionList.Success");
			queryPermissionListResponse.Message = _ctx.StringValue("QueryPermissionList.Message");

			QueryPermissionListResponse.QueryPermissionList_Data data = new QueryPermissionListResponse.QueryPermissionList_Data();
			data.MasterId = _ctx.LongValue("QueryPermissionList.Data.MasterId");
			data.MemberId = _ctx.LongValue("QueryPermissionList.Data.MemberId");
			data.RelationType = _ctx.StringValue("QueryPermissionList.Data.RelationType");
			data.State = _ctx.StringValue("QueryPermissionList.Data.State");
			data.SetupTime = _ctx.StringValue("QueryPermissionList.Data.SetupTime");
			data.StartTime = _ctx.StringValue("QueryPermissionList.Data.StartTime");
			data.EndTime = _ctx.StringValue("QueryPermissionList.Data.EndTime");

			List<QueryPermissionListResponse.QueryPermissionList_Data.QueryPermissionList_PermissionListItem> data_permissionList = new List<QueryPermissionListResponse.QueryPermissionList_Data.QueryPermissionList_PermissionListItem>();
			for (int i = 0; i < _ctx.Length("QueryPermissionList.Data.PermissionList.Length"); i++) {
				QueryPermissionListResponse.QueryPermissionList_Data.QueryPermissionList_PermissionListItem permissionListItem = new QueryPermissionListResponse.QueryPermissionList_Data.QueryPermissionList_PermissionListItem();
				permissionListItem.PermissionCode = _ctx.StringValue("QueryPermissionList.Data.PermissionList["+ i +"].PermissionCode");
				permissionListItem.PermissionName = _ctx.StringValue("QueryPermissionList.Data.PermissionList["+ i +"].PermissionName");
				permissionListItem.StartTime = _ctx.StringValue("QueryPermissionList.Data.PermissionList["+ i +"].StartTime");
				permissionListItem.EndTime = _ctx.StringValue("QueryPermissionList.Data.PermissionList["+ i +"].EndTime");

				data_permissionList.Add(permissionListItem);
			}
			data.PermissionList = data_permissionList;
			queryPermissionListResponse.Data = data;
        
			return queryPermissionListResponse;
        }
    }
}
