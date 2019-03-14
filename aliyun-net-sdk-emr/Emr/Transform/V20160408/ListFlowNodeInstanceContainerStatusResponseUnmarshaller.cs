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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class ListFlowNodeInstanceContainerStatusResponseUnmarshaller
    {
        public static ListFlowNodeInstanceContainerStatusResponse Unmarshall(UnmarshallerContext context)
        {
			ListFlowNodeInstanceContainerStatusResponse listFlowNodeInstanceContainerStatusResponse = new ListFlowNodeInstanceContainerStatusResponse();

			listFlowNodeInstanceContainerStatusResponse.HttpResponse = context.HttpResponse;
			listFlowNodeInstanceContainerStatusResponse.RequestId = context.StringValue("ListFlowNodeInstanceContainerStatus.RequestId");
			listFlowNodeInstanceContainerStatusResponse.PageNumber = context.IntegerValue("ListFlowNodeInstanceContainerStatus.PageNumber");
			listFlowNodeInstanceContainerStatusResponse.PageSize = context.IntegerValue("ListFlowNodeInstanceContainerStatus.PageSize");
			listFlowNodeInstanceContainerStatusResponse.Total = context.IntegerValue("ListFlowNodeInstanceContainerStatus.Total");

			List<ListFlowNodeInstanceContainerStatusResponse.ListFlowNodeInstanceContainerStatus_ContainerStatus> listFlowNodeInstanceContainerStatusResponse_containerStatusList = new List<ListFlowNodeInstanceContainerStatusResponse.ListFlowNodeInstanceContainerStatus_ContainerStatus>();
			for (int i = 0; i < context.Length("ListFlowNodeInstanceContainerStatus.ContainerStatusList.Length"); i++) {
				ListFlowNodeInstanceContainerStatusResponse.ListFlowNodeInstanceContainerStatus_ContainerStatus containerStatus = new ListFlowNodeInstanceContainerStatusResponse.ListFlowNodeInstanceContainerStatus_ContainerStatus();
				containerStatus.ApplicationId = context.StringValue("ListFlowNodeInstanceContainerStatus.ContainerStatusList["+ i +"].ApplicationId");
				containerStatus.ContainerId = context.StringValue("ListFlowNodeInstanceContainerStatus.ContainerStatusList["+ i +"].ContainerId");
				containerStatus.HostName = context.StringValue("ListFlowNodeInstanceContainerStatus.ContainerStatusList["+ i +"].HostName");
				containerStatus.Status = context.StringValue("ListFlowNodeInstanceContainerStatus.ContainerStatusList["+ i +"].Status");

				listFlowNodeInstanceContainerStatusResponse_containerStatusList.Add(containerStatus);
			}
			listFlowNodeInstanceContainerStatusResponse.ContainerStatusList = listFlowNodeInstanceContainerStatusResponse_containerStatusList;
        
			return listFlowNodeInstanceContainerStatusResponse;
        }
    }
}
