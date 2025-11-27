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
using Aliyun.Acs.Ims.Model.V20190815;

namespace Aliyun.Acs.Ims.Transform.V20190815
{
    public class GetAccountSummaryResponseUnmarshaller
    {
        public static GetAccountSummaryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetAccountSummaryResponse getAccountSummaryResponse = new GetAccountSummaryResponse();

			getAccountSummaryResponse.HttpResponse = _ctx.HttpResponse;
			getAccountSummaryResponse.RequestId = _ctx.StringValue("GetAccountSummary.RequestId");

			GetAccountSummaryResponse.GetAccountSummary_SummaryMap summaryMap = new GetAccountSummaryResponse.GetAccountSummary_SummaryMap();
			summaryMap.MFADevices = _ctx.IntegerValue("GetAccountSummary.SummaryMap.MFADevices");
			summaryMap.AccessKeysPerUserQuota = _ctx.IntegerValue("GetAccountSummary.SummaryMap.AccessKeysPerUserQuota");
			summaryMap.AttachedPoliciesPerGroupQuota = _ctx.IntegerValue("GetAccountSummary.SummaryMap.AttachedPoliciesPerGroupQuota");
			summaryMap.AttachedSystemPoliciesPerRoleQuota = _ctx.IntegerValue("GetAccountSummary.SummaryMap.AttachedSystemPoliciesPerRoleQuota");
			summaryMap.AttachedPoliciesPerRoleQuota = _ctx.IntegerValue("GetAccountSummary.SummaryMap.AttachedPoliciesPerRoleQuota");
			summaryMap.GroupsPerUserQuota = _ctx.IntegerValue("GetAccountSummary.SummaryMap.GroupsPerUserQuota");
			summaryMap.Roles = _ctx.IntegerValue("GetAccountSummary.SummaryMap.Roles");
			summaryMap.PolicySizeQuota = _ctx.IntegerValue("GetAccountSummary.SummaryMap.PolicySizeQuota");
			summaryMap.AttachedSystemPoliciesPerGroupQuota = _ctx.IntegerValue("GetAccountSummary.SummaryMap.AttachedSystemPoliciesPerGroupQuota");
			summaryMap.AttachedSystemPoliciesPerUserQuota = _ctx.IntegerValue("GetAccountSummary.SummaryMap.AttachedSystemPoliciesPerUserQuota");
			summaryMap.AttachedPoliciesPerUserQuota = _ctx.IntegerValue("GetAccountSummary.SummaryMap.AttachedPoliciesPerUserQuota");
			summaryMap.GroupsQuota = _ctx.IntegerValue("GetAccountSummary.SummaryMap.GroupsQuota");
			summaryMap.Groups = _ctx.IntegerValue("GetAccountSummary.SummaryMap.Groups");
			summaryMap.PoliciesQuota = _ctx.IntegerValue("GetAccountSummary.SummaryMap.PoliciesQuota");
			summaryMap.VirtualMFADevicesQuota = _ctx.IntegerValue("GetAccountSummary.SummaryMap.VirtualMFADevicesQuota");
			summaryMap.VersionsPerPolicyQuota = _ctx.IntegerValue("GetAccountSummary.SummaryMap.VersionsPerPolicyQuota");
			summaryMap.RolesQuota = _ctx.IntegerValue("GetAccountSummary.SummaryMap.RolesQuota");
			summaryMap.UsersQuota = _ctx.IntegerValue("GetAccountSummary.SummaryMap.UsersQuota");
			summaryMap.Policies = _ctx.IntegerValue("GetAccountSummary.SummaryMap.Policies");
			summaryMap.Users = _ctx.IntegerValue("GetAccountSummary.SummaryMap.Users");
			summaryMap.MFADevicesInUse = _ctx.IntegerValue("GetAccountSummary.SummaryMap.MFADevicesInUse");
			getAccountSummaryResponse.SummaryMap = summaryMap;
        
			return getAccountSummaryResponse;
        }
    }
}
