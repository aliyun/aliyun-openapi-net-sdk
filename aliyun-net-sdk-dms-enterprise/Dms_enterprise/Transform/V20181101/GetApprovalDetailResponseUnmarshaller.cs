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
using Aliyun.Acs.dms_enterprise.Model.V20181101;

namespace Aliyun.Acs.dms_enterprise.Transform.V20181101
{
    public class GetApprovalDetailResponseUnmarshaller
    {
        public static GetApprovalDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetApprovalDetailResponse getApprovalDetailResponse = new GetApprovalDetailResponse();

			getApprovalDetailResponse.HttpResponse = _ctx.HttpResponse;
			getApprovalDetailResponse.RequestId = _ctx.StringValue("GetApprovalDetail.RequestId");
			getApprovalDetailResponse.ErrorCode = _ctx.StringValue("GetApprovalDetail.ErrorCode");
			getApprovalDetailResponse.ErrorMessage = _ctx.StringValue("GetApprovalDetail.ErrorMessage");
			getApprovalDetailResponse.Success = _ctx.BooleanValue("GetApprovalDetail.Success");

			GetApprovalDetailResponse.GetApprovalDetail_ApprovalDetail approvalDetail = new GetApprovalDetailResponse.GetApprovalDetail_ApprovalDetail();
			approvalDetail.Description = _ctx.StringValue("GetApprovalDetail.ApprovalDetail.Description");
			approvalDetail.OrderType = _ctx.StringValue("GetApprovalDetail.ApprovalDetail.OrderType");
			approvalDetail.Title = _ctx.StringValue("GetApprovalDetail.ApprovalDetail.Title");
			approvalDetail.AuditId = _ctx.LongValue("GetApprovalDetail.ApprovalDetail.AuditId");
			approvalDetail.OrderId = _ctx.LongValue("GetApprovalDetail.ApprovalDetail.OrderId");
			approvalDetail.WorkflowInsCode = _ctx.StringValue("GetApprovalDetail.ApprovalDetail.WorkflowInsCode");

			List<string> approvalDetail_reasonList = new List<string>();
			for (int i = 0; i < _ctx.Length("GetApprovalDetail.ApprovalDetail.ReasonList.Length"); i++) {
				approvalDetail_reasonList.Add(_ctx.StringValue("GetApprovalDetail.ApprovalDetail.ReasonList["+ i +"]"));
			}
			approvalDetail.ReasonList = approvalDetail_reasonList;

			List<GetApprovalDetailResponse.GetApprovalDetail_ApprovalDetail.GetApprovalDetail_WorkflowNode> approvalDetail_workflowNodes = new List<GetApprovalDetailResponse.GetApprovalDetail_ApprovalDetail.GetApprovalDetail_WorkflowNode>();
			for (int i = 0; i < _ctx.Length("GetApprovalDetail.ApprovalDetail.WorkflowNodes.Length"); i++) {
				GetApprovalDetailResponse.GetApprovalDetail_ApprovalDetail.GetApprovalDetail_WorkflowNode workflowNode = new GetApprovalDetailResponse.GetApprovalDetail_ApprovalDetail.GetApprovalDetail_WorkflowNode();
				workflowNode.OperateTime = _ctx.StringValue("GetApprovalDetail.ApprovalDetail.WorkflowNodes["+ i +"].OperateTime");
				workflowNode.OperatorId = _ctx.LongValue("GetApprovalDetail.ApprovalDetail.WorkflowNodes["+ i +"].OperatorId");
				workflowNode.NodeName = _ctx.StringValue("GetApprovalDetail.ApprovalDetail.WorkflowNodes["+ i +"].NodeName");
				workflowNode.OperateComment = _ctx.StringValue("GetApprovalDetail.ApprovalDetail.WorkflowNodes["+ i +"].OperateComment");
				workflowNode.WorkflowInsCode = _ctx.StringValue("GetApprovalDetail.ApprovalDetail.WorkflowNodes["+ i +"].WorkflowInsCode");

				List<string> workflowNode_auditUserIdList = new List<string>();
				for (int j = 0; j < _ctx.Length("GetApprovalDetail.ApprovalDetail.WorkflowNodes["+ i +"].AuditUserIdList.Length"); j++) {
					workflowNode_auditUserIdList.Add(_ctx.StringValue("GetApprovalDetail.ApprovalDetail.WorkflowNodes["+ i +"].AuditUserIdList["+ j +"]"));
				}
				workflowNode.AuditUserIdList = workflowNode_auditUserIdList;

				approvalDetail_workflowNodes.Add(workflowNode);
			}
			approvalDetail.WorkflowNodes = approvalDetail_workflowNodes;

			List<GetApprovalDetailResponse.GetApprovalDetail_ApprovalDetail.GetApprovalDetail_CurrentHandler> approvalDetail_currentHandlers = new List<GetApprovalDetailResponse.GetApprovalDetail_ApprovalDetail.GetApprovalDetail_CurrentHandler>();
			for (int i = 0; i < _ctx.Length("GetApprovalDetail.ApprovalDetail.CurrentHandlers.Length"); i++) {
				GetApprovalDetailResponse.GetApprovalDetail_ApprovalDetail.GetApprovalDetail_CurrentHandler currentHandler = new GetApprovalDetailResponse.GetApprovalDetail_ApprovalDetail.GetApprovalDetail_CurrentHandler();
				currentHandler.NickName = _ctx.StringValue("GetApprovalDetail.ApprovalDetail.CurrentHandlers["+ i +"].NickName");
				currentHandler.Id = _ctx.LongValue("GetApprovalDetail.ApprovalDetail.CurrentHandlers["+ i +"].Id");

				approvalDetail_currentHandlers.Add(currentHandler);
			}
			approvalDetail.CurrentHandlers = approvalDetail_currentHandlers;
			getApprovalDetailResponse.ApprovalDetail = approvalDetail;
        
			return getApprovalDetailResponse;
        }
    }
}
