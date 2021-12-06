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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class GetMetaTableColumnResponseUnmarshaller
    {
        public static GetMetaTableColumnResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetMetaTableColumnResponse getMetaTableColumnResponse = new GetMetaTableColumnResponse();

			getMetaTableColumnResponse.HttpResponse = _ctx.HttpResponse;
			getMetaTableColumnResponse.HttpStatusCode = _ctx.IntegerValue("GetMetaTableColumn.HttpStatusCode");
			getMetaTableColumnResponse.ErrorMessage = _ctx.StringValue("GetMetaTableColumn.ErrorMessage");
			getMetaTableColumnResponse.RequestId = _ctx.StringValue("GetMetaTableColumn.RequestId");
			getMetaTableColumnResponse.Success = _ctx.BooleanValue("GetMetaTableColumn.Success");
			getMetaTableColumnResponse.ErrorCode = _ctx.StringValue("GetMetaTableColumn.ErrorCode");

			GetMetaTableColumnResponse.GetMetaTableColumn_Data data = new GetMetaTableColumnResponse.GetMetaTableColumn_Data();
			data.PageNum = _ctx.IntegerValue("GetMetaTableColumn.Data.PageNum");
			data.PageSize = _ctx.IntegerValue("GetMetaTableColumn.Data.PageSize");
			data.TotalCount = _ctx.LongValue("GetMetaTableColumn.Data.TotalCount");

			List<GetMetaTableColumnResponse.GetMetaTableColumn_Data.GetMetaTableColumn_ColumnListItem> data_columnList = new List<GetMetaTableColumnResponse.GetMetaTableColumn_Data.GetMetaTableColumn_ColumnListItem>();
			for (int i = 0; i < _ctx.Length("GetMetaTableColumn.Data.ColumnList.Length"); i++) {
				GetMetaTableColumnResponse.GetMetaTableColumn_Data.GetMetaTableColumn_ColumnListItem columnListItem = new GetMetaTableColumnResponse.GetMetaTableColumn_Data.GetMetaTableColumn_ColumnListItem();
				columnListItem.ColumnGuid = _ctx.StringValue("GetMetaTableColumn.Data.ColumnList["+ i +"].ColumnGuid");
				columnListItem.ColumnName = _ctx.StringValue("GetMetaTableColumn.Data.ColumnList["+ i +"].ColumnName");
				columnListItem.IsPartitionColumn = _ctx.BooleanValue("GetMetaTableColumn.Data.ColumnList["+ i +"].IsPartitionColumn");
				columnListItem.Comment = _ctx.StringValue("GetMetaTableColumn.Data.ColumnList["+ i +"].Comment");
				columnListItem.ColumnType = _ctx.StringValue("GetMetaTableColumn.Data.ColumnList["+ i +"].ColumnType");
				columnListItem.IsPrimaryKey = _ctx.BooleanValue("GetMetaTableColumn.Data.ColumnList["+ i +"].IsPrimaryKey");
				columnListItem.Position = _ctx.IntegerValue("GetMetaTableColumn.Data.ColumnList["+ i +"].Position");
				columnListItem.Caption = _ctx.StringValue("GetMetaTableColumn.Data.ColumnList["+ i +"].Caption");
				columnListItem.IsForeignKey = _ctx.BooleanValue("GetMetaTableColumn.Data.ColumnList["+ i +"].IsForeignKey");
				columnListItem.RelationCount = _ctx.LongValue("GetMetaTableColumn.Data.ColumnList["+ i +"].RelationCount");

				data_columnList.Add(columnListItem);
			}
			data.ColumnList = data_columnList;
			getMetaTableColumnResponse.Data = data;
        
			return getMetaTableColumnResponse;
        }
    }
}
