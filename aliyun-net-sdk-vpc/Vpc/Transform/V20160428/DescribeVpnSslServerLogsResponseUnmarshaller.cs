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
using Aliyun.Acs.Vpc.Model.V20160428;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class DescribeVpnSslServerLogsResponseUnmarshaller
    {
        public static DescribeVpnSslServerLogsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVpnSslServerLogsResponse describeVpnSslServerLogsResponse = new DescribeVpnSslServerLogsResponse();

			describeVpnSslServerLogsResponse.HttpResponse = _ctx.HttpResponse;
			describeVpnSslServerLogsResponse.RequestId = _ctx.StringValue("DescribeVpnSslServerLogs.RequestId");
			describeVpnSslServerLogsResponse.Count = _ctx.IntegerValue("DescribeVpnSslServerLogs.Count");
			describeVpnSslServerLogsResponse.IsCompleted = _ctx.BooleanValue("DescribeVpnSslServerLogs.IsCompleted");
			describeVpnSslServerLogsResponse.PageNumber = _ctx.IntegerValue("DescribeVpnSslServerLogs.PageNumber");
			describeVpnSslServerLogsResponse.PageSize = _ctx.IntegerValue("DescribeVpnSslServerLogs.PageSize");

			List<string> describeVpnSslServerLogsResponse_data = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeVpnSslServerLogs.Data.Length"); i++) {
				describeVpnSslServerLogsResponse_data.Add(_ctx.StringValue("DescribeVpnSslServerLogs.Data["+ i +"]"));
			}
			describeVpnSslServerLogsResponse.Data = describeVpnSslServerLogsResponse_data;
        
			return describeVpnSslServerLogsResponse;
        }
    }
}
