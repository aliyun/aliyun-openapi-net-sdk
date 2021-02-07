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
    public class ListRepositoryCommitsResponseUnmarshaller
    {
        public static ListRepositoryCommitsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListRepositoryCommitsResponse listRepositoryCommitsResponse = new ListRepositoryCommitsResponse();

			listRepositoryCommitsResponse.HttpResponse = _ctx.HttpResponse;
			listRepositoryCommitsResponse.ErrorCode = _ctx.StringValue("ListRepositoryCommits.ErrorCode");
			listRepositoryCommitsResponse.ErrorMessage = _ctx.StringValue("ListRepositoryCommits.ErrorMessage");
			listRepositoryCommitsResponse.RequestId = _ctx.StringValue("ListRepositoryCommits.RequestId");
			listRepositoryCommitsResponse.Success = _ctx.BooleanValue("ListRepositoryCommits.Success");
			listRepositoryCommitsResponse.Total = _ctx.LongValue("ListRepositoryCommits.Total");

			List<ListRepositoryCommitsResponse.ListRepositoryCommits_ResultItem> listRepositoryCommitsResponse_result = new List<ListRepositoryCommitsResponse.ListRepositoryCommits_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListRepositoryCommits.Result.Length"); i++) {
				ListRepositoryCommitsResponse.ListRepositoryCommits_ResultItem resultItem = new ListRepositoryCommitsResponse.ListRepositoryCommits_ResultItem();
				resultItem.AuthorDate = _ctx.StringValue("ListRepositoryCommits.Result["+ i +"].AuthorDate");
				resultItem.AuthorEmail = _ctx.StringValue("ListRepositoryCommits.Result["+ i +"].AuthorEmail");
				resultItem.AuthorName = _ctx.StringValue("ListRepositoryCommits.Result["+ i +"].AuthorName");
				resultItem.CommittedDate = _ctx.StringValue("ListRepositoryCommits.Result["+ i +"].CommittedDate");
				resultItem.CommitterEmail = _ctx.StringValue("ListRepositoryCommits.Result["+ i +"].CommitterEmail");
				resultItem.CommitterName = _ctx.StringValue("ListRepositoryCommits.Result["+ i +"].CommitterName");
				resultItem.CreatedAt = _ctx.StringValue("ListRepositoryCommits.Result["+ i +"].CreatedAt");
				resultItem.Id = _ctx.StringValue("ListRepositoryCommits.Result["+ i +"].Id");
				resultItem.Message = _ctx.StringValue("ListRepositoryCommits.Result["+ i +"].Message");
				resultItem.ShortId = _ctx.StringValue("ListRepositoryCommits.Result["+ i +"].ShortId");
				resultItem.Title = _ctx.StringValue("ListRepositoryCommits.Result["+ i +"].Title");

				List<string> resultItem_parentIds = new List<string>();
				for (int j = 0; j < _ctx.Length("ListRepositoryCommits.Result["+ i +"].ParentIds.Length"); j++) {
					resultItem_parentIds.Add(_ctx.StringValue("ListRepositoryCommits.Result["+ i +"].ParentIds["+ j +"]"));
				}
				resultItem.ParentIds = resultItem_parentIds;

				ListRepositoryCommitsResponse.ListRepositoryCommits_ResultItem.ListRepositoryCommits_Signature signature = new ListRepositoryCommitsResponse.ListRepositoryCommits_ResultItem.ListRepositoryCommits_Signature();
				signature.GpgKeyId = _ctx.StringValue("ListRepositoryCommits.Result["+ i +"].Signature.GpgKeyId");
				signature.VerificationStatus = _ctx.StringValue("ListRepositoryCommits.Result["+ i +"].Signature.VerificationStatus");
				resultItem.Signature = signature;

				listRepositoryCommitsResponse_result.Add(resultItem);
			}
			listRepositoryCommitsResponse.Result = listRepositoryCommitsResponse_result;
        
			return listRepositoryCommitsResponse;
        }
    }
}
