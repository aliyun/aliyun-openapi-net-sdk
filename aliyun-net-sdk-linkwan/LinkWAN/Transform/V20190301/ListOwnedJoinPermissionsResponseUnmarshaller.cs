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
using Aliyun.Acs.LinkWAN.Model.V20190301;

namespace Aliyun.Acs.LinkWAN.Transform.V20190301
{
    public class ListOwnedJoinPermissionsResponseUnmarshaller
    {
        public static ListOwnedJoinPermissionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListOwnedJoinPermissionsResponse listOwnedJoinPermissionsResponse = new ListOwnedJoinPermissionsResponse();

			listOwnedJoinPermissionsResponse.HttpResponse = _ctx.HttpResponse;
			listOwnedJoinPermissionsResponse.RequestId = _ctx.StringValue("ListOwnedJoinPermissions.RequestId");
			listOwnedJoinPermissionsResponse.Success = _ctx.BooleanValue("ListOwnedJoinPermissions.Success");

			ListOwnedJoinPermissionsResponse.ListOwnedJoinPermissions_Data data = new ListOwnedJoinPermissionsResponse.ListOwnedJoinPermissions_Data();
			data.TotalCount = _ctx.LongValue("ListOwnedJoinPermissions.Data.TotalCount");

			List<ListOwnedJoinPermissionsResponse.ListOwnedJoinPermissions_Data.ListOwnedJoinPermissions_JoinPermission> data_list = new List<ListOwnedJoinPermissionsResponse.ListOwnedJoinPermissions_Data.ListOwnedJoinPermissions_JoinPermission>();
			for (int i = 0; i < _ctx.Length("ListOwnedJoinPermissions.Data.List.Length"); i++) {
				ListOwnedJoinPermissionsResponse.ListOwnedJoinPermissions_Data.ListOwnedJoinPermissions_JoinPermission joinPermission = new ListOwnedJoinPermissionsResponse.ListOwnedJoinPermissions_Data.ListOwnedJoinPermissions_JoinPermission();
				joinPermission.JoinPermissionId = _ctx.StringValue("ListOwnedJoinPermissions.Data.List["+ i +"].JoinPermissionId");
				joinPermission.RenterAliyunId = _ctx.StringValue("ListOwnedJoinPermissions.Data.List["+ i +"].RenterAliyunId");
				joinPermission.JoinEui = _ctx.StringValue("ListOwnedJoinPermissions.Data.List["+ i +"].JoinEui");
				joinPermission.FreqBandPlanGroupId = _ctx.LongValue("ListOwnedJoinPermissions.Data.List["+ i +"].FreqBandPlanGroupId");
				joinPermission.ClassMode = _ctx.StringValue("ListOwnedJoinPermissions.Data.List["+ i +"].ClassMode");
				joinPermission.AuthState = _ctx.StringValue("ListOwnedJoinPermissions.Data.List["+ i +"].AuthState");
				joinPermission.Enabled = _ctx.BooleanValue("ListOwnedJoinPermissions.Data.List["+ i +"].Enabled");
				joinPermission.JoinPermissionName = _ctx.StringValue("ListOwnedJoinPermissions.Data.List["+ i +"].JoinPermissionName");
				joinPermission.RxDelay = _ctx.LongValue("ListOwnedJoinPermissions.Data.List["+ i +"].RxDelay");
				joinPermission.DataRate = _ctx.LongValue("ListOwnedJoinPermissions.Data.List["+ i +"].DataRate");

				data_list.Add(joinPermission);
			}
			data.List = data_list;
			listOwnedJoinPermissionsResponse.Data = data;
        
			return listOwnedJoinPermissionsResponse;
        }
    }
}
