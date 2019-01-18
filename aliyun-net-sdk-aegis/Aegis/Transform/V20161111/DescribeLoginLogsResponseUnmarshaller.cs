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
    public class DescribeLoginLogsResponseUnmarshaller
    {
        public static DescribeLoginLogsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLoginLogsResponse describeLoginLogsResponse = new DescribeLoginLogsResponse();

			describeLoginLogsResponse.HttpResponse = context.HttpResponse;
			describeLoginLogsResponse.RequestId = context.StringValue("DescribeLoginLogs.RequestId");
			describeLoginLogsResponse.PageSize = context.IntegerValue("DescribeLoginLogs.PageSize");
			describeLoginLogsResponse.CurrentPage = context.IntegerValue("DescribeLoginLogs.CurrentPage");
			describeLoginLogsResponse.TotalCount = context.IntegerValue("DescribeLoginLogs.TotalCount");
			describeLoginLogsResponse.HttpStatusCode = context.IntegerValue("DescribeLoginLogs.HttpStatusCode");

			List<string> describeLoginLogsResponse_loginLogs = new List<string>();
			for (int i = 0; i < context.Length("DescribeLoginLogs.LoginLogs.Length"); i++) {
				describeLoginLogsResponse_loginLogs.Add(context.StringValue("DescribeLoginLogs.LoginLogs["+ i +"]"));
			}
			describeLoginLogsResponse.LoginLogs = describeLoginLogsResponse_loginLogs;
        
			return describeLoginLogsResponse;
        }
    }
}