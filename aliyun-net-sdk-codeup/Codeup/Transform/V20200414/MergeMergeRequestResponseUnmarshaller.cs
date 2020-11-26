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
    public class MergeMergeRequestResponseUnmarshaller
    {
        public static MergeMergeRequestResponse Unmarshall(UnmarshallerContext _ctx)
        {
			MergeMergeRequestResponse mergeMergeRequestResponse = new MergeMergeRequestResponse();

			mergeMergeRequestResponse.HttpResponse = _ctx.HttpResponse;
			mergeMergeRequestResponse.RequestId = _ctx.StringValue("MergeMergeRequest.RequestId");
			mergeMergeRequestResponse.ErrorCode = _ctx.StringValue("MergeMergeRequest.ErrorCode");
			mergeMergeRequestResponse.Success = _ctx.BooleanValue("MergeMergeRequest.Success");
			mergeMergeRequestResponse.ErrorMessage = _ctx.StringValue("MergeMergeRequest.ErrorMessage");

			MergeMergeRequestResponse.MergeMergeRequest_Result result = new MergeMergeRequestResponse.MergeMergeRequest_Result();
			result.Id = _ctx.LongValue("MergeMergeRequest.Result.Id");
			result.ProjectId = _ctx.LongValue("MergeMergeRequest.Result.ProjectId");
			result.Title = _ctx.StringValue("MergeMergeRequest.Result.Title");
			result.Description = _ctx.StringValue("MergeMergeRequest.Result.Description");
			result.State = _ctx.StringValue("MergeMergeRequest.Result.State");
			result.MergeStatus = _ctx.StringValue("MergeMergeRequest.Result.MergeStatus");
			result.CreatedAt = _ctx.StringValue("MergeMergeRequest.Result.CreatedAt");
			result.UpdatedAt = _ctx.StringValue("MergeMergeRequest.Result.UpdatedAt");
			result.TargetBranch = _ctx.StringValue("MergeMergeRequest.Result.TargetBranch");
			result.SourceBranch = _ctx.StringValue("MergeMergeRequest.Result.SourceBranch");
			result.WebUrl = _ctx.StringValue("MergeMergeRequest.Result.WebUrl");
			result.AcceptedRevision = _ctx.StringValue("MergeMergeRequest.Result.AcceptedRevision");
			result.MergeError = _ctx.StringValue("MergeMergeRequest.Result.MergeError");
			result.MergedRevision = _ctx.StringValue("MergeMergeRequest.Result.MergedRevision");
			result.NameWithNamespace = _ctx.StringValue("MergeMergeRequest.Result.NameWithNamespace");
			result.MergeType = _ctx.StringValue("MergeMergeRequest.Result.MergeType");
			result.AheadCommitCount = _ctx.IntegerValue("MergeMergeRequest.Result.AheadCommitCount");
			result.BehindCommitCount = _ctx.IntegerValue("MergeMergeRequest.Result.BehindCommitCount");

			MergeMergeRequestResponse.MergeMergeRequest_Result.MergeMergeRequest_Author author = new MergeMergeRequestResponse.MergeMergeRequest_Result.MergeMergeRequest_Author();
			author.Id = _ctx.LongValue("MergeMergeRequest.Result.Author.Id");
			author.ExternUserId = _ctx.StringValue("MergeMergeRequest.Result.Author.ExternUserId");
			author.AvatarUrl = _ctx.StringValue("MergeMergeRequest.Result.Author.AvatarUrl");
			author.Name = _ctx.StringValue("MergeMergeRequest.Result.Author.Name");
			result.Author = author;

			MergeMergeRequestResponse.MergeMergeRequest_Result.MergeMergeRequest_ApproveCheckResult approveCheckResult = new MergeMergeRequestResponse.MergeMergeRequest_Result.MergeMergeRequest_ApproveCheckResult();
			approveCheckResult.TotalCheckResult = _ctx.StringValue("MergeMergeRequest.Result.ApproveCheckResult.TotalCheckResult");

			List<MergeMergeRequestResponse.MergeMergeRequest_Result.MergeMergeRequest_ApproveCheckResult.MergeMergeRequest_SatisfiedCheckResultsItem> approveCheckResult_satisfiedCheckResults = new List<MergeMergeRequestResponse.MergeMergeRequest_Result.MergeMergeRequest_ApproveCheckResult.MergeMergeRequest_SatisfiedCheckResultsItem>();
			for (int i = 0; i < _ctx.Length("MergeMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults.Length"); i++) {
				MergeMergeRequestResponse.MergeMergeRequest_Result.MergeMergeRequest_ApproveCheckResult.MergeMergeRequest_SatisfiedCheckResultsItem satisfiedCheckResultsItem = new MergeMergeRequestResponse.MergeMergeRequest_Result.MergeMergeRequest_ApproveCheckResult.MergeMergeRequest_SatisfiedCheckResultsItem();
				satisfiedCheckResultsItem.CheckStatus = _ctx.StringValue("MergeMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].CheckStatus");
				satisfiedCheckResultsItem.CheckName = _ctx.StringValue("MergeMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].CheckName");
				satisfiedCheckResultsItem.CheckType = _ctx.StringValue("MergeMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].CheckType");

				List<string> satisfiedCheckResultsItem_satisfiedItems = new List<string>();
				for (int j = 0; j < _ctx.Length("MergeMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].SatisfiedItems.Length"); j++) {
					satisfiedCheckResultsItem_satisfiedItems.Add(_ctx.StringValue("MergeMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].SatisfiedItems["+ j +"]"));
				}
				satisfiedCheckResultsItem.SatisfiedItems = satisfiedCheckResultsItem_satisfiedItems;

				List<string> satisfiedCheckResultsItem_unsatisfiedItems = new List<string>();
				for (int j = 0; j < _ctx.Length("MergeMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].UnsatisfiedItems.Length"); j++) {
					satisfiedCheckResultsItem_unsatisfiedItems.Add(_ctx.StringValue("MergeMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].UnsatisfiedItems["+ j +"]"));
				}
				satisfiedCheckResultsItem.UnsatisfiedItems = satisfiedCheckResultsItem_unsatisfiedItems;

				List<MergeMergeRequestResponse.MergeMergeRequest_Result.MergeMergeRequest_ApproveCheckResult.MergeMergeRequest_SatisfiedCheckResultsItem.MergeMergeRequest_ExtraUsersItem> satisfiedCheckResultsItem_extraUsers = new List<MergeMergeRequestResponse.MergeMergeRequest_Result.MergeMergeRequest_ApproveCheckResult.MergeMergeRequest_SatisfiedCheckResultsItem.MergeMergeRequest_ExtraUsersItem>();
				for (int j = 0; j < _ctx.Length("MergeMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].ExtraUsers.Length"); j++) {
					MergeMergeRequestResponse.MergeMergeRequest_Result.MergeMergeRequest_ApproveCheckResult.MergeMergeRequest_SatisfiedCheckResultsItem.MergeMergeRequest_ExtraUsersItem extraUsersItem = new MergeMergeRequestResponse.MergeMergeRequest_Result.MergeMergeRequest_ApproveCheckResult.MergeMergeRequest_SatisfiedCheckResultsItem.MergeMergeRequest_ExtraUsersItem();
					extraUsersItem.Id = _ctx.LongValue("MergeMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].ExtraUsers["+ j +"].Id");
					extraUsersItem.ExternUserId = _ctx.StringValue("MergeMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].ExtraUsers["+ j +"].ExternUserId");
					extraUsersItem.AvatarUrl = _ctx.StringValue("MergeMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].ExtraUsers["+ j +"].AvatarUrl");
					extraUsersItem.Name = _ctx.StringValue("MergeMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].ExtraUsers["+ j +"].Name");

					satisfiedCheckResultsItem_extraUsers.Add(extraUsersItem);
				}
				satisfiedCheckResultsItem.ExtraUsers = satisfiedCheckResultsItem_extraUsers;

				approveCheckResult_satisfiedCheckResults.Add(satisfiedCheckResultsItem);
			}
			approveCheckResult.SatisfiedCheckResults = approveCheckResult_satisfiedCheckResults;

			List<MergeMergeRequestResponse.MergeMergeRequest_Result.MergeMergeRequest_ApproveCheckResult.MergeMergeRequest_UnsatisfiedCheckResultsItem> approveCheckResult_unsatisfiedCheckResults = new List<MergeMergeRequestResponse.MergeMergeRequest_Result.MergeMergeRequest_ApproveCheckResult.MergeMergeRequest_UnsatisfiedCheckResultsItem>();
			for (int i = 0; i < _ctx.Length("MergeMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults.Length"); i++) {
				MergeMergeRequestResponse.MergeMergeRequest_Result.MergeMergeRequest_ApproveCheckResult.MergeMergeRequest_UnsatisfiedCheckResultsItem unsatisfiedCheckResultsItem = new MergeMergeRequestResponse.MergeMergeRequest_Result.MergeMergeRequest_ApproveCheckResult.MergeMergeRequest_UnsatisfiedCheckResultsItem();
				unsatisfiedCheckResultsItem.CheckStatus = _ctx.StringValue("MergeMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].CheckStatus");
				unsatisfiedCheckResultsItem.CheckName = _ctx.StringValue("MergeMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].CheckName");
				unsatisfiedCheckResultsItem.CheckType = _ctx.StringValue("MergeMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].CheckType");

				List<string> unsatisfiedCheckResultsItem_satisfiedItems1 = new List<string>();
				for (int j = 0; j < _ctx.Length("MergeMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].SatisfiedItems.Length"); j++) {
					unsatisfiedCheckResultsItem_satisfiedItems1.Add(_ctx.StringValue("MergeMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].SatisfiedItems["+ j +"]"));
				}
				unsatisfiedCheckResultsItem.SatisfiedItems1 = unsatisfiedCheckResultsItem_satisfiedItems1;

				List<string> unsatisfiedCheckResultsItem_unsatisfiedItems2 = new List<string>();
				for (int j = 0; j < _ctx.Length("MergeMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].UnsatisfiedItems.Length"); j++) {
					unsatisfiedCheckResultsItem_unsatisfiedItems2.Add(_ctx.StringValue("MergeMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].UnsatisfiedItems["+ j +"]"));
				}
				unsatisfiedCheckResultsItem.UnsatisfiedItems2 = unsatisfiedCheckResultsItem_unsatisfiedItems2;

				List<MergeMergeRequestResponse.MergeMergeRequest_Result.MergeMergeRequest_ApproveCheckResult.MergeMergeRequest_UnsatisfiedCheckResultsItem.MergeMergeRequest_ExtraUsersItem4> unsatisfiedCheckResultsItem_extraUsers3 = new List<MergeMergeRequestResponse.MergeMergeRequest_Result.MergeMergeRequest_ApproveCheckResult.MergeMergeRequest_UnsatisfiedCheckResultsItem.MergeMergeRequest_ExtraUsersItem4>();
				for (int j = 0; j < _ctx.Length("MergeMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].ExtraUsers.Length"); j++) {
					MergeMergeRequestResponse.MergeMergeRequest_Result.MergeMergeRequest_ApproveCheckResult.MergeMergeRequest_UnsatisfiedCheckResultsItem.MergeMergeRequest_ExtraUsersItem4 extraUsersItem4 = new MergeMergeRequestResponse.MergeMergeRequest_Result.MergeMergeRequest_ApproveCheckResult.MergeMergeRequest_UnsatisfiedCheckResultsItem.MergeMergeRequest_ExtraUsersItem4();
					extraUsersItem4.Id = _ctx.LongValue("MergeMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].ExtraUsers["+ j +"].Id");
					extraUsersItem4.ExternUserId = _ctx.StringValue("MergeMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].ExtraUsers["+ j +"].ExternUserId");
					extraUsersItem4.AvatarUrl = _ctx.StringValue("MergeMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].ExtraUsers["+ j +"].AvatarUrl");
					extraUsersItem4.Name = _ctx.StringValue("MergeMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].ExtraUsers["+ j +"].Name");

					unsatisfiedCheckResultsItem_extraUsers3.Add(extraUsersItem4);
				}
				unsatisfiedCheckResultsItem.ExtraUsers3 = unsatisfiedCheckResultsItem_extraUsers3;

				approveCheckResult_unsatisfiedCheckResults.Add(unsatisfiedCheckResultsItem);
			}
			approveCheckResult.UnsatisfiedCheckResults = approveCheckResult_unsatisfiedCheckResults;
			result.ApproveCheckResult = approveCheckResult;

			List<MergeMergeRequestResponse.MergeMergeRequest_Result.MergeMergeRequest_AssigneeListItem> result_assigneeList = new List<MergeMergeRequestResponse.MergeMergeRequest_Result.MergeMergeRequest_AssigneeListItem>();
			for (int i = 0; i < _ctx.Length("MergeMergeRequest.Result.AssigneeList.Length"); i++) {
				MergeMergeRequestResponse.MergeMergeRequest_Result.MergeMergeRequest_AssigneeListItem assigneeListItem = new MergeMergeRequestResponse.MergeMergeRequest_Result.MergeMergeRequest_AssigneeListItem();
				assigneeListItem.Id = _ctx.StringValue("MergeMergeRequest.Result.AssigneeList["+ i +"].Id");
				assigneeListItem.ExternUserId = _ctx.StringValue("MergeMergeRequest.Result.AssigneeList["+ i +"].ExternUserId");
				assigneeListItem.AvatarUrl = _ctx.StringValue("MergeMergeRequest.Result.AssigneeList["+ i +"].AvatarUrl");
				assigneeListItem.Name = _ctx.StringValue("MergeMergeRequest.Result.AssigneeList["+ i +"].Name");

				result_assigneeList.Add(assigneeListItem);
			}
			result.AssigneeList = result_assigneeList;
			mergeMergeRequestResponse.Result = result;
        
			return mergeMergeRequestResponse;
        }
    }
}
