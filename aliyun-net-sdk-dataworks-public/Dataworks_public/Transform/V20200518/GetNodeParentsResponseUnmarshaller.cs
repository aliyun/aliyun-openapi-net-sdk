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
    public class GetNodeParentsResponseUnmarshaller
    {
        public static GetNodeParentsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetNodeParentsResponse getNodeParentsResponse = new GetNodeParentsResponse();

			getNodeParentsResponse.HttpResponse = _ctx.HttpResponse;
			getNodeParentsResponse.Success = _ctx.BooleanValue("GetNodeParents.Success");
			getNodeParentsResponse.HttpStatusCode = _ctx.IntegerValue("GetNodeParents.HttpStatusCode");
			getNodeParentsResponse.ErrorCode = _ctx.StringValue("GetNodeParents.ErrorCode");
			getNodeParentsResponse.ErrorMessage = _ctx.StringValue("GetNodeParents.ErrorMessage");
			getNodeParentsResponse.RequestId = _ctx.StringValue("GetNodeParents.RequestId");

			GetNodeParentsResponse.GetNodeParents_Data data = new GetNodeParentsResponse.GetNodeParents_Data();

			List<GetNodeParentsResponse.GetNodeParents_Data.GetNodeParents_NodesItem> data_nodes = new List<GetNodeParentsResponse.GetNodeParents_Data.GetNodeParents_NodesItem>();
			for (int i = 0; i < _ctx.Length("GetNodeParents.Data.Nodes.Length"); i++) {
				GetNodeParentsResponse.GetNodeParents_Data.GetNodeParents_NodesItem nodesItem = new GetNodeParentsResponse.GetNodeParents_Data.GetNodeParents_NodesItem();
				nodesItem.NodeId = _ctx.LongValue("GetNodeParents.Data.Nodes["+ i +"].NodeId");
				nodesItem.NodeName = _ctx.StringValue("GetNodeParents.Data.Nodes["+ i +"].NodeName");
				nodesItem.CronExpress = _ctx.StringValue("GetNodeParents.Data.Nodes["+ i +"].CronExpress");
				nodesItem.SchedulerType = _ctx.StringValue("GetNodeParents.Data.Nodes["+ i +"].SchedulerType");
				nodesItem.ProgramType = _ctx.StringValue("GetNodeParents.Data.Nodes["+ i +"].ProgramType");
				nodesItem.OwnerId = _ctx.StringValue("GetNodeParents.Data.Nodes["+ i +"].OwnerId");
				nodesItem.ProjectId = _ctx.LongValue("GetNodeParents.Data.Nodes["+ i +"].ProjectId");
				nodesItem.Repeatability = _ctx.BooleanValue("GetNodeParents.Data.Nodes["+ i +"].Repeatability");
				nodesItem.Priority = _ctx.IntegerValue("GetNodeParents.Data.Nodes["+ i +"].Priority");
				nodesItem.BaselineId = _ctx.LongValue("GetNodeParents.Data.Nodes["+ i +"].BaselineId");

				data_nodes.Add(nodesItem);
			}
			data.Nodes = data_nodes;
			getNodeParentsResponse.Data = data;
        
			return getNodeParentsResponse;
        }
    }
}
