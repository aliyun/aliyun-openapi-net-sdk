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
using Aliyun.Acs.cloudesl.Model.V20200201;

namespace Aliyun.Acs.cloudesl.Transform.V20200201
{
    public class DescribeRoleActionsResponseUnmarshaller
    {
        public static DescribeRoleActionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRoleActionsResponse describeRoleActionsResponse = new DescribeRoleActionsResponse();

			describeRoleActionsResponse.HttpResponse = _ctx.HttpResponse;
			describeRoleActionsResponse.ErrorMessage = _ctx.StringValue("DescribeRoleActions.ErrorMessage");
			describeRoleActionsResponse.ErrorCode = _ctx.StringValue("DescribeRoleActions.ErrorCode");
			describeRoleActionsResponse.Message = _ctx.StringValue("DescribeRoleActions.Message");
			describeRoleActionsResponse.DynamicCode = _ctx.StringValue("DescribeRoleActions.DynamicCode");
			describeRoleActionsResponse.Code = _ctx.StringValue("DescribeRoleActions.Code");
			describeRoleActionsResponse.DynamicMessage = _ctx.StringValue("DescribeRoleActions.DynamicMessage");
			describeRoleActionsResponse.RequestId = _ctx.StringValue("DescribeRoleActions.RequestId");
			describeRoleActionsResponse.Success = _ctx.BooleanValue("DescribeRoleActions.Success");

			List<DescribeRoleActionsResponse.DescribeRoleActions_RoleAclInfo> describeRoleActionsResponse_roleAclInfos = new List<DescribeRoleActionsResponse.DescribeRoleActions_RoleAclInfo>();
			for (int i = 0; i < _ctx.Length("DescribeRoleActions.RoleAclInfos.Length"); i++) {
				DescribeRoleActionsResponse.DescribeRoleActions_RoleAclInfo roleAclInfo = new DescribeRoleActionsResponse.DescribeRoleActions_RoleAclInfo();
				roleAclInfo.RoleCode = _ctx.StringValue("DescribeRoleActions.RoleAclInfos["+ i +"].RoleCode");
				roleAclInfo.Name = _ctx.StringValue("DescribeRoleActions.RoleAclInfos["+ i +"].Name");

				List<DescribeRoleActionsResponse.DescribeRoleActions_RoleAclInfo.DescribeRoleActions_RoleActionInfo> roleAclInfo_accessControlLists = new List<DescribeRoleActionsResponse.DescribeRoleActions_RoleAclInfo.DescribeRoleActions_RoleActionInfo>();
				for (int j = 0; j < _ctx.Length("DescribeRoleActions.RoleAclInfos["+ i +"].AccessControlLists.Length"); j++) {
					DescribeRoleActionsResponse.DescribeRoleActions_RoleAclInfo.DescribeRoleActions_RoleActionInfo roleActionInfo = new DescribeRoleActionsResponse.DescribeRoleActions_RoleAclInfo.DescribeRoleActions_RoleActionInfo();
					roleActionInfo.Code = _ctx.StringValue("DescribeRoleActions.RoleAclInfos["+ i +"].AccessControlLists["+ j +"].Code");

					roleAclInfo_accessControlLists.Add(roleActionInfo);
				}
				roleAclInfo.AccessControlLists = roleAclInfo_accessControlLists;

				describeRoleActionsResponse_roleAclInfos.Add(roleAclInfo);
			}
			describeRoleActionsResponse.RoleAclInfos = describeRoleActionsResponse_roleAclInfos;
        
			return describeRoleActionsResponse;
        }
    }
}
