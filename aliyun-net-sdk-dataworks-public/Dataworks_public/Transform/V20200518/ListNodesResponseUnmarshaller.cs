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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class ListNodesResponseUnmarshaller
    {
        public static ListNodesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListNodesResponse listNodesResponse = new ListNodesResponse();

			listNodesResponse.HttpResponse = _ctx.HttpResponse;
			listNodesResponse.Success = _ctx.BooleanValue("ListNodes.Success");
			listNodesResponse.HttpStatusCode = _ctx.IntegerValue("ListNodes.HttpStatusCode");
			listNodesResponse.ErrorCode = _ctx.StringValue("ListNodes.ErrorCode");
			listNodesResponse.ErrorMessage = _ctx.StringValue("ListNodes.ErrorMessage");
			listNodesResponse.RequestId = _ctx.StringValue("ListNodes.RequestId");

			ListNodesResponse.ListNodes_Data data = new ListNodesResponse.ListNodes_Data();
			data.PageNumber = _ctx.IntegerValue("ListNodes.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("ListNodes.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("ListNodes.Data.TotalCount");

			List<ListNodesResponse.ListNodes_Data.ListNodes_NodesItem> data_nodes = new List<ListNodesResponse.ListNodes_Data.ListNodes_NodesItem>();
			for (int i = 0; i < _ctx.Length("ListNodes.Data.Nodes.Length"); i++) {
				ListNodesResponse.ListNodes_Data.ListNodes_NodesItem nodesItem = new ListNodesResponse.ListNodes_Data.ListNodes_NodesItem();
				nodesItem.NodeId = _ctx.LongValue("ListNodes.Data.Nodes["+ i +"].NodeId");
				nodesItem.NodeName = _ctx.StringValue("ListNodes.Data.Nodes["+ i +"].NodeName");
				nodesItem.CronExpress = _ctx.StringValue("ListNodes.Data.Nodes["+ i +"].CronExpress");
				nodesItem.SchedulerType = _ctx.StringValue("ListNodes.Data.Nodes["+ i +"].SchedulerType");
				nodesItem.ProgramType = _ctx.StringValue("ListNodes.Data.Nodes["+ i +"].ProgramType");
				nodesItem.OwnerId = _ctx.StringValue("ListNodes.Data.Nodes["+ i +"].OwnerId");
				nodesItem.ProjectId = _ctx.LongValue("ListNodes.Data.Nodes["+ i +"].ProjectId");
				nodesItem.Repeatability = _ctx.BooleanValue("ListNodes.Data.Nodes["+ i +"].Repeatability");
				nodesItem.ParamValues = _ctx.StringValue("ListNodes.Data.Nodes["+ i +"].ParamValues");
				nodesItem.Description = _ctx.StringValue("ListNodes.Data.Nodes["+ i +"].Description");
				nodesItem.ResGroupName = _ctx.StringValue("ListNodes.Data.Nodes["+ i +"].ResGroupName");
				nodesItem.Priority = _ctx.IntegerValue("ListNodes.Data.Nodes["+ i +"].Priority");
				nodesItem.BaselineId = _ctx.LongValue("ListNodes.Data.Nodes["+ i +"].BaselineId");
				nodesItem.RepeatInterval = _ctx.LongValue("ListNodes.Data.Nodes["+ i +"].RepeatInterval");
				nodesItem.Connection = _ctx.StringValue("ListNodes.Data.Nodes["+ i +"].Connection");
				nodesItem.DqcType = _ctx.IntegerValue("ListNodes.Data.Nodes["+ i +"].DqcType");
				nodesItem.DqcDescription = _ctx.StringValue("ListNodes.Data.Nodes["+ i +"].DqcDescription");
				nodesItem.RelatedFlowId = _ctx.LongValue("ListNodes.Data.Nodes["+ i +"].RelatedFlowId");

				data_nodes.Add(nodesItem);
			}
			data.Nodes = data_nodes;
			listNodesResponse.Data = data;
        
			return listNodesResponse;
        }
    }
}
