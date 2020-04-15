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
    public class DescribeSagHaResponseUnmarshaller
    {
        public static DescribeSagHaResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSagHaResponse describeSagHaResponse = new DescribeSagHaResponse();

			describeSagHaResponse.HttpResponse = context.HttpResponse;
			describeSagHaResponse.RequestId = context.StringValue("DescribeSagHa.RequestId");
			describeSagHaResponse.Mode = context.StringValue("DescribeSagHa.Mode");

			List<DescribeSagHaResponse.DescribeSagHa_Port> describeSagHaResponse_ports = new List<DescribeSagHaResponse.DescribeSagHa_Port>();
			for (int i = 0; i < context.Length("DescribeSagHa.Ports.Length"); i++) {
				DescribeSagHaResponse.DescribeSagHa_Port port = new DescribeSagHaResponse.DescribeSagHa_Port();
				port.PortName = context.StringValue("DescribeSagHa.Ports["+ i +"].PortName");
				port.VirtualIp = context.StringValue("DescribeSagHa.Ports["+ i +"].VirtualIp");

				describeSagHaResponse_ports.Add(port);
			}
			describeSagHaResponse.Ports = describeSagHaResponse_ports;

			List<DescribeSagHaResponse.DescribeSagHa_TaskState> describeSagHaResponse_taskStates = new List<DescribeSagHaResponse.DescribeSagHa_TaskState>();
			for (int i = 0; i < context.Length("DescribeSagHa.TaskStates.Length"); i++) {
				DescribeSagHaResponse.DescribeSagHa_TaskState taskState = new DescribeSagHaResponse.DescribeSagHa_TaskState();
				taskState.State = context.StringValue("DescribeSagHa.TaskStates["+ i +"].State");
				taskState.ErrorCode = context.StringValue("DescribeSagHa.TaskStates["+ i +"].ErrorCode");
				taskState.ErrorMessage = context.StringValue("DescribeSagHa.TaskStates["+ i +"].ErrorMessage");
				taskState.CreateTime = context.StringValue("DescribeSagHa.TaskStates["+ i +"].CreateTime");

				describeSagHaResponse_taskStates.Add(taskState);
			}
			describeSagHaResponse.TaskStates = describeSagHaResponse_taskStates;
        
			return describeSagHaResponse;
        }
    }
}
