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
    public class DescribeSagGlobalRouteProtocolResponseUnmarshaller
    {
        public static DescribeSagGlobalRouteProtocolResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSagGlobalRouteProtocolResponse describeSagGlobalRouteProtocolResponse = new DescribeSagGlobalRouteProtocolResponse();

			describeSagGlobalRouteProtocolResponse.HttpResponse = context.HttpResponse;
			describeSagGlobalRouteProtocolResponse.RequestId = context.StringValue("DescribeSagGlobalRouteProtocol.RequestId");
			describeSagGlobalRouteProtocolResponse.RouteProtocol = context.StringValue("DescribeSagGlobalRouteProtocol.RouteProtocol");

			List<DescribeSagGlobalRouteProtocolResponse.DescribeSagGlobalRouteProtocol_TaskState> describeSagGlobalRouteProtocolResponse_taskStates = new List<DescribeSagGlobalRouteProtocolResponse.DescribeSagGlobalRouteProtocol_TaskState>();
			for (int i = 0; i < context.Length("DescribeSagGlobalRouteProtocol.TaskStates.Length"); i++) {
				DescribeSagGlobalRouteProtocolResponse.DescribeSagGlobalRouteProtocol_TaskState taskState = new DescribeSagGlobalRouteProtocolResponse.DescribeSagGlobalRouteProtocol_TaskState();
				taskState.State = context.StringValue("DescribeSagGlobalRouteProtocol.TaskStates["+ i +"].State");
				taskState.ErrorCode = context.StringValue("DescribeSagGlobalRouteProtocol.TaskStates["+ i +"].ErrorCode");
				taskState.ErrorMessage = context.StringValue("DescribeSagGlobalRouteProtocol.TaskStates["+ i +"].ErrorMessage");
				taskState.CreateTime = context.StringValue("DescribeSagGlobalRouteProtocol.TaskStates["+ i +"].CreateTime");

				describeSagGlobalRouteProtocolResponse_taskStates.Add(taskState);
			}
			describeSagGlobalRouteProtocolResponse.TaskStates = describeSagGlobalRouteProtocolResponse_taskStates;
        
			return describeSagGlobalRouteProtocolResponse;
        }
    }
}
