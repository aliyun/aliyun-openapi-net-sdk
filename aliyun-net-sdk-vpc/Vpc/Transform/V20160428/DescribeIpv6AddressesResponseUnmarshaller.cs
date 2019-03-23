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
    public class DescribeIpv6AddressesResponseUnmarshaller
    {
        public static DescribeIpv6AddressesResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeIpv6AddressesResponse describeIpv6AddressesResponse = new DescribeIpv6AddressesResponse();

            describeIpv6AddressesResponse.HttpResponse = context.HttpResponse;
            describeIpv6AddressesResponse.RequestId = context.StringValue("DescribeIpv6Addresses.RequestId");
            describeIpv6AddressesResponse.TotalCount = context.IntegerValue("DescribeIpv6Addresses.TotalCount");
            describeIpv6AddressesResponse.PageNumber = context.IntegerValue("DescribeIpv6Addresses.PageNumber");
            describeIpv6AddressesResponse.PageSize = context.IntegerValue("DescribeIpv6Addresses.PageSize");

            List<DescribeIpv6AddressesResponse.DescribeIpv6Addresses_Ipv6Address> describeIpv6AddressesResponse_ipv6Addresses = new List<DescribeIpv6AddressesResponse.DescribeIpv6Addresses_Ipv6Address>();
            for (int i = 0; i < context.Length("DescribeIpv6Addresses.Ipv6Addresses.Length"); i++)
            {
                DescribeIpv6AddressesResponse.DescribeIpv6Addresses_Ipv6Address ipv6Address = new DescribeIpv6AddressesResponse.DescribeIpv6Addresses_Ipv6Address();
                ipv6Address.Ipv6AddressId = context.StringValue("DescribeIpv6Addresses.Ipv6Addresses[" + i + "].Ipv6AddressId");
                ipv6Address.Ipv6AddressName = context.StringValue("DescribeIpv6Addresses.Ipv6Addresses[" + i + "].Ipv6AddressName");
                ipv6Address.VSwitchId = context.StringValue("DescribeIpv6Addresses.Ipv6Addresses[" + i + "].VSwitchId");
                ipv6Address.VpcId = context.StringValue("DescribeIpv6Addresses.Ipv6Addresses[" + i + "].VpcId");
                ipv6Address.Ipv6GatewayId = context.StringValue("DescribeIpv6Addresses.Ipv6Addresses[" + i + "].Ipv6GatewayId");
                ipv6Address.Ipv6Address = context.StringValue("DescribeIpv6Addresses.Ipv6Addresses[" + i + "].Ipv6Address");
                ipv6Address.AssociatedInstanceId = context.StringValue("DescribeIpv6Addresses.Ipv6Addresses[" + i + "].AssociatedInstanceId");
                ipv6Address.AssociatedInstanceType = context.StringValue("DescribeIpv6Addresses.Ipv6Addresses[" + i + "].AssociatedInstanceType");
                ipv6Address.Status = context.StringValue("DescribeIpv6Addresses.Ipv6Addresses[" + i + "].Status");
                ipv6Address.NetworkType = context.StringValue("DescribeIpv6Addresses.Ipv6Addresses[" + i + "].NetworkType");
                ipv6Address.RealBandwidth = context.IntegerValue("DescribeIpv6Addresses.Ipv6Addresses[" + i + "].RealBandwidth");
                ipv6Address.AllocationTime = context.StringValue("DescribeIpv6Addresses.Ipv6Addresses[" + i + "].AllocationTime");

                DescribeIpv6AddressesResponse.DescribeIpv6Addresses_Ipv6Address.DescribeIpv6Addresses_Ipv6InternetBandwidth ipv6InternetBandwidth = new DescribeIpv6AddressesResponse.DescribeIpv6Addresses_Ipv6Address.DescribeIpv6Addresses_Ipv6InternetBandwidth();
                ipv6InternetBandwidth.Bandwidth = context.IntegerValue("DescribeIpv6Addresses.Ipv6Addresses[" + i + "].Ipv6InternetBandwidth.Bandwidth");
                ipv6InternetBandwidth.InstanceChargeType = context.StringValue("DescribeIpv6Addresses.Ipv6Addresses[" + i + "].Ipv6InternetBandwidth.InstanceChargeType");
                ipv6InternetBandwidth.InternetChargeType = context.StringValue("DescribeIpv6Addresses.Ipv6Addresses[" + i + "].Ipv6InternetBandwidth.InternetChargeType");
                ipv6InternetBandwidth.BusinessStatus = context.StringValue("DescribeIpv6Addresses.Ipv6Addresses[" + i + "].Ipv6InternetBandwidth.BusinessStatus");
                ipv6InternetBandwidth.Ipv6InternetBandwidthId = context.StringValue("DescribeIpv6Addresses.Ipv6Addresses[" + i + "].Ipv6InternetBandwidth.Ipv6InternetBandwidthId");
                ipv6Address.Ipv6InternetBandwidth = ipv6InternetBandwidth;

                describeIpv6AddressesResponse_ipv6Addresses.Add(ipv6Address);
            }
            describeIpv6AddressesResponse.Ipv6Addresses = describeIpv6AddressesResponse_ipv6Addresses;

            return describeIpv6AddressesResponse;
        }
    }
}