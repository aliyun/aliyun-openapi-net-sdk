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
    public class DescribeNatGatewaysResponseUnmarshaller
    {
        public static DescribeNatGatewaysResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeNatGatewaysResponse describeNatGatewaysResponse = new DescribeNatGatewaysResponse();

            describeNatGatewaysResponse.HttpResponse = context.HttpResponse;
            describeNatGatewaysResponse.RequestId = context.StringValue("DescribeNatGateways.RequestId");
            describeNatGatewaysResponse.TotalCount = context.IntegerValue("DescribeNatGateways.TotalCount");
            describeNatGatewaysResponse.PageNumber = context.IntegerValue("DescribeNatGateways.PageNumber");
            describeNatGatewaysResponse.PageSize = context.IntegerValue("DescribeNatGateways.PageSize");

            List<DescribeNatGatewaysResponse.DescribeNatGateways_NatGateway> describeNatGatewaysResponse_natGateways = new List<DescribeNatGatewaysResponse.DescribeNatGateways_NatGateway>();
            for (int i = 0; i < context.Length("DescribeNatGateways.NatGateways.Length"); i++)
            {
                DescribeNatGatewaysResponse.DescribeNatGateways_NatGateway natGateway = new DescribeNatGatewaysResponse.DescribeNatGateways_NatGateway();
                natGateway.NatGatewayId = context.StringValue("DescribeNatGateways.NatGateways[" + i + "].NatGatewayId");
                natGateway.RegionId = context.StringValue("DescribeNatGateways.NatGateways[" + i + "].RegionId");
                natGateway.Name = context.StringValue("DescribeNatGateways.NatGateways[" + i + "].Name");
                natGateway.Description = context.StringValue("DescribeNatGateways.NatGateways[" + i + "].Description");
                natGateway.VpcId = context.StringValue("DescribeNatGateways.NatGateways[" + i + "].VpcId");
                natGateway.Spec = context.StringValue("DescribeNatGateways.NatGateways[" + i + "].Spec");
                natGateway.InstanceChargeType = context.StringValue("DescribeNatGateways.NatGateways[" + i + "].InstanceChargeType");
                natGateway.ExpiredTime = context.StringValue("DescribeNatGateways.NatGateways[" + i + "].ExpiredTime");
                natGateway.AutoPay = context.BooleanValue("DescribeNatGateways.NatGateways[" + i + "].AutoPay");
                natGateway.BusinessStatus = context.StringValue("DescribeNatGateways.NatGateways[" + i + "].BusinessStatus");
                natGateway.CreationTime = context.StringValue("DescribeNatGateways.NatGateways[" + i + "].CreationTime");
                natGateway.Status = context.StringValue("DescribeNatGateways.NatGateways[" + i + "].Status");

                List<string> natGateway_forwardTableIds = new List<string>();
                for (int j = 0; j < context.Length("DescribeNatGateways.NatGateways[" + i + "].ForwardTableIds.Length"); j++)
                {
                    natGateway_forwardTableIds.Add(context.StringValue("DescribeNatGateways.NatGateways[" + i + "].ForwardTableIds[" + j + "]"));
                }
                natGateway.ForwardTableIds = natGateway_forwardTableIds;

                List<string> natGateway_snatTableIds = new List<string>();
                for (int j = 0; j < context.Length("DescribeNatGateways.NatGateways[" + i + "].SnatTableIds.Length"); j++)
                {
                    natGateway_snatTableIds.Add(context.StringValue("DescribeNatGateways.NatGateways[" + i + "].SnatTableIds[" + j + "]"));
                }
                natGateway.SnatTableIds = natGateway_snatTableIds;

                List<string> natGateway_bandwidthPackageIds = new List<string>();
                for (int j = 0; j < context.Length("DescribeNatGateways.NatGateways[" + i + "].BandwidthPackageIds.Length"); j++)
                {
                    natGateway_bandwidthPackageIds.Add(context.StringValue("DescribeNatGateways.NatGateways[" + i + "].BandwidthPackageIds[" + j + "]"));
                }
                natGateway.BandwidthPackageIds = natGateway_bandwidthPackageIds;

                List<DescribeNatGatewaysResponse.DescribeNatGateways_NatGateway.DescribeNatGateways_IpList> natGateway_ipLists = new List<DescribeNatGatewaysResponse.DescribeNatGateways_NatGateway.DescribeNatGateways_IpList>();
                for (int j = 0; j < context.Length("DescribeNatGateways.NatGateways[" + i + "].IpLists.Length"); j++)
                {
                    DescribeNatGatewaysResponse.DescribeNatGateways_NatGateway.DescribeNatGateways_IpList ipList = new DescribeNatGatewaysResponse.DescribeNatGateways_NatGateway.DescribeNatGateways_IpList();
                    ipList.AllocationId = context.StringValue("DescribeNatGateways.NatGateways[" + i + "].IpLists[" + j + "].AllocationId");
                    ipList.IpAddress = context.StringValue("DescribeNatGateways.NatGateways[" + i + "].IpLists[" + j + "].IpAddress");
                    ipList.UsingStatus = context.StringValue("DescribeNatGateways.NatGateways[" + i + "].IpLists[" + j + "].UsingStatus");
                    ipList.ApAccessEnabled = context.BooleanValue("DescribeNatGateways.NatGateways[" + i + "].IpLists[" + j + "].ApAccessEnabled");

                    natGateway_ipLists.Add(ipList);
                }
                natGateway.IpLists = natGateway_ipLists;

                describeNatGatewaysResponse_natGateways.Add(natGateway);
            }
            describeNatGatewaysResponse.NatGateways = describeNatGatewaysResponse_natGateways;

            return describeNatGatewaysResponse;
        }
    }
}