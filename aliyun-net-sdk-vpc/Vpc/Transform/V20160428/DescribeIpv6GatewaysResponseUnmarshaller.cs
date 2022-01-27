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
    public class DescribeIpv6GatewaysResponseUnmarshaller
    {
        public static DescribeIpv6GatewaysResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeIpv6GatewaysResponse describeIpv6GatewaysResponse = new DescribeIpv6GatewaysResponse();

			describeIpv6GatewaysResponse.HttpResponse = _ctx.HttpResponse;
			describeIpv6GatewaysResponse.RequestId = _ctx.StringValue("DescribeIpv6Gateways.RequestId");
			describeIpv6GatewaysResponse.TotalCount = _ctx.IntegerValue("DescribeIpv6Gateways.TotalCount");
			describeIpv6GatewaysResponse.PageNumber = _ctx.IntegerValue("DescribeIpv6Gateways.PageNumber");
			describeIpv6GatewaysResponse.PageSize = _ctx.IntegerValue("DescribeIpv6Gateways.PageSize");

			List<DescribeIpv6GatewaysResponse.DescribeIpv6Gateways_Ipv6Gateway> describeIpv6GatewaysResponse_ipv6Gateways = new List<DescribeIpv6GatewaysResponse.DescribeIpv6Gateways_Ipv6Gateway>();
			for (int i = 0; i < _ctx.Length("DescribeIpv6Gateways.Ipv6Gateways.Length"); i++) {
				DescribeIpv6GatewaysResponse.DescribeIpv6Gateways_Ipv6Gateway ipv6Gateway = new DescribeIpv6GatewaysResponse.DescribeIpv6Gateways_Ipv6Gateway();
				ipv6Gateway.RegionId = _ctx.StringValue("DescribeIpv6Gateways.Ipv6Gateways["+ i +"].RegionId");
				ipv6Gateway.Ipv6GatewayId = _ctx.StringValue("DescribeIpv6Gateways.Ipv6Gateways["+ i +"].Ipv6GatewayId");
				ipv6Gateway.VpcId = _ctx.StringValue("DescribeIpv6Gateways.Ipv6Gateways["+ i +"].VpcId");
				ipv6Gateway.Status = _ctx.StringValue("DescribeIpv6Gateways.Ipv6Gateways["+ i +"].Status");
				ipv6Gateway.Name = _ctx.StringValue("DescribeIpv6Gateways.Ipv6Gateways["+ i +"].Name");
				ipv6Gateway.Description = _ctx.StringValue("DescribeIpv6Gateways.Ipv6Gateways["+ i +"].Description");
				ipv6Gateway.Spec = _ctx.StringValue("DescribeIpv6Gateways.Ipv6Gateways["+ i +"].Spec");
				ipv6Gateway.InstanceChargeType = _ctx.StringValue("DescribeIpv6Gateways.Ipv6Gateways["+ i +"].InstanceChargeType");
				ipv6Gateway.BusinessStatus = _ctx.StringValue("DescribeIpv6Gateways.Ipv6Gateways["+ i +"].BusinessStatus");
				ipv6Gateway.ExpiredTime = _ctx.StringValue("DescribeIpv6Gateways.Ipv6Gateways["+ i +"].ExpiredTime");
				ipv6Gateway.CreationTime = _ctx.StringValue("DescribeIpv6Gateways.Ipv6Gateways["+ i +"].CreationTime");

				describeIpv6GatewaysResponse_ipv6Gateways.Add(ipv6Gateway);
			}
			describeIpv6GatewaysResponse.Ipv6Gateways = describeIpv6GatewaysResponse_ipv6Gateways;
        
			return describeIpv6GatewaysResponse;
        }
    }
}
