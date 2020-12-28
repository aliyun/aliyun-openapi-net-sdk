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
        public static GetMetaTableFullInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetMetaTableFullInfoResponse getMetaTableFullInfoResponse = new GetMetaTableFullInfoResponse();

			getMetaTableFullInfoResponse.HttpResponse = _ctx.HttpResponse;
			getMetaTableFullInfoResponse.RequestId = _ctx.StringValue("GetMetaTableFullInfo.RequestId");
			getMetaTableFullInfoResponse.ErrorCode = _ctx.StringValue("GetMetaTableFullInfo.ErrorCode");
			getMetaTableFullInfoResponse.ErrorMessage = _ctx.StringValue("GetMetaTableFullInfo.ErrorMessage");
			getMetaTableFullInfoResponse.HttpStatusCode = _ctx.IntegerValue("GetMetaTableFullInfo.HttpStatusCode");
			getMetaTableFullInfoResponse.Success = _ctx.BooleanValue("GetMetaTableFullInfo.Success");

			GetMetaTableFullInfoResponse.GetMetaTableFullInfo_Data data = new GetMetaTableFullInfoResponse.GetMetaTableFullInfo_Data();
			data.TableName = _ctx.StringValue("GetMetaTableFullInfo.Data.TableName");
			data.TableGuid = _ctx.StringValue("GetMetaTableFullInfo.Data.TableGuid");
			data.OwnerId = _ctx.StringValue("GetMetaTableFullInfo.Data.OwnerId");
			data.TenantId = _ctx.LongValue("GetMetaTableFullInfo.Data.TenantId");
			data.ProjectId = _ctx.LongValue("GetMetaTableFullInfo.Data.ProjectId");
			data.CreateTime = _ctx.LongValue("GetMetaTableFullInfo.Data.CreateTime");
			data.LastModifyTime = _ctx.LongValue("GetMetaTableFullInfo.Data.LastModifyTime");
			data.LifeCycle = _ctx.IntegerValue("GetMetaTableFullInfo.Data.LifeCycle");
			data.IsVisible = _ctx.IntegerValue("GetMetaTableFullInfo.Data.IsVisible");
			data.ProjectName = _ctx.StringValue("GetMetaTableFullInfo.Data.ProjectName");
			data.DataSize = _ctx.LongValue("GetMetaTableFullInfo.Data.DataSize");
			data.EnvType = _ctx.IntegerValue("GetMetaTableFullInfo.Data.EnvType");
			data.Comment = _ctx.StringValue("GetMetaTableFullInfo.Data.Comment");
			data.TotalColumnCount = _ctx.LongValue("GetMetaTableFullInfo.Data.TotalColumnCount");
			data.LastDdlTime = _ctx.LongValue("GetMetaTableFullInfo.Data.LastDdlTime");
			data.LastAccessTime = _ctx.LongValue("GetMetaTableFullInfo.Data.LastAccessTime");
			data.DatabaseName = _ctx.StringValue("GetMetaTableFullInfo.Data.DatabaseName");
			data.PartitionKeys = _ctx.StringValue("GetMetaTableFullInfo.Data.PartitionKeys");
			data.Location = _ctx.StringValue("GetMetaTableFullInfo.Data.Location");
			data.ClusterId = _ctx.StringValue("GetMetaTableFullInfo.Data.ClusterId");

			List<GetMetaTableFullInfoResponse.GetMetaTableFullInfo_Data.GetMetaTableFullInfo_ColumnListItem> data_columnList = new List<GetMetaTableFullInfoResponse.GetMetaTableFullInfo_Data.GetMetaTableFullInfo_ColumnListItem>();
			for (int i = 0; i < _ctx.Length("GetMetaTableFullInfo.Data.ColumnList.Length"); i++) {
				GetMetaTableFullInfoResponse.GetMetaTableFullInfo_Data.GetMetaTableFullInfo_ColumnListItem columnListItem = new GetMetaTableFullInfoResponse.GetMetaTableFullInfo_Data.GetMetaTableFullInfo_ColumnListItem();
				columnListItem.ColumnGuid = _ctx.StringValue("GetMetaTableFullInfo.Data.ColumnList["+ i +"].ColumnGuid");
				columnListItem.ColumnName = _ctx.StringValue("GetMetaTableFullInfo.Data.ColumnList["+ i +"].ColumnName");
				columnListItem.ColumnType = _ctx.StringValue("GetMetaTableFullInfo.Data.ColumnList["+ i +"].ColumnType");
				columnListItem.IsPrimaryKey = _ctx.BooleanValue("GetMetaTableFullInfo.Data.ColumnList["+ i +"].IsPrimaryKey");
				columnListItem.Comment = _ctx.StringValue("GetMetaTableFullInfo.Data.ColumnList["+ i +"].Comment");
				columnListItem.IsPartitionColumn = _ctx.BooleanValue("GetMetaTableFullInfo.Data.ColumnList["+ i +"].IsPartitionColumn");
				columnListItem.IsForeignKey = _ctx.BooleanValue("GetMetaTableFullInfo.Data.ColumnList["+ i +"].IsForeignKey");
				columnListItem.Caption = _ctx.StringValue("GetMetaTableFullInfo.Data.ColumnList["+ i +"].Caption");
				columnListItem.Position = _ctx.IntegerValue("GetMetaTableFullInfo.Data.ColumnList["+ i +"].Position");

				data_columnList.Add(columnListItem);
			}
			data.ColumnList = data_columnList;
			getMetaTableFullInfoResponse.Data = data;
        
			return getMetaTableFullInfoResponse;
        }
    }
}
