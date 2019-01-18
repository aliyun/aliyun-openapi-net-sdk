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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.aegis.Model.V20161111;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class DescribeSuspiciousEventsResponseUnmarshaller
    {
        public static DescribeSuspiciousEventsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSuspiciousEventsResponse describeSuspiciousEventsResponse = new DescribeSuspiciousEventsResponse();

			describeSuspiciousEventsResponse.HttpResponse = context.HttpResponse;
			describeSuspiciousEventsResponse.RequestId = context.StringValue("DescribeSuspiciousEvents.RequestId");
			describeSuspiciousEventsResponse.PageSize = context.IntegerValue("DescribeSuspiciousEvents.PageSize");
			describeSuspiciousEventsResponse.TotalCount = context.IntegerValue("DescribeSuspiciousEvents.TotalCount");
			describeSuspiciousEventsResponse.CurrentPage = context.IntegerValue("DescribeSuspiciousEvents.CurrentPage");
			describeSuspiciousEventsResponse.HttpStatusCode = context.IntegerValue("DescribeSuspiciousEvents.HttpStatusCode");

			List<string> describeSuspiciousEventsResponse_suspiciousEvents = new List<string>();
			for (int i = 0; i < context.Length("DescribeSuspiciousEvents.SuspiciousEvents.Length"); i++) {
				describeSuspiciousEventsResponse_suspiciousEvents.Add(context.StringValue("DescribeSuspiciousEvents.SuspiciousEvents["+ i +"]"));
			}
			describeSuspiciousEventsResponse.SuspiciousEvents = describeSuspiciousEventsResponse_suspiciousEvents;
        
			return describeSuspiciousEventsResponse;
        }
    }
}