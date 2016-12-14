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
using Aliyun.Acs.CloudAPI.Model.V20160714;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudAPI.Transform.V20160714
{
    public class DescribeTrafficControlsByApiResponseUnmarshaller
    {
        public static DescribeTrafficControlsByApiResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeTrafficControlsByApiResponse describeTrafficControlsByApiResponse = new DescribeTrafficControlsByApiResponse();

			describeTrafficControlsByApiResponse.HttpResponse = context.HttpResponse;
			describeTrafficControlsByApiResponse.RequestId = context.StringValue("DescribeTrafficControlsByApi.RequestId");

			List<DescribeTrafficControlsByApiResponse.TrafficControlItem> trafficControlItems = new List<DescribeTrafficControlsByApiResponse.TrafficControlItem>();
			for (int i = 0; i < context.Length("DescribeTrafficControlsByApi.TrafficControlItems.Length"); i++) {
				DescribeTrafficControlsByApiResponse.TrafficControlItem trafficControlItem = new DescribeTrafficControlsByApiResponse.TrafficControlItem();
				trafficControlItem.TrafficControlItemId = context.StringValue("DescribeTrafficControlsByApi.TrafficControlItems["+ i +"].TrafficControlItemId");
				trafficControlItem.TrafficControlItemName = context.StringValue("DescribeTrafficControlsByApi.TrafficControlItems["+ i +"].TrafficControlItemName");
				trafficControlItem.BoundTime = context.StringValue("DescribeTrafficControlsByApi.TrafficControlItems["+ i +"].BoundTime");

				trafficControlItems.Add(trafficControlItem);
			}
			describeTrafficControlsByApiResponse.TrafficControlItems = trafficControlItems;
        
			return describeTrafficControlsByApiResponse;
        }
    }
}