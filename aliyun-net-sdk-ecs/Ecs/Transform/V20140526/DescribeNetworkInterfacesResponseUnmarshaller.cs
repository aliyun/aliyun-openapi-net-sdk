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
        public static DescribeNetworkInterfacesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeNetworkInterfacesResponse describeNetworkInterfacesResponse = new DescribeNetworkInterfacesResponse();

			describeNetworkInterfacesResponse.HttpResponse = context.HttpResponse;
			describeNetworkInterfacesResponse.RequestId = context.StringValue("DescribeNetworkInterfaces.RequestId");
			describeNetworkInterfacesResponse.TotalCount = context.IntegerValue("DescribeNetworkInterfaces.TotalCount");
			describeNetworkInterfacesResponse.PageNumber = context.IntegerValue("DescribeNetworkInterfaces.PageNumber");
			describeNetworkInterfacesResponse.PageSize = context.IntegerValue("DescribeNetworkInterfaces.PageSize");
			describeNetworkInterfacesResponse.NextToken = context.StringValue("DescribeNetworkInterfaces.NextToken");

			List<DescribeNetworkInterfacesResponse.DescribeNetworkInterfaces_NetworkInterfaceSet> describeNetworkInterfacesResponse_networkInterfaceSets = new List<DescribeNetworkInterfacesResponse.DescribeNetworkInterfaces_NetworkInterfaceSet>();
			for (int i = 0; i < context.Length("DescribeNetworkInterfaces.NetworkInterfaceSets.Length"); i++) {
				DescribeNetworkInterfacesResponse.DescribeNetworkInterfaces_NetworkInterfaceSet networkInterfaceSet = new DescribeNetworkInterfacesResponse.DescribeNetworkInterfaces_NetworkInterfaceSet();
				networkInterfaceSet.NetworkInterfaceId = context.StringValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].NetworkInterfaceId");
				networkInterfaceSet.Status = context.StringValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].Status");
				networkInterfaceSet.Type = context.StringValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].Type");
				networkInterfaceSet.VpcId = context.StringValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].VpcId");
				networkInterfaceSet.VSwitchId = context.StringValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].VSwitchId");
				networkInterfaceSet.ZoneId = context.StringValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].ZoneId");
				networkInterfaceSet.PrivateIpAddress = context.StringValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].PrivateIpAddress");
				networkInterfaceSet.MacAddress = context.StringValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].MacAddress");
				networkInterfaceSet.NetworkInterfaceName = context.StringValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].NetworkInterfaceName");
				networkInterfaceSet.Description = context.StringValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].Description");
				networkInterfaceSet.InstanceId = context.StringValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].InstanceId");
				networkInterfaceSet.CreationTime = context.StringValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].CreationTime");
				networkInterfaceSet.ResourceGroupId = context.StringValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].ResourceGroupId");
				networkInterfaceSet.ServiceID = context.LongValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].ServiceID");
				networkInterfaceSet.ServiceManaged = context.BooleanValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].ServiceManaged");
				networkInterfaceSet.QueueNumber = context.IntegerValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].QueueNumber");
				networkInterfaceSet.OwnerId = context.StringValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].OwnerId");

				List<string> networkInterfaceSet_securityGroupIds = new List<string>();
				for (int j = 0; j < context.Length("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].SecurityGroupIds.Length"); j++) {
					networkInterfaceSet_securityGroupIds.Add(context.StringValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].SecurityGroupIds["+ j +"]"));
				}
				networkInterfaceSet.SecurityGroupIds = networkInterfaceSet_securityGroupIds;

				DescribeNetworkInterfacesResponse.DescribeNetworkInterfaces_NetworkInterfaceSet.DescribeNetworkInterfaces_AssociatedPublicIp associatedPublicIp = new DescribeNetworkInterfacesResponse.DescribeNetworkInterfaces_NetworkInterfaceSet.DescribeNetworkInterfaces_AssociatedPublicIp();
				associatedPublicIp.PublicIpAddress = context.StringValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].AssociatedPublicIp.PublicIpAddress");
				associatedPublicIp.AllocationId = context.StringValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].AssociatedPublicIp.AllocationId");
				networkInterfaceSet.AssociatedPublicIp = associatedPublicIp;

				DescribeNetworkInterfacesResponse.DescribeNetworkInterfaces_NetworkInterfaceSet.DescribeNetworkInterfaces_Attachment attachment = new DescribeNetworkInterfacesResponse.DescribeNetworkInterfaces_NetworkInterfaceSet.DescribeNetworkInterfaces_Attachment();
				attachment.InstanceId = context.StringValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].Attachment.InstanceId");
				attachment.TrunkNetworkInterfaceId = context.StringValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].Attachment.TrunkNetworkInterfaceId");
				attachment.DeviceIndex = context.IntegerValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].Attachment.DeviceIndex");
				networkInterfaceSet.Attachment = attachment;

				List<DescribeNetworkInterfacesResponse.DescribeNetworkInterfaces_NetworkInterfaceSet.DescribeNetworkInterfaces_PrivateIpSet> networkInterfaceSet_privateIpSets = new List<DescribeNetworkInterfacesResponse.DescribeNetworkInterfaces_NetworkInterfaceSet.DescribeNetworkInterfaces_PrivateIpSet>();
				for (int j = 0; j < context.Length("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].PrivateIpSets.Length"); j++) {
					DescribeNetworkInterfacesResponse.DescribeNetworkInterfaces_NetworkInterfaceSet.DescribeNetworkInterfaces_PrivateIpSet privateIpSet = new DescribeNetworkInterfacesResponse.DescribeNetworkInterfaces_NetworkInterfaceSet.DescribeNetworkInterfaces_PrivateIpSet();
					privateIpSet.PrivateIpAddress = context.StringValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].PrivateIpSets["+ j +"].PrivateIpAddress");
					privateIpSet.Primary = context.BooleanValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].PrivateIpSets["+ j +"].Primary");

					DescribeNetworkInterfacesResponse.DescribeNetworkInterfaces_NetworkInterfaceSet.DescribeNetworkInterfaces_PrivateIpSet.DescribeNetworkInterfaces_AssociatedPublicIp1 associatedPublicIp1 = new DescribeNetworkInterfacesResponse.DescribeNetworkInterfaces_NetworkInterfaceSet.DescribeNetworkInterfaces_PrivateIpSet.DescribeNetworkInterfaces_AssociatedPublicIp1();
					associatedPublicIp1.PublicIpAddress = context.StringValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].PrivateIpSets["+ j +"].AssociatedPublicIp.PublicIpAddress");
					associatedPublicIp1.AllocationId = context.StringValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].PrivateIpSets["+ j +"].AssociatedPublicIp.AllocationId");
					privateIpSet.AssociatedPublicIp1 = associatedPublicIp1;

					networkInterfaceSet_privateIpSets.Add(privateIpSet);
				}
				networkInterfaceSet.PrivateIpSets = networkInterfaceSet_privateIpSets;

				List<DescribeNetworkInterfacesResponse.DescribeNetworkInterfaces_NetworkInterfaceSet.DescribeNetworkInterfaces_Ipv6Set> networkInterfaceSet_ipv6Sets = new List<DescribeNetworkInterfacesResponse.DescribeNetworkInterfaces_NetworkInterfaceSet.DescribeNetworkInterfaces_Ipv6Set>();
				for (int j = 0; j < context.Length("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].Ipv6Sets.Length"); j++) {
					DescribeNetworkInterfacesResponse.DescribeNetworkInterfaces_NetworkInterfaceSet.DescribeNetworkInterfaces_Ipv6Set ipv6Set = new DescribeNetworkInterfacesResponse.DescribeNetworkInterfaces_NetworkInterfaceSet.DescribeNetworkInterfaces_Ipv6Set();
					ipv6Set.Ipv6Address = context.StringValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].Ipv6Sets["+ j +"].Ipv6Address");

					networkInterfaceSet_ipv6Sets.Add(ipv6Set);
				}
				networkInterfaceSet.Ipv6Sets = networkInterfaceSet_ipv6Sets;

				List<DescribeNetworkInterfacesResponse.DescribeNetworkInterfaces_NetworkInterfaceSet.DescribeNetworkInterfaces_Tag> networkInterfaceSet_tags = new List<DescribeNetworkInterfacesResponse.DescribeNetworkInterfaces_NetworkInterfaceSet.DescribeNetworkInterfaces_Tag>();
				for (int j = 0; j < context.Length("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].Tags.Length"); j++) {
					DescribeNetworkInterfacesResponse.DescribeNetworkInterfaces_NetworkInterfaceSet.DescribeNetworkInterfaces_Tag tag = new DescribeNetworkInterfacesResponse.DescribeNetworkInterfaces_NetworkInterfaceSet.DescribeNetworkInterfaces_Tag();
					tag.TagKey = context.StringValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].Tags["+ j +"].TagKey");
					tag.TagValue = context.StringValue("DescribeNetworkInterfaces.NetworkInterfaceSets["+ i +"].Tags["+ j +"].TagValue");

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
