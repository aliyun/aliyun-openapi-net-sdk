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
    public class UpdateMergeRequestResponseUnmarshaller
    {
        public static UpdateMergeRequestResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateMergeRequestResponse updateMergeRequestResponse = new UpdateMergeRequestResponse();

			updateMergeRequestResponse.HttpResponse = _ctx.HttpResponse;
			updateMergeRequestResponse.ErrorCode = _ctx.StringValue("UpdateMergeRequest.ErrorCode");
			updateMergeRequestResponse.ErrorMessage = _ctx.StringValue("UpdateMergeRequest.ErrorMessage");
			updateMergeRequestResponse.RequestId = _ctx.StringValue("UpdateMergeRequest.RequestId");
			updateMergeRequestResponse.Success = _ctx.BooleanValue("UpdateMergeRequest.Success");

			UpdateMergeRequestResponse.UpdateMergeRequest_Result result = new UpdateMergeRequestResponse.UpdateMergeRequest_Result();
			result.AcceptedRevision = _ctx.StringValue("UpdateMergeRequest.Result.AcceptedRevision");
			result.AheadCommitCount = _ctx.IntegerValue("UpdateMergeRequest.Result.AheadCommitCount");
			result.BehindCommitCount = _ctx.IntegerValue("UpdateMergeRequest.Result.BehindCommitCount");
			result.CreatedAt = _ctx.StringValue("UpdateMergeRequest.Result.CreatedAt");
			result.Description = _ctx.StringValue("UpdateMergeRequest.Result.Description");
			result.Id = _ctx.LongValue("UpdateMergeRequest.Result.Id");
			result.MergeError = _ctx.StringValue("UpdateMergeRequest.Result.MergeError");
			result.MergeStatus = _ctx.StringValue("UpdateMergeRequest.Result.MergeStatus");
			result.MergeType = _ctx.StringValue("UpdateMergeRequest.Result.MergeType");
			result.MergedRevision = _ctx.StringValue("UpdateMergeRequest.Result.MergedRevision");
			result.NameWithNamespace = _ctx.StringValue("UpdateMergeRequest.Result.NameWithNamespace");
			result.ProjectId = _ctx.LongValue("UpdateMergeRequest.Result.ProjectId");
			result.SourceBranch = _ctx.StringValue("UpdateMergeRequest.Result.SourceBranch");
			result.State = _ctx.StringValue("UpdateMergeRequest.Result.State");
			result.TargetBranch = _ctx.StringValue("UpdateMergeRequest.Result.TargetBranch");
			result.Title = _ctx.StringValue("UpdateMergeRequest.Result.Title");
			result.UpdatedAt = _ctx.StringValue("UpdateMergeRequest.Result.UpdatedAt");
			result.WebUrl = _ctx.StringValue("UpdateMergeRequest.Result.WebUrl");

			UpdateMergeRequestResponse.UpdateMergeRequest_Result.UpdateMergeRequest_ApproveCheckResult approveCheckResult = new UpdateMergeRequestResponse.UpdateMergeRequest_Result.UpdateMergeRequest_ApproveCheckResult();
			approveCheckResult.TotalCheckResult = _ctx.StringValue("UpdateMergeRequest.Result.ApproveCheckResult.TotalCheckResult");

			List<UpdateMergeRequestResponse.UpdateMergeRequest_Result.UpdateMergeRequest_ApproveCheckResult.UpdateMergeRequest_SatisfiedCheckResultsItem> approveCheckResult_satisfiedCheckResults = new List<UpdateMergeRequestResponse.UpdateMergeRequest_Result.UpdateMergeRequest_ApproveCheckResult.UpdateMergeRequest_SatisfiedCheckResultsItem>();
			for (int i = 0; i < _ctx.Length("UpdateMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults.Length"); i++) {
				UpdateMergeRequestResponse.UpdateMergeRequest_Result.UpdateMergeRequest_ApproveCheckResult.UpdateMergeRequest_SatisfiedCheckResultsItem satisfiedCheckResultsItem = new UpdateMergeRequestResponse.UpdateMergeRequest_Result.UpdateMergeRequest_ApproveCheckResult.UpdateMergeRequest_SatisfiedCheckResultsItem();
				satisfiedCheckResultsItem.CheckName = _ctx.StringValue("UpdateMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].CheckName");
				satisfiedCheckResultsItem.CheckStatus = _ctx.StringValue("UpdateMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].CheckStatus");
				satisfiedCheckResultsItem.CheckType = _ctx.StringValue("UpdateMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].CheckType");

				List<string> satisfiedCheckResultsItem_satisfiedItems = new List<string>();
				for (int j = 0; j < _ctx.Length("UpdateMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].SatisfiedItems.Length"); j++) {
					satisfiedCheckResultsItem_satisfiedItems.Add(_ctx.StringValue("UpdateMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].SatisfiedItems["+ j +"]"));
				}
				satisfiedCheckResultsItem.SatisfiedItems = satisfiedCheckResultsItem_satisfiedItems;

				List<string> satisfiedCheckResultsItem_unsatisfiedItems = new List<string>();
				for (int j = 0; j < _ctx.Length("UpdateMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].UnsatisfiedItems.Length"); j++) {
					satisfiedCheckResultsItem_unsatisfiedItems.Add(_ctx.StringValue("UpdateMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].UnsatisfiedItems["+ j +"]"));
				}
				satisfiedCheckResultsItem.UnsatisfiedItems = satisfiedCheckResultsItem_unsatisfiedItems;

				List<UpdateMergeRequestResponse.UpdateMergeRequest_Result.UpdateMergeRequest_ApproveCheckResult.UpdateMergeRequest_SatisfiedCheckResultsItem.UpdateMergeRequest_ExtraUsersItem> satisfiedCheckResultsItem_extraUsers = new List<UpdateMergeRequestResponse.UpdateMergeRequest_Result.UpdateMergeRequest_ApproveCheckResult.UpdateMergeRequest_SatisfiedCheckResultsItem.UpdateMergeRequest_ExtraUsersItem>();
				for (int j = 0; j < _ctx.Length("UpdateMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].ExtraUsers.Length"); j++) {
					UpdateMergeRequestResponse.UpdateMergeRequest_Result.UpdateMergeRequest_ApproveCheckResult.UpdateMergeRequest_SatisfiedCheckResultsItem.UpdateMergeRequest_ExtraUsersItem extraUsersItem = new UpdateMergeRequestResponse.UpdateMergeRequest_Result.UpdateMergeRequest_ApproveCheckResult.UpdateMergeRequest_SatisfiedCheckResultsItem.UpdateMergeRequest_ExtraUsersItem();
					extraUsersItem.AvatarUrl = _ctx.StringValue("UpdateMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].ExtraUsers["+ j +"].AvatarUrl");
					extraUsersItem.ExternUserId = _ctx.StringValue("UpdateMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].ExtraUsers["+ j +"].ExternUserId");
					extraUsersItem.Id = _ctx.LongValue("UpdateMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].ExtraUsers["+ j +"].Id");
					extraUsersItem.Name = _ctx.StringValue("UpdateMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].ExtraUsers["+ j +"].Name");

					satisfiedCheckResultsItem_extraUsers.Add(extraUsersItem);
				}
				satisfiedCheckResultsItem.ExtraUsers = satisfiedCheckResultsItem_extraUsers;

				approveCheckResult_satisfiedCheckResults.Add(satisfiedCheckResultsItem);
			}
			approveCheckResult.SatisfiedCheckResults = approveCheckResult_satisfiedCheckResults;

			List<UpdateMergeRequestResponse.UpdateMergeRequest_Result.UpdateMergeRequest_ApproveCheckResult.UpdateMergeRequest_UnsatisfiedCheckResultsItem> approveCheckResult_unsatisfiedCheckResults = new List<UpdateMergeRequestResponse.UpdateMergeRequest_Result.UpdateMergeRequest_ApproveCheckResult.UpdateMergeRequest_UnsatisfiedCheckResultsItem>();
			for (int i = 0; i < _ctx.Length("UpdateMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults.Length"); i++) {
				UpdateMergeRequestResponse.UpdateMergeRequest_Result.UpdateMergeRequest_ApproveCheckResult.UpdateMergeRequest_UnsatisfiedCheckResultsItem unsatisfiedCheckResultsItem = new UpdateMergeRequestResponse.UpdateMergeRequest_Result.UpdateMergeRequest_ApproveCheckResult.UpdateMergeRequest_UnsatisfiedCheckResultsItem();
				unsatisfiedCheckResultsItem.CheckName = _ctx.StringValue("UpdateMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].CheckName");
				unsatisfiedCheckResultsItem.CheckStatus = _ctx.StringValue("UpdateMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].CheckStatus");
				unsatisfiedCheckResultsItem.CheckType = _ctx.StringValue("UpdateMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].CheckType");

				List<string> unsatisfiedCheckResultsItem_satisfiedItems1 = new List<string>();
				for (int j = 0; j < _ctx.Length("UpdateMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].SatisfiedItems.Length"); j++) {
					unsatisfiedCheckResultsItem_satisfiedItems1.Add(_ctx.StringValue("UpdateMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].SatisfiedItems["+ j +"]"));
				}
				unsatisfiedCheckResultsItem.SatisfiedItems1 = unsatisfiedCheckResultsItem_satisfiedItems1;

				List<string> unsatisfiedCheckResultsItem_unsatisfiedItems2 = new List<string>();
				for (int j = 0; j < _ctx.Length("UpdateMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].UnsatisfiedItems.Length"); j++) {
					unsatisfiedCheckResultsItem_unsatisfiedItems2.Add(_ctx.StringValue("UpdateMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].UnsatisfiedItems["+ j +"]"));
				}
				unsatisfiedCheckResultsItem.UnsatisfiedItems2 = unsatisfiedCheckResultsItem_unsatisfiedItems2;

				List<UpdateMergeRequestResponse.UpdateMergeRequest_Result.UpdateMergeRequest_ApproveCheckResult.UpdateMergeRequest_UnsatisfiedCheckResultsItem.UpdateMergeRequest_ExtraUsersItem4> unsatisfiedCheckResultsItem_extraUsers3 = new List<UpdateMergeRequestResponse.UpdateMergeRequest_Result.UpdateMergeRequest_ApproveCheckResult.UpdateMergeRequest_UnsatisfiedCheckResultsItem.UpdateMergeRequest_ExtraUsersItem4>();
				for (int j = 0; j < _ctx.Length("UpdateMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].ExtraUsers.Length"); j++) {
					UpdateMergeRequestResponse.UpdateMergeRequest_Result.UpdateMergeRequest_ApproveCheckResult.UpdateMergeRequest_UnsatisfiedCheckResultsItem.UpdateMergeRequest_ExtraUsersItem4 extraUsersItem4 = new UpdateMergeRequestResponse.UpdateMergeRequest_Result.UpdateMergeRequest_ApproveCheckResult.UpdateMergeRequest_UnsatisfiedCheckResultsItem.UpdateMergeRequest_ExtraUsersItem4();
					extraUsersItem4.AvatarUrl = _ctx.StringValue("UpdateMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].ExtraUsers["+ j +"].AvatarUrl");
					extraUsersItem4.ExternUserId = _ctx.StringValue("UpdateMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].ExtraUsers["+ j +"].ExternUserId");
					extraUsersItem4.Id = _ctx.LongValue("UpdateMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].ExtraUsers["+ j +"].Id");
					extraUsersItem4.Name = _ctx.StringValue("UpdateMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].ExtraUsers["+ j +"].Name");

					unsatisfiedCheckResultsItem_extraUsers3.Add(extraUsersItem4);
				}
				unsatisfiedCheckResultsItem.ExtraUsers3 = unsatisfiedCheckResultsItem_extraUsers3;

				approveCheckResult_unsatisfiedCheckResults.Add(unsatisfiedCheckResultsItem);
			}
			approveCheckResult.UnsatisfiedCheckResults = approveCheckResult_unsatisfiedCheckResults;
			result.ApproveCheckResult = approveCheckResult;

			UpdateMergeRequestResponse.UpdateMergeRequest_Result.UpdateMergeRequest_Author author = new UpdateMergeRequestResponse.UpdateMergeRequest_Result.UpdateMergeRequest_Author();
			author.AvatarUrl = _ctx.StringValue("UpdateMergeRequest.Result.Author.AvatarUrl");
			author.ExternUserId = _ctx.StringValue("UpdateMergeRequest.Result.Author.ExternUserId");
			author.Id = _ctx.LongValue("UpdateMergeRequest.Result.Author.Id");
			author.Name = _ctx.StringValue("UpdateMergeRequest.Result.Author.Name");
			result.Author = author;

			List<UpdateMergeRequestResponse.UpdateMergeRequest_Result.UpdateMergeRequest_AssigneeListItem> result_assigneeList = new List<UpdateMergeRequestResponse.UpdateMergeRequest_Result.UpdateMergeRequest_AssigneeListItem>();
			for (int i = 0; i < _ctx.Length("UpdateMergeRequest.Result.AssigneeList.Length"); i++) {
				UpdateMergeRequestResponse.UpdateMergeRequest_Result.UpdateMergeRequest_AssigneeListItem assigneeListItem = new UpdateMergeRequestResponse.UpdateMergeRequest_Result.UpdateMergeRequest_AssigneeListItem();
				assigneeListItem.AvatarUrl = _ctx.StringValue("UpdateMergeRequest.Result.AssigneeList["+ i +"].AvatarUrl");
				assigneeListItem.ExternUserId = _ctx.StringValue("UpdateMergeRequest.Result.AssigneeList["+ i +"].ExternUserId");
				assigneeListItem.Id = _ctx.StringValue("UpdateMergeRequest.Result.AssigneeList["+ i +"].Id");
				assigneeListItem.Name = _ctx.StringValue("UpdateMergeRequest.Result.AssigneeList["+ i +"].Name");

				result_assigneeList.Add(assigneeListItem);
			}
			result.AssigneeList = result_assigneeList;
			updateMergeRequestResponse.Result = result;
        
			return updateMergeRequestResponse;
        }
    }
}
