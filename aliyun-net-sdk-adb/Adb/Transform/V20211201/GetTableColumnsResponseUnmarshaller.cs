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
using Aliyun.Acs.adb.Model.V20211201;

namespace Aliyun.Acs.adb.Transform.V20211201
{
    public class GetTableColumnsResponseUnmarshaller
    {
        public static GetTableColumnsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetTableColumnsResponse getTableColumnsResponse = new GetTableColumnsResponse();

			getTableColumnsResponse.HttpResponse = _ctx.HttpResponse;
			getTableColumnsResponse.RequestId = _ctx.StringValue("GetTableColumns.RequestId");
			getTableColumnsResponse.PageNumber = _ctx.LongValue("GetTableColumns.PageNumber");
			getTableColumnsResponse.PageSize = _ctx.LongValue("GetTableColumns.PageSize");
			getTableColumnsResponse.TotalCount = _ctx.LongValue("GetTableColumns.TotalCount");

			GetTableColumnsResponse.GetTableColumns_Data data = new GetTableColumnsResponse.GetTableColumns_Data();
			data.PageNumber = _ctx.LongValue("GetTableColumns.Data.PageNumber");
			data.PageSize = _ctx.LongValue("GetTableColumns.Data.PageSize");
			data.TotalCount = _ctx.LongValue("GetTableColumns.Data.TotalCount");

			GetTableColumnsResponse.GetTableColumns_Data.GetTableColumns_Table table = new GetTableColumnsResponse.GetTableColumns_Data.GetTableColumns_Table();
			table.SchemaName = _ctx.StringValue("GetTableColumns.Data.Table.SchemaName");
			table.TableName = _ctx.StringValue("GetTableColumns.Data.Table.TableName");
			table.TableType = _ctx.StringValue("GetTableColumns.Data.Table.TableType");
			table.CreateTime = _ctx.StringValue("GetTableColumns.Data.Table.CreateTime");
			table.UpdateTime = _ctx.StringValue("GetTableColumns.Data.Table.UpdateTime");
			table.Description = _ctx.StringValue("GetTableColumns.Data.Table.Description");
			table.Owner = _ctx.StringValue("GetTableColumns.Data.Table.Owner");
			table.Catalog = _ctx.StringValue("GetTableColumns.Data.Table.Catalog");

			List<GetTableColumnsResponse.GetTableColumns_Data.GetTableColumns_Table.GetTableColumns_ColumnsItem> table_columns = new List<GetTableColumnsResponse.GetTableColumns_Data.GetTableColumns_Table.GetTableColumns_ColumnsItem>();
			for (int i = 0; i < _ctx.Length("GetTableColumns.Data.Table.Columns.Length"); i++) {
				GetTableColumnsResponse.GetTableColumns_Data.GetTableColumns_Table.GetTableColumns_ColumnsItem columnsItem = new GetTableColumnsResponse.GetTableColumns_Data.GetTableColumns_Table.GetTableColumns_ColumnsItem();
				columnsItem.ColumnName = _ctx.StringValue("GetTableColumns.Data.Table.Columns["+ i +"].ColumnName");
				columnsItem.Type = _ctx.StringValue("GetTableColumns.Data.Table.Columns["+ i +"].Type");
				columnsItem.Description = _ctx.StringValue("GetTableColumns.Data.Table.Columns["+ i +"].Description");
				columnsItem.SchemaName = _ctx.StringValue("GetTableColumns.Data.Table.Columns["+ i +"].SchemaName");
				columnsItem.TableName = _ctx.StringValue("GetTableColumns.Data.Table.Columns["+ i +"].TableName");
				columnsItem.CreateTime = _ctx.StringValue("GetTableColumns.Data.Table.Columns["+ i +"].CreateTime");
				columnsItem.UpdateTime = _ctx.StringValue("GetTableColumns.Data.Table.Columns["+ i +"].UpdateTime");
				columnsItem.PartitionKey = _ctx.BooleanValue("GetTableColumns.Data.Table.Columns["+ i +"].PartitionKey");
				columnsItem.Nullable = _ctx.BooleanValue("GetTableColumns.Data.Table.Columns["+ i +"].Nullable");
				columnsItem.PrimaryKey = _ctx.BooleanValue("GetTableColumns.Data.Table.Columns["+ i +"].PrimaryKey");
				columnsItem.DistributeKey = _ctx.BooleanValue("GetTableColumns.Data.Table.Columns["+ i +"].DistributeKey");

				table_columns.Add(columnsItem);
			}
			table.Columns = table_columns;
			data.Table = table;
			getTableColumnsResponse.Data = data;
        
			return getTableColumnsResponse;
        }
    }
}
