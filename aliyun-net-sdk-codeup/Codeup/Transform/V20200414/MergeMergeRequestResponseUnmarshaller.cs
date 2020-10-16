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
        public static MergeMergeRequestResponse Unmarshall(UnmarshallerContext context)
        {
			MergeMergeRequestResponse mergeMergeRequestResponse = new MergeMergeRequestResponse();

			mergeMergeRequestResponse.HttpResponse = context.HttpResponse;
			mergeMergeRequestResponse.RequestId = context.StringValue("MergeMergeRequest.RequestId");
			mergeMergeRequestResponse.ErrorCode = context.StringValue("MergeMergeRequest.ErrorCode");
			mergeMergeRequestResponse.Success = context.BooleanValue("MergeMergeRequest.Success");
			mergeMergeRequestResponse.ErrorMessage = context.StringValue("MergeMergeRequest.ErrorMessage");

			MergeMergeRequestResponse.MergeMergeRequest_Result result = new MergeMergeRequestResponse.MergeMergeRequest_Result();
			result.Id = context.LongValue("MergeMergeRequest.Result.Id");
			result.ProjectId = context.LongValue("MergeMergeRequest.Result.ProjectId");
			result.Title = context.StringValue("MergeMergeRequest.Result.Title");
			result.Description = context.StringValue("MergeMergeRequest.Result.Description");
			result.State = context.StringValue("MergeMergeRequest.Result.State");
			result.MergeStatus = context.StringValue("MergeMergeRequest.Result.MergeStatus");
			result.CreatedAt = context.StringValue("MergeMergeRequest.Result.CreatedAt");
			result.UpdatedAt = context.StringValue("MergeMergeRequest.Result.UpdatedAt");
			result.TargetBranch = context.StringValue("MergeMergeRequest.Result.TargetBranch");
			result.SourceBranch = context.StringValue("MergeMergeRequest.Result.SourceBranch");
			result.WebUrl = context.StringValue("MergeMergeRequest.Result.WebUrl");
			result.AcceptedRevision = context.StringValue("MergeMergeRequest.Result.AcceptedRevision");
			result.MergeError = context.StringValue("MergeMergeRequest.Result.MergeError");
			result.MergedRevision = context.StringValue("MergeMergeRequest.Result.MergedRevision");
			result.NameWithNamespace = context.StringValue("MergeMergeRequest.Result.NameWithNamespace");
			result.MergeType = context.StringValue("MergeMergeRequest.Result.MergeType");
			result.AheadCommitCount = context.IntegerValue("MergeMergeRequest.Result.AheadCommitCount");
			result.BehindCommitCount = context.IntegerValue("MergeMergeRequest.Result.BehindCommitCount");

			MergeMergeRequestResponse.MergeMergeRequest_Result.MergeMergeRequest_Author author = new MergeMergeRequestResponse.MergeMergeRequest_Result.MergeMergeRequest_Author();
			author.Id = context.LongValue("MergeMergeRequest.Result.Author.Id");
			author.ExternUserId = context.StringValue("MergeMergeRequest.Result.Author.ExternUserId");
			author.AvatarUrl = context.StringValue("MergeMergeRequest.Result.Author.AvatarUrl");
			author.Name = context.StringValue("MergeMergeRequest.Result.Author.Name");
			result.Author = author;

			MergeMergeRequestResponse.MergeMergeRequest_Result.MergeMergeRequest_ApproveCheckResult approveCheckResult = new MergeMergeRequestResponse.MergeMergeRequest_Result.MergeMergeRequest_ApproveCheckResult();
			approveCheckResult.TotalCheckResult = context.StringValue("MergeMergeRequest.Result.ApproveCheckResult.TotalCheckResult");

			List<MergeMergeRequestResponse.MergeMergeRequest_Result.MergeMergeRequest_ApproveCheckResult.MergeMergeRequest_SatisfiedCheckResultsItem> approveCheckResult_satisfiedCheckResults = new List<MergeMergeRequestResponse.MergeMergeRequest_Result.MergeMergeRequest_ApproveCheckResult.MergeMergeRequest_SatisfiedCheckResultsItem>();
			for (int i = 0; i < context.Length("MergeMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults.Length"); i++) {
				MergeMergeRequestResponse.MergeMergeRequest_Result.MergeMergeRequest_ApproveCheckResult.MergeMergeRequest_SatisfiedCheckResultsItem satisfiedCheckResultsItem = new MergeMergeRequestResponse.MergeMergeRequest_Result.MergeMergeRequest_ApproveCheckResult.MergeMergeRequest_SatisfiedCheckResultsItem();
				satisfiedCheckResultsItem.CheckStatus = context.StringValue("MergeMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].CheckStatus");
				satisfiedCheckResultsItem.CheckName = context.StringValue("MergeMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].CheckName");
				satisfiedCheckResultsItem.CheckType = context.StringValue("MergeMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].CheckType");

				List<string> satisfiedCheckResultsItem_satisfiedItems = new List<string>();
				for (int j = 0; j < context.Length("MergeMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].SatisfiedItems.Length"); j++) {
					satisfiedCheckResultsItem_satisfiedItems.Add(context.StringValue("MergeMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].SatisfiedItems["+ j +"]"));
				}
				satisfiedCheckResultsItem.SatisfiedItems = satisfiedCheckResultsItem_satisfiedItems;

				List<string> satisfiedCheckResultsItem_unsatisfiedItems = new List<string>();
				for (int j = 0; j < context.Length("MergeMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].UnsatisfiedItems.Length"); j++) {
					satisfiedCheckResultsItem_unsatisfiedItems.Add(context.StringValue("MergeMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].UnsatisfiedItems["+ j +"]"));
				}
				satisfiedCheckResultsItem.UnsatisfiedItems = satisfiedCheckResultsItem_unsatisfiedItems;

				List<MergeMergeRequestResponse.MergeMergeRequest_Result.MergeMergeRequest_ApproveCheckResult.MergeMergeRequest_SatisfiedCheckResultsItem.MergeMergeRequest_ExtraUsersItem> satisfiedCheckResultsItem_extraUsers = new List<MergeMergeRequestResponse.MergeMergeRequest_Result.MergeMergeRequest_ApproveCheckResult.MergeMergeRequest_SatisfiedCheckResultsItem.MergeMergeRequest_ExtraUsersItem>();
				for (int j = 0; j < context.Length("MergeMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].ExtraUsers.Length"); j++) {
					MergeMergeRequestResponse.MergeMergeRequest_Result.MergeMergeRequest_ApproveCheckResult.MergeMergeRequest_SatisfiedCheckResultsItem.MergeMergeRequest_ExtraUsersItem extraUsersItem = new MergeMergeRequestResponse.MergeMergeRequest_Result.MergeMergeRequest_ApproveCheckResult.MergeMergeRequest_SatisfiedCheckResultsItem.MergeMergeRequest_ExtraUsersItem();
					extraUsersItem.Id = context.LongValue("MergeMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].ExtraUsers["+ j +"].Id");
					extraUsersItem.ExternUserId = context.StringValue("MergeMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].ExtraUsers["+ j +"].ExternUserId");
					extraUsersItem.AvatarUrl = context.StringValue("MergeMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].ExtraUsers["+ j +"].AvatarUrl");
					extraUsersItem.Name = context.StringValue("MergeMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].ExtraUsers["+ j +"].Name");

					satisfiedCheckResultsItem_extraUsers.Add(extraUsersItem);
				}
				satisfiedCheckResultsItem.ExtraUsers = satisfiedCheckResultsItem_extraUsers;

				approveCheckResult_satisfiedCheckResults.Add(satisfiedCheckResultsItem);
			}
			approveCheckResult.SatisfiedCheckResults = approveCheckResult_satisfiedCheckResults;

			List<MergeMergeRequestResponse.MergeMergeRequest_Result.MergeMergeRequest_ApproveCheckResult.MergeMergeRequest_UnsatisfiedCheckResultsItem> approveCheckResult_unsatisfiedCheckResults = new List<MergeMergeRequestResponse.MergeMergeRequest_Result.MergeMergeRequest_ApproveCheckResult.MergeMergeRequest_UnsatisfiedCheckResultsItem>();
			for (int i = 0; i < context.Length("MergeMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults.Length"); i++) {
				MergeMergeRequestResponse.MergeMergeRequest_Result.MergeMergeRequest_ApproveCheckResult.MergeMergeRequest_UnsatisfiedCheckResultsItem unsatisfiedCheckResultsItem = new MergeMergeRequestResponse.MergeMergeRequest_Result.MergeMergeRequest_ApproveCheckResult.MergeMergeRequest_UnsatisfiedCheckResultsItem();
				unsatisfiedCheckResultsItem.CheckStatus = context.StringValue("MergeMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].CheckStatus");
				unsatisfiedCheckResultsItem.CheckName = context.StringValue("MergeMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].CheckName");
				unsatisfiedCheckResultsItem.CheckType = context.StringValue("MergeMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].CheckType");

				List<string> unsatisfiedCheckResultsItem_satisfiedItems1 = new List<string>();
				for (int j = 0; j < context.Length("MergeMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].SatisfiedItems.Length"); j++) {
					unsatisfiedCheckResultsItem_satisfiedItems1.Add(context.StringValue("MergeMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].SatisfiedItems["+ j +"]"));
				}
				unsatisfiedCheckResultsItem.SatisfiedItems1 = unsatisfiedCheckResultsItem_satisfiedItems1;

				List<string> unsatisfiedCheckResultsItem_unsatisfiedItems2 = new List<string>();
				for (int j = 0; j < context.Length("MergeMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].UnsatisfiedItems.Length"); j++) {
					unsatisfiedCheckResultsItem_unsatisfiedItems2.Add(context.StringValue("MergeMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].UnsatisfiedItems["+ j +"]"));
				}
				unsatisfiedCheckResultsItem.UnsatisfiedItems2 = unsatisfiedCheckResultsItem_unsatisfiedItems2;

				List<MergeMergeRequestResponse.MergeMergeRequest_Result.MergeMergeRequest_ApproveCheckResult.MergeMergeRequest_UnsatisfiedCheckResultsItem.MergeMergeRequest_ExtraUsersItem4> unsatisfiedCheckResultsItem_extraUsers3 = new List<MergeMergeRequestResponse.MergeMergeRequest_Result.MergeMergeRequest_ApproveCheckResult.MergeMergeRequest_UnsatisfiedCheckResultsItem.MergeMergeRequest_ExtraUsersItem4>();
				for (int j = 0; j < context.Length("MergeMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].ExtraUsers.Length"); j++) {
					MergeMergeRequestResponse.MergeMergeRequest_Result.MergeMergeRequest_ApproveCheckResult.MergeMergeRequest_UnsatisfiedCheckResultsItem.MergeMergeRequest_ExtraUsersItem4 extraUsersItem4 = new MergeMergeRequestResponse.MergeMergeRequest_Result.MergeMergeRequest_ApproveCheckResult.MergeMergeRequest_UnsatisfiedCheckResultsItem.MergeMergeRequest_ExtraUsersItem4();
					extraUsersItem4.Id = context.LongValue("MergeMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].ExtraUsers["+ j +"].Id");
					extraUsersItem4.ExternUserId = context.StringValue("MergeMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].ExtraUsers["+ j +"].ExternUserId");
					extraUsersItem4.AvatarUrl = context.StringValue("MergeMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].ExtraUsers["+ j +"].AvatarUrl");
					extraUsersItem4.Name = context.StringValue("MergeMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].ExtraUsers["+ j +"].Name");

					unsatisfiedCheckResultsItem_extraUsers3.Add(extraUsersItem4);
				}
				unsatisfiedCheckResultsItem.ExtraUsers3 = unsatisfiedCheckResultsItem_extraUsers3;

				approveCheckResult_unsatisfiedCheckResults.Add(unsatisfiedCheckResultsItem);
			}
			approveCheckResult.UnsatisfiedCheckResults = approveCheckResult_unsatisfiedCheckResults;
			result.ApproveCheckResult = approveCheckResult;

			List<MergeMergeRequestResponse.MergeMergeRequest_Result.MergeMergeRequest_AssigneeListItem> result_assigneeList = new List<MergeMergeRequestResponse.MergeMergeRequest_Result.MergeMergeRequest_AssigneeListItem>();
			for (int i = 0; i < context.Length("MergeMergeRequest.Result.AssigneeList.Length"); i++) {
				MergeMergeRequestResponse.MergeMergeRequest_Result.MergeMergeRequest_AssigneeListItem assigneeListItem = new MergeMergeRequestResponse.MergeMergeRequest_Result.MergeMergeRequest_AssigneeListItem();
				assigneeListItem.Id = context.StringValue("MergeMergeRequest.Result.AssigneeList["+ i +"].Id");
				assigneeListItem.ExternUserId = context.StringValue("MergeMergeRequest.Result.AssigneeList["+ i +"].ExternUserId");
				assigneeListItem.AvatarUrl = context.StringValue("MergeMergeRequest.Result.AssigneeList["+ i +"].AvatarUrl");
				assigneeListItem.Name = context.StringValue("MergeMergeRequest.Result.AssigneeList["+ i +"].Name");

				result_assigneeList.Add(assigneeListItem);
			}
			result.AssigneeList = result_assigneeList;
			mergeMergeRequestResponse.Result = result;
        
			return mergeMergeRequestResponse;
        }
    }
}
