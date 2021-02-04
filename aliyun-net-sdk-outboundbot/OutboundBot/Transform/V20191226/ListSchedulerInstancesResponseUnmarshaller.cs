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
using Aliyun.Acs.OutboundBot.Model.V20191226;

namespace Aliyun.Acs.OutboundBot.Transform.V20191226
{
    public class ListSchedulerInstancesResponseUnmarshaller
    {
        public static ListSchedulerInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSchedulerInstancesResponse listSchedulerInstancesResponse = new ListSchedulerInstancesResponse();

			listSchedulerInstancesResponse.HttpResponse = _ctx.HttpResponse;
			listSchedulerInstancesResponse.RequestId = _ctx.StringValue("ListSchedulerInstances.RequestId");
			listSchedulerInstancesResponse.Success = _ctx.BooleanValue("ListSchedulerInstances.Success");
			listSchedulerInstancesResponse.Code = _ctx.StringValue("ListSchedulerInstances.Code");
			listSchedulerInstancesResponse.Message = _ctx.StringValue("ListSchedulerInstances.Message");
			listSchedulerInstancesResponse.HttpStatusCode = _ctx.IntegerValue("ListSchedulerInstances.HttpStatusCode");

			List<ListSchedulerInstancesResponse.ListSchedulerInstances_SchedulerInstance> listSchedulerInstancesResponse_schedulerInstances = new List<ListSchedulerInstancesResponse.ListSchedulerInstances_SchedulerInstance>();
			for (int i = 0; i < _ctx.Length("ListSchedulerInstances.SchedulerInstances.Length"); i++) {
				ListSchedulerInstancesResponse.ListSchedulerInstances_SchedulerInstance schedulerInstance = new ListSchedulerInstancesResponse.ListSchedulerInstances_SchedulerInstance();
				schedulerInstance.OwnerId = _ctx.StringValue("ListSchedulerInstances.SchedulerInstances["+ i +"].OwnerId");
				schedulerInstance.InstanceId = _ctx.StringValue("ListSchedulerInstances.SchedulerInstances["+ i +"].InstanceId");
				schedulerInstance.Business = _ctx.StringValue("ListSchedulerInstances.SchedulerInstances["+ i +"].Business");
				schedulerInstance.MaxConcurrency = _ctx.IntegerValue("ListSchedulerInstances.SchedulerInstances["+ i +"].MaxConcurrency");

				listSchedulerInstancesResponse_schedulerInstances.Add(schedulerInstance);
			}
			listSchedulerInstancesResponse.SchedulerInstances = listSchedulerInstancesResponse_schedulerInstances;
        
			return listSchedulerInstancesResponse;
        }
    }
}
