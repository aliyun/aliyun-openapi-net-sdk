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
    public class ListMergeRequestsResponseUnmarshaller
    {
        public static ListMergeRequestsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListMergeRequestsResponse listMergeRequestsResponse = new ListMergeRequestsResponse();

			listMergeRequestsResponse.HttpResponse = _ctx.HttpResponse;
			listMergeRequestsResponse.ErrorCode = _ctx.StringValue("ListMergeRequests.ErrorCode");
			listMergeRequestsResponse.ErrorMessage = _ctx.StringValue("ListMergeRequests.ErrorMessage");
			listMergeRequestsResponse.RequestId = _ctx.StringValue("ListMergeRequests.RequestId");
			listMergeRequestsResponse.Success = _ctx.BooleanValue("ListMergeRequests.Success");
			listMergeRequestsResponse.Total = _ctx.LongValue("ListMergeRequests.Total");

			List<ListMergeRequestsResponse.ListMergeRequests_ResultItem> listMergeRequestsResponse_result = new List<ListMergeRequestsResponse.ListMergeRequests_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListMergeRequests.Result.Length"); i++) {
				ListMergeRequestsResponse.ListMergeRequests_ResultItem resultItem = new ListMergeRequestsResponse.ListMergeRequests_ResultItem();
				resultItem.AcceptedRevision = _ctx.StringValue("ListMergeRequests.Result["+ i +"].AcceptedRevision");
				resultItem.AheadCommitCount = _ctx.IntegerValue("ListMergeRequests.Result["+ i +"].AheadCommitCount");
				resultItem.BehindCommitCount = _ctx.IntegerValue("ListMergeRequests.Result["+ i +"].BehindCommitCount");
				resultItem.CreatedAt = _ctx.StringValue("ListMergeRequests.Result["+ i +"].CreatedAt");
				resultItem.Description = _ctx.StringValue("ListMergeRequests.Result["+ i +"].Description");
				resultItem.Id = _ctx.LongValue("ListMergeRequests.Result["+ i +"].Id");
				resultItem.MergeError = _ctx.StringValue("ListMergeRequests.Result["+ i +"].MergeError");
				resultItem.MergeStatus = _ctx.StringValue("ListMergeRequests.Result["+ i +"].MergeStatus");
				resultItem.MergeType = _ctx.StringValue("ListMergeRequests.Result["+ i +"].MergeType");
				resultItem.MergedRevision = _ctx.StringValue("ListMergeRequests.Result["+ i +"].MergedRevision");
				resultItem.NameWithNamespace = _ctx.StringValue("ListMergeRequests.Result["+ i +"].NameWithNamespace");
				resultItem.ProjectId = _ctx.LongValue("ListMergeRequests.Result["+ i +"].ProjectId");
				resultItem.SourceBranch = _ctx.StringValue("ListMergeRequests.Result["+ i +"].SourceBranch");
				resultItem.State = _ctx.StringValue("ListMergeRequests.Result["+ i +"].State");
				resultItem.TargetBranch = _ctx.StringValue("ListMergeRequests.Result["+ i +"].TargetBranch");
				resultItem.Title = _ctx.StringValue("ListMergeRequests.Result["+ i +"].Title");
				resultItem.UpdatedAt = _ctx.StringValue("ListMergeRequests.Result["+ i +"].UpdatedAt");
				resultItem.WebUrl = _ctx.StringValue("ListMergeRequests.Result["+ i +"].WebUrl");
				resultItem.IsSupportMerge = _ctx.BooleanValue("ListMergeRequests.Result["+ i +"].IsSupportMerge");

				ListMergeRequestsResponse.ListMergeRequests_ResultItem.ListMergeRequests_ApproveCheckResult approveCheckResult = new ListMergeRequestsResponse.ListMergeRequests_ResultItem.ListMergeRequests_ApproveCheckResult();
				approveCheckResult.TotalCheckResult = _ctx.StringValue("ListMergeRequests.Result["+ i +"].ApproveCheckResult.TotalCheckResult");

				List<ListMergeRequestsResponse.ListMergeRequests_ResultItem.ListMergeRequests_ApproveCheckResult.ListMergeRequests_SatisfiedCheckResultsItem> approveCheckResult_satisfiedCheckResults = new List<ListMergeRequestsResponse.ListMergeRequests_ResultItem.ListMergeRequests_ApproveCheckResult.ListMergeRequests_SatisfiedCheckResultsItem>();
				for (int j = 0; j < _ctx.Length("ListMergeRequests.Result["+ i +"].ApproveCheckResult.SatisfiedCheckResults.Length"); j++) {
					ListMergeRequestsResponse.ListMergeRequests_ResultItem.ListMergeRequests_ApproveCheckResult.ListMergeRequests_SatisfiedCheckResultsItem satisfiedCheckResultsItem = new ListMergeRequestsResponse.ListMergeRequests_ResultItem.ListMergeRequests_ApproveCheckResult.ListMergeRequests_SatisfiedCheckResultsItem();
					satisfiedCheckResultsItem.CheckName = _ctx.StringValue("ListMergeRequests.Result["+ i +"].ApproveCheckResult.SatisfiedCheckResults["+ j +"].CheckName");
					satisfiedCheckResultsItem.CheckStatus = _ctx.StringValue("ListMergeRequests.Result["+ i +"].ApproveCheckResult.SatisfiedCheckResults["+ j +"].CheckStatus");
					satisfiedCheckResultsItem.CheckType = _ctx.StringValue("ListMergeRequests.Result["+ i +"].ApproveCheckResult.SatisfiedCheckResults["+ j +"].CheckType");

					List<string> satisfiedCheckResultsItem_satisfiedItems = new List<string>();
					for (int k = 0; k < _ctx.Length("ListMergeRequests.Result["+ i +"].ApproveCheckResult.SatisfiedCheckResults["+ j +"].SatisfiedItems.Length"); k++) {
						satisfiedCheckResultsItem_satisfiedItems.Add(_ctx.StringValue("ListMergeRequests.Result["+ i +"].ApproveCheckResult.SatisfiedCheckResults["+ j +"].SatisfiedItems["+ k +"]"));
					}
					satisfiedCheckResultsItem.SatisfiedItems = satisfiedCheckResultsItem_satisfiedItems;

					List<string> satisfiedCheckResultsItem_unsatisfiedItems = new List<string>();
					for (int k = 0; k < _ctx.Length("ListMergeRequests.Result["+ i +"].ApproveCheckResult.SatisfiedCheckResults["+ j +"].UnsatisfiedItems.Length"); k++) {
						satisfiedCheckResultsItem_unsatisfiedItems.Add(_ctx.StringValue("ListMergeRequests.Result["+ i +"].ApproveCheckResult.SatisfiedCheckResults["+ j +"].UnsatisfiedItems["+ k +"]"));
					}
					satisfiedCheckResultsItem.UnsatisfiedItems = satisfiedCheckResultsItem_unsatisfiedItems;

					List<ListMergeRequestsResponse.ListMergeRequests_ResultItem.ListMergeRequests_ApproveCheckResult.ListMergeRequests_SatisfiedCheckResultsItem.ListMergeRequests_ExtraUsersItem> satisfiedCheckResultsItem_extraUsers = new List<ListMergeRequestsResponse.ListMergeRequests_ResultItem.ListMergeRequests_ApproveCheckResult.ListMergeRequests_SatisfiedCheckResultsItem.ListMergeRequests_ExtraUsersItem>();
					for (int k = 0; k < _ctx.Length("ListMergeRequests.Result["+ i +"].ApproveCheckResult.SatisfiedCheckResults["+ j +"].ExtraUsers.Length"); k++) {
						ListMergeRequestsResponse.ListMergeRequests_ResultItem.ListMergeRequests_ApproveCheckResult.ListMergeRequests_SatisfiedCheckResultsItem.ListMergeRequests_ExtraUsersItem extraUsersItem = new ListMergeRequestsResponse.ListMergeRequests_ResultItem.ListMergeRequests_ApproveCheckResult.ListMergeRequests_SatisfiedCheckResultsItem.ListMergeRequests_ExtraUsersItem();
						extraUsersItem.AvatarUrl = _ctx.StringValue("ListMergeRequests.Result["+ i +"].ApproveCheckResult.SatisfiedCheckResults["+ j +"].ExtraUsers["+ k +"].AvatarUrl");
						extraUsersItem.ExternUserId = _ctx.StringValue("ListMergeRequests.Result["+ i +"].ApproveCheckResult.SatisfiedCheckResults["+ j +"].ExtraUsers["+ k +"].ExternUserId");
						extraUsersItem.Id = _ctx.LongValue("ListMergeRequests.Result["+ i +"].ApproveCheckResult.SatisfiedCheckResults["+ j +"].ExtraUsers["+ k +"].Id");
						extraUsersItem.Name = _ctx.StringValue("ListMergeRequests.Result["+ i +"].ApproveCheckResult.SatisfiedCheckResults["+ j +"].ExtraUsers["+ k +"].Name");

						satisfiedCheckResultsItem_extraUsers.Add(extraUsersItem);
					}
					satisfiedCheckResultsItem.ExtraUsers = satisfiedCheckResultsItem_extraUsers;

					approveCheckResult_satisfiedCheckResults.Add(satisfiedCheckResultsItem);
				}
				approveCheckResult.SatisfiedCheckResults = approveCheckResult_satisfiedCheckResults;

				List<ListMergeRequestsResponse.ListMergeRequests_ResultItem.ListMergeRequests_ApproveCheckResult.ListMergeRequests_UnsatisfiedCheckResultsItem> approveCheckResult_unsatisfiedCheckResults = new List<ListMergeRequestsResponse.ListMergeRequests_ResultItem.ListMergeRequests_ApproveCheckResult.ListMergeRequests_UnsatisfiedCheckResultsItem>();
				for (int j = 0; j < _ctx.Length("ListMergeRequests.Result["+ i +"].ApproveCheckResult.UnsatisfiedCheckResults.Length"); j++) {
					ListMergeRequestsResponse.ListMergeRequests_ResultItem.ListMergeRequests_ApproveCheckResult.ListMergeRequests_UnsatisfiedCheckResultsItem unsatisfiedCheckResultsItem = new ListMergeRequestsResponse.ListMergeRequests_ResultItem.ListMergeRequests_ApproveCheckResult.ListMergeRequests_UnsatisfiedCheckResultsItem();
					unsatisfiedCheckResultsItem.CheckName = _ctx.StringValue("ListMergeRequests.Result["+ i +"].ApproveCheckResult.UnsatisfiedCheckResults["+ j +"].CheckName");
					unsatisfiedCheckResultsItem.CheckStatus = _ctx.StringValue("ListMergeRequests.Result["+ i +"].ApproveCheckResult.UnsatisfiedCheckResults["+ j +"].CheckStatus");
					unsatisfiedCheckResultsItem.CheckType = _ctx.StringValue("ListMergeRequests.Result["+ i +"].ApproveCheckResult.UnsatisfiedCheckResults["+ j +"].CheckType");

					List<string> unsatisfiedCheckResultsItem_satisfiedItems1 = new List<string>();
					for (int k = 0; k < _ctx.Length("ListMergeRequests.Result["+ i +"].ApproveCheckResult.UnsatisfiedCheckResults["+ j +"].SatisfiedItems.Length"); k++) {
						unsatisfiedCheckResultsItem_satisfiedItems1.Add(_ctx.StringValue("ListMergeRequests.Result["+ i +"].ApproveCheckResult.UnsatisfiedCheckResults["+ j +"].SatisfiedItems["+ k +"]"));
					}
					unsatisfiedCheckResultsItem.SatisfiedItems1 = unsatisfiedCheckResultsItem_satisfiedItems1;

					List<string> unsatisfiedCheckResultsItem_unsatisfiedItems2 = new List<string>();
					for (int k = 0; k < _ctx.Length("ListMergeRequests.Result["+ i +"].ApproveCheckResult.UnsatisfiedCheckResults["+ j +"].UnsatisfiedItems.Length"); k++) {
						unsatisfiedCheckResultsItem_unsatisfiedItems2.Add(_ctx.StringValue("ListMergeRequests.Result["+ i +"].ApproveCheckResult.UnsatisfiedCheckResults["+ j +"].UnsatisfiedItems["+ k +"]"));
					}
					unsatisfiedCheckResultsItem.UnsatisfiedItems2 = unsatisfiedCheckResultsItem_unsatisfiedItems2;

					List<ListMergeRequestsResponse.ListMergeRequests_ResultItem.ListMergeRequests_ApproveCheckResult.ListMergeRequests_UnsatisfiedCheckResultsItem.ListMergeRequests_ExtraUsersItem4> unsatisfiedCheckResultsItem_extraUsers3 = new List<ListMergeRequestsResponse.ListMergeRequests_ResultItem.ListMergeRequests_ApproveCheckResult.ListMergeRequests_UnsatisfiedCheckResultsItem.ListMergeRequests_ExtraUsersItem4>();
					for (int k = 0; k < _ctx.Length("ListMergeRequests.Result["+ i +"].ApproveCheckResult.UnsatisfiedCheckResults["+ j +"].ExtraUsers.Length"); k++) {
						ListMergeRequestsResponse.ListMergeRequests_ResultItem.ListMergeRequests_ApproveCheckResult.ListMergeRequests_UnsatisfiedCheckResultsItem.ListMergeRequests_ExtraUsersItem4 extraUsersItem4 = new ListMergeRequestsResponse.ListMergeRequests_ResultItem.ListMergeRequests_ApproveCheckResult.ListMergeRequests_UnsatisfiedCheckResultsItem.ListMergeRequests_ExtraUsersItem4();
						extraUsersItem4.AvatarUrl = _ctx.StringValue("ListMergeRequests.Result["+ i +"].ApproveCheckResult.UnsatisfiedCheckResults["+ j +"].ExtraUsers["+ k +"].AvatarUrl");
						extraUsersItem4.ExternUserId = _ctx.StringValue("ListMergeRequests.Result["+ i +"].ApproveCheckResult.UnsatisfiedCheckResults["+ j +"].ExtraUsers["+ k +"].ExternUserId");
						extraUsersItem4.Id = _ctx.LongValue("ListMergeRequests.Result["+ i +"].ApproveCheckResult.UnsatisfiedCheckResults["+ j +"].ExtraUsers["+ k +"].Id");
						extraUsersItem4.Name = _ctx.StringValue("ListMergeRequests.Result["+ i +"].ApproveCheckResult.UnsatisfiedCheckResults["+ j +"].ExtraUsers["+ k +"].Name");

						unsatisfiedCheckResultsItem_extraUsers3.Add(extraUsersItem4);
					}
					unsatisfiedCheckResultsItem.ExtraUsers3 = unsatisfiedCheckResultsItem_extraUsers3;

					approveCheckResult_unsatisfiedCheckResults.Add(unsatisfiedCheckResultsItem);
				}
				approveCheckResult.UnsatisfiedCheckResults = approveCheckResult_unsatisfiedCheckResults;
				resultItem.ApproveCheckResult = approveCheckResult;

				ListMergeRequestsResponse.ListMergeRequests_ResultItem.ListMergeRequests_Author author = new ListMergeRequestsResponse.ListMergeRequests_ResultItem.ListMergeRequests_Author();
				author.AvatarUrl = _ctx.StringValue("ListMergeRequests.Result["+ i +"].Author.AvatarUrl");
				author.ExternUserId = _ctx.StringValue("ListMergeRequests.Result["+ i +"].Author.ExternUserId");
				author.Id = _ctx.LongValue("ListMergeRequests.Result["+ i +"].Author.Id");
				author.Name = _ctx.StringValue("ListMergeRequests.Result["+ i +"].Author.Name");
				resultItem.Author = author;

				List<ListMergeRequestsResponse.ListMergeRequests_ResultItem.ListMergeRequests_AssigneeListItem> resultItem_assigneeList = new List<ListMergeRequestsResponse.ListMergeRequests_ResultItem.ListMergeRequests_AssigneeListItem>();
				for (int j = 0; j < _ctx.Length("ListMergeRequests.Result["+ i +"].AssigneeList.Length"); j++) {
					ListMergeRequestsResponse.ListMergeRequests_ResultItem.ListMergeRequests_AssigneeListItem assigneeListItem = new ListMergeRequestsResponse.ListMergeRequests_ResultItem.ListMergeRequests_AssigneeListItem();
					assigneeListItem.AvatarUrl = _ctx.StringValue("ListMergeRequests.Result["+ i +"].AssigneeList["+ j +"].AvatarUrl");
					assigneeListItem.ExternUserId = _ctx.StringValue("ListMergeRequests.Result["+ i +"].AssigneeList["+ j +"].ExternUserId");
					assigneeListItem.Id = _ctx.StringValue("ListMergeRequests.Result["+ i +"].AssigneeList["+ j +"].Id");
					assigneeListItem.Name = _ctx.StringValue("ListMergeRequests.Result["+ i +"].AssigneeList["+ j +"].Name");
					assigneeListItem.Status = _ctx.StringValue("ListMergeRequests.Result["+ i +"].AssigneeList["+ j +"].Status");
					assigneeListItem.Email = _ctx.StringValue("ListMergeRequests.Result["+ i +"].AssigneeList["+ j +"].Email");

					resultItem_assigneeList.Add(assigneeListItem);
				}
				resultItem.AssigneeList = resultItem_assigneeList;

				listMergeRequestsResponse_result.Add(resultItem);
			}
			listMergeRequestsResponse.Result = listMergeRequestsResponse_result;
        
			return listMergeRequestsResponse;
        }
    }
}
