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
    public class GetRepositoryTagV2ResponseUnmarshaller
    {
        public static GetRepositoryTagV2Response Unmarshall(UnmarshallerContext _ctx)
        {
			GetRepositoryTagV2Response getRepositoryTagV2Response = new GetRepositoryTagV2Response();

			getRepositoryTagV2Response.HttpResponse = _ctx.HttpResponse;
			getRepositoryTagV2Response.ErrorCode = _ctx.StringValue("GetRepositoryTagV2.ErrorCode");
			getRepositoryTagV2Response.ErrorMessage = _ctx.StringValue("GetRepositoryTagV2.ErrorMessage");
			getRepositoryTagV2Response.RequestId = _ctx.StringValue("GetRepositoryTagV2.RequestId");
			getRepositoryTagV2Response.Success = _ctx.BooleanValue("GetRepositoryTagV2.Success");

			GetRepositoryTagV2Response.GetRepositoryTagV2_Result result = new GetRepositoryTagV2Response.GetRepositoryTagV2_Result();
			result.Id = _ctx.StringValue("GetRepositoryTagV2.Result.Id");
			result.Message = _ctx.StringValue("GetRepositoryTagV2.Result.Message");
			result.Name = _ctx.StringValue("GetRepositoryTagV2.Result.Name");

			GetRepositoryTagV2Response.GetRepositoryTagV2_Result.GetRepositoryTagV2_Commit commit = new GetRepositoryTagV2Response.GetRepositoryTagV2_Result.GetRepositoryTagV2_Commit();
			commit.AuthorEmail = _ctx.StringValue("GetRepositoryTagV2.Result.Commit.AuthorEmail");
			commit.AuthorName = _ctx.StringValue("GetRepositoryTagV2.Result.Commit.AuthorName");
			commit.AuthoredDate = _ctx.StringValue("GetRepositoryTagV2.Result.Commit.AuthoredDate");
			commit.CommittedDate = _ctx.StringValue("GetRepositoryTagV2.Result.Commit.CommittedDate");
			commit.CommitterEmail = _ctx.StringValue("GetRepositoryTagV2.Result.Commit.CommitterEmail");
			commit.CommitterName = _ctx.StringValue("GetRepositoryTagV2.Result.Commit.CommitterName");
			commit.CreatedAt = _ctx.StringValue("GetRepositoryTagV2.Result.Commit.CreatedAt");
			commit.Id = _ctx.StringValue("GetRepositoryTagV2.Result.Commit.Id");
			commit.Message = _ctx.StringValue("GetRepositoryTagV2.Result.Commit.Message");
			commit.ShortId = _ctx.StringValue("GetRepositoryTagV2.Result.Commit.ShortId");
			commit.Title = _ctx.StringValue("GetRepositoryTagV2.Result.Commit.Title");

			List<string> commit_parentIds = new List<string>();
			for (int i = 0; i < _ctx.Length("GetRepositoryTagV2.Result.Commit.ParentIds.Length"); i++) {
				commit_parentIds.Add(_ctx.StringValue("GetRepositoryTagV2.Result.Commit.ParentIds["+ i +"]"));
			}
			commit.ParentIds = commit_parentIds;

			GetRepositoryTagV2Response.GetRepositoryTagV2_Result.GetRepositoryTagV2_Commit.GetRepositoryTagV2_Signature1 signature1 = new GetRepositoryTagV2Response.GetRepositoryTagV2_Result.GetRepositoryTagV2_Commit.GetRepositoryTagV2_Signature1();
			signature1.GpgKeyId = _ctx.StringValue("GetRepositoryTagV2.Result.Commit.Signature.GpgKeyId");
			signature1.VerificationStatus = _ctx.StringValue("GetRepositoryTagV2.Result.Commit.Signature.VerificationStatus");
			commit.Signature1 = signature1;
			result.Commit = commit;

			GetRepositoryTagV2Response.GetRepositoryTagV2_Result.GetRepositoryTagV2_Signature signature = new GetRepositoryTagV2Response.GetRepositoryTagV2_Result.GetRepositoryTagV2_Signature();
			signature.GpgKeyId = _ctx.StringValue("GetRepositoryTagV2.Result.Signature.GpgKeyId");
			signature.VerificationStatus = _ctx.StringValue("GetRepositoryTagV2.Result.Signature.VerificationStatus");
			result.Signature = signature;
			getRepositoryTagV2Response.Result = result;
        
			return getRepositoryTagV2Response;
        }
    }
}
