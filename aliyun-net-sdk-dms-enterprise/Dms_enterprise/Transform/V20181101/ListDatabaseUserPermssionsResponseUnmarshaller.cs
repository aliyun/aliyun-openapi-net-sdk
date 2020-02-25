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
        public static ListDatabaseUserPermssionsResponse Unmarshall(UnmarshallerContext context)
        {
			ListDatabaseUserPermssionsResponse listDatabaseUserPermssionsResponse = new ListDatabaseUserPermssionsResponse();

			listDatabaseUserPermssionsResponse.HttpResponse = context.HttpResponse;
			listDatabaseUserPermssionsResponse.RequestId = context.StringValue("ListDatabaseUserPermssions.RequestId");
			listDatabaseUserPermssionsResponse.Success = context.BooleanValue("ListDatabaseUserPermssions.Success");
			listDatabaseUserPermssionsResponse.ErrorMessage = context.StringValue("ListDatabaseUserPermssions.ErrorMessage");
			listDatabaseUserPermssionsResponse.ErrorCode = context.StringValue("ListDatabaseUserPermssions.ErrorCode");
			listDatabaseUserPermssionsResponse.TotalCount = context.LongValue("ListDatabaseUserPermssions.TotalCount");

			List<ListDatabaseUserPermssionsResponse.ListDatabaseUserPermssions_UserPermission> listDatabaseUserPermssionsResponse_userPermissions = new List<ListDatabaseUserPermssionsResponse.ListDatabaseUserPermssions_UserPermission>();
			for (int i = 0; i < context.Length("ListDatabaseUserPermssions.UserPermissions.Length"); i++) {
				ListDatabaseUserPermssionsResponse.ListDatabaseUserPermssions_UserPermission userPermission = new ListDatabaseUserPermssionsResponse.ListDatabaseUserPermssions_UserPermission();
				userPermission.UserId = context.StringValue("ListDatabaseUserPermssions.UserPermissions["+ i +"].UserId");
				userPermission.UserNickName = context.StringValue("ListDatabaseUserPermssions.UserPermissions["+ i +"].UserNickName");
				userPermission.DsType = context.StringValue("ListDatabaseUserPermssions.UserPermissions["+ i +"].DsType");
				userPermission.DbId = context.StringValue("ListDatabaseUserPermssions.UserPermissions["+ i +"].DbId");
				userPermission.Logic = context.BooleanValue("ListDatabaseUserPermssions.UserPermissions["+ i +"].Logic");
				userPermission.SchemaName = context.StringValue("ListDatabaseUserPermssions.UserPermissions["+ i +"].SchemaName");
				userPermission.SearchName = context.StringValue("ListDatabaseUserPermssions.UserPermissions["+ i +"].SearchName");
				userPermission.InstanceId = context.StringValue("ListDatabaseUserPermssions.UserPermissions["+ i +"].InstanceId");
				userPermission.EnvType = context.StringValue("ListDatabaseUserPermssions.UserPermissions["+ i +"].EnvType");
				userPermission.Alias = context.StringValue("ListDatabaseUserPermssions.UserPermissions["+ i +"].Alias");
				userPermission.DbType = context.StringValue("ListDatabaseUserPermssions.UserPermissions["+ i +"].DbType");
				userPermission.TableName = context.StringValue("ListDatabaseUserPermssions.UserPermissions["+ i +"].TableName");
				userPermission.TableId = context.StringValue("ListDatabaseUserPermssions.UserPermissions["+ i +"].TableId");
				userPermission.ColumnName = context.StringValue("ListDatabaseUserPermssions.UserPermissions["+ i +"].ColumnName");

				List<ListDatabaseUserPermssionsResponse.ListDatabaseUserPermssions_UserPermission.ListDatabaseUserPermssions_PermDetail> userPermission_permDetails = new List<ListDatabaseUserPermssionsResponse.ListDatabaseUserPermssions_UserPermission.ListDatabaseUserPermssions_PermDetail>();
				for (int j = 0; j < context.Length("ListDatabaseUserPermssions.UserPermissions["+ i +"].PermDetails.Length"); j++) {
					ListDatabaseUserPermssionsResponse.ListDatabaseUserPermssions_UserPermission.ListDatabaseUserPermssions_PermDetail permDetail = new ListDatabaseUserPermssionsResponse.ListDatabaseUserPermssions_UserPermission.ListDatabaseUserPermssions_PermDetail();
					permDetail.PermType = context.StringValue("ListDatabaseUserPermssions.UserPermissions["+ i +"].PermDetails["+ j +"].PermType");
					permDetail.ExpireDate = context.StringValue("ListDatabaseUserPermssions.UserPermissions["+ i +"].PermDetails["+ j +"].ExpireDate");
					permDetail.CreateDate = context.StringValue("ListDatabaseUserPermssions.UserPermissions["+ i +"].PermDetails["+ j +"].CreateDate");
					permDetail.OriginFrom = context.StringValue("ListDatabaseUserPermssions.UserPermissions["+ i +"].PermDetails["+ j +"].OriginFrom");
					permDetail.UserAccessId = context.StringValue("ListDatabaseUserPermssions.UserPermissions["+ i +"].PermDetails["+ j +"].UserAccessId");
					permDetail.ExtraData = context.StringValue("ListDatabaseUserPermssions.UserPermissions["+ i +"].PermDetails["+ j +"].ExtraData");

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
