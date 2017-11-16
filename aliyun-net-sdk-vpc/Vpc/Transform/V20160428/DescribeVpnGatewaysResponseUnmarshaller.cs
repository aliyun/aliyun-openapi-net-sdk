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
    public class DescribeVpnGatewaysResponseUnmarshaller
    {
        public static DescribeVpnGatewaysResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVpnGatewaysResponse describeVpnGatewaysResponse = new DescribeVpnGatewaysResponse();

			describeVpnGatewaysResponse.HttpResponse = context.HttpResponse;
			describeVpnGatewaysResponse.RequestId = context.StringValue("DescribeVpnGateways.RequestId");
			describeVpnGatewaysResponse.TotalCount = context.IntegerValue("DescribeVpnGateways.TotalCount");
			describeVpnGatewaysResponse.PageNumber = context.IntegerValue("DescribeVpnGateways.PageNumber");
			describeVpnGatewaysResponse.PageSize = context.IntegerValue("DescribeVpnGateways.PageSize");

			List<DescribeVpnGatewaysResponse.DescribeVpnGateways_VpnGateway> describeVpnGatewaysResponse_vpnGateways = new List<DescribeVpnGatewaysResponse.DescribeVpnGateways_VpnGateway>();
			for (int i = 0; i < context.Length("DescribeVpnGateways.VpnGateways.Length"); i++) {
				DescribeVpnGatewaysResponse.DescribeVpnGateways_VpnGateway vpnGateway = new DescribeVpnGatewaysResponse.DescribeVpnGateways_VpnGateway();
				vpnGateway.VpnGatewayId = context.StringValue("DescribeVpnGateways.VpnGateways["+ i +"].VpnGatewayId");
				vpnGateway.VpcId = context.StringValue("DescribeVpnGateways.VpnGateways["+ i +"].VpcId");
				vpnGateway.VSwitchId = context.StringValue("DescribeVpnGateways.VpnGateways["+ i +"].VSwitchId");
				vpnGateway.InternetIp = context.StringValue("DescribeVpnGateways.VpnGateways["+ i +"].InternetIp");
				vpnGateway.CreateTime = context.LongValue("DescribeVpnGateways.VpnGateways["+ i +"].CreateTime");
				vpnGateway.EndTime = context.LongValue("DescribeVpnGateways.VpnGateways["+ i +"].EndTime");
				vpnGateway.Spec = context.StringValue("DescribeVpnGateways.VpnGateways["+ i +"].Spec");
				vpnGateway.Name = context.StringValue("DescribeVpnGateways.VpnGateways["+ i +"].Name");
				vpnGateway.Description = context.StringValue("DescribeVpnGateways.VpnGateways["+ i +"].Description");
				vpnGateway.Status = context.StringValue("DescribeVpnGateways.VpnGateways["+ i +"].Status");
				vpnGateway.BusinessStatus = context.StringValue("DescribeVpnGateways.VpnGateways["+ i +"].BusinessStatus");
				vpnGateway.ChargeType = context.StringValue("DescribeVpnGateways.VpnGateways["+ i +"].ChargeType");

				describeVpnGatewaysResponse_vpnGateways.Add(vpnGateway);
			}
			describeVpnGatewaysResponse.VpnGateways = describeVpnGatewaysResponse_vpnGateways;
        
			return describeVpnGatewaysResponse;
        }
    }
}