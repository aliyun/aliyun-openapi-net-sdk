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
    public class CreateNetworkAclResponseUnmarshaller
    {
        public static CreateNetworkAclResponse Unmarshall(UnmarshallerContext context)
        {
			CreateNetworkAclResponse createNetworkAclResponse = new CreateNetworkAclResponse();

			createNetworkAclResponse.HttpResponse = context.HttpResponse;
			createNetworkAclResponse.RequestId = context.StringValue("CreateNetworkAcl.RequestId");
			createNetworkAclResponse.NetworkAclId = context.StringValue("CreateNetworkAcl.NetworkAclId");

			CreateNetworkAclResponse.CreateNetworkAcl_NetworkAclAttribute networkAclAttribute = new CreateNetworkAclResponse.CreateNetworkAcl_NetworkAclAttribute();
			networkAclAttribute.NetworkAclId = context.StringValue("CreateNetworkAcl.NetworkAclAttribute.NetworkAclId");
			networkAclAttribute.RegionId = context.StringValue("CreateNetworkAcl.NetworkAclAttribute.RegionId");
			networkAclAttribute.NetworkAclName = context.StringValue("CreateNetworkAcl.NetworkAclAttribute.NetworkAclName");
			networkAclAttribute.Description = context.StringValue("CreateNetworkAcl.NetworkAclAttribute.Description");
			networkAclAttribute.VpcId = context.StringValue("CreateNetworkAcl.NetworkAclAttribute.VpcId");
			networkAclAttribute.CreationTime = context.StringValue("CreateNetworkAcl.NetworkAclAttribute.CreationTime");
			networkAclAttribute.Status = context.StringValue("CreateNetworkAcl.NetworkAclAttribute.Status");

			List<CreateNetworkAclResponse.CreateNetworkAcl_NetworkAclAttribute.CreateNetworkAcl_IngressAclEntry> networkAclAttribute_ingressAclEntries = new List<CreateNetworkAclResponse.CreateNetworkAcl_NetworkAclAttribute.CreateNetworkAcl_IngressAclEntry>();
			for (int i = 0; i < context.Length("CreateNetworkAcl.NetworkAclAttribute.IngressAclEntries.Length"); i++) {
				CreateNetworkAclResponse.CreateNetworkAcl_NetworkAclAttribute.CreateNetworkAcl_IngressAclEntry ingressAclEntry = new CreateNetworkAclResponse.CreateNetworkAcl_NetworkAclAttribute.CreateNetworkAcl_IngressAclEntry();
				ingressAclEntry.NetworkAclEntryId = context.StringValue("CreateNetworkAcl.NetworkAclAttribute.IngressAclEntries["+ i +"].NetworkAclEntryId");
				ingressAclEntry.Policy = context.StringValue("CreateNetworkAcl.NetworkAclAttribute.IngressAclEntries["+ i +"].Policy");
				ingressAclEntry.Protocol = context.StringValue("CreateNetworkAcl.NetworkAclAttribute.IngressAclEntries["+ i +"].Protocol");
				ingressAclEntry.SourceCidrIp = context.StringValue("CreateNetworkAcl.NetworkAclAttribute.IngressAclEntries["+ i +"].SourceCidrIp");
				ingressAclEntry.Port = context.StringValue("CreateNetworkAcl.NetworkAclAttribute.IngressAclEntries["+ i +"].Port");
				ingressAclEntry.EntryType = context.StringValue("CreateNetworkAcl.NetworkAclAttribute.IngressAclEntries["+ i +"].EntryType");
				ingressAclEntry.NetworkAclEntryName = context.StringValue("CreateNetworkAcl.NetworkAclAttribute.IngressAclEntries["+ i +"].NetworkAclEntryName");
				ingressAclEntry.Description = context.StringValue("CreateNetworkAcl.NetworkAclAttribute.IngressAclEntries["+ i +"].Description");

				networkAclAttribute_ingressAclEntries.Add(ingressAclEntry);
			}
			networkAclAttribute.IngressAclEntries = networkAclAttribute_ingressAclEntries;

			List<CreateNetworkAclResponse.CreateNetworkAcl_NetworkAclAttribute.CreateNetworkAcl_EgressAclEntry> networkAclAttribute_egressAclEntries = new List<CreateNetworkAclResponse.CreateNetworkAcl_NetworkAclAttribute.CreateNetworkAcl_EgressAclEntry>();
			for (int i = 0; i < context.Length("CreateNetworkAcl.NetworkAclAttribute.EgressAclEntries.Length"); i++) {
				CreateNetworkAclResponse.CreateNetworkAcl_NetworkAclAttribute.CreateNetworkAcl_EgressAclEntry egressAclEntry = new CreateNetworkAclResponse.CreateNetworkAcl_NetworkAclAttribute.CreateNetworkAcl_EgressAclEntry();
				egressAclEntry.NetworkAclEntryId = context.StringValue("CreateNetworkAcl.NetworkAclAttribute.EgressAclEntries["+ i +"].NetworkAclEntryId");
				egressAclEntry.Policy = context.StringValue("CreateNetworkAcl.NetworkAclAttribute.EgressAclEntries["+ i +"].Policy");
				egressAclEntry.Protocol = context.StringValue("CreateNetworkAcl.NetworkAclAttribute.EgressAclEntries["+ i +"].Protocol");
				egressAclEntry.DestinationCidrIp = context.StringValue("CreateNetworkAcl.NetworkAclAttribute.EgressAclEntries["+ i +"].DestinationCidrIp");
				egressAclEntry.Port = context.StringValue("CreateNetworkAcl.NetworkAclAttribute.EgressAclEntries["+ i +"].Port");
				egressAclEntry.EntryType = context.StringValue("CreateNetworkAcl.NetworkAclAttribute.EgressAclEntries["+ i +"].EntryType");
				egressAclEntry.Description = context.StringValue("CreateNetworkAcl.NetworkAclAttribute.EgressAclEntries["+ i +"].Description");
				egressAclEntry.NetworkAclEntryName = context.StringValue("CreateNetworkAcl.NetworkAclAttribute.EgressAclEntries["+ i +"].NetworkAclEntryName");

				networkAclAttribute_egressAclEntries.Add(egressAclEntry);
			}
			networkAclAttribute.EgressAclEntries = networkAclAttribute_egressAclEntries;

			List<CreateNetworkAclResponse.CreateNetworkAcl_NetworkAclAttribute.CreateNetworkAcl_Resource> networkAclAttribute_resources = new List<CreateNetworkAclResponse.CreateNetworkAcl_NetworkAclAttribute.CreateNetworkAcl_Resource>();
			for (int i = 0; i < context.Length("CreateNetworkAcl.NetworkAclAttribute.Resources.Length"); i++) {
				CreateNetworkAclResponse.CreateNetworkAcl_NetworkAclAttribute.CreateNetworkAcl_Resource resource = new CreateNetworkAclResponse.CreateNetworkAcl_NetworkAclAttribute.CreateNetworkAcl_Resource();
				resource.ResourceId = context.StringValue("CreateNetworkAcl.NetworkAclAttribute.Resources["+ i +"].ResourceId");
				resource.ResourceType = context.StringValue("CreateNetworkAcl.NetworkAclAttribute.Resources["+ i +"].ResourceType");
				resource.Status = context.StringValue("CreateNetworkAcl.NetworkAclAttribute.Resources["+ i +"].Status");

				networkAclAttribute_resources.Add(resource);
			}
			networkAclAttribute.Resources = networkAclAttribute_resources;
			createNetworkAclResponse.NetworkAclAttribute = networkAclAttribute;
        
			return createNetworkAclResponse;
        }
    }
}
