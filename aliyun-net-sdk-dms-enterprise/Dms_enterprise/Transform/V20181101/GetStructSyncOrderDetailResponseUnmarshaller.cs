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
    public class GetStructSyncOrderDetailResponseUnmarshaller
    {
        public static GetStructSyncOrderDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetStructSyncOrderDetailResponse getStructSyncOrderDetailResponse = new GetStructSyncOrderDetailResponse();

			getStructSyncOrderDetailResponse.HttpResponse = _ctx.HttpResponse;
			getStructSyncOrderDetailResponse.RequestId = _ctx.StringValue("GetStructSyncOrderDetail.RequestId");
			getStructSyncOrderDetailResponse.Success = _ctx.BooleanValue("GetStructSyncOrderDetail.Success");
			getStructSyncOrderDetailResponse.ErrorMessage = _ctx.StringValue("GetStructSyncOrderDetail.ErrorMessage");
			getStructSyncOrderDetailResponse.ErrorCode = _ctx.StringValue("GetStructSyncOrderDetail.ErrorCode");

			GetStructSyncOrderDetailResponse.GetStructSyncOrderDetail_StructSyncOrderDetail structSyncOrderDetail = new GetStructSyncOrderDetailResponse.GetStructSyncOrderDetail_StructSyncOrderDetail();
			structSyncOrderDetail.SourceType = _ctx.StringValue("GetStructSyncOrderDetail.StructSyncOrderDetail.SourceType");
			structSyncOrderDetail.TargetType = _ctx.StringValue("GetStructSyncOrderDetail.StructSyncOrderDetail.TargetType");
			structSyncOrderDetail.IgnoreError = _ctx.BooleanValue("GetStructSyncOrderDetail.StructSyncOrderDetail.IgnoreError");

			GetStructSyncOrderDetailResponse.GetStructSyncOrderDetail_StructSyncOrderDetail.GetStructSyncOrderDetail_SourceDatabaseInfo sourceDatabaseInfo = new GetStructSyncOrderDetailResponse.GetStructSyncOrderDetail_StructSyncOrderDetail.GetStructSyncOrderDetail_SourceDatabaseInfo();
			sourceDatabaseInfo.DbId = _ctx.LongValue("GetStructSyncOrderDetail.StructSyncOrderDetail.SourceDatabaseInfo.DbId");
			sourceDatabaseInfo.SearchName = _ctx.StringValue("GetStructSyncOrderDetail.StructSyncOrderDetail.SourceDatabaseInfo.SearchName");
			sourceDatabaseInfo.DbType = _ctx.StringValue("GetStructSyncOrderDetail.StructSyncOrderDetail.SourceDatabaseInfo.DbType");
			sourceDatabaseInfo.EnvType = _ctx.StringValue("GetStructSyncOrderDetail.StructSyncOrderDetail.SourceDatabaseInfo.EnvType");
			sourceDatabaseInfo.Logic = _ctx.BooleanValue("GetStructSyncOrderDetail.StructSyncOrderDetail.SourceDatabaseInfo.Logic");
			structSyncOrderDetail.SourceDatabaseInfo = sourceDatabaseInfo;

			GetStructSyncOrderDetailResponse.GetStructSyncOrderDetail_StructSyncOrderDetail.GetStructSyncOrderDetail_TargetDatabaseInfo targetDatabaseInfo = new GetStructSyncOrderDetailResponse.GetStructSyncOrderDetail_StructSyncOrderDetail.GetStructSyncOrderDetail_TargetDatabaseInfo();
			targetDatabaseInfo.DbId = _ctx.LongValue("GetStructSyncOrderDetail.StructSyncOrderDetail.TargetDatabaseInfo.DbId");
			targetDatabaseInfo.SearchName = _ctx.StringValue("GetStructSyncOrderDetail.StructSyncOrderDetail.TargetDatabaseInfo.SearchName");
			targetDatabaseInfo.DbType = _ctx.StringValue("GetStructSyncOrderDetail.StructSyncOrderDetail.TargetDatabaseInfo.DbType");
			targetDatabaseInfo.EnvType = _ctx.StringValue("GetStructSyncOrderDetail.StructSyncOrderDetail.TargetDatabaseInfo.EnvType");
			targetDatabaseInfo.Logic = _ctx.BooleanValue("GetStructSyncOrderDetail.StructSyncOrderDetail.TargetDatabaseInfo.Logic");
			structSyncOrderDetail.TargetDatabaseInfo = targetDatabaseInfo;

			GetStructSyncOrderDetailResponse.GetStructSyncOrderDetail_StructSyncOrderDetail.GetStructSyncOrderDetail_SourceVersionInfo sourceVersionInfo = new GetStructSyncOrderDetailResponse.GetStructSyncOrderDetail_StructSyncOrderDetail.GetStructSyncOrderDetail_SourceVersionInfo();
			sourceVersionInfo.VersionId = _ctx.StringValue("GetStructSyncOrderDetail.StructSyncOrderDetail.SourceVersionInfo.VersionId");
			structSyncOrderDetail.SourceVersionInfo = sourceVersionInfo;

			GetStructSyncOrderDetailResponse.GetStructSyncOrderDetail_StructSyncOrderDetail.GetStructSyncOrderDetail_TargetVersionInfo targetVersionInfo = new GetStructSyncOrderDetailResponse.GetStructSyncOrderDetail_StructSyncOrderDetail.GetStructSyncOrderDetail_TargetVersionInfo();
			targetVersionInfo.VersionId = _ctx.StringValue("GetStructSyncOrderDetail.StructSyncOrderDetail.TargetVersionInfo.VersionId");
			structSyncOrderDetail.TargetVersionInfo = targetVersionInfo;

			List<GetStructSyncOrderDetailResponse.GetStructSyncOrderDetail_StructSyncOrderDetail.GetStructSyncOrderDetail_TableInfo> structSyncOrderDetail_tableInfoList = new List<GetStructSyncOrderDetailResponse.GetStructSyncOrderDetail_StructSyncOrderDetail.GetStructSyncOrderDetail_TableInfo>();
			for (int i = 0; i < _ctx.Length("GetStructSyncOrderDetail.StructSyncOrderDetail.TableInfoList.Length"); i++) {
				GetStructSyncOrderDetailResponse.GetStructSyncOrderDetail_StructSyncOrderDetail.GetStructSyncOrderDetail_TableInfo tableInfo = new GetStructSyncOrderDetailResponse.GetStructSyncOrderDetail_StructSyncOrderDetail.GetStructSyncOrderDetail_TableInfo();
				tableInfo.SourceTableName = _ctx.StringValue("GetStructSyncOrderDetail.StructSyncOrderDetail.TableInfoList["+ i +"].SourceTableName");
				tableInfo.TargetTableName = _ctx.StringValue("GetStructSyncOrderDetail.StructSyncOrderDetail.TableInfoList["+ i +"].TargetTableName");

				structSyncOrderDetail_tableInfoList.Add(tableInfo);
			}
			structSyncOrderDetail.TableInfoList = structSyncOrderDetail_tableInfoList;
			getStructSyncOrderDetailResponse.StructSyncOrderDetail = structSyncOrderDetail;
        
			return getStructSyncOrderDetailResponse;
        }
    }
}
