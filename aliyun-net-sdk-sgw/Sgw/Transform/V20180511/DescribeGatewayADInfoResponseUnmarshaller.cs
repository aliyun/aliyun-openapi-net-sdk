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
    public class DescribeGatewayADInfoResponseUnmarshaller
    {
        public static DescribeGatewayADInfoResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeGatewayADInfoResponse describeGatewayADInfoResponse = new DescribeGatewayADInfoResponse();

			describeGatewayADInfoResponse.HttpResponse = context.HttpResponse;
			describeGatewayADInfoResponse.RequestId = context.StringValue("DescribeGatewayADInfo.RequestId");
			describeGatewayADInfoResponse.Success = context.BooleanValue("DescribeGatewayADInfo.Success");
			describeGatewayADInfoResponse.Code = context.StringValue("DescribeGatewayADInfo.Code");
			describeGatewayADInfoResponse.Message = context.StringValue("DescribeGatewayADInfo.Message");
			describeGatewayADInfoResponse.Username = context.StringValue("DescribeGatewayADInfo.Username");
			describeGatewayADInfoResponse.ServerIp = context.StringValue("DescribeGatewayADInfo.ServerIp");
			describeGatewayADInfoResponse.DomainName = context.StringValue("DescribeGatewayADInfo.DomainName");
			describeGatewayADInfoResponse.IsEnabled = context.BooleanValue("DescribeGatewayADInfo.IsEnabled");
        
			return describeGatewayADInfoResponse;
        }
    }
}
