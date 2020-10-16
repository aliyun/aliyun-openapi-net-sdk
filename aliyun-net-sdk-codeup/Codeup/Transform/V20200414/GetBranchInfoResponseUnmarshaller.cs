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
        public static GetBranchInfoResponse Unmarshall(UnmarshallerContext context)
        {
			GetBranchInfoResponse getBranchInfoResponse = new GetBranchInfoResponse();

			getBranchInfoResponse.HttpResponse = context.HttpResponse;
			getBranchInfoResponse.RequestId = context.StringValue("GetBranchInfo.RequestId");
			getBranchInfoResponse.ErrorCode = context.StringValue("GetBranchInfo.ErrorCode");
			getBranchInfoResponse.Success = context.BooleanValue("GetBranchInfo.Success");
			getBranchInfoResponse.ErrorMessage = context.StringValue("GetBranchInfo.ErrorMessage");

			GetBranchInfoResponse.GetBranchInfo_Result result = new GetBranchInfoResponse.GetBranchInfo_Result();
			result.BranchName = context.StringValue("GetBranchInfo.Result.BranchName");
			result.ProtectedBranch = context.BooleanValue("GetBranchInfo.Result.ProtectedBranch");

			GetBranchInfoResponse.GetBranchInfo_Result.GetBranchInfo_CommitInfo commitInfo = new GetBranchInfoResponse.GetBranchInfo_Result.GetBranchInfo_CommitInfo();
			commitInfo.Id = context.StringValue("GetBranchInfo.Result.CommitInfo.Id");
			commitInfo.ShortId = context.StringValue("GetBranchInfo.Result.CommitInfo.ShortId");
			commitInfo.Title = context.StringValue("GetBranchInfo.Result.CommitInfo.Title");
			commitInfo.AuthorName = context.StringValue("GetBranchInfo.Result.CommitInfo.AuthorName");
			commitInfo.AuthorEmail = context.StringValue("GetBranchInfo.Result.CommitInfo.AuthorEmail");
			commitInfo.CreatedAt = context.StringValue("GetBranchInfo.Result.CommitInfo.CreatedAt");
			commitInfo.Message = context.StringValue("GetBranchInfo.Result.CommitInfo.Message");
			commitInfo.AuthorDate = context.StringValue("GetBranchInfo.Result.CommitInfo.AuthorDate");
			commitInfo.CommittedDate = context.StringValue("GetBranchInfo.Result.CommitInfo.CommittedDate");
			commitInfo.CommitterEmail = context.StringValue("GetBranchInfo.Result.CommitInfo.CommitterEmail");
			commitInfo.CommitterName = context.StringValue("GetBranchInfo.Result.CommitInfo.CommitterName");

			List<string> commitInfo_parentIds = new List<string>();
			for (int i = 0; i < context.Length("GetBranchInfo.Result.CommitInfo.ParentIds.Length"); i++) {
				commitInfo_parentIds.Add(context.StringValue("GetBranchInfo.Result.CommitInfo.ParentIds["+ i +"]"));
			}
			commitInfo.ParentIds = commitInfo_parentIds;
			result.CommitInfo = commitInfo;
			getBranchInfoResponse.Result = result;
        
			return getBranchInfoResponse;
        }
    }
}
