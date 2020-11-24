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
    public class DescribeDDosAllEventListResponseUnmarshaller
    {
        public static DescribeDDosAllEventListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDDosAllEventListResponse describeDDosAllEventListResponse = new DescribeDDosAllEventListResponse();

			describeDDosAllEventListResponse.HttpResponse = _ctx.HttpResponse;
			describeDDosAllEventListResponse.RequestId = _ctx.StringValue("DescribeDDosAllEventList.RequestId");
			describeDDosAllEventListResponse.Total = _ctx.LongValue("DescribeDDosAllEventList.Total");

			List<DescribeDDosAllEventListResponse.DescribeDDosAllEventList_AttackEvent> describeDDosAllEventListResponse_attackEvents = new List<DescribeDDosAllEventListResponse.DescribeDDosAllEventList_AttackEvent>();
			for (int i = 0; i < _ctx.Length("DescribeDDosAllEventList.AttackEvents.Length"); i++) {
				DescribeDDosAllEventListResponse.DescribeDDosAllEventList_AttackEvent attackEvent = new DescribeDDosAllEventListResponse.DescribeDDosAllEventList_AttackEvent();
				attackEvent.Pps = _ctx.LongValue("DescribeDDosAllEventList.AttackEvents["+ i +"].Pps");
				attackEvent.EventType = _ctx.StringValue("DescribeDDosAllEventList.AttackEvents["+ i +"].EventType");
				attackEvent.Port = _ctx.StringValue("DescribeDDosAllEventList.AttackEvents["+ i +"].Port");
				attackEvent.Ip = _ctx.StringValue("DescribeDDosAllEventList.AttackEvents["+ i +"].Ip");
				attackEvent.StartTime = _ctx.LongValue("DescribeDDosAllEventList.AttackEvents["+ i +"].StartTime");
				attackEvent.EndTime = _ctx.LongValue("DescribeDDosAllEventList.AttackEvents["+ i +"].EndTime");
				attackEvent.Mbps = _ctx.LongValue("DescribeDDosAllEventList.AttackEvents["+ i +"].Mbps");

				describeDDosAllEventListResponse_attackEvents.Add(attackEvent);
			}
			describeDDosAllEventListResponse.AttackEvents = describeDDosAllEventListResponse_attackEvents;
        
			return describeDDosAllEventListResponse;
        }
    }
}
