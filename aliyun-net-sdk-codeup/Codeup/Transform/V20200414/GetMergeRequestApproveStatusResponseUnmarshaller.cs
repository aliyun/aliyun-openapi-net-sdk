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
    public class GetMergeRequestApproveStatusResponseUnmarshaller
    {
        public static GetMergeRequestApproveStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetMergeRequestApproveStatusResponse getMergeRequestApproveStatusResponse = new GetMergeRequestApproveStatusResponse();

			getMergeRequestApproveStatusResponse.HttpResponse = _ctx.HttpResponse;
			getMergeRequestApproveStatusResponse.ErrorCode = _ctx.StringValue("GetMergeRequestApproveStatus.ErrorCode");
			getMergeRequestApproveStatusResponse.ErrorMessage = _ctx.StringValue("GetMergeRequestApproveStatus.ErrorMessage");
			getMergeRequestApproveStatusResponse.RequestId = _ctx.StringValue("GetMergeRequestApproveStatus.RequestId");
			getMergeRequestApproveStatusResponse.Success = _ctx.BooleanValue("GetMergeRequestApproveStatus.Success");

			GetMergeRequestApproveStatusResponse.GetMergeRequestApproveStatus_Result result = new GetMergeRequestApproveStatusResponse.GetMergeRequestApproveStatus_Result();
			result.ApproveStatus = _ctx.StringValue("GetMergeRequestApproveStatus.Result.ApproveStatus");
			result.Message = _ctx.StringValue("GetMergeRequestApproveStatus.Result.Message");
			getMergeRequestApproveStatusResponse.Result = result;
        
			return getMergeRequestApproveStatusResponse;
        }
    }
}
