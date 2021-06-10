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
    public class DescribeVpcAttributeResponseUnmarshaller
    {
        public static DescribeVpcAttributeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVpcAttributeResponse describeVpcAttributeResponse = new DescribeVpcAttributeResponse();

			describeVpcAttributeResponse.HttpResponse = _ctx.HttpResponse;
			describeVpcAttributeResponse.RequestId = _ctx.StringValue("DescribeVpcAttribute.RequestId");
			describeVpcAttributeResponse.VpcId = _ctx.StringValue("DescribeVpcAttribute.VpcId");
			describeVpcAttributeResponse.RegionId = _ctx.StringValue("DescribeVpcAttribute.RegionId");
			describeVpcAttributeResponse.Status = _ctx.StringValue("DescribeVpcAttribute.Status");
			describeVpcAttributeResponse.VpcName = _ctx.StringValue("DescribeVpcAttribute.VpcName");
			describeVpcAttributeResponse.CreationTime = _ctx.StringValue("DescribeVpcAttribute.CreationTime");
			describeVpcAttributeResponse.CidrBlock = _ctx.StringValue("DescribeVpcAttribute.CidrBlock");
			describeVpcAttributeResponse.Ipv6CidrBlock = _ctx.StringValue("DescribeVpcAttribute.Ipv6CidrBlock");
			describeVpcAttributeResponse.VRouterId = _ctx.StringValue("DescribeVpcAttribute.VRouterId");
			describeVpcAttributeResponse.Description = _ctx.StringValue("DescribeVpcAttribute.Description");
			describeVpcAttributeResponse.IsDefault = _ctx.BooleanValue("DescribeVpcAttribute.IsDefault");
			describeVpcAttributeResponse.ClassicLinkEnabled = _ctx.BooleanValue("DescribeVpcAttribute.ClassicLinkEnabled");
			describeVpcAttributeResponse.ResourceGroupId = _ctx.StringValue("DescribeVpcAttribute.ResourceGroupId");
			describeVpcAttributeResponse.NetworkAclNum = _ctx.StringValue("DescribeVpcAttribute.NetworkAclNum");
			describeVpcAttributeResponse.OwnerId = _ctx.LongValue("DescribeVpcAttribute.OwnerId");
			describeVpcAttributeResponse.DhcpOptionsSetId = _ctx.StringValue("DescribeVpcAttribute.DhcpOptionsSetId");
			describeVpcAttributeResponse.DhcpOptionsSetStatus = _ctx.StringValue("DescribeVpcAttribute.DhcpOptionsSetStatus");

			List<string> describeVpcAttributeResponse_vSwitchIds = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeVpcAttribute.VSwitchIds.Length"); i++) {
				describeVpcAttributeResponse_vSwitchIds.Add(_ctx.StringValue("DescribeVpcAttribute.VSwitchIds["+ i +"]"));
			}
			describeVpcAttributeResponse.VSwitchIds = describeVpcAttributeResponse_vSwitchIds;

			List<string> describeVpcAttributeResponse_userCidrs = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeVpcAttribute.UserCidrs.Length"); i++) {
				describeVpcAttributeResponse_userCidrs.Add(_ctx.StringValue("DescribeVpcAttribute.UserCidrs["+ i +"]"));
			}
			describeVpcAttributeResponse.UserCidrs = describeVpcAttributeResponse_userCidrs;

			List<string> describeVpcAttributeResponse_secondaryCidrBlocks = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeVpcAttribute.SecondaryCidrBlocks.Length"); i++) {
				describeVpcAttributeResponse_secondaryCidrBlocks.Add(_ctx.StringValue("DescribeVpcAttribute.SecondaryCidrBlocks["+ i +"]"));
			}
			describeVpcAttributeResponse.SecondaryCidrBlocks = describeVpcAttributeResponse_secondaryCidrBlocks;

			List<DescribeVpcAttributeResponse.DescribeVpcAttribute_AssociatedCen> describeVpcAttributeResponse_associatedCens = new List<DescribeVpcAttributeResponse.DescribeVpcAttribute_AssociatedCen>();
			for (int i = 0; i < _ctx.Length("DescribeVpcAttribute.AssociatedCens.Length"); i++) {
				DescribeVpcAttributeResponse.DescribeVpcAttribute_AssociatedCen associatedCen = new DescribeVpcAttributeResponse.DescribeVpcAttribute_AssociatedCen();
				associatedCen.CenId = _ctx.StringValue("DescribeVpcAttribute.AssociatedCens["+ i +"].CenId");
				associatedCen.CenOwnerId = _ctx.LongValue("DescribeVpcAttribute.AssociatedCens["+ i +"].CenOwnerId");
				associatedCen.CenStatus = _ctx.StringValue("DescribeVpcAttribute.AssociatedCens["+ i +"].CenStatus");

				describeVpcAttributeResponse_associatedCens.Add(associatedCen);
			}
			describeVpcAttributeResponse.AssociatedCens = describeVpcAttributeResponse_associatedCens;

			List<DescribeVpcAttributeResponse.DescribeVpcAttribute_CloudResourceSetType> describeVpcAttributeResponse_cloudResources = new List<DescribeVpcAttributeResponse.DescribeVpcAttribute_CloudResourceSetType>();
			for (int i = 0; i < _ctx.Length("DescribeVpcAttribute.CloudResources.Length"); i++) {
				DescribeVpcAttributeResponse.DescribeVpcAttribute_CloudResourceSetType cloudResourceSetType = new DescribeVpcAttributeResponse.DescribeVpcAttribute_CloudResourceSetType();
				cloudResourceSetType.ResourceType = _ctx.StringValue("DescribeVpcAttribute.CloudResources["+ i +"].ResourceType");
				cloudResourceSetType.ResourceCount = _ctx.IntegerValue("DescribeVpcAttribute.CloudResources["+ i +"].ResourceCount");

				describeVpcAttributeResponse_cloudResources.Add(cloudResourceSetType);
			}
			describeVpcAttributeResponse.CloudResources = describeVpcAttributeResponse_cloudResources;

			List<DescribeVpcAttributeResponse.DescribeVpcAttribute_Ipv6CidrBlock> describeVpcAttributeResponse_ipv6CidrBlocks = new List<DescribeVpcAttributeResponse.DescribeVpcAttribute_Ipv6CidrBlock>();
			for (int i = 0; i < _ctx.Length("DescribeVpcAttribute.Ipv6CidrBlocks.Length"); i++) {
				DescribeVpcAttributeResponse.DescribeVpcAttribute_Ipv6CidrBlock ipv6CidrBlock = new DescribeVpcAttributeResponse.DescribeVpcAttribute_Ipv6CidrBlock();
				ipv6CidrBlock.Ipv6CidrBlock = _ctx.StringValue("DescribeVpcAttribute.Ipv6CidrBlocks["+ i +"].Ipv6CidrBlock");
				ipv6CidrBlock.Ipv6Isp = _ctx.StringValue("DescribeVpcAttribute.Ipv6CidrBlocks["+ i +"].Ipv6Isp");

				describeVpcAttributeResponse_ipv6CidrBlocks.Add(ipv6CidrBlock);
			}
			describeVpcAttributeResponse.Ipv6CidrBlocks = describeVpcAttributeResponse_ipv6CidrBlocks;
        
			return describeVpcAttributeResponse;
        }
    }
}
