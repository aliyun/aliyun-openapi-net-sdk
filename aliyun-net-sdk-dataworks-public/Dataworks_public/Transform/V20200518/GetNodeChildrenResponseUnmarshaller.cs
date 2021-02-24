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
    public class GetNodeChildrenResponseUnmarshaller
    {
        public static GetNodeChildrenResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetNodeChildrenResponse getNodeChildrenResponse = new GetNodeChildrenResponse();

			getNodeChildrenResponse.HttpResponse = _ctx.HttpResponse;
			getNodeChildrenResponse.Success = _ctx.BooleanValue("GetNodeChildren.Success");
			getNodeChildrenResponse.HttpStatusCode = _ctx.IntegerValue("GetNodeChildren.HttpStatusCode");
			getNodeChildrenResponse.ErrorCode = _ctx.StringValue("GetNodeChildren.ErrorCode");
			getNodeChildrenResponse.ErrorMessage = _ctx.StringValue("GetNodeChildren.ErrorMessage");
			getNodeChildrenResponse.RequestId = _ctx.StringValue("GetNodeChildren.RequestId");

			GetNodeChildrenResponse.GetNodeChildren_Data data = new GetNodeChildrenResponse.GetNodeChildren_Data();

			List<GetNodeChildrenResponse.GetNodeChildren_Data.GetNodeChildren_NodesItem> data_nodes = new List<GetNodeChildrenResponse.GetNodeChildren_Data.GetNodeChildren_NodesItem>();
			for (int i = 0; i < _ctx.Length("GetNodeChildren.Data.Nodes.Length"); i++) {
				GetNodeChildrenResponse.GetNodeChildren_Data.GetNodeChildren_NodesItem nodesItem = new GetNodeChildrenResponse.GetNodeChildren_Data.GetNodeChildren_NodesItem();
				nodesItem.NodeId = _ctx.LongValue("GetNodeChildren.Data.Nodes["+ i +"].NodeId");
				nodesItem.NodeName = _ctx.StringValue("GetNodeChildren.Data.Nodes["+ i +"].NodeName");
				nodesItem.CronExpress = _ctx.StringValue("GetNodeChildren.Data.Nodes["+ i +"].CronExpress");
				nodesItem.SchedulerType = _ctx.StringValue("GetNodeChildren.Data.Nodes["+ i +"].SchedulerType");
				nodesItem.ProgramType = _ctx.StringValue("GetNodeChildren.Data.Nodes["+ i +"].ProgramType");
				nodesItem.OwnerId = _ctx.StringValue("GetNodeChildren.Data.Nodes["+ i +"].OwnerId");
				nodesItem.ProjectId = _ctx.LongValue("GetNodeChildren.Data.Nodes["+ i +"].ProjectId");
				nodesItem.Repeatability = _ctx.BooleanValue("GetNodeChildren.Data.Nodes["+ i +"].Repeatability");
				nodesItem.Priority = _ctx.IntegerValue("GetNodeChildren.Data.Nodes["+ i +"].Priority");
				nodesItem.BaselineId = _ctx.LongValue("GetNodeChildren.Data.Nodes["+ i +"].BaselineId");

				data_nodes.Add(nodesItem);
			}
			data.Nodes = data_nodes;
			getNodeChildrenResponse.Data = data;
        
			return getNodeChildrenResponse;
        }
    }
}
