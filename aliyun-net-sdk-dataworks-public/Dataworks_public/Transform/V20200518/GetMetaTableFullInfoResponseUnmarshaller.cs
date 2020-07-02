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
    public class GetMetaTableFullInfoResponseUnmarshaller
    {
        public static GetMetaTableFullInfoResponse Unmarshall(UnmarshallerContext context)
        {
			GetMetaTableFullInfoResponse getMetaTableFullInfoResponse = new GetMetaTableFullInfoResponse();

			getMetaTableFullInfoResponse.HttpResponse = context.HttpResponse;
			getMetaTableFullInfoResponse.RequestId = context.StringValue("GetMetaTableFullInfo.RequestId");
			getMetaTableFullInfoResponse.ErrorCode = context.StringValue("GetMetaTableFullInfo.ErrorCode");
			getMetaTableFullInfoResponse.ErrorMessage = context.StringValue("GetMetaTableFullInfo.ErrorMessage");
			getMetaTableFullInfoResponse.HttpStatusCode = context.IntegerValue("GetMetaTableFullInfo.HttpStatusCode");
			getMetaTableFullInfoResponse.Success = context.BooleanValue("GetMetaTableFullInfo.Success");

			GetMetaTableFullInfoResponse.GetMetaTableFullInfo_Data data = new GetMetaTableFullInfoResponse.GetMetaTableFullInfo_Data();
			data.TableName = context.StringValue("GetMetaTableFullInfo.Data.TableName");
			data.TableGuid = context.StringValue("GetMetaTableFullInfo.Data.TableGuid");
			data.OwnerId = context.StringValue("GetMetaTableFullInfo.Data.OwnerId");
			data.TenantId = context.LongValue("GetMetaTableFullInfo.Data.TenantId");
			data.ProjectId = context.LongValue("GetMetaTableFullInfo.Data.ProjectId");
			data.CreateTime = context.LongValue("GetMetaTableFullInfo.Data.CreateTime");
			data.LastModifyTime = context.LongValue("GetMetaTableFullInfo.Data.LastModifyTime");
			data.LifeCycle = context.IntegerValue("GetMetaTableFullInfo.Data.LifeCycle");
			data.IsVisible = context.IntegerValue("GetMetaTableFullInfo.Data.IsVisible");
			data.ProjectName = context.StringValue("GetMetaTableFullInfo.Data.ProjectName");
			data.DataSize = context.LongValue("GetMetaTableFullInfo.Data.DataSize");
			data.EnvType = context.IntegerValue("GetMetaTableFullInfo.Data.EnvType");
			data.Comment = context.StringValue("GetMetaTableFullInfo.Data.Comment");
			data.TotalColumnCount = context.LongValue("GetMetaTableFullInfo.Data.TotalColumnCount");
			data.LastDdlTime = context.LongValue("GetMetaTableFullInfo.Data.LastDdlTime");
			data.LastAccessTime = context.LongValue("GetMetaTableFullInfo.Data.LastAccessTime");

			List<GetMetaTableFullInfoResponse.GetMetaTableFullInfo_Data.GetMetaTableFullInfo_ColumnListItem> data_columnList = new List<GetMetaTableFullInfoResponse.GetMetaTableFullInfo_Data.GetMetaTableFullInfo_ColumnListItem>();
			for (int i = 0; i < context.Length("GetMetaTableFullInfo.Data.ColumnList.Length"); i++) {
				GetMetaTableFullInfoResponse.GetMetaTableFullInfo_Data.GetMetaTableFullInfo_ColumnListItem columnListItem = new GetMetaTableFullInfoResponse.GetMetaTableFullInfo_Data.GetMetaTableFullInfo_ColumnListItem();
				columnListItem.ColumnGuid = context.StringValue("GetMetaTableFullInfo.Data.ColumnList["+ i +"].ColumnGuid");
				columnListItem.ColumnName = context.StringValue("GetMetaTableFullInfo.Data.ColumnList["+ i +"].ColumnName");
				columnListItem.ColumnType = context.StringValue("GetMetaTableFullInfo.Data.ColumnList["+ i +"].ColumnType");
				columnListItem.IsPrimaryKey = context.BooleanValue("GetMetaTableFullInfo.Data.ColumnList["+ i +"].IsPrimaryKey");
				columnListItem.Comment = context.StringValue("GetMetaTableFullInfo.Data.ColumnList["+ i +"].Comment");
				columnListItem.IsPartitionColumn = context.BooleanValue("GetMetaTableFullInfo.Data.ColumnList["+ i +"].IsPartitionColumn");
				columnListItem.IsForeignKey = context.BooleanValue("GetMetaTableFullInfo.Data.ColumnList["+ i +"].IsForeignKey");
				columnListItem.Caption = context.StringValue("GetMetaTableFullInfo.Data.ColumnList["+ i +"].Caption");

				data_columnList.Add(columnListItem);
			}
			data.ColumnList = data_columnList;
			getMetaTableFullInfoResponse.Data = data;
        
			return getMetaTableFullInfoResponse;
        }
    }
}
