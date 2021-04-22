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
    public class DescribeNetworkInterfaceAttributeResponseUnmarshaller
    {
        public static DescribeNetworkInterfaceAttributeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeNetworkInterfaceAttributeResponse describeNetworkInterfaceAttributeResponse = new DescribeNetworkInterfaceAttributeResponse();

			describeNetworkInterfaceAttributeResponse.HttpResponse = _ctx.HttpResponse;
			describeNetworkInterfaceAttributeResponse.RequestId = _ctx.StringValue("DescribeNetworkInterfaceAttribute.RequestId");
			describeNetworkInterfaceAttributeResponse.NetworkInterfaceId = _ctx.StringValue("DescribeNetworkInterfaceAttribute.NetworkInterfaceId");
			describeNetworkInterfaceAttributeResponse.Status = _ctx.StringValue("DescribeNetworkInterfaceAttribute.Status");
			describeNetworkInterfaceAttributeResponse.Type = _ctx.StringValue("DescribeNetworkInterfaceAttribute.Type");
			describeNetworkInterfaceAttributeResponse.VpcId = _ctx.StringValue("DescribeNetworkInterfaceAttribute.VpcId");
			describeNetworkInterfaceAttributeResponse.VSwitchId = _ctx.StringValue("DescribeNetworkInterfaceAttribute.VSwitchId");
			describeNetworkInterfaceAttributeResponse.ZoneId = _ctx.StringValue("DescribeNetworkInterfaceAttribute.ZoneId");
			describeNetworkInterfaceAttributeResponse.PrivateIpAddress = _ctx.StringValue("DescribeNetworkInterfaceAttribute.PrivateIpAddress");
			describeNetworkInterfaceAttributeResponse.MacAddress = _ctx.StringValue("DescribeNetworkInterfaceAttribute.MacAddress");
			describeNetworkInterfaceAttributeResponse.NetworkInterfaceName = _ctx.StringValue("DescribeNetworkInterfaceAttribute.NetworkInterfaceName");
			describeNetworkInterfaceAttributeResponse.Description = _ctx.StringValue("DescribeNetworkInterfaceAttribute.Description");
			describeNetworkInterfaceAttributeResponse.InstanceId = _ctx.StringValue("DescribeNetworkInterfaceAttribute.InstanceId");
			describeNetworkInterfaceAttributeResponse.CreationTime = _ctx.StringValue("DescribeNetworkInterfaceAttribute.CreationTime");
			describeNetworkInterfaceAttributeResponse.ResourceGroupId = _ctx.StringValue("DescribeNetworkInterfaceAttribute.ResourceGroupId");
			describeNetworkInterfaceAttributeResponse.ServiceID = _ctx.LongValue("DescribeNetworkInterfaceAttribute.ServiceID");
			describeNetworkInterfaceAttributeResponse.ServiceManaged = _ctx.BooleanValue("DescribeNetworkInterfaceAttribute.ServiceManaged");
			describeNetworkInterfaceAttributeResponse.QueueNumber = _ctx.IntegerValue("DescribeNetworkInterfaceAttribute.QueueNumber");
			describeNetworkInterfaceAttributeResponse.OwnerId = _ctx.StringValue("DescribeNetworkInterfaceAttribute.OwnerId");
			describeNetworkInterfaceAttributeResponse.NetworkInterfaceTrafficMode = _ctx.StringValue("DescribeNetworkInterfaceAttribute.NetworkInterfaceTrafficMode");
			describeNetworkInterfaceAttributeResponse.QueuePairNumber = _ctx.IntegerValue("DescribeNetworkInterfaceAttribute.QueuePairNumber");

			List<string> describeNetworkInterfaceAttributeResponse_securityGroupIds = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeNetworkInterfaceAttribute.SecurityGroupIds.Length"); i++) {
				describeNetworkInterfaceAttributeResponse_securityGroupIds.Add(_ctx.StringValue("DescribeNetworkInterfaceAttribute.SecurityGroupIds["+ i +"]"));
			}
			describeNetworkInterfaceAttributeResponse.SecurityGroupIds = describeNetworkInterfaceAttributeResponse_securityGroupIds;

			DescribeNetworkInterfaceAttributeResponse.DescribeNetworkInterfaceAttribute_AssociatedPublicIp associatedPublicIp = new DescribeNetworkInterfaceAttributeResponse.DescribeNetworkInterfaceAttribute_AssociatedPublicIp();
			associatedPublicIp.PublicIpAddress = _ctx.StringValue("DescribeNetworkInterfaceAttribute.AssociatedPublicIp.PublicIpAddress");
			associatedPublicIp.AllocationId = _ctx.StringValue("DescribeNetworkInterfaceAttribute.AssociatedPublicIp.AllocationId");
			describeNetworkInterfaceAttributeResponse.AssociatedPublicIp = associatedPublicIp;

			DescribeNetworkInterfaceAttributeResponse.DescribeNetworkInterfaceAttribute_Attachment attachment = new DescribeNetworkInterfaceAttributeResponse.DescribeNetworkInterfaceAttribute_Attachment();
			attachment.InstanceId = _ctx.StringValue("DescribeNetworkInterfaceAttribute.Attachment.InstanceId");
			attachment.TrunkNetworkInterfaceId = _ctx.StringValue("DescribeNetworkInterfaceAttribute.Attachment.TrunkNetworkInterfaceId");
			attachment.DeviceIndex = _ctx.IntegerValue("DescribeNetworkInterfaceAttribute.Attachment.DeviceIndex");

			List<string> attachment_memberNetworkInterfaceIds = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeNetworkInterfaceAttribute.Attachment.MemberNetworkInterfaceIds.Length"); i++) {
				attachment_memberNetworkInterfaceIds.Add(_ctx.StringValue("DescribeNetworkInterfaceAttribute.Attachment.MemberNetworkInterfaceIds["+ i +"]"));
			}
			attachment.MemberNetworkInterfaceIds = attachment_memberNetworkInterfaceIds;
			describeNetworkInterfaceAttributeResponse.Attachment = attachment;

			List<DescribeNetworkInterfaceAttributeResponse.DescribeNetworkInterfaceAttribute_PrivateIpSet> describeNetworkInterfaceAttributeResponse_privateIpSets = new List<DescribeNetworkInterfaceAttributeResponse.DescribeNetworkInterfaceAttribute_PrivateIpSet>();
			for (int i = 0; i < _ctx.Length("DescribeNetworkInterfaceAttribute.PrivateIpSets.Length"); i++) {
				DescribeNetworkInterfaceAttributeResponse.DescribeNetworkInterfaceAttribute_PrivateIpSet privateIpSet = new DescribeNetworkInterfaceAttributeResponse.DescribeNetworkInterfaceAttribute_PrivateIpSet();
				privateIpSet.PrivateIpAddress = _ctx.StringValue("DescribeNetworkInterfaceAttribute.PrivateIpSets["+ i +"].PrivateIpAddress");
				privateIpSet.Primary = _ctx.BooleanValue("DescribeNetworkInterfaceAttribute.PrivateIpSets["+ i +"].Primary");

				DescribeNetworkInterfaceAttributeResponse.DescribeNetworkInterfaceAttribute_PrivateIpSet.DescribeNetworkInterfaceAttribute_AssociatedPublicIp1 associatedPublicIp1 = new DescribeNetworkInterfaceAttributeResponse.DescribeNetworkInterfaceAttribute_PrivateIpSet.DescribeNetworkInterfaceAttribute_AssociatedPublicIp1();
				associatedPublicIp1.PublicIpAddress = _ctx.StringValue("DescribeNetworkInterfaceAttribute.PrivateIpSets["+ i +"].AssociatedPublicIp.PublicIpAddress");
				associatedPublicIp1.AllocationId = _ctx.StringValue("DescribeNetworkInterfaceAttribute.PrivateIpSets["+ i +"].AssociatedPublicIp.AllocationId");
				privateIpSet.AssociatedPublicIp1 = associatedPublicIp1;

				describeNetworkInterfaceAttributeResponse_privateIpSets.Add(privateIpSet);
			}
			describeNetworkInterfaceAttributeResponse.PrivateIpSets = describeNetworkInterfaceAttributeResponse_privateIpSets;

			List<DescribeNetworkInterfaceAttributeResponse.DescribeNetworkInterfaceAttribute_Ipv6Set> describeNetworkInterfaceAttributeResponse_ipv6Sets = new List<DescribeNetworkInterfaceAttributeResponse.DescribeNetworkInterfaceAttribute_Ipv6Set>();
			for (int i = 0; i < _ctx.Length("DescribeNetworkInterfaceAttribute.Ipv6Sets.Length"); i++) {
				DescribeNetworkInterfaceAttributeResponse.DescribeNetworkInterfaceAttribute_Ipv6Set ipv6Set = new DescribeNetworkInterfaceAttributeResponse.DescribeNetworkInterfaceAttribute_Ipv6Set();
				ipv6Set.Ipv6Address = _ctx.StringValue("DescribeNetworkInterfaceAttribute.Ipv6Sets["+ i +"].Ipv6Address");

				describeNetworkInterfaceAttributeResponse_ipv6Sets.Add(ipv6Set);
			}
			describeNetworkInterfaceAttributeResponse.Ipv6Sets = describeNetworkInterfaceAttributeResponse_ipv6Sets;

			List<DescribeNetworkInterfaceAttributeResponse.DescribeNetworkInterfaceAttribute_Tag> describeNetworkInterfaceAttributeResponse_tags = new List<DescribeNetworkInterfaceAttributeResponse.DescribeNetworkInterfaceAttribute_Tag>();
			for (int i = 0; i < _ctx.Length("DescribeNetworkInterfaceAttribute.Tags.Length"); i++) {
				DescribeNetworkInterfaceAttributeResponse.DescribeNetworkInterfaceAttribute_Tag tag = new DescribeNetworkInterfaceAttributeResponse.DescribeNetworkInterfaceAttribute_Tag();
				tag.TagKey = _ctx.StringValue("DescribeNetworkInterfaceAttribute.Tags["+ i +"].TagKey");
				tag.TagValue = _ctx.StringValue("DescribeNetworkInterfaceAttribute.Tags["+ i +"].TagValue");

				describeNetworkInterfaceAttributeResponse_tags.Add(tag);
			}
			describeNetworkInterfaceAttributeResponse.Tags = describeNetworkInterfaceAttributeResponse_tags;
        
			return describeNetworkInterfaceAttributeResponse;
        }
    }
}
