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
using Aliyun.Acs.Cms.Model.V20180308;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Cms.Transform.V20180308
{
    public class NodeListResponseUnmarshaller
    {
        public static NodeListResponse Unmarshall(UnmarshallerContext context)
        {
			NodeListResponse nodeListResponse = new NodeListResponse();

			nodeListResponse.HttpResponse = context.HttpResponse;
			nodeListResponse.ErrorCode = context.IntegerValue("NodeList.ErrorCode");
			nodeListResponse.ErrorMessage = context.StringValue("NodeList.ErrorMessage");
			nodeListResponse.Success = context.BooleanValue("NodeList.Success");
			nodeListResponse.RequestId = context.StringValue("NodeList.RequestId");
			nodeListResponse.PageNumber = context.IntegerValue("NodeList.PageNumber");
			nodeListResponse.PageSize = context.IntegerValue("NodeList.PageSize");
			nodeListResponse.PageTotal = context.IntegerValue("NodeList.PageTotal");
			nodeListResponse.Total = context.IntegerValue("NodeList.Total");

			List<NodeListResponse.NodeList_Node> nodeListResponse_nodes = new List<NodeListResponse.NodeList_Node>();
			for (int i = 0; i < context.Length("NodeList.Nodes.Length"); i++) {
				NodeListResponse.NodeList_Node node = new NodeListResponse.NodeList_Node();
				node.InstanceId = context.StringValue("NodeList.Nodes["+ i +"].InstanceId");
				node.SerialNumber = context.StringValue("NodeList.Nodes["+ i +"].SerialNumber");
				node.HostName = context.StringValue("NodeList.Nodes["+ i +"].HostName");
				node.AliUid = context.LongValue("NodeList.Nodes["+ i +"].AliUid");
				node.OperatingSystem = context.StringValue("NodeList.Nodes["+ i +"].OperatingSystem");
				node.IpGroup = context.StringValue("NodeList.Nodes["+ i +"].IpGroup");
				node.Region = context.StringValue("NodeList.Nodes["+ i +"].Region");
				node.TianjimonVersion = context.StringValue("NodeList.Nodes["+ i +"].TianjimonVersion");
				node.EipAddress = context.StringValue("NodeList.Nodes["+ i +"].EipAddress");
				node.EipId = context.StringValue("NodeList.Nodes["+ i +"].EipId");
				node.AliyunHost = context.BooleanValue("NodeList.Nodes["+ i +"].AliyunHost");
				node.NatIp = context.StringValue("NodeList.Nodes["+ i +"].NatIp");
				node.NetworkType = context.StringValue("NodeList.Nodes["+ i +"].NetworkType");
				node.InstanceTypeFamily = context.StringValue("NodeList.Nodes["+ i +"].InstanceTypeFamily");

				nodeListResponse_nodes.Add(node);
			}
			nodeListResponse.Nodes = nodeListResponse_nodes;
        
			return nodeListResponse;
        }
    }
}