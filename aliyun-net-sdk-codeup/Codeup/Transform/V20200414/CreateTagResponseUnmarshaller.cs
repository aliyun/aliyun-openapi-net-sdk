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
    public class CreateTagResponseUnmarshaller
    {
        public static CreateTagResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateTagResponse createTagResponse = new CreateTagResponse();

			createTagResponse.HttpResponse = _ctx.HttpResponse;
			createTagResponse.RequestId = _ctx.StringValue("CreateTag.RequestId");
			createTagResponse.ErrorCode = _ctx.StringValue("CreateTag.ErrorCode");
			createTagResponse.Success = _ctx.BooleanValue("CreateTag.Success");
			createTagResponse.ErrorMessage = _ctx.StringValue("CreateTag.ErrorMessage");

			CreateTagResponse.CreateTag_Result result = new CreateTagResponse.CreateTag_Result();
			result.Name = _ctx.StringValue("CreateTag.Result.Name");
			result.Message = _ctx.StringValue("CreateTag.Result.Message");

			CreateTagResponse.CreateTag_Result.CreateTag_CommitInfo commitInfo = new CreateTagResponse.CreateTag_Result.CreateTag_CommitInfo();
			commitInfo.Id = _ctx.StringValue("CreateTag.Result.CommitInfo.Id");
			commitInfo.ShortId = _ctx.StringValue("CreateTag.Result.CommitInfo.ShortId");
			commitInfo.Title = _ctx.StringValue("CreateTag.Result.CommitInfo.Title");
			commitInfo.AuthorName = _ctx.StringValue("CreateTag.Result.CommitInfo.AuthorName");
			commitInfo.AuthorEmail = _ctx.StringValue("CreateTag.Result.CommitInfo.AuthorEmail");
			commitInfo.AuthoredDate = _ctx.StringValue("CreateTag.Result.CommitInfo.AuthoredDate");
			commitInfo.CommittedDate = _ctx.StringValue("CreateTag.Result.CommitInfo.CommittedDate");
			commitInfo.CommitterEmail = _ctx.StringValue("CreateTag.Result.CommitInfo.CommitterEmail");
			commitInfo.CommitterName = _ctx.StringValue("CreateTag.Result.CommitInfo.CommitterName");
			commitInfo.CreatedAt = _ctx.StringValue("CreateTag.Result.CommitInfo.CreatedAt");
			commitInfo.Message = _ctx.StringValue("CreateTag.Result.CommitInfo.Message");

			List<string> commitInfo_parentIds = new List<string>();
			for (int i = 0; i < _ctx.Length("CreateTag.Result.CommitInfo.ParentIds.Length"); i++) {
				commitInfo_parentIds.Add(_ctx.StringValue("CreateTag.Result.CommitInfo.ParentIds["+ i +"]"));
			}
			commitInfo.ParentIds = commitInfo_parentIds;
			result.CommitInfo = commitInfo;

			CreateTagResponse.CreateTag_Result.CreateTag_Release release = new CreateTagResponse.CreateTag_Result.CreateTag_Release();
			release.TagName = _ctx.StringValue("CreateTag.Result.Release.TagName");
			release.Description = _ctx.StringValue("CreateTag.Result.Release.Description");
			result.Release = release;
			createTagResponse.Result = result;
        
			return createTagResponse;
        }
    }
}
