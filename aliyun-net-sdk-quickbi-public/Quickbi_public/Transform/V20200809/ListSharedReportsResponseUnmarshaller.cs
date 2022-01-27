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
using Aliyun.Acs.quickbi_public.Model.V20200809;

namespace Aliyun.Acs.quickbi_public.Transform.V20200809
{
    public class ListSharedReportsResponseUnmarshaller
    {
        public static ListSharedReportsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSharedReportsResponse listSharedReportsResponse = new ListSharedReportsResponse();

			listSharedReportsResponse.HttpResponse = _ctx.HttpResponse;
			listSharedReportsResponse.RequestId = _ctx.StringValue("ListSharedReports.RequestId");
			listSharedReportsResponse.Success = _ctx.BooleanValue("ListSharedReports.Success");

			ListSharedReportsResponse.ListSharedReports_Result result = new ListSharedReportsResponse.ListSharedReports_Result();
			result.TotalNum = _ctx.IntegerValue("ListSharedReports.Result.TotalNum");
			result.TotalPages = _ctx.IntegerValue("ListSharedReports.Result.TotalPages");
			result.PageNum = _ctx.IntegerValue("ListSharedReports.Result.PageNum");
			result.PageSize = _ctx.IntegerValue("ListSharedReports.Result.PageSize");

			List<ListSharedReportsResponse.ListSharedReports_Result.ListSharedReports_DataItem> result_data = new List<ListSharedReportsResponse.ListSharedReports_Result.ListSharedReports_DataItem>();
			for (int i = 0; i < _ctx.Length("ListSharedReports.Result.Data.Length"); i++) {
				ListSharedReportsResponse.ListSharedReports_Result.ListSharedReports_DataItem dataItem = new ListSharedReportsResponse.ListSharedReports_Result.ListSharedReports_DataItem();
				dataItem.TreeId = _ctx.StringValue("ListSharedReports.Result.Data["+ i +"].TreeId");
				dataItem.Type = _ctx.StringValue("ListSharedReports.Result.Data["+ i +"].Type");
				dataItem.Name = _ctx.StringValue("ListSharedReports.Result.Data["+ i +"].Name");
				dataItem.OwnerNum = _ctx.StringValue("ListSharedReports.Result.Data["+ i +"].OwnerNum");
				dataItem.OwnerName = _ctx.StringValue("ListSharedReports.Result.Data["+ i +"].OwnerName");
				dataItem.GmtCreate = _ctx.StringValue("ListSharedReports.Result.Data["+ i +"].GmtCreate");
				dataItem.GmtModified = _ctx.StringValue("ListSharedReports.Result.Data["+ i +"].GmtModified");
				dataItem.PublishStatus = _ctx.IntegerValue("ListSharedReports.Result.Data["+ i +"].PublishStatus");
				dataItem.Favorite = _ctx.BooleanValue("ListSharedReports.Result.Data["+ i +"].Favorite");
				dataItem.HasViewAuth = _ctx.BooleanValue("ListSharedReports.Result.Data["+ i +"].HasViewAuth");
				dataItem.HasEditAuth = _ctx.BooleanValue("ListSharedReports.Result.Data["+ i +"].HasEditAuth");
				dataItem.WorkspaceId = _ctx.StringValue("ListSharedReports.Result.Data["+ i +"].WorkspaceId");
				dataItem.WorkspaceName = _ctx.StringValue("ListSharedReports.Result.Data["+ i +"].WorkspaceName");

				result_data.Add(dataItem);
			}
			result.Data = result_data;
			listSharedReportsResponse.Result = result;
        
			return listSharedReportsResponse;
        }
    }
}
