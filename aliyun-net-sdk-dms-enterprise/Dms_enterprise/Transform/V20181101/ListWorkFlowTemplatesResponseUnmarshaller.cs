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
        public static ListWorkFlowTemplatesResponse Unmarshall(UnmarshallerContext context)
        {
			ListWorkFlowTemplatesResponse listWorkFlowTemplatesResponse = new ListWorkFlowTemplatesResponse();

			listWorkFlowTemplatesResponse.HttpResponse = context.HttpResponse;
			listWorkFlowTemplatesResponse.RequestId = context.StringValue("ListWorkFlowTemplates.RequestId");
			listWorkFlowTemplatesResponse.Success = context.BooleanValue("ListWorkFlowTemplates.Success");
			listWorkFlowTemplatesResponse.ErrorMessage = context.StringValue("ListWorkFlowTemplates.ErrorMessage");
			listWorkFlowTemplatesResponse.ErrorCode = context.StringValue("ListWorkFlowTemplates.ErrorCode");

			List<ListWorkFlowTemplatesResponse.ListWorkFlowTemplates_WorkFlowTemplate> listWorkFlowTemplatesResponse_workFlowTemplates = new List<ListWorkFlowTemplatesResponse.ListWorkFlowTemplates_WorkFlowTemplate>();
			for (int i = 0; i < context.Length("ListWorkFlowTemplates.WorkFlowTemplates.Length"); i++) {
				ListWorkFlowTemplatesResponse.ListWorkFlowTemplates_WorkFlowTemplate workFlowTemplate = new ListWorkFlowTemplatesResponse.ListWorkFlowTemplates_WorkFlowTemplate();
				workFlowTemplate.TemplateName = context.StringValue("ListWorkFlowTemplates.WorkFlowTemplates["+ i +"].TemplateName");
				workFlowTemplate.Comment = context.StringValue("ListWorkFlowTemplates.WorkFlowTemplates["+ i +"].Comment");
				workFlowTemplate.TemplateId = context.LongValue("ListWorkFlowTemplates.WorkFlowTemplates["+ i +"].TemplateId");
				workFlowTemplate.IsSystem = context.IntegerValue("ListWorkFlowTemplates.WorkFlowTemplates["+ i +"].IsSystem");
				workFlowTemplate.Enabled = context.StringValue("ListWorkFlowTemplates.WorkFlowTemplates["+ i +"].Enabled");

				List<ListWorkFlowTemplatesResponse.ListWorkFlowTemplates_WorkFlowTemplate.ListWorkFlowTemplates_WorkflowNode> workFlowTemplate_workflowNodes = new List<ListWorkFlowTemplatesResponse.ListWorkFlowTemplates_WorkFlowTemplate.ListWorkFlowTemplates_WorkflowNode>();
				for (int j = 0; j < context.Length("ListWorkFlowTemplates.WorkFlowTemplates["+ i +"].WorkflowNodes.Length"); j++) {
					ListWorkFlowTemplatesResponse.ListWorkFlowTemplates_WorkFlowTemplate.ListWorkFlowTemplates_WorkflowNode workflowNode = new ListWorkFlowTemplatesResponse.ListWorkFlowTemplates_WorkFlowTemplate.ListWorkFlowTemplates_WorkflowNode();
					workflowNode.NodeId = context.LongValue("ListWorkFlowTemplates.WorkFlowTemplates["+ i +"].WorkflowNodes["+ j +"].NodeId");
					workflowNode.TemplateId = context.LongValue("ListWorkFlowTemplates.WorkFlowTemplates["+ i +"].WorkflowNodes["+ j +"].TemplateId");
					workflowNode.NodeName = context.StringValue("ListWorkFlowTemplates.WorkFlowTemplates["+ i +"].WorkflowNodes["+ j +"].NodeName");
					workflowNode.NodeType = context.StringValue("ListWorkFlowTemplates.WorkFlowTemplates["+ i +"].WorkflowNodes["+ j +"].NodeType");
					workflowNode.Comment = context.StringValue("ListWorkFlowTemplates.WorkFlowTemplates["+ i +"].WorkflowNodes["+ j +"].Comment");
					workflowNode.Position = context.IntegerValue("ListWorkFlowTemplates.WorkFlowTemplates["+ i +"].WorkflowNodes["+ j +"].Position");

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
