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
using Aliyun.Acs.sgw.Model.V20180511;

namespace Aliyun.Acs.sgw.Transform.V20180511
{
    public class DescribeGatewayLogsResponseUnmarshaller
    {
        public static DescribeGatewayLogsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGatewayLogsResponse describeGatewayLogsResponse = new DescribeGatewayLogsResponse();

			describeGatewayLogsResponse.HttpResponse = _ctx.HttpResponse;
			describeGatewayLogsResponse.RequestId = _ctx.StringValue("DescribeGatewayLogs.RequestId");
			describeGatewayLogsResponse.Success = _ctx.BooleanValue("DescribeGatewayLogs.Success");
			describeGatewayLogsResponse.Code = _ctx.StringValue("DescribeGatewayLogs.Code");
			describeGatewayLogsResponse.Message = _ctx.StringValue("DescribeGatewayLogs.Message");
			describeGatewayLogsResponse.LogFilePaths = _ctx.StringValue("DescribeGatewayLogs.LogFilePaths");
        
			return describeGatewayLogsResponse;
        }
    }
}
