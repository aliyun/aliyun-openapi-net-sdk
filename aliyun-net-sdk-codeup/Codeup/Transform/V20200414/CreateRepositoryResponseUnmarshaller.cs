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
        public static CreateRepositoryResponse Unmarshall(UnmarshallerContext context)
        {
			CreateRepositoryResponse createRepositoryResponse = new CreateRepositoryResponse();

			createRepositoryResponse.HttpResponse = context.HttpResponse;
			createRepositoryResponse.ErrorCode = context.IntegerValue("CreateRepository.ErrorCode");
			createRepositoryResponse.ErrorMessage = context.StringValue("CreateRepository.ErrorMessage");
			createRepositoryResponse.RequestId = context.StringValue("CreateRepository.RequestId");
			createRepositoryResponse.Success = context.BooleanValue("CreateRepository.Success");

			CreateRepositoryResponse.CreateRepository_Result result = new CreateRepositoryResponse.CreateRepository_Result();
			result.Id = context.LongValue("CreateRepository.Result.Id");
			result.SshUrlToRepo = context.StringValue("CreateRepository.Result.SshUrlToRepo");
			result.Description = context.StringValue("CreateRepository.Result.Description");
			result.DefaultBranch = context.StringValue("CreateRepository.Result.DefaultBranch");
			result._Public = context.BooleanValue("CreateRepository.Result.Public");
			result.VisibilityLevel = context.StringValue("CreateRepository.Result.VisibilityLevel");
			result.HttpUrlToRepo = context.StringValue("CreateRepository.Result.HttpUrlToRepo");
			result.WebUrl = context.StringValue("CreateRepository.Result.WebUrl");
			result.Name = context.StringValue("CreateRepository.Result.Name");
			result.NameWithNamespace = context.StringValue("CreateRepository.Result.NameWithNamespace");
			result.Path = context.StringValue("CreateRepository.Result.Path");
			result.PathWithNamespace = context.StringValue("CreateRepository.Result.PathWithNamespace");
			result.IssuesEnableStatus = context.BooleanValue("CreateRepository.Result.IssuesEnableStatus");
			result.MergeRequestEnableStatus = context.BooleanValue("CreateRepository.Result.MergeRequestEnableStatus");
			result.BuildsEnableStatus = context.BooleanValue("CreateRepository.Result.BuildsEnableStatus");
			result.WikiEnableStatus = context.BooleanValue("CreateRepository.Result.WikiEnableStatus");
			result.SnippetsEnableStatus = context.BooleanValue("CreateRepository.Result.SnippetsEnableStatus");
			result.CreatedAt = context.StringValue("CreateRepository.Result.CreatedAt");
			result.LastActivityAt = context.StringValue("CreateRepository.Result.LastActivityAt");
			result.CreatorId = context.LongValue("CreateRepository.Result.CreatorId");
			result.Archive = context.BooleanValue("CreateRepository.Result.Archive");
			result.AvatarUrl = context.StringValue("CreateRepository.Result.AvatarUrl");
			result.DemoProjectStatus = context.BooleanValue("CreateRepository.Result.DemoProjectStatus");

			List<string> result_tagList = new List<string>();
			for (int i = 0; i < context.Length("CreateRepository.Result.TagList.Length"); i++) {
				result_tagList.Add(context.StringValue("CreateRepository.Result.TagList["+ i +"]"));
			}
			result.TagList = result_tagList;

			CreateRepositoryResponse.CreateRepository_Result.CreateRepository__Namespace _namespace = new CreateRepositoryResponse.CreateRepository_Result.CreateRepository__Namespace();
			_namespace.Id = context.LongValue("CreateRepository.Result.Namespace.Id");
			_namespace.Name = context.StringValue("CreateRepository.Result.Namespace.Name");
			_namespace.Path = context.StringValue("CreateRepository.Result.Namespace.Path");
			_namespace.OwnerId = context.LongValue("CreateRepository.Result.Namespace.OwnerId");
			_namespace.CreatedAt = context.StringValue("CreateRepository.Result.Namespace.CreatedAt");
			_namespace.UpdatedAt = context.StringValue("CreateRepository.Result.Namespace.UpdatedAt");
			_namespace.Description = context.StringValue("CreateRepository.Result.Namespace.Description");
			_namespace.State = context.StringValue("CreateRepository.Result.Namespace.State");
			_namespace.Avatar = context.StringValue("CreateRepository.Result.Namespace.Avatar");
			_namespace._Public = context.BooleanValue("CreateRepository.Result.Namespace.Public");
			_namespace.VisibilityLevel = context.StringValue("CreateRepository.Result.Namespace.VisibilityLevel");
			result._Namespace = _namespace;
			createRepositoryResponse.Result = result;
        
			return createRepositoryResponse;
        }
    }
}
