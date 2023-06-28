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
    public class DescribeDdosEventResponseUnmarshaller
    {
        public static DescribeDdosEventResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDdosEventResponse describeDdosEventResponse = new DescribeDdosEventResponse();

			describeDdosEventResponse.HttpResponse = _ctx.HttpResponse;
			describeDdosEventResponse.Total = _ctx.LongValue("DescribeDdosEvent.Total");
			describeDdosEventResponse.RequestId = _ctx.StringValue("DescribeDdosEvent.RequestId");

			List<DescribeDdosEventResponse.DescribeDdosEvent__Event> describeDdosEventResponse_events = new List<DescribeDdosEventResponse.DescribeDdosEvent__Event>();
			for (int i = 0; i < _ctx.Length("DescribeDdosEvent.Events.Length"); i++) {
				DescribeDdosEventResponse.DescribeDdosEvent__Event _event = new DescribeDdosEventResponse.DescribeDdosEvent__Event();
				_event.EndTime = _ctx.IntegerValue("DescribeDdosEvent.Events["+ i +"].EndTime");
				_event.Status = _ctx.StringValue("DescribeDdosEvent.Events["+ i +"].Status");
				_event.StartTime = _ctx.IntegerValue("DescribeDdosEvent.Events["+ i +"].StartTime");
				_event.Mbps = _ctx.IntegerValue("DescribeDdosEvent.Events["+ i +"].Mbps");
				_event.Ip = _ctx.StringValue("DescribeDdosEvent.Events["+ i +"].Ip");
				_event.Pps = _ctx.IntegerValue("DescribeDdosEvent.Events["+ i +"].Pps");

				describeDdosEventResponse_events.Add(_event);
			}
			describeDdosEventResponse.Events = describeDdosEventResponse_events;
        
			return describeDdosEventResponse;
        }
    }
}
