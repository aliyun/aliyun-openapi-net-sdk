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
        public static CreateTagResponse Unmarshall(UnmarshallerContext context)
        {
			CreateTagResponse createTagResponse = new CreateTagResponse();

			createTagResponse.HttpResponse = context.HttpResponse;
			createTagResponse.RequestId = context.StringValue("CreateTag.RequestId");
			createTagResponse.ErrorCode = context.StringValue("CreateTag.ErrorCode");
			createTagResponse.Success = context.BooleanValue("CreateTag.Success");
			createTagResponse.ErrorMessage = context.StringValue("CreateTag.ErrorMessage");

			CreateTagResponse.CreateTag_Result result = new CreateTagResponse.CreateTag_Result();
			result.Name = context.StringValue("CreateTag.Result.Name");
			result.Message = context.StringValue("CreateTag.Result.Message");

			CreateTagResponse.CreateTag_Result.CreateTag_CommitInfo commitInfo = new CreateTagResponse.CreateTag_Result.CreateTag_CommitInfo();
			commitInfo.Id = context.StringValue("CreateTag.Result.CommitInfo.Id");
			commitInfo.ShortId = context.StringValue("CreateTag.Result.CommitInfo.ShortId");
			commitInfo.Title = context.StringValue("CreateTag.Result.CommitInfo.Title");
			commitInfo.AuthorName = context.StringValue("CreateTag.Result.CommitInfo.AuthorName");
			commitInfo.AuthorEmail = context.StringValue("CreateTag.Result.CommitInfo.AuthorEmail");
			commitInfo.AuthoredDate = context.StringValue("CreateTag.Result.CommitInfo.AuthoredDate");
			commitInfo.CommittedDate = context.StringValue("CreateTag.Result.CommitInfo.CommittedDate");
			commitInfo.CommitterEmail = context.StringValue("CreateTag.Result.CommitInfo.CommitterEmail");
			commitInfo.CommitterName = context.StringValue("CreateTag.Result.CommitInfo.CommitterName");
			commitInfo.CreatedAt = context.StringValue("CreateTag.Result.CommitInfo.CreatedAt");
			commitInfo.Message = context.StringValue("CreateTag.Result.CommitInfo.Message");

			List<string> commitInfo_parentIds = new List<string>();
			for (int i = 0; i < context.Length("CreateTag.Result.CommitInfo.ParentIds.Length"); i++) {
				commitInfo_parentIds.Add(context.StringValue("CreateTag.Result.CommitInfo.ParentIds["+ i +"]"));
			}
			commitInfo.ParentIds = commitInfo_parentIds;
			result.CommitInfo = commitInfo;

			CreateTagResponse.CreateTag_Result.CreateTag_Release release = new CreateTagResponse.CreateTag_Result.CreateTag_Release();
			release.TagName = context.StringValue("CreateTag.Result.Release.TagName");
			release.Description = context.StringValue("CreateTag.Result.Release.Description");
			result.Release = release;
			createTagResponse.Result = result;
        
			return createTagResponse;
        }
    }
}
