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
    public class DescribeDomainAttackEventsResponseUnmarshaller
    {
        public static DescribeDomainAttackEventsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDomainAttackEventsResponse describeDomainAttackEventsResponse = new DescribeDomainAttackEventsResponse();

			describeDomainAttackEventsResponse.HttpResponse = _ctx.HttpResponse;
			describeDomainAttackEventsResponse.RequestId = _ctx.StringValue("DescribeDomainAttackEvents.RequestId");
			describeDomainAttackEventsResponse.TotalCount = _ctx.LongValue("DescribeDomainAttackEvents.TotalCount");

			List<DescribeDomainAttackEventsResponse.DescribeDomainAttackEvents_Data> describeDomainAttackEventsResponse_domainAttackEvents = new List<DescribeDomainAttackEventsResponse.DescribeDomainAttackEvents_Data>();
			for (int i = 0; i < _ctx.Length("DescribeDomainAttackEvents.DomainAttackEvents.Length"); i++) {
				DescribeDomainAttackEventsResponse.DescribeDomainAttackEvents_Data data = new DescribeDomainAttackEventsResponse.DescribeDomainAttackEvents_Data();
				data.Domain = _ctx.StringValue("DescribeDomainAttackEvents.DomainAttackEvents["+ i +"].Domain");
				data.StartTime = _ctx.LongValue("DescribeDomainAttackEvents.DomainAttackEvents["+ i +"].StartTime");
				data.EndTime = _ctx.LongValue("DescribeDomainAttackEvents.DomainAttackEvents["+ i +"].EndTime");
				data.MaxQps = _ctx.LongValue("DescribeDomainAttackEvents.DomainAttackEvents["+ i +"].MaxQps");

				describeDomainAttackEventsResponse_domainAttackEvents.Add(data);
			}
			describeDomainAttackEventsResponse.DomainAttackEvents = describeDomainAttackEventsResponse_domainAttackEvents;
        
			return describeDomainAttackEventsResponse;
        }
    }
}
