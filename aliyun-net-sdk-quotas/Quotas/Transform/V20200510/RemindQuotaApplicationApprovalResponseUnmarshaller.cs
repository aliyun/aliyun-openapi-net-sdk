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
    public class RemindQuotaApplicationApprovalResponseUnmarshaller
    {
        public static RemindQuotaApplicationApprovalResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RemindQuotaApplicationApprovalResponse remindQuotaApplicationApprovalResponse = new RemindQuotaApplicationApprovalResponse();

			remindQuotaApplicationApprovalResponse.HttpResponse = _ctx.HttpResponse;
			remindQuotaApplicationApprovalResponse.RequestId = _ctx.StringValue("RemindQuotaApplicationApproval.RequestId");
			remindQuotaApplicationApprovalResponse.HttpStatusCode = _ctx.IntegerValue("RemindQuotaApplicationApproval.HttpStatusCode");
			remindQuotaApplicationApprovalResponse.DynamicCode = _ctx.StringValue("RemindQuotaApplicationApproval.DynamicCode");
			remindQuotaApplicationApprovalResponse.DynamicMessage = _ctx.StringValue("RemindQuotaApplicationApproval.DynamicMessage");
			remindQuotaApplicationApprovalResponse.ErrorMsg = _ctx.StringValue("RemindQuotaApplicationApproval.ErrorMsg");
			remindQuotaApplicationApprovalResponse.ErrorCode = _ctx.StringValue("RemindQuotaApplicationApproval.ErrorCode");
			remindQuotaApplicationApprovalResponse.Success = _ctx.BooleanValue("RemindQuotaApplicationApproval.Success");
			remindQuotaApplicationApprovalResponse.Module = _ctx.StringValue("RemindQuotaApplicationApproval.Module");
			remindQuotaApplicationApprovalResponse.AllowRetry = _ctx.BooleanValue("RemindQuotaApplicationApproval.AllowRetry");

			List<string> remindQuotaApplicationApprovalResponse_errorArgs = new List<string>();
			for (int i = 0; i < _ctx.Length("RemindQuotaApplicationApproval.ErrorArgs.Length"); i++) {
				remindQuotaApplicationApprovalResponse_errorArgs.Add(_ctx.StringValue("RemindQuotaApplicationApproval.ErrorArgs["+ i +"]"));
			}
			remindQuotaApplicationApprovalResponse.ErrorArgs = remindQuotaApplicationApprovalResponse_errorArgs;
        
			return remindQuotaApplicationApprovalResponse;
        }
    }
}
