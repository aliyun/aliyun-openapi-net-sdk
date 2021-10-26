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
using Aliyun.Acs.quickbi_public.Model.V20200807;

namespace Aliyun.Acs.quickbi_public.Transform.V20200807
{
    public class QueryWorksByWorkspaceResponseUnmarshaller
    {
        public static QueryWorksByWorkspaceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryWorksByWorkspaceResponse queryWorksByWorkspaceResponse = new QueryWorksByWorkspaceResponse();

			queryWorksByWorkspaceResponse.HttpResponse = _ctx.HttpResponse;
			queryWorksByWorkspaceResponse.RequestId = _ctx.StringValue("QueryWorksByWorkspace.RequestId");
			queryWorksByWorkspaceResponse.Success = _ctx.BooleanValue("QueryWorksByWorkspace.Success");

			QueryWorksByWorkspaceResponse.QueryWorksByWorkspace_Result result = new QueryWorksByWorkspaceResponse.QueryWorksByWorkspace_Result();
			result.TotalNum = _ctx.IntegerValue("QueryWorksByWorkspace.Result.TotalNum");
			result.TotalPages = _ctx.IntegerValue("QueryWorksByWorkspace.Result.TotalPages");
			result.PageNum = _ctx.IntegerValue("QueryWorksByWorkspace.Result.PageNum");
			result.PageSize = _ctx.IntegerValue("QueryWorksByWorkspace.Result.PageSize");

			List<QueryWorksByWorkspaceResponse.QueryWorksByWorkspace_Result.QueryWorksByWorkspace_DataItem> result_data = new List<QueryWorksByWorkspaceResponse.QueryWorksByWorkspace_Result.QueryWorksByWorkspace_DataItem>();
			for (int i = 0; i < _ctx.Length("QueryWorksByWorkspace.Result.Data.Length"); i++) {
				QueryWorksByWorkspaceResponse.QueryWorksByWorkspace_Result.QueryWorksByWorkspace_DataItem dataItem = new QueryWorksByWorkspaceResponse.QueryWorksByWorkspace_Result.QueryWorksByWorkspace_DataItem();
				dataItem.WorksId = _ctx.StringValue("QueryWorksByWorkspace.Result.Data["+ i +"].WorksId");
				dataItem.WorkType = _ctx.StringValue("QueryWorksByWorkspace.Result.Data["+ i +"].WorkType");
				dataItem.WorkName = _ctx.StringValue("QueryWorksByWorkspace.Result.Data["+ i +"].WorkName");
				dataItem.WorkspaceId = _ctx.StringValue("QueryWorksByWorkspace.Result.Data["+ i +"].WorkspaceId");
				dataItem.SecurityLevel = _ctx.StringValue("QueryWorksByWorkspace.Result.Data["+ i +"].SecurityLevel");
				dataItem.Description = _ctx.StringValue("QueryWorksByWorkspace.Result.Data["+ i +"].Description");
				dataItem.OwnerId = _ctx.StringValue("QueryWorksByWorkspace.Result.Data["+ i +"].OwnerId");
				dataItem.OwnerName = _ctx.StringValue("QueryWorksByWorkspace.Result.Data["+ i +"].OwnerName");
				dataItem.ModifyName = _ctx.StringValue("QueryWorksByWorkspace.Result.Data["+ i +"].ModifyName");
				dataItem.GmtCreate = _ctx.StringValue("QueryWorksByWorkspace.Result.Data["+ i +"].GmtCreate");
				dataItem.GmtModify = _ctx.StringValue("QueryWorksByWorkspace.Result.Data["+ i +"].GmtModify");
				dataItem.Auth3rdFlag = _ctx.IntegerValue("QueryWorksByWorkspace.Result.Data["+ i +"].Auth3rdFlag");
				dataItem.Status = _ctx.IntegerValue("QueryWorksByWorkspace.Result.Data["+ i +"].Status");
				dataItem.WorkspaceName = _ctx.StringValue("QueryWorksByWorkspace.Result.Data["+ i +"].WorkspaceName");

				QueryWorksByWorkspaceResponse.QueryWorksByWorkspace_Result.QueryWorksByWorkspace_DataItem.QueryWorksByWorkspace_Directory directory = new QueryWorksByWorkspaceResponse.QueryWorksByWorkspace_Result.QueryWorksByWorkspace_DataItem.QueryWorksByWorkspace_Directory();
				directory.Id = _ctx.StringValue("QueryWorksByWorkspace.Result.Data["+ i +"].Directory.Id");
				directory.Name = _ctx.StringValue("QueryWorksByWorkspace.Result.Data["+ i +"].Directory.Name");
				directory.PathId = _ctx.StringValue("QueryWorksByWorkspace.Result.Data["+ i +"].Directory.PathId");
				directory.PathName = _ctx.StringValue("QueryWorksByWorkspace.Result.Data["+ i +"].Directory.PathName");
				dataItem.Directory = directory;

				result_data.Add(dataItem);
			}
			result.Data = result_data;
			queryWorksByWorkspaceResponse.Result = result;
        
			return queryWorksByWorkspaceResponse;
        }
    }
}
