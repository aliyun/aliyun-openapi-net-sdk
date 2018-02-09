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
using Aliyun.Acs.EHPC.Model.V20170714;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.EHPC.Transform.V20170714
{
    public class ListNodesNoPagingResponseUnmarshaller
    {
        public static ListNodesNoPagingResponse Unmarshall(UnmarshallerContext context)
        {
			ListNodesNoPagingResponse listNodesNoPagingResponse = new ListNodesNoPagingResponse();

			listNodesNoPagingResponse.HttpResponse = context.HttpResponse;
			listNodesNoPagingResponse.RequestId = context.StringValue("ListNodesNoPaging.RequestId");
			listNodesNoPagingResponse.TotalCount = context.IntegerValue("ListNodesNoPaging.TotalCount");
			listNodesNoPagingResponse.PageNumber = context.IntegerValue("ListNodesNoPaging.PageNumber");
			listNodesNoPagingResponse.PageSize = context.IntegerValue("ListNodesNoPaging.PageSize");

			List<ListNodesNoPagingResponse.ListNodesNoPaging_NodeInfo> listNodesNoPagingResponse_nodes = new List<ListNodesNoPagingResponse.ListNodesNoPaging_NodeInfo>();
			for (int i = 0; i < context.Length("ListNodesNoPaging.Nodes.Length"); i++) {
				ListNodesNoPagingResponse.ListNodesNoPaging_NodeInfo nodeInfo = new ListNodesNoPagingResponse.ListNodesNoPaging_NodeInfo();
				nodeInfo.Id = context.StringValue("ListNodesNoPaging.Nodes["+ i +"].Id");
				nodeInfo.RegionId = context.StringValue("ListNodesNoPaging.Nodes["+ i +"].RegionId");
				nodeInfo.Status = context.StringValue("ListNodesNoPaging.Nodes["+ i +"].Status");
				nodeInfo.CreatedByEhpc = context.BooleanValue("ListNodesNoPaging.Nodes["+ i +"].CreatedByEhpc");
				nodeInfo.Role = context.StringValue("ListNodesNoPaging.Nodes["+ i +"].Role");
				nodeInfo.AddTime = context.StringValue("ListNodesNoPaging.Nodes["+ i +"].AddTime");
				nodeInfo.Expired = context.BooleanValue("ListNodesNoPaging.Nodes["+ i +"].Expired");
				nodeInfo.ExpiredTime = context.StringValue("ListNodesNoPaging.Nodes["+ i +"].ExpiredTime");
				nodeInfo.SpotStrategy = context.StringValue("ListNodesNoPaging.Nodes["+ i +"].SpotStrategy");
				nodeInfo.LockReason = context.StringValue("ListNodesNoPaging.Nodes["+ i +"].LockReason");
				nodeInfo.ImageOwnerAlias = context.StringValue("ListNodesNoPaging.Nodes["+ i +"].ImageOwnerAlias");
				nodeInfo.ImageId = context.StringValue("ListNodesNoPaging.Nodes["+ i +"].ImageId");

				ListNodesNoPagingResponse.ListNodesNoPaging_NodeInfo.ListNodesNoPaging_TotalResources totalResources = new ListNodesNoPagingResponse.ListNodesNoPaging_NodeInfo.ListNodesNoPaging_TotalResources();
				totalResources.Cpu = context.IntegerValue("ListNodesNoPaging.Nodes["+ i +"].TotalResources.Cpu");
				totalResources.Memory = context.IntegerValue("ListNodesNoPaging.Nodes["+ i +"].TotalResources.Memory");
				totalResources.Gpu = context.IntegerValue("ListNodesNoPaging.Nodes["+ i +"].TotalResources.Gpu");
				nodeInfo.TotalResources = totalResources;

				ListNodesNoPagingResponse.ListNodesNoPaging_NodeInfo.ListNodesNoPaging_UsedResources usedResources = new ListNodesNoPagingResponse.ListNodesNoPaging_NodeInfo.ListNodesNoPaging_UsedResources();
				usedResources.Cpu = context.IntegerValue("ListNodesNoPaging.Nodes["+ i +"].UsedResources.Cpu");
				usedResources.Memory = context.IntegerValue("ListNodesNoPaging.Nodes["+ i +"].UsedResources.Memory");
				usedResources.Gpu = context.IntegerValue("ListNodesNoPaging.Nodes["+ i +"].UsedResources.Gpu");
				nodeInfo.UsedResources = usedResources;

				listNodesNoPagingResponse_nodes.Add(nodeInfo);
			}
			listNodesNoPagingResponse.Nodes = listNodesNoPagingResponse_nodes;
        
			return listNodesNoPagingResponse;
        }
    }
}