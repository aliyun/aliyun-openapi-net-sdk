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
    public class DescribeIpv6AddressesResponseUnmarshaller
    {
        public static DescribeIpv6AddressesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeIpv6AddressesResponse describeIpv6AddressesResponse = new DescribeIpv6AddressesResponse();

			describeIpv6AddressesResponse.HttpResponse = _ctx.HttpResponse;
			describeIpv6AddressesResponse.RequestId = _ctx.StringValue("DescribeIpv6Addresses.RequestId");
			describeIpv6AddressesResponse.TotalCount = _ctx.IntegerValue("DescribeIpv6Addresses.TotalCount");
			describeIpv6AddressesResponse.PageNumber = _ctx.IntegerValue("DescribeIpv6Addresses.PageNumber");
			describeIpv6AddressesResponse.PageSize = _ctx.IntegerValue("DescribeIpv6Addresses.PageSize");

			List<DescribeIpv6AddressesResponse.DescribeIpv6Addresses_Ipv6Address> describeIpv6AddressesResponse_ipv6Addresses = new List<DescribeIpv6AddressesResponse.DescribeIpv6Addresses_Ipv6Address>();
			for (int i = 0; i < _ctx.Length("DescribeIpv6Addresses.Ipv6Addresses.Length"); i++) {
				DescribeIpv6AddressesResponse.DescribeIpv6Addresses_Ipv6Address ipv6Address = new DescribeIpv6AddressesResponse.DescribeIpv6Addresses_Ipv6Address();
				ipv6Address.Ipv6AddressId = _ctx.StringValue("DescribeIpv6Addresses.Ipv6Addresses["+ i +"].Ipv6AddressId");
				ipv6Address.Ipv6AddressName = _ctx.StringValue("DescribeIpv6Addresses.Ipv6Addresses["+ i +"].Ipv6AddressName");
				ipv6Address.VSwitchId = _ctx.StringValue("DescribeIpv6Addresses.Ipv6Addresses["+ i +"].VSwitchId");
				ipv6Address.VpcId = _ctx.StringValue("DescribeIpv6Addresses.Ipv6Addresses["+ i +"].VpcId");
				ipv6Address.Ipv6GatewayId = _ctx.StringValue("DescribeIpv6Addresses.Ipv6Addresses["+ i +"].Ipv6GatewayId");
				ipv6Address.Ipv6Address = _ctx.StringValue("DescribeIpv6Addresses.Ipv6Addresses["+ i +"].Ipv6Address");
				ipv6Address.AssociatedInstanceId = _ctx.StringValue("DescribeIpv6Addresses.Ipv6Addresses["+ i +"].AssociatedInstanceId");
				ipv6Address.AssociatedInstanceType = _ctx.StringValue("DescribeIpv6Addresses.Ipv6Addresses["+ i +"].AssociatedInstanceType");
				ipv6Address.Status = _ctx.StringValue("DescribeIpv6Addresses.Ipv6Addresses["+ i +"].Status");
				ipv6Address.NetworkType = _ctx.StringValue("DescribeIpv6Addresses.Ipv6Addresses["+ i +"].NetworkType");
				ipv6Address.RealBandwidth = _ctx.IntegerValue("DescribeIpv6Addresses.Ipv6Addresses["+ i +"].RealBandwidth");
				ipv6Address.AllocationTime = _ctx.StringValue("DescribeIpv6Addresses.Ipv6Addresses["+ i +"].AllocationTime");
				ipv6Address.Ipv6Isp = _ctx.StringValue("DescribeIpv6Addresses.Ipv6Addresses["+ i +"].Ipv6Isp");

				DescribeIpv6AddressesResponse.DescribeIpv6Addresses_Ipv6Address.DescribeIpv6Addresses_Ipv6InternetBandwidth ipv6InternetBandwidth = new DescribeIpv6AddressesResponse.DescribeIpv6Addresses_Ipv6Address.DescribeIpv6Addresses_Ipv6InternetBandwidth();
				ipv6InternetBandwidth.Bandwidth = _ctx.IntegerValue("DescribeIpv6Addresses.Ipv6Addresses["+ i +"].Ipv6InternetBandwidth.Bandwidth");
				ipv6InternetBandwidth.InstanceChargeType = _ctx.StringValue("DescribeIpv6Addresses.Ipv6Addresses["+ i +"].Ipv6InternetBandwidth.InstanceChargeType");
				ipv6InternetBandwidth.InternetChargeType = _ctx.StringValue("DescribeIpv6Addresses.Ipv6Addresses["+ i +"].Ipv6InternetBandwidth.InternetChargeType");
				ipv6InternetBandwidth.BusinessStatus = _ctx.StringValue("DescribeIpv6Addresses.Ipv6Addresses["+ i +"].Ipv6InternetBandwidth.BusinessStatus");
				ipv6InternetBandwidth.Ipv6InternetBandwidthId = _ctx.StringValue("DescribeIpv6Addresses.Ipv6Addresses["+ i +"].Ipv6InternetBandwidth.Ipv6InternetBandwidthId");
				ipv6Address.Ipv6InternetBandwidth = ipv6InternetBandwidth;

				describeIpv6AddressesResponse_ipv6Addresses.Add(ipv6Address);
			}
			describeIpv6AddressesResponse.Ipv6Addresses = describeIpv6AddressesResponse_ipv6Addresses;
        
			return describeIpv6AddressesResponse;
        }
    }
}
