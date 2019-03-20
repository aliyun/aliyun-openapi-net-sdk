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
using Aliyun.Acs.Cms.Model.V20180308;

namespace Aliyun.Acs.Cms.Transform.V20180308
{
    public class NodeStatusListResponseUnmarshaller
    {
        public static NodeStatusListResponse Unmarshall(UnmarshallerContext context)
        {
			NodeStatusListResponse nodeStatusListResponse = new NodeStatusListResponse();

			nodeStatusListResponse.HttpResponse = context.HttpResponse;
			nodeStatusListResponse.ErrorCode = context.IntegerValue("NodeStatusList.ErrorCode");
			nodeStatusListResponse.ErrorMessage = context.StringValue("NodeStatusList.ErrorMessage");
			nodeStatusListResponse.Success = context.BooleanValue("NodeStatusList.Success");
			nodeStatusListResponse.RequestId = context.StringValue("NodeStatusList.RequestId");

			List<NodeStatusListResponse.NodeStatusList_NodeStatus> nodeStatusListResponse_nodeStatusList = new List<NodeStatusListResponse.NodeStatusList_NodeStatus>();
			for (int i = 0; i < context.Length("NodeStatusList.NodeStatusList.Length"); i++) {
				NodeStatusListResponse.NodeStatusList_NodeStatus nodeStatus = new NodeStatusListResponse.NodeStatusList_NodeStatus();
				nodeStatus.InstanceId = context.StringValue("NodeStatusList.NodeStatusList["+ i +"].InstanceId");
				nodeStatus.AutoInstall = context.BooleanValue("NodeStatusList.NodeStatusList["+ i +"].AutoInstall");
				nodeStatus.Status = context.StringValue("NodeStatusList.NodeStatusList["+ i +"].Status");

				nodeStatusListResponse_nodeStatusList.Add(nodeStatus);
			}
			nodeStatusListResponse.NodeStatusList = nodeStatusListResponse_nodeStatusList;
        
			return nodeStatusListResponse;
        }
    }
}
