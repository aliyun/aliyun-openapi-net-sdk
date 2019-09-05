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
    public class DescribeApiTrafficDataResponseUnmarshaller
    {
        public static DescribeApiTrafficDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeApiTrafficDataResponse describeApiTrafficDataResponse = new DescribeApiTrafficDataResponse();

			describeApiTrafficDataResponse.HttpResponse = context.HttpResponse;
			describeApiTrafficDataResponse.RequestId = context.StringValue("DescribeApiTrafficData.RequestId");

			List<DescribeApiTrafficDataResponse.DescribeApiTrafficData_MonitorItem> describeApiTrafficDataResponse_callUploads = new List<DescribeApiTrafficDataResponse.DescribeApiTrafficData_MonitorItem>();
			for (int i = 0; i < context.Length("DescribeApiTrafficData.CallUploads.Length"); i++) {
				DescribeApiTrafficDataResponse.DescribeApiTrafficData_MonitorItem monitorItem = new DescribeApiTrafficDataResponse.DescribeApiTrafficData_MonitorItem();
				monitorItem.ItemTime = context.StringValue("DescribeApiTrafficData.CallUploads["+ i +"].ItemTime");
				monitorItem.ItemValue = context.StringValue("DescribeApiTrafficData.CallUploads["+ i +"].ItemValue");

				describeApiTrafficDataResponse_callUploads.Add(monitorItem);
			}
			describeApiTrafficDataResponse.CallUploads = describeApiTrafficDataResponse_callUploads;

			List<DescribeApiTrafficDataResponse.DescribeApiTrafficData_MonitorItem> describeApiTrafficDataResponse_callDownloads = new List<DescribeApiTrafficDataResponse.DescribeApiTrafficData_MonitorItem>();
			for (int i = 0; i < context.Length("DescribeApiTrafficData.CallDownloads.Length"); i++) {
				DescribeApiTrafficDataResponse.DescribeApiTrafficData_MonitorItem monitorItem = new DescribeApiTrafficDataResponse.DescribeApiTrafficData_MonitorItem();
				monitorItem.ItemTime = context.StringValue("DescribeApiTrafficData.CallDownloads["+ i +"].ItemTime");
				monitorItem.ItemValue = context.StringValue("DescribeApiTrafficData.CallDownloads["+ i +"].ItemValue");

				describeApiTrafficDataResponse_callDownloads.Add(monitorItem);
			}
			describeApiTrafficDataResponse.CallDownloads = describeApiTrafficDataResponse_callDownloads;
        
			return describeApiTrafficDataResponse;
        }
    }
}
