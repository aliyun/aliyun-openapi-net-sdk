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
    public class ListNodesResponseUnmarshaller
    {
        public static ListNodesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListNodesResponse listNodesResponse = new ListNodesResponse();

			listNodesResponse.HttpResponse = _ctx.HttpResponse;
			listNodesResponse.RequestId = _ctx.StringValue("ListNodes.RequestId");
			listNodesResponse.TotalCount = _ctx.IntegerValue("ListNodes.TotalCount");
			listNodesResponse.PageNumber = _ctx.IntegerValue("ListNodes.PageNumber");
			listNodesResponse.PageSize = _ctx.IntegerValue("ListNodes.PageSize");

			List<ListNodesResponse.ListNodes_NodeInfo> listNodesResponse_nodes = new List<ListNodesResponse.ListNodes_NodeInfo>();
			for (int i = 0; i < _ctx.Length("ListNodes.Nodes.Length"); i++) {
				ListNodesResponse.ListNodes_NodeInfo nodeInfo = new ListNodesResponse.ListNodes_NodeInfo();
				nodeInfo.Id = _ctx.StringValue("ListNodes.Nodes["+ i +"].Id");
				nodeInfo.RegionId = _ctx.StringValue("ListNodes.Nodes["+ i +"].RegionId");
				nodeInfo.HostName = _ctx.StringValue("ListNodes.Nodes["+ i +"].HostName");
				nodeInfo.IpAddress = _ctx.StringValue("ListNodes.Nodes["+ i +"].IpAddress");
				nodeInfo.Status = _ctx.StringValue("ListNodes.Nodes["+ i +"].Status");
				nodeInfo.Version = _ctx.StringValue("ListNodes.Nodes["+ i +"].Version");
				nodeInfo.CreatedByEhpc = _ctx.BooleanValue("ListNodes.Nodes["+ i +"].CreatedByEhpc");
				nodeInfo.AddTime = _ctx.StringValue("ListNodes.Nodes["+ i +"].AddTime");
				nodeInfo.Expired = _ctx.BooleanValue("ListNodes.Nodes["+ i +"].Expired");
				nodeInfo.ExpiredTime = _ctx.StringValue("ListNodes.Nodes["+ i +"].ExpiredTime");
				nodeInfo.SpotStrategy = _ctx.StringValue("ListNodes.Nodes["+ i +"].SpotStrategy");
				nodeInfo.LockReason = _ctx.StringValue("ListNodes.Nodes["+ i +"].LockReason");
				nodeInfo.ImageOwnerAlias = _ctx.StringValue("ListNodes.Nodes["+ i +"].ImageOwnerAlias");
				nodeInfo.ImageId = _ctx.StringValue("ListNodes.Nodes["+ i +"].ImageId");
				nodeInfo.Location = _ctx.StringValue("ListNodes.Nodes["+ i +"].Location");
				nodeInfo.CreateMode = _ctx.StringValue("ListNodes.Nodes["+ i +"].CreateMode");
				nodeInfo.VpcId = _ctx.StringValue("ListNodes.Nodes["+ i +"].VpcId");
				nodeInfo.ZoneId = _ctx.StringValue("ListNodes.Nodes["+ i +"].ZoneId");
				nodeInfo.VSwitchId = _ctx.StringValue("ListNodes.Nodes["+ i +"].VSwitchId");
				nodeInfo.HtEnabled = _ctx.BooleanValue("ListNodes.Nodes["+ i +"].HtEnabled");
				nodeInfo.PublicIpAddress = _ctx.StringValue("ListNodes.Nodes["+ i +"].PublicIpAddress");
				nodeInfo.InstanceType = _ctx.StringValue("ListNodes.Nodes["+ i +"].InstanceType");

				List<string> nodeInfo_roles = new List<string>();
				for (int j = 0; j < _ctx.Length("ListNodes.Nodes["+ i +"].Roles.Length"); j++) {
					nodeInfo_roles.Add(_ctx.StringValue("ListNodes.Nodes["+ i +"].Roles["+ j +"]"));
				}
				nodeInfo.Roles = nodeInfo_roles;

				ListNodesResponse.ListNodes_NodeInfo.ListNodes_TotalResources totalResources = new ListNodesResponse.ListNodes_NodeInfo.ListNodes_TotalResources();
				totalResources.Cpu = _ctx.IntegerValue("ListNodes.Nodes["+ i +"].TotalResources.Cpu");
				totalResources.Memory = _ctx.IntegerValue("ListNodes.Nodes["+ i +"].TotalResources.Memory");
				totalResources.Gpu = _ctx.IntegerValue("ListNodes.Nodes["+ i +"].TotalResources.Gpu");
				nodeInfo.TotalResources = totalResources;

				ListNodesResponse.ListNodes_NodeInfo.ListNodes_UsedResources usedResources = new ListNodesResponse.ListNodes_NodeInfo.ListNodes_UsedResources();
				usedResources.Cpu = _ctx.IntegerValue("ListNodes.Nodes["+ i +"].UsedResources.Cpu");
				usedResources.Memory = _ctx.IntegerValue("ListNodes.Nodes["+ i +"].UsedResources.Memory");
				usedResources.Gpu = _ctx.IntegerValue("ListNodes.Nodes["+ i +"].UsedResources.Gpu");
				nodeInfo.UsedResources = usedResources;

				listNodesResponse_nodes.Add(nodeInfo);
			}
			listNodesResponse.Nodes = listNodesResponse_nodes;
        
			return listNodesResponse;
        }
    }
}
