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
        public static GetApprovalDetailResponse Unmarshall(UnmarshallerContext context)
        {
			GetApprovalDetailResponse getApprovalDetailResponse = new GetApprovalDetailResponse();

			getApprovalDetailResponse.HttpResponse = context.HttpResponse;
			getApprovalDetailResponse.RequestId = context.StringValue("GetApprovalDetail.RequestId");
			getApprovalDetailResponse.Success = context.BooleanValue("GetApprovalDetail.Success");
			getApprovalDetailResponse.ErrorMessage = context.StringValue("GetApprovalDetail.ErrorMessage");
			getApprovalDetailResponse.ErrorCode = context.StringValue("GetApprovalDetail.ErrorCode");

			GetApprovalDetailResponse.GetApprovalDetail_ApprovalDetail approvalDetail = new GetApprovalDetailResponse.GetApprovalDetail_ApprovalDetail();
			approvalDetail.AuditId = context.LongValue("GetApprovalDetail.ApprovalDetail.AuditId");
			approvalDetail.OrderId = context.LongValue("GetApprovalDetail.ApprovalDetail.OrderId");
			approvalDetail.OrderType = context.StringValue("GetApprovalDetail.ApprovalDetail.OrderType");
			approvalDetail.Title = context.StringValue("GetApprovalDetail.ApprovalDetail.Title");
			approvalDetail.WorkflowInsCode = context.StringValue("GetApprovalDetail.ApprovalDetail.WorkflowInsCode");
			approvalDetail.Description = context.StringValue("GetApprovalDetail.ApprovalDetail.Description");

			List<string> approvalDetail_reasonList = new List<string>();
			for (int i = 0; i < context.Length("GetApprovalDetail.ApprovalDetail.ReasonList.Length"); i++) {
				approvalDetail_reasonList.Add(context.StringValue("GetApprovalDetail.ApprovalDetail.ReasonList["+ i +"]"));
			}
			approvalDetail.ReasonList = approvalDetail_reasonList;

			List<GetApprovalDetailResponse.GetApprovalDetail_ApprovalDetail.GetApprovalDetail_WorkflowNode> approvalDetail_workflowNodes = new List<GetApprovalDetailResponse.GetApprovalDetail_ApprovalDetail.GetApprovalDetail_WorkflowNode>();
			for (int i = 0; i < context.Length("GetApprovalDetail.ApprovalDetail.WorkflowNodes.Length"); i++) {
				GetApprovalDetailResponse.GetApprovalDetail_ApprovalDetail.GetApprovalDetail_WorkflowNode workflowNode = new GetApprovalDetailResponse.GetApprovalDetail_ApprovalDetail.GetApprovalDetail_WorkflowNode();
				workflowNode.NodeName = context.StringValue("GetApprovalDetail.ApprovalDetail.WorkflowNodes["+ i +"].NodeName");
				workflowNode.OperateComment = context.StringValue("GetApprovalDetail.ApprovalDetail.WorkflowNodes["+ i +"].OperateComment");
				workflowNode.OperateTime = context.StringValue("GetApprovalDetail.ApprovalDetail.WorkflowNodes["+ i +"].OperateTime");
				workflowNode.OperatorId = context.LongValue("GetApprovalDetail.ApprovalDetail.WorkflowNodes["+ i +"].OperatorId");
				workflowNode.WorkflowInsCode = context.StringValue("GetApprovalDetail.ApprovalDetail.WorkflowNodes["+ i +"].WorkflowInsCode");

				List<string> workflowNode_auditUserIdList = new List<string>();
				for (int j = 0; j < context.Length("GetApprovalDetail.ApprovalDetail.WorkflowNodes["+ i +"].AuditUserIdList.Length"); j++) {
					workflowNode_auditUserIdList.Add(context.StringValue("GetApprovalDetail.ApprovalDetail.WorkflowNodes["+ i +"].AuditUserIdList["+ j +"]"));
				}
				workflowNode.AuditUserIdList = workflowNode_auditUserIdList;

				approvalDetail_workflowNodes.Add(workflowNode);
			}
			approvalDetail.WorkflowNodes = approvalDetail_workflowNodes;

			List<GetApprovalDetailResponse.GetApprovalDetail_ApprovalDetail.GetApprovalDetail_CurrentHandler> approvalDetail_currentHandlers = new List<GetApprovalDetailResponse.GetApprovalDetail_ApprovalDetail.GetApprovalDetail_CurrentHandler>();
			for (int i = 0; i < context.Length("GetApprovalDetail.ApprovalDetail.CurrentHandlers.Length"); i++) {
				GetApprovalDetailResponse.GetApprovalDetail_ApprovalDetail.GetApprovalDetail_CurrentHandler currentHandler = new GetApprovalDetailResponse.GetApprovalDetail_ApprovalDetail.GetApprovalDetail_CurrentHandler();
				currentHandler.Id = context.LongValue("GetApprovalDetail.ApprovalDetail.CurrentHandlers["+ i +"].Id");
				currentHandler.NickName = context.StringValue("GetApprovalDetail.ApprovalDetail.CurrentHandlers["+ i +"].NickName");

				approvalDetail_currentHandlers.Add(currentHandler);
			}
			approvalDetail.CurrentHandlers = approvalDetail_currentHandlers;
			getApprovalDetailResponse.ApprovalDetail = approvalDetail;
        
			return getApprovalDetailResponse;
        }
    }
}
