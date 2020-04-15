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
using Aliyun.Acs.Smartag.Model.V20180313;

namespace Aliyun.Acs.Smartag.Transform.V20180313
{
    public class DescribeSagExpressConnectInterfaceListResponseUnmarshaller
    {
        public static DescribeSagExpressConnectInterfaceListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSagExpressConnectInterfaceListResponse describeSagExpressConnectInterfaceListResponse = new DescribeSagExpressConnectInterfaceListResponse();

			describeSagExpressConnectInterfaceListResponse.HttpResponse = context.HttpResponse;
			describeSagExpressConnectInterfaceListResponse.RequestId = context.StringValue("DescribeSagExpressConnectInterfaceList.RequestId");

			List<DescribeSagExpressConnectInterfaceListResponse.DescribeSagExpressConnectInterfaceList__Interface> describeSagExpressConnectInterfaceListResponse_interfaces = new List<DescribeSagExpressConnectInterfaceListResponse.DescribeSagExpressConnectInterfaceList__Interface>();
			for (int i = 0; i < context.Length("DescribeSagExpressConnectInterfaceList.Interfaces.Length"); i++) {
				DescribeSagExpressConnectInterfaceListResponse.DescribeSagExpressConnectInterfaceList__Interface _interface = new DescribeSagExpressConnectInterfaceListResponse.DescribeSagExpressConnectInterfaceList__Interface();
				_interface.Vlan = context.StringValue("DescribeSagExpressConnectInterfaceList.Interfaces["+ i +"].Vlan");
				_interface.IP = context.StringValue("DescribeSagExpressConnectInterfaceList.Interfaces["+ i +"].IP");
				_interface.Mask = context.StringValue("DescribeSagExpressConnectInterfaceList.Interfaces["+ i +"].Mask");

				describeSagExpressConnectInterfaceListResponse_interfaces.Add(_interface);
			}
			describeSagExpressConnectInterfaceListResponse.Interfaces = describeSagExpressConnectInterfaceListResponse_interfaces;

			List<DescribeSagExpressConnectInterfaceListResponse.DescribeSagExpressConnectInterfaceList_TaskState> describeSagExpressConnectInterfaceListResponse_taskStates = new List<DescribeSagExpressConnectInterfaceListResponse.DescribeSagExpressConnectInterfaceList_TaskState>();
			for (int i = 0; i < context.Length("DescribeSagExpressConnectInterfaceList.TaskStates.Length"); i++) {
				DescribeSagExpressConnectInterfaceListResponse.DescribeSagExpressConnectInterfaceList_TaskState taskState = new DescribeSagExpressConnectInterfaceListResponse.DescribeSagExpressConnectInterfaceList_TaskState();
				taskState.State = context.StringValue("DescribeSagExpressConnectInterfaceList.TaskStates["+ i +"].State");
				taskState.ErrorCode = context.StringValue("DescribeSagExpressConnectInterfaceList.TaskStates["+ i +"].ErrorCode");
				taskState.ErrorMessage = context.StringValue("DescribeSagExpressConnectInterfaceList.TaskStates["+ i +"].ErrorMessage");
				taskState.CreateTime = context.StringValue("DescribeSagExpressConnectInterfaceList.TaskStates["+ i +"].CreateTime");

				describeSagExpressConnectInterfaceListResponse_taskStates.Add(taskState);
			}
			describeSagExpressConnectInterfaceListResponse.TaskStates = describeSagExpressConnectInterfaceListResponse_taskStates;
        
			return describeSagExpressConnectInterfaceListResponse;
        }
    }
}
