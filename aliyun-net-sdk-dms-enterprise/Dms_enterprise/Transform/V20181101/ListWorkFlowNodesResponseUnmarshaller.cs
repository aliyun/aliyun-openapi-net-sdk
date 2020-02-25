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
        public static ListWorkFlowNodesResponse Unmarshall(UnmarshallerContext context)
        {
			ListWorkFlowNodesResponse listWorkFlowNodesResponse = new ListWorkFlowNodesResponse();

			listWorkFlowNodesResponse.HttpResponse = context.HttpResponse;
			listWorkFlowNodesResponse.RequestId = context.StringValue("ListWorkFlowNodes.RequestId");
			listWorkFlowNodesResponse.Success = context.BooleanValue("ListWorkFlowNodes.Success");
			listWorkFlowNodesResponse.ErrorMessage = context.StringValue("ListWorkFlowNodes.ErrorMessage");
			listWorkFlowNodesResponse.ErrorCode = context.StringValue("ListWorkFlowNodes.ErrorCode");

			List<ListWorkFlowNodesResponse.ListWorkFlowNodes_WorkflowNode> listWorkFlowNodesResponse_workflowNodes = new List<ListWorkFlowNodesResponse.ListWorkFlowNodes_WorkflowNode>();
			for (int i = 0; i < context.Length("ListWorkFlowNodes.WorkflowNodes.Length"); i++) {
				ListWorkFlowNodesResponse.ListWorkFlowNodes_WorkflowNode workflowNode = new ListWorkFlowNodesResponse.ListWorkFlowNodes_WorkflowNode();
				workflowNode.NodeName = context.StringValue("ListWorkFlowNodes.WorkflowNodes["+ i +"].NodeName");
				workflowNode.Comment = context.StringValue("ListWorkFlowNodes.WorkflowNodes["+ i +"].Comment");
				workflowNode.NodeId = context.LongValue("ListWorkFlowNodes.WorkflowNodes["+ i +"].NodeId");
				workflowNode.NodeType = context.StringValue("ListWorkFlowNodes.WorkflowNodes["+ i +"].NodeType");
				workflowNode.CreateUserId = context.LongValue("ListWorkFlowNodes.WorkflowNodes["+ i +"].CreateUserId");
				workflowNode.CreateUserNickName = context.StringValue("ListWorkFlowNodes.WorkflowNodes["+ i +"].CreateUserNickName");

				List<ListWorkFlowNodesResponse.ListWorkFlowNodes_WorkflowNode.ListWorkFlowNodes_AuditUser> workflowNode_auditUsers = new List<ListWorkFlowNodesResponse.ListWorkFlowNodes_WorkflowNode.ListWorkFlowNodes_AuditUser>();
				for (int j = 0; j < context.Length("ListWorkFlowNodes.WorkflowNodes["+ i +"].AuditUsers.Length"); j++) {
					ListWorkFlowNodesResponse.ListWorkFlowNodes_WorkflowNode.ListWorkFlowNodes_AuditUser auditUser = new ListWorkFlowNodesResponse.ListWorkFlowNodes_WorkflowNode.ListWorkFlowNodes_AuditUser();
					auditUser.UserId = context.LongValue("ListWorkFlowNodes.WorkflowNodes["+ i +"].AuditUsers["+ j +"].UserId");
					auditUser.NickName = context.StringValue("ListWorkFlowNodes.WorkflowNodes["+ i +"].AuditUsers["+ j +"].NickName");
					auditUser.RealName = context.StringValue("ListWorkFlowNodes.WorkflowNodes["+ i +"].AuditUsers["+ j +"].RealName");

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
