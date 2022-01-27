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
using Aliyun.Acs.codeup.Model.V20200414;

namespace Aliyun.Acs.codeup.Transform.V20200414
{
    public class CreateRepositoryGroupResponseUnmarshaller
    {
        public static CreateRepositoryGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateRepositoryGroupResponse createRepositoryGroupResponse = new CreateRepositoryGroupResponse();

			createRepositoryGroupResponse.HttpResponse = _ctx.HttpResponse;
			createRepositoryGroupResponse.ErrorCode = _ctx.IntegerValue("CreateRepositoryGroup.ErrorCode");
			createRepositoryGroupResponse.ErrorMessage = _ctx.StringValue("CreateRepositoryGroup.ErrorMessage");
			createRepositoryGroupResponse.RequestId = _ctx.StringValue("CreateRepositoryGroup.RequestId");
			createRepositoryGroupResponse.Success = _ctx.BooleanValue("CreateRepositoryGroup.Success");

			CreateRepositoryGroupResponse.CreateRepositoryGroup_Result result = new CreateRepositoryGroupResponse.CreateRepositoryGroup_Result();
			result.Id = _ctx.LongValue("CreateRepositoryGroup.Result.Id");
			result.Description = _ctx.StringValue("CreateRepositoryGroup.Result.Description");
			result.VisibilityLevel = _ctx.StringValue("CreateRepositoryGroup.Result.VisibilityLevel");
			result.WebUrl = _ctx.StringValue("CreateRepositoryGroup.Result.WebUrl");
			result.Name = _ctx.StringValue("CreateRepositoryGroup.Result.Name");
			result.NameWithNamespace = _ctx.StringValue("CreateRepositoryGroup.Result.NameWithNamespace");
			result.Path = _ctx.StringValue("CreateRepositoryGroup.Result.Path");
			result.PathWithNamespace = _ctx.StringValue("CreateRepositoryGroup.Result.PathWithNamespace");
			result.ParentId = _ctx.LongValue("CreateRepositoryGroup.Result.ParentId");
			result.OwnerId = _ctx.LongValue("CreateRepositoryGroup.Result.OwnerId");
			result.AvatarUrl = _ctx.StringValue("CreateRepositoryGroup.Result.AvatarUrl");
			result.Type = _ctx.StringValue("CreateRepositoryGroup.Result.Type");
			createRepositoryGroupResponse.Result = result;
        
			return createRepositoryGroupResponse;
        }
    }
}
