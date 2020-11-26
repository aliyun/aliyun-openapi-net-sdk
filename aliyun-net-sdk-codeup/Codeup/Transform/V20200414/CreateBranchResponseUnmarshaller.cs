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
    public class CreateBranchResponseUnmarshaller
    {
        public static CreateBranchResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateBranchResponse createBranchResponse = new CreateBranchResponse();

			createBranchResponse.HttpResponse = _ctx.HttpResponse;
			createBranchResponse.RequestId = _ctx.StringValue("CreateBranch.RequestId");
			createBranchResponse.ErrorCode = _ctx.StringValue("CreateBranch.ErrorCode");
			createBranchResponse.Success = _ctx.BooleanValue("CreateBranch.Success");
			createBranchResponse.ErrorMessage = _ctx.StringValue("CreateBranch.ErrorMessage");

			CreateBranchResponse.CreateBranch_Result result = new CreateBranchResponse.CreateBranch_Result();
			result.BranchName = _ctx.StringValue("CreateBranch.Result.BranchName");
			result.ProtectedBranch = _ctx.BooleanValue("CreateBranch.Result.ProtectedBranch");

			CreateBranchResponse.CreateBranch_Result.CreateBranch_CommitInfo commitInfo = new CreateBranchResponse.CreateBranch_Result.CreateBranch_CommitInfo();
			commitInfo.Id = _ctx.StringValue("CreateBranch.Result.CommitInfo.Id");
			commitInfo.ShortId = _ctx.StringValue("CreateBranch.Result.CommitInfo.ShortId");
			commitInfo.Title = _ctx.StringValue("CreateBranch.Result.CommitInfo.Title");
			commitInfo.AuthorName = _ctx.StringValue("CreateBranch.Result.CommitInfo.AuthorName");
			commitInfo.AuthorEmail = _ctx.StringValue("CreateBranch.Result.CommitInfo.AuthorEmail");
			commitInfo.CreatedAt = _ctx.StringValue("CreateBranch.Result.CommitInfo.CreatedAt");
			commitInfo.Message = _ctx.StringValue("CreateBranch.Result.CommitInfo.Message");
			commitInfo.AuthorDate = _ctx.StringValue("CreateBranch.Result.CommitInfo.AuthorDate");
			commitInfo.CommittedDate = _ctx.StringValue("CreateBranch.Result.CommitInfo.CommittedDate");
			commitInfo.CommitterEmail = _ctx.StringValue("CreateBranch.Result.CommitInfo.CommitterEmail");
			commitInfo.CommitterName = _ctx.StringValue("CreateBranch.Result.CommitInfo.CommitterName");

			List<string> commitInfo_parentIds = new List<string>();
			for (int i = 0; i < _ctx.Length("CreateBranch.Result.CommitInfo.ParentIds.Length"); i++) {
				commitInfo_parentIds.Add(_ctx.StringValue("CreateBranch.Result.CommitInfo.ParentIds["+ i +"]"));
			}
			commitInfo.ParentIds = commitInfo_parentIds;
			result.CommitInfo = commitInfo;
			createBranchResponse.Result = result;
        
			return createBranchResponse;
        }
    }
}
