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
using Aliyun.Acs.quickbi_public.Model.V20220101;

namespace Aliyun.Acs.quickbi_public.Transform.V20220101
{
    public class AddWorkspaceUsersResponseUnmarshaller
    {
        public static AddWorkspaceUsersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AddWorkspaceUsersResponse addWorkspaceUsersResponse = new AddWorkspaceUsersResponse();

			addWorkspaceUsersResponse.HttpResponse = _ctx.HttpResponse;
			addWorkspaceUsersResponse.Success = _ctx.BooleanValue("AddWorkspaceUsers.Success");
			addWorkspaceUsersResponse.RequestId = _ctx.StringValue("AddWorkspaceUsers.RequestId");

			AddWorkspaceUsersResponse.AddWorkspaceUsers_Result result = new AddWorkspaceUsersResponse.AddWorkspaceUsers_Result();
			result.Failure = _ctx.IntegerValue("AddWorkspaceUsers.Result.Failure");
			result.FailureDetail = _ctx.StringValue("AddWorkspaceUsers.Result.FailureDetail");
			result.Success = _ctx.IntegerValue("AddWorkspaceUsers.Result.Success");
			result.Total = _ctx.IntegerValue("AddWorkspaceUsers.Result.Total");
			addWorkspaceUsersResponse.Result = result;
        
			return addWorkspaceUsersResponse;
        }
    }
}
