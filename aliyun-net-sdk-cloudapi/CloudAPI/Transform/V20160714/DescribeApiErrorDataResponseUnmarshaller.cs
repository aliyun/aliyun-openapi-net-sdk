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
    public class DescribeApiErrorDataResponseUnmarshaller
    {
        public static DescribeApiErrorDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeApiErrorDataResponse describeApiErrorDataResponse = new DescribeApiErrorDataResponse();

			describeApiErrorDataResponse.HttpResponse = context.HttpResponse;
			describeApiErrorDataResponse.RequestId = context.StringValue("DescribeApiErrorData.RequestId");

			List<DescribeApiErrorDataResponse.DescribeApiErrorData_MonitorItem> describeApiErrorDataResponse_clientErrors = new List<DescribeApiErrorDataResponse.DescribeApiErrorData_MonitorItem>();
			for (int i = 0; i < context.Length("DescribeApiErrorData.ClientErrors.Length"); i++) {
				DescribeApiErrorDataResponse.DescribeApiErrorData_MonitorItem monitorItem = new DescribeApiErrorDataResponse.DescribeApiErrorData_MonitorItem();
				monitorItem.ItemTime = context.StringValue("DescribeApiErrorData.ClientErrors["+ i +"].ItemTime");
				monitorItem.ItemValue = context.StringValue("DescribeApiErrorData.ClientErrors["+ i +"].ItemValue");

				describeApiErrorDataResponse_clientErrors.Add(monitorItem);
			}
			describeApiErrorDataResponse.ClientErrors = describeApiErrorDataResponse_clientErrors;

			List<DescribeApiErrorDataResponse.DescribeApiErrorData_MonitorItem> describeApiErrorDataResponse_serverErrors = new List<DescribeApiErrorDataResponse.DescribeApiErrorData_MonitorItem>();
			for (int i = 0; i < context.Length("DescribeApiErrorData.ServerErrors.Length"); i++) {
				DescribeApiErrorDataResponse.DescribeApiErrorData_MonitorItem monitorItem = new DescribeApiErrorDataResponse.DescribeApiErrorData_MonitorItem();
				monitorItem.ItemTime = context.StringValue("DescribeApiErrorData.ServerErrors["+ i +"].ItemTime");
				monitorItem.ItemValue = context.StringValue("DescribeApiErrorData.ServerErrors["+ i +"].ItemValue");

				describeApiErrorDataResponse_serverErrors.Add(monitorItem);
			}
			describeApiErrorDataResponse.ServerErrors = describeApiErrorDataResponse_serverErrors;
        
			return describeApiErrorDataResponse;
        }
    }
}
