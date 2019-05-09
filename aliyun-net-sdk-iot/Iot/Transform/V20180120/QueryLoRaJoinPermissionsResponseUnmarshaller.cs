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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class QueryLoRaJoinPermissionsResponseUnmarshaller
    {
        public static QueryLoRaJoinPermissionsResponse Unmarshall(UnmarshallerContext context)
        {
			QueryLoRaJoinPermissionsResponse queryLoRaJoinPermissionsResponse = new QueryLoRaJoinPermissionsResponse();

			queryLoRaJoinPermissionsResponse.HttpResponse = context.HttpResponse;
			queryLoRaJoinPermissionsResponse.RequestId = context.StringValue("QueryLoRaJoinPermissions.RequestId");
			queryLoRaJoinPermissionsResponse.Success = context.BooleanValue("QueryLoRaJoinPermissions.Success");
			queryLoRaJoinPermissionsResponse.Code = context.StringValue("QueryLoRaJoinPermissions.Code");
			queryLoRaJoinPermissionsResponse.ErrorMessage = context.StringValue("QueryLoRaJoinPermissions.ErrorMessage");
			queryLoRaJoinPermissionsResponse.ProductKey = context.StringValue("QueryLoRaJoinPermissions.ProductKey");

			List<QueryLoRaJoinPermissionsResponse.QueryLoRaJoinPermissions_JoinPermission> queryLoRaJoinPermissionsResponse_joinPermissions = new List<QueryLoRaJoinPermissionsResponse.QueryLoRaJoinPermissions_JoinPermission>();
			for (int i = 0; i < context.Length("QueryLoRaJoinPermissions.JoinPermissions.Length"); i++) {
				QueryLoRaJoinPermissionsResponse.QueryLoRaJoinPermissions_JoinPermission joinPermission = new QueryLoRaJoinPermissionsResponse.QueryLoRaJoinPermissions_JoinPermission();
				joinPermission.JoinPermissionId = context.StringValue("QueryLoRaJoinPermissions.JoinPermissions["+ i +"].JoinPermissionId");
				joinPermission.JoinPermissionName = context.StringValue("QueryLoRaJoinPermissions.JoinPermissions["+ i +"].JoinPermissionName");
				joinPermission.JoinPermissionType = context.StringValue("QueryLoRaJoinPermissions.JoinPermissions["+ i +"].JoinPermissionType");
				joinPermission.OwnerAliyunPk = context.StringValue("QueryLoRaJoinPermissions.JoinPermissions["+ i +"].OwnerAliyunPk");
				joinPermission.Enabled = context.BooleanValue("QueryLoRaJoinPermissions.JoinPermissions["+ i +"].Enabled");
				joinPermission.ClassMode = context.StringValue("QueryLoRaJoinPermissions.JoinPermissions["+ i +"].ClassMode");

				queryLoRaJoinPermissionsResponse_joinPermissions.Add(joinPermission);
			}
			queryLoRaJoinPermissionsResponse.JoinPermissions = queryLoRaJoinPermissionsResponse_joinPermissions;
        
			return queryLoRaJoinPermissionsResponse;
        }
    }
}
