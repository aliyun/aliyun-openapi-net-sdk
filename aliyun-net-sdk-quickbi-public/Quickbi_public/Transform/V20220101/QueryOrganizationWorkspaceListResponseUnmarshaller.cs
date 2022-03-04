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
using Aliyun.Acs.quickbi_public.Model.V20220101;

namespace Aliyun.Acs.quickbi_public.Transform.V20220101
{
    public class QueryOrganizationWorkspaceListResponseUnmarshaller
    {
        public static QueryOrganizationWorkspaceListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryOrganizationWorkspaceListResponse queryOrganizationWorkspaceListResponse = new QueryOrganizationWorkspaceListResponse();

			queryOrganizationWorkspaceListResponse.HttpResponse = _ctx.HttpResponse;
			queryOrganizationWorkspaceListResponse.Success = _ctx.BooleanValue("QueryOrganizationWorkspaceList.Success");
			queryOrganizationWorkspaceListResponse.RequestId = _ctx.StringValue("QueryOrganizationWorkspaceList.RequestId");

			QueryOrganizationWorkspaceListResponse.QueryOrganizationWorkspaceList_Result result = new QueryOrganizationWorkspaceListResponse.QueryOrganizationWorkspaceList_Result();
			result.TotalPages = _ctx.IntegerValue("QueryOrganizationWorkspaceList.Result.TotalPages");
			result.PageNum = _ctx.IntegerValue("QueryOrganizationWorkspaceList.Result.PageNum");
			result.PageSize = _ctx.IntegerValue("QueryOrganizationWorkspaceList.Result.PageSize");
			result.TotalNum = _ctx.IntegerValue("QueryOrganizationWorkspaceList.Result.TotalNum");

			List<QueryOrganizationWorkspaceListResponse.QueryOrganizationWorkspaceList_Result.QueryOrganizationWorkspaceList_DataItem> result_data = new List<QueryOrganizationWorkspaceListResponse.QueryOrganizationWorkspaceList_Result.QueryOrganizationWorkspaceList_DataItem>();
			for (int i = 0; i < _ctx.Length("QueryOrganizationWorkspaceList.Result.Data.Length"); i++) {
				QueryOrganizationWorkspaceListResponse.QueryOrganizationWorkspaceList_Result.QueryOrganizationWorkspaceList_DataItem dataItem = new QueryOrganizationWorkspaceListResponse.QueryOrganizationWorkspaceList_Result.QueryOrganizationWorkspaceList_DataItem();
				dataItem.CreateUserAccountName = _ctx.StringValue("QueryOrganizationWorkspaceList.Result.Data["+ i +"].CreateUserAccountName");
				dataItem.Owner = _ctx.StringValue("QueryOrganizationWorkspaceList.Result.Data["+ i +"].Owner");
				dataItem.CreateTime = _ctx.StringValue("QueryOrganizationWorkspaceList.Result.Data["+ i +"].CreateTime");
				dataItem.WorkspaceName = _ctx.StringValue("QueryOrganizationWorkspaceList.Result.Data["+ i +"].WorkspaceName");
				dataItem.OrganizationId = _ctx.StringValue("QueryOrganizationWorkspaceList.Result.Data["+ i +"].OrganizationId");
				dataItem.WorkspaceId = _ctx.StringValue("QueryOrganizationWorkspaceList.Result.Data["+ i +"].WorkspaceId");
				dataItem.AllowShareOperation = _ctx.BooleanValue("QueryOrganizationWorkspaceList.Result.Data["+ i +"].AllowShareOperation");
				dataItem.CreateUser = _ctx.StringValue("QueryOrganizationWorkspaceList.Result.Data["+ i +"].CreateUser");
				dataItem.ModifiedTime = _ctx.StringValue("QueryOrganizationWorkspaceList.Result.Data["+ i +"].ModifiedTime");
				dataItem.WorkspaceDescription = _ctx.StringValue("QueryOrganizationWorkspaceList.Result.Data["+ i +"].WorkspaceDescription");
				dataItem.ModifyUser = _ctx.StringValue("QueryOrganizationWorkspaceList.Result.Data["+ i +"].ModifyUser");
				dataItem.AllowPublishOperation = _ctx.BooleanValue("QueryOrganizationWorkspaceList.Result.Data["+ i +"].AllowPublishOperation");
				dataItem.OwnerAccountName = _ctx.StringValue("QueryOrganizationWorkspaceList.Result.Data["+ i +"].OwnerAccountName");
				dataItem.ModifyUserAccountName = _ctx.StringValue("QueryOrganizationWorkspaceList.Result.Data["+ i +"].ModifyUserAccountName");

				result_data.Add(dataItem);
			}
			result.Data = result_data;
			queryOrganizationWorkspaceListResponse.Result = result;
        
			return queryOrganizationWorkspaceListResponse;
        }
    }
}
