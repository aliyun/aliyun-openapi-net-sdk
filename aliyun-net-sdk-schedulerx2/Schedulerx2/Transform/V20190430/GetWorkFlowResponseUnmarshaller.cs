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
using Aliyun.Acs.schedulerx2.Model.V20190430;

namespace Aliyun.Acs.schedulerx2.Transform.V20190430
{
    public class GetWorkFlowResponseUnmarshaller
    {
        public static GetWorkFlowResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetWorkFlowResponse getWorkFlowResponse = new GetWorkFlowResponse();

			getWorkFlowResponse.HttpResponse = _ctx.HttpResponse;
			getWorkFlowResponse.RequestId = _ctx.StringValue("GetWorkFlow.RequestId");
			getWorkFlowResponse.Code = _ctx.IntegerValue("GetWorkFlow.Code");
			getWorkFlowResponse.Message = _ctx.StringValue("GetWorkFlow.Message");
			getWorkFlowResponse.Success = _ctx.BooleanValue("GetWorkFlow.Success");

			GetWorkFlowResponse.GetWorkFlow_Data data = new GetWorkFlowResponse.GetWorkFlow_Data();

			GetWorkFlowResponse.GetWorkFlow_Data.GetWorkFlow_WorkFlowInfo workFlowInfo = new GetWorkFlowResponse.GetWorkFlow_Data.GetWorkFlow_WorkFlowInfo();
			workFlowInfo.WorkflowId = _ctx.LongValue("GetWorkFlow.Data.WorkFlowInfo.WorkflowId");
			workFlowInfo.Name = _ctx.StringValue("GetWorkFlow.Data.WorkFlowInfo.Name");
			workFlowInfo.Description = _ctx.StringValue("GetWorkFlow.Data.WorkFlowInfo.Description");
			workFlowInfo.Status = _ctx.StringValue("GetWorkFlow.Data.WorkFlowInfo.Status");
			workFlowInfo.TimeType = _ctx.StringValue("GetWorkFlow.Data.WorkFlowInfo.TimeType");
			workFlowInfo.TimeExpression = _ctx.StringValue("GetWorkFlow.Data.WorkFlowInfo.TimeExpression");
			workFlowInfo.GroupId = _ctx.StringValue("GetWorkFlow.Data.WorkFlowInfo.GroupId");
			workFlowInfo._Namespace = _ctx.StringValue("GetWorkFlow.Data.WorkFlowInfo.Namespace");
			workFlowInfo.MaxConcurrency = _ctx.StringValue("GetWorkFlow.Data.WorkFlowInfo.MaxConcurrency");
			data.WorkFlowInfo = workFlowInfo;

			GetWorkFlowResponse.GetWorkFlow_Data.GetWorkFlow_WorkFlowNodeInfo workFlowNodeInfo = new GetWorkFlowResponse.GetWorkFlow_Data.GetWorkFlow_WorkFlowNodeInfo();

			List<GetWorkFlowResponse.GetWorkFlow_Data.GetWorkFlow_WorkFlowNodeInfo.GetWorkFlow_Node> workFlowNodeInfo_nodes = new List<GetWorkFlowResponse.GetWorkFlow_Data.GetWorkFlow_WorkFlowNodeInfo.GetWorkFlow_Node>();
			for (int i = 0; i < _ctx.Length("GetWorkFlow.Data.WorkFlowNodeInfo.Nodes.Length"); i++) {
				GetWorkFlowResponse.GetWorkFlow_Data.GetWorkFlow_WorkFlowNodeInfo.GetWorkFlow_Node node = new GetWorkFlowResponse.GetWorkFlow_Data.GetWorkFlow_WorkFlowNodeInfo.GetWorkFlow_Node();
				node.Id = _ctx.LongValue("GetWorkFlow.Data.WorkFlowNodeInfo.Nodes["+ i +"].Id");
				node.Label = _ctx.StringValue("GetWorkFlow.Data.WorkFlowNodeInfo.Nodes["+ i +"].Label");
				node.Status = _ctx.IntegerValue("GetWorkFlow.Data.WorkFlowNodeInfo.Nodes["+ i +"].Status");

				workFlowNodeInfo_nodes.Add(node);
			}
			workFlowNodeInfo.Nodes = workFlowNodeInfo_nodes;

			List<GetWorkFlowResponse.GetWorkFlow_Data.GetWorkFlow_WorkFlowNodeInfo.GetWorkFlow_Edge> workFlowNodeInfo_edges = new List<GetWorkFlowResponse.GetWorkFlow_Data.GetWorkFlow_WorkFlowNodeInfo.GetWorkFlow_Edge>();
			for (int i = 0; i < _ctx.Length("GetWorkFlow.Data.WorkFlowNodeInfo.Edges.Length"); i++) {
				GetWorkFlowResponse.GetWorkFlow_Data.GetWorkFlow_WorkFlowNodeInfo.GetWorkFlow_Edge edge = new GetWorkFlowResponse.GetWorkFlow_Data.GetWorkFlow_WorkFlowNodeInfo.GetWorkFlow_Edge();
				edge.Source = _ctx.LongValue("GetWorkFlow.Data.WorkFlowNodeInfo.Edges["+ i +"].Source");
				edge.Target = _ctx.LongValue("GetWorkFlow.Data.WorkFlowNodeInfo.Edges["+ i +"].Target");

				workFlowNodeInfo_edges.Add(edge);
			}
			workFlowNodeInfo.Edges = workFlowNodeInfo_edges;
			data.WorkFlowNodeInfo = workFlowNodeInfo;
			getWorkFlowResponse.Data = data;
        
			return getWorkFlowResponse;
        }
    }
}
