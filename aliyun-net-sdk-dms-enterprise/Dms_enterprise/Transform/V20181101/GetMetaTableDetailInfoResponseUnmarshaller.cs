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
    public class GetMetaTableDetailInfoResponseUnmarshaller
    {
        public static GetMetaTableDetailInfoResponse Unmarshall(UnmarshallerContext context)
        {
			GetMetaTableDetailInfoResponse getMetaTableDetailInfoResponse = new GetMetaTableDetailInfoResponse();

			getMetaTableDetailInfoResponse.HttpResponse = context.HttpResponse;
			getMetaTableDetailInfoResponse.RequestId = context.StringValue("GetMetaTableDetailInfo.RequestId");
			getMetaTableDetailInfoResponse.Success = context.BooleanValue("GetMetaTableDetailInfo.Success");
			getMetaTableDetailInfoResponse.ErrorMessage = context.StringValue("GetMetaTableDetailInfo.ErrorMessage");
			getMetaTableDetailInfoResponse.ErrorCode = context.StringValue("GetMetaTableDetailInfo.ErrorCode");

			GetMetaTableDetailInfoResponse.GetMetaTableDetailInfo_DetailInfo detailInfo = new GetMetaTableDetailInfoResponse.GetMetaTableDetailInfo_DetailInfo();

			List<GetMetaTableDetailInfoResponse.GetMetaTableDetailInfo_DetailInfo.GetMetaTableDetailInfo_Column> detailInfo_columnList = new List<GetMetaTableDetailInfoResponse.GetMetaTableDetailInfo_DetailInfo.GetMetaTableDetailInfo_Column>();
			for (int i = 0; i < context.Length("GetMetaTableDetailInfo.DetailInfo.ColumnList.Length"); i++) {
				GetMetaTableDetailInfoResponse.GetMetaTableDetailInfo_DetailInfo.GetMetaTableDetailInfo_Column column = new GetMetaTableDetailInfoResponse.GetMetaTableDetailInfo_DetailInfo.GetMetaTableDetailInfo_Column();
				column.Description = context.StringValue("GetMetaTableDetailInfo.DetailInfo.ColumnList["+ i +"].Description");
				column.ColumnType = context.StringValue("GetMetaTableDetailInfo.DetailInfo.ColumnList["+ i +"].ColumnType");
				column.Position = context.StringValue("GetMetaTableDetailInfo.DetailInfo.ColumnList["+ i +"].Position");
				column.DataLength = context.IntegerValue("GetMetaTableDetailInfo.DetailInfo.ColumnList["+ i +"].DataLength");
				column.Nullable = context.BooleanValue("GetMetaTableDetailInfo.DetailInfo.ColumnList["+ i +"].Nullable");
				column.ColumnName = context.StringValue("GetMetaTableDetailInfo.DetailInfo.ColumnList["+ i +"].ColumnName");
				column.AutoIncrement = context.BooleanValue("GetMetaTableDetailInfo.DetailInfo.ColumnList["+ i +"].AutoIncrement");
				column.DataPrecision = context.IntegerValue("GetMetaTableDetailInfo.DetailInfo.ColumnList["+ i +"].DataPrecision");
				column.DataScale = context.IntegerValue("GetMetaTableDetailInfo.DetailInfo.ColumnList["+ i +"].DataScale");
				column.ColumnId = context.StringValue("GetMetaTableDetailInfo.DetailInfo.ColumnList["+ i +"].ColumnId");

				detailInfo_columnList.Add(column);
			}
			detailInfo.ColumnList = detailInfo_columnList;

			List<GetMetaTableDetailInfoResponse.GetMetaTableDetailInfo_DetailInfo.GetMetaTableDetailInfo_Index> detailInfo_indexList = new List<GetMetaTableDetailInfoResponse.GetMetaTableDetailInfo_DetailInfo.GetMetaTableDetailInfo_Index>();
			for (int i = 0; i < context.Length("GetMetaTableDetailInfo.DetailInfo.IndexList.Length"); i++) {
				GetMetaTableDetailInfoResponse.GetMetaTableDetailInfo_DetailInfo.GetMetaTableDetailInfo_Index index = new GetMetaTableDetailInfoResponse.GetMetaTableDetailInfo_DetailInfo.GetMetaTableDetailInfo_Index();
				index.IndexName = context.StringValue("GetMetaTableDetailInfo.DetailInfo.IndexList["+ i +"].IndexName");
				index.IndexType = context.StringValue("GetMetaTableDetailInfo.DetailInfo.IndexList["+ i +"].IndexType");
				index.Unique = context.BooleanValue("GetMetaTableDetailInfo.DetailInfo.IndexList["+ i +"].Unique");
				index.IndexId = context.StringValue("GetMetaTableDetailInfo.DetailInfo.IndexList["+ i +"].IndexId");

				List<string> index_indexColumns = new List<string>();
				for (int j = 0; j < context.Length("GetMetaTableDetailInfo.DetailInfo.IndexList["+ i +"].IndexColumns.Length"); j++) {
					index_indexColumns.Add(context.StringValue("GetMetaTableDetailInfo.DetailInfo.IndexList["+ i +"].IndexColumns["+ j +"]"));
				}
				index.IndexColumns = index_indexColumns;

				detailInfo_indexList.Add(index);
			}
			detailInfo.IndexList = detailInfo_indexList;
			getMetaTableDetailInfoResponse.DetailInfo = detailInfo;
        
			return getMetaTableDetailInfoResponse;
        }
    }
}
