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
using Aliyun.Acs.Vpc.Model.V20160428;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class DescribeVpnConnectionLogsResponseUnmarshaller
    {
        public static DescribeVpnConnectionLogsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVpnConnectionLogsResponse describeVpnConnectionLogsResponse = new DescribeVpnConnectionLogsResponse();

			describeVpnConnectionLogsResponse.HttpResponse = context.HttpResponse;
			describeVpnConnectionLogsResponse.RequestId = context.StringValue("DescribeVpnConnectionLogs.RequestId");
			describeVpnConnectionLogsResponse.Count = context.IntegerValue("DescribeVpnConnectionLogs.Count");
			describeVpnConnectionLogsResponse.IsCompleted = context.BooleanValue("DescribeVpnConnectionLogs.IsCompleted");
			describeVpnConnectionLogsResponse.PageNumber = context.IntegerValue("DescribeVpnConnectionLogs.PageNumber");
			describeVpnConnectionLogsResponse.PageSize = context.IntegerValue("DescribeVpnConnectionLogs.PageSize");

			List<string> describeVpnConnectionLogsResponse_data = new List<string>();
			for (int i = 0; i < context.Length("DescribeVpnConnectionLogs.Data.Length"); i++) {
				describeVpnConnectionLogsResponse_data.Add(context.StringValue("DescribeVpnConnectionLogs.Data["+ i +"]"));
			}
			describeVpnConnectionLogsResponse.Data = describeVpnConnectionLogsResponse_data;
        
			return describeVpnConnectionLogsResponse;
        }
    }
}