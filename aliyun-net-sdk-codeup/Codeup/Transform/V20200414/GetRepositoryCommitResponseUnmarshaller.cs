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
    public class GetRepositoryCommitResponseUnmarshaller
    {
        public static GetRepositoryCommitResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetRepositoryCommitResponse getRepositoryCommitResponse = new GetRepositoryCommitResponse();

			getRepositoryCommitResponse.HttpResponse = _ctx.HttpResponse;
			getRepositoryCommitResponse.ErrorCode = _ctx.StringValue("GetRepositoryCommit.ErrorCode");
			getRepositoryCommitResponse.ErrorMessage = _ctx.StringValue("GetRepositoryCommit.ErrorMessage");
			getRepositoryCommitResponse.RequestId = _ctx.StringValue("GetRepositoryCommit.RequestId");
			getRepositoryCommitResponse.Success = _ctx.BooleanValue("GetRepositoryCommit.Success");

			GetRepositoryCommitResponse.GetRepositoryCommit_Result result = new GetRepositoryCommitResponse.GetRepositoryCommit_Result();
			result.AuthorDate = _ctx.StringValue("GetRepositoryCommit.Result.AuthorDate");
			result.AuthorEmail = _ctx.StringValue("GetRepositoryCommit.Result.AuthorEmail");
			result.AuthorName = _ctx.StringValue("GetRepositoryCommit.Result.AuthorName");
			result.CommittedDate = _ctx.StringValue("GetRepositoryCommit.Result.CommittedDate");
			result.CommitterEmail = _ctx.StringValue("GetRepositoryCommit.Result.CommitterEmail");
			result.CommitterName = _ctx.StringValue("GetRepositoryCommit.Result.CommitterName");
			result.CreatedAt = _ctx.StringValue("GetRepositoryCommit.Result.CreatedAt");
			result.Id = _ctx.StringValue("GetRepositoryCommit.Result.Id");
			result.Message = _ctx.StringValue("GetRepositoryCommit.Result.Message");
			result.ShortId = _ctx.StringValue("GetRepositoryCommit.Result.ShortId");
			result.Title = _ctx.StringValue("GetRepositoryCommit.Result.Title");

			List<string> result_parentIds = new List<string>();
			for (int i = 0; i < _ctx.Length("GetRepositoryCommit.Result.ParentIds.Length"); i++) {
				result_parentIds.Add(_ctx.StringValue("GetRepositoryCommit.Result.ParentIds["+ i +"]"));
			}
			result.ParentIds = result_parentIds;

			GetRepositoryCommitResponse.GetRepositoryCommit_Result.GetRepositoryCommit_Signature signature = new GetRepositoryCommitResponse.GetRepositoryCommit_Result.GetRepositoryCommit_Signature();
			signature.GpgKeyId = _ctx.StringValue("GetRepositoryCommit.Result.Signature.GpgKeyId");
			signature.VerificationStatus = _ctx.StringValue("GetRepositoryCommit.Result.Signature.VerificationStatus");
			result.Signature = signature;
			getRepositoryCommitResponse.Result = result;
        
			return getRepositoryCommitResponse;
        }
    }
}
