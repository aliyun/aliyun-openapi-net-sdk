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
    public class DescribeNatGatewaysResponseUnmarshaller
    {
        public static DescribeNatGatewaysResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeNatGatewaysResponse describeNatGatewaysResponse = new DescribeNatGatewaysResponse();

			describeNatGatewaysResponse.HttpResponse = _ctx.HttpResponse;
			describeNatGatewaysResponse.PageSize = _ctx.IntegerValue("DescribeNatGateways.PageSize");
			describeNatGatewaysResponse.RequestId = _ctx.StringValue("DescribeNatGateways.RequestId");
			describeNatGatewaysResponse.PageNumber = _ctx.IntegerValue("DescribeNatGateways.PageNumber");
			describeNatGatewaysResponse.TotalCount = _ctx.IntegerValue("DescribeNatGateways.TotalCount");

			List<DescribeNatGatewaysResponse.DescribeNatGateways_NatGateway> describeNatGatewaysResponse_natGateways = new List<DescribeNatGatewaysResponse.DescribeNatGateways_NatGateway>();
			for (int i = 0; i < _ctx.Length("DescribeNatGateways.NatGateways.Length"); i++) {
				DescribeNatGatewaysResponse.DescribeNatGateways_NatGateway natGateway = new DescribeNatGatewaysResponse.DescribeNatGateways_NatGateway();
				natGateway.Status = _ctx.StringValue("DescribeNatGateways.NatGateways["+ i +"].Status");
				natGateway.CreationTime = _ctx.StringValue("DescribeNatGateways.NatGateways["+ i +"].CreationTime");
				natGateway.VpcId = _ctx.StringValue("DescribeNatGateways.NatGateways["+ i +"].VpcId");
				natGateway.NatType = _ctx.StringValue("DescribeNatGateways.NatGateways["+ i +"].NatType");
				natGateway.AutoPay = _ctx.BooleanValue("DescribeNatGateways.NatGateways["+ i +"].AutoPay");
				natGateway.Spec = _ctx.StringValue("DescribeNatGateways.NatGateways["+ i +"].Spec");
				natGateway.DeletionProtection = _ctx.BooleanValue("DescribeNatGateways.NatGateways["+ i +"].DeletionProtection");
				natGateway.NetworkType = _ctx.StringValue("DescribeNatGateways.NatGateways["+ i +"].NetworkType");
				natGateway.SecurityProtectionEnabled = _ctx.BooleanValue("DescribeNatGateways.NatGateways["+ i +"].SecurityProtectionEnabled");
				natGateway.InstanceChargeType = _ctx.StringValue("DescribeNatGateways.NatGateways["+ i +"].InstanceChargeType");
				natGateway.RegionId = _ctx.StringValue("DescribeNatGateways.NatGateways["+ i +"].RegionId");
				natGateway.EcsMetricEnabled = _ctx.BooleanValue("DescribeNatGateways.NatGateways["+ i +"].EcsMetricEnabled");
				natGateway.IcmpReplyEnabled = _ctx.BooleanValue("DescribeNatGateways.NatGateways["+ i +"].IcmpReplyEnabled");
				natGateway.Description = _ctx.StringValue("DescribeNatGateways.NatGateways["+ i +"].Description");
				natGateway.ExpiredTime = _ctx.StringValue("DescribeNatGateways.NatGateways["+ i +"].ExpiredTime");
				natGateway.ResourceGroupId = _ctx.StringValue("DescribeNatGateways.NatGateways["+ i +"].ResourceGroupId");
				natGateway.NatGatewayId = _ctx.StringValue("DescribeNatGateways.NatGateways["+ i +"].NatGatewayId");
				natGateway.InternetChargeType = _ctx.StringValue("DescribeNatGateways.NatGateways["+ i +"].InternetChargeType");
				natGateway.BusinessStatus = _ctx.StringValue("DescribeNatGateways.NatGateways["+ i +"].BusinessStatus");
				natGateway.Name = _ctx.StringValue("DescribeNatGateways.NatGateways["+ i +"].Name");
				natGateway.PrivateLinkEnabled = _ctx.BooleanValue("DescribeNatGateways.NatGateways["+ i +"].PrivateLinkEnabled");
				natGateway.PrivateLinkMode = _ctx.StringValue("DescribeNatGateways.NatGateways["+ i +"].PrivateLinkMode");

				List<string> natGateway_forwardTableIds = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeNatGateways.NatGateways["+ i +"].ForwardTableIds.Length"); j++) {
					natGateway_forwardTableIds.Add(_ctx.StringValue("DescribeNatGateways.NatGateways["+ i +"].ForwardTableIds["+ j +"]"));
				}
				natGateway.ForwardTableIds = natGateway_forwardTableIds;

				List<string> natGateway_snatTableIds = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeNatGateways.NatGateways["+ i +"].SnatTableIds.Length"); j++) {
					natGateway_snatTableIds.Add(_ctx.StringValue("DescribeNatGateways.NatGateways["+ i +"].SnatTableIds["+ j +"]"));
				}
				natGateway.SnatTableIds = natGateway_snatTableIds;

				List<string> natGateway_fullNatTableIds = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeNatGateways.NatGateways["+ i +"].FullNatTableIds.Length"); j++) {
					natGateway_fullNatTableIds.Add(_ctx.StringValue("DescribeNatGateways.NatGateways["+ i +"].FullNatTableIds["+ j +"]"));
				}
				natGateway.FullNatTableIds = natGateway_fullNatTableIds;

				List<string> natGateway_bandwidthPackageIds = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeNatGateways.NatGateways["+ i +"].BandwidthPackageIds.Length"); j++) {
					natGateway_bandwidthPackageIds.Add(_ctx.StringValue("DescribeNatGateways.NatGateways["+ i +"].BandwidthPackageIds["+ j +"]"));
				}
				natGateway.BandwidthPackageIds = natGateway_bandwidthPackageIds;

				DescribeNatGatewaysResponse.DescribeNatGateways_NatGateway.DescribeNatGateways_NatGatewayPrivateInfo natGatewayPrivateInfo = new DescribeNatGatewaysResponse.DescribeNatGateways_NatGateway.DescribeNatGateways_NatGatewayPrivateInfo();
				natGatewayPrivateInfo.VswitchId = _ctx.StringValue("DescribeNatGateways.NatGateways["+ i +"].NatGatewayPrivateInfo.VswitchId");
				natGatewayPrivateInfo.EniInstanceId = _ctx.StringValue("DescribeNatGateways.NatGateways["+ i +"].NatGatewayPrivateInfo.EniInstanceId");
				natGatewayPrivateInfo.MaxBandwidth = _ctx.IntegerValue("DescribeNatGateways.NatGateways["+ i +"].NatGatewayPrivateInfo.MaxBandwidth");
				natGatewayPrivateInfo.MaxSessionQuota = _ctx.IntegerValue("DescribeNatGateways.NatGateways["+ i +"].NatGatewayPrivateInfo.MaxSessionQuota");
				natGatewayPrivateInfo.MaxSessionEstablishRate = _ctx.IntegerValue("DescribeNatGateways.NatGateways["+ i +"].NatGatewayPrivateInfo.MaxSessionEstablishRate");
				natGatewayPrivateInfo.PrivateIpAddress = _ctx.StringValue("DescribeNatGateways.NatGateways["+ i +"].NatGatewayPrivateInfo.PrivateIpAddress");
				natGatewayPrivateInfo.IzNo = _ctx.StringValue("DescribeNatGateways.NatGateways["+ i +"].NatGatewayPrivateInfo.IzNo");
				natGatewayPrivateInfo.EniType = _ctx.StringValue("DescribeNatGateways.NatGateways["+ i +"].NatGatewayPrivateInfo.EniType");
				natGateway.NatGatewayPrivateInfo = natGatewayPrivateInfo;

				List<DescribeNatGatewaysResponse.DescribeNatGateways_NatGateway.DescribeNatGateways_IpList> natGateway_ipLists = new List<DescribeNatGatewaysResponse.DescribeNatGateways_NatGateway.DescribeNatGateways_IpList>();
				for (int j = 0; j < _ctx.Length("DescribeNatGateways.NatGateways["+ i +"].IpLists.Length"); j++) {
					DescribeNatGatewaysResponse.DescribeNatGateways_NatGateway.DescribeNatGateways_IpList ipList = new DescribeNatGatewaysResponse.DescribeNatGateways_NatGateway.DescribeNatGateways_IpList();
					ipList.UsingStatus = _ctx.StringValue("DescribeNatGateways.NatGateways["+ i +"].IpLists["+ j +"].UsingStatus");
					ipList.IpAddress = _ctx.StringValue("DescribeNatGateways.NatGateways["+ i +"].IpLists["+ j +"].IpAddress");
					ipList.SnatEntryEnabled = _ctx.BooleanValue("DescribeNatGateways.NatGateways["+ i +"].IpLists["+ j +"].SnatEntryEnabled");
					ipList.AllocationId = _ctx.StringValue("DescribeNatGateways.NatGateways["+ i +"].IpLists["+ j +"].AllocationId");
					ipList.ApAccessEnabled = _ctx.BooleanValue("DescribeNatGateways.NatGateways["+ i +"].IpLists["+ j +"].ApAccessEnabled");
					ipList.PrivateIpAddress = _ctx.StringValue("DescribeNatGateways.NatGateways["+ i +"].IpLists["+ j +"].PrivateIpAddress");

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
