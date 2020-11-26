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
    public class ListRepositoryBranchesResponseUnmarshaller
    {
        public static ListRepositoryBranchesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListRepositoryBranchesResponse listRepositoryBranchesResponse = new ListRepositoryBranchesResponse();

			listRepositoryBranchesResponse.HttpResponse = _ctx.HttpResponse;
			listRepositoryBranchesResponse.RequestId = _ctx.StringValue("ListRepositoryBranches.RequestId");
			listRepositoryBranchesResponse.ErrorCode = _ctx.StringValue("ListRepositoryBranches.ErrorCode");
			listRepositoryBranchesResponse.Success = _ctx.BooleanValue("ListRepositoryBranches.Success");
			listRepositoryBranchesResponse.ErrorMessage = _ctx.StringValue("ListRepositoryBranches.ErrorMessage");
			listRepositoryBranchesResponse.Total = _ctx.LongValue("ListRepositoryBranches.Total");

			List<ListRepositoryBranchesResponse.ListRepositoryBranches_ResultItem> listRepositoryBranchesResponse_result = new List<ListRepositoryBranchesResponse.ListRepositoryBranches_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListRepositoryBranches.Result.Length"); i++) {
				ListRepositoryBranchesResponse.ListRepositoryBranches_ResultItem resultItem = new ListRepositoryBranchesResponse.ListRepositoryBranches_ResultItem();
				resultItem.BranchName = _ctx.StringValue("ListRepositoryBranches.Result["+ i +"].BranchName");
				resultItem.ProtectedBranch = _ctx.BooleanValue("ListRepositoryBranches.Result["+ i +"].ProtectedBranch");

				ListRepositoryBranchesResponse.ListRepositoryBranches_ResultItem.ListRepositoryBranches_CommitInfo commitInfo = new ListRepositoryBranchesResponse.ListRepositoryBranches_ResultItem.ListRepositoryBranches_CommitInfo();
				commitInfo.Id = _ctx.StringValue("ListRepositoryBranches.Result["+ i +"].CommitInfo.Id");
				commitInfo.ShortId = _ctx.StringValue("ListRepositoryBranches.Result["+ i +"].CommitInfo.ShortId");
				commitInfo.Title = _ctx.StringValue("ListRepositoryBranches.Result["+ i +"].CommitInfo.Title");
				commitInfo.AuthorName = _ctx.StringValue("ListRepositoryBranches.Result["+ i +"].CommitInfo.AuthorName");
				commitInfo.AuthorEmail = _ctx.StringValue("ListRepositoryBranches.Result["+ i +"].CommitInfo.AuthorEmail");
				commitInfo.CreatedAt = _ctx.StringValue("ListRepositoryBranches.Result["+ i +"].CommitInfo.CreatedAt");
				commitInfo.Message = _ctx.StringValue("ListRepositoryBranches.Result["+ i +"].CommitInfo.Message");
				commitInfo.AuthorDate = _ctx.StringValue("ListRepositoryBranches.Result["+ i +"].CommitInfo.AuthorDate");
				commitInfo.CommittedDate = _ctx.StringValue("ListRepositoryBranches.Result["+ i +"].CommitInfo.CommittedDate");
				commitInfo.CommitterEmail = _ctx.StringValue("ListRepositoryBranches.Result["+ i +"].CommitInfo.CommitterEmail");
				commitInfo.CommitterName = _ctx.StringValue("ListRepositoryBranches.Result["+ i +"].CommitInfo.CommitterName");

				List<string> commitInfo_parentIds = new List<string>();
				for (int j = 0; j < _ctx.Length("ListRepositoryBranches.Result["+ i +"].CommitInfo.ParentIds.Length"); j++) {
					commitInfo_parentIds.Add(_ctx.StringValue("ListRepositoryBranches.Result["+ i +"].CommitInfo.ParentIds["+ j +"]"));
				}
				commitInfo.ParentIds = commitInfo_parentIds;
				resultItem.CommitInfo = commitInfo;

				listRepositoryBranchesResponse_result.Add(resultItem);
			}
			listRepositoryBranchesResponse.Result = listRepositoryBranchesResponse_result;
        
			return listRepositoryBranchesResponse;
        }
    }
}
