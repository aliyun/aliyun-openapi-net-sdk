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
        public static GetMetaTableColumnResponse Unmarshall(UnmarshallerContext context)
        {
			GetMetaTableColumnResponse getMetaTableColumnResponse = new GetMetaTableColumnResponse();

			getMetaTableColumnResponse.HttpResponse = context.HttpResponse;
			getMetaTableColumnResponse.RequestId = context.StringValue("GetMetaTableColumn.RequestId");
			getMetaTableColumnResponse.ErrorCode = context.StringValue("GetMetaTableColumn.ErrorCode");
			getMetaTableColumnResponse.ErrorMessage = context.StringValue("GetMetaTableColumn.ErrorMessage");
			getMetaTableColumnResponse.HttpStatusCode = context.IntegerValue("GetMetaTableColumn.HttpStatusCode");
			getMetaTableColumnResponse.Success = context.BooleanValue("GetMetaTableColumn.Success");

			GetMetaTableColumnResponse.GetMetaTableColumn_Data data = new GetMetaTableColumnResponse.GetMetaTableColumn_Data();
			data.TotalCount = context.LongValue("GetMetaTableColumn.Data.TotalCount");
			data.PageNum = context.IntegerValue("GetMetaTableColumn.Data.PageNum");
			data.PageSize = context.IntegerValue("GetMetaTableColumn.Data.PageSize");

			List<GetMetaTableColumnResponse.GetMetaTableColumn_Data.GetMetaTableColumn_ColumnListItem> data_columnList = new List<GetMetaTableColumnResponse.GetMetaTableColumn_Data.GetMetaTableColumn_ColumnListItem>();
			for (int i = 0; i < context.Length("GetMetaTableColumn.Data.ColumnList.Length"); i++) {
				GetMetaTableColumnResponse.GetMetaTableColumn_Data.GetMetaTableColumn_ColumnListItem columnListItem = new GetMetaTableColumnResponse.GetMetaTableColumn_Data.GetMetaTableColumn_ColumnListItem();
				columnListItem.ColumnName = context.StringValue("GetMetaTableColumn.Data.ColumnList["+ i +"].ColumnName");
				columnListItem.ColumnGuid = context.StringValue("GetMetaTableColumn.Data.ColumnList["+ i +"].ColumnGuid");
				columnListItem.Comment = context.StringValue("GetMetaTableColumn.Data.ColumnList["+ i +"].Comment");
				columnListItem.IsPrimaryKey = context.BooleanValue("GetMetaTableColumn.Data.ColumnList["+ i +"].IsPrimaryKey");
				columnListItem.ColumnType = context.StringValue("GetMetaTableColumn.Data.ColumnList["+ i +"].ColumnType");
				columnListItem.IsPartitionColumn = context.BooleanValue("GetMetaTableColumn.Data.ColumnList["+ i +"].IsPartitionColumn");
				columnListItem.IsForeignKey = context.BooleanValue("GetMetaTableColumn.Data.ColumnList["+ i +"].IsForeignKey");
				columnListItem.Caption = context.StringValue("GetMetaTableColumn.Data.ColumnList["+ i +"].Caption");

				data_columnList.Add(columnListItem);
			}
			data.ColumnList = data_columnList;
			getMetaTableColumnResponse.Data = data;
        
			return getMetaTableColumnResponse;
        }
    }
}
