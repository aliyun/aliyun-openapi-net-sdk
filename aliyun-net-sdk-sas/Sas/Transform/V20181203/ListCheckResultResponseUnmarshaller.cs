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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class ListCheckResultResponseUnmarshaller
    {
        public static ListCheckResultResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListCheckResultResponse listCheckResultResponse = new ListCheckResultResponse();

			listCheckResultResponse.HttpResponse = _ctx.HttpResponse;
			listCheckResultResponse.RequestId = _ctx.StringValue("ListCheckResult.RequestId");

			ListCheckResultResponse.ListCheckResult_PageInfo pageInfo = new ListCheckResultResponse.ListCheckResult_PageInfo();
			pageInfo.CurrentPage = _ctx.IntegerValue("ListCheckResult.PageInfo.CurrentPage");
			pageInfo.PageSize = _ctx.IntegerValue("ListCheckResult.PageInfo.PageSize");
			pageInfo.NextToken = _ctx.StringValue("ListCheckResult.PageInfo.NextToken");
			pageInfo.MaxResults = _ctx.IntegerValue("ListCheckResult.PageInfo.MaxResults");
			pageInfo.TotalCount = _ctx.IntegerValue("ListCheckResult.PageInfo.TotalCount");
			pageInfo.Count = _ctx.IntegerValue("ListCheckResult.PageInfo.Count");
			listCheckResultResponse.PageInfo = pageInfo;

			List<ListCheckResultResponse.ListCheckResult_ChecksItem> listCheckResultResponse_checks = new List<ListCheckResultResponse.ListCheckResult_ChecksItem>();
			for (int i = 0; i < _ctx.Length("ListCheckResult.Checks.Length"); i++) {
				ListCheckResultResponse.ListCheckResult_ChecksItem checksItem = new ListCheckResultResponse.ListCheckResult_ChecksItem();
				checksItem.CheckId = _ctx.LongValue("ListCheckResult.Checks["+ i +"].CheckId");
				checksItem.CheckShowName = _ctx.StringValue("ListCheckResult.Checks["+ i +"].CheckShowName");
				checksItem.Vendor = _ctx.StringValue("ListCheckResult.Checks["+ i +"].Vendor");
				checksItem.VendorShowName = _ctx.StringValue("ListCheckResult.Checks["+ i +"].VendorShowName");
				checksItem.InstanceType = _ctx.StringValue("ListCheckResult.Checks["+ i +"].InstanceType");
				checksItem.InstanceSubType = _ctx.StringValue("ListCheckResult.Checks["+ i +"].InstanceSubType");
				checksItem.RiskLevel = _ctx.StringValue("ListCheckResult.Checks["+ i +"].RiskLevel");
				checksItem.Status = _ctx.StringValue("ListCheckResult.Checks["+ i +"].Status");
				checksItem.TaskId = _ctx.StringValue("ListCheckResult.Checks["+ i +"].TaskId");
				checksItem.LastCheckTime = _ctx.LongValue("ListCheckResult.Checks["+ i +"].LastCheckTime");

				List<ListCheckResultResponse.ListCheckResult_ChecksItem.ListCheckResult_CheckPolicie> checksItem_checkPolicies = new List<ListCheckResultResponse.ListCheckResult_ChecksItem.ListCheckResult_CheckPolicie>();
				for (int j = 0; j < _ctx.Length("ListCheckResult.Checks["+ i +"].CheckPolicies.Length"); j++) {
					ListCheckResultResponse.ListCheckResult_ChecksItem.ListCheckResult_CheckPolicie checkPolicie = new ListCheckResultResponse.ListCheckResult_ChecksItem.ListCheckResult_CheckPolicie();
					checkPolicie.StandardId = _ctx.LongValue("ListCheckResult.Checks["+ i +"].CheckPolicies["+ j +"].StandardId");
					checkPolicie.StandardShowName = _ctx.StringValue("ListCheckResult.Checks["+ i +"].CheckPolicies["+ j +"].StandardShowName");
					checkPolicie.RequirementId = _ctx.LongValue("ListCheckResult.Checks["+ i +"].CheckPolicies["+ j +"].RequirementId");
					checkPolicie.RequirementShowName = _ctx.StringValue("ListCheckResult.Checks["+ i +"].CheckPolicies["+ j +"].RequirementShowName");
					checkPolicie.SectionId = _ctx.LongValue("ListCheckResult.Checks["+ i +"].CheckPolicies["+ j +"].SectionId");
					checkPolicie.SectionShowName = _ctx.StringValue("ListCheckResult.Checks["+ i +"].CheckPolicies["+ j +"].SectionShowName");

					checksItem_checkPolicies.Add(checkPolicie);
				}
				checksItem.CheckPolicies = checksItem_checkPolicies;

				listCheckResultResponse_checks.Add(checksItem);
			}
			listCheckResultResponse.Checks = listCheckResultResponse_checks;
        
			return listCheckResultResponse;
        }
    }
}
