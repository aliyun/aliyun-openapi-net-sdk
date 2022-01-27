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
    public class DescribeNetworkAclAttributesResponseUnmarshaller
    {
        public static DescribeNetworkAclAttributesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeNetworkAclAttributesResponse describeNetworkAclAttributesResponse = new DescribeNetworkAclAttributesResponse();

			describeNetworkAclAttributesResponse.HttpResponse = _ctx.HttpResponse;
			describeNetworkAclAttributesResponse.RequestId = _ctx.StringValue("DescribeNetworkAclAttributes.RequestId");

			DescribeNetworkAclAttributesResponse.DescribeNetworkAclAttributes_NetworkAclAttribute networkAclAttribute = new DescribeNetworkAclAttributesResponse.DescribeNetworkAclAttributes_NetworkAclAttribute();
			networkAclAttribute.NetworkAclId = _ctx.StringValue("DescribeNetworkAclAttributes.NetworkAclAttribute.NetworkAclId");
			networkAclAttribute.RegionId = _ctx.StringValue("DescribeNetworkAclAttributes.NetworkAclAttribute.RegionId");
			networkAclAttribute.NetworkAclName = _ctx.StringValue("DescribeNetworkAclAttributes.NetworkAclAttribute.NetworkAclName");
			networkAclAttribute.Description = _ctx.StringValue("DescribeNetworkAclAttributes.NetworkAclAttribute.Description");
			networkAclAttribute.VpcId = _ctx.StringValue("DescribeNetworkAclAttributes.NetworkAclAttribute.VpcId");
			networkAclAttribute.CreationTime = _ctx.StringValue("DescribeNetworkAclAttributes.NetworkAclAttribute.CreationTime");
			networkAclAttribute.Status = _ctx.StringValue("DescribeNetworkAclAttributes.NetworkAclAttribute.Status");
			networkAclAttribute.OwnerId = _ctx.LongValue("DescribeNetworkAclAttributes.NetworkAclAttribute.OwnerId");

			List<DescribeNetworkAclAttributesResponse.DescribeNetworkAclAttributes_NetworkAclAttribute.DescribeNetworkAclAttributes_IngressAclEntry> networkAclAttribute_ingressAclEntries = new List<DescribeNetworkAclAttributesResponse.DescribeNetworkAclAttributes_NetworkAclAttribute.DescribeNetworkAclAttributes_IngressAclEntry>();
			for (int i = 0; i < _ctx.Length("DescribeNetworkAclAttributes.NetworkAclAttribute.IngressAclEntries.Length"); i++) {
				DescribeNetworkAclAttributesResponse.DescribeNetworkAclAttributes_NetworkAclAttribute.DescribeNetworkAclAttributes_IngressAclEntry ingressAclEntry = new DescribeNetworkAclAttributesResponse.DescribeNetworkAclAttributes_NetworkAclAttribute.DescribeNetworkAclAttributes_IngressAclEntry();
				ingressAclEntry.NetworkAclEntryId = _ctx.StringValue("DescribeNetworkAclAttributes.NetworkAclAttribute.IngressAclEntries["+ i +"].NetworkAclEntryId");
				ingressAclEntry.Policy = _ctx.StringValue("DescribeNetworkAclAttributes.NetworkAclAttribute.IngressAclEntries["+ i +"].Policy");
				ingressAclEntry.Protocol = _ctx.StringValue("DescribeNetworkAclAttributes.NetworkAclAttribute.IngressAclEntries["+ i +"].Protocol");
				ingressAclEntry.SourceCidrIp = _ctx.StringValue("DescribeNetworkAclAttributes.NetworkAclAttribute.IngressAclEntries["+ i +"].SourceCidrIp");
				ingressAclEntry.Port = _ctx.StringValue("DescribeNetworkAclAttributes.NetworkAclAttribute.IngressAclEntries["+ i +"].Port");
				ingressAclEntry.EntryType = _ctx.StringValue("DescribeNetworkAclAttributes.NetworkAclAttribute.IngressAclEntries["+ i +"].EntryType");
				ingressAclEntry.NetworkAclEntryName = _ctx.StringValue("DescribeNetworkAclAttributes.NetworkAclAttribute.IngressAclEntries["+ i +"].NetworkAclEntryName");
				ingressAclEntry.Description = _ctx.StringValue("DescribeNetworkAclAttributes.NetworkAclAttribute.IngressAclEntries["+ i +"].Description");

				networkAclAttribute_ingressAclEntries.Add(ingressAclEntry);
			}
			networkAclAttribute.IngressAclEntries = networkAclAttribute_ingressAclEntries;

			List<DescribeNetworkAclAttributesResponse.DescribeNetworkAclAttributes_NetworkAclAttribute.DescribeNetworkAclAttributes_EgressAclEntry> networkAclAttribute_egressAclEntries = new List<DescribeNetworkAclAttributesResponse.DescribeNetworkAclAttributes_NetworkAclAttribute.DescribeNetworkAclAttributes_EgressAclEntry>();
			for (int i = 0; i < _ctx.Length("DescribeNetworkAclAttributes.NetworkAclAttribute.EgressAclEntries.Length"); i++) {
				DescribeNetworkAclAttributesResponse.DescribeNetworkAclAttributes_NetworkAclAttribute.DescribeNetworkAclAttributes_EgressAclEntry egressAclEntry = new DescribeNetworkAclAttributesResponse.DescribeNetworkAclAttributes_NetworkAclAttribute.DescribeNetworkAclAttributes_EgressAclEntry();
				egressAclEntry.NetworkAclEntryId = _ctx.StringValue("DescribeNetworkAclAttributes.NetworkAclAttribute.EgressAclEntries["+ i +"].NetworkAclEntryId");
				egressAclEntry.Policy = _ctx.StringValue("DescribeNetworkAclAttributes.NetworkAclAttribute.EgressAclEntries["+ i +"].Policy");
				egressAclEntry.Protocol = _ctx.StringValue("DescribeNetworkAclAttributes.NetworkAclAttribute.EgressAclEntries["+ i +"].Protocol");
				egressAclEntry.DestinationCidrIp = _ctx.StringValue("DescribeNetworkAclAttributes.NetworkAclAttribute.EgressAclEntries["+ i +"].DestinationCidrIp");
				egressAclEntry.Port = _ctx.StringValue("DescribeNetworkAclAttributes.NetworkAclAttribute.EgressAclEntries["+ i +"].Port");
				egressAclEntry.EntryType = _ctx.StringValue("DescribeNetworkAclAttributes.NetworkAclAttribute.EgressAclEntries["+ i +"].EntryType");
				egressAclEntry.Description = _ctx.StringValue("DescribeNetworkAclAttributes.NetworkAclAttribute.EgressAclEntries["+ i +"].Description");
				egressAclEntry.NetworkAclEntryName = _ctx.StringValue("DescribeNetworkAclAttributes.NetworkAclAttribute.EgressAclEntries["+ i +"].NetworkAclEntryName");

				networkAclAttribute_egressAclEntries.Add(egressAclEntry);
			}
			networkAclAttribute.EgressAclEntries = networkAclAttribute_egressAclEntries;

			List<DescribeNetworkAclAttributesResponse.DescribeNetworkAclAttributes_NetworkAclAttribute.DescribeNetworkAclAttributes_Resource> networkAclAttribute_resources = new List<DescribeNetworkAclAttributesResponse.DescribeNetworkAclAttributes_NetworkAclAttribute.DescribeNetworkAclAttributes_Resource>();
			for (int i = 0; i < _ctx.Length("DescribeNetworkAclAttributes.NetworkAclAttribute.Resources.Length"); i++) {
				DescribeNetworkAclAttributesResponse.DescribeNetworkAclAttributes_NetworkAclAttribute.DescribeNetworkAclAttributes_Resource resource = new DescribeNetworkAclAttributesResponse.DescribeNetworkAclAttributes_NetworkAclAttribute.DescribeNetworkAclAttributes_Resource();
				resource.ResourceId = _ctx.StringValue("DescribeNetworkAclAttributes.NetworkAclAttribute.Resources["+ i +"].ResourceId");
				resource.ResourceType = _ctx.StringValue("DescribeNetworkAclAttributes.NetworkAclAttribute.Resources["+ i +"].ResourceType");
				resource.Status = _ctx.StringValue("DescribeNetworkAclAttributes.NetworkAclAttribute.Resources["+ i +"].Status");

				networkAclAttribute_resources.Add(resource);
			}
			networkAclAttribute.Resources = networkAclAttribute_resources;
			describeNetworkAclAttributesResponse.NetworkAclAttribute = networkAclAttribute;
        
			return describeNetworkAclAttributesResponse;
        }
    }
}
