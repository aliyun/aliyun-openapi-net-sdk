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
    public class CreateSimulatedSystemEventsResponseUnmarshaller
    {
        public static CreateSimulatedSystemEventsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateSimulatedSystemEventsResponse createSimulatedSystemEventsResponse = new CreateSimulatedSystemEventsResponse();

			createSimulatedSystemEventsResponse.HttpResponse = _ctx.HttpResponse;
			createSimulatedSystemEventsResponse.RequestId = _ctx.StringValue("CreateSimulatedSystemEvents.RequestId");

			List<string> createSimulatedSystemEventsResponse_eventIdSet = new List<string>();
			for (int i = 0; i < _ctx.Length("CreateSimulatedSystemEvents.EventIdSet.Length"); i++) {
				createSimulatedSystemEventsResponse_eventIdSet.Add(_ctx.StringValue("CreateSimulatedSystemEvents.EventIdSet["+ i +"]"));
			}
			createSimulatedSystemEventsResponse.EventIdSet = createSimulatedSystemEventsResponse_eventIdSet;
        
			return createSimulatedSystemEventsResponse;
        }
    }
}
