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
    public class DescribeSagManagementPortResponseUnmarshaller
    {
        public static DescribeSagManagementPortResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSagManagementPortResponse describeSagManagementPortResponse = new DescribeSagManagementPortResponse();

			describeSagManagementPortResponse.HttpResponse = context.HttpResponse;
			describeSagManagementPortResponse.RequestId = context.StringValue("DescribeSagManagementPort.RequestId");
			describeSagManagementPortResponse.IP = context.StringValue("DescribeSagManagementPort.IP");
			describeSagManagementPortResponse.Mask = context.StringValue("DescribeSagManagementPort.Mask");
			describeSagManagementPortResponse.Gateway = context.StringValue("DescribeSagManagementPort.Gateway");

			List<DescribeSagManagementPortResponse.DescribeSagManagementPort_TaskState> describeSagManagementPortResponse_taskStates = new List<DescribeSagManagementPortResponse.DescribeSagManagementPort_TaskState>();
			for (int i = 0; i < context.Length("DescribeSagManagementPort.TaskStates.Length"); i++) {
				DescribeSagManagementPortResponse.DescribeSagManagementPort_TaskState taskState = new DescribeSagManagementPortResponse.DescribeSagManagementPort_TaskState();
				taskState.State = context.StringValue("DescribeSagManagementPort.TaskStates["+ i +"].State");
				taskState.ErrorCode = context.StringValue("DescribeSagManagementPort.TaskStates["+ i +"].ErrorCode");
				taskState.ErrorMessage = context.StringValue("DescribeSagManagementPort.TaskStates["+ i +"].ErrorMessage");
				taskState.CreateTime = context.StringValue("DescribeSagManagementPort.TaskStates["+ i +"].CreateTime");

				describeSagManagementPortResponse_taskStates.Add(taskState);
			}
			describeSagManagementPortResponse.TaskStates = describeSagManagementPortResponse_taskStates;
        
			return describeSagManagementPortResponse;
        }
    }
}
