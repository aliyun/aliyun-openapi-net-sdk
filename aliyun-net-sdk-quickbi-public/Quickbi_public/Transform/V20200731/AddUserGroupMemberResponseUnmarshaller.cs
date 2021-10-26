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
using Aliyun.Acs.quickbi_public.Model.V20200731;

namespace Aliyun.Acs.quickbi_public.Transform.V20200731
{
    public class AddUserGroupMemberResponseUnmarshaller
    {
        public static AddUserGroupMemberResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AddUserGroupMemberResponse addUserGroupMemberResponse = new AddUserGroupMemberResponse();

			addUserGroupMemberResponse.HttpResponse = _ctx.HttpResponse;
			addUserGroupMemberResponse.RequestId = _ctx.StringValue("AddUserGroupMember.RequestId");
			addUserGroupMemberResponse.Result = _ctx.BooleanValue("AddUserGroupMember.Result");
			addUserGroupMemberResponse.Success = _ctx.BooleanValue("AddUserGroupMember.Success");
        
			return addUserGroupMemberResponse;
        }
    }
}
