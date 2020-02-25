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
        public static ListColumnsResponse Unmarshall(UnmarshallerContext context)
        {
			ListColumnsResponse listColumnsResponse = new ListColumnsResponse();

			listColumnsResponse.HttpResponse = context.HttpResponse;
			listColumnsResponse.RequestId = context.StringValue("ListColumns.RequestId");
			listColumnsResponse.Success = context.BooleanValue("ListColumns.Success");
			listColumnsResponse.ErrorMessage = context.StringValue("ListColumns.ErrorMessage");
			listColumnsResponse.ErrorCode = context.StringValue("ListColumns.ErrorCode");

			List<ListColumnsResponse.ListColumns_Column> listColumnsResponse_columnList = new List<ListColumnsResponse.ListColumns_Column>();
			for (int i = 0; i < context.Length("ListColumns.ColumnList.Length"); i++) {
				ListColumnsResponse.ListColumns_Column column = new ListColumnsResponse.ListColumns_Column();
				column.ColumnId = context.StringValue("ListColumns.ColumnList["+ i +"].ColumnId");
				column.ColumnName = context.StringValue("ListColumns.ColumnList["+ i +"].ColumnName");
				column.ColumnType = context.StringValue("ListColumns.ColumnList["+ i +"].ColumnType");
				column.Nullable = context.BooleanValue("ListColumns.ColumnList["+ i +"].Nullable");
				column.DefaultValue = context.StringValue("ListColumns.ColumnList["+ i +"].DefaultValue");
				column.AutoIncrement = context.BooleanValue("ListColumns.ColumnList["+ i +"].AutoIncrement");
				column.Description = context.StringValue("ListColumns.ColumnList["+ i +"].Description");
				column.SecurityLevel = context.StringValue("ListColumns.ColumnList["+ i +"].SecurityLevel");
				column.FunctionType = context.StringValue("ListColumns.ColumnList["+ i +"].FunctionType");
				column.DataLength = context.LongValue("ListColumns.ColumnList["+ i +"].DataLength");
				column.Sensitive = context.BooleanValue("ListColumns.ColumnList["+ i +"].Sensitive");
				column.DataPrecision = context.IntegerValue("ListColumns.ColumnList["+ i +"].DataPrecision");
				column.DataScale = context.IntegerValue("ListColumns.ColumnList["+ i +"].DataScale");

				listColumnsResponse_columnList.Add(column);
			}
			listColumnsResponse.ColumnList = listColumnsResponse_columnList;
        
			return listColumnsResponse;
        }
    }
}
