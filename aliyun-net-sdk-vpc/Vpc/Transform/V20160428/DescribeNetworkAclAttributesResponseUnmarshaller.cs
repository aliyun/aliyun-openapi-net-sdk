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
        public static DescribeNetworkAclAttributesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeNetworkAclAttributesResponse describeNetworkAclAttributesResponse = new DescribeNetworkAclAttributesResponse();

			describeNetworkAclAttributesResponse.HttpResponse = context.HttpResponse;
			describeNetworkAclAttributesResponse.RequestId = context.StringValue("DescribeNetworkAclAttributes.RequestId");

			DescribeNetworkAclAttributesResponse.DescribeNetworkAclAttributes_NetworkAclAttribute networkAclAttribute = new DescribeNetworkAclAttributesResponse.DescribeNetworkAclAttributes_NetworkAclAttribute();
			networkAclAttribute.NetworkAclId = context.StringValue("DescribeNetworkAclAttributes.NetworkAclAttribute.NetworkAclId");
			networkAclAttribute.RegionId = context.StringValue("DescribeNetworkAclAttributes.NetworkAclAttribute.RegionId");
			networkAclAttribute.NetworkAclName = context.StringValue("DescribeNetworkAclAttributes.NetworkAclAttribute.NetworkAclName");
			networkAclAttribute.Description = context.StringValue("DescribeNetworkAclAttributes.NetworkAclAttribute.Description");
			networkAclAttribute.VpcId = context.StringValue("DescribeNetworkAclAttributes.NetworkAclAttribute.VpcId");
			networkAclAttribute.CreationTime = context.StringValue("DescribeNetworkAclAttributes.NetworkAclAttribute.CreationTime");
			networkAclAttribute.Status = context.StringValue("DescribeNetworkAclAttributes.NetworkAclAttribute.Status");

			List<DescribeNetworkAclAttributesResponse.DescribeNetworkAclAttributes_NetworkAclAttribute.DescribeNetworkAclAttributes_IngressAclEntry> networkAclAttribute_ingressAclEntries = new List<DescribeNetworkAclAttributesResponse.DescribeNetworkAclAttributes_NetworkAclAttribute.DescribeNetworkAclAttributes_IngressAclEntry>();
			for (int i = 0; i < context.Length("DescribeNetworkAclAttributes.NetworkAclAttribute.IngressAclEntries.Length"); i++) {
				DescribeNetworkAclAttributesResponse.DescribeNetworkAclAttributes_NetworkAclAttribute.DescribeNetworkAclAttributes_IngressAclEntry ingressAclEntry = new DescribeNetworkAclAttributesResponse.DescribeNetworkAclAttributes_NetworkAclAttribute.DescribeNetworkAclAttributes_IngressAclEntry();
				ingressAclEntry.NetworkAclEntryId = context.StringValue("DescribeNetworkAclAttributes.NetworkAclAttribute.IngressAclEntries["+ i +"].NetworkAclEntryId");
				ingressAclEntry.Policy = context.StringValue("DescribeNetworkAclAttributes.NetworkAclAttribute.IngressAclEntries["+ i +"].Policy");
				ingressAclEntry.Protocol = context.StringValue("DescribeNetworkAclAttributes.NetworkAclAttribute.IngressAclEntries["+ i +"].Protocol");
				ingressAclEntry.SourceCidrIp = context.StringValue("DescribeNetworkAclAttributes.NetworkAclAttribute.IngressAclEntries["+ i +"].SourceCidrIp");
				ingressAclEntry.Port = context.StringValue("DescribeNetworkAclAttributes.NetworkAclAttribute.IngressAclEntries["+ i +"].Port");
				ingressAclEntry.EntryType = context.StringValue("DescribeNetworkAclAttributes.NetworkAclAttribute.IngressAclEntries["+ i +"].EntryType");
				ingressAclEntry.NetworkAclEntryName = context.StringValue("DescribeNetworkAclAttributes.NetworkAclAttribute.IngressAclEntries["+ i +"].NetworkAclEntryName");
				ingressAclEntry.Description = context.StringValue("DescribeNetworkAclAttributes.NetworkAclAttribute.IngressAclEntries["+ i +"].Description");

				networkAclAttribute_ingressAclEntries.Add(ingressAclEntry);
			}
			networkAclAttribute.IngressAclEntries = networkAclAttribute_ingressAclEntries;

			List<DescribeNetworkAclAttributesResponse.DescribeNetworkAclAttributes_NetworkAclAttribute.DescribeNetworkAclAttributes_EgressAclEntry> networkAclAttribute_egressAclEntries = new List<DescribeNetworkAclAttributesResponse.DescribeNetworkAclAttributes_NetworkAclAttribute.DescribeNetworkAclAttributes_EgressAclEntry>();
			for (int i = 0; i < context.Length("DescribeNetworkAclAttributes.NetworkAclAttribute.EgressAclEntries.Length"); i++) {
				DescribeNetworkAclAttributesResponse.DescribeNetworkAclAttributes_NetworkAclAttribute.DescribeNetworkAclAttributes_EgressAclEntry egressAclEntry = new DescribeNetworkAclAttributesResponse.DescribeNetworkAclAttributes_NetworkAclAttribute.DescribeNetworkAclAttributes_EgressAclEntry();
				egressAclEntry.NetworkAclEntryId = context.StringValue("DescribeNetworkAclAttributes.NetworkAclAttribute.EgressAclEntries["+ i +"].NetworkAclEntryId");
				egressAclEntry.Policy = context.StringValue("DescribeNetworkAclAttributes.NetworkAclAttribute.EgressAclEntries["+ i +"].Policy");
				egressAclEntry.Protocol = context.StringValue("DescribeNetworkAclAttributes.NetworkAclAttribute.EgressAclEntries["+ i +"].Protocol");
				egressAclEntry.DestinationCidrIp = context.StringValue("DescribeNetworkAclAttributes.NetworkAclAttribute.EgressAclEntries["+ i +"].DestinationCidrIp");
				egressAclEntry.Port = context.StringValue("DescribeNetworkAclAttributes.NetworkAclAttribute.EgressAclEntries["+ i +"].Port");
				egressAclEntry.EntryType = context.StringValue("DescribeNetworkAclAttributes.NetworkAclAttribute.EgressAclEntries["+ i +"].EntryType");
				egressAclEntry.Description = context.StringValue("DescribeNetworkAclAttributes.NetworkAclAttribute.EgressAclEntries["+ i +"].Description");
				egressAclEntry.NetworkAclEntryName = context.StringValue("DescribeNetworkAclAttributes.NetworkAclAttribute.EgressAclEntries["+ i +"].NetworkAclEntryName");

				networkAclAttribute_egressAclEntries.Add(egressAclEntry);
			}
			networkAclAttribute.EgressAclEntries = networkAclAttribute_egressAclEntries;

			List<DescribeNetworkAclAttributesResponse.DescribeNetworkAclAttributes_NetworkAclAttribute.DescribeNetworkAclAttributes_Resource> networkAclAttribute_resources = new List<DescribeNetworkAclAttributesResponse.DescribeNetworkAclAttributes_NetworkAclAttribute.DescribeNetworkAclAttributes_Resource>();
			for (int i = 0; i < context.Length("DescribeNetworkAclAttributes.NetworkAclAttribute.Resources.Length"); i++) {
				DescribeNetworkAclAttributesResponse.DescribeNetworkAclAttributes_NetworkAclAttribute.DescribeNetworkAclAttributes_Resource resource = new DescribeNetworkAclAttributesResponse.DescribeNetworkAclAttributes_NetworkAclAttribute.DescribeNetworkAclAttributes_Resource();
				resource.ResourceId = context.StringValue("DescribeNetworkAclAttributes.NetworkAclAttribute.Resources["+ i +"].ResourceId");
				resource.ResourceType = context.StringValue("DescribeNetworkAclAttributes.NetworkAclAttribute.Resources["+ i +"].ResourceType");
				resource.Status = context.StringValue("DescribeNetworkAclAttributes.NetworkAclAttribute.Resources["+ i +"].Status");

				networkAclAttribute_resources.Add(resource);
			}
			networkAclAttribute.Resources = networkAclAttribute_resources;
			describeNetworkAclAttributesResponse.NetworkAclAttribute = networkAclAttribute;
        
			return describeNetworkAclAttributesResponse;
        }
    }
}
