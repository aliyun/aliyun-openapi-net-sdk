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
using Aliyun.Acs.Vcs.Model.V20200515;

namespace Aliyun.Acs.Vcs.Transform.V20200515
{
    public class CreateUserGroupResponseUnmarshaller
    {
        public static CreateUserGroupResponse Unmarshall(UnmarshallerContext context)
        {
			CreateUserGroupResponse createUserGroupResponse = new CreateUserGroupResponse();

			createUserGroupResponse.HttpResponse = context.HttpResponse;
			createUserGroupResponse.Code = context.StringValue("CreateUserGroup.Code");
			createUserGroupResponse.Message = context.StringValue("CreateUserGroup.Message");
			createUserGroupResponse.RequestId = context.StringValue("CreateUserGroup.RequestId");

			CreateUserGroupResponse.CreateUserGroup_Data data = new CreateUserGroupResponse.CreateUserGroup_Data();
			data.UserGroupName = context.StringValue("CreateUserGroup.Data.UserGroupName");
			data.IsvSubId = context.StringValue("CreateUserGroup.Data.IsvSubId");
			data.UserGroupId = context.LongValue("CreateUserGroup.Data.UserGroupId");
			createUserGroupResponse.Data = data;
        
			return createUserGroupResponse;
        }
    }
}
