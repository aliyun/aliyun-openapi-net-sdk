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
using Aliyun.Acs.Ram.Model.V20150501;

namespace Aliyun.Acs.Ram.Transform.V20150501
{
    public class GetRoleResponseUnmarshaller
    {
        public static GetRoleResponse Unmarshall(UnmarshallerContext context)
        {
			GetRoleResponse getRoleResponse = new GetRoleResponse();

			getRoleResponse.HttpResponse = context.HttpResponse;
			getRoleResponse.RequestId = context.StringValue("GetRole.RequestId");

			GetRoleResponse.GetRole_Role role = new GetRoleResponse.GetRole_Role();
			role.RoleId = context.StringValue("GetRole.Role.RoleId");
			role.RoleName = context.StringValue("GetRole.Role.RoleName");
			role.Arn = context.StringValue("GetRole.Role.Arn");
			role.Description = context.StringValue("GetRole.Role.Description");
			role.AssumeRolePolicyDocument = context.StringValue("GetRole.Role.AssumeRolePolicyDocument");
			role.CreateDate = context.StringValue("GetRole.Role.CreateDate");
			role.UpdateDate = context.StringValue("GetRole.Role.UpdateDate");
			role.MaxSessionDuration = context.LongValue("GetRole.Role.MaxSessionDuration");
			getRoleResponse.Role = role;
        
			return getRoleResponse;
        }
    }
}
