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
    public class DescribeVpnGatewayResponseUnmarshaller
    {
        public static DescribeVpnGatewayResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVpnGatewayResponse describeVpnGatewayResponse = new DescribeVpnGatewayResponse();

			describeVpnGatewayResponse.HttpResponse = context.HttpResponse;
			describeVpnGatewayResponse.RequestId = context.StringValue("DescribeVpnGateway.RequestId");
			describeVpnGatewayResponse.VpnGatewayId = context.StringValue("DescribeVpnGateway.VpnGatewayId");
			describeVpnGatewayResponse.VpcId = context.StringValue("DescribeVpnGateway.VpcId");
			describeVpnGatewayResponse.VSwitchId = context.StringValue("DescribeVpnGateway.VSwitchId");
			describeVpnGatewayResponse.InternetIp = context.StringValue("DescribeVpnGateway.InternetIp");
			describeVpnGatewayResponse.CreateTime = context.LongValue("DescribeVpnGateway.CreateTime");
			describeVpnGatewayResponse.EndTime = context.LongValue("DescribeVpnGateway.EndTime");
			describeVpnGatewayResponse.Spec = context.StringValue("DescribeVpnGateway.Spec");
			describeVpnGatewayResponse.Name = context.StringValue("DescribeVpnGateway.Name");
			describeVpnGatewayResponse.Description = context.StringValue("DescribeVpnGateway.Description");
			describeVpnGatewayResponse.Status = context.StringValue("DescribeVpnGateway.Status");
			describeVpnGatewayResponse.BusinessStatus = context.StringValue("DescribeVpnGateway.BusinessStatus");
			describeVpnGatewayResponse.ChargeType = context.StringValue("DescribeVpnGateway.ChargeType");
        
			return describeVpnGatewayResponse;
        }
    }
}