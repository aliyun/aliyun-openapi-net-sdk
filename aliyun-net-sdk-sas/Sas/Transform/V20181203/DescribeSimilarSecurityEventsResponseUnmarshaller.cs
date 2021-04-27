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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeSimilarSecurityEventsResponseUnmarshaller
    {
        public static DescribeSimilarSecurityEventsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSimilarSecurityEventsResponse describeSimilarSecurityEventsResponse = new DescribeSimilarSecurityEventsResponse();

			describeSimilarSecurityEventsResponse.HttpResponse = _ctx.HttpResponse;
			describeSimilarSecurityEventsResponse.RequestId = _ctx.StringValue("DescribeSimilarSecurityEvents.RequestId");

			DescribeSimilarSecurityEventsResponse.DescribeSimilarSecurityEvents_PageInfo pageInfo = new DescribeSimilarSecurityEventsResponse.DescribeSimilarSecurityEvents_PageInfo();
			pageInfo.Count = _ctx.IntegerValue("DescribeSimilarSecurityEvents.PageInfo.Count");
			pageInfo.PageSize = _ctx.IntegerValue("DescribeSimilarSecurityEvents.PageInfo.PageSize");
			pageInfo.TotalCount = _ctx.IntegerValue("DescribeSimilarSecurityEvents.PageInfo.TotalCount");
			pageInfo.CurrentPage = _ctx.IntegerValue("DescribeSimilarSecurityEvents.PageInfo.CurrentPage");
			describeSimilarSecurityEventsResponse.PageInfo = pageInfo;

			List<DescribeSimilarSecurityEventsResponse.DescribeSimilarSecurityEvents_SimpleSecurityEvent> describeSimilarSecurityEventsResponse_securityEventsResponse = new List<DescribeSimilarSecurityEventsResponse.DescribeSimilarSecurityEvents_SimpleSecurityEvent>();
			for (int i = 0; i < _ctx.Length("DescribeSimilarSecurityEvents.SecurityEventsResponse.Length"); i++) {
				DescribeSimilarSecurityEventsResponse.DescribeSimilarSecurityEvents_SimpleSecurityEvent simpleSecurityEvent = new DescribeSimilarSecurityEventsResponse.DescribeSimilarSecurityEvents_SimpleSecurityEvent();
				simpleSecurityEvent.SecurityEventId = _ctx.LongValue("DescribeSimilarSecurityEvents.SecurityEventsResponse["+ i +"].SecurityEventId");
				simpleSecurityEvent.Uuid = _ctx.StringValue("DescribeSimilarSecurityEvents.SecurityEventsResponse["+ i +"].Uuid");
				simpleSecurityEvent.EventType = _ctx.StringValue("DescribeSimilarSecurityEvents.SecurityEventsResponse["+ i +"].EventType");
				simpleSecurityEvent.EventName = _ctx.StringValue("DescribeSimilarSecurityEvents.SecurityEventsResponse["+ i +"].EventName");
				simpleSecurityEvent.OccurrenceTime = _ctx.LongValue("DescribeSimilarSecurityEvents.SecurityEventsResponse["+ i +"].OccurrenceTime");
				simpleSecurityEvent.LastTime = _ctx.LongValue("DescribeSimilarSecurityEvents.SecurityEventsResponse["+ i +"].LastTime");

				describeSimilarSecurityEventsResponse_securityEventsResponse.Add(simpleSecurityEvent);
			}
			describeSimilarSecurityEventsResponse.SecurityEventsResponse = describeSimilarSecurityEventsResponse_securityEventsResponse;
        
			return describeSimilarSecurityEventsResponse;
        }
    }
}
