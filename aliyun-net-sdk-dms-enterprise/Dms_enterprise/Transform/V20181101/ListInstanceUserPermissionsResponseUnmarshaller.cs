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
    public class ListInstanceUserPermissionsResponseUnmarshaller
    {
        public static ListInstanceUserPermissionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListInstanceUserPermissionsResponse listInstanceUserPermissionsResponse = new ListInstanceUserPermissionsResponse();

			listInstanceUserPermissionsResponse.HttpResponse = _ctx.HttpResponse;
			listInstanceUserPermissionsResponse.TotalCount = _ctx.LongValue("ListInstanceUserPermissions.TotalCount");
			listInstanceUserPermissionsResponse.RequestId = _ctx.StringValue("ListInstanceUserPermissions.RequestId");
			listInstanceUserPermissionsResponse.ErrorCode = _ctx.StringValue("ListInstanceUserPermissions.ErrorCode");
			listInstanceUserPermissionsResponse.ErrorMessage = _ctx.StringValue("ListInstanceUserPermissions.ErrorMessage");
			listInstanceUserPermissionsResponse.Success = _ctx.BooleanValue("ListInstanceUserPermissions.Success");

			List<ListInstanceUserPermissionsResponse.ListInstanceUserPermissions_UserPermission> listInstanceUserPermissionsResponse_userPermissions = new List<ListInstanceUserPermissionsResponse.ListInstanceUserPermissions_UserPermission>();
			for (int i = 0; i < _ctx.Length("ListInstanceUserPermissions.UserPermissions.Length"); i++) {
				ListInstanceUserPermissionsResponse.ListInstanceUserPermissions_UserPermission userPermission = new ListInstanceUserPermissionsResponse.ListInstanceUserPermissions_UserPermission();
				userPermission.UserId = _ctx.StringValue("ListInstanceUserPermissions.UserPermissions["+ i +"].UserId");
				userPermission.UserNickName = _ctx.StringValue("ListInstanceUserPermissions.UserPermissions["+ i +"].UserNickName");
				userPermission.InstanceId = _ctx.StringValue("ListInstanceUserPermissions.UserPermissions["+ i +"].InstanceId");

				List<ListInstanceUserPermissionsResponse.ListInstanceUserPermissions_UserPermission.ListInstanceUserPermissions_PermDetail> userPermission_permDetails = new List<ListInstanceUserPermissionsResponse.ListInstanceUserPermissions_UserPermission.ListInstanceUserPermissions_PermDetail>();
				for (int j = 0; j < _ctx.Length("ListInstanceUserPermissions.UserPermissions["+ i +"].PermDetails.Length"); j++) {
					ListInstanceUserPermissionsResponse.ListInstanceUserPermissions_UserPermission.ListInstanceUserPermissions_PermDetail permDetail = new ListInstanceUserPermissionsResponse.ListInstanceUserPermissions_UserPermission.ListInstanceUserPermissions_PermDetail();
					permDetail.OriginFrom = _ctx.StringValue("ListInstanceUserPermissions.UserPermissions["+ i +"].PermDetails["+ j +"].OriginFrom");
					permDetail.PermType = _ctx.StringValue("ListInstanceUserPermissions.UserPermissions["+ i +"].PermDetails["+ j +"].PermType");
					permDetail.ExpireDate = _ctx.StringValue("ListInstanceUserPermissions.UserPermissions["+ i +"].PermDetails["+ j +"].ExpireDate");
					permDetail.CreateDate = _ctx.StringValue("ListInstanceUserPermissions.UserPermissions["+ i +"].PermDetails["+ j +"].CreateDate");
					permDetail.UserAccessId = _ctx.StringValue("ListInstanceUserPermissions.UserPermissions["+ i +"].PermDetails["+ j +"].UserAccessId");
					permDetail.ExtraData = _ctx.StringValue("ListInstanceUserPermissions.UserPermissions["+ i +"].PermDetails["+ j +"].ExtraData");

					userPermission_permDetails.Add(permDetail);
				}
				userPermission.PermDetails = userPermission_permDetails;

				listInstanceUserPermissionsResponse_userPermissions.Add(userPermission);
			}
			listInstanceUserPermissionsResponse.UserPermissions = listInstanceUserPermissionsResponse_userPermissions;
        
			return listInstanceUserPermissionsResponse;
        }
    }
}
