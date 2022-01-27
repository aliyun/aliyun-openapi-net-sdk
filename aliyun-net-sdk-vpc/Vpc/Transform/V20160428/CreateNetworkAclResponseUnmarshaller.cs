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
        public static CreateNetworkAclResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateNetworkAclResponse createNetworkAclResponse = new CreateNetworkAclResponse();

			createNetworkAclResponse.HttpResponse = _ctx.HttpResponse;
			createNetworkAclResponse.RequestId = _ctx.StringValue("CreateNetworkAcl.RequestId");
			createNetworkAclResponse.NetworkAclId = _ctx.StringValue("CreateNetworkAcl.NetworkAclId");

			CreateNetworkAclResponse.CreateNetworkAcl_NetworkAclAttribute networkAclAttribute = new CreateNetworkAclResponse.CreateNetworkAcl_NetworkAclAttribute();
			networkAclAttribute.NetworkAclId = _ctx.StringValue("CreateNetworkAcl.NetworkAclAttribute.NetworkAclId");
			networkAclAttribute.RegionId = _ctx.StringValue("CreateNetworkAcl.NetworkAclAttribute.RegionId");
			networkAclAttribute.NetworkAclName = _ctx.StringValue("CreateNetworkAcl.NetworkAclAttribute.NetworkAclName");
			networkAclAttribute.Description = _ctx.StringValue("CreateNetworkAcl.NetworkAclAttribute.Description");
			networkAclAttribute.VpcId = _ctx.StringValue("CreateNetworkAcl.NetworkAclAttribute.VpcId");
			networkAclAttribute.CreationTime = _ctx.StringValue("CreateNetworkAcl.NetworkAclAttribute.CreationTime");
			networkAclAttribute.Status = _ctx.StringValue("CreateNetworkAcl.NetworkAclAttribute.Status");

			List<CreateNetworkAclResponse.CreateNetworkAcl_NetworkAclAttribute.CreateNetworkAcl_IngressAclEntry> networkAclAttribute_ingressAclEntries = new List<CreateNetworkAclResponse.CreateNetworkAcl_NetworkAclAttribute.CreateNetworkAcl_IngressAclEntry>();
			for (int i = 0; i < _ctx.Length("CreateNetworkAcl.NetworkAclAttribute.IngressAclEntries.Length"); i++) {
				CreateNetworkAclResponse.CreateNetworkAcl_NetworkAclAttribute.CreateNetworkAcl_IngressAclEntry ingressAclEntry = new CreateNetworkAclResponse.CreateNetworkAcl_NetworkAclAttribute.CreateNetworkAcl_IngressAclEntry();
				ingressAclEntry.NetworkAclEntryId = _ctx.StringValue("CreateNetworkAcl.NetworkAclAttribute.IngressAclEntries["+ i +"].NetworkAclEntryId");
				ingressAclEntry.Policy = _ctx.StringValue("CreateNetworkAcl.NetworkAclAttribute.IngressAclEntries["+ i +"].Policy");
				ingressAclEntry.Protocol = _ctx.StringValue("CreateNetworkAcl.NetworkAclAttribute.IngressAclEntries["+ i +"].Protocol");
				ingressAclEntry.SourceCidrIp = _ctx.StringValue("CreateNetworkAcl.NetworkAclAttribute.IngressAclEntries["+ i +"].SourceCidrIp");
				ingressAclEntry.Port = _ctx.StringValue("CreateNetworkAcl.NetworkAclAttribute.IngressAclEntries["+ i +"].Port");
				ingressAclEntry.EntryType = _ctx.StringValue("CreateNetworkAcl.NetworkAclAttribute.IngressAclEntries["+ i +"].EntryType");
				ingressAclEntry.NetworkAclEntryName = _ctx.StringValue("CreateNetworkAcl.NetworkAclAttribute.IngressAclEntries["+ i +"].NetworkAclEntryName");
				ingressAclEntry.Description = _ctx.StringValue("CreateNetworkAcl.NetworkAclAttribute.IngressAclEntries["+ i +"].Description");

				networkAclAttribute_ingressAclEntries.Add(ingressAclEntry);
			}
			networkAclAttribute.IngressAclEntries = networkAclAttribute_ingressAclEntries;

			List<CreateNetworkAclResponse.CreateNetworkAcl_NetworkAclAttribute.CreateNetworkAcl_EgressAclEntry> networkAclAttribute_egressAclEntries = new List<CreateNetworkAclResponse.CreateNetworkAcl_NetworkAclAttribute.CreateNetworkAcl_EgressAclEntry>();
			for (int i = 0; i < _ctx.Length("CreateNetworkAcl.NetworkAclAttribute.EgressAclEntries.Length"); i++) {
				CreateNetworkAclResponse.CreateNetworkAcl_NetworkAclAttribute.CreateNetworkAcl_EgressAclEntry egressAclEntry = new CreateNetworkAclResponse.CreateNetworkAcl_NetworkAclAttribute.CreateNetworkAcl_EgressAclEntry();
				egressAclEntry.NetworkAclEntryId = _ctx.StringValue("CreateNetworkAcl.NetworkAclAttribute.EgressAclEntries["+ i +"].NetworkAclEntryId");
				egressAclEntry.Policy = _ctx.StringValue("CreateNetworkAcl.NetworkAclAttribute.EgressAclEntries["+ i +"].Policy");
				egressAclEntry.Protocol = _ctx.StringValue("CreateNetworkAcl.NetworkAclAttribute.EgressAclEntries["+ i +"].Protocol");
				egressAclEntry.DestinationCidrIp = _ctx.StringValue("CreateNetworkAcl.NetworkAclAttribute.EgressAclEntries["+ i +"].DestinationCidrIp");
				egressAclEntry.Port = _ctx.StringValue("CreateNetworkAcl.NetworkAclAttribute.EgressAclEntries["+ i +"].Port");
				egressAclEntry.EntryType = _ctx.StringValue("CreateNetworkAcl.NetworkAclAttribute.EgressAclEntries["+ i +"].EntryType");
				egressAclEntry.Description = _ctx.StringValue("CreateNetworkAcl.NetworkAclAttribute.EgressAclEntries["+ i +"].Description");
				egressAclEntry.NetworkAclEntryName = _ctx.StringValue("CreateNetworkAcl.NetworkAclAttribute.EgressAclEntries["+ i +"].NetworkAclEntryName");

				networkAclAttribute_egressAclEntries.Add(egressAclEntry);
			}
			networkAclAttribute.EgressAclEntries = networkAclAttribute_egressAclEntries;

			List<CreateNetworkAclResponse.CreateNetworkAcl_NetworkAclAttribute.CreateNetworkAcl_Resource> networkAclAttribute_resources = new List<CreateNetworkAclResponse.CreateNetworkAcl_NetworkAclAttribute.CreateNetworkAcl_Resource>();
			for (int i = 0; i < _ctx.Length("CreateNetworkAcl.NetworkAclAttribute.Resources.Length"); i++) {
				CreateNetworkAclResponse.CreateNetworkAcl_NetworkAclAttribute.CreateNetworkAcl_Resource resource = new CreateNetworkAclResponse.CreateNetworkAcl_NetworkAclAttribute.CreateNetworkAcl_Resource();
				resource.ResourceId = _ctx.StringValue("CreateNetworkAcl.NetworkAclAttribute.Resources["+ i +"].ResourceId");
				resource.ResourceType = _ctx.StringValue("CreateNetworkAcl.NetworkAclAttribute.Resources["+ i +"].ResourceType");
				resource.Status = _ctx.StringValue("CreateNetworkAcl.NetworkAclAttribute.Resources["+ i +"].Status");

				networkAclAttribute_resources.Add(resource);
			}
			networkAclAttribute.Resources = networkAclAttribute_resources;
			createNetworkAclResponse.NetworkAclAttribute = networkAclAttribute;
        
			return createNetworkAclResponse;
        }
    }
}
