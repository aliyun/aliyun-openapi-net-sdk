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
    public class QueryDatasetListResponseUnmarshaller
    {
        public static QueryDatasetListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryDatasetListResponse queryDatasetListResponse = new QueryDatasetListResponse();

			queryDatasetListResponse.HttpResponse = _ctx.HttpResponse;
			queryDatasetListResponse.RequestId = _ctx.StringValue("QueryDatasetList.RequestId");
			queryDatasetListResponse.Success = _ctx.BooleanValue("QueryDatasetList.Success");

			QueryDatasetListResponse.QueryDatasetList_Result result = new QueryDatasetListResponse.QueryDatasetList_Result();
			result.PageNum = _ctx.IntegerValue("QueryDatasetList.Result.PageNum");
			result.PageSize = _ctx.IntegerValue("QueryDatasetList.Result.PageSize");
			result.TotalNum = _ctx.IntegerValue("QueryDatasetList.Result.TotalNum");
			result.TotalPages = _ctx.IntegerValue("QueryDatasetList.Result.TotalPages");

			List<QueryDatasetListResponse.QueryDatasetList_Result.QueryDatasetList_DataItem> result_data = new List<QueryDatasetListResponse.QueryDatasetList_Result.QueryDatasetList_DataItem>();
			for (int i = 0; i < _ctx.Length("QueryDatasetList.Result.Data.Length"); i++) {
				QueryDatasetListResponse.QueryDatasetList_Result.QueryDatasetList_DataItem dataItem = new QueryDatasetListResponse.QueryDatasetList_Result.QueryDatasetList_DataItem();
				dataItem.CreateTime = _ctx.StringValue("QueryDatasetList.Result.Data["+ i +"].CreateTime");
				dataItem.DatasetId = _ctx.StringValue("QueryDatasetList.Result.Data["+ i +"].DatasetId");
				dataItem.DatasetName = _ctx.StringValue("QueryDatasetList.Result.Data["+ i +"].DatasetName");
				dataItem.Description = _ctx.StringValue("QueryDatasetList.Result.Data["+ i +"].Description");
				dataItem.ModifyTime = _ctx.StringValue("QueryDatasetList.Result.Data["+ i +"].ModifyTime");
				dataItem.OpenOfflineAcceleration = _ctx.BooleanValue("QueryDatasetList.Result.Data["+ i +"].OpenOfflineAcceleration");
				dataItem.OwnerId = _ctx.StringValue("QueryDatasetList.Result.Data["+ i +"].OwnerId");
				dataItem.OwnerName = _ctx.StringValue("QueryDatasetList.Result.Data["+ i +"].OwnerName");
				dataItem.RowLevel = _ctx.BooleanValue("QueryDatasetList.Result.Data["+ i +"].RowLevel");
				dataItem.WorkspaceId = _ctx.StringValue("QueryDatasetList.Result.Data["+ i +"].WorkspaceId");
				dataItem.WorkspaceName = _ctx.StringValue("QueryDatasetList.Result.Data["+ i +"].WorkspaceName");

				QueryDatasetListResponse.QueryDatasetList_Result.QueryDatasetList_DataItem.QueryDatasetList_DataSource dataSource = new QueryDatasetListResponse.QueryDatasetList_Result.QueryDatasetList_DataItem.QueryDatasetList_DataSource();
				dataSource.DsId = _ctx.StringValue("QueryDatasetList.Result.Data["+ i +"].DataSource.DsId");
				dataSource.DsName = _ctx.StringValue("QueryDatasetList.Result.Data["+ i +"].DataSource.DsName");
				dataSource.DsType = _ctx.StringValue("QueryDatasetList.Result.Data["+ i +"].DataSource.DsType");
				dataItem.DataSource = dataSource;

				QueryDatasetListResponse.QueryDatasetList_Result.QueryDatasetList_DataItem.QueryDatasetList_Directory directory = new QueryDatasetListResponse.QueryDatasetList_Result.QueryDatasetList_DataItem.QueryDatasetList_Directory();
				directory.Id = _ctx.StringValue("QueryDatasetList.Result.Data["+ i +"].Directory.Id");
				directory.Name = _ctx.StringValue("QueryDatasetList.Result.Data["+ i +"].Directory.Name");
				directory.PathId = _ctx.StringValue("QueryDatasetList.Result.Data["+ i +"].Directory.PathId");
				directory.PathName = _ctx.StringValue("QueryDatasetList.Result.Data["+ i +"].Directory.PathName");
				dataItem.Directory = directory;

				result_data.Add(dataItem);
			}
			result.Data = result_data;
			queryDatasetListResponse.Result = result;
        
			return queryDatasetListResponse;
        }
    }
}
