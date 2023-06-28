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
    public class GetWorkflowInstanceResponseUnmarshaller
    {
        public static GetWorkflowInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetWorkflowInstanceResponse getWorkflowInstanceResponse = new GetWorkflowInstanceResponse();

			getWorkflowInstanceResponse.HttpResponse = _ctx.HttpResponse;
			getWorkflowInstanceResponse.RequestId = _ctx.StringValue("GetWorkflowInstance.RequestId");
			getWorkflowInstanceResponse.Code = _ctx.IntegerValue("GetWorkflowInstance.Code");
			getWorkflowInstanceResponse.Success = _ctx.BooleanValue("GetWorkflowInstance.Success");
			getWorkflowInstanceResponse.Message = _ctx.StringValue("GetWorkflowInstance.Message");

			GetWorkflowInstanceResponse.GetWorkflowInstance_Data data = new GetWorkflowInstanceResponse.GetWorkflowInstance_Data();

			GetWorkflowInstanceResponse.GetWorkflowInstance_Data.GetWorkflowInstance_WfInstanceInfo wfInstanceInfo = new GetWorkflowInstanceResponse.GetWorkflowInstance_Data.GetWorkflowInstance_WfInstanceInfo();
			wfInstanceInfo.Status = _ctx.IntegerValue("GetWorkflowInstance.Data.WfInstanceInfo.Status");
			wfInstanceInfo.StartTime = _ctx.StringValue("GetWorkflowInstance.Data.WfInstanceInfo.StartTime");
			wfInstanceInfo.EndTime = _ctx.StringValue("GetWorkflowInstance.Data.WfInstanceInfo.EndTime");
			wfInstanceInfo.ScheduleTime = _ctx.StringValue("GetWorkflowInstance.Data.WfInstanceInfo.ScheduleTime");
			wfInstanceInfo.DataTime = _ctx.StringValue("GetWorkflowInstance.Data.WfInstanceInfo.DataTime");
			data.WfInstanceInfo = wfInstanceInfo;

			GetWorkflowInstanceResponse.GetWorkflowInstance_Data.GetWorkflowInstance_WfInstanceDag wfInstanceDag = new GetWorkflowInstanceResponse.GetWorkflowInstance_Data.GetWorkflowInstance_WfInstanceDag();

			List<GetWorkflowInstanceResponse.GetWorkflowInstance_Data.GetWorkflowInstance_WfInstanceDag.GetWorkflowInstance_Node> wfInstanceDag_nodes = new List<GetWorkflowInstanceResponse.GetWorkflowInstance_Data.GetWorkflowInstance_WfInstanceDag.GetWorkflowInstance_Node>();
			for (int i = 0; i < _ctx.Length("GetWorkflowInstance.Data.WfInstanceDag.Nodes.Length"); i++) {
				GetWorkflowInstanceResponse.GetWorkflowInstance_Data.GetWorkflowInstance_WfInstanceDag.GetWorkflowInstance_Node node = new GetWorkflowInstanceResponse.GetWorkflowInstance_Data.GetWorkflowInstance_WfInstanceDag.GetWorkflowInstance_Node();
				node.JobInstanceId = _ctx.LongValue("GetWorkflowInstance.Data.WfInstanceDag.Nodes["+ i +"].JobInstanceId");
				node.JobId = _ctx.LongValue("GetWorkflowInstance.Data.WfInstanceDag.Nodes["+ i +"].JobId");
				node.StartTime = _ctx.StringValue("GetWorkflowInstance.Data.WfInstanceDag.Nodes["+ i +"].StartTime");
				node.EndTime = _ctx.StringValue("GetWorkflowInstance.Data.WfInstanceDag.Nodes["+ i +"].EndTime");
				node.ScheduleTime = _ctx.StringValue("GetWorkflowInstance.Data.WfInstanceDag.Nodes["+ i +"].ScheduleTime");
				node.DataTime = _ctx.StringValue("GetWorkflowInstance.Data.WfInstanceDag.Nodes["+ i +"].DataTime");
				node.WorkAddr = _ctx.StringValue("GetWorkflowInstance.Data.WfInstanceDag.Nodes["+ i +"].WorkAddr");
				node.Result = _ctx.StringValue("GetWorkflowInstance.Data.WfInstanceDag.Nodes["+ i +"].Result");
				node.Attempt = _ctx.IntegerValue("GetWorkflowInstance.Data.WfInstanceDag.Nodes["+ i +"].Attempt");

				wfInstanceDag_nodes.Add(node);
			}
			wfInstanceDag.Nodes = wfInstanceDag_nodes;

			List<GetWorkflowInstanceResponse.GetWorkflowInstance_Data.GetWorkflowInstance_WfInstanceDag.GetWorkflowInstance_Edge> wfInstanceDag_edges = new List<GetWorkflowInstanceResponse.GetWorkflowInstance_Data.GetWorkflowInstance_WfInstanceDag.GetWorkflowInstance_Edge>();
			for (int i = 0; i < _ctx.Length("GetWorkflowInstance.Data.WfInstanceDag.Edges.Length"); i++) {
				GetWorkflowInstanceResponse.GetWorkflowInstance_Data.GetWorkflowInstance_WfInstanceDag.GetWorkflowInstance_Edge edge = new GetWorkflowInstanceResponse.GetWorkflowInstance_Data.GetWorkflowInstance_WfInstanceDag.GetWorkflowInstance_Edge();
				edge.Source = _ctx.LongValue("GetWorkflowInstance.Data.WfInstanceDag.Edges["+ i +"].Source");
				edge.Target = _ctx.LongValue("GetWorkflowInstance.Data.WfInstanceDag.Edges["+ i +"].Target");

				wfInstanceDag_edges.Add(edge);
			}
			wfInstanceDag.Edges = wfInstanceDag_edges;
			data.WfInstanceDag = wfInstanceDag;
			getWorkflowInstanceResponse.Data = data;
        
			return getWorkflowInstanceResponse;
        }
    }
}
