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
    public class ListColumnsResponseUnmarshaller
    {
        public static ListColumnsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListColumnsResponse listColumnsResponse = new ListColumnsResponse();

			listColumnsResponse.HttpResponse = _ctx.HttpResponse;
			listColumnsResponse.RequestId = _ctx.StringValue("ListColumns.RequestId");
			listColumnsResponse.ErrorCode = _ctx.StringValue("ListColumns.ErrorCode");
			listColumnsResponse.ErrorMessage = _ctx.StringValue("ListColumns.ErrorMessage");
			listColumnsResponse.Success = _ctx.BooleanValue("ListColumns.Success");

			List<ListColumnsResponse.ListColumns_Column> listColumnsResponse_columnList = new List<ListColumnsResponse.ListColumns_Column>();
			for (int i = 0; i < _ctx.Length("ListColumns.ColumnList.Length"); i++) {
				ListColumnsResponse.ListColumns_Column column = new ListColumnsResponse.ListColumns_Column();
				column.ColumnType = _ctx.StringValue("ListColumns.ColumnList["+ i +"].ColumnType");
				column.AutoIncrement = _ctx.BooleanValue("ListColumns.ColumnList["+ i +"].AutoIncrement");
				column.ColumnId = _ctx.StringValue("ListColumns.ColumnList["+ i +"].ColumnId");
				column.DefaultValue = _ctx.StringValue("ListColumns.ColumnList["+ i +"].DefaultValue");
				column.Sensitive = _ctx.BooleanValue("ListColumns.ColumnList["+ i +"].Sensitive");
				column.ColumnName = _ctx.StringValue("ListColumns.ColumnList["+ i +"].ColumnName");
				column.SecurityLevel = _ctx.StringValue("ListColumns.ColumnList["+ i +"].SecurityLevel");
				column.Description = _ctx.StringValue("ListColumns.ColumnList["+ i +"].Description");
				column.DataPrecision = _ctx.IntegerValue("ListColumns.ColumnList["+ i +"].DataPrecision");
				column.DataScale = _ctx.IntegerValue("ListColumns.ColumnList["+ i +"].DataScale");
				column.FunctionType = _ctx.StringValue("ListColumns.ColumnList["+ i +"].FunctionType");
				column.Nullable = _ctx.BooleanValue("ListColumns.ColumnList["+ i +"].Nullable");
				column.DataLength = _ctx.LongValue("ListColumns.ColumnList["+ i +"].DataLength");

				listColumnsResponse_columnList.Add(column);
			}
			listColumnsResponse.ColumnList = listColumnsResponse_columnList;
        
			return listColumnsResponse;
        }
    }
}
