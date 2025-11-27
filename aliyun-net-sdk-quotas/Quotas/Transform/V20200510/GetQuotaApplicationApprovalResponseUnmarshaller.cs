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
using Aliyun.Acs.quotas.Model.V20200510;

namespace Aliyun.Acs.quotas.Transform.V20200510
{
    public class GetQuotaApplicationApprovalResponseUnmarshaller
    {
        public static GetQuotaApplicationApprovalResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetQuotaApplicationApprovalResponse getQuotaApplicationApprovalResponse = new GetQuotaApplicationApprovalResponse();

			getQuotaApplicationApprovalResponse.HttpResponse = _ctx.HttpResponse;
			getQuotaApplicationApprovalResponse.RequestId = _ctx.StringValue("GetQuotaApplicationApproval.RequestId");
			getQuotaApplicationApprovalResponse.HttpStatusCode = _ctx.IntegerValue("GetQuotaApplicationApproval.HttpStatusCode");
			getQuotaApplicationApprovalResponse.DynamicCode = _ctx.StringValue("GetQuotaApplicationApproval.DynamicCode");
			getQuotaApplicationApprovalResponse.DynamicMessage = _ctx.StringValue("GetQuotaApplicationApproval.DynamicMessage");
			getQuotaApplicationApprovalResponse.ErrorMsg = _ctx.StringValue("GetQuotaApplicationApproval.ErrorMsg");
			getQuotaApplicationApprovalResponse.ErrorCode = _ctx.StringValue("GetQuotaApplicationApproval.ErrorCode");
			getQuotaApplicationApprovalResponse.Success = _ctx.BooleanValue("GetQuotaApplicationApproval.Success");
			getQuotaApplicationApprovalResponse.AllowRetry = _ctx.BooleanValue("GetQuotaApplicationApproval.AllowRetry");

			List<string> getQuotaApplicationApprovalResponse_errorArgs = new List<string>();
			for (int i = 0; i < _ctx.Length("GetQuotaApplicationApproval.ErrorArgs.Length"); i++) {
				getQuotaApplicationApprovalResponse_errorArgs.Add(_ctx.StringValue("GetQuotaApplicationApproval.ErrorArgs["+ i +"]"));
			}
			getQuotaApplicationApprovalResponse.ErrorArgs = getQuotaApplicationApprovalResponse_errorArgs;

			GetQuotaApplicationApprovalResponse.GetQuotaApplicationApproval_Module module = new GetQuotaApplicationApprovalResponse.GetQuotaApplicationApproval_Module();
			module.ApprovalHours = _ctx.IntegerValue("GetQuotaApplicationApproval.Module.ApprovalHours");
			module.SupportReminder = _ctx.BooleanValue("GetQuotaApplicationApproval.Module.SupportReminder");
			module.UnsupportReminderReason = _ctx.StringValue("GetQuotaApplicationApproval.Module.UnsupportReminderReason");
			module.ReminderIntervalHours = _ctx.IntegerValue("GetQuotaApplicationApproval.Module.ReminderIntervalHours");
			getQuotaApplicationApprovalResponse.Module = module;
        
			return getQuotaApplicationApprovalResponse;
        }
    }
}
