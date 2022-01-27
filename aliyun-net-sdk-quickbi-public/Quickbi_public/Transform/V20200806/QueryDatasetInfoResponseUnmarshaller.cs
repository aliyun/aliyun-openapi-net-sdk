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
using Aliyun.Acs.quickbi_public.Model.V20200806;

namespace Aliyun.Acs.quickbi_public.Transform.V20200806
{
    public class QueryDatasetInfoResponseUnmarshaller
    {
        public static QueryDatasetInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryDatasetInfoResponse queryDatasetInfoResponse = new QueryDatasetInfoResponse();

			queryDatasetInfoResponse.HttpResponse = _ctx.HttpResponse;
			queryDatasetInfoResponse.Success = _ctx.BooleanValue("QueryDatasetInfo.Success");
			queryDatasetInfoResponse.RequestId = _ctx.StringValue("QueryDatasetInfo.RequestId");

			QueryDatasetInfoResponse.QueryDatasetInfo_Result result = new QueryDatasetInfoResponse.QueryDatasetInfo_Result();
			result.GmtModify = _ctx.StringValue("QueryDatasetInfo.Result.GmtModify");
			result.DsName = _ctx.StringValue("QueryDatasetInfo.Result.DsName");
			result.DsId = _ctx.StringValue("QueryDatasetInfo.Result.DsId");
			result.OwnerName = _ctx.StringValue("QueryDatasetInfo.Result.OwnerName");
			result.WorkspaceName = _ctx.StringValue("QueryDatasetInfo.Result.WorkspaceName");
			result.OwnerId = _ctx.StringValue("QueryDatasetInfo.Result.OwnerId");
			result.DatasetName = _ctx.StringValue("QueryDatasetInfo.Result.DatasetName");
			result.RowLevel = _ctx.BooleanValue("QueryDatasetInfo.Result.RowLevel");
			result.WorkspaceId = _ctx.StringValue("QueryDatasetInfo.Result.WorkspaceId");
			result.CustimzeSql = _ctx.BooleanValue("QueryDatasetInfo.Result.CustimzeSql");
			result.GmtCreate = _ctx.StringValue("QueryDatasetInfo.Result.GmtCreate");
			result.DsType = _ctx.StringValue("QueryDatasetInfo.Result.DsType");
			result.DatasetId = _ctx.StringValue("QueryDatasetInfo.Result.DatasetId");

			QueryDatasetInfoResponse.QueryDatasetInfo_Result.QueryDatasetInfo_Directory directory = new QueryDatasetInfoResponse.QueryDatasetInfo_Result.QueryDatasetInfo_Directory();
			directory.PathId = _ctx.StringValue("QueryDatasetInfo.Result.Directory.PathId");
			directory.PathName = _ctx.StringValue("QueryDatasetInfo.Result.Directory.PathName");
			directory.Name = _ctx.StringValue("QueryDatasetInfo.Result.Directory.Name");
			directory.Id = _ctx.StringValue("QueryDatasetInfo.Result.Directory.Id");
			result.Directory = directory;

			List<QueryDatasetInfoResponse.QueryDatasetInfo_Result.QueryDatasetInfo_CubeTableListItem> result_cubeTableList = new List<QueryDatasetInfoResponse.QueryDatasetInfo_Result.QueryDatasetInfo_CubeTableListItem>();
			for (int i = 0; i < _ctx.Length("QueryDatasetInfo.Result.CubeTableList.Length"); i++) {
				QueryDatasetInfoResponse.QueryDatasetInfo_Result.QueryDatasetInfo_CubeTableListItem cubeTableListItem = new QueryDatasetInfoResponse.QueryDatasetInfo_Result.QueryDatasetInfo_CubeTableListItem();
				cubeTableListItem.TableName = _ctx.StringValue("QueryDatasetInfo.Result.CubeTableList["+ i +"].TableName");
				cubeTableListItem.DatasourceId = _ctx.StringValue("QueryDatasetInfo.Result.CubeTableList["+ i +"].DatasourceId");
				cubeTableListItem.DsType = _ctx.StringValue("QueryDatasetInfo.Result.CubeTableList["+ i +"].DsType");
				cubeTableListItem.UniqueId = _ctx.StringValue("QueryDatasetInfo.Result.CubeTableList["+ i +"].UniqueId");
				cubeTableListItem.FactTable = _ctx.BooleanValue("QueryDatasetInfo.Result.CubeTableList["+ i +"].FactTable");
				cubeTableListItem.Caption = _ctx.StringValue("QueryDatasetInfo.Result.CubeTableList["+ i +"].Caption");
				cubeTableListItem.Customsql = _ctx.BooleanValue("QueryDatasetInfo.Result.CubeTableList["+ i +"].Customsql");
				cubeTableListItem.Sql = _ctx.StringValue("QueryDatasetInfo.Result.CubeTableList["+ i +"].Sql");

				result_cubeTableList.Add(cubeTableListItem);
			}
			result.CubeTableList = result_cubeTableList;

