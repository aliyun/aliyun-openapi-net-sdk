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
    public class ListWorkFlowNodesResponseUnmarshaller
    {
        public static ListWorkFlowNodesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListWorkFlowNodesResponse listWorkFlowNodesResponse = new ListWorkFlowNodesResponse();

			listWorkFlowNodesResponse.HttpResponse = _ctx.HttpResponse;
			listWorkFlowNodesResponse.RequestId = _ctx.StringValue("ListWorkFlowNodes.RequestId");
			listWorkFlowNodesResponse.ErrorCode = _ctx.StringValue("ListWorkFlowNodes.ErrorCode");
			listWorkFlowNodesResponse.ErrorMessage = _ctx.StringValue("ListWorkFlowNodes.ErrorMessage");
			listWorkFlowNodesResponse.Success = _ctx.BooleanValue("ListWorkFlowNodes.Success");

			List<ListWorkFlowNodesResponse.ListWorkFlowNodes_WorkflowNode> listWorkFlowNodesResponse_workflowNodes = new List<ListWorkFlowNodesResponse.ListWorkFlowNodes_WorkflowNode>();
			for (int i = 0; i < _ctx.Length("ListWorkFlowNodes.WorkflowNodes.Length"); i++) {
				ListWorkFlowNodesResponse.ListWorkFlowNodes_WorkflowNode workflowNode = new ListWorkFlowNodesResponse.ListWorkFlowNodes_WorkflowNode();
				workflowNode.Comment = _ctx.StringValue("ListWorkFlowNodes.WorkflowNodes["+ i +"].Comment");
				workflowNode.CreateUserNickName = _ctx.StringValue("ListWorkFlowNodes.WorkflowNodes["+ i +"].CreateUserNickName");
				workflowNode.NodeType = _ctx.StringValue("ListWorkFlowNodes.WorkflowNodes["+ i +"].NodeType");
				workflowNode.NodeName = _ctx.StringValue("ListWorkFlowNodes.WorkflowNodes["+ i +"].NodeName");
				workflowNode.CreateUserId = _ctx.LongValue("ListWorkFlowNodes.WorkflowNodes["+ i +"].CreateUserId");
				workflowNode.NodeId = _ctx.LongValue("ListWorkFlowNodes.WorkflowNodes["+ i +"].NodeId");

				List<ListWorkFlowNodesResponse.ListWorkFlowNodes_WorkflowNode.ListWorkFlowNodes_AuditUser> workflowNode_auditUsers = new List<ListWorkFlowNodesResponse.ListWorkFlowNodes_WorkflowNode.ListWorkFlowNodes_AuditUser>();
				for (int j = 0; j < _ctx.Length("ListWorkFlowNodes.WorkflowNodes["+ i +"].AuditUsers.Length"); j++) {
					ListWorkFlowNodesResponse.ListWorkFlowNodes_WorkflowNode.ListWorkFlowNodes_AuditUser auditUser = new ListWorkFlowNodesResponse.ListWorkFlowNodes_WorkflowNode.ListWorkFlowNodes_AuditUser();
					auditUser.RealName = _ctx.StringValue("ListWorkFlowNodes.WorkflowNodes["+ i +"].AuditUsers["+ j +"].RealName");
					auditUser.UserId = _ctx.LongValue("ListWorkFlowNodes.WorkflowNodes["+ i +"].AuditUsers["+ j +"].UserId");
					auditUser.NickName = _ctx.StringValue("ListWorkFlowNodes.WorkflowNodes["+ i +"].AuditUsers["+ j +"].NickName");

					workflowNode_auditUsers.Add(auditUser);
				}
				workflowNode.AuditUsers = workflowNode_auditUsers;

				listWorkFlowNodesResponse_workflowNodes.Add(workflowNode);
			}
			listWorkFlowNodesResponse.WorkflowNodes = listWorkFlowNodesResponse_workflowNodes;
        
			return listWorkFlowNodesResponse;
        }
    }
}
