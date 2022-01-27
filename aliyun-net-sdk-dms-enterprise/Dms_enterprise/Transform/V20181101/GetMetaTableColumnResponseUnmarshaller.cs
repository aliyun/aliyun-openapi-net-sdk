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
using Aliyun.Acs.dms_enterprise.Model.V20181101;

namespace Aliyun.Acs.dms_enterprise.Transform.V20181101
{
    public class GetMetaTableColumnResponseUnmarshaller
    {
        public static GetMetaTableColumnResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetMetaTableColumnResponse getMetaTableColumnResponse = new GetMetaTableColumnResponse();

			getMetaTableColumnResponse.HttpResponse = _ctx.HttpResponse;
			getMetaTableColumnResponse.RequestId = _ctx.StringValue("GetMetaTableColumn.RequestId");
			getMetaTableColumnResponse.ErrorCode = _ctx.StringValue("GetMetaTableColumn.ErrorCode");
			getMetaTableColumnResponse.ErrorMessage = _ctx.StringValue("GetMetaTableColumn.ErrorMessage");
			getMetaTableColumnResponse.Success = _ctx.BooleanValue("GetMetaTableColumn.Success");

			List<GetMetaTableColumnResponse.GetMetaTableColumn_Column> getMetaTableColumnResponse_columnList = new List<GetMetaTableColumnResponse.GetMetaTableColumn_Column>();
			for (int i = 0; i < _ctx.Length("GetMetaTableColumn.ColumnList.Length"); i++) {
				GetMetaTableColumnResponse.GetMetaTableColumn_Column column = new GetMetaTableColumnResponse.GetMetaTableColumn_Column();
				column.ColumnType = _ctx.StringValue("GetMetaTableColumn.ColumnList["+ i +"].ColumnType");
				column.AutoIncrement = _ctx.BooleanValue("GetMetaTableColumn.ColumnList["+ i +"].AutoIncrement");
				column.ColumnId = _ctx.StringValue("GetMetaTableColumn.ColumnList["+ i +"].ColumnId");
				column.ColumnName = _ctx.StringValue("GetMetaTableColumn.ColumnList["+ i +"].ColumnName");
				column.SecurityLevel = _ctx.StringValue("GetMetaTableColumn.ColumnList["+ i +"].SecurityLevel");
				column.PrimaryKey = _ctx.StringValue("GetMetaTableColumn.ColumnList["+ i +"].PrimaryKey");
				column.Description = _ctx.StringValue("GetMetaTableColumn.ColumnList["+ i +"].Description");
				column.DataPrecision = _ctx.IntegerValue("GetMetaTableColumn.ColumnList["+ i +"].DataPrecision");
				column.DataScale = _ctx.IntegerValue("GetMetaTableColumn.ColumnList["+ i +"].DataScale");
				column.Position = _ctx.IntegerValue("GetMetaTableColumn.ColumnList["+ i +"].Position");
				column.Nullable = _ctx.BooleanValue("GetMetaTableColumn.ColumnList["+ i +"].Nullable");
				column.DataLength = _ctx.LongValue("GetMetaTableColumn.ColumnList["+ i +"].DataLength");

				getMetaTableColumnResponse_columnList.Add(column);
			}
			getMetaTableColumnResponse.ColumnList = getMetaTableColumnResponse_columnList;
        
			return getMetaTableColumnResponse;
        }
    }
}
