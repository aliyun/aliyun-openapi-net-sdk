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
    public class CreateRepositoryResponseUnmarshaller
    {
        public static CreateRepositoryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateRepositoryResponse createRepositoryResponse = new CreateRepositoryResponse();

			createRepositoryResponse.HttpResponse = _ctx.HttpResponse;
			createRepositoryResponse.ErrorCode = _ctx.IntegerValue("CreateRepository.ErrorCode");
			createRepositoryResponse.ErrorMessage = _ctx.StringValue("CreateRepository.ErrorMessage");
			createRepositoryResponse.RequestId = _ctx.StringValue("CreateRepository.RequestId");
			createRepositoryResponse.Success = _ctx.BooleanValue("CreateRepository.Success");

			CreateRepositoryResponse.CreateRepository_Result result = new CreateRepositoryResponse.CreateRepository_Result();
			result.Id = _ctx.LongValue("CreateRepository.Result.Id");
			result.SshUrlToRepo = _ctx.StringValue("CreateRepository.Result.SshUrlToRepo");
			result.Description = _ctx.StringValue("CreateRepository.Result.Description");
			result.DefaultBranch = _ctx.StringValue("CreateRepository.Result.DefaultBranch");
			result._Public = _ctx.BooleanValue("CreateRepository.Result.Public");
			result.VisibilityLevel = _ctx.StringValue("CreateRepository.Result.VisibilityLevel");
			result.HttpUrlToRepo = _ctx.StringValue("CreateRepository.Result.HttpUrlToRepo");
			result.WebUrl = _ctx.StringValue("CreateRepository.Result.WebUrl");
			result.Name = _ctx.StringValue("CreateRepository.Result.Name");
			result.NameWithNamespace = _ctx.StringValue("CreateRepository.Result.NameWithNamespace");
			result.Path = _ctx.StringValue("CreateRepository.Result.Path");
			result.PathWithNamespace = _ctx.StringValue("CreateRepository.Result.PathWithNamespace");
			result.IssuesEnableStatus = _ctx.BooleanValue("CreateRepository.Result.IssuesEnableStatus");
			result.MergeRequestEnableStatus = _ctx.BooleanValue("CreateRepository.Result.MergeRequestEnableStatus");
			result.BuildsEnableStatus = _ctx.BooleanValue("CreateRepository.Result.BuildsEnableStatus");
			result.WikiEnableStatus = _ctx.BooleanValue("CreateRepository.Result.WikiEnableStatus");
			result.SnippetsEnableStatus = _ctx.BooleanValue("CreateRepository.Result.SnippetsEnableStatus");
			result.CreatedAt = _ctx.StringValue("CreateRepository.Result.CreatedAt");
			result.LastActivityAt = _ctx.StringValue("CreateRepository.Result.LastActivityAt");
			result.CreatorId = _ctx.LongValue("CreateRepository.Result.CreatorId");
			result.Archive = _ctx.BooleanValue("CreateRepository.Result.Archive");
			result.AvatarUrl = _ctx.StringValue("CreateRepository.Result.AvatarUrl");
			result.DemoProjectStatus = _ctx.BooleanValue("CreateRepository.Result.DemoProjectStatus");

			List<string> result_tagList = new List<string>();
			for (int i = 0; i < _ctx.Length("CreateRepository.Result.TagList.Length"); i++) {
				result_tagList.Add(_ctx.StringValue("CreateRepository.Result.TagList["+ i +"]"));
			}
			result.TagList = result_tagList;

			CreateRepositoryResponse.CreateRepository_Result.CreateRepository__Namespace _namespace = new CreateRepositoryResponse.CreateRepository_Result.CreateRepository__Namespace();
			_namespace.Id = _ctx.LongValue("CreateRepository.Result.Namespace.Id");
			_namespace.Name = _ctx.StringValue("CreateRepository.Result.Namespace.Name");
			_namespace.Path = _ctx.StringValue("CreateRepository.Result.Namespace.Path");
			_namespace.OwnerId = _ctx.LongValue("CreateRepository.Result.Namespace.OwnerId");
			_namespace.CreatedAt = _ctx.StringValue("CreateRepository.Result.Namespace.CreatedAt");
			_namespace.UpdatedAt = _ctx.StringValue("CreateRepository.Result.Namespace.UpdatedAt");
			_namespace.Description = _ctx.StringValue("CreateRepository.Result.Namespace.Description");
			_namespace.State = _ctx.StringValue("CreateRepository.Result.Namespace.State");
			_namespace.Avatar = _ctx.StringValue("CreateRepository.Result.Namespace.Avatar");
			_namespace._Public = _ctx.BooleanValue("CreateRepository.Result.Namespace.Public");
			_namespace.VisibilityLevel = _ctx.StringValue("CreateRepository.Result.Namespace.VisibilityLevel");
			result._Namespace = _namespace;
			createRepositoryResponse.Result = result;
        
			return createRepositoryResponse;
        }
    }
}
