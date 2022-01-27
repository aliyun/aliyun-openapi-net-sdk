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
using Aliyun.Acs.ddoscoo.Model.V20200101;

namespace Aliyun.Acs.ddoscoo.Transform.V20200101
{
    public class DescribeDDoSEventsResponseUnmarshaller
    {
        public static DescribeDDoSEventsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDDoSEventsResponse describeDDoSEventsResponse = new DescribeDDoSEventsResponse();

			describeDDoSEventsResponse.HttpResponse = _ctx.HttpResponse;
			describeDDoSEventsResponse.RequestId = _ctx.StringValue("DescribeDDoSEvents.RequestId");
			describeDDoSEventsResponse.Total = _ctx.LongValue("DescribeDDoSEvents.Total");

			List<DescribeDDoSEventsResponse.DescribeDDoSEvents_Data> describeDDoSEventsResponse_dDoSEvents = new List<DescribeDDoSEventsResponse.DescribeDDoSEvents_Data>();
			for (int i = 0; i < _ctx.Length("DescribeDDoSEvents.DDoSEvents.Length"); i++) {
				DescribeDDoSEventsResponse.DescribeDDoSEvents_Data data = new DescribeDDoSEventsResponse.DescribeDDoSEvents_Data();
				data.Bps = _ctx.LongValue("DescribeDDoSEvents.DDoSEvents["+ i +"].Bps");
				data.Pps = _ctx.LongValue("DescribeDDoSEvents.DDoSEvents["+ i +"].Pps");
				data.EventType = _ctx.StringValue("DescribeDDoSEvents.DDoSEvents["+ i +"].EventType");
				data.Ip = _ctx.StringValue("DescribeDDoSEvents.DDoSEvents["+ i +"].Ip");
				data.StartTime = _ctx.LongValue("DescribeDDoSEvents.DDoSEvents["+ i +"].StartTime");
				data.EndTime = _ctx.LongValue("DescribeDDoSEvents.DDoSEvents["+ i +"].EndTime");
				data.Port = _ctx.StringValue("DescribeDDoSEvents.DDoSEvents["+ i +"].Port");
				data.Region = _ctx.StringValue("DescribeDDoSEvents.DDoSEvents["+ i +"].Region");

				describeDDoSEventsResponse_dDoSEvents.Add(data);
			}
			describeDDoSEventsResponse.DDoSEvents = describeDDoSEventsResponse_dDoSEvents;
        
			return describeDDoSEventsResponse;
        }
    }
}
