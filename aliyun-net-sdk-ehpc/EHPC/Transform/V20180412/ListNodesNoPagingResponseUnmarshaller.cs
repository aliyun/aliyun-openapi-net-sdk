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
    public class ListNodesNoPagingResponseUnmarshaller
    {
        public static ListNodesNoPagingResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListNodesNoPagingResponse listNodesNoPagingResponse = new ListNodesNoPagingResponse();

			listNodesNoPagingResponse.HttpResponse = _ctx.HttpResponse;
			listNodesNoPagingResponse.RequestId = _ctx.StringValue("ListNodesNoPaging.RequestId");
			listNodesNoPagingResponse.TotalCount = _ctx.IntegerValue("ListNodesNoPaging.TotalCount");
			listNodesNoPagingResponse.PageNumber = _ctx.IntegerValue("ListNodesNoPaging.PageNumber");
			listNodesNoPagingResponse.PageSize = _ctx.IntegerValue("ListNodesNoPaging.PageSize");

			List<ListNodesNoPagingResponse.ListNodesNoPaging_NodeInfo> listNodesNoPagingResponse_nodes = new List<ListNodesNoPagingResponse.ListNodesNoPaging_NodeInfo>();
			for (int i = 0; i < _ctx.Length("ListNodesNoPaging.Nodes.Length"); i++) {
				ListNodesNoPagingResponse.ListNodesNoPaging_NodeInfo nodeInfo = new ListNodesNoPagingResponse.ListNodesNoPaging_NodeInfo();
				nodeInfo.Id = _ctx.StringValue("ListNodesNoPaging.Nodes["+ i +"].Id");
				nodeInfo.HostName = _ctx.StringValue("ListNodesNoPaging.Nodes["+ i +"].HostName");
				nodeInfo.RegionId = _ctx.StringValue("ListNodesNoPaging.Nodes["+ i +"].RegionId");
				nodeInfo.Status = _ctx.StringValue("ListNodesNoPaging.Nodes["+ i +"].Status");
				nodeInfo.Version = _ctx.StringValue("ListNodesNoPaging.Nodes["+ i +"].Version");
				nodeInfo.CreatedByEhpc = _ctx.BooleanValue("ListNodesNoPaging.Nodes["+ i +"].CreatedByEhpc");
				nodeInfo.AddTime = _ctx.StringValue("ListNodesNoPaging.Nodes["+ i +"].AddTime");
				nodeInfo.Expired = _ctx.BooleanValue("ListNodesNoPaging.Nodes["+ i +"].Expired");
				nodeInfo.ExpiredTime = _ctx.StringValue("ListNodesNoPaging.Nodes["+ i +"].ExpiredTime");
				nodeInfo.SpotStrategy = _ctx.StringValue("ListNodesNoPaging.Nodes["+ i +"].SpotStrategy");
				nodeInfo.LockReason = _ctx.StringValue("ListNodesNoPaging.Nodes["+ i +"].LockReason");
				nodeInfo.ImageOwnerAlias = _ctx.StringValue("ListNodesNoPaging.Nodes["+ i +"].ImageOwnerAlias");
				nodeInfo.ImageId = _ctx.StringValue("ListNodesNoPaging.Nodes["+ i +"].ImageId");
				nodeInfo.HtEnabled = _ctx.BooleanValue("ListNodesNoPaging.Nodes["+ i +"].HtEnabled");
				nodeInfo.InstanceType = _ctx.StringValue("ListNodesNoPaging.Nodes["+ i +"].InstanceType");

				List<string> nodeInfo_roles = new List<string>();
				for (int j = 0; j < _ctx.Length("ListNodesNoPaging.Nodes["+ i +"].Roles.Length"); j++) {
					nodeInfo_roles.Add(_ctx.StringValue("ListNodesNoPaging.Nodes["+ i +"].Roles["+ j +"]"));
				}
				nodeInfo.Roles = nodeInfo_roles;

				ListNodesNoPagingResponse.ListNodesNoPaging_NodeInfo.ListNodesNoPaging_TotalResources totalResources = new ListNodesNoPagingResponse.ListNodesNoPaging_NodeInfo.ListNodesNoPaging_TotalResources();
				totalResources.Cpu = _ctx.IntegerValue("ListNodesNoPaging.Nodes["+ i +"].TotalResources.Cpu");
				totalResources.Memory = _ctx.IntegerValue("ListNodesNoPaging.Nodes["+ i +"].TotalResources.Memory");
				totalResources.Gpu = _ctx.IntegerValue("ListNodesNoPaging.Nodes["+ i +"].TotalResources.Gpu");
				nodeInfo.TotalResources = totalResources;

				ListNodesNoPagingResponse.ListNodesNoPaging_NodeInfo.ListNodesNoPaging_UsedResources usedResources = new ListNodesNoPagingResponse.ListNodesNoPaging_NodeInfo.ListNodesNoPaging_UsedResources();
				usedResources.Cpu = _ctx.IntegerValue("ListNodesNoPaging.Nodes["+ i +"].UsedResources.Cpu");
				usedResources.Memory = _ctx.IntegerValue("ListNodesNoPaging.Nodes["+ i +"].UsedResources.Memory");
				usedResources.Gpu = _ctx.IntegerValue("ListNodesNoPaging.Nodes["+ i +"].UsedResources.Gpu");
				nodeInfo.UsedResources = usedResources;

				listNodesNoPagingResponse_nodes.Add(nodeInfo);
			}
			listNodesNoPagingResponse.Nodes = listNodesNoPagingResponse_nodes;
        
			return listNodesNoPagingResponse;
        }
    }
}
