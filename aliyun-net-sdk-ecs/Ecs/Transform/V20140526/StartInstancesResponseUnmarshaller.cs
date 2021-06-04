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
    public class StartInstancesResponseUnmarshaller
    {
        public static StartInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			StartInstancesResponse startInstancesResponse = new StartInstancesResponse();

			startInstancesResponse.HttpResponse = _ctx.HttpResponse;
			startInstancesResponse.RequestId = _ctx.StringValue("StartInstances.RequestId");

			List<StartInstancesResponse.StartInstances_InstanceResponse> startInstancesResponse_instanceResponses = new List<StartInstancesResponse.StartInstances_InstanceResponse>();
			for (int i = 0; i < _ctx.Length("StartInstances.InstanceResponses.Length"); i++) {
				StartInstancesResponse.StartInstances_InstanceResponse instanceResponse = new StartInstancesResponse.StartInstances_InstanceResponse();
				instanceResponse.Code = _ctx.StringValue("StartInstances.InstanceResponses["+ i +"].Code");
				instanceResponse.Message = _ctx.StringValue("StartInstances.InstanceResponses["+ i +"].Message");
				instanceResponse.InstanceId = _ctx.StringValue("StartInstances.InstanceResponses["+ i +"].InstanceId");
				instanceResponse.CurrentStatus = _ctx.StringValue("StartInstances.InstanceResponses["+ i +"].CurrentStatus");
				instanceResponse.PreviousStatus = _ctx.StringValue("StartInstances.InstanceResponses["+ i +"].PreviousStatus");

				startInstancesResponse_instanceResponses.Add(instanceResponse);
			}
			startInstancesResponse.InstanceResponses = startInstancesResponse_instanceResponses;
        
			return startInstancesResponse;
        }
    }
}
