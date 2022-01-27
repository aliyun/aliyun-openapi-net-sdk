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
    public class GetPermApplyOrderDetailResponseUnmarshaller
    {
        public static GetPermApplyOrderDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetPermApplyOrderDetailResponse getPermApplyOrderDetailResponse = new GetPermApplyOrderDetailResponse();

			getPermApplyOrderDetailResponse.HttpResponse = _ctx.HttpResponse;
			getPermApplyOrderDetailResponse.RequestId = _ctx.StringValue("GetPermApplyOrderDetail.RequestId");
			getPermApplyOrderDetailResponse.Success = _ctx.BooleanValue("GetPermApplyOrderDetail.Success");
			getPermApplyOrderDetailResponse.ErrorMessage = _ctx.StringValue("GetPermApplyOrderDetail.ErrorMessage");
			getPermApplyOrderDetailResponse.ErrorCode = _ctx.StringValue("GetPermApplyOrderDetail.ErrorCode");

			GetPermApplyOrderDetailResponse.GetPermApplyOrderDetail_PermApplyOrderDetail permApplyOrderDetail = new GetPermApplyOrderDetailResponse.GetPermApplyOrderDetail_PermApplyOrderDetail();
			permApplyOrderDetail.PermType = _ctx.LongValue("GetPermApplyOrderDetail.PermApplyOrderDetail.PermType");
			permApplyOrderDetail.Seconds = _ctx.LongValue("GetPermApplyOrderDetail.PermApplyOrderDetail.Seconds");
			permApplyOrderDetail.ApplyType = _ctx.StringValue("GetPermApplyOrderDetail.PermApplyOrderDetail.ApplyType");

			List<GetPermApplyOrderDetailResponse.GetPermApplyOrderDetail_PermApplyOrderDetail.GetPermApplyOrderDetail_Resource> permApplyOrderDetail_resources = new List<GetPermApplyOrderDetailResponse.GetPermApplyOrderDetail_PermApplyOrderDetail.GetPermApplyOrderDetail_Resource>();
			for (int i = 0; i < _ctx.Length("GetPermApplyOrderDetail.PermApplyOrderDetail.Resources.Length"); i++) {
				GetPermApplyOrderDetailResponse.GetPermApplyOrderDetail_PermApplyOrderDetail.GetPermApplyOrderDetail_Resource resource = new GetPermApplyOrderDetailResponse.GetPermApplyOrderDetail_PermApplyOrderDetail.GetPermApplyOrderDetail_Resource();

				GetPermApplyOrderDetailResponse.GetPermApplyOrderDetail_PermApplyOrderDetail.GetPermApplyOrderDetail_Resource.GetPermApplyOrderDetail_DatabaseInfo databaseInfo = new GetPermApplyOrderDetailResponse.GetPermApplyOrderDetail_PermApplyOrderDetail.GetPermApplyOrderDetail_Resource.GetPermApplyOrderDetail_DatabaseInfo();
				databaseInfo.DbId = _ctx.LongValue("GetPermApplyOrderDetail.PermApplyOrderDetail.Resources["+ i +"].DatabaseInfo.DbId");
				databaseInfo.Logic = _ctx.BooleanValue("GetPermApplyOrderDetail.PermApplyOrderDetail.Resources["+ i +"].DatabaseInfo.Logic");
				databaseInfo.DbType = _ctx.StringValue("GetPermApplyOrderDetail.PermApplyOrderDetail.Resources["+ i +"].DatabaseInfo.DbType");
				databaseInfo.SearchName = _ctx.StringValue("GetPermApplyOrderDetail.PermApplyOrderDetail.Resources["+ i +"].DatabaseInfo.SearchName");
				databaseInfo.EnvType = _ctx.StringValue("GetPermApplyOrderDetail.PermApplyOrderDetail.Resources["+ i +"].DatabaseInfo.EnvType");

				List<string> databaseInfo_ownerIds = new List<string>();
				for (int j = 0; j < _ctx.Length("GetPermApplyOrderDetail.PermApplyOrderDetail.Resources["+ i +"].DatabaseInfo.OwnerIds.Length"); j++) {
					databaseInfo_ownerIds.Add(_ctx.StringValue("GetPermApplyOrderDetail.PermApplyOrderDetail.Resources["+ i +"].DatabaseInfo.OwnerIds["+ j +"]"));
				}
				databaseInfo.OwnerIds = databaseInfo_ownerIds;

				List<string> databaseInfo_ownerNickNames = new List<string>();
				for (int j = 0; j < _ctx.Length("GetPermApplyOrderDetail.PermApplyOrderDetail.Resources["+ i +"].DatabaseInfo.OwnerNickNames.Length"); j++) {
					databaseInfo_ownerNickNames.Add(_ctx.StringValue("GetPermApplyOrderDetail.PermApplyOrderDetail.Resources["+ i +"].DatabaseInfo.OwnerNickNames["+ j +"]"));
				}
				databaseInfo.OwnerNickNames = databaseInfo_ownerNickNames;
				resource.DatabaseInfo = databaseInfo;

				GetPermApplyOrderDetailResponse.GetPermApplyOrderDetail_PermApplyOrderDetail.GetPermApplyOrderDetail_Resource.GetPermApplyOrderDetail_TableInfo tableInfo = new GetPermApplyOrderDetailResponse.GetPermApplyOrderDetail_PermApplyOrderDetail.GetPermApplyOrderDetail_Resource.GetPermApplyOrderDetail_TableInfo();
				tableInfo.TableName = _ctx.StringValue("GetPermApplyOrderDetail.PermApplyOrderDetail.Resources["+ i +"].TableInfo.TableName");
				resource.TableInfo = tableInfo;

				GetPermApplyOrderDetailResponse.GetPermApplyOrderDetail_PermApplyOrderDetail.GetPermApplyOrderDetail_Resource.GetPermApplyOrderDetail_ColumnInfo columnInfo = new GetPermApplyOrderDetailResponse.GetPermApplyOrderDetail_PermApplyOrderDetail.GetPermApplyOrderDetail_Resource.GetPermApplyOrderDetail_ColumnInfo();
				columnInfo.TableName = _ctx.StringValue("GetPermApplyOrderDetail.PermApplyOrderDetail.Resources["+ i +"].ColumnInfo.TableName");
				columnInfo.ColumnName = _ctx.StringValue("GetPermApplyOrderDetail.PermApplyOrderDetail.Resources["+ i +"].ColumnInfo.ColumnName");
				resource.ColumnInfo = columnInfo;

				GetPermApplyOrderDetailResponse.GetPermApplyOrderDetail_PermApplyOrderDetail.GetPermApplyOrderDetail_Resource.GetPermApplyOrderDetail_InstanceInfo instanceInfo = new GetPermApplyOrderDetailResponse.GetPermApplyOrderDetail_PermApplyOrderDetail.GetPermApplyOrderDetail_Resource.GetPermApplyOrderDetail_InstanceInfo();
				instanceInfo.InstanceId = _ctx.StringValue("GetPermApplyOrderDetail.PermApplyOrderDetail.Resources["+ i +"].InstanceInfo.InstanceId");
				instanceInfo.SearchName = _ctx.StringValue("GetPermApplyOrderDetail.PermApplyOrderDetail.Resources["+ i +"].InstanceInfo.SearchName");
				instanceInfo.DbType = _ctx.StringValue("GetPermApplyOrderDetail.PermApplyOrderDetail.Resources["+ i +"].InstanceInfo.DbType");
				instanceInfo.EnvType = _ctx.StringValue("GetPermApplyOrderDetail.PermApplyOrderDetail.Resources["+ i +"].InstanceInfo.EnvType");
				instanceInfo.Host = _ctx.StringValue("GetPermApplyOrderDetail.PermApplyOrderDetail.Resources["+ i +"].InstanceInfo.Host");
				instanceInfo.Port = _ctx.LongValue("GetPermApplyOrderDetail.PermApplyOrderDetail.Resources["+ i +"].InstanceInfo.Port");
				instanceInfo.DbaId = _ctx.LongValue("GetPermApplyOrderDetail.PermApplyOrderDetail.Resources["+ i +"].InstanceInfo.DbaId");
				instanceInfo.DbaNickName = _ctx.StringValue("GetPermApplyOrderDetail.PermApplyOrderDetail.Resources["+ i +"].InstanceInfo.DbaNickName");

				List<string> instanceInfo_ownerIds1 = new List<string>();
				for (int j = 0; j < _ctx.Length("GetPermApplyOrderDetail.PermApplyOrderDetail.Resources["+ i +"].InstanceInfo.OwnerIds.Length"); j++) {
					instanceInfo_ownerIds1.Add(_ctx.StringValue("GetPermApplyOrderDetail.PermApplyOrderDetail.Resources["+ i +"].InstanceInfo.OwnerIds["+ j +"]"));
				}
				instanceInfo.OwnerIds1 = instanceInfo_ownerIds1;

				List<string> instanceInfo_ownerNickName = new List<string>();
				for (int j = 0; j < _ctx.Length("GetPermApplyOrderDetail.PermApplyOrderDetail.Resources["+ i +"].InstanceInfo.OwnerNickName.Length"); j++) {
					instanceInfo_ownerNickName.Add(_ctx.StringValue("GetPermApplyOrderDetail.PermApplyOrderDetail.Resources["+ i +"].InstanceInfo.OwnerNickName["+ j +"]"));
				}
				instanceInfo.OwnerNickName = instanceInfo_ownerNickName;
				resource.InstanceInfo = instanceInfo;

				permApplyOrderDetail_resources.Add(resource);
			}
			permApplyOrderDetail.Resources = permApplyOrderDetail_resources;
			getPermApplyOrderDetailResponse.PermApplyOrderDetail = permApplyOrderDetail;
        
			return getPermApplyOrderDetailResponse;
        }
    }
}
