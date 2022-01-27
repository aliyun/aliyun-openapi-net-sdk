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
    public class DescribeVpcsResponseUnmarshaller
    {
        public static DescribeVpcsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVpcsResponse describeVpcsResponse = new DescribeVpcsResponse();

			describeVpcsResponse.HttpResponse = _ctx.HttpResponse;
			describeVpcsResponse.RequestId = _ctx.StringValue("DescribeVpcs.RequestId");
			describeVpcsResponse.TotalCount = _ctx.IntegerValue("DescribeVpcs.TotalCount");
			describeVpcsResponse.PageNumber = _ctx.IntegerValue("DescribeVpcs.PageNumber");
			describeVpcsResponse.PageSize = _ctx.IntegerValue("DescribeVpcs.PageSize");

			List<DescribeVpcsResponse.DescribeVpcs_Vpc> describeVpcsResponse_vpcs = new List<DescribeVpcsResponse.DescribeVpcs_Vpc>();
			for (int i = 0; i < _ctx.Length("DescribeVpcs.Vpcs.Length"); i++) {
				DescribeVpcsResponse.DescribeVpcs_Vpc vpc = new DescribeVpcsResponse.DescribeVpcs_Vpc();
				vpc.VpcId = _ctx.StringValue("DescribeVpcs.Vpcs["+ i +"].VpcId");
				vpc.RegionId = _ctx.StringValue("DescribeVpcs.Vpcs["+ i +"].RegionId");
				vpc.Status = _ctx.StringValue("DescribeVpcs.Vpcs["+ i +"].Status");
				vpc.VpcName = _ctx.StringValue("DescribeVpcs.Vpcs["+ i +"].VpcName");
				vpc.CreationTime = _ctx.StringValue("DescribeVpcs.Vpcs["+ i +"].CreationTime");
				vpc.CidrBlock = _ctx.StringValue("DescribeVpcs.Vpcs["+ i +"].CidrBlock");
				vpc.Ipv6CidrBlock = _ctx.StringValue("DescribeVpcs.Vpcs["+ i +"].Ipv6CidrBlock");
				vpc.VRouterId = _ctx.StringValue("DescribeVpcs.Vpcs["+ i +"].VRouterId");
				vpc.Description = _ctx.StringValue("DescribeVpcs.Vpcs["+ i +"].Description");
				vpc.IsDefault = _ctx.BooleanValue("DescribeVpcs.Vpcs["+ i +"].IsDefault");
				vpc.NetworkAclNum = _ctx.StringValue("DescribeVpcs.Vpcs["+ i +"].NetworkAclNum");
				vpc.ResourceGroupId = _ctx.StringValue("DescribeVpcs.Vpcs["+ i +"].ResourceGroupId");
				vpc.CenStatus = _ctx.StringValue("DescribeVpcs.Vpcs["+ i +"].CenStatus");
				vpc.OwnerId = _ctx.LongValue("DescribeVpcs.Vpcs["+ i +"].OwnerId");
				vpc.SupportAdvancedFeature = _ctx.BooleanValue("DescribeVpcs.Vpcs["+ i +"].SupportAdvancedFeature");
				vpc.AdvancedResource = _ctx.BooleanValue("DescribeVpcs.Vpcs["+ i +"].AdvancedResource");
				vpc.DhcpOptionsSetId = _ctx.StringValue("DescribeVpcs.Vpcs["+ i +"].DhcpOptionsSetId");
				vpc.DhcpOptionsSetStatus = _ctx.StringValue("DescribeVpcs.Vpcs["+ i +"].DhcpOptionsSetStatus");

				List<string> vpc_vSwitchIds = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeVpcs.Vpcs["+ i +"].VSwitchIds.Length"); j++) {
					vpc_vSwitchIds.Add(_ctx.StringValue("DescribeVpcs.Vpcs["+ i +"].VSwitchIds["+ j +"]"));
				}
				vpc.VSwitchIds = vpc_vSwitchIds;

				List<string> vpc_userCidrs = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeVpcs.Vpcs["+ i +"].UserCidrs.Length"); j++) {
					vpc_userCidrs.Add(_ctx.StringValue("DescribeVpcs.Vpcs["+ i +"].UserCidrs["+ j +"]"));
				}
				vpc.UserCidrs = vpc_userCidrs;

				List<string> vpc_natGatewayIds = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeVpcs.Vpcs["+ i +"].NatGatewayIds.Length"); j++) {
					vpc_natGatewayIds.Add(_ctx.StringValue("DescribeVpcs.Vpcs["+ i +"].NatGatewayIds["+ j +"]"));
				}
				vpc.NatGatewayIds = vpc_natGatewayIds;

				List<string> vpc_routerTableIds = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeVpcs.Vpcs["+ i +"].RouterTableIds.Length"); j++) {
					vpc_routerTableIds.Add(_ctx.StringValue("DescribeVpcs.Vpcs["+ i +"].RouterTableIds["+ j +"]"));
				}
				vpc.RouterTableIds = vpc_routerTableIds;

				List<string> vpc_secondaryCidrBlocks = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeVpcs.Vpcs["+ i +"].SecondaryCidrBlocks.Length"); j++) {
					vpc_secondaryCidrBlocks.Add(_ctx.StringValue("DescribeVpcs.Vpcs["+ i +"].SecondaryCidrBlocks["+ j +"]"));
				}
				vpc.SecondaryCidrBlocks = vpc_secondaryCidrBlocks;

				List<DescribeVpcsResponse.DescribeVpcs_Vpc.DescribeVpcs_Tag> vpc_tags = new List<DescribeVpcsResponse.DescribeVpcs_Vpc.DescribeVpcs_Tag>();
				for (int j = 0; j < _ctx.Length("DescribeVpcs.Vpcs["+ i +"].Tags.Length"); j++) {
					DescribeVpcsResponse.DescribeVpcs_Vpc.DescribeVpcs_Tag tag = new DescribeVpcsResponse.DescribeVpcs_Vpc.DescribeVpcs_Tag();
					tag.Key = _ctx.StringValue("DescribeVpcs.Vpcs["+ i +"].Tags["+ j +"].Key");
					tag._Value = _ctx.StringValue("DescribeVpcs.Vpcs["+ i +"].Tags["+ j +"].Value");

					vpc_tags.Add(tag);
				}
				vpc.Tags = vpc_tags;

				List<DescribeVpcsResponse.DescribeVpcs_Vpc.DescribeVpcs_Ipv6CidrBlock> vpc_ipv6CidrBlocks = new List<DescribeVpcsResponse.DescribeVpcs_Vpc.DescribeVpcs_Ipv6CidrBlock>();
				for (int j = 0; j < _ctx.Length("DescribeVpcs.Vpcs["+ i +"].Ipv6CidrBlocks.Length"); j++) {
					DescribeVpcsResponse.DescribeVpcs_Vpc.DescribeVpcs_Ipv6CidrBlock ipv6CidrBlock = new DescribeVpcsResponse.DescribeVpcs_Vpc.DescribeVpcs_Ipv6CidrBlock();
					ipv6CidrBlock.Ipv6CidrBlock = _ctx.StringValue("DescribeVpcs.Vpcs["+ i +"].Ipv6CidrBlocks["+ j +"].Ipv6CidrBlock");
					ipv6CidrBlock.Ipv6Isp = _ctx.StringValue("DescribeVpcs.Vpcs["+ i +"].Ipv6CidrBlocks["+ j +"].Ipv6Isp");

					vpc_ipv6CidrBlocks.Add(ipv6CidrBlock);
				}
				vpc.Ipv6CidrBlocks = vpc_ipv6CidrBlocks;

				describeVpcsResponse_vpcs.Add(vpc);
			}
			describeVpcsResponse.Vpcs = describeVpcsResponse_vpcs;
        
			return describeVpcsResponse;
        }
    }
}
