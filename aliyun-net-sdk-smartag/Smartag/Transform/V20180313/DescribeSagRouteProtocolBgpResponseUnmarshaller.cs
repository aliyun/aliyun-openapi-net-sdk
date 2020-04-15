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
    public class DescribeSagRouteProtocolBgpResponseUnmarshaller
    {
        public static DescribeSagRouteProtocolBgpResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSagRouteProtocolBgpResponse describeSagRouteProtocolBgpResponse = new DescribeSagRouteProtocolBgpResponse();

			describeSagRouteProtocolBgpResponse.HttpResponse = context.HttpResponse;
			describeSagRouteProtocolBgpResponse.RequestId = context.StringValue("DescribeSagRouteProtocolBgp.RequestId");
			describeSagRouteProtocolBgpResponse.RouterId = context.StringValue("DescribeSagRouteProtocolBgp.RouterId");
			describeSagRouteProtocolBgpResponse.LocalAs = context.IntegerValue("DescribeSagRouteProtocolBgp.LocalAs");
			describeSagRouteProtocolBgpResponse.HoldTime = context.IntegerValue("DescribeSagRouteProtocolBgp.HoldTime");
			describeSagRouteProtocolBgpResponse.KeepAlive = context.IntegerValue("DescribeSagRouteProtocolBgp.KeepAlive");

			List<DescribeSagRouteProtocolBgpResponse.DescribeSagRouteProtocolBgp_TaskState> describeSagRouteProtocolBgpResponse_taskStates = new List<DescribeSagRouteProtocolBgpResponse.DescribeSagRouteProtocolBgp_TaskState>();
			for (int i = 0; i < context.Length("DescribeSagRouteProtocolBgp.TaskStates.Length"); i++) {
				DescribeSagRouteProtocolBgpResponse.DescribeSagRouteProtocolBgp_TaskState taskState = new DescribeSagRouteProtocolBgpResponse.DescribeSagRouteProtocolBgp_TaskState();
				taskState.State = context.StringValue("DescribeSagRouteProtocolBgp.TaskStates["+ i +"].State");
				taskState.ErrorCode = context.StringValue("DescribeSagRouteProtocolBgp.TaskStates["+ i +"].ErrorCode");
				taskState.ErrorMessage = context.StringValue("DescribeSagRouteProtocolBgp.TaskStates["+ i +"].ErrorMessage");
				taskState.CreateTime = context.StringValue("DescribeSagRouteProtocolBgp.TaskStates["+ i +"].CreateTime");

				describeSagRouteProtocolBgpResponse_taskStates.Add(taskState);
			}
			describeSagRouteProtocolBgpResponse.TaskStates = describeSagRouteProtocolBgpResponse_taskStates;
        
			return describeSagRouteProtocolBgpResponse;
        }
    }
}
