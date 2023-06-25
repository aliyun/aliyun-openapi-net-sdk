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
using Aliyun.Acs.ddosbgp.Model.V20180720;

namespace Aliyun.Acs.ddosbgp.Transform.V20180720
{
    public class DescribeOnDemandDdosEventResponseUnmarshaller
    {
        public static DescribeOnDemandDdosEventResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeOnDemandDdosEventResponse describeOnDemandDdosEventResponse = new DescribeOnDemandDdosEventResponse();

			describeOnDemandDdosEventResponse.HttpResponse = _ctx.HttpResponse;
			describeOnDemandDdosEventResponse.Total = _ctx.LongValue("DescribeOnDemandDdosEvent.Total");
			describeOnDemandDdosEventResponse.RequestId = _ctx.StringValue("DescribeOnDemandDdosEvent.RequestId");

			List<DescribeOnDemandDdosEventResponse.DescribeOnDemandDdosEvent__Event> describeOnDemandDdosEventResponse_events = new List<DescribeOnDemandDdosEventResponse.DescribeOnDemandDdosEvent__Event>();
			for (int i = 0; i < _ctx.Length("DescribeOnDemandDdosEvent.Events.Length"); i++) {
				DescribeOnDemandDdosEventResponse.DescribeOnDemandDdosEvent__Event _event = new DescribeOnDemandDdosEventResponse.DescribeOnDemandDdosEvent__Event();
				_event.EndTime = _ctx.IntegerValue("DescribeOnDemandDdosEvent.Events["+ i +"].EndTime");
				_event.Status = _ctx.StringValue("DescribeOnDemandDdosEvent.Events["+ i +"].Status");
				_event.StartTime = _ctx.IntegerValue("DescribeOnDemandDdosEvent.Events["+ i +"].StartTime");
				_event.Mbps = _ctx.IntegerValue("DescribeOnDemandDdosEvent.Events["+ i +"].Mbps");
				_event.Ip = _ctx.StringValue("DescribeOnDemandDdosEvent.Events["+ i +"].Ip");
				_event.Pps = _ctx.IntegerValue("DescribeOnDemandDdosEvent.Events["+ i +"].Pps");

				describeOnDemandDdosEventResponse_events.Add(_event);
			}
			describeOnDemandDdosEventResponse.Events = describeOnDemandDdosEventResponse_events;
        
			return describeOnDemandDdosEventResponse;
        }
    }
}
