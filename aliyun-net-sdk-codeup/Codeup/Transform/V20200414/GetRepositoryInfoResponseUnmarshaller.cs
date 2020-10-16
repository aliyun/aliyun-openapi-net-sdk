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
    public class GetRepositoryInfoResponseUnmarshaller
    {
        public static GetRepositoryInfoResponse Unmarshall(UnmarshallerContext context)
        {
			GetRepositoryInfoResponse getRepositoryInfoResponse = new GetRepositoryInfoResponse();

			getRepositoryInfoResponse.HttpResponse = context.HttpResponse;
			getRepositoryInfoResponse.ErrorCode = context.IntegerValue("GetRepositoryInfo.ErrorCode");
			getRepositoryInfoResponse.ErrorMessage = context.StringValue("GetRepositoryInfo.ErrorMessage");
			getRepositoryInfoResponse.RequestId = context.StringValue("GetRepositoryInfo.RequestId");
			getRepositoryInfoResponse.Success = context.BooleanValue("GetRepositoryInfo.Success");

			GetRepositoryInfoResponse.GetRepositoryInfo_Result result = new GetRepositoryInfoResponse.GetRepositoryInfo_Result();
			result.Id = context.LongValue("GetRepositoryInfo.Result.Id");
			result.SshUrlToRepo = context.StringValue("GetRepositoryInfo.Result.SshUrlToRepo");
			result.Description = context.StringValue("GetRepositoryInfo.Result.Description");
			result.DefaultBranch = context.StringValue("GetRepositoryInfo.Result.DefaultBranch");
			result._Public = context.BooleanValue("GetRepositoryInfo.Result.Public");
			result.VisibilityLevel = context.StringValue("GetRepositoryInfo.Result.VisibilityLevel");
			result.HttpUrlToRepo = context.StringValue("GetRepositoryInfo.Result.HttpUrlToRepo");
			result.WebUrl = context.StringValue("GetRepositoryInfo.Result.WebUrl");
			result.Name = context.StringValue("GetRepositoryInfo.Result.Name");
			result.NameWithNamespace = context.StringValue("GetRepositoryInfo.Result.NameWithNamespace");
			result.Path = context.StringValue("GetRepositoryInfo.Result.Path");
			result.PathWithNamespace = context.StringValue("GetRepositoryInfo.Result.PathWithNamespace");
			result.CreatedAt = context.StringValue("GetRepositoryInfo.Result.CreatedAt");
			result.LastActivityAt = context.StringValue("GetRepositoryInfo.Result.LastActivityAt");
			result.CreatorId = context.LongValue("GetRepositoryInfo.Result.CreatorId");
			result.Archive = context.BooleanValue("GetRepositoryInfo.Result.Archive");
			result.AvatarUrl = context.StringValue("GetRepositoryInfo.Result.AvatarUrl");
			result.DemoProjectStatus = context.BooleanValue("GetRepositoryInfo.Result.DemoProjectStatus");
			result.AccessLevel = context.IntegerValue("GetRepositoryInfo.Result.AccessLevel");
			result.ImportStatus = context.StringValue("GetRepositoryInfo.Result.ImportStatus");
			result.ImportUrl = context.StringValue("GetRepositoryInfo.Result.ImportUrl");
			result.ImportFromSubversion = context.BooleanValue("GetRepositoryInfo.Result.ImportFromSubversion");

			List<string> result_tagList = new List<string>();
			for (int i = 0; i < context.Length("GetRepositoryInfo.Result.TagList.Length"); i++) {
				result_tagList.Add(context.StringValue("GetRepositoryInfo.Result.TagList["+ i +"]"));
			}
			result.TagList = result_tagList;

			GetRepositoryInfoResponse.GetRepositoryInfo_Result.GetRepositoryInfo__Namespace _namespace = new GetRepositoryInfoResponse.GetRepositoryInfo_Result.GetRepositoryInfo__Namespace();
			_namespace.Id = context.LongValue("GetRepositoryInfo.Result.Namespace.Id");
			_namespace.Name = context.StringValue("GetRepositoryInfo.Result.Namespace.Name");
			_namespace.Path = context.StringValue("GetRepositoryInfo.Result.Namespace.Path");
			_namespace.OwnerId = context.LongValue("GetRepositoryInfo.Result.Namespace.OwnerId");
			_namespace.CreatedAt = context.StringValue("GetRepositoryInfo.Result.Namespace.CreatedAt");
			_namespace.UpdatedAt = context.StringValue("GetRepositoryInfo.Result.Namespace.UpdatedAt");
			_namespace.Description = context.StringValue("GetRepositoryInfo.Result.Namespace.Description");
			_namespace.State = context.StringValue("GetRepositoryInfo.Result.Namespace.State");
			_namespace.Avatar = context.StringValue("GetRepositoryInfo.Result.Namespace.Avatar");
			_namespace._Public = context.BooleanValue("GetRepositoryInfo.Result.Namespace.Public");
			_namespace.VisibilityLevel = context.StringValue("GetRepositoryInfo.Result.Namespace.VisibilityLevel");
			result._Namespace = _namespace;

			GetRepositoryInfoResponse.GetRepositoryInfo_Result.GetRepositoryInfo_Permissions permissions = new GetRepositoryInfoResponse.GetRepositoryInfo_Result.GetRepositoryInfo_Permissions();

			GetRepositoryInfoResponse.GetRepositoryInfo_Result.GetRepositoryInfo_Permissions.GetRepositoryInfo_ProjectAccess projectAccess = new GetRepositoryInfoResponse.GetRepositoryInfo_Result.GetRepositoryInfo_Permissions.GetRepositoryInfo_ProjectAccess();
			projectAccess.AccessLevel = context.IntegerValue("GetRepositoryInfo.Result.Permissions.ProjectAccess.AccessLevel");
			permissions.ProjectAccess = projectAccess;

			GetRepositoryInfoResponse.GetRepositoryInfo_Result.GetRepositoryInfo_Permissions.GetRepositoryInfo_GroupAccess groupAccess = new GetRepositoryInfoResponse.GetRepositoryInfo_Result.GetRepositoryInfo_Permissions.GetRepositoryInfo_GroupAccess();
			groupAccess.AccessLevel = context.IntegerValue("GetRepositoryInfo.Result.Permissions.GroupAccess.AccessLevel");
			permissions.GroupAccess = groupAccess;
			result.Permissions = permissions;
			getRepositoryInfoResponse.Result = result;
        
			return getRepositoryInfoResponse;
        }
    }
}
