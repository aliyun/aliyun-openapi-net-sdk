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
        public static ListUserPermissionsResponse Unmarshall(UnmarshallerContext context)
        {
			ListUserPermissionsResponse listUserPermissionsResponse = new ListUserPermissionsResponse();

			listUserPermissionsResponse.HttpResponse = context.HttpResponse;
			listUserPermissionsResponse.RequestId = context.StringValue("ListUserPermissions.RequestId");
			listUserPermissionsResponse.Success = context.BooleanValue("ListUserPermissions.Success");
			listUserPermissionsResponse.ErrorMessage = context.StringValue("ListUserPermissions.ErrorMessage");
			listUserPermissionsResponse.ErrorCode = context.StringValue("ListUserPermissions.ErrorCode");
			listUserPermissionsResponse.TotalCount = context.LongValue("ListUserPermissions.TotalCount");

			List<ListUserPermissionsResponse.ListUserPermissions_UserPermission> listUserPermissionsResponse_userPermissions = new List<ListUserPermissionsResponse.ListUserPermissions_UserPermission>();
			for (int i = 0; i < context.Length("ListUserPermissions.UserPermissions.Length"); i++) {
				ListUserPermissionsResponse.ListUserPermissions_UserPermission userPermission = new ListUserPermissionsResponse.ListUserPermissions_UserPermission();
				userPermission.UserId = context.StringValue("ListUserPermissions.UserPermissions["+ i +"].UserId");
				userPermission.UserNickName = context.StringValue("ListUserPermissions.UserPermissions["+ i +"].UserNickName");
				userPermission.DsType = context.StringValue("ListUserPermissions.UserPermissions["+ i +"].DsType");
				userPermission.DbId = context.StringValue("ListUserPermissions.UserPermissions["+ i +"].DbId");
				userPermission.Logic = context.BooleanValue("ListUserPermissions.UserPermissions["+ i +"].Logic");
				userPermission.SchemaName = context.StringValue("ListUserPermissions.UserPermissions["+ i +"].SchemaName");
				userPermission.SearchName = context.StringValue("ListUserPermissions.UserPermissions["+ i +"].SearchName");
				userPermission.InstanceId = context.StringValue("ListUserPermissions.UserPermissions["+ i +"].InstanceId");
				userPermission.EnvType = context.StringValue("ListUserPermissions.UserPermissions["+ i +"].EnvType");
				userPermission.Alias = context.StringValue("ListUserPermissions.UserPermissions["+ i +"].Alias");
				userPermission.DbType = context.StringValue("ListUserPermissions.UserPermissions["+ i +"].DbType");
				userPermission.TableName = context.StringValue("ListUserPermissions.UserPermissions["+ i +"].TableName");
				userPermission.TableId = context.StringValue("ListUserPermissions.UserPermissions["+ i +"].TableId");
				userPermission.ColumnName = context.StringValue("ListUserPermissions.UserPermissions["+ i +"].ColumnName");

				List<ListUserPermissionsResponse.ListUserPermissions_UserPermission.ListUserPermissions_PermDetail> userPermission_permDetails = new List<ListUserPermissionsResponse.ListUserPermissions_UserPermission.ListUserPermissions_PermDetail>();
				for (int j = 0; j < context.Length("ListUserPermissions.UserPermissions["+ i +"].PermDetails.Length"); j++) {
					ListUserPermissionsResponse.ListUserPermissions_UserPermission.ListUserPermissions_PermDetail permDetail = new ListUserPermissionsResponse.ListUserPermissions_UserPermission.ListUserPermissions_PermDetail();
					permDetail.PermType = context.StringValue("ListUserPermissions.UserPermissions["+ i +"].PermDetails["+ j +"].PermType");
					permDetail.ExpireDate = context.StringValue("ListUserPermissions.UserPermissions["+ i +"].PermDetails["+ j +"].ExpireDate");
					permDetail.CreateDate = context.StringValue("ListUserPermissions.UserPermissions["+ i +"].PermDetails["+ j +"].CreateDate");
					permDetail.OriginFrom = context.StringValue("ListUserPermissions.UserPermissions["+ i +"].PermDetails["+ j +"].OriginFrom");
					permDetail.UserAccessId = context.StringValue("ListUserPermissions.UserPermissions["+ i +"].PermDetails["+ j +"].UserAccessId");
					permDetail.ExtraData = context.StringValue("ListUserPermissions.UserPermissions["+ i +"].PermDetails["+ j +"].ExtraData");

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
