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
    public class QueryWorksByOrganizationResponseUnmarshaller
    {
        public static QueryWorksByOrganizationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryWorksByOrganizationResponse queryWorksByOrganizationResponse = new QueryWorksByOrganizationResponse();

			queryWorksByOrganizationResponse.HttpResponse = _ctx.HttpResponse;
			queryWorksByOrganizationResponse.Success = _ctx.BooleanValue("QueryWorksByOrganization.Success");
			queryWorksByOrganizationResponse.RequestId = _ctx.StringValue("QueryWorksByOrganization.RequestId");

			QueryWorksByOrganizationResponse.QueryWorksByOrganization_Result result = new QueryWorksByOrganizationResponse.QueryWorksByOrganization_Result();
			result.TotalPages = _ctx.IntegerValue("QueryWorksByOrganization.Result.TotalPages");
			result.PageNum = _ctx.IntegerValue("QueryWorksByOrganization.Result.PageNum");
			result.PageSize = _ctx.IntegerValue("QueryWorksByOrganization.Result.PageSize");
			result.TotalNum = _ctx.IntegerValue("QueryWorksByOrganization.Result.TotalNum");

			List<QueryWorksByOrganizationResponse.QueryWorksByOrganization_Result.QueryWorksByOrganization_DataItem> result_data = new List<QueryWorksByOrganizationResponse.QueryWorksByOrganization_Result.QueryWorksByOrganization_DataItem>();
			for (int i = 0; i < _ctx.Length("QueryWorksByOrganization.Result.Data.Length"); i++) {
				QueryWorksByOrganizationResponse.QueryWorksByOrganization_Result.QueryWorksByOrganization_DataItem dataItem = new QueryWorksByOrganizationResponse.QueryWorksByOrganization_Result.QueryWorksByOrganization_DataItem();
				dataItem.Status = _ctx.IntegerValue("QueryWorksByOrganization.Result.Data["+ i +"].Status");
				dataItem.Auth3rdFlag = _ctx.IntegerValue("QueryWorksByOrganization.Result.Data["+ i +"].Auth3rdFlag");
				dataItem.GmtModify = _ctx.StringValue("QueryWorksByOrganization.Result.Data["+ i +"].GmtModify");
				dataItem.WorksId = _ctx.StringValue("QueryWorksByOrganization.Result.Data["+ i +"].WorksId");
				dataItem.WorkType = _ctx.StringValue("QueryWorksByOrganization.Result.Data["+ i +"].WorkType");
				dataItem.OwnerName = _ctx.StringValue("QueryWorksByOrganization.Result.Data["+ i +"].OwnerName");
				dataItem.WorkspaceName = _ctx.StringValue("QueryWorksByOrganization.Result.Data["+ i +"].WorkspaceName");
				dataItem.OwnerId = _ctx.StringValue("QueryWorksByOrganization.Result.Data["+ i +"].OwnerId");
				dataItem.ModifyName = _ctx.StringValue("QueryWorksByOrganization.Result.Data["+ i +"].ModifyName");
				dataItem.WorkspaceId = _ctx.StringValue("QueryWorksByOrganization.Result.Data["+ i +"].WorkspaceId");
				dataItem.SecurityLevel = _ctx.StringValue("QueryWorksByOrganization.Result.Data["+ i +"].SecurityLevel");
				dataItem.Description = _ctx.StringValue("QueryWorksByOrganization.Result.Data["+ i +"].Description");
				dataItem.WorkName = _ctx.StringValue("QueryWorksByOrganization.Result.Data["+ i +"].WorkName");
				dataItem.GmtCreate = _ctx.StringValue("QueryWorksByOrganization.Result.Data["+ i +"].GmtCreate");
				dataItem.PublicFlag = _ctx.BooleanValue("QueryWorksByOrganization.Result.Data["+ i +"].PublicFlag");
				dataItem.PublicInvalidTime = _ctx.LongValue("QueryWorksByOrganization.Result.Data["+ i +"].PublicInvalidTime");

				QueryWorksByOrganizationResponse.QueryWorksByOrganization_Result.QueryWorksByOrganization_DataItem.QueryWorksByOrganization_Directory directory = new QueryWorksByOrganizationResponse.QueryWorksByOrganization_Result.QueryWorksByOrganization_DataItem.QueryWorksByOrganization_Directory();
				directory.PathId = _ctx.StringValue("QueryWorksByOrganization.Result.Data["+ i +"].Directory.PathId");
				directory.PathName = _ctx.StringValue("QueryWorksByOrganization.Result.Data["+ i +"].Directory.PathName");
				directory.Name = _ctx.StringValue("QueryWorksByOrganization.Result.Data["+ i +"].Directory.Name");
				directory.Id = _ctx.StringValue("QueryWorksByOrganization.Result.Data["+ i +"].Directory.Id");
				dataItem.Directory = directory;

				result_data.Add(dataItem);
			}
			result.Data = result_data;
			queryWorksByOrganizationResponse.Result = result;
        
			return queryWorksByOrganizationResponse;
        }
    }
}
