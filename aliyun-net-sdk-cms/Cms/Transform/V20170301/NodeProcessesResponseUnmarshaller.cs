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
using Aliyun.Acs.Cms.Model.V20170301;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Cms.Transform.V20170301
{
    public class NodeProcessesResponseUnmarshaller
    {
        public static NodeProcessesResponse Unmarshall(UnmarshallerContext context)
        {
			NodeProcessesResponse nodeProcessesResponse = new NodeProcessesResponse();

			nodeProcessesResponse.HttpResponse = context.HttpResponse;
			nodeProcessesResponse.ErrorCode = context.IntegerValue("NodeProcesses.ErrorCode");
			nodeProcessesResponse.ErrorMessage = context.StringValue("NodeProcesses.ErrorMessage");
			nodeProcessesResponse.Success = context.BooleanValue("NodeProcesses.Success");
			nodeProcessesResponse.RequestId = context.StringValue("NodeProcesses.RequestId");

			List<NodeProcessesResponse.NodeProcesses_NodeProcess> nodeProcessesResponse_nodeProcesses = new List<NodeProcessesResponse.NodeProcesses_NodeProcess>();
			for (int i = 0; i < context.Length("NodeProcesses.NodeProcesses.Length"); i++) {
				NodeProcessesResponse.NodeProcesses_NodeProcess nodeProcess = new NodeProcessesResponse.NodeProcesses_NodeProcess();
				nodeProcess.Id = context.LongValue("NodeProcesses.NodeProcesses["+ i +"].Id");
				nodeProcess.Name = context.StringValue("NodeProcesses.NodeProcesses["+ i +"].Name");
				nodeProcess.InstanceId = context.StringValue("NodeProcesses.NodeProcesses["+ i +"].InstanceId");
				nodeProcess.ProcessName = context.StringValue("NodeProcesses.NodeProcesses["+ i +"].ProcessName");
				nodeProcess.ProcessUser = context.StringValue("NodeProcesses.NodeProcesses["+ i +"].ProcessUser");
				nodeProcess.Command = context.StringValue("NodeProcesses.NodeProcesses["+ i +"].Command");

				nodeProcessesResponse_nodeProcesses.Add(nodeProcess);
			}
			nodeProcessesResponse.NodeProcesses = nodeProcessesResponse_nodeProcesses;
        
			return nodeProcessesResponse;
        }
    }
}