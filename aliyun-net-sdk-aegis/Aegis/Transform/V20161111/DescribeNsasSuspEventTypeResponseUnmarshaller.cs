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
    public class DescribeNsasSuspEventTypeResponseUnmarshaller
    {
        public static DescribeNsasSuspEventTypeResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeNsasSuspEventTypeResponse describeNsasSuspEventTypeResponse = new DescribeNsasSuspEventTypeResponse();

			describeNsasSuspEventTypeResponse.HttpResponse = context.HttpResponse;
			describeNsasSuspEventTypeResponse.RequestId = context.StringValue("DescribeNsasSuspEventType.RequestId");

			List<DescribeNsasSuspEventTypeResponse.DescribeNsasSuspEventType_Data> describeNsasSuspEventTypeResponse_eventTypes = new List<DescribeNsasSuspEventTypeResponse.DescribeNsasSuspEventType_Data>();
			for (int i = 0; i < context.Length("DescribeNsasSuspEventType.EventTypes.Length"); i++) {
				DescribeNsasSuspEventTypeResponse.DescribeNsasSuspEventType_Data data = new DescribeNsasSuspEventTypeResponse.DescribeNsasSuspEventType_Data();
				data.Name = context.StringValue("DescribeNsasSuspEventType.EventTypes["+ i +"].Name");
				data.Type = context.StringValue("DescribeNsasSuspEventType.EventTypes["+ i +"].Type");
				data.SuspEventCount = context.IntegerValue("DescribeNsasSuspEventType.EventTypes["+ i +"].SuspEventCount");

				describeNsasSuspEventTypeResponse_eventTypes.Add(data);
			}
			describeNsasSuspEventTypeResponse.EventTypes = describeNsasSuspEventTypeResponse_eventTypes;
        
			return describeNsasSuspEventTypeResponse;
        }
    }
}
