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
    public class ListRecentViewReportsResponseUnmarshaller
    {
        public static ListRecentViewReportsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListRecentViewReportsResponse listRecentViewReportsResponse = new ListRecentViewReportsResponse();

			listRecentViewReportsResponse.HttpResponse = _ctx.HttpResponse;
			listRecentViewReportsResponse.RequestId = _ctx.StringValue("ListRecentViewReports.RequestId");
			listRecentViewReportsResponse.Success = _ctx.BooleanValue("ListRecentViewReports.Success");

			ListRecentViewReportsResponse.ListRecentViewReports_Result result = new ListRecentViewReportsResponse.ListRecentViewReports_Result();
			result.TotalNum = _ctx.IntegerValue("ListRecentViewReports.Result.TotalNum");
			result.TotalPages = _ctx.IntegerValue("ListRecentViewReports.Result.TotalPages");
			result.PageNum = _ctx.IntegerValue("ListRecentViewReports.Result.PageNum");
			result.PageSize = _ctx.IntegerValue("ListRecentViewReports.Result.PageSize");

			List<ListRecentViewReportsResponse.ListRecentViewReports_Result.ListRecentViewReports_DataItem> result_data = new List<ListRecentViewReportsResponse.ListRecentViewReports_Result.ListRecentViewReports_DataItem>();
			for (int i = 0; i < _ctx.Length("ListRecentViewReports.Result.Data.Length"); i++) {
				ListRecentViewReportsResponse.ListRecentViewReports_Result.ListRecentViewReports_DataItem dataItem = new ListRecentViewReportsResponse.ListRecentViewReports_Result.ListRecentViewReports_DataItem();
				dataItem.TreeId = _ctx.StringValue("ListRecentViewReports.Result.Data["+ i +"].TreeId");
				dataItem.Type = _ctx.StringValue("ListRecentViewReports.Result.Data["+ i +"].Type");
				dataItem.Name = _ctx.StringValue("ListRecentViewReports.Result.Data["+ i +"].Name");
				dataItem.OwnerNum = _ctx.StringValue("ListRecentViewReports.Result.Data["+ i +"].OwnerNum");
				dataItem.OwnerName = _ctx.StringValue("ListRecentViewReports.Result.Data["+ i +"].OwnerName");
				dataItem.GmtCreate = _ctx.StringValue("ListRecentViewReports.Result.Data["+ i +"].GmtCreate");
				dataItem.GmtModified = _ctx.StringValue("ListRecentViewReports.Result.Data["+ i +"].GmtModified");
				dataItem.PublishStatus = _ctx.IntegerValue("ListRecentViewReports.Result.Data["+ i +"].PublishStatus");
				dataItem.Favorite = _ctx.BooleanValue("ListRecentViewReports.Result.Data["+ i +"].Favorite");
				dataItem.HasViewAuth = _ctx.BooleanValue("ListRecentViewReports.Result.Data["+ i +"].HasViewAuth");
				dataItem.HasEditAuth = _ctx.BooleanValue("ListRecentViewReports.Result.Data["+ i +"].HasEditAuth");
				dataItem.WorkspaceId = _ctx.StringValue("ListRecentViewReports.Result.Data["+ i +"].WorkspaceId");
				dataItem.WorkspaceName = _ctx.StringValue("ListRecentViewReports.Result.Data["+ i +"].WorkspaceName");
				dataItem.ViewCount = _ctx.LongValue("ListRecentViewReports.Result.Data["+ i +"].ViewCount");
				dataItem.LatestViewTime = _ctx.StringValue("ListRecentViewReports.Result.Data["+ i +"].LatestViewTime");

				result_data.Add(dataItem);
			}
			result.Data = result_data;
			listRecentViewReportsResponse.Result = result;
        
			return listRecentViewReportsResponse;
        }
    }
}
