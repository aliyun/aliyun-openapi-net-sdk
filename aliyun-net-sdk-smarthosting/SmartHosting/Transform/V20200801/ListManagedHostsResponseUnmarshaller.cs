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
using Aliyun.Acs.SmartHosting.Model.V20200801;

namespace Aliyun.Acs.SmartHosting.Transform.V20200801
{
    public class ListManagedHostsResponseUnmarshaller
    {
        public static ListManagedHostsResponse Unmarshall(UnmarshallerContext context)
        {
			ListManagedHostsResponse listManagedHostsResponse = new ListManagedHostsResponse();

			listManagedHostsResponse.HttpResponse = context.HttpResponse;
			listManagedHostsResponse.NextToken = context.StringValue("ListManagedHosts.NextToken");
			listManagedHostsResponse.PageSize = context.IntegerValue("ListManagedHosts.PageSize");
			listManagedHostsResponse.RequestId = context.StringValue("ListManagedHosts.RequestId");
			listManagedHostsResponse.TotalCount = context.IntegerValue("ListManagedHosts.TotalCount");

			List<ListManagedHostsResponse.ListManagedHosts_ManagedHostSet> listManagedHostsResponse_managedHostSets = new List<ListManagedHostsResponse.ListManagedHosts_ManagedHostSet>();
			for (int i = 0; i < context.Length("ListManagedHosts.ManagedHostSets.Length"); i++) {
				ListManagedHostsResponse.ListManagedHosts_ManagedHostSet managedHostSet = new ListManagedHostsResponse.ListManagedHosts_ManagedHostSet();
				managedHostSet.ManagedHostId = context.StringValue("ListManagedHosts.ManagedHostSets["+ i +"].ManagedHostId");
				managedHostSet.ManagedHostName = context.StringValue("ListManagedHosts.ManagedHostSets["+ i +"].ManagedHostName");
				managedHostSet.Mode = context.StringValue("ListManagedHosts.ManagedHostSets["+ i +"].Mode");
				managedHostSet.ResourceGroupId = context.StringValue("ListManagedHosts.ManagedHostSets["+ i +"].ResourceGroupId");
				managedHostSet.Status = context.StringValue("ListManagedHosts.ManagedHostSets["+ i +"].Status");

				List<string> managedHostSet_supportedCustomInstanceTypeFamilies = new List<string>();
				for (int j = 0; j < context.Length("ListManagedHosts.ManagedHostSets["+ i +"].SupportedCustomInstanceTypeFamilies.Length"); j++) {
					managedHostSet_supportedCustomInstanceTypeFamilies.Add(context.StringValue("ListManagedHosts.ManagedHostSets["+ i +"].SupportedCustomInstanceTypeFamilies["+ j +"]"));
				}
				managedHostSet.SupportedCustomInstanceTypeFamilies = managedHostSet_supportedCustomInstanceTypeFamilies;

				List<string> managedHostSet_supportedInstanceTypeFamilies = new List<string>();
				for (int j = 0; j < context.Length("ListManagedHosts.ManagedHostSets["+ i +"].SupportedInstanceTypeFamilies.Length"); j++) {
					managedHostSet_supportedInstanceTypeFamilies.Add(context.StringValue("ListManagedHosts.ManagedHostSets["+ i +"].SupportedInstanceTypeFamilies["+ j +"]"));
				}
				managedHostSet.SupportedInstanceTypeFamilies = managedHostSet_supportedInstanceTypeFamilies;

				List<string> managedHostSet_supportedInstanceTypes = new List<string>();
				for (int j = 0; j < context.Length("ListManagedHosts.ManagedHostSets["+ i +"].SupportedInstanceTypes.Length"); j++) {
					managedHostSet_supportedInstanceTypes.Add(context.StringValue("ListManagedHosts.ManagedHostSets["+ i +"].SupportedInstanceTypes["+ j +"]"));
				}
				managedHostSet.SupportedInstanceTypes = managedHostSet_supportedInstanceTypes;

				ListManagedHostsResponse.ListManagedHosts_ManagedHostSet.ListManagedHosts_CapacityAttribute capacityAttribute = new ListManagedHostsResponse.ListManagedHosts_ManagedHostSet.ListManagedHosts_CapacityAttribute();
				capacityAttribute.AvailableMemories = context.IntegerValue("ListManagedHosts.ManagedHostSets["+ i +"].CapacityAttribute.AvailableMemories");
				capacityAttribute.AvailableVcpus = context.IntegerValue("ListManagedHosts.ManagedHostSets["+ i +"].CapacityAttribute.AvailableVcpus");
				capacityAttribute.TotalMemories = context.IntegerValue("ListManagedHosts.ManagedHostSets["+ i +"].CapacityAttribute.TotalMemories");
				capacityAttribute.TotalVcpus = context.IntegerValue("ListManagedHosts.ManagedHostSets["+ i +"].CapacityAttribute.TotalVcpus");
				managedHostSet.CapacityAttribute = capacityAttribute;

				ListManagedHostsResponse.ListManagedHosts_ManagedHostSet.ListManagedHosts_HostAttribute hostAttribute = new ListManagedHostsResponse.ListManagedHosts_ManagedHostSet.ListManagedHosts_HostAttribute();
				hostAttribute.CpuModelName = context.StringValue("ListManagedHosts.ManagedHostSets["+ i +"].HostAttribute.CpuModelName");
				hostAttribute.HostType = context.StringValue("ListManagedHosts.ManagedHostSets["+ i +"].HostAttribute.HostType");
				managedHostSet.HostAttribute = hostAttribute;

				ListManagedHostsResponse.ListManagedHosts_ManagedHostSet.ListManagedHosts_NetworkAssociation networkAssociation = new ListManagedHostsResponse.ListManagedHosts_ManagedHostSet.ListManagedHosts_NetworkAssociation();

				List<ListManagedHostsResponse.ListManagedHosts_ManagedHostSet.ListManagedHosts_NetworkAssociation.ListManagedHosts_SwitchSet> networkAssociation_switchSets = new List<ListManagedHostsResponse.ListManagedHosts_ManagedHostSet.ListManagedHosts_NetworkAssociation.ListManagedHosts_SwitchSet>();
				for (int j = 0; j < context.Length("ListManagedHosts.ManagedHostSets["+ i +"].NetworkAssociation.SwitchSets.Length"); j++) {
					ListManagedHostsResponse.ListManagedHosts_ManagedHostSet.ListManagedHosts_NetworkAssociation.ListManagedHosts_SwitchSet switchSet = new ListManagedHostsResponse.ListManagedHosts_ManagedHostSet.ListManagedHosts_NetworkAssociation.ListManagedHosts_SwitchSet();
					switchSet.SwitchId = context.StringValue("ListManagedHosts.ManagedHostSets["+ i +"].NetworkAssociation.SwitchSets["+ j +"].SwitchId");

					networkAssociation_switchSets.Add(switchSet);
				}
				networkAssociation.SwitchSets = networkAssociation_switchSets;
				managedHostSet.NetworkAssociation = networkAssociation;

				List<ListManagedHostsResponse.ListManagedHosts_ManagedHostSet.ListManagedHosts_InstanceSet> managedHostSet_instanceSets = new List<ListManagedHostsResponse.ListManagedHosts_ManagedHostSet.ListManagedHosts_InstanceSet>();
				for (int j = 0; j < context.Length("ListManagedHosts.ManagedHostSets["+ i +"].InstanceSets.Length"); j++) {
					ListManagedHostsResponse.ListManagedHosts_ManagedHostSet.ListManagedHosts_InstanceSet instanceSet = new ListManagedHostsResponse.ListManagedHosts_ManagedHostSet.ListManagedHosts_InstanceSet();
					instanceSet.InstanceId = context.StringValue("ListManagedHosts.ManagedHostSets["+ i +"].InstanceSets["+ j +"].InstanceId");

					managedHostSet_instanceSets.Add(instanceSet);
				}
				managedHostSet.InstanceSets = managedHostSet_instanceSets;

				List<ListManagedHostsResponse.ListManagedHosts_ManagedHostSet.ListManagedHosts_Tag> managedHostSet_tags = new List<ListManagedHostsResponse.ListManagedHosts_ManagedHostSet.ListManagedHosts_Tag>();
				for (int j = 0; j < context.Length("ListManagedHosts.ManagedHostSets["+ i +"].Tags.Length"); j++) {
					ListManagedHostsResponse.ListManagedHosts_ManagedHostSet.ListManagedHosts_Tag tag = new ListManagedHostsResponse.ListManagedHosts_ManagedHostSet.ListManagedHosts_Tag();
					tag.Key = context.StringValue("ListManagedHosts.ManagedHostSets["+ i +"].Tags["+ j +"].Key");
					tag._Value = context.StringValue("ListManagedHosts.ManagedHostSets["+ i +"].Tags["+ j +"].Value");

					managedHostSet_tags.Add(tag);
				}
				managedHostSet.Tags = managedHostSet_tags;

				listManagedHostsResponse_managedHostSets.Add(managedHostSet);
			}
			listManagedHostsResponse.ManagedHostSets = listManagedHostsResponse_managedHostSets;
        
			return listManagedHostsResponse;
        }
    }
}
