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
    public class CreateMergeRequestCommentResponseUnmarshaller
    {
        public static CreateMergeRequestCommentResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateMergeRequestCommentResponse createMergeRequestCommentResponse = new CreateMergeRequestCommentResponse();

			createMergeRequestCommentResponse.HttpResponse = _ctx.HttpResponse;
			createMergeRequestCommentResponse.ErrorCode = _ctx.StringValue("CreateMergeRequestComment.ErrorCode");
			createMergeRequestCommentResponse.ErrorMessage = _ctx.StringValue("CreateMergeRequestComment.ErrorMessage");
			createMergeRequestCommentResponse.RequestId = _ctx.StringValue("CreateMergeRequestComment.RequestId");
			createMergeRequestCommentResponse.Success = _ctx.BooleanValue("CreateMergeRequestComment.Success");

			CreateMergeRequestCommentResponse.CreateMergeRequestComment_Result result = new CreateMergeRequestCommentResponse.CreateMergeRequestComment_Result();
			result.Id = _ctx.LongValue("CreateMergeRequestComment.Result.Id");
			result.Note = _ctx.StringValue("CreateMergeRequestComment.Result.Note");
			result.CreatedAt = _ctx.StringValue("CreateMergeRequestComment.Result.CreatedAt");
			result.UpdatedAt = _ctx.StringValue("CreateMergeRequestComment.Result.UpdatedAt");
			result.ProjectId = _ctx.LongValue("CreateMergeRequestComment.Result.ProjectId");
			result.IsDraft = _ctx.BooleanValue("CreateMergeRequestComment.Result.IsDraft");
			result.ParentNoteId = _ctx.LongValue("CreateMergeRequestComment.Result.ParentNoteId");
			result.Line = _ctx.LongValue("CreateMergeRequestComment.Result.Line");
			result.Side = _ctx.StringValue("CreateMergeRequestComment.Result.Side");
			result.Path = _ctx.StringValue("CreateMergeRequestComment.Result.Path");
			result.RangeContext = _ctx.StringValue("CreateMergeRequestComment.Result.RangeContext");
			result.OutDated = _ctx.BooleanValue("CreateMergeRequestComment.Result.OutDated");
			result.Closed = _ctx.IntegerValue("CreateMergeRequestComment.Result.Closed");

			CreateMergeRequestCommentResponse.CreateMergeRequestComment_Result.CreateMergeRequestComment_Author author = new CreateMergeRequestCommentResponse.CreateMergeRequestComment_Result.CreateMergeRequestComment_Author();
			author.Id = _ctx.LongValue("CreateMergeRequestComment.Result.Author.Id");
			author.AvatarUrl = _ctx.StringValue("CreateMergeRequestComment.Result.Author.AvatarUrl");
			author.ExternUserId = _ctx.StringValue("CreateMergeRequestComment.Result.Author.ExternUserId");
			author.Name = _ctx.StringValue("CreateMergeRequestComment.Result.Author.Name");
			author.Email = _ctx.StringValue("CreateMergeRequestComment.Result.Author.Email");
			result.Author = author;
			createMergeRequestCommentResponse.Result = result;
        
			return createMergeRequestCommentResponse;
        }
    }
}
