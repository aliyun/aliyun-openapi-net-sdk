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
    public class ListDatabaseUserPermssionsResponseUnmarshaller
    {
        public static ListDatabaseUserPermssionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDatabaseUserPermssionsResponse listDatabaseUserPermssionsResponse = new ListDatabaseUserPermssionsResponse();

			listDatabaseUserPermssionsResponse.HttpResponse = _ctx.HttpResponse;
			listDatabaseUserPermssionsResponse.TotalCount = _ctx.LongValue("ListDatabaseUserPermssions.TotalCount");
			listDatabaseUserPermssionsResponse.RequestId = _ctx.StringValue("ListDatabaseUserPermssions.RequestId");
			listDatabaseUserPermssionsResponse.ErrorCode = _ctx.StringValue("ListDatabaseUserPermssions.ErrorCode");
			listDatabaseUserPermssionsResponse.ErrorMessage = _ctx.StringValue("ListDatabaseUserPermssions.ErrorMessage");
			listDatabaseUserPermssionsResponse.Success = _ctx.BooleanValue("ListDatabaseUserPermssions.Success");

			List<ListDatabaseUserPermssionsResponse.ListDatabaseUserPermssions_UserPermission> listDatabaseUserPermssionsResponse_userPermissions = new List<ListDatabaseUserPermssionsResponse.ListDatabaseUserPermssions_UserPermission>();
			for (int i = 0; i < _ctx.Length("ListDatabaseUserPermssions.UserPermissions.Length"); i++) {
				ListDatabaseUserPermssionsResponse.ListDatabaseUserPermssions_UserPermission userPermission = new ListDatabaseUserPermssionsResponse.ListDatabaseUserPermssions_UserPermission();
				userPermission.DbId = _ctx.StringValue("ListDatabaseUserPermssions.UserPermissions["+ i +"].DbId");
				userPermission.TableName = _ctx.StringValue("ListDatabaseUserPermssions.UserPermissions["+ i +"].TableName");
				userPermission.UserId = _ctx.StringValue("ListDatabaseUserPermssions.UserPermissions["+ i +"].UserId");
				userPermission.SchemaName = _ctx.StringValue("ListDatabaseUserPermssions.UserPermissions["+ i +"].SchemaName");
				userPermission.Logic = _ctx.BooleanValue("ListDatabaseUserPermssions.UserPermissions["+ i +"].Logic");
				userPermission.UserNickName = _ctx.StringValue("ListDatabaseUserPermssions.UserPermissions["+ i +"].UserNickName");
				userPermission.InstanceId = _ctx.StringValue("ListDatabaseUserPermssions.UserPermissions["+ i +"].InstanceId");
				userPermission.EnvType = _ctx.StringValue("ListDatabaseUserPermssions.UserPermissions["+ i +"].EnvType");
				userPermission.ColumnName = _ctx.StringValue("ListDatabaseUserPermssions.UserPermissions["+ i +"].ColumnName");
				userPermission.DbType = _ctx.StringValue("ListDatabaseUserPermssions.UserPermissions["+ i +"].DbType");
				userPermission.DsType = _ctx.StringValue("ListDatabaseUserPermssions.UserPermissions["+ i +"].DsType");
				userPermission.TableId = _ctx.StringValue("ListDatabaseUserPermssions.UserPermissions["+ i +"].TableId");
				userPermission.SearchName = _ctx.StringValue("ListDatabaseUserPermssions.UserPermissions["+ i +"].SearchName");
				userPermission.Alias = _ctx.StringValue("ListDatabaseUserPermssions.UserPermissions["+ i +"].Alias");

				List<ListDatabaseUserPermssionsResponse.ListDatabaseUserPermssions_UserPermission.ListDatabaseUserPermssions_PermDetail> userPermission_permDetails = new List<ListDatabaseUserPermssionsResponse.ListDatabaseUserPermssions_UserPermission.ListDatabaseUserPermssions_PermDetail>();
				for (int j = 0; j < _ctx.Length("ListDatabaseUserPermssions.UserPermissions["+ i +"].PermDetails.Length"); j++) {
					ListDatabaseUserPermssionsResponse.ListDatabaseUserPermssions_UserPermission.ListDatabaseUserPermssions_PermDetail permDetail = new ListDatabaseUserPermssionsResponse.ListDatabaseUserPermssions_UserPermission.ListDatabaseUserPermssions_PermDetail();
					permDetail.OriginFrom = _ctx.StringValue("ListDatabaseUserPermssions.UserPermissions["+ i +"].PermDetails["+ j +"].OriginFrom");
					permDetail.PermType = _ctx.StringValue("ListDatabaseUserPermssions.UserPermissions["+ i +"].PermDetails["+ j +"].PermType");
					permDetail.ExpireDate = _ctx.StringValue("ListDatabaseUserPermssions.UserPermissions["+ i +"].PermDetails["+ j +"].ExpireDate");
					permDetail.CreateDate = _ctx.StringValue("ListDatabaseUserPermssions.UserPermissions["+ i +"].PermDetails["+ j +"].CreateDate");
					permDetail.UserAccessId = _ctx.StringValue("ListDatabaseUserPermssions.UserPermissions["+ i +"].PermDetails["+ j +"].UserAccessId");
					permDetail.ExtraData = _ctx.StringValue("ListDatabaseUserPermssions.UserPermissions["+ i +"].PermDetails["+ j +"].ExtraData");

					userPermission_permDetails.Add(permDetail);
				}
				userPermission.PermDetails = userPermission_permDetails;

				listDatabaseUserPermssionsResponse_userPermissions.Add(userPermission);
			}
			listDatabaseUserPermssionsResponse.UserPermissions = listDatabaseUserPermssionsResponse_userPermissions;
        
			return listDatabaseUserPermssionsResponse;
        }
    }
}
