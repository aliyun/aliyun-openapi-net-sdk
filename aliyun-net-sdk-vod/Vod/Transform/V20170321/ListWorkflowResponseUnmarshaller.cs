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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.vod.Model.V20170321;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class ListWorkflowResponseUnmarshaller
    {
        public static ListWorkflowResponse Unmarshall(UnmarshallerContext context)
        {
			ListWorkflowResponse listWorkflowResponse = new ListWorkflowResponse();

			listWorkflowResponse.HttpResponse = context.HttpResponse;
			listWorkflowResponse.RequestId = context.StringValue("ListWorkflow.RequestId");

			List<ListWorkflowResponse.ListWorkflow_WorkflowInfo> listWorkflowResponse_workflowInfoList = new List<ListWorkflowResponse.ListWorkflow_WorkflowInfo>();
			for (int i = 0; i < context.Length("ListWorkflow.WorkflowInfoList.Length"); i++) {
				ListWorkflowResponse.ListWorkflow_WorkflowInfo workflowInfo = new ListWorkflowResponse.ListWorkflow_WorkflowInfo();
				workflowInfo.WorkflowId = context.StringValue("ListWorkflow.WorkflowInfoList["+ i +"].WorkflowId");
				workflowInfo.Name = context.StringValue("ListWorkflow.WorkflowInfoList["+ i +"].Name");
				workflowInfo.ActionList = context.StringValue("ListWorkflow.WorkflowInfoList["+ i +"].ActionList");
				workflowInfo.CreationTime = context.StringValue("ListWorkflow.WorkflowInfoList["+ i +"].CreationTime");
				workflowInfo.ModifyTime = context.StringValue("ListWorkflow.WorkflowInfoList["+ i +"].ModifyTime");

				listWorkflowResponse_workflowInfoList.Add(workflowInfo);
			}
			listWorkflowResponse.WorkflowInfoList = listWorkflowResponse_workflowInfoList;
        
			return listWorkflowResponse;
        }
    }
}