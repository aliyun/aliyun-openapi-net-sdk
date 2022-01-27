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
        public static GetRepositoryInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetRepositoryInfoResponse getRepositoryInfoResponse = new GetRepositoryInfoResponse();

			getRepositoryInfoResponse.HttpResponse = _ctx.HttpResponse;
			getRepositoryInfoResponse.ErrorCode = _ctx.IntegerValue("GetRepositoryInfo.ErrorCode");
			getRepositoryInfoResponse.ErrorMessage = _ctx.StringValue("GetRepositoryInfo.ErrorMessage");
			getRepositoryInfoResponse.RequestId = _ctx.StringValue("GetRepositoryInfo.RequestId");
			getRepositoryInfoResponse.Success = _ctx.BooleanValue("GetRepositoryInfo.Success");

			GetRepositoryInfoResponse.GetRepositoryInfo_Result result = new GetRepositoryInfoResponse.GetRepositoryInfo_Result();
			result.Id = _ctx.LongValue("GetRepositoryInfo.Result.Id");
			result.SshUrlToRepo = _ctx.StringValue("GetRepositoryInfo.Result.SshUrlToRepo");
			result.Description = _ctx.StringValue("GetRepositoryInfo.Result.Description");
			result.DefaultBranch = _ctx.StringValue("GetRepositoryInfo.Result.DefaultBranch");
			result._Public = _ctx.BooleanValue("GetRepositoryInfo.Result.Public");
			result.VisibilityLevel = _ctx.StringValue("GetRepositoryInfo.Result.VisibilityLevel");
			result.HttpUrlToRepo = _ctx.StringValue("GetRepositoryInfo.Result.HttpUrlToRepo");
			result.WebUrl = _ctx.StringValue("GetRepositoryInfo.Result.WebUrl");
			result.Name = _ctx.StringValue("GetRepositoryInfo.Result.Name");
			result.NameWithNamespace = _ctx.StringValue("GetRepositoryInfo.Result.NameWithNamespace");
			result.Path = _ctx.StringValue("GetRepositoryInfo.Result.Path");
			result.PathWithNamespace = _ctx.StringValue("GetRepositoryInfo.Result.PathWithNamespace");
			result.CreatedAt = _ctx.StringValue("GetRepositoryInfo.Result.CreatedAt");
			result.LastActivityAt = _ctx.StringValue("GetRepositoryInfo.Result.LastActivityAt");
			result.CreatorId = _ctx.LongValue("GetRepositoryInfo.Result.CreatorId");
			result.Archive = _ctx.BooleanValue("GetRepositoryInfo.Result.Archive");
			result.AvatarUrl = _ctx.StringValue("GetRepositoryInfo.Result.AvatarUrl");
			result.DemoProjectStatus = _ctx.BooleanValue("GetRepositoryInfo.Result.DemoProjectStatus");
			result.AccessLevel = _ctx.IntegerValue("GetRepositoryInfo.Result.AccessLevel");
			result.ImportStatus = _ctx.StringValue("GetRepositoryInfo.Result.ImportStatus");
			result.ImportUrl = _ctx.StringValue("GetRepositoryInfo.Result.ImportUrl");
			result.ImportFromSubversion = _ctx.BooleanValue("GetRepositoryInfo.Result.ImportFromSubversion");

			List<string> result_tagList = new List<string>();
			for (int i = 0; i < _ctx.Length("GetRepositoryInfo.Result.TagList.Length"); i++) {
				result_tagList.Add(_ctx.StringValue("GetRepositoryInfo.Result.TagList["+ i +"]"));
			}
			result.TagList = result_tagList;

			GetRepositoryInfoResponse.GetRepositoryInfo_Result.GetRepositoryInfo__Namespace _namespace = new GetRepositoryInfoResponse.GetRepositoryInfo_Result.GetRepositoryInfo__Namespace();
			_namespace.Id = _ctx.LongValue("GetRepositoryInfo.Result.Namespace.Id");
			_namespace.Name = _ctx.StringValue("GetRepositoryInfo.Result.Namespace.Name");
			_namespace.Path = _ctx.StringValue("GetRepositoryInfo.Result.Namespace.Path");
			_namespace.OwnerId = _ctx.LongValue("GetRepositoryInfo.Result.Namespace.OwnerId");
			_namespace.CreatedAt = _ctx.StringValue("GetRepositoryInfo.Result.Namespace.CreatedAt");
			_namespace.UpdatedAt = _ctx.StringValue("GetRepositoryInfo.Result.Namespace.UpdatedAt");
			_namespace.Description = _ctx.StringValue("GetRepositoryInfo.Result.Namespace.Description");
			_namespace.State = _ctx.StringValue("GetRepositoryInfo.Result.Namespace.State");
			_namespace.Avatar = _ctx.StringValue("GetRepositoryInfo.Result.Namespace.Avatar");
			_namespace._Public = _ctx.BooleanValue("GetRepositoryInfo.Result.Namespace.Public");
			_namespace.VisibilityLevel = _ctx.StringValue("GetRepositoryInfo.Result.Namespace.VisibilityLevel");
			result._Namespace = _namespace;

			GetRepositoryInfoResponse.GetRepositoryInfo_Result.GetRepositoryInfo_Permissions permissions = new GetRepositoryInfoResponse.GetRepositoryInfo_Result.GetRepositoryInfo_Permissions();

			GetRepositoryInfoResponse.GetRepositoryInfo_Result.GetRepositoryInfo_Permissions.GetRepositoryInfo_ProjectAccess projectAccess = new GetRepositoryInfoResponse.GetRepositoryInfo_Result.GetRepositoryInfo_Permissions.GetRepositoryInfo_ProjectAccess();
			projectAccess.AccessLevel = _ctx.IntegerValue("GetRepositoryInfo.Result.Permissions.ProjectAccess.AccessLevel");
			permissions.ProjectAccess = projectAccess;

			GetRepositoryInfoResponse.GetRepositoryInfo_Result.GetRepositoryInfo_Permissions.GetRepositoryInfo_GroupAccess groupAccess = new GetRepositoryInfoResponse.GetRepositoryInfo_Result.GetRepositoryInfo_Permissions.GetRepositoryInfo_GroupAccess();
			groupAccess.AccessLevel = _ctx.IntegerValue("GetRepositoryInfo.Result.Permissions.GroupAccess.AccessLevel");
			permissions.GroupAccess = groupAccess;
			result.Permissions = permissions;
			getRepositoryInfoResponse.Result = result;
        
			return getRepositoryInfoResponse;
        }
    }
}