			List<QueryDatasetInfoResponse.QueryDatasetInfo_Result.QueryDatasetInfo_DimensionListItem> result_dimensionList = new List<QueryDatasetInfoResponse.QueryDatasetInfo_Result.QueryDatasetInfo_DimensionListItem>();
			for (int i = 0; i < _ctx.Length("QueryDatasetInfo.Result.DimensionList.Length"); i++) {
				QueryDatasetInfoResponse.QueryDatasetInfo_Result.QueryDatasetInfo_DimensionListItem dimensionListItem = new QueryDatasetInfoResponse.QueryDatasetInfo_Result.QueryDatasetInfo_DimensionListItem();
				dimensionListItem.DataType = _ctx.StringValue("QueryDatasetInfo.Result.DimensionList["+ i +"].DataType");
				dimensionListItem.Expression = _ctx.StringValue("QueryDatasetInfo.Result.DimensionList["+ i +"].Expression");
				dimensionListItem.FactColumn = _ctx.StringValue("QueryDatasetInfo.Result.DimensionList["+ i +"].FactColumn");
				dimensionListItem.DimensionType = _ctx.StringValue("QueryDatasetInfo.Result.DimensionList["+ i +"].DimensionType");
				dimensionListItem.Granularity = _ctx.StringValue("QueryDatasetInfo.Result.DimensionList["+ i +"].Granularity");
				dimensionListItem.RefUid = _ctx.StringValue("QueryDatasetInfo.Result.DimensionList["+ i +"].RefUid");
				dimensionListItem.Caption = _ctx.StringValue("QueryDatasetInfo.Result.DimensionList["+ i +"].Caption");
				dimensionListItem.Uid = _ctx.StringValue("QueryDatasetInfo.Result.DimensionList["+ i +"].Uid");
				dimensionListItem.TableUniqueId = _ctx.StringValue("QueryDatasetInfo.Result.DimensionList["+ i +"].TableUniqueId");

				result_dimensionList.Add(dimensionListItem);
			}
			result.DimensionList = result_dimensionList;

			List<QueryDatasetInfoResponse.QueryDatasetInfo_Result.QueryDatasetInfo_MeasureListItem> result_measureList = new List<QueryDatasetInfoResponse.QueryDatasetInfo_Result.QueryDatasetInfo_MeasureListItem>();
			for (int i = 0; i < _ctx.Length("QueryDatasetInfo.Result.MeasureList.Length"); i++) {
				QueryDatasetInfoResponse.QueryDatasetInfo_Result.QueryDatasetInfo_MeasureListItem measureListItem = new QueryDatasetInfoResponse.QueryDatasetInfo_Result.QueryDatasetInfo_MeasureListItem();
				measureListItem.DataType = _ctx.StringValue("QueryDatasetInfo.Result.MeasureList["+ i +"].DataType");
				measureListItem.Expression = _ctx.StringValue("QueryDatasetInfo.Result.MeasureList["+ i +"].Expression");
				measureListItem.MeasureType = _ctx.StringValue("QueryDatasetInfo.Result.MeasureList["+ i +"].MeasureType");
				measureListItem.FactColumn = _ctx.StringValue("QueryDatasetInfo.Result.MeasureList["+ i +"].FactColumn");
				measureListItem.Caption = _ctx.StringValue("QueryDatasetInfo.Result.MeasureList["+ i +"].Caption");
				measureListItem.TableUniqueId = _ctx.StringValue("QueryDatasetInfo.Result.MeasureList["+ i +"].TableUniqueId");
				measureListItem.Uid = _ctx.StringValue("QueryDatasetInfo.Result.MeasureList["+ i +"].Uid");

				result_measureList.Add(measureListItem);
			}
			result.MeasureList = result_measureList;
			queryDatasetInfoResponse.Result = result;
        
			return queryDatasetInfoResponse;
        }
    }
}
