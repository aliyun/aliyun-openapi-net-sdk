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
        public static ListNodesResponse Unmarshall(UnmarshallerContext context)
        {
			ListNodesResponse listNodesResponse = new ListNodesResponse();

			listNodesResponse.HttpResponse = context.HttpResponse;
			listNodesResponse.Success = context.BooleanValue("ListNodes.Success");
			listNodesResponse.HttpStatusCode = context.IntegerValue("ListNodes.HttpStatusCode");
			listNodesResponse.ErrorCode = context.StringValue("ListNodes.ErrorCode");
			listNodesResponse.ErrorMessage = context.StringValue("ListNodes.ErrorMessage");
			listNodesResponse.RequestId = context.StringValue("ListNodes.RequestId");

			ListNodesResponse.ListNodes_Data data = new ListNodesResponse.ListNodes_Data();
			data.PageNumber = context.IntegerValue("ListNodes.Data.PageNumber");
			data.PageSize = context.IntegerValue("ListNodes.Data.PageSize");
			data.TotalCount = context.IntegerValue("ListNodes.Data.TotalCount");

			List<ListNodesResponse.ListNodes_Data.ListNodes_NodesItem> data_nodes = new List<ListNodesResponse.ListNodes_Data.ListNodes_NodesItem>();
			for (int i = 0; i < context.Length("ListNodes.Data.Nodes.Length"); i++) {
				ListNodesResponse.ListNodes_Data.ListNodes_NodesItem nodesItem = new ListNodesResponse.ListNodes_Data.ListNodes_NodesItem();
				nodesItem.NodeId = context.LongValue("ListNodes.Data.Nodes["+ i +"].NodeId");
				nodesItem.NodeName = context.StringValue("ListNodes.Data.Nodes["+ i +"].NodeName");
				nodesItem.CronExpress = context.StringValue("ListNodes.Data.Nodes["+ i +"].CronExpress");
				nodesItem.SchedulerType = context.StringValue("ListNodes.Data.Nodes["+ i +"].SchedulerType");
				nodesItem.ProgramType = context.StringValue("ListNodes.Data.Nodes["+ i +"].ProgramType");
				nodesItem.OwnerId = context.StringValue("ListNodes.Data.Nodes["+ i +"].OwnerId");
				nodesItem.ProjectId = context.LongValue("ListNodes.Data.Nodes["+ i +"].ProjectId");
				nodesItem.Repeatability = context.BooleanValue("ListNodes.Data.Nodes["+ i +"].Repeatability");
				nodesItem.ParamValues = context.StringValue("ListNodes.Data.Nodes["+ i +"].ParamValues");
				nodesItem.Description = context.StringValue("ListNodes.Data.Nodes["+ i +"].Description");
				nodesItem.ResGroupName = context.StringValue("ListNodes.Data.Nodes["+ i +"].ResGroupName");

				data_nodes.Add(nodesItem);
			}
			data.Nodes = data_nodes;
			listNodesResponse.Data = data;
        
			return listNodesResponse;
        }
    }
}
