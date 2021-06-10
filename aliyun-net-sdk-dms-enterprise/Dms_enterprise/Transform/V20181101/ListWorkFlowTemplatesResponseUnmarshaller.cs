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
    public class ListWorkFlowTemplatesResponseUnmarshaller
    {
        public static ListWorkFlowTemplatesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListWorkFlowTemplatesResponse listWorkFlowTemplatesResponse = new ListWorkFlowTemplatesResponse();

			listWorkFlowTemplatesResponse.HttpResponse = _ctx.HttpResponse;
			listWorkFlowTemplatesResponse.RequestId = _ctx.StringValue("ListWorkFlowTemplates.RequestId");
			listWorkFlowTemplatesResponse.ErrorCode = _ctx.StringValue("ListWorkFlowTemplates.ErrorCode");
			listWorkFlowTemplatesResponse.ErrorMessage = _ctx.StringValue("ListWorkFlowTemplates.ErrorMessage");
			listWorkFlowTemplatesResponse.Success = _ctx.BooleanValue("ListWorkFlowTemplates.Success");

			List<ListWorkFlowTemplatesResponse.ListWorkFlowTemplates_WorkFlowTemplate> listWorkFlowTemplatesResponse_workFlowTemplates = new List<ListWorkFlowTemplatesResponse.ListWorkFlowTemplates_WorkFlowTemplate>();
			for (int i = 0; i < _ctx.Length("ListWorkFlowTemplates.WorkFlowTemplates.Length"); i++) {
				ListWorkFlowTemplatesResponse.ListWorkFlowTemplates_WorkFlowTemplate workFlowTemplate = new ListWorkFlowTemplatesResponse.ListWorkFlowTemplates_WorkFlowTemplate();
				workFlowTemplate.IsSystem = _ctx.IntegerValue("ListWorkFlowTemplates.WorkFlowTemplates["+ i +"].IsSystem");
				workFlowTemplate.Comment = _ctx.StringValue("ListWorkFlowTemplates.WorkFlowTemplates["+ i +"].Comment");
				workFlowTemplate.Enabled = _ctx.StringValue("ListWorkFlowTemplates.WorkFlowTemplates["+ i +"].Enabled");
				workFlowTemplate.TemplateName = _ctx.StringValue("ListWorkFlowTemplates.WorkFlowTemplates["+ i +"].TemplateName");
				workFlowTemplate.TemplateId = _ctx.LongValue("ListWorkFlowTemplates.WorkFlowTemplates["+ i +"].TemplateId");
				workFlowTemplate.CreateUserId = _ctx.LongValue("ListWorkFlowTemplates.WorkFlowTemplates["+ i +"].CreateUserId");

				List<ListWorkFlowTemplatesResponse.ListWorkFlowTemplates_WorkFlowTemplate.ListWorkFlowTemplates_WorkflowNode> workFlowTemplate_workflowNodes = new List<ListWorkFlowTemplatesResponse.ListWorkFlowTemplates_WorkFlowTemplate.ListWorkFlowTemplates_WorkflowNode>();
				for (int j = 0; j < _ctx.Length("ListWorkFlowTemplates.WorkFlowTemplates["+ i +"].WorkflowNodes.Length"); j++) {
					ListWorkFlowTemplatesResponse.ListWorkFlowTemplates_WorkFlowTemplate.ListWorkFlowTemplates_WorkflowNode workflowNode = new ListWorkFlowTemplatesResponse.ListWorkFlowTemplates_WorkFlowTemplate.ListWorkFlowTemplates_WorkflowNode();
					workflowNode.Comment = _ctx.StringValue("ListWorkFlowTemplates.WorkFlowTemplates["+ i +"].WorkflowNodes["+ j +"].Comment");
					workflowNode.NodeType = _ctx.StringValue("ListWorkFlowTemplates.WorkFlowTemplates["+ i +"].WorkflowNodes["+ j +"].NodeType");
					workflowNode.NodeName = _ctx.StringValue("ListWorkFlowTemplates.WorkFlowTemplates["+ i +"].WorkflowNodes["+ j +"].NodeName");
					workflowNode.Position = _ctx.IntegerValue("ListWorkFlowTemplates.WorkFlowTemplates["+ i +"].WorkflowNodes["+ j +"].Position");
					workflowNode.CreateUserId = _ctx.LongValue("ListWorkFlowTemplates.WorkFlowTemplates["+ i +"].WorkflowNodes["+ j +"].CreateUserId");
					workflowNode.TemplateId = _ctx.LongValue("ListWorkFlowTemplates.WorkFlowTemplates["+ i +"].WorkflowNodes["+ j +"].TemplateId");
					workflowNode.NodeId = _ctx.LongValue("ListWorkFlowTemplates.WorkFlowTemplates["+ i +"].WorkflowNodes["+ j +"].NodeId");

					workFlowTemplate_workflowNodes.Add(workflowNode);
				}
				workFlowTemplate.WorkflowNodes = workFlowTemplate_workflowNodes;

				listWorkFlowTemplatesResponse_workFlowTemplates.Add(workFlowTemplate);
			}
			listWorkFlowTemplatesResponse.WorkFlowTemplates = listWorkFlowTemplatesResponse_workFlowTemplates;
        
			return listWorkFlowTemplatesResponse;
        }
    }
}
