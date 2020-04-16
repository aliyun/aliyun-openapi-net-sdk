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
using Aliyun.Acs.Ecs.Model.V20140526;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class StopInstancesResponseUnmarshaller
    {
        public static StopInstancesResponse Unmarshall(UnmarshallerContext context)
        {
			StopInstancesResponse stopInstancesResponse = new StopInstancesResponse();

			stopInstancesResponse.HttpResponse = context.HttpResponse;
			stopInstancesResponse.RequestId = context.StringValue("StopInstances.RequestId");

			List<StopInstancesResponse.StopInstances_InstanceResponse> stopInstancesResponse_instanceResponses = new List<StopInstancesResponse.StopInstances_InstanceResponse>();
			for (int i = 0; i < context.Length("StopInstances.InstanceResponses.Length"); i++) {
				StopInstancesResponse.StopInstances_InstanceResponse instanceResponse = new StopInstancesResponse.StopInstances_InstanceResponse();
				instanceResponse.InstanceId = context.StringValue("StopInstances.InstanceResponses["+ i +"].InstanceId");
				instanceResponse.PreviousStatus = context.StringValue("StopInstances.InstanceResponses["+ i +"].PreviousStatus");
				instanceResponse.CurrentStatus = context.StringValue("StopInstances.InstanceResponses["+ i +"].CurrentStatus");
				instanceResponse.Code = context.StringValue("StopInstances.InstanceResponses["+ i +"].Code");
				instanceResponse.Message = context.StringValue("StopInstances.InstanceResponses["+ i +"].Message");

				stopInstancesResponse_instanceResponses.Add(instanceResponse);
			}
			stopInstancesResponse.InstanceResponses = stopInstancesResponse_instanceResponses;
        
			return stopInstancesResponse;
        }
    }
}
