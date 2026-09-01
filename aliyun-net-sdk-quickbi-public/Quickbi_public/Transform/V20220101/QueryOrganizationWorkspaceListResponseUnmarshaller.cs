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
			queryOrganizationWorkspaceListResponse.RequestId = _ctx.StringValue("QueryOrganizationWorkspaceList.RequestId");
			queryOrganizationWorkspaceListResponse.Success = _ctx.BooleanValue("QueryOrganizationWorkspaceList.Success");

			QueryOrganizationWorkspaceListResponse.QueryOrganizationWorkspaceList_Result result = new QueryOrganizationWorkspaceListResponse.QueryOrganizationWorkspaceList_Result();
			result.TotalNum = _ctx.IntegerValue("QueryOrganizationWorkspaceList.Result.TotalNum");
			result.PageNum = _ctx.IntegerValue("QueryOrganizationWorkspaceList.Result.PageNum");
			result.PageSize = _ctx.IntegerValue("QueryOrganizationWorkspaceList.Result.PageSize");
			result.TotalPages = _ctx.IntegerValue("QueryOrganizationWorkspaceList.Result.TotalPages");

			List<QueryOrganizationWorkspaceListResponse.QueryOrganizationWorkspaceList_Result.QueryOrganizationWorkspaceList_DataItem> result_data = new List<QueryOrganizationWorkspaceListResponse.QueryOrganizationWorkspaceList_Result.QueryOrganizationWorkspaceList_DataItem>();
			for (int i = 0; i < _ctx.Length("QueryOrganizationWorkspaceList.Result.Data.Length"); i++) {
				QueryOrganizationWorkspaceListResponse.QueryOrganizationWorkspaceList_Result.QueryOrganizationWorkspaceList_DataItem dataItem = new QueryOrganizationWorkspaceListResponse.QueryOrganizationWorkspaceList_Result.QueryOrganizationWorkspaceList_DataItem();
				dataItem.WorkspaceDescription = _ctx.StringValue("QueryOrganizationWorkspaceList.Result.Data["+ i +"].WorkspaceDescription");
				dataItem.RealOwnerAccountName = _ctx.StringValue("QueryOrganizationWorkspaceList.Result.Data["+ i +"].RealOwnerAccountName");
				dataItem.Owner = _ctx.StringValue("QueryOrganizationWorkspaceList.Result.Data["+ i +"].Owner");
				dataItem.ModifyUser = _ctx.StringValue("QueryOrganizationWorkspaceList.Result.Data["+ i +"].ModifyUser");
				dataItem.CreateTime = _ctx.StringValue("QueryOrganizationWorkspaceList.Result.Data["+ i +"].CreateTime");
				dataItem.OwnerAccountName = _ctx.StringValue("QueryOrganizationWorkspaceList.Result.Data["+ i +"].OwnerAccountName");
				dataItem.WorkspaceId = _ctx.StringValue("QueryOrganizationWorkspaceList.Result.Data["+ i +"].WorkspaceId");
				dataItem.CreateUser = _ctx.StringValue("QueryOrganizationWorkspaceList.Result.Data["+ i +"].CreateUser");
				dataItem.OrganizationId = _ctx.StringValue("QueryOrganizationWorkspaceList.Result.Data["+ i +"].OrganizationId");
				dataItem.ModifyUserAccountName = _ctx.StringValue("QueryOrganizationWorkspaceList.Result.Data["+ i +"].ModifyUserAccountName");
				dataItem.ModifiedTime = _ctx.StringValue("QueryOrganizationWorkspaceList.Result.Data["+ i +"].ModifiedTime");
				dataItem.AllowShareOperation = _ctx.BooleanValue("QueryOrganizationWorkspaceList.Result.Data["+ i +"].AllowShareOperation");
				dataItem.WorkspaceName = _ctx.StringValue("QueryOrganizationWorkspaceList.Result.Data["+ i +"].WorkspaceName");
				dataItem.AllowPublishOperation = _ctx.BooleanValue("QueryOrganizationWorkspaceList.Result.Data["+ i +"].AllowPublishOperation");
				dataItem.CreateUserAccountName = _ctx.StringValue("QueryOrganizationWorkspaceList.Result.Data["+ i +"].CreateUserAccountName");

				QueryOrganizationWorkspaceListResponse.QueryOrganizationWorkspaceList_Result.QueryOrganizationWorkspaceList_DataItem.QueryOrganizationWorkspaceList_WorkspaceExportConfig workspaceExportConfig = new QueryOrganizationWorkspaceListResponse.QueryOrganizationWorkspaceList_Result.QueryOrganizationWorkspaceList_DataItem.QueryOrganizationWorkspaceList_WorkspaceExportConfig();
				workspaceExportConfig.DefaultExportType = _ctx.BooleanValue("QueryOrganizationWorkspaceList.Result.Data["+ i +"].WorkspaceExportConfig.DefaultExportType");
				workspaceExportConfig.PdfExport = _ctx.BooleanValue("QueryOrganizationWorkspaceList.Result.Data["+ i +"].WorkspaceExportConfig.PdfExport");
				workspaceExportConfig.ImageExport = _ctx.BooleanValue("QueryOrganizationWorkspaceList.Result.Data["+ i +"].WorkspaceExportConfig.ImageExport");
				workspaceExportConfig.ExportToServer = _ctx.BooleanValue("QueryOrganizationWorkspaceList.Result.Data["+ i +"].WorkspaceExportConfig.ExportToServer");
				workspaceExportConfig.ExportToLocal = _ctx.BooleanValue("QueryOrganizationWorkspaceList.Result.Data["+ i +"].WorkspaceExportConfig.ExportToLocal");
				workspaceExportConfig.ExportMainSwitch = _ctx.BooleanValue("QueryOrganizationWorkspaceList.Result.Data["+ i +"].WorkspaceExportConfig.ExportMainSwitch");
				workspaceExportConfig.AllowExcelImageFile = _ctx.BooleanValue("QueryOrganizationWorkspaceList.Result.Data["+ i +"].WorkspaceExportConfig.AllowExcelImageFile");
				workspaceExportConfig.DataExport = _ctx.BooleanValue("QueryOrganizationWorkspaceList.Result.Data["+ i +"].WorkspaceExportConfig.DataExport");
				workspaceExportConfig.ExportToPublicWork = _ctx.BooleanValue("QueryOrganizationWorkspaceList.Result.Data["+ i +"].WorkspaceExportConfig.ExportToPublicWork");
				dataItem.WorkspaceExportConfig = workspaceExportConfig;

				result_data.Add(dataItem);
			}
			result.Data = result_data;
			queryOrganizationWorkspaceListResponse.Result = result;
        
			return queryOrganizationWorkspaceListResponse;
        }
    }
}
