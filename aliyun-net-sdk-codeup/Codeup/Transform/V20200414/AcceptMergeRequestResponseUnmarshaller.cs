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
    public class AcceptMergeRequestResponseUnmarshaller
    {
        public static AcceptMergeRequestResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AcceptMergeRequestResponse acceptMergeRequestResponse = new AcceptMergeRequestResponse();

			acceptMergeRequestResponse.HttpResponse = _ctx.HttpResponse;
			acceptMergeRequestResponse.ErrorCode = _ctx.StringValue("AcceptMergeRequest.ErrorCode");
			acceptMergeRequestResponse.ErrorMessage = _ctx.StringValue("AcceptMergeRequest.ErrorMessage");
			acceptMergeRequestResponse.RequestId = _ctx.StringValue("AcceptMergeRequest.RequestId");
			acceptMergeRequestResponse.Success = _ctx.BooleanValue("AcceptMergeRequest.Success");

			AcceptMergeRequestResponse.AcceptMergeRequest_Result result = new AcceptMergeRequestResponse.AcceptMergeRequest_Result();
			result.AcceptedRevision = _ctx.StringValue("AcceptMergeRequest.Result.AcceptedRevision");
			result.AheadCommitCount = _ctx.IntegerValue("AcceptMergeRequest.Result.AheadCommitCount");
			result.BehindCommitCount = _ctx.IntegerValue("AcceptMergeRequest.Result.BehindCommitCount");
			result.CreatedAt = _ctx.StringValue("AcceptMergeRequest.Result.CreatedAt");
			result.Description = _ctx.StringValue("AcceptMergeRequest.Result.Description");
			result.Id = _ctx.LongValue("AcceptMergeRequest.Result.Id");
			result.MergeError = _ctx.StringValue("AcceptMergeRequest.Result.MergeError");
			result.MergeStatus = _ctx.StringValue("AcceptMergeRequest.Result.MergeStatus");
			result.MergeType = _ctx.StringValue("AcceptMergeRequest.Result.MergeType");
			result.MergedRevision = _ctx.StringValue("AcceptMergeRequest.Result.MergedRevision");
			result.NameWithNamespace = _ctx.StringValue("AcceptMergeRequest.Result.NameWithNamespace");
			result.ProjectId = _ctx.LongValue("AcceptMergeRequest.Result.ProjectId");
			result.SourceBranch = _ctx.StringValue("AcceptMergeRequest.Result.SourceBranch");
			result.State = _ctx.StringValue("AcceptMergeRequest.Result.State");
			result.TargetBranch = _ctx.StringValue("AcceptMergeRequest.Result.TargetBranch");
			result.Title = _ctx.StringValue("AcceptMergeRequest.Result.Title");
			result.UpdatedAt = _ctx.StringValue("AcceptMergeRequest.Result.UpdatedAt");
			result.WebUrl = _ctx.StringValue("AcceptMergeRequest.Result.WebUrl");

			AcceptMergeRequestResponse.AcceptMergeRequest_Result.AcceptMergeRequest_ApproveCheckResult approveCheckResult = new AcceptMergeRequestResponse.AcceptMergeRequest_Result.AcceptMergeRequest_ApproveCheckResult();
			approveCheckResult.TotalCheckResult = _ctx.StringValue("AcceptMergeRequest.Result.ApproveCheckResult.TotalCheckResult");

			List<AcceptMergeRequestResponse.AcceptMergeRequest_Result.AcceptMergeRequest_ApproveCheckResult.AcceptMergeRequest_SatisfiedCheckResultsItem> approveCheckResult_satisfiedCheckResults = new List<AcceptMergeRequestResponse.AcceptMergeRequest_Result.AcceptMergeRequest_ApproveCheckResult.AcceptMergeRequest_SatisfiedCheckResultsItem>();
			for (int i = 0; i < _ctx.Length("AcceptMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults.Length"); i++) {
				AcceptMergeRequestResponse.AcceptMergeRequest_Result.AcceptMergeRequest_ApproveCheckResult.AcceptMergeRequest_SatisfiedCheckResultsItem satisfiedCheckResultsItem = new AcceptMergeRequestResponse.AcceptMergeRequest_Result.AcceptMergeRequest_ApproveCheckResult.AcceptMergeRequest_SatisfiedCheckResultsItem();
				satisfiedCheckResultsItem.CheckName = _ctx.StringValue("AcceptMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].CheckName");
				satisfiedCheckResultsItem.CheckStatus = _ctx.StringValue("AcceptMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].CheckStatus");
				satisfiedCheckResultsItem.CheckType = _ctx.StringValue("AcceptMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].CheckType");

				List<string> satisfiedCheckResultsItem_satisfiedItems = new List<string>();
				for (int j = 0; j < _ctx.Length("AcceptMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].SatisfiedItems.Length"); j++) {
					satisfiedCheckResultsItem_satisfiedItems.Add(_ctx.StringValue("AcceptMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].SatisfiedItems["+ j +"]"));
				}
				satisfiedCheckResultsItem.SatisfiedItems = satisfiedCheckResultsItem_satisfiedItems;

				List<string> satisfiedCheckResultsItem_unsatisfiedItems = new List<string>();
				for (int j = 0; j < _ctx.Length("AcceptMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].UnsatisfiedItems.Length"); j++) {
					satisfiedCheckResultsItem_unsatisfiedItems.Add(_ctx.StringValue("AcceptMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].UnsatisfiedItems["+ j +"]"));
				}
				satisfiedCheckResultsItem.UnsatisfiedItems = satisfiedCheckResultsItem_unsatisfiedItems;

				List<AcceptMergeRequestResponse.AcceptMergeRequest_Result.AcceptMergeRequest_ApproveCheckResult.AcceptMergeRequest_SatisfiedCheckResultsItem.AcceptMergeRequest_ExtraUsersItem> satisfiedCheckResultsItem_extraUsers = new List<AcceptMergeRequestResponse.AcceptMergeRequest_Result.AcceptMergeRequest_ApproveCheckResult.AcceptMergeRequest_SatisfiedCheckResultsItem.AcceptMergeRequest_ExtraUsersItem>();
				for (int j = 0; j < _ctx.Length("AcceptMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].ExtraUsers.Length"); j++) {
					AcceptMergeRequestResponse.AcceptMergeRequest_Result.AcceptMergeRequest_ApproveCheckResult.AcceptMergeRequest_SatisfiedCheckResultsItem.AcceptMergeRequest_ExtraUsersItem extraUsersItem = new AcceptMergeRequestResponse.AcceptMergeRequest_Result.AcceptMergeRequest_ApproveCheckResult.AcceptMergeRequest_SatisfiedCheckResultsItem.AcceptMergeRequest_ExtraUsersItem();
					extraUsersItem.AvatarUrl = _ctx.StringValue("AcceptMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].ExtraUsers["+ j +"].AvatarUrl");
					extraUsersItem.ExternUserId = _ctx.StringValue("AcceptMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].ExtraUsers["+ j +"].ExternUserId");
					extraUsersItem.Id = _ctx.LongValue("AcceptMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].ExtraUsers["+ j +"].Id");
					extraUsersItem.Name = _ctx.StringValue("AcceptMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].ExtraUsers["+ j +"].Name");

					satisfiedCheckResultsItem_extraUsers.Add(extraUsersItem);
				}
				satisfiedCheckResultsItem.ExtraUsers = satisfiedCheckResultsItem_extraUsers;

				approveCheckResult_satisfiedCheckResults.Add(satisfiedCheckResultsItem);
			}
			approveCheckResult.SatisfiedCheckResults = approveCheckResult_satisfiedCheckResults;

			List<AcceptMergeRequestResponse.AcceptMergeRequest_Result.AcceptMergeRequest_ApproveCheckResult.AcceptMergeRequest_UnsatisfiedCheckResultsItem> approveCheckResult_unsatisfiedCheckResults = new List<AcceptMergeRequestResponse.AcceptMergeRequest_Result.AcceptMergeRequest_ApproveCheckResult.AcceptMergeRequest_UnsatisfiedCheckResultsItem>();
			for (int i = 0; i < _ctx.Length("AcceptMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults.Length"); i++) {
				AcceptMergeRequestResponse.AcceptMergeRequest_Result.AcceptMergeRequest_ApproveCheckResult.AcceptMergeRequest_UnsatisfiedCheckResultsItem unsatisfiedCheckResultsItem = new AcceptMergeRequestResponse.AcceptMergeRequest_Result.AcceptMergeRequest_ApproveCheckResult.AcceptMergeRequest_UnsatisfiedCheckResultsItem();
				unsatisfiedCheckResultsItem.CheckName = _ctx.StringValue("AcceptMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].CheckName");
				unsatisfiedCheckResultsItem.CheckStatus = _ctx.StringValue("AcceptMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].CheckStatus");
				unsatisfiedCheckResultsItem.CheckType = _ctx.StringValue("AcceptMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].CheckType");

				List<string> unsatisfiedCheckResultsItem_satisfiedItems1 = new List<string>();
				for (int j = 0; j < _ctx.Length("AcceptMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].SatisfiedItems.Length"); j++) {
					unsatisfiedCheckResultsItem_satisfiedItems1.Add(_ctx.StringValue("AcceptMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].SatisfiedItems["+ j +"]"));
				}
				unsatisfiedCheckResultsItem.SatisfiedItems1 = unsatisfiedCheckResultsItem_satisfiedItems1;

				List<string> unsatisfiedCheckResultsItem_unsatisfiedItems2 = new List<string>();
				for (int j = 0; j < _ctx.Length("AcceptMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].UnsatisfiedItems.Length"); j++) {
					unsatisfiedCheckResultsItem_unsatisfiedItems2.Add(_ctx.StringValue("AcceptMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].UnsatisfiedItems["+ j +"]"));
				}
				unsatisfiedCheckResultsItem.UnsatisfiedItems2 = unsatisfiedCheckResultsItem_unsatisfiedItems2;

				List<AcceptMergeRequestResponse.AcceptMergeRequest_Result.AcceptMergeRequest_ApproveCheckResult.AcceptMergeRequest_UnsatisfiedCheckResultsItem.AcceptMergeRequest_ExtraUsersItem4> unsatisfiedCheckResultsItem_extraUsers3 = new List<AcceptMergeRequestResponse.AcceptMergeRequest_Result.AcceptMergeRequest_ApproveCheckResult.AcceptMergeRequest_UnsatisfiedCheckResultsItem.AcceptMergeRequest_ExtraUsersItem4>();
				for (int j = 0; j < _ctx.Length("AcceptMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].ExtraUsers.Length"); j++) {
					AcceptMergeRequestResponse.AcceptMergeRequest_Result.AcceptMergeRequest_ApproveCheckResult.AcceptMergeRequest_UnsatisfiedCheckResultsItem.AcceptMergeRequest_ExtraUsersItem4 extraUsersItem4 = new AcceptMergeRequestResponse.AcceptMergeRequest_Result.AcceptMergeRequest_ApproveCheckResult.AcceptMergeRequest_UnsatisfiedCheckResultsItem.AcceptMergeRequest_ExtraUsersItem4();
					extraUsersItem4.AvatarUrl = _ctx.StringValue("AcceptMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].ExtraUsers["+ j +"].AvatarUrl");
					extraUsersItem4.ExternUserId = _ctx.StringValue("AcceptMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].ExtraUsers["+ j +"].ExternUserId");
					extraUsersItem4.Id = _ctx.LongValue("AcceptMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].ExtraUsers["+ j +"].Id");
					extraUsersItem4.Name = _ctx.StringValue("AcceptMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].ExtraUsers["+ j +"].Name");

					unsatisfiedCheckResultsItem_extraUsers3.Add(extraUsersItem4);
				}
				unsatisfiedCheckResultsItem.ExtraUsers3 = unsatisfiedCheckResultsItem_extraUsers3;

				approveCheckResult_unsatisfiedCheckResults.Add(unsatisfiedCheckResultsItem);
			}
			approveCheckResult.UnsatisfiedCheckResults = approveCheckResult_unsatisfiedCheckResults;
			result.ApproveCheckResult = approveCheckResult;

			AcceptMergeRequestResponse.AcceptMergeRequest_Result.AcceptMergeRequest_Author author = new AcceptMergeRequestResponse.AcceptMergeRequest_Result.AcceptMergeRequest_Author();
			author.AvatarUrl = _ctx.StringValue("AcceptMergeRequest.Result.Author.AvatarUrl");
			author.ExternUserId = _ctx.StringValue("AcceptMergeRequest.Result.Author.ExternUserId");
			author.Id = _ctx.LongValue("AcceptMergeRequest.Result.Author.Id");
			author.Name = _ctx.StringValue("AcceptMergeRequest.Result.Author.Name");
			result.Author = author;

			List<AcceptMergeRequestResponse.AcceptMergeRequest_Result.AcceptMergeRequest_AssigneeListItem> result_assigneeList = new List<AcceptMergeRequestResponse.AcceptMergeRequest_Result.AcceptMergeRequest_AssigneeListItem>();
			for (int i = 0; i < _ctx.Length("AcceptMergeRequest.Result.AssigneeList.Length"); i++) {
				AcceptMergeRequestResponse.AcceptMergeRequest_Result.AcceptMergeRequest_AssigneeListItem assigneeListItem = new AcceptMergeRequestResponse.AcceptMergeRequest_Result.AcceptMergeRequest_AssigneeListItem();
				assigneeListItem.AvatarUrl = _ctx.StringValue("AcceptMergeRequest.Result.AssigneeList["+ i +"].AvatarUrl");
				assigneeListItem.ExternUserId = _ctx.StringValue("AcceptMergeRequest.Result.AssigneeList["+ i +"].ExternUserId");
				assigneeListItem.Id = _ctx.StringValue("AcceptMergeRequest.Result.AssigneeList["+ i +"].Id");
				assigneeListItem.Name = _ctx.StringValue("AcceptMergeRequest.Result.AssigneeList["+ i +"].Name");

				result_assigneeList.Add(assigneeListItem);
			}
			result.AssigneeList = result_assigneeList;
			acceptMergeRequestResponse.Result = result;
        
			return acceptMergeRequestResponse;
        }
    }
}
