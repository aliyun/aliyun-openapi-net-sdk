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
using Aliyun.Acs.CloudAPI.Model.V20160714;

namespace Aliyun.Acs.CloudAPI.Transform.V20160714
{
    public class DescribeApiQpsDataResponseUnmarshaller
    {
        public static DescribeApiQpsDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeApiQpsDataResponse describeApiQpsDataResponse = new DescribeApiQpsDataResponse();

			describeApiQpsDataResponse.HttpResponse = context.HttpResponse;
			describeApiQpsDataResponse.RequestId = context.StringValue("DescribeApiQpsData.RequestId");

			List<DescribeApiQpsDataResponse.DescribeApiQpsData_MonitorItem> describeApiQpsDataResponse_callSuccesses = new List<DescribeApiQpsDataResponse.DescribeApiQpsData_MonitorItem>();
			for (int i = 0; i < context.Length("DescribeApiQpsData.CallSuccesses.Length"); i++) {
				DescribeApiQpsDataResponse.DescribeApiQpsData_MonitorItem monitorItem = new DescribeApiQpsDataResponse.DescribeApiQpsData_MonitorItem();
				monitorItem.ItemTime = context.StringValue("DescribeApiQpsData.CallSuccesses["+ i +"].ItemTime");
				monitorItem.ItemValue = context.StringValue("DescribeApiQpsData.CallSuccesses["+ i +"].ItemValue");

				describeApiQpsDataResponse_callSuccesses.Add(monitorItem);
			}
			describeApiQpsDataResponse.CallSuccesses = describeApiQpsDataResponse_callSuccesses;

			List<DescribeApiQpsDataResponse.DescribeApiQpsData_MonitorItem> describeApiQpsDataResponse_callFails = new List<DescribeApiQpsDataResponse.DescribeApiQpsData_MonitorItem>();
			for (int i = 0; i < context.Length("DescribeApiQpsData.CallFails.Length"); i++) {
				DescribeApiQpsDataResponse.DescribeApiQpsData_MonitorItem monitorItem = new DescribeApiQpsDataResponse.DescribeApiQpsData_MonitorItem();
				monitorItem.ItemTime = context.StringValue("DescribeApiQpsData.CallFails["+ i +"].ItemTime");
				monitorItem.ItemValue = context.StringValue("DescribeApiQpsData.CallFails["+ i +"].ItemValue");

				describeApiQpsDataResponse_callFails.Add(monitorItem);
			}
			describeApiQpsDataResponse.CallFails = describeApiQpsDataResponse_callFails;
        
			return describeApiQpsDataResponse;
        }
    }
}
