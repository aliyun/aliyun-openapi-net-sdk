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
    public class DescribeSagRouteProtocolOspfResponseUnmarshaller
    {
        public static DescribeSagRouteProtocolOspfResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSagRouteProtocolOspfResponse describeSagRouteProtocolOspfResponse = new DescribeSagRouteProtocolOspfResponse();

			describeSagRouteProtocolOspfResponse.HttpResponse = context.HttpResponse;
			describeSagRouteProtocolOspfResponse.RequestId = context.StringValue("DescribeSagRouteProtocolOspf.RequestId");
			describeSagRouteProtocolOspfResponse.RouterId = context.StringValue("DescribeSagRouteProtocolOspf.RouterId");
			describeSagRouteProtocolOspfResponse.AreaId = context.StringValue("DescribeSagRouteProtocolOspf.AreaId");
			describeSagRouteProtocolOspfResponse.AreaType = context.StringValue("DescribeSagRouteProtocolOspf.AreaType");
			describeSagRouteProtocolOspfResponse.DeadTime = context.IntegerValue("DescribeSagRouteProtocolOspf.DeadTime");
			describeSagRouteProtocolOspfResponse.HelloTime = context.IntegerValue("DescribeSagRouteProtocolOspf.HelloTime");
			describeSagRouteProtocolOspfResponse.AuthenticationType = context.StringValue("DescribeSagRouteProtocolOspf.AuthenticationType");
			describeSagRouteProtocolOspfResponse.Md5KeyId = context.IntegerValue("DescribeSagRouteProtocolOspf.Md5KeyId");
			describeSagRouteProtocolOspfResponse.Md5Key = context.StringValue("DescribeSagRouteProtocolOspf.Md5Key");

			List<DescribeSagRouteProtocolOspfResponse.DescribeSagRouteProtocolOspf_TaskState> describeSagRouteProtocolOspfResponse_taskStates = new List<DescribeSagRouteProtocolOspfResponse.DescribeSagRouteProtocolOspf_TaskState>();
			for (int i = 0; i < context.Length("DescribeSagRouteProtocolOspf.TaskStates.Length"); i++) {
				DescribeSagRouteProtocolOspfResponse.DescribeSagRouteProtocolOspf_TaskState taskState = new DescribeSagRouteProtocolOspfResponse.DescribeSagRouteProtocolOspf_TaskState();
				taskState.State = context.StringValue("DescribeSagRouteProtocolOspf.TaskStates["+ i +"].State");
				taskState.ErrorCode = context.StringValue("DescribeSagRouteProtocolOspf.TaskStates["+ i +"].ErrorCode");
				taskState.ErrorMessage = context.StringValue("DescribeSagRouteProtocolOspf.TaskStates["+ i +"].ErrorMessage");
				taskState.CreateTime = context.StringValue("DescribeSagRouteProtocolOspf.TaskStates["+ i +"].CreateTime");

				describeSagRouteProtocolOspfResponse_taskStates.Add(taskState);
			}
			describeSagRouteProtocolOspfResponse.TaskStates = describeSagRouteProtocolOspfResponse_taskStates;
        
			return describeSagRouteProtocolOspfResponse;
        }
    }
}
