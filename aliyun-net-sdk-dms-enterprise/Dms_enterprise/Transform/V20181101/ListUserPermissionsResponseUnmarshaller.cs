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
    public class ListUserPermissionsResponseUnmarshaller
    {
        public static ListUserPermissionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListUserPermissionsResponse listUserPermissionsResponse = new ListUserPermissionsResponse();

			listUserPermissionsResponse.HttpResponse = _ctx.HttpResponse;
			listUserPermissionsResponse.RequestId = _ctx.StringValue("ListUserPermissions.RequestId");
			listUserPermissionsResponse.Success = _ctx.BooleanValue("ListUserPermissions.Success");
			listUserPermissionsResponse.ErrorMessage = _ctx.StringValue("ListUserPermissions.ErrorMessage");
			listUserPermissionsResponse.ErrorCode = _ctx.StringValue("ListUserPermissions.ErrorCode");
			listUserPermissionsResponse.TotalCount = _ctx.LongValue("ListUserPermissions.TotalCount");

			List<ListUserPermissionsResponse.ListUserPermissions_UserPermission> listUserPermissionsResponse_userPermissions = new List<ListUserPermissionsResponse.ListUserPermissions_UserPermission>();
			for (int i = 0; i < _ctx.Length("ListUserPermissions.UserPermissions.Length"); i++) {
				ListUserPermissionsResponse.ListUserPermissions_UserPermission userPermission = new ListUserPermissionsResponse.ListUserPermissions_UserPermission();
				userPermission.UserId = _ctx.StringValue("ListUserPermissions.UserPermissions["+ i +"].UserId");
				userPermission.UserNickName = _ctx.StringValue("ListUserPermissions.UserPermissions["+ i +"].UserNickName");
				userPermission.DsType = _ctx.StringValue("ListUserPermissions.UserPermissions["+ i +"].DsType");
				userPermission.DbId = _ctx.StringValue("ListUserPermissions.UserPermissions["+ i +"].DbId");
				userPermission.Logic = _ctx.BooleanValue("ListUserPermissions.UserPermissions["+ i +"].Logic");
				userPermission.SchemaName = _ctx.StringValue("ListUserPermissions.UserPermissions["+ i +"].SchemaName");
				userPermission.SearchName = _ctx.StringValue("ListUserPermissions.UserPermissions["+ i +"].SearchName");
				userPermission.InstanceId = _ctx.StringValue("ListUserPermissions.UserPermissions["+ i +"].InstanceId");
				userPermission.EnvType = _ctx.StringValue("ListUserPermissions.UserPermissions["+ i +"].EnvType");
				userPermission.Alias = _ctx.StringValue("ListUserPermissions.UserPermissions["+ i +"].Alias");
				userPermission.DbType = _ctx.StringValue("ListUserPermissions.UserPermissions["+ i +"].DbType");
				userPermission.TableName = _ctx.StringValue("ListUserPermissions.UserPermissions["+ i +"].TableName");
				userPermission.TableId = _ctx.StringValue("ListUserPermissions.UserPermissions["+ i +"].TableId");
				userPermission.ColumnName = _ctx.StringValue("ListUserPermissions.UserPermissions["+ i +"].ColumnName");

				List<ListUserPermissionsResponse.ListUserPermissions_UserPermission.ListUserPermissions_PermDetail> userPermission_permDetails = new List<ListUserPermissionsResponse.ListUserPermissions_UserPermission.ListUserPermissions_PermDetail>();
				for (int j = 0; j < _ctx.Length("ListUserPermissions.UserPermissions["+ i +"].PermDetails.Length"); j++) {
					ListUserPermissionsResponse.ListUserPermissions_UserPermission.ListUserPermissions_PermDetail permDetail = new ListUserPermissionsResponse.ListUserPermissions_UserPermission.ListUserPermissions_PermDetail();
					permDetail.PermType = _ctx.StringValue("ListUserPermissions.UserPermissions["+ i +"].PermDetails["+ j +"].PermType");
					permDetail.ExpireDate = _ctx.StringValue("ListUserPermissions.UserPermissions["+ i +"].PermDetails["+ j +"].ExpireDate");
					permDetail.CreateDate = _ctx.StringValue("ListUserPermissions.UserPermissions["+ i +"].PermDetails["+ j +"].CreateDate");
					permDetail.OriginFrom = _ctx.StringValue("ListUserPermissions.UserPermissions["+ i +"].PermDetails["+ j +"].OriginFrom");
					permDetail.UserAccessId = _ctx.StringValue("ListUserPermissions.UserPermissions["+ i +"].PermDetails["+ j +"].UserAccessId");
					permDetail.ExtraData = _ctx.StringValue("ListUserPermissions.UserPermissions["+ i +"].PermDetails["+ j +"].ExtraData");

					userPermission_permDetails.Add(permDetail);
				}
				userPermission.PermDetails = userPermission_permDetails;

				listUserPermissionsResponse_userPermissions.Add(userPermission);
			}
			listUserPermissionsResponse.UserPermissions = listUserPermissionsResponse_userPermissions;
        
			return listUserPermissionsResponse;
        }
    }
}
