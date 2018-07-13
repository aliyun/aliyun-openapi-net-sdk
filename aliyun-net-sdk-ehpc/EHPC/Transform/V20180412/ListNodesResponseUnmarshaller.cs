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
using Aliyun.Acs.EHPC.Model.V20180412;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.EHPC.Transform.V20180412
{
    public class ListNodesResponseUnmarshaller
    {
        public static ListNodesResponse Unmarshall(UnmarshallerContext context)
        {
			ListNodesResponse listNodesResponse = new ListNodesResponse();

			listNodesResponse.HttpResponse = context.HttpResponse;
			listNodesResponse.RequestId = context.StringValue("ListNodes.RequestId");
			listNodesResponse.TotalCount = context.IntegerValue("ListNodes.TotalCount");
			listNodesResponse.PageNumber = context.IntegerValue("ListNodes.PageNumber");
			listNodesResponse.PageSize = context.IntegerValue("ListNodes.PageSize");

			List<ListNodesResponse.ListNodes_NodeInfo> listNodesResponse_nodes = new List<ListNodesResponse.ListNodes_NodeInfo>();
			for (int i = 0; i < context.Length("ListNodes.Nodes.Length"); i++) {
				ListNodesResponse.ListNodes_NodeInfo nodeInfo = new ListNodesResponse.ListNodes_NodeInfo();
				nodeInfo.Id = context.StringValue("ListNodes.Nodes["+ i +"].Id");
				nodeInfo.RegionId = context.StringValue("ListNodes.Nodes["+ i +"].RegionId");
				nodeInfo.Status = context.StringValue("ListNodes.Nodes["+ i +"].Status");
				nodeInfo.CreatedByEhpc = context.BooleanValue("ListNodes.Nodes["+ i +"].CreatedByEhpc");
				nodeInfo.AddTime = context.StringValue("ListNodes.Nodes["+ i +"].AddTime");
				nodeInfo.Expired = context.BooleanValue("ListNodes.Nodes["+ i +"].Expired");
				nodeInfo.ExpiredTime = context.StringValue("ListNodes.Nodes["+ i +"].ExpiredTime");
				nodeInfo.SpotStrategy = context.StringValue("ListNodes.Nodes["+ i +"].SpotStrategy");
				nodeInfo.LockReason = context.StringValue("ListNodes.Nodes["+ i +"].LockReason");
				nodeInfo.ImageOwnerAlias = context.StringValue("ListNodes.Nodes["+ i +"].ImageOwnerAlias");
				nodeInfo.ImageId = context.StringValue("ListNodes.Nodes["+ i +"].ImageId");
				nodeInfo.Location = context.StringValue("ListNodes.Nodes["+ i +"].Location");

				List<string> nodeInfo_roles = new List<string>();
				for (int j = 0; j < context.Length("ListNodes.Nodes["+ i +"].Roles.Length"); j++) {
					nodeInfo_roles.Add(context.StringValue("ListNodes.Nodes["+ i +"].Roles["+ j +"]"));
				}
				nodeInfo.Roles = nodeInfo_roles;

				ListNodesResponse.ListNodes_NodeInfo.ListNodes_TotalResources totalResources = new ListNodesResponse.ListNodes_NodeInfo.ListNodes_TotalResources();
				totalResources.Cpu = context.IntegerValue("ListNodes.Nodes["+ i +"].TotalResources.Cpu");
				totalResources.Memory = context.IntegerValue("ListNodes.Nodes["+ i +"].TotalResources.Memory");
				totalResources.Gpu = context.IntegerValue("ListNodes.Nodes["+ i +"].TotalResources.Gpu");
				nodeInfo.TotalResources = totalResources;

				ListNodesResponse.ListNodes_NodeInfo.ListNodes_UsedResources usedResources = new ListNodesResponse.ListNodes_NodeInfo.ListNodes_UsedResources();
				usedResources.Cpu = context.IntegerValue("ListNodes.Nodes["+ i +"].UsedResources.Cpu");
				usedResources.Memory = context.IntegerValue("ListNodes.Nodes["+ i +"].UsedResources.Memory");
				usedResources.Gpu = context.IntegerValue("ListNodes.Nodes["+ i +"].UsedResources.Gpu");
				nodeInfo.UsedResources = usedResources;

				listNodesResponse_nodes.Add(nodeInfo);
			}
			listNodesResponse.Nodes = listNodesResponse_nodes;
        
			return listNodesResponse;
        }
    }
}