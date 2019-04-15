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
using Aliyun.Acs.aegis.Model.V20161111;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class DescribeSuspEventTypesResponseUnmarshaller
    {
        public static DescribeSuspEventTypesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSuspEventTypesResponse describeSuspEventTypesResponse = new DescribeSuspEventTypesResponse();

			describeSuspEventTypesResponse.HttpResponse = context.HttpResponse;
			describeSuspEventTypesResponse.RequestId = context.StringValue("DescribeSuspEventTypes.RequestId");
			describeSuspEventTypesResponse.TotalCount = context.IntegerValue("DescribeSuspEventTypes.TotalCount");

			List<DescribeSuspEventTypesResponse.DescribeSuspEventTypes_Data> describeSuspEventTypesResponse_eventTypes = new List<DescribeSuspEventTypesResponse.DescribeSuspEventTypes_Data>();
			for (int i = 0; i < context.Length("DescribeSuspEventTypes.EventTypes.Length"); i++) {
				DescribeSuspEventTypesResponse.DescribeSuspEventTypes_Data data = new DescribeSuspEventTypesResponse.DescribeSuspEventTypes_Data();
				data.AliseEventType = context.StringValue("DescribeSuspEventTypes.EventTypes["+ i +"].AliseEventType");
				data.EventType = context.StringValue("DescribeSuspEventTypes.EventTypes["+ i +"].EventType");

				describeSuspEventTypesResponse_eventTypes.Add(data);
			}
			describeSuspEventTypesResponse.EventTypes = describeSuspEventTypesResponse_eventTypes;
        
			return describeSuspEventTypesResponse;
        }
    }
}
