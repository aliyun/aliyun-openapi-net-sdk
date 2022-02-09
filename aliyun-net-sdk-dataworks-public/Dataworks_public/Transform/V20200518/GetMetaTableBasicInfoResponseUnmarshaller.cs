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
			getMetaTableBasicInfoResponse.HttpStatusCode = _ctx.IntegerValue("GetMetaTableBasicInfo.HttpStatusCode");
			getMetaTableBasicInfoResponse.ErrorMessage = _ctx.StringValue("GetMetaTableBasicInfo.ErrorMessage");
			getMetaTableBasicInfoResponse.RequestId = _ctx.StringValue("GetMetaTableBasicInfo.RequestId");
			getMetaTableBasicInfoResponse.Success = _ctx.BooleanValue("GetMetaTableBasicInfo.Success");
			getMetaTableBasicInfoResponse.ErrorCode = _ctx.StringValue("GetMetaTableBasicInfo.ErrorCode");

			GetMetaTableBasicInfoResponse.GetMetaTableBasicInfo_Data data = new GetMetaTableBasicInfoResponse.GetMetaTableBasicInfo_Data();
			data.TableName = _ctx.StringValue("GetMetaTableBasicInfo.Data.TableName");
			data.FavoriteCount = _ctx.LongValue("GetMetaTableBasicInfo.Data.FavoriteCount");
			data.Comment = _ctx.StringValue("GetMetaTableBasicInfo.Data.Comment");
			data.ColumnCount = _ctx.IntegerValue("GetMetaTableBasicInfo.Data.ColumnCount");
			data.CreateTime = _ctx.LongValue("GetMetaTableBasicInfo.Data.CreateTime");
			data.ProjectId = _ctx.LongValue("GetMetaTableBasicInfo.Data.ProjectId");
			data.OwnerId = _ctx.StringValue("GetMetaTableBasicInfo.Data.OwnerId");
			data.EnvType = _ctx.IntegerValue("GetMetaTableBasicInfo.Data.EnvType");
			data.DatabaseName = _ctx.StringValue("GetMetaTableBasicInfo.Data.DatabaseName");
			data.IsVisible = _ctx.IntegerValue("GetMetaTableBasicInfo.Data.IsVisible");
			data.TableGuid = _ctx.StringValue("GetMetaTableBasicInfo.Data.TableGuid");
			data.ReadCount = _ctx.LongValue("GetMetaTableBasicInfo.Data.ReadCount");
			data.ClusterId = _ctx.StringValue("GetMetaTableBasicInfo.Data.ClusterId");
			data.IsPartitionTable = _ctx.BooleanValue("GetMetaTableBasicInfo.Data.IsPartitionTable");
			data.IsView = _ctx.BooleanValue("GetMetaTableBasicInfo.Data.IsView");
			data.LifeCycle = _ctx.IntegerValue("GetMetaTableBasicInfo.Data.LifeCycle");
			data.ProjectName = _ctx.StringValue("GetMetaTableBasicInfo.Data.ProjectName");
			data.ViewCount = _ctx.LongValue("GetMetaTableBasicInfo.Data.ViewCount");
			data.LastAccessTime = _ctx.LongValue("GetMetaTableBasicInfo.Data.LastAccessTime");
			data.DataSize = _ctx.LongValue("GetMetaTableBasicInfo.Data.DataSize");
			data.LastModifyTime = _ctx.LongValue("GetMetaTableBasicInfo.Data.LastModifyTime");
			data.LastDdlTime = _ctx.LongValue("GetMetaTableBasicInfo.Data.LastDdlTime");
			data.PartitionKeys = _ctx.StringValue("GetMetaTableBasicInfo.Data.PartitionKeys");
			data.Location = _ctx.StringValue("GetMetaTableBasicInfo.Data.Location");
			data.Caption = _ctx.StringValue("GetMetaTableBasicInfo.Data.Caption");
			data.TenantId = _ctx.LongValue("GetMetaTableBasicInfo.Data.TenantId");
			getMetaTableBasicInfoResponse.Data = data;
        
			return getMetaTableBasicInfoResponse;
        }
    }
}
