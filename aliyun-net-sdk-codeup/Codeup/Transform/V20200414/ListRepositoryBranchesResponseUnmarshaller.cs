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
        public static ListRepositoryBranchesResponse Unmarshall(UnmarshallerContext context)
        {
			ListRepositoryBranchesResponse listRepositoryBranchesResponse = new ListRepositoryBranchesResponse();

			listRepositoryBranchesResponse.HttpResponse = context.HttpResponse;
			listRepositoryBranchesResponse.RequestId = context.StringValue("ListRepositoryBranches.RequestId");
			listRepositoryBranchesResponse.ErrorCode = context.StringValue("ListRepositoryBranches.ErrorCode");
			listRepositoryBranchesResponse.Success = context.BooleanValue("ListRepositoryBranches.Success");
			listRepositoryBranchesResponse.ErrorMessage = context.StringValue("ListRepositoryBranches.ErrorMessage");
			listRepositoryBranchesResponse.Total = context.LongValue("ListRepositoryBranches.Total");

			List<ListRepositoryBranchesResponse.ListRepositoryBranches_ResultItem> listRepositoryBranchesResponse_result = new List<ListRepositoryBranchesResponse.ListRepositoryBranches_ResultItem>();
			for (int i = 0; i < context.Length("ListRepositoryBranches.Result.Length"); i++) {
				ListRepositoryBranchesResponse.ListRepositoryBranches_ResultItem resultItem = new ListRepositoryBranchesResponse.ListRepositoryBranches_ResultItem();
				resultItem.BranchName = context.StringValue("ListRepositoryBranches.Result["+ i +"].BranchName");
				resultItem.ProtectedBranch = context.BooleanValue("ListRepositoryBranches.Result["+ i +"].ProtectedBranch");

				ListRepositoryBranchesResponse.ListRepositoryBranches_ResultItem.ListRepositoryBranches_CommitInfo commitInfo = new ListRepositoryBranchesResponse.ListRepositoryBranches_ResultItem.ListRepositoryBranches_CommitInfo();
				commitInfo.Id = context.StringValue("ListRepositoryBranches.Result["+ i +"].CommitInfo.Id");
				commitInfo.ShortId = context.StringValue("ListRepositoryBranches.Result["+ i +"].CommitInfo.ShortId");
				commitInfo.Title = context.StringValue("ListRepositoryBranches.Result["+ i +"].CommitInfo.Title");
				commitInfo.AuthorName = context.StringValue("ListRepositoryBranches.Result["+ i +"].CommitInfo.AuthorName");
				commitInfo.AuthorEmail = context.StringValue("ListRepositoryBranches.Result["+ i +"].CommitInfo.AuthorEmail");
				commitInfo.CreatedAt = context.StringValue("ListRepositoryBranches.Result["+ i +"].CommitInfo.CreatedAt");
				commitInfo.Message = context.StringValue("ListRepositoryBranches.Result["+ i +"].CommitInfo.Message");
				commitInfo.AuthorDate = context.StringValue("ListRepositoryBranches.Result["+ i +"].CommitInfo.AuthorDate");
				commitInfo.CommittedDate = context.StringValue("ListRepositoryBranches.Result["+ i +"].CommitInfo.CommittedDate");
				commitInfo.CommitterEmail = context.StringValue("ListRepositoryBranches.Result["+ i +"].CommitInfo.CommitterEmail");
				commitInfo.CommitterName = context.StringValue("ListRepositoryBranches.Result["+ i +"].CommitInfo.CommitterName");

				List<string> commitInfo_parentIds = new List<string>();
				for (int j = 0; j < context.Length("ListRepositoryBranches.Result["+ i +"].CommitInfo.ParentIds.Length"); j++) {
					commitInfo_parentIds.Add(context.StringValue("ListRepositoryBranches.Result["+ i +"].CommitInfo.ParentIds["+ j +"]"));
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
