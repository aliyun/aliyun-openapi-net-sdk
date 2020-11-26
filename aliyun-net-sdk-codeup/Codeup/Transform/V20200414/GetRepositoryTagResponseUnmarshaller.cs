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
    public class GetRepositoryTagResponseUnmarshaller
    {
        public static GetRepositoryTagResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetRepositoryTagResponse getRepositoryTagResponse = new GetRepositoryTagResponse();

			getRepositoryTagResponse.HttpResponse = _ctx.HttpResponse;
			getRepositoryTagResponse.RequestId = _ctx.StringValue("GetRepositoryTag.RequestId");
			getRepositoryTagResponse.ErrorCode = _ctx.StringValue("GetRepositoryTag.ErrorCode");
			getRepositoryTagResponse.Success = _ctx.BooleanValue("GetRepositoryTag.Success");
			getRepositoryTagResponse.ErrorMessage = _ctx.StringValue("GetRepositoryTag.ErrorMessage");

			GetRepositoryTagResponse.GetRepositoryTag_Result result = new GetRepositoryTagResponse.GetRepositoryTag_Result();
			result.Id = _ctx.StringValue("GetRepositoryTag.Result.Id");
			result.Name = _ctx.StringValue("GetRepositoryTag.Result.Name");
			result.Message = _ctx.StringValue("GetRepositoryTag.Result.Message");

			GetRepositoryTagResponse.GetRepositoryTag_Result.GetRepositoryTag_Commit commit = new GetRepositoryTagResponse.GetRepositoryTag_Result.GetRepositoryTag_Commit();
			commit.Id = _ctx.StringValue("GetRepositoryTag.Result.Commit.Id");
			commit.ShortId = _ctx.StringValue("GetRepositoryTag.Result.Commit.ShortId");
			commit.Title = _ctx.StringValue("GetRepositoryTag.Result.Commit.Title");
			commit.AuthorName = _ctx.StringValue("GetRepositoryTag.Result.Commit.AuthorName");
			commit.AuthorEmail = _ctx.StringValue("GetRepositoryTag.Result.Commit.AuthorEmail");
			commit.CreatedAt = _ctx.StringValue("GetRepositoryTag.Result.Commit.CreatedAt");
			commit.Message = _ctx.StringValue("GetRepositoryTag.Result.Commit.Message");
			commit.AuthoredDate = _ctx.StringValue("GetRepositoryTag.Result.Commit.AuthoredDate");
			commit.CommittedDate = _ctx.StringValue("GetRepositoryTag.Result.Commit.CommittedDate");
			commit.CommitterEmail = _ctx.StringValue("GetRepositoryTag.Result.Commit.CommitterEmail");
			commit.CommitterName = _ctx.StringValue("GetRepositoryTag.Result.Commit.CommitterName");

			List<string> commit_parentIds = new List<string>();
			for (int i = 0; i < _ctx.Length("GetRepositoryTag.Result.Commit.ParentIds.Length"); i++) {
				commit_parentIds.Add(_ctx.StringValue("GetRepositoryTag.Result.Commit.ParentIds["+ i +"]"));
			}
			commit.ParentIds = commit_parentIds;

			GetRepositoryTagResponse.GetRepositoryTag_Result.GetRepositoryTag_Commit.GetRepositoryTag_Signature1 signature1 = new GetRepositoryTagResponse.GetRepositoryTag_Result.GetRepositoryTag_Commit.GetRepositoryTag_Signature1();
			signature1.GpgKeyId = _ctx.StringValue("GetRepositoryTag.Result.Commit.Signature.GpgKeyId");
			signature1.VerificationStatus = _ctx.StringValue("GetRepositoryTag.Result.Commit.Signature.VerificationStatus");
			commit.Signature1 = signature1;
			result.Commit = commit;

			GetRepositoryTagResponse.GetRepositoryTag_Result.GetRepositoryTag_Signature signature = new GetRepositoryTagResponse.GetRepositoryTag_Result.GetRepositoryTag_Signature();
			signature.GpgKeyId = _ctx.StringValue("GetRepositoryTag.Result.Signature.GpgKeyId");
			signature.VerificationStatus = _ctx.StringValue("GetRepositoryTag.Result.Signature.VerificationStatus");
			result.Signature = signature;
			getRepositoryTagResponse.Result = result;
        
			return getRepositoryTagResponse;
        }
    }
}
