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
    public class ListFavoriteReportsResponseUnmarshaller
    {
        public static ListFavoriteReportsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListFavoriteReportsResponse listFavoriteReportsResponse = new ListFavoriteReportsResponse();

			listFavoriteReportsResponse.HttpResponse = _ctx.HttpResponse;
			listFavoriteReportsResponse.RequestId = _ctx.StringValue("ListFavoriteReports.RequestId");
			listFavoriteReportsResponse.Success = _ctx.BooleanValue("ListFavoriteReports.Success");

			ListFavoriteReportsResponse.ListFavoriteReports_Result result = new ListFavoriteReportsResponse.ListFavoriteReports_Result();
			result.TotalNum = _ctx.IntegerValue("ListFavoriteReports.Result.TotalNum");
			result.TotalPages = _ctx.IntegerValue("ListFavoriteReports.Result.TotalPages");
			result.PageNum = _ctx.IntegerValue("ListFavoriteReports.Result.PageNum");
			result.PageSize = _ctx.IntegerValue("ListFavoriteReports.Result.PageSize");

			List<ListFavoriteReportsResponse.ListFavoriteReports_Result.ListFavoriteReports_DataItem> result_data = new List<ListFavoriteReportsResponse.ListFavoriteReports_Result.ListFavoriteReports_DataItem>();
			for (int i = 0; i < _ctx.Length("ListFavoriteReports.Result.Data.Length"); i++) {
				ListFavoriteReportsResponse.ListFavoriteReports_Result.ListFavoriteReports_DataItem dataItem = new ListFavoriteReportsResponse.ListFavoriteReports_Result.ListFavoriteReports_DataItem();
				dataItem.TreeId = _ctx.StringValue("ListFavoriteReports.Result.Data["+ i +"].TreeId");
				dataItem.Type = _ctx.StringValue("ListFavoriteReports.Result.Data["+ i +"].Type");
				dataItem.Name = _ctx.StringValue("ListFavoriteReports.Result.Data["+ i +"].Name");
				dataItem.OwnerNum = _ctx.StringValue("ListFavoriteReports.Result.Data["+ i +"].OwnerNum");
				dataItem.OwnerName = _ctx.StringValue("ListFavoriteReports.Result.Data["+ i +"].OwnerName");
				dataItem.GmtCreate = _ctx.StringValue("ListFavoriteReports.Result.Data["+ i +"].GmtCreate");
				dataItem.GmtModified = _ctx.StringValue("ListFavoriteReports.Result.Data["+ i +"].GmtModified");
				dataItem.PublishStatus = _ctx.IntegerValue("ListFavoriteReports.Result.Data["+ i +"].PublishStatus");
				dataItem.Favorite = _ctx.BooleanValue("ListFavoriteReports.Result.Data["+ i +"].Favorite");
				dataItem.HasViewAuth = _ctx.BooleanValue("ListFavoriteReports.Result.Data["+ i +"].HasViewAuth");
				dataItem.HasEditAuth = _ctx.BooleanValue("ListFavoriteReports.Result.Data["+ i +"].HasEditAuth");
				dataItem.WorkspaceId = _ctx.StringValue("ListFavoriteReports.Result.Data["+ i +"].WorkspaceId");
				dataItem.WorkspaceName = _ctx.StringValue("ListFavoriteReports.Result.Data["+ i +"].WorkspaceName");

				result_data.Add(dataItem);
			}
			result.Data = result_data;
			listFavoriteReportsResponse.Result = result;
        
			return listFavoriteReportsResponse;
        }
    }
}
