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
        public static DescribeSimilarSecurityEventsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSimilarSecurityEventsResponse describeSimilarSecurityEventsResponse = new DescribeSimilarSecurityEventsResponse();

			describeSimilarSecurityEventsResponse.HttpResponse = context.HttpResponse;
			describeSimilarSecurityEventsResponse.RequestId = context.StringValue("DescribeSimilarSecurityEvents.RequestId");

			DescribeSimilarSecurityEventsResponse.DescribeSimilarSecurityEvents_PageInfo pageInfo = new DescribeSimilarSecurityEventsResponse.DescribeSimilarSecurityEvents_PageInfo();
			pageInfo.Count = context.IntegerValue("DescribeSimilarSecurityEvents.PageInfo.Count");
			pageInfo.PageSize = context.IntegerValue("DescribeSimilarSecurityEvents.PageInfo.PageSize");
			pageInfo.TotalCount = context.IntegerValue("DescribeSimilarSecurityEvents.PageInfo.TotalCount");
			pageInfo.CurrentPage = context.IntegerValue("DescribeSimilarSecurityEvents.PageInfo.CurrentPage");
			describeSimilarSecurityEventsResponse.PageInfo = pageInfo;

			List<DescribeSimilarSecurityEventsResponse.DescribeSimilarSecurityEvents_SimpleSecurityEvent> describeSimilarSecurityEventsResponse_securityEventsResponse = new List<DescribeSimilarSecurityEventsResponse.DescribeSimilarSecurityEvents_SimpleSecurityEvent>();
			for (int i = 0; i < context.Length("DescribeSimilarSecurityEvents.SecurityEventsResponse.Length"); i++) {
				DescribeSimilarSecurityEventsResponse.DescribeSimilarSecurityEvents_SimpleSecurityEvent simpleSecurityEvent = new DescribeSimilarSecurityEventsResponse.DescribeSimilarSecurityEvents_SimpleSecurityEvent();
				simpleSecurityEvent.SecurityEventId = context.LongValue("DescribeSimilarSecurityEvents.SecurityEventsResponse["+ i +"].SecurityEventId");
				simpleSecurityEvent.Uuid = context.StringValue("DescribeSimilarSecurityEvents.SecurityEventsResponse["+ i +"].Uuid");
				simpleSecurityEvent.EventType = context.StringValue("DescribeSimilarSecurityEvents.SecurityEventsResponse["+ i +"].EventType");
				simpleSecurityEvent.EventName = context.StringValue("DescribeSimilarSecurityEvents.SecurityEventsResponse["+ i +"].EventName");
				simpleSecurityEvent.OccurrenceTime = context.LongValue("DescribeSimilarSecurityEvents.SecurityEventsResponse["+ i +"].OccurrenceTime");
				simpleSecurityEvent.LastTime = context.LongValue("DescribeSimilarSecurityEvents.SecurityEventsResponse["+ i +"].LastTime");

				describeSimilarSecurityEventsResponse_securityEventsResponse.Add(simpleSecurityEvent);
			}
			describeSimilarSecurityEventsResponse.SecurityEventsResponse = describeSimilarSecurityEventsResponse_securityEventsResponse;
        
			return describeSimilarSecurityEventsResponse;
        }
    }
}
