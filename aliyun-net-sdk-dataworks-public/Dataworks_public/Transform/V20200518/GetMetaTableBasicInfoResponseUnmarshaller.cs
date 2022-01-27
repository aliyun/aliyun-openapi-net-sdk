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
    public class GetMetaTableBasicInfoResponseUnmarshaller
    {
        public static GetMetaTableBasicInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetMetaTableBasicInfoResponse getMetaTableBasicInfoResponse = new GetMetaTableBasicInfoResponse();

			getMetaTableBasicInfoResponse.HttpResponse = _ctx.HttpResponse;
			getMetaTableBasicInfoResponse.RequestId = _ctx.StringValue("GetMetaTableBasicInfo.RequestId");
			getMetaTableBasicInfoResponse.ErrorCode = _ctx.StringValue("GetMetaTableBasicInfo.ErrorCode");
			getMetaTableBasicInfoResponse.ErrorMessage = _ctx.StringValue("GetMetaTableBasicInfo.ErrorMessage");
			getMetaTableBasicInfoResponse.HttpStatusCode = _ctx.IntegerValue("GetMetaTableBasicInfo.HttpStatusCode");
			getMetaTableBasicInfoResponse.Success = _ctx.BooleanValue("GetMetaTableBasicInfo.Success");

			GetMetaTableBasicInfoResponse.GetMetaTableBasicInfo_Data data = new GetMetaTableBasicInfoResponse.GetMetaTableBasicInfo_Data();
			data.TableName = _ctx.StringValue("GetMetaTableBasicInfo.Data.TableName");
			data.TableGuid = _ctx.StringValue("GetMetaTableBasicInfo.Data.TableGuid");
			data.OwnerId = _ctx.StringValue("GetMetaTableBasicInfo.Data.OwnerId");
			data.TenantId = _ctx.LongValue("GetMetaTableBasicInfo.Data.TenantId");
			data.ProjectId = _ctx.LongValue("GetMetaTableBasicInfo.Data.ProjectId");
			data.CreateTime = _ctx.LongValue("GetMetaTableBasicInfo.Data.CreateTime");
			data.LastModifyTime = _ctx.LongValue("GetMetaTableBasicInfo.Data.LastModifyTime");
			data.LifeCycle = _ctx.IntegerValue("GetMetaTableBasicInfo.Data.LifeCycle");
			data.IsVisible = _ctx.IntegerValue("GetMetaTableBasicInfo.Data.IsVisible");
			data.LastDdlTime = _ctx.LongValue("GetMetaTableBasicInfo.Data.LastDdlTime");
			data.LastAccessTime = _ctx.LongValue("GetMetaTableBasicInfo.Data.LastAccessTime");
			data.EnvType = _ctx.IntegerValue("GetMetaTableBasicInfo.Data.EnvType");
			data.DataSize = _ctx.LongValue("GetMetaTableBasicInfo.Data.DataSize");
			data.Comment = _ctx.StringValue("GetMetaTableBasicInfo.Data.Comment");
			data.ProjectName = _ctx.StringValue("GetMetaTableBasicInfo.Data.ProjectName");
			data.DatabaseName = _ctx.StringValue("GetMetaTableBasicInfo.Data.DatabaseName");
			data.PartitionKeys = _ctx.StringValue("GetMetaTableBasicInfo.Data.PartitionKeys");
			data.Location = _ctx.StringValue("GetMetaTableBasicInfo.Data.Location");
			data.ClusterId = _ctx.StringValue("GetMetaTableBasicInfo.Data.ClusterId");
			data.Caption = _ctx.StringValue("GetMetaTableBasicInfo.Data.Caption");
			data.IsPartitionTable = _ctx.BooleanValue("GetMetaTableBasicInfo.Data.IsPartitionTable");
			data.ReadCount = _ctx.LongValue("GetMetaTableBasicInfo.Data.ReadCount");
			data.ViewCount = _ctx.LongValue("GetMetaTableBasicInfo.Data.ViewCount");
			data.FavoriteCount = _ctx.LongValue("GetMetaTableBasicInfo.Data.FavoriteCount");
			data.IsView = _ctx.BooleanValue("GetMetaTableBasicInfo.Data.IsView");
			data.ColumnCount = _ctx.IntegerValue("GetMetaTableBasicInfo.Data.ColumnCount");
			getMetaTableBasicInfoResponse.Data = data;
        
			return getMetaTableBasicInfoResponse;
        }
    }
}
