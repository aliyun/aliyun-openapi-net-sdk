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
    public class CreateRepositoryProtectedBranchResponseUnmarshaller
    {
        public static CreateRepositoryProtectedBranchResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateRepositoryProtectedBranchResponse createRepositoryProtectedBranchResponse = new CreateRepositoryProtectedBranchResponse();

			createRepositoryProtectedBranchResponse.HttpResponse = _ctx.HttpResponse;
			createRepositoryProtectedBranchResponse.ErrorCode = _ctx.StringValue("CreateRepositoryProtectedBranch.ErrorCode");
			createRepositoryProtectedBranchResponse.ErrorMessage = _ctx.StringValue("CreateRepositoryProtectedBranch.ErrorMessage");
			createRepositoryProtectedBranchResponse.RequestId = _ctx.StringValue("CreateRepositoryProtectedBranch.RequestId");
			createRepositoryProtectedBranchResponse.Success = _ctx.BooleanValue("CreateRepositoryProtectedBranch.Success");

			CreateRepositoryProtectedBranchResponse.CreateRepositoryProtectedBranch_Result result = new CreateRepositoryProtectedBranchResponse.CreateRepositoryProtectedBranch_Result();
			result.Id = _ctx.LongValue("CreateRepositoryProtectedBranch.Result.Id");
			result.Branch = _ctx.StringValue("CreateRepositoryProtectedBranch.Result.Branch");

			List<string> result_allowPushRoles = new List<string>();
			for (int i = 0; i < _ctx.Length("CreateRepositoryProtectedBranch.Result.AllowPushRoles.Length"); i++) {
				result_allowPushRoles.Add(_ctx.StringValue("CreateRepositoryProtectedBranch.Result.AllowPushRoles["+ i +"]"));
			}
			result.AllowPushRoles = result_allowPushRoles;

			List<string> result_allowMergeRoles = new List<string>();
			for (int i = 0; i < _ctx.Length("CreateRepositoryProtectedBranch.Result.AllowMergeRoles.Length"); i++) {
				result_allowMergeRoles.Add(_ctx.StringValue("CreateRepositoryProtectedBranch.Result.AllowMergeRoles["+ i +"]"));
			}
			result.AllowMergeRoles = result_allowMergeRoles;

			CreateRepositoryProtectedBranchResponse.CreateRepositoryProtectedBranch_Result.CreateRepositoryProtectedBranch_MergeRequestSetting mergeRequestSetting = new CreateRepositoryProtectedBranchResponse.CreateRepositoryProtectedBranch_Result.CreateRepositoryProtectedBranch_MergeRequestSetting();
			mergeRequestSetting.Required = _ctx.BooleanValue("CreateRepositoryProtectedBranch.Result.MergeRequestSetting.Required");
			mergeRequestSetting.MergeRequestMode = _ctx.StringValue("CreateRepositoryProtectedBranch.Result.MergeRequestSetting.MergeRequestMode");
			mergeRequestSetting.AllowSelfApproval = _ctx.BooleanValue("CreateRepositoryProtectedBranch.Result.MergeRequestSetting.AllowSelfApproval");
			mergeRequestSetting.IsRequireDiscussionProcessed = _ctx.BooleanValue("CreateRepositoryProtectedBranch.Result.MergeRequestSetting.IsRequireDiscussionProcessed");
			mergeRequestSetting.IsResetApprovalWhenNewPush = _ctx.BooleanValue("CreateRepositoryProtectedBranch.Result.MergeRequestSetting.IsResetApprovalWhenNewPush");
			mergeRequestSetting.MinimualApproval = _ctx.IntegerValue("CreateRepositoryProtectedBranch.Result.MergeRequestSetting.MinimualApproval");

			List<string> mergeRequestSetting_allowMergeRequestRoles = new List<string>();
			for (int i = 0; i < _ctx.Length("CreateRepositoryProtectedBranch.Result.MergeRequestSetting.AllowMergeRequestRoles.Length"); i++) {
				mergeRequestSetting_allowMergeRequestRoles.Add(_ctx.StringValue("CreateRepositoryProtectedBranch.Result.MergeRequestSetting.AllowMergeRequestRoles["+ i +"]"));
			}
			mergeRequestSetting.AllowMergeRequestRoles = mergeRequestSetting_allowMergeRequestRoles;

			List<string> mergeRequestSetting_defaultAssignees = new List<string>();
			for (int i = 0; i < _ctx.Length("CreateRepositoryProtectedBranch.Result.MergeRequestSetting.DefaultAssignees.Length"); i++) {
				mergeRequestSetting_defaultAssignees.Add(_ctx.StringValue("CreateRepositoryProtectedBranch.Result.MergeRequestSetting.DefaultAssignees["+ i +"]"));
			}
			mergeRequestSetting.DefaultAssignees = mergeRequestSetting_defaultAssignees;
			result.MergeRequestSetting = mergeRequestSetting;

			CreateRepositoryProtectedBranchResponse.CreateRepositoryProtectedBranch_Result.CreateRepositoryProtectedBranch_TestSetting testSetting = new CreateRepositoryProtectedBranchResponse.CreateRepositoryProtectedBranch_Result.CreateRepositoryProtectedBranch_TestSetting();
			testSetting.Required = _ctx.BooleanValue("CreateRepositoryProtectedBranch.Result.TestSetting.Required");

			CreateRepositoryProtectedBranchResponse.CreateRepositoryProtectedBranch_Result.CreateRepositoryProtectedBranch_TestSetting.CreateRepositoryProtectedBranch_CodingGuidelinesDetection codingGuidelinesDetection = new CreateRepositoryProtectedBranchResponse.CreateRepositoryProtectedBranch_Result.CreateRepositoryProtectedBranch_TestSetting.CreateRepositoryProtectedBranch_CodingGuidelinesDetection();
			codingGuidelinesDetection.Enabled = _ctx.BooleanValue("CreateRepositoryProtectedBranch.Result.TestSetting.CodingGuidelinesDetection.Enabled");
			codingGuidelinesDetection.Message = _ctx.StringValue("CreateRepositoryProtectedBranch.Result.TestSetting.CodingGuidelinesDetection.Message");
			testSetting.CodingGuidelinesDetection = codingGuidelinesDetection;

			CreateRepositoryProtectedBranchResponse.CreateRepositoryProtectedBranch_Result.CreateRepositoryProtectedBranch_TestSetting.CreateRepositoryProtectedBranch_SensitiveInfoDetection sensitiveInfoDetection = new CreateRepositoryProtectedBranchResponse.CreateRepositoryProtectedBranch_Result.CreateRepositoryProtectedBranch_TestSetting.CreateRepositoryProtectedBranch_SensitiveInfoDetection();
			sensitiveInfoDetection.Enabled = _ctx.BooleanValue("CreateRepositoryProtectedBranch.Result.TestSetting.SensitiveInfoDetection.Enabled");
			sensitiveInfoDetection.Message = _ctx.StringValue("CreateRepositoryProtectedBranch.Result.TestSetting.SensitiveInfoDetection.Message");
			testSetting.SensitiveInfoDetection = sensitiveInfoDetection;

			CreateRepositoryProtectedBranchResponse.CreateRepositoryProtectedBranch_Result.CreateRepositoryProtectedBranch_TestSetting.CreateRepositoryProtectedBranch_CheckConfig checkConfig = new CreateRepositoryProtectedBranchResponse.CreateRepositoryProtectedBranch_Result.CreateRepositoryProtectedBranch_TestSetting.CreateRepositoryProtectedBranch_CheckConfig();

			List<CreateRepositoryProtectedBranchResponse.CreateRepositoryProtectedBranch_Result.CreateRepositoryProtectedBranch_TestSetting.CreateRepositoryProtectedBranch_CheckConfig.CreateRepositoryProtectedBranch_CheckItemsItem> checkConfig_checkItems = new List<CreateRepositoryProtectedBranchResponse.CreateRepositoryProtectedBranch_Result.CreateRepositoryProtectedBranch_TestSetting.CreateRepositoryProtectedBranch_CheckConfig.CreateRepositoryProtectedBranch_CheckItemsItem>();
			for (int i = 0; i < _ctx.Length("CreateRepositoryProtectedBranch.Result.TestSetting.CheckConfig.CheckItems.Length"); i++) {
				CreateRepositoryProtectedBranchResponse.CreateRepositoryProtectedBranch_Result.CreateRepositoryProtectedBranch_TestSetting.CreateRepositoryProtectedBranch_CheckConfig.CreateRepositoryProtectedBranch_CheckItemsItem checkItemsItem = new CreateRepositoryProtectedBranchResponse.CreateRepositoryProtectedBranch_Result.CreateRepositoryProtectedBranch_TestSetting.CreateRepositoryProtectedBranch_CheckConfig.CreateRepositoryProtectedBranch_CheckItemsItem();
				checkItemsItem.Name = _ctx.StringValue("CreateRepositoryProtectedBranch.Result.TestSetting.CheckConfig.CheckItems["+ i +"].Name");
				checkItemsItem.Required = _ctx.BooleanValue("CreateRepositoryProtectedBranch.Result.TestSetting.CheckConfig.CheckItems["+ i +"].Required");

				checkConfig_checkItems.Add(checkItemsItem);
			}
			checkConfig.CheckItems = checkConfig_checkItems;
			testSetting.CheckConfig = checkConfig;
			result.TestSetting = testSetting;
			createRepositoryProtectedBranchResponse.Result = result;
        
			return createRepositoryProtectedBranchResponse;
        }
    }
}
