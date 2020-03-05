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
        public static ListNodesByQueueResponse Unmarshall(UnmarshallerContext context)
        {
			ListNodesByQueueResponse listNodesByQueueResponse = new ListNodesByQueueResponse();

			listNodesByQueueResponse.HttpResponse = context.HttpResponse;
			listNodesByQueueResponse.RequestId = context.StringValue("ListNodesByQueue.RequestId");
			listNodesByQueueResponse.TotalCount = context.IntegerValue("ListNodesByQueue.TotalCount");
			listNodesByQueueResponse.PageNumber = context.IntegerValue("ListNodesByQueue.PageNumber");
			listNodesByQueueResponse.PageSize = context.IntegerValue("ListNodesByQueue.PageSize");

			List<ListNodesByQueueResponse.ListNodesByQueue_NodeInfo> listNodesByQueueResponse_nodes = new List<ListNodesByQueueResponse.ListNodesByQueue_NodeInfo>();
			for (int i = 0; i < context.Length("ListNodesByQueue.Nodes.Length"); i++) {
				ListNodesByQueueResponse.ListNodesByQueue_NodeInfo nodeInfo = new ListNodesByQueueResponse.ListNodesByQueue_NodeInfo();
				nodeInfo.Id = context.StringValue("ListNodesByQueue.Nodes["+ i +"].Id");
				nodeInfo.RegionId = context.StringValue("ListNodesByQueue.Nodes["+ i +"].RegionId");
				nodeInfo.HostName = context.StringValue("ListNodesByQueue.Nodes["+ i +"].HostName");
				nodeInfo.Status = context.StringValue("ListNodesByQueue.Nodes["+ i +"].Status");
				nodeInfo.Version = context.StringValue("ListNodesByQueue.Nodes["+ i +"].Version");
				nodeInfo.CreatedByEhpc = context.BooleanValue("ListNodesByQueue.Nodes["+ i +"].CreatedByEhpc");
				nodeInfo.AddTime = context.StringValue("ListNodesByQueue.Nodes["+ i +"].AddTime");
				nodeInfo.Expired = context.BooleanValue("ListNodesByQueue.Nodes["+ i +"].Expired");
				nodeInfo.ExpiredTime = context.StringValue("ListNodesByQueue.Nodes["+ i +"].ExpiredTime");
				nodeInfo.SpotStrategy = context.StringValue("ListNodesByQueue.Nodes["+ i +"].SpotStrategy");
				nodeInfo.LockReason = context.StringValue("ListNodesByQueue.Nodes["+ i +"].LockReason");
				nodeInfo.ImageOwnerAlias = context.StringValue("ListNodesByQueue.Nodes["+ i +"].ImageOwnerAlias");
				nodeInfo.ImageId = context.StringValue("ListNodesByQueue.Nodes["+ i +"].ImageId");
				nodeInfo.Location = context.StringValue("ListNodesByQueue.Nodes["+ i +"].Location");
				nodeInfo.CreateMode = context.StringValue("ListNodesByQueue.Nodes["+ i +"].CreateMode");
				nodeInfo.VpcId = context.StringValue("ListNodesByQueue.Nodes["+ i +"].VpcId");
				nodeInfo.ZoneId = context.StringValue("ListNodesByQueue.Nodes["+ i +"].ZoneId");
				nodeInfo.VSwitchId = context.StringValue("ListNodesByQueue.Nodes["+ i +"].VSwitchId");
				nodeInfo.HtEnabled = context.BooleanValue("ListNodesByQueue.Nodes["+ i +"].HtEnabled");

				ListNodesByQueueResponse.ListNodesByQueue_NodeInfo.ListNodesByQueue_TotalResources totalResources = new ListNodesByQueueResponse.ListNodesByQueue_NodeInfo.ListNodesByQueue_TotalResources();
				totalResources.Cpu = context.IntegerValue("ListNodesByQueue.Nodes["+ i +"].TotalResources.Cpu");
				totalResources.Memory = context.IntegerValue("ListNodesByQueue.Nodes["+ i +"].TotalResources.Memory");
				totalResources.Gpu = context.IntegerValue("ListNodesByQueue.Nodes["+ i +"].TotalResources.Gpu");
				nodeInfo.TotalResources = totalResources;

				ListNodesByQueueResponse.ListNodesByQueue_NodeInfo.ListNodesByQueue_UsedResources usedResources = new ListNodesByQueueResponse.ListNodesByQueue_NodeInfo.ListNodesByQueue_UsedResources();
				usedResources.Cpu = context.IntegerValue("ListNodesByQueue.Nodes["+ i +"].UsedResources.Cpu");
				usedResources.Memory = context.IntegerValue("ListNodesByQueue.Nodes["+ i +"].UsedResources.Memory");
				usedResources.Gpu = context.IntegerValue("ListNodesByQueue.Nodes["+ i +"].UsedResources.Gpu");
				nodeInfo.UsedResources = usedResources;

				listNodesByQueueResponse_nodes.Add(nodeInfo);
			}
			listNodesByQueueResponse.Nodes = listNodesByQueueResponse_nodes;
        
			return listNodesByQueueResponse;
        }
    }
}
