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
        public static GetMetaTableColumnResponse Unmarshall(UnmarshallerContext context)
        {
			GetMetaTableColumnResponse getMetaTableColumnResponse = new GetMetaTableColumnResponse();

			getMetaTableColumnResponse.HttpResponse = context.HttpResponse;
			getMetaTableColumnResponse.RequestId = context.StringValue("GetMetaTableColumn.RequestId");
			getMetaTableColumnResponse.Success = context.BooleanValue("GetMetaTableColumn.Success");
			getMetaTableColumnResponse.ErrorMessage = context.StringValue("GetMetaTableColumn.ErrorMessage");
			getMetaTableColumnResponse.ErrorCode = context.StringValue("GetMetaTableColumn.ErrorCode");

			List<GetMetaTableColumnResponse.GetMetaTableColumn_Column> getMetaTableColumnResponse_columnList = new List<GetMetaTableColumnResponse.GetMetaTableColumn_Column>();
			for (int i = 0; i < context.Length("GetMetaTableColumn.ColumnList.Length"); i++) {
				GetMetaTableColumnResponse.GetMetaTableColumn_Column column = new GetMetaTableColumnResponse.GetMetaTableColumn_Column();
				column.ColumnId = context.StringValue("GetMetaTableColumn.ColumnList["+ i +"].ColumnId");
				column.ColumnName = context.StringValue("GetMetaTableColumn.ColumnList["+ i +"].ColumnName");
				column.ColumnType = context.StringValue("GetMetaTableColumn.ColumnList["+ i +"].ColumnType");
				column.DataLength = context.IntegerValue("GetMetaTableColumn.ColumnList["+ i +"].DataLength");
				column.Description = context.StringValue("GetMetaTableColumn.ColumnList["+ i +"].Description");
				column.Position = context.IntegerValue("GetMetaTableColumn.ColumnList["+ i +"].Position");
				column.AutoIncrement = context.BooleanValue("GetMetaTableColumn.ColumnList["+ i +"].AutoIncrement");
				column.Nullable = context.BooleanValue("GetMetaTableColumn.ColumnList["+ i +"].Nullable");
				column.SecurityLevel = context.StringValue("GetMetaTableColumn.ColumnList["+ i +"].SecurityLevel");
				column.PrimaryKey = context.StringValue("GetMetaTableColumn.ColumnList["+ i +"].PrimaryKey");
				column.DataScale = context.IntegerValue("GetMetaTableColumn.ColumnList["+ i +"].DataScale");
				column.DataPrecision = context.IntegerValue("GetMetaTableColumn.ColumnList["+ i +"].DataPrecision");

				getMetaTableColumnResponse_columnList.Add(column);
			}
			getMetaTableColumnResponse.ColumnList = getMetaTableColumnResponse_columnList;
        
			return getMetaTableColumnResponse;
        }
    }
}
