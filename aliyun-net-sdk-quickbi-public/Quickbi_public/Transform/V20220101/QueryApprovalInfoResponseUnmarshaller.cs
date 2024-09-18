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
using Aliyun.Acs.quickbi_public.Model.V20220101;

namespace Aliyun.Acs.quickbi_public.Transform.V20220101
{
    public class QueryApprovalInfoResponseUnmarshaller
    {
        public static QueryApprovalInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryApprovalInfoResponse queryApprovalInfoResponse = new QueryApprovalInfoResponse();

			queryApprovalInfoResponse.HttpResponse = _ctx.HttpResponse;
			queryApprovalInfoResponse.RequestId = _ctx.StringValue("QueryApprovalInfo.RequestId");
			queryApprovalInfoResponse.Success = _ctx.BooleanValue("QueryApprovalInfo.Success");

			QueryApprovalInfoResponse.QueryApprovalInfo_Result result = new QueryApprovalInfoResponse.QueryApprovalInfo_Result();
			result.Page = _ctx.IntegerValue("QueryApprovalInfo.Result.Page");
			result.PageSize = _ctx.IntegerValue("QueryApprovalInfo.Result.PageSize");
			result.Start = _ctx.IntegerValue("QueryApprovalInfo.Result.Start");
			result.Total = _ctx.IntegerValue("QueryApprovalInfo.Result.Total");
			result.TotalPages = _ctx.IntegerValue("QueryApprovalInfo.Result.TotalPages");

			List<QueryApprovalInfoResponse.QueryApprovalInfo_Result.QueryApprovalInfo_ApprovalsResultModel> result_data = new List<QueryApprovalInfoResponse.QueryApprovalInfo_Result.QueryApprovalInfo_ApprovalsResultModel>();
			for (int i = 0; i < _ctx.Length("QueryApprovalInfo.Result.Data.Length"); i++) {
				QueryApprovalInfoResponse.QueryApprovalInfo_Result.QueryApprovalInfo_ApprovalsResultModel approvalsResultModel = new QueryApprovalInfoResponse.QueryApprovalInfo_Result.QueryApprovalInfo_ApprovalsResultModel();
				approvalsResultModel.ApplicantId = _ctx.StringValue("QueryApprovalInfo.Result.Data["+ i +"].ApplicantId");
				approvalsResultModel.ApplicantName = _ctx.StringValue("QueryApprovalInfo.Result.Data["+ i +"].ApplicantName");
				approvalsResultModel.ApplicationId = _ctx.StringValue("QueryApprovalInfo.Result.Data["+ i +"].ApplicationId");
				approvalsResultModel.ApplyReason = _ctx.StringValue("QueryApprovalInfo.Result.Data["+ i +"].ApplyReason");
				approvalsResultModel.ApproverId = _ctx.StringValue("QueryApprovalInfo.Result.Data["+ i +"].ApproverId");
				approvalsResultModel.ApproverName = _ctx.StringValue("QueryApprovalInfo.Result.Data["+ i +"].ApproverName");
				approvalsResultModel.DeleteFlag = _ctx.BooleanValue("QueryApprovalInfo.Result.Data["+ i +"].DeleteFlag");
				approvalsResultModel.ExpireDate = _ctx.LongValue("QueryApprovalInfo.Result.Data["+ i +"].ExpireDate");
				approvalsResultModel.FlagStatus = _ctx.IntegerValue("QueryApprovalInfo.Result.Data["+ i +"].FlagStatus");
				approvalsResultModel.GmtCreate = _ctx.LongValue("QueryApprovalInfo.Result.Data["+ i +"].GmtCreate");
				approvalsResultModel.GmtModified = _ctx.LongValue("QueryApprovalInfo.Result.Data["+ i +"].GmtModified");
				approvalsResultModel.HandleReason = _ctx.StringValue("QueryApprovalInfo.Result.Data["+ i +"].HandleReason");
				approvalsResultModel.ResourceId = _ctx.StringValue("QueryApprovalInfo.Result.Data["+ i +"].ResourceId");
				approvalsResultModel.ResourceName = _ctx.StringValue("QueryApprovalInfo.Result.Data["+ i +"].ResourceName");
				approvalsResultModel.ResourceType = _ctx.StringValue("QueryApprovalInfo.Result.Data["+ i +"].ResourceType");
				approvalsResultModel.WorkspaceName = _ctx.StringValue("QueryApprovalInfo.Result.Data["+ i +"].WorkspaceName");

				result_data.Add(approvalsResultModel);
			}
			result.Data = result_data;
			queryApprovalInfoResponse.Result = result;
        
			return queryApprovalInfoResponse;
        }
    }
}
