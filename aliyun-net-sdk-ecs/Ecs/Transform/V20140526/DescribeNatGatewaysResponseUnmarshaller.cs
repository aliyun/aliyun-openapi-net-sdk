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
using Aliyun.Acs.Ecs.Model.V20140526;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeNatGatewaysResponseUnmarshaller
    {
        public static DescribeNatGatewaysResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeNatGatewaysResponse describeNatGatewaysResponse = new DescribeNatGatewaysResponse();

			describeNatGatewaysResponse.HttpResponse = _ctx.HttpResponse;
			describeNatGatewaysResponse.RequestId = _ctx.StringValue("DescribeNatGateways.RequestId");
			describeNatGatewaysResponse.TotalCount = _ctx.IntegerValue("DescribeNatGateways.TotalCount");
			describeNatGatewaysResponse.PageNumber = _ctx.IntegerValue("DescribeNatGateways.PageNumber");
			describeNatGatewaysResponse.PageSize = _ctx.IntegerValue("DescribeNatGateways.PageSize");

			List<DescribeNatGatewaysResponse.DescribeNatGateways_NatGateway> describeNatGatewaysResponse_natGateways = new List<DescribeNatGatewaysResponse.DescribeNatGateways_NatGateway>();
			for (int i = 0; i < _ctx.Length("DescribeNatGateways.NatGateways.Length"); i++) {
				DescribeNatGatewaysResponse.DescribeNatGateways_NatGateway natGateway = new DescribeNatGatewaysResponse.DescribeNatGateways_NatGateway();
				natGateway.NatGatewayId = _ctx.StringValue("DescribeNatGateways.NatGateways["+ i +"].NatGatewayId");
				natGateway.RegionId = _ctx.StringValue("DescribeNatGateways.NatGateways["+ i +"].RegionId");
				natGateway.Name = _ctx.StringValue("DescribeNatGateways.NatGateways["+ i +"].Name");
				natGateway.Description = _ctx.StringValue("DescribeNatGateways.NatGateways["+ i +"].Description");
				natGateway.VpcId = _ctx.StringValue("DescribeNatGateways.NatGateways["+ i +"].VpcId");
				natGateway.Spec = _ctx.StringValue("DescribeNatGateways.NatGateways["+ i +"].Spec");
				natGateway.InstanceChargeType = _ctx.StringValue("DescribeNatGateways.NatGateways["+ i +"].InstanceChargeType");
				natGateway.BusinessStatus = _ctx.StringValue("DescribeNatGateways.NatGateways["+ i +"].BusinessStatus");
				natGateway.CreationTime = _ctx.StringValue("DescribeNatGateways.NatGateways["+ i +"].CreationTime");
				natGateway.Status = _ctx.StringValue("DescribeNatGateways.NatGateways["+ i +"].Status");

				List<string> natGateway_forwardTableIds = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeNatGateways.NatGateways["+ i +"].ForwardTableIds.Length"); j++) {
					natGateway_forwardTableIds.Add(_ctx.StringValue("DescribeNatGateways.NatGateways["+ i +"].ForwardTableIds["+ j +"]"));
				}
				natGateway.ForwardTableIds = natGateway_forwardTableIds;

				List<string> natGateway_bandwidthPackageIds = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeNatGateways.NatGateways["+ i +"].BandwidthPackageIds.Length"); j++) {
					natGateway_bandwidthPackageIds.Add(_ctx.StringValue("DescribeNatGateways.NatGateways["+ i +"].BandwidthPackageIds["+ j +"]"));
				}
				natGateway.BandwidthPackageIds = natGateway_bandwidthPackageIds;

				describeNatGatewaysResponse_natGateways.Add(natGateway);
			}
			describeNatGatewaysResponse.NatGateways = describeNatGatewaysResponse_natGateways;
        
			return describeNatGatewaysResponse;
        }
    }
}
