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
    public class GetBranchInfoResponseUnmarshaller
    {
        public static GetBranchInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetBranchInfoResponse getBranchInfoResponse = new GetBranchInfoResponse();

			getBranchInfoResponse.HttpResponse = _ctx.HttpResponse;
			getBranchInfoResponse.RequestId = _ctx.StringValue("GetBranchInfo.RequestId");
			getBranchInfoResponse.ErrorCode = _ctx.StringValue("GetBranchInfo.ErrorCode");
			getBranchInfoResponse.Success = _ctx.BooleanValue("GetBranchInfo.Success");
			getBranchInfoResponse.ErrorMessage = _ctx.StringValue("GetBranchInfo.ErrorMessage");

			GetBranchInfoResponse.GetBranchInfo_Result result = new GetBranchInfoResponse.GetBranchInfo_Result();
			result.BranchName = _ctx.StringValue("GetBranchInfo.Result.BranchName");
			result.ProtectedBranch = _ctx.BooleanValue("GetBranchInfo.Result.ProtectedBranch");

			GetBranchInfoResponse.GetBranchInfo_Result.GetBranchInfo_CommitInfo commitInfo = new GetBranchInfoResponse.GetBranchInfo_Result.GetBranchInfo_CommitInfo();
			commitInfo.Id = _ctx.StringValue("GetBranchInfo.Result.CommitInfo.Id");
			commitInfo.ShortId = _ctx.StringValue("GetBranchInfo.Result.CommitInfo.ShortId");
			commitInfo.Title = _ctx.StringValue("GetBranchInfo.Result.CommitInfo.Title");
			commitInfo.AuthorName = _ctx.StringValue("GetBranchInfo.Result.CommitInfo.AuthorName");
			commitInfo.AuthorEmail = _ctx.StringValue("GetBranchInfo.Result.CommitInfo.AuthorEmail");
			commitInfo.CreatedAt = _ctx.StringValue("GetBranchInfo.Result.CommitInfo.CreatedAt");
			commitInfo.Message = _ctx.StringValue("GetBranchInfo.Result.CommitInfo.Message");
			commitInfo.AuthorDate = _ctx.StringValue("GetBranchInfo.Result.CommitInfo.AuthorDate");
			commitInfo.CommittedDate = _ctx.StringValue("GetBranchInfo.Result.CommitInfo.CommittedDate");
			commitInfo.CommitterEmail = _ctx.StringValue("GetBranchInfo.Result.CommitInfo.CommitterEmail");
			commitInfo.CommitterName = _ctx.StringValue("GetBranchInfo.Result.CommitInfo.CommitterName");

			List<string> commitInfo_parentIds = new List<string>();
			for (int i = 0; i < _ctx.Length("GetBranchInfo.Result.CommitInfo.ParentIds.Length"); i++) {
				commitInfo_parentIds.Add(_ctx.StringValue("GetBranchInfo.Result.CommitInfo.ParentIds["+ i +"]"));
			}
			commitInfo.ParentIds = commitInfo_parentIds;
			result.CommitInfo = commitInfo;
			getBranchInfoResponse.Result = result;
        
			return getBranchInfoResponse;
        }
    }
}
