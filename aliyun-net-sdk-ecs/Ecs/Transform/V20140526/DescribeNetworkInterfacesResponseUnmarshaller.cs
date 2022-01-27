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
    public class DescribeNetworkInterfacesResponseUnmarshaller
    {
        public static DescribeNetworkInterfacesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeNetworkInterfacesResponse describeNetworkInterfacesResponse = new DescribeNetworkInterfacesResponse();

			describeNetworkInterfacesResponse.HttpResponse = _ctx.HttpResponse;
			describeNetworkInterfacesResponse.NextToken = _ctx.StringValue("DescribeNetworkInterfaces.NextToken");
			describeNetworkInterfacesResponse.PageSize = _ctx.IntegerValue("DescribeNetworkInterfaces.PageSize");
			describeNetworkInterfacesResponse.PageNumber = _ctx.IntegerValue("DescribeNetworkInterfaces.PageNumber");
			describeNetworkInterfacesResponse.RequestId = _ctx.StringValue("DescribeNetworkInterfaces.RequestId");
			describeNetworkInterfacesResponse.TotalCount = _ctx.IntegerValue("DescribeNetworkInterfaces.TotalCount");

			List<DescribeNetworkInterfacesResponse.DescribeNetworkInterfaces_NetworkInterfaceSet> describeNetworkInterfacesResponse_networkInterfaceSets = new List<DescribeNetworkInterfacesResponse.DescribeNetworkInterfaces_NetworkInterfaceSet>();
			for (int i = 0; i < _ctx.Length("DescribeNetworkInterfaces.NetworkInterfaceSets.Length"); i++) {
				DescribeNetworkInterfacesResponse.DescribeNetworkInterfaces_NetworkInterfaceSet networkInterfaceSet = new DescribeNetworkInterfacesResponse.DescribeNetworkInterfaces_NetworkInterfaceSet();
				networkInterfaceSet.CreationTime = _ctx.StringValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].CreationTime");
				networkInterfaceSet.VpcId = _ctx.StringValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].VpcId");
				networkInterfaceSet.Type = _ctx.StringValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].Type");
				networkInterfaceSet.Status = _ctx.StringValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].Status");
				networkInterfaceSet.NetworkInterfaceTrafficMode = _ctx.StringValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].NetworkInterfaceTrafficMode");
				networkInterfaceSet.NetworkInterfaceName = _ctx.StringValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].NetworkInterfaceName");
				networkInterfaceSet.MacAddress = _ctx.StringValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].MacAddress");
				networkInterfaceSet.QueuePairNumber = _ctx.IntegerValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].QueuePairNumber");
				networkInterfaceSet.NetworkInterfaceId = _ctx.StringValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].NetworkInterfaceId");
				networkInterfaceSet.ServiceID = _ctx.LongValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].ServiceID");
				networkInterfaceSet.InstanceId = _ctx.StringValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].InstanceId");
				networkInterfaceSet.OwnerId = _ctx.StringValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].OwnerId");
				networkInterfaceSet.ServiceManaged = _ctx.BooleanValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].ServiceManaged");
				networkInterfaceSet.VSwitchId = _ctx.StringValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].VSwitchId");
				networkInterfaceSet.Description = _ctx.StringValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].Description");
				networkInterfaceSet.ResourceGroupId = _ctx.StringValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].ResourceGroupId");
				networkInterfaceSet.ZoneId = _ctx.StringValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].ZoneId");
				networkInterfaceSet.PrivateIpAddress = _ctx.StringValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].PrivateIpAddress");
				networkInterfaceSet.QueueNumber = _ctx.IntegerValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].QueueNumber");

				List<string> networkInterfaceSet_securityGroupIds = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].SecurityGroupIds.Length"); j++) {
					networkInterfaceSet_securityGroupIds.Add(_ctx.StringValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].SecurityGroupIds["+ j +"]"));
				}
				networkInterfaceSet.SecurityGroupIds = networkInterfaceSet_securityGroupIds;

				DescribeNetworkInterfacesResponse.DescribeNetworkInterfaces_NetworkInterfaceSet.DescribeNetworkInterfaces_AssociatedPublicIp associatedPublicIp = new DescribeNetworkInterfacesResponse.DescribeNetworkInterfaces_NetworkInterfaceSet.DescribeNetworkInterfaces_AssociatedPublicIp();
				associatedPublicIp.PublicIpAddress = _ctx.StringValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].AssociatedPublicIp.PublicIpAddress");
				associatedPublicIp.AllocationId = _ctx.StringValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].AssociatedPublicIp.AllocationId");
				networkInterfaceSet.AssociatedPublicIp = associatedPublicIp;

				DescribeNetworkInterfacesResponse.DescribeNetworkInterfaces_NetworkInterfaceSet.DescribeNetworkInterfaces_Attachment attachment = new DescribeNetworkInterfacesResponse.DescribeNetworkInterfaces_NetworkInterfaceSet.DescribeNetworkInterfaces_Attachment();
				attachment.DeviceIndex = _ctx.IntegerValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].Attachment.DeviceIndex");
				attachment.InstanceId = _ctx.StringValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].Attachment.InstanceId");
				attachment.TrunkNetworkInterfaceId = _ctx.StringValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].Attachment.TrunkNetworkInterfaceId");
				networkInterfaceSet.Attachment = attachment;

				List<DescribeNetworkInterfacesResponse.DescribeNetworkInterfaces_NetworkInterfaceSet.DescribeNetworkInterfaces_PrivateIpSet> networkInterfaceSet_privateIpSets = new List<DescribeNetworkInterfacesResponse.DescribeNetworkInterfaces_NetworkInterfaceSet.DescribeNetworkInterfaces_PrivateIpSet>();
				for (int j = 0; j < _ctx.Length("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].PrivateIpSets.Length"); j++) {
					DescribeNetworkInterfacesResponse.DescribeNetworkInterfaces_NetworkInterfaceSet.DescribeNetworkInterfaces_PrivateIpSet privateIpSet = new DescribeNetworkInterfacesResponse.DescribeNetworkInterfaces_NetworkInterfaceSet.DescribeNetworkInterfaces_PrivateIpSet();
					privateIpSet.PrivateIpAddress = _ctx.StringValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].PrivateIpSets["+ j +"].PrivateIpAddress");
					privateIpSet.Primary = _ctx.BooleanValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].PrivateIpSets["+ j +"].Primary");

					DescribeNetworkInterfacesResponse.DescribeNetworkInterfaces_NetworkInterfaceSet.DescribeNetworkInterfaces_PrivateIpSet.DescribeNetworkInterfaces_AssociatedPublicIp1 associatedPublicIp1 = new DescribeNetworkInterfacesResponse.DescribeNetworkInterfaces_NetworkInterfaceSet.DescribeNetworkInterfaces_PrivateIpSet.DescribeNetworkInterfaces_AssociatedPublicIp1();
					associatedPublicIp1.PublicIpAddress = _ctx.StringValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].PrivateIpSets["+ j +"].AssociatedPublicIp.PublicIpAddress");
					associatedPublicIp1.AllocationId = _ctx.StringValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].PrivateIpSets["+ j +"].AssociatedPublicIp.AllocationId");
					privateIpSet.AssociatedPublicIp1 = associatedPublicIp1;

					networkInterfaceSet_privateIpSets.Add(privateIpSet);
				}
				networkInterfaceSet.PrivateIpSets = networkInterfaceSet_privateIpSets;

				List<DescribeNetworkInterfacesResponse.DescribeNetworkInterfaces_NetworkInterfaceSet.DescribeNetworkInterfaces_Ipv6Set> networkInterfaceSet_ipv6Sets = new List<DescribeNetworkInterfacesResponse.DescribeNetworkInterfaces_NetworkInterfaceSet.DescribeNetworkInterfaces_Ipv6Set>();
				for (int j = 0; j < _ctx.Length("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].Ipv6Sets.Length"); j++) {
					DescribeNetworkInterfacesResponse.DescribeNetworkInterfaces_NetworkInterfaceSet.DescribeNetworkInterfaces_Ipv6Set ipv6Set = new DescribeNetworkInterfacesResponse.DescribeNetworkInterfaces_NetworkInterfaceSet.DescribeNetworkInterfaces_Ipv6Set();
					ipv6Set.Ipv6Address = _ctx.StringValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].Ipv6Sets["+ j +"].Ipv6Address");

					networkInterfaceSet_ipv6Sets.Add(ipv6Set);
				}
				networkInterfaceSet.Ipv6Sets = networkInterfaceSet_ipv6Sets;

				List<DescribeNetworkInterfacesResponse.DescribeNetworkInterfaces_NetworkInterfaceSet.DescribeNetworkInterfaces_Tag> networkInterfaceSet_tags = new List<DescribeNetworkInterfacesResponse.DescribeNetworkInterfaces_NetworkInterfaceSet.DescribeNetworkInterfaces_Tag>();
				for (int j = 0; j < _ctx.Length("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].Tags.Length"); j++) {
					DescribeNetworkInterfacesResponse.DescribeNetworkInterfaces_NetworkInterfaceSet.DescribeNetworkInterfaces_Tag tag = new DescribeNetworkInterfacesResponse.DescribeNetworkInterfaces_NetworkInterfaceSet.DescribeNetworkInterfaces_Tag();
					tag.TagValue = _ctx.StringValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].Tags["+ j +"].TagValue");
					tag.TagKey = _ctx.StringValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].Tags["+ j +"].TagKey");

					networkInterfaceSet_tags.Add(tag);
				}
				networkInterfaceSet.Tags = networkInterfaceSet_tags;

				describeNetworkInterfacesResponse_networkInterfaceSets.Add(networkInterfaceSet);
			}
			describeNetworkInterfacesResponse.NetworkInterfaceSets = describeNetworkInterfacesResponse_networkInterfaceSets;
        
			return describeNetworkInterfacesResponse;
        }
    }
}
