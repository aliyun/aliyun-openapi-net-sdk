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
using Aliyun.Acs.EHPC.Model.V20180412;

namespace Aliyun.Acs.EHPC.Transform.V20180412
{
    public class ListNodesByQueueResponseUnmarshaller
    {
        public static ListNodesByQueueResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListNodesByQueueResponse listNodesByQueueResponse = new ListNodesByQueueResponse();

			listNodesByQueueResponse.HttpResponse = _ctx.HttpResponse;
			listNodesByQueueResponse.RequestId = _ctx.StringValue("ListNodesByQueue.RequestId");
			listNodesByQueueResponse.TotalCount = _ctx.IntegerValue("ListNodesByQueue.TotalCount");
			listNodesByQueueResponse.PageNumber = _ctx.IntegerValue("ListNodesByQueue.PageNumber");
			listNodesByQueueResponse.PageSize = _ctx.IntegerValue("ListNodesByQueue.PageSize");

			List<ListNodesByQueueResponse.ListNodesByQueue_NodeInfo> listNodesByQueueResponse_nodes = new List<ListNodesByQueueResponse.ListNodesByQueue_NodeInfo>();
			for (int i = 0; i < _ctx.Length("ListNodesByQueue.Nodes.Length"); i++) {
				ListNodesByQueueResponse.ListNodesByQueue_NodeInfo nodeInfo = new ListNodesByQueueResponse.ListNodesByQueue_NodeInfo();
				nodeInfo.Id = _ctx.StringValue("ListNodesByQueue.Nodes["+ i +"].Id");
				nodeInfo.RegionId = _ctx.StringValue("ListNodesByQueue.Nodes["+ i +"].RegionId");
				nodeInfo.HostName = _ctx.StringValue("ListNodesByQueue.Nodes["+ i +"].HostName");
				nodeInfo.Status = _ctx.StringValue("ListNodesByQueue.Nodes["+ i +"].Status");
				nodeInfo.Version = _ctx.StringValue("ListNodesByQueue.Nodes["+ i +"].Version");
				nodeInfo.CreatedByEhpc = _ctx.BooleanValue("ListNodesByQueue.Nodes["+ i +"].CreatedByEhpc");
				nodeInfo.AddTime = _ctx.StringValue("ListNodesByQueue.Nodes["+ i +"].AddTime");
				nodeInfo.Expired = _ctx.BooleanValue("ListNodesByQueue.Nodes["+ i +"].Expired");
				nodeInfo.ExpiredTime = _ctx.StringValue("ListNodesByQueue.Nodes["+ i +"].ExpiredTime");
				nodeInfo.SpotStrategy = _ctx.StringValue("ListNodesByQueue.Nodes["+ i +"].SpotStrategy");
				nodeInfo.LockReason = _ctx.StringValue("ListNodesByQueue.Nodes["+ i +"].LockReason");
				nodeInfo.ImageOwnerAlias = _ctx.StringValue("ListNodesByQueue.Nodes["+ i +"].ImageOwnerAlias");
				nodeInfo.ImageId = _ctx.StringValue("ListNodesByQueue.Nodes["+ i +"].ImageId");
				nodeInfo.Location = _ctx.StringValue("ListNodesByQueue.Nodes["+ i +"].Location");
				nodeInfo.CreateMode = _ctx.StringValue("ListNodesByQueue.Nodes["+ i +"].CreateMode");
				nodeInfo.VpcId = _ctx.StringValue("ListNodesByQueue.Nodes["+ i +"].VpcId");
				nodeInfo.ZoneId = _ctx.StringValue("ListNodesByQueue.Nodes["+ i +"].ZoneId");
				nodeInfo.VSwitchId = _ctx.StringValue("ListNodesByQueue.Nodes["+ i +"].VSwitchId");
				nodeInfo.HtEnabled = _ctx.BooleanValue("ListNodesByQueue.Nodes["+ i +"].HtEnabled");
				nodeInfo.IpAddress = _ctx.StringValue("ListNodesByQueue.Nodes["+ i +"].IpAddress");
				nodeInfo.PublicIpAddress = _ctx.StringValue("ListNodesByQueue.Nodes["+ i +"].PublicIpAddress");

				ListNodesByQueueResponse.ListNodesByQueue_NodeInfo.ListNodesByQueue_TotalResources totalResources = new ListNodesByQueueResponse.ListNodesByQueue_NodeInfo.ListNodesByQueue_TotalResources();
				totalResources.Cpu = _ctx.IntegerValue("ListNodesByQueue.Nodes["+ i +"].TotalResources.Cpu");
				totalResources.Memory = _ctx.IntegerValue("ListNodesByQueue.Nodes["+ i +"].TotalResources.Memory");
				totalResources.Gpu = _ctx.IntegerValue("ListNodesByQueue.Nodes["+ i +"].TotalResources.Gpu");
				nodeInfo.TotalResources = totalResources;

				ListNodesByQueueResponse.ListNodesByQueue_NodeInfo.ListNodesByQueue_UsedResources usedResources = new ListNodesByQueueResponse.ListNodesByQueue_NodeInfo.ListNodesByQueue_UsedResources();
				usedResources.Cpu = _ctx.IntegerValue("ListNodesByQueue.Nodes["+ i +"].UsedResources.Cpu");
				usedResources.Memory = _ctx.IntegerValue("ListNodesByQueue.Nodes["+ i +"].UsedResources.Memory");
				usedResources.Gpu = _ctx.IntegerValue("ListNodesByQueue.Nodes["+ i +"].UsedResources.Gpu");
				nodeInfo.UsedResources = usedResources;

				listNodesByQueueResponse_nodes.Add(nodeInfo);
			}
			listNodesByQueueResponse.Nodes = listNodesByQueueResponse_nodes;
        
			return listNodesByQueueResponse;
        }
    }
}
