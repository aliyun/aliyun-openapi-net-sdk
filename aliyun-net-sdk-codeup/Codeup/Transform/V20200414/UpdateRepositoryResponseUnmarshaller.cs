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
    public class UpdateRepositoryResponseUnmarshaller
    {
        public static UpdateRepositoryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateRepositoryResponse updateRepositoryResponse = new UpdateRepositoryResponse();

			updateRepositoryResponse.HttpResponse = _ctx.HttpResponse;
			updateRepositoryResponse.ErrorCode = _ctx.StringValue("UpdateRepository.ErrorCode");
			updateRepositoryResponse.ErrorMessage = _ctx.StringValue("UpdateRepository.ErrorMessage");
			updateRepositoryResponse.RequestId = _ctx.StringValue("UpdateRepository.RequestId");
			updateRepositoryResponse.Success = _ctx.BooleanValue("UpdateRepository.Success");

			UpdateRepositoryResponse.UpdateRepository_Result result = new UpdateRepositoryResponse.UpdateRepository_Result();
			result.Archive = _ctx.BooleanValue("UpdateRepository.Result.Archive");
			result.AvatarUrl = _ctx.StringValue("UpdateRepository.Result.AvatarUrl");
			result.CreatedAt = _ctx.StringValue("UpdateRepository.Result.CreatedAt");
			result.CreatorId = _ctx.LongValue("UpdateRepository.Result.CreatorId");
			result.DefaultBranch = _ctx.StringValue("UpdateRepository.Result.DefaultBranch");
			result.Description = _ctx.StringValue("UpdateRepository.Result.Description");
			result.HttpUrlToRepo = _ctx.StringValue("UpdateRepository.Result.HttpUrlToRepo");
			result.Id = _ctx.LongValue("UpdateRepository.Result.Id");
			result.LastActivityAt = _ctx.StringValue("UpdateRepository.Result.LastActivityAt");
			result.Name = _ctx.StringValue("UpdateRepository.Result.Name");
			result.NameWithNamespace = _ctx.StringValue("UpdateRepository.Result.NameWithNamespace");
			result.Path = _ctx.StringValue("UpdateRepository.Result.Path");
			result.PathWithNamespace = _ctx.StringValue("UpdateRepository.Result.PathWithNamespace");
			result.SshUrlToRepo = _ctx.StringValue("UpdateRepository.Result.SshUrlToRepo");
			result.VisibilityLevel = _ctx.StringValue("UpdateRepository.Result.VisibilityLevel");
			result.WebUrl = _ctx.StringValue("UpdateRepository.Result.WebUrl");

			UpdateRepositoryResponse.UpdateRepository_Result.UpdateRepository__Namespace _namespace = new UpdateRepositoryResponse.UpdateRepository_Result.UpdateRepository__Namespace();
			_namespace.Avatar = _ctx.StringValue("UpdateRepository.Result.Namespace.Avatar");
			_namespace.CreatedAt = _ctx.StringValue("UpdateRepository.Result.Namespace.CreatedAt");
			_namespace.Description = _ctx.StringValue("UpdateRepository.Result.Namespace.Description");
			_namespace.Id = _ctx.LongValue("UpdateRepository.Result.Namespace.Id");
			_namespace.Name = _ctx.StringValue("UpdateRepository.Result.Namespace.Name");
			_namespace.OwnerId = _ctx.LongValue("UpdateRepository.Result.Namespace.OwnerId");
			_namespace.Path = _ctx.StringValue("UpdateRepository.Result.Namespace.Path");
			_namespace._Public = _ctx.BooleanValue("UpdateRepository.Result.Namespace.Public");
			_namespace.UpdatedAt = _ctx.StringValue("UpdateRepository.Result.Namespace.UpdatedAt");
			_namespace.VisibilityLevel = _ctx.StringValue("UpdateRepository.Result.Namespace.VisibilityLevel");
			result._Namespace = _namespace;
			updateRepositoryResponse.Result = result;
        
			return updateRepositoryResponse;
        }
    }
}
