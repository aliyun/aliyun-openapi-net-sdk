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
    public class GetMergeRequestDetailResponseUnmarshaller
    {
        public static GetMergeRequestDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetMergeRequestDetailResponse getMergeRequestDetailResponse = new GetMergeRequestDetailResponse();

			getMergeRequestDetailResponse.HttpResponse = _ctx.HttpResponse;
			getMergeRequestDetailResponse.ErrorCode = _ctx.StringValue("GetMergeRequestDetail.ErrorCode");
			getMergeRequestDetailResponse.ErrorMessage = _ctx.StringValue("GetMergeRequestDetail.ErrorMessage");
			getMergeRequestDetailResponse.RequestId = _ctx.StringValue("GetMergeRequestDetail.RequestId");
			getMergeRequestDetailResponse.Success = _ctx.BooleanValue("GetMergeRequestDetail.Success");

			GetMergeRequestDetailResponse.GetMergeRequestDetail_Result result = new GetMergeRequestDetailResponse.GetMergeRequestDetail_Result();
			result.AcceptedRevision = _ctx.StringValue("GetMergeRequestDetail.Result.AcceptedRevision");
			result.AheadCommitCount = _ctx.IntegerValue("GetMergeRequestDetail.Result.AheadCommitCount");
			result.BehindCommitCount = _ctx.IntegerValue("GetMergeRequestDetail.Result.BehindCommitCount");
			result.CreatedAt = _ctx.StringValue("GetMergeRequestDetail.Result.CreatedAt");
			result.Description = _ctx.StringValue("GetMergeRequestDetail.Result.Description");
			result.Id = _ctx.LongValue("GetMergeRequestDetail.Result.Id");
			result.MergeError = _ctx.StringValue("GetMergeRequestDetail.Result.MergeError");
			result.MergeStatus = _ctx.StringValue("GetMergeRequestDetail.Result.MergeStatus");
			result.MergeType = _ctx.StringValue("GetMergeRequestDetail.Result.MergeType");
			result.MergedRevision = _ctx.StringValue("GetMergeRequestDetail.Result.MergedRevision");
			result.NameWithNamespace = _ctx.StringValue("GetMergeRequestDetail.Result.NameWithNamespace");
			result.ProjectId = _ctx.LongValue("GetMergeRequestDetail.Result.ProjectId");
			result.SourceBranch = _ctx.StringValue("GetMergeRequestDetail.Result.SourceBranch");
			result.State = _ctx.StringValue("GetMergeRequestDetail.Result.State");
			result.TargetBranch = _ctx.StringValue("GetMergeRequestDetail.Result.TargetBranch");
			result.Title = _ctx.StringValue("GetMergeRequestDetail.Result.Title");
			result.UpdatedAt = _ctx.StringValue("GetMergeRequestDetail.Result.UpdatedAt");
			result.WebUrl = _ctx.StringValue("GetMergeRequestDetail.Result.WebUrl");
			result.IsSupportMerge = _ctx.BooleanValue("GetMergeRequestDetail.Result.IsSupportMerge");

			GetMergeRequestDetailResponse.GetMergeRequestDetail_Result.GetMergeRequestDetail_ApproveCheckResult approveCheckResult = new GetMergeRequestDetailResponse.GetMergeRequestDetail_Result.GetMergeRequestDetail_ApproveCheckResult();
			approveCheckResult.TotalCheckResult = _ctx.StringValue("GetMergeRequestDetail.Result.ApproveCheckResult.TotalCheckResult");

			List<GetMergeRequestDetailResponse.GetMergeRequestDetail_Result.GetMergeRequestDetail_ApproveCheckResult.GetMergeRequestDetail_SatisfiedCheckResultsItem> approveCheckResult_satisfiedCheckResults = new List<GetMergeRequestDetailResponse.GetMergeRequestDetail_Result.GetMergeRequestDetail_ApproveCheckResult.GetMergeRequestDetail_SatisfiedCheckResultsItem>();
			for (int i = 0; i < _ctx.Length("GetMergeRequestDetail.Result.ApproveCheckResult.SatisfiedCheckResults.Length"); i++) {
				GetMergeRequestDetailResponse.GetMergeRequestDetail_Result.GetMergeRequestDetail_ApproveCheckResult.GetMergeRequestDetail_SatisfiedCheckResultsItem satisfiedCheckResultsItem = new GetMergeRequestDetailResponse.GetMergeRequestDetail_Result.GetMergeRequestDetail_ApproveCheckResult.GetMergeRequestDetail_SatisfiedCheckResultsItem();
				satisfiedCheckResultsItem.CheckName = _ctx.StringValue("GetMergeRequestDetail.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].CheckName");
				satisfiedCheckResultsItem.CheckStatus = _ctx.StringValue("GetMergeRequestDetail.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].CheckStatus");
				satisfiedCheckResultsItem.CheckType = _ctx.StringValue("GetMergeRequestDetail.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].CheckType");

				List<string> satisfiedCheckResultsItem_satisfiedItems = new List<string>();
				for (int j = 0; j < _ctx.Length("GetMergeRequestDetail.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].SatisfiedItems.Length"); j++) {
					satisfiedCheckResultsItem_satisfiedItems.Add(_ctx.StringValue("GetMergeRequestDetail.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].SatisfiedItems["+ j +"]"));
				}
				satisfiedCheckResultsItem.SatisfiedItems = satisfiedCheckResultsItem_satisfiedItems;

				List<string> satisfiedCheckResultsItem_unsatisfiedItems = new List<string>();
				for (int j = 0; j < _ctx.Length("GetMergeRequestDetail.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].UnsatisfiedItems.Length"); j++) {
					satisfiedCheckResultsItem_unsatisfiedItems.Add(_ctx.StringValue("GetMergeRequestDetail.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].UnsatisfiedItems["+ j +"]"));
				}
				satisfiedCheckResultsItem.UnsatisfiedItems = satisfiedCheckResultsItem_unsatisfiedItems;

				List<GetMergeRequestDetailResponse.GetMergeRequestDetail_Result.GetMergeRequestDetail_ApproveCheckResult.GetMergeRequestDetail_SatisfiedCheckResultsItem.GetMergeRequestDetail_ExtraUsersItem> satisfiedCheckResultsItem_extraUsers = new List<GetMergeRequestDetailResponse.GetMergeRequestDetail_Result.GetMergeRequestDetail_ApproveCheckResult.GetMergeRequestDetail_SatisfiedCheckResultsItem.GetMergeRequestDetail_ExtraUsersItem>();
				for (int j = 0; j < _ctx.Length("GetMergeRequestDetail.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].ExtraUsers.Length"); j++) {
					GetMergeRequestDetailResponse.GetMergeRequestDetail_Result.GetMergeRequestDetail_ApproveCheckResult.GetMergeRequestDetail_SatisfiedCheckResultsItem.GetMergeRequestDetail_ExtraUsersItem extraUsersItem = new GetMergeRequestDetailResponse.GetMergeRequestDetail_Result.GetMergeRequestDetail_ApproveCheckResult.GetMergeRequestDetail_SatisfiedCheckResultsItem.GetMergeRequestDetail_ExtraUsersItem();
					extraUsersItem.AvatarUrl = _ctx.StringValue("GetMergeRequestDetail.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].ExtraUsers["+ j +"].AvatarUrl");
					extraUsersItem.ExternUserId = _ctx.StringValue("GetMergeRequestDetail.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].ExtraUsers["+ j +"].ExternUserId");
					extraUsersItem.Id = _ctx.LongValue("GetMergeRequestDetail.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].ExtraUsers["+ j +"].Id");
					extraUsersItem.Name = _ctx.StringValue("GetMergeRequestDetail.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].ExtraUsers["+ j +"].Name");

					satisfiedCheckResultsItem_extraUsers.Add(extraUsersItem);
				}
				satisfiedCheckResultsItem.ExtraUsers = satisfiedCheckResultsItem_extraUsers;

				approveCheckResult_satisfiedCheckResults.Add(satisfiedCheckResultsItem);
			}
			approveCheckResult.SatisfiedCheckResults = approveCheckResult_satisfiedCheckResults;

			List<GetMergeRequestDetailResponse.GetMergeRequestDetail_Result.GetMergeRequestDetail_ApproveCheckResult.GetMergeRequestDetail_UnsatisfiedCheckResultsItem> approveCheckResult_unsatisfiedCheckResults = new List<GetMergeRequestDetailResponse.GetMergeRequestDetail_Result.GetMergeRequestDetail_ApproveCheckResult.GetMergeRequestDetail_UnsatisfiedCheckResultsItem>();
			for (int i = 0; i < _ctx.Length("GetMergeRequestDetail.Result.ApproveCheckResult.UnsatisfiedCheckResults.Length"); i++) {
				GetMergeRequestDetailResponse.GetMergeRequestDetail_Result.GetMergeRequestDetail_ApproveCheckResult.GetMergeRequestDetail_UnsatisfiedCheckResultsItem unsatisfiedCheckResultsItem = new GetMergeRequestDetailResponse.GetMergeRequestDetail_Result.GetMergeRequestDetail_ApproveCheckResult.GetMergeRequestDetail_UnsatisfiedCheckResultsItem();
				unsatisfiedCheckResultsItem.CheckName = _ctx.StringValue("GetMergeRequestDetail.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].CheckName");
				unsatisfiedCheckResultsItem.CheckStatus = _ctx.StringValue("GetMergeRequestDetail.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].CheckStatus");
				unsatisfiedCheckResultsItem.CheckType = _ctx.StringValue("GetMergeRequestDetail.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].CheckType");

				List<string> unsatisfiedCheckResultsItem_satisfiedItems1 = new List<string>();
				for (int j = 0; j < _ctx.Length("GetMergeRequestDetail.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].SatisfiedItems.Length"); j++) {
					unsatisfiedCheckResultsItem_satisfiedItems1.Add(_ctx.StringValue("GetMergeRequestDetail.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].SatisfiedItems["+ j +"]"));
				}
				unsatisfiedCheckResultsItem.SatisfiedItems1 = unsatisfiedCheckResultsItem_satisfiedItems1;

				List<string> unsatisfiedCheckResultsItem_unsatisfiedItems2 = new List<string>();
				for (int j = 0; j < _ctx.Length("GetMergeRequestDetail.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].UnsatisfiedItems.Length"); j++) {
					unsatisfiedCheckResultsItem_unsatisfiedItems2.Add(_ctx.StringValue("GetMergeRequestDetail.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].UnsatisfiedItems["+ j +"]"));
				}
				unsatisfiedCheckResultsItem.UnsatisfiedItems2 = unsatisfiedCheckResultsItem_unsatisfiedItems2;

				List<GetMergeRequestDetailResponse.GetMergeRequestDetail_Result.GetMergeRequestDetail_ApproveCheckResult.GetMergeRequestDetail_UnsatisfiedCheckResultsItem.GetMergeRequestDetail_ExtraUsersItem4> unsatisfiedCheckResultsItem_extraUsers3 = new List<GetMergeRequestDetailResponse.GetMergeRequestDetail_Result.GetMergeRequestDetail_ApproveCheckResult.GetMergeRequestDetail_UnsatisfiedCheckResultsItem.GetMergeRequestDetail_ExtraUsersItem4>();
				for (int j = 0; j < _ctx.Length("GetMergeRequestDetail.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].ExtraUsers.Length"); j++) {
					GetMergeRequestDetailResponse.GetMergeRequestDetail_Result.GetMergeRequestDetail_ApproveCheckResult.GetMergeRequestDetail_UnsatisfiedCheckResultsItem.GetMergeRequestDetail_ExtraUsersItem4 extraUsersItem4 = new GetMergeRequestDetailResponse.GetMergeRequestDetail_Result.GetMergeRequestDetail_ApproveCheckResult.GetMergeRequestDetail_UnsatisfiedCheckResultsItem.GetMergeRequestDetail_ExtraUsersItem4();
					extraUsersItem4.AvatarUrl = _ctx.StringValue("GetMergeRequestDetail.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].ExtraUsers["+ j +"].AvatarUrl");
					extraUsersItem4.ExternUserId = _ctx.StringValue("GetMergeRequestDetail.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].ExtraUsers["+ j +"].ExternUserId");
					extraUsersItem4.Id = _ctx.LongValue("GetMergeRequestDetail.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].ExtraUsers["+ j +"].Id");
					extraUsersItem4.Name = _ctx.StringValue("GetMergeRequestDetail.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].ExtraUsers["+ j +"].Name");

					unsatisfiedCheckResultsItem_extraUsers3.Add(extraUsersItem4);
				}
				unsatisfiedCheckResultsItem.ExtraUsers3 = unsatisfiedCheckResultsItem_extraUsers3;

				approveCheckResult_unsatisfiedCheckResults.Add(unsatisfiedCheckResultsItem);
			}
			approveCheckResult.UnsatisfiedCheckResults = approveCheckResult_unsatisfiedCheckResults;
			result.ApproveCheckResult = approveCheckResult;

			GetMergeRequestDetailResponse.GetMergeRequestDetail_Result.GetMergeRequestDetail_Author author = new GetMergeRequestDetailResponse.GetMergeRequestDetail_Result.GetMergeRequestDetail_Author();
			author.AvatarUrl = _ctx.StringValue("GetMergeRequestDetail.Result.Author.AvatarUrl");
			author.ExternUserId = _ctx.StringValue("GetMergeRequestDetail.Result.Author.ExternUserId");
			author.Id = _ctx.LongValue("GetMergeRequestDetail.Result.Author.Id");
			author.Name = _ctx.StringValue("GetMergeRequestDetail.Result.Author.Name");
			result.Author = author;

			List<GetMergeRequestDetailResponse.GetMergeRequestDetail_Result.GetMergeRequestDetail_AssigneeListItem> result_assigneeList = new List<GetMergeRequestDetailResponse.GetMergeRequestDetail_Result.GetMergeRequestDetail_AssigneeListItem>();
			for (int i = 0; i < _ctx.Length("GetMergeRequestDetail.Result.AssigneeList.Length"); i++) {
				GetMergeRequestDetailResponse.GetMergeRequestDetail_Result.GetMergeRequestDetail_AssigneeListItem assigneeListItem = new GetMergeRequestDetailResponse.GetMergeRequestDetail_Result.GetMergeRequestDetail_AssigneeListItem();
				assigneeListItem.AvatarUrl = _ctx.StringValue("GetMergeRequestDetail.Result.AssigneeList["+ i +"].AvatarUrl");
				assigneeListItem.ExternUserId = _ctx.StringValue("GetMergeRequestDetail.Result.AssigneeList["+ i +"].ExternUserId");
				assigneeListItem.Id = _ctx.StringValue("GetMergeRequestDetail.Result.AssigneeList["+ i +"].Id");
				assigneeListItem.Name = _ctx.StringValue("GetMergeRequestDetail.Result.AssigneeList["+ i +"].Name");
				assigneeListItem.Status = _ctx.StringValue("GetMergeRequestDetail.Result.AssigneeList["+ i +"].Status");
				assigneeListItem.Email = _ctx.StringValue("GetMergeRequestDetail.Result.AssigneeList["+ i +"].Email");

				result_assigneeList.Add(assigneeListItem);
			}
			result.AssigneeList = result_assigneeList;
			getMergeRequestDetailResponse.Result = result;
        
			return getMergeRequestDetailResponse;
        }
    }
}
