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
    public class QueryDatasetInfoResponseUnmarshaller
    {
        public static QueryDatasetInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryDatasetInfoResponse queryDatasetInfoResponse = new QueryDatasetInfoResponse();

			queryDatasetInfoResponse.HttpResponse = _ctx.HttpResponse;
			queryDatasetInfoResponse.RequestId = _ctx.StringValue("QueryDatasetInfo.RequestId");
			queryDatasetInfoResponse.Success = _ctx.BooleanValue("QueryDatasetInfo.Success");

			QueryDatasetInfoResponse.QueryDatasetInfo_Result result = new QueryDatasetInfoResponse.QueryDatasetInfo_Result();
			result.OpenOfflineAcceleration = _ctx.BooleanValue("QueryDatasetInfo.Result.OpenOfflineAcceleration");
			result.OwnerName = _ctx.StringValue("QueryDatasetInfo.Result.OwnerName");
			result.WorkspaceId = _ctx.StringValue("QueryDatasetInfo.Result.WorkspaceId");
			result.RowLevel = _ctx.BooleanValue("QueryDatasetInfo.Result.RowLevel");
			result.CustimzeSql = _ctx.BooleanValue("QueryDatasetInfo.Result.CustimzeSql");
			result.DsId = _ctx.StringValue("QueryDatasetInfo.Result.DsId");
			result.DatasetId = _ctx.StringValue("QueryDatasetInfo.Result.DatasetId");
			result.DsType = _ctx.StringValue("QueryDatasetInfo.Result.DsType");
			result.GmtCreate = _ctx.StringValue("QueryDatasetInfo.Result.GmtCreate");
			result.OwnerId = _ctx.StringValue("QueryDatasetInfo.Result.OwnerId");
			result.DatasetName = _ctx.StringValue("QueryDatasetInfo.Result.DatasetName");
			result.GmtModify = _ctx.StringValue("QueryDatasetInfo.Result.GmtModify");
			result.DsName = _ctx.StringValue("QueryDatasetInfo.Result.DsName");
			result.WorkspaceName = _ctx.StringValue("QueryDatasetInfo.Result.WorkspaceName");

			QueryDatasetInfoResponse.QueryDatasetInfo_Result.QueryDatasetInfo_Directory directory = new QueryDatasetInfoResponse.QueryDatasetInfo_Result.QueryDatasetInfo_Directory();
			directory.PathId = _ctx.StringValue("QueryDatasetInfo.Result.Directory.PathId");
			directory.Id = _ctx.StringValue("QueryDatasetInfo.Result.Directory.Id");
			directory.PathName = _ctx.StringValue("QueryDatasetInfo.Result.Directory.PathName");
			directory.Name = _ctx.StringValue("QueryDatasetInfo.Result.Directory.Name");
			result.Directory = directory;

			List<QueryDatasetInfoResponse.QueryDatasetInfo_Result.QueryDatasetInfo_MeasureListItem> result_measureList = new List<QueryDatasetInfoResponse.QueryDatasetInfo_Result.QueryDatasetInfo_MeasureListItem>();
			for (int i = 0; i < _ctx.Length("QueryDatasetInfo.Result.MeasureList.Length"); i++) {
				QueryDatasetInfoResponse.QueryDatasetInfo_Result.QueryDatasetInfo_MeasureListItem measureListItem = new QueryDatasetInfoResponse.QueryDatasetInfo_Result.QueryDatasetInfo_MeasureListItem();
				measureListItem.Uid = _ctx.StringValue("QueryDatasetInfo.Result.MeasureList["+ i +"].Uid");
				measureListItem.Expression = _ctx.StringValue("QueryDatasetInfo.Result.MeasureList["+ i +"].Expression");
				measureListItem.ExpressionV2 = _ctx.StringValue("QueryDatasetInfo.Result.MeasureList["+ i +"].ExpressionV2");
				measureListItem.DataType = _ctx.StringValue("QueryDatasetInfo.Result.MeasureList["+ i +"].DataType");
				measureListItem.MeasureType = _ctx.StringValue("QueryDatasetInfo.Result.MeasureList["+ i +"].MeasureType");
				measureListItem.TableUniqueId = _ctx.StringValue("QueryDatasetInfo.Result.MeasureList["+ i +"].TableUniqueId");
				measureListItem.Caption = _ctx.StringValue("QueryDatasetInfo.Result.MeasureList["+ i +"].Caption");
				measureListItem.FieldDescription = _ctx.StringValue("QueryDatasetInfo.Result.MeasureList["+ i +"].FieldDescription");
				measureListItem.FactColumn = _ctx.StringValue("QueryDatasetInfo.Result.MeasureList["+ i +"].FactColumn");

				result_measureList.Add(measureListItem);
			}
			result.MeasureList = result_measureList;

			List<QueryDatasetInfoResponse.QueryDatasetInfo_Result.QueryDatasetInfo_DimensionListItem> result_dimensionList = new List<QueryDatasetInfoResponse.QueryDatasetInfo_Result.QueryDatasetInfo_DimensionListItem>();
			for (int i = 0; i < _ctx.Length("QueryDatasetInfo.Result.DimensionList.Length"); i++) {
				QueryDatasetInfoResponse.QueryDatasetInfo_Result.QueryDatasetInfo_DimensionListItem dimensionListItem = new QueryDatasetInfoResponse.QueryDatasetInfo_Result.QueryDatasetInfo_DimensionListItem();
				dimensionListItem.DimensionType = _ctx.StringValue("QueryDatasetInfo.Result.DimensionList["+ i +"].DimensionType");
				dimensionListItem.RefUid = _ctx.StringValue("QueryDatasetInfo.Result.DimensionList["+ i +"].RefUid");
				dimensionListItem.Uid = _ctx.StringValue("QueryDatasetInfo.Result.DimensionList["+ i +"].Uid");
				dimensionListItem.Expression = _ctx.StringValue("QueryDatasetInfo.Result.DimensionList["+ i +"].Expression");
				dimensionListItem.ExpressionV2 = _ctx.StringValue("QueryDatasetInfo.Result.DimensionList["+ i +"].ExpressionV2");
				dimensionListItem.DataType = _ctx.StringValue("QueryDatasetInfo.Result.DimensionList["+ i +"].DataType");
				dimensionListItem.TableUniqueId = _ctx.StringValue("QueryDatasetInfo.Result.DimensionList["+ i +"].TableUniqueId");
				dimensionListItem.Granularity = _ctx.StringValue("QueryDatasetInfo.Result.DimensionList["+ i +"].Granularity");
				dimensionListItem.Caption = _ctx.StringValue("QueryDatasetInfo.Result.DimensionList["+ i +"].Caption");
				dimensionListItem.FieldDescription = _ctx.StringValue("QueryDatasetInfo.Result.DimensionList["+ i +"].FieldDescription");
				dimensionListItem.FactColumn = _ctx.StringValue("QueryDatasetInfo.Result.DimensionList["+ i +"].FactColumn");

				result_dimensionList.Add(dimensionListItem);
			}
			result.DimensionList = result_dimensionList;

			List<QueryDatasetInfoResponse.QueryDatasetInfo_Result.QueryDatasetInfo_CubeTableListItem> result_cubeTableList = new List<QueryDatasetInfoResponse.QueryDatasetInfo_Result.QueryDatasetInfo_CubeTableListItem>();
			for (int i = 0; i < _ctx.Length("QueryDatasetInfo.Result.CubeTableList.Length"); i++) {
				QueryDatasetInfoResponse.QueryDatasetInfo_Result.QueryDatasetInfo_CubeTableListItem cubeTableListItem = new QueryDatasetInfoResponse.QueryDatasetInfo_Result.QueryDatasetInfo_CubeTableListItem();
				cubeTableListItem.TableName = _ctx.StringValue("QueryDatasetInfo.Result.CubeTableList["+ i +"].TableName");
				cubeTableListItem.UniqueId = _ctx.StringValue("QueryDatasetInfo.Result.CubeTableList["+ i +"].UniqueId");
				cubeTableListItem.FactTable = _ctx.BooleanValue("QueryDatasetInfo.Result.CubeTableList["+ i +"].FactTable");
				cubeTableListItem.DatasourceId = _ctx.StringValue("QueryDatasetInfo.Result.CubeTableList["+ i +"].DatasourceId");
				cubeTableListItem.Customsql = _ctx.BooleanValue("QueryDatasetInfo.Result.CubeTableList["+ i +"].Customsql");
				cubeTableListItem.Caption = _ctx.StringValue("QueryDatasetInfo.Result.CubeTableList["+ i +"].Caption");
				cubeTableListItem.DsType = _ctx.StringValue("QueryDatasetInfo.Result.CubeTableList["+ i +"].DsType");
				cubeTableListItem.Sql = _ctx.StringValue("QueryDatasetInfo.Result.CubeTableList["+ i +"].Sql");

				result_cubeTableList.Add(cubeTableListItem);
			}
			result.CubeTableList = result_cubeTableList;
			queryDatasetInfoResponse.Result = result;
        
			return queryDatasetInfoResponse;
        }
    }
}
