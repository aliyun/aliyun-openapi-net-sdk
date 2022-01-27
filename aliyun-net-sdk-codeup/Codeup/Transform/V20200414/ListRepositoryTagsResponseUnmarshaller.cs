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
    public class ListRepositoryTagsResponseUnmarshaller
    {
        public static ListRepositoryTagsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListRepositoryTagsResponse listRepositoryTagsResponse = new ListRepositoryTagsResponse();

			listRepositoryTagsResponse.HttpResponse = _ctx.HttpResponse;
			listRepositoryTagsResponse.RequestId = _ctx.StringValue("ListRepositoryTags.RequestId");
			listRepositoryTagsResponse.ErrorCode = _ctx.StringValue("ListRepositoryTags.ErrorCode");
			listRepositoryTagsResponse.Success = _ctx.BooleanValue("ListRepositoryTags.Success");
			listRepositoryTagsResponse.ErrorMessage = _ctx.StringValue("ListRepositoryTags.ErrorMessage");
			listRepositoryTagsResponse.Total = _ctx.LongValue("ListRepositoryTags.Total");

			List<ListRepositoryTagsResponse.ListRepositoryTags_ResultItem> listRepositoryTagsResponse_result = new List<ListRepositoryTagsResponse.ListRepositoryTags_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListRepositoryTags.Result.Length"); i++) {
				ListRepositoryTagsResponse.ListRepositoryTags_ResultItem resultItem = new ListRepositoryTagsResponse.ListRepositoryTags_ResultItem();
				resultItem.Id = _ctx.StringValue("ListRepositoryTags.Result["+ i +"].Id");
				resultItem.Name = _ctx.StringValue("ListRepositoryTags.Result["+ i +"].Name");
				resultItem.Message = _ctx.StringValue("ListRepositoryTags.Result["+ i +"].Message");

				ListRepositoryTagsResponse.ListRepositoryTags_ResultItem.ListRepositoryTags_Commit commit = new ListRepositoryTagsResponse.ListRepositoryTags_ResultItem.ListRepositoryTags_Commit();
				commit.Id = _ctx.StringValue("ListRepositoryTags.Result["+ i +"].Commit.Id");
				commit.ShortId = _ctx.StringValue("ListRepositoryTags.Result["+ i +"].Commit.ShortId");
				commit.Title = _ctx.StringValue("ListRepositoryTags.Result["+ i +"].Commit.Title");
				commit.AuthorName = _ctx.StringValue("ListRepositoryTags.Result["+ i +"].Commit.AuthorName");
				commit.AuthorEmail = _ctx.StringValue("ListRepositoryTags.Result["+ i +"].Commit.AuthorEmail");
				commit.CreatedAt = _ctx.StringValue("ListRepositoryTags.Result["+ i +"].Commit.CreatedAt");
				commit.Message = _ctx.StringValue("ListRepositoryTags.Result["+ i +"].Commit.Message");
				commit.AuthoredDate = _ctx.StringValue("ListRepositoryTags.Result["+ i +"].Commit.AuthoredDate");
				commit.CommittedDate = _ctx.StringValue("ListRepositoryTags.Result["+ i +"].Commit.CommittedDate");
				commit.CommitterEmail = _ctx.StringValue("ListRepositoryTags.Result["+ i +"].Commit.CommitterEmail");
				commit.CommitterName = _ctx.StringValue("ListRepositoryTags.Result["+ i +"].Commit.CommitterName");

				List<string> commit_parentIds = new List<string>();
				for (int j = 0; j < _ctx.Length("ListRepositoryTags.Result["+ i +"].Commit.ParentIds.Length"); j++) {
					commit_parentIds.Add(_ctx.StringValue("ListRepositoryTags.Result["+ i +"].Commit.ParentIds["+ j +"]"));
				}
				commit.ParentIds = commit_parentIds;

				ListRepositoryTagsResponse.ListRepositoryTags_ResultItem.ListRepositoryTags_Commit.ListRepositoryTags_Signature1 signature1 = new ListRepositoryTagsResponse.ListRepositoryTags_ResultItem.ListRepositoryTags_Commit.ListRepositoryTags_Signature1();
				signature1.GpgKeyId = _ctx.StringValue("ListRepositoryTags.Result["+ i +"].Commit.Signature.GpgKeyId");
				signature1.VerificationStatus = _ctx.StringValue("ListRepositoryTags.Result["+ i +"].Commit.Signature.VerificationStatus");
				commit.Signature1 = signature1;
				resultItem.Commit = commit;

				ListRepositoryTagsResponse.ListRepositoryTags_ResultItem.ListRepositoryTags_Signature signature = new ListRepositoryTagsResponse.ListRepositoryTags_ResultItem.ListRepositoryTags_Signature();
				signature.GpgKeyId = _ctx.StringValue("ListRepositoryTags.Result["+ i +"].Signature.GpgKeyId");
				signature.VerificationStatus = _ctx.StringValue("ListRepositoryTags.Result["+ i +"].Signature.VerificationStatus");
				resultItem.Signature = signature;

				listRepositoryTagsResponse_result.Add(resultItem);
			}
			listRepositoryTagsResponse.Result = listRepositoryTagsResponse_result;
        
			return listRepositoryTagsResponse;
        }
    }
}
