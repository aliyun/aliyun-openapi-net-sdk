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
    public class ListManagedPrivateSpacesResponseUnmarshaller
    {
        public static ListManagedPrivateSpacesResponse Unmarshall(UnmarshallerContext context)
        {
			ListManagedPrivateSpacesResponse listManagedPrivateSpacesResponse = new ListManagedPrivateSpacesResponse();

			listManagedPrivateSpacesResponse.HttpResponse = context.HttpResponse;
			listManagedPrivateSpacesResponse.NextToken = context.StringValue("ListManagedPrivateSpaces.NextToken");
			listManagedPrivateSpacesResponse.RequestId = context.StringValue("ListManagedPrivateSpaces.RequestId");
			listManagedPrivateSpacesResponse.TotalCount = context.IntegerValue("ListManagedPrivateSpaces.TotalCount");

			List<ListManagedPrivateSpacesResponse.ListManagedPrivateSpaces_ManagedPrivateSpaceSet> listManagedPrivateSpacesResponse_managedPrivateSpaceSets = new List<ListManagedPrivateSpacesResponse.ListManagedPrivateSpaces_ManagedPrivateSpaceSet>();
			for (int i = 0; i < context.Length("ListManagedPrivateSpaces.ManagedPrivateSpaceSets.Length"); i++) {
				ListManagedPrivateSpacesResponse.ListManagedPrivateSpaces_ManagedPrivateSpaceSet managedPrivateSpaceSet = new ListManagedPrivateSpacesResponse.ListManagedPrivateSpaces_ManagedPrivateSpaceSet();
				managedPrivateSpaceSet.CreationTime = context.StringValue("ListManagedPrivateSpaces.ManagedPrivateSpaceSets["+ i +"].CreationTime");
				managedPrivateSpaceSet.Description = context.StringValue("ListManagedPrivateSpaces.ManagedPrivateSpaceSets["+ i +"].Description");
				managedPrivateSpaceSet.ManagedPrivateSpaceId = context.StringValue("ListManagedPrivateSpaces.ManagedPrivateSpaceSets["+ i +"].ManagedPrivateSpaceId");
				managedPrivateSpaceSet.ManagedPrivateSpaceName = context.StringValue("ListManagedPrivateSpaces.ManagedPrivateSpaceSets["+ i +"].ManagedPrivateSpaceName");
				managedPrivateSpaceSet.ResourceGroupId = context.StringValue("ListManagedPrivateSpaces.ManagedPrivateSpaceSets["+ i +"].ResourceGroupId");
				managedPrivateSpaceSet.SaleMode = context.StringValue("ListManagedPrivateSpaces.ManagedPrivateSpaceSets["+ i +"].SaleMode");
				managedPrivateSpaceSet.ZoneId = context.StringValue("ListManagedPrivateSpaces.ManagedPrivateSpaceSets["+ i +"].ZoneId");

				ListManagedPrivateSpacesResponse.ListManagedPrivateSpaces_ManagedPrivateSpaceSet.ListManagedPrivateSpaces_CapacityAttribute capacityAttribute = new ListManagedPrivateSpacesResponse.ListManagedPrivateSpaces_ManagedPrivateSpaceSet.ListManagedPrivateSpaces_CapacityAttribute();
				capacityAttribute.AvailableHostCount = context.IntegerValue("ListManagedPrivateSpaces.ManagedPrivateSpaceSets["+ i +"].CapacityAttribute.AvailableHostCount");
				capacityAttribute.AvailableMemories = context.IntegerValue("ListManagedPrivateSpaces.ManagedPrivateSpaceSets["+ i +"].CapacityAttribute.AvailableMemories");
				capacityAttribute.AvailableVcpus = context.IntegerValue("ListManagedPrivateSpaces.ManagedPrivateSpaceSets["+ i +"].CapacityAttribute.AvailableVcpus");
				capacityAttribute.ReservedHostCount = context.IntegerValue("ListManagedPrivateSpaces.ManagedPrivateSpaceSets["+ i +"].CapacityAttribute.ReservedHostCount");
				capacityAttribute.ReservedMemories = context.IntegerValue("ListManagedPrivateSpaces.ManagedPrivateSpaceSets["+ i +"].CapacityAttribute.ReservedMemories");
				capacityAttribute.ReservedVcpus = context.IntegerValue("ListManagedPrivateSpaces.ManagedPrivateSpaceSets["+ i +"].CapacityAttribute.ReservedVcpus");
				capacityAttribute.TotalHostCount = context.IntegerValue("ListManagedPrivateSpaces.ManagedPrivateSpaceSets["+ i +"].CapacityAttribute.TotalHostCount");
				capacityAttribute.TotalMemories = context.IntegerValue("ListManagedPrivateSpaces.ManagedPrivateSpaceSets["+ i +"].CapacityAttribute.TotalMemories");
				capacityAttribute.TotalVcpus = context.IntegerValue("ListManagedPrivateSpaces.ManagedPrivateSpaceSets["+ i +"].CapacityAttribute.TotalVcpus");
				managedPrivateSpaceSet.CapacityAttribute = capacityAttribute;

				ListManagedPrivateSpacesResponse.ListManagedPrivateSpaces_ManagedPrivateSpaceSet.ListManagedPrivateSpaces_LifecycleAttribute lifecycleAttribute = new ListManagedPrivateSpacesResponse.ListManagedPrivateSpaces_ManagedPrivateSpaceSet.ListManagedPrivateSpaces_LifecycleAttribute();
				lifecycleAttribute.DeliveryTime = context.StringValue("ListManagedPrivateSpaces.ManagedPrivateSpaceSets["+ i +"].LifecycleAttribute.DeliveryTime");
				lifecycleAttribute.ExpirationTime = context.StringValue("ListManagedPrivateSpaces.ManagedPrivateSpaceSets["+ i +"].LifecycleAttribute.ExpirationTime");
				lifecycleAttribute.ReceptionTime = context.StringValue("ListManagedPrivateSpaces.ManagedPrivateSpaceSets["+ i +"].LifecycleAttribute.ReceptionTime");
				managedPrivateSpaceSet.LifecycleAttribute = lifecycleAttribute;

				ListManagedPrivateSpacesResponse.ListManagedPrivateSpaces_ManagedPrivateSpaceSet.ListManagedPrivateSpaces_LocationAttribute locationAttribute = new ListManagedPrivateSpacesResponse.ListManagedPrivateSpaces_ManagedPrivateSpaceSet.ListManagedPrivateSpaces_LocationAttribute();
				locationAttribute.Address = context.StringValue("ListManagedPrivateSpaces.ManagedPrivateSpaceSets["+ i +"].LocationAttribute.Address");
				managedPrivateSpaceSet.LocationAttribute = locationAttribute;

				List<ListManagedPrivateSpacesResponse.ListManagedPrivateSpaces_ManagedPrivateSpaceSet.ListManagedPrivateSpaces_DeploymentAttribute> managedPrivateSpaceSet_deploymentAttributes = new List<ListManagedPrivateSpacesResponse.ListManagedPrivateSpaces_ManagedPrivateSpaceSet.ListManagedPrivateSpaces_DeploymentAttribute>();
				for (int j = 0; j < context.Length("ListManagedPrivateSpaces.ManagedPrivateSpaceSets["+ i +"].DeploymentAttributes.Length"); j++) {
					ListManagedPrivateSpacesResponse.ListManagedPrivateSpaces_ManagedPrivateSpaceSet.ListManagedPrivateSpaces_DeploymentAttribute deploymentAttribute = new ListManagedPrivateSpacesResponse.ListManagedPrivateSpaces_ManagedPrivateSpaceSet.ListManagedPrivateSpaces_DeploymentAttribute();
					deploymentAttribute.ContractId = context.StringValue("ListManagedPrivateSpaces.ManagedPrivateSpaceSets["+ i +"].DeploymentAttributes["+ j +"].ContractId");
					deploymentAttribute.CreateTime = context.StringValue("ListManagedPrivateSpaces.ManagedPrivateSpaceSets["+ i +"].DeploymentAttributes["+ j +"].CreateTime");
					deploymentAttribute.Description = context.StringValue("ListManagedPrivateSpaces.ManagedPrivateSpaceSets["+ i +"].DeploymentAttributes["+ j +"].Description");

					List<ListManagedPrivateSpacesResponse.ListManagedPrivateSpaces_ManagedPrivateSpaceSet.ListManagedPrivateSpaces_DeploymentAttribute.ListManagedPrivateSpaces_DeploymentStep> deploymentAttribute_deploymentSteps = new List<ListManagedPrivateSpacesResponse.ListManagedPrivateSpaces_ManagedPrivateSpaceSet.ListManagedPrivateSpaces_DeploymentAttribute.ListManagedPrivateSpaces_DeploymentStep>();
					for (int k = 0; k < context.Length("ListManagedPrivateSpaces.ManagedPrivateSpaceSets["+ i +"].DeploymentAttributes["+ j +"].DeploymentSteps.Length"); k++) {
						ListManagedPrivateSpacesResponse.ListManagedPrivateSpaces_ManagedPrivateSpaceSet.ListManagedPrivateSpaces_DeploymentAttribute.ListManagedPrivateSpaces_DeploymentStep deploymentStep = new ListManagedPrivateSpacesResponse.ListManagedPrivateSpaces_ManagedPrivateSpaceSet.ListManagedPrivateSpaces_DeploymentAttribute.ListManagedPrivateSpaces_DeploymentStep();
						deploymentStep.ActualTime = context.StringValue("ListManagedPrivateSpaces.ManagedPrivateSpaceSets["+ i +"].DeploymentAttributes["+ j +"].DeploymentSteps["+ k +"].ActualTime");
						deploymentStep.CurrentStep = context.BooleanValue("ListManagedPrivateSpaces.ManagedPrivateSpaceSets["+ i +"].DeploymentAttributes["+ j +"].DeploymentSteps["+ k +"].CurrentStep");
						deploymentStep.ExpectTime = context.StringValue("ListManagedPrivateSpaces.ManagedPrivateSpaceSets["+ i +"].DeploymentAttributes["+ j +"].DeploymentSteps["+ k +"].ExpectTime");
						deploymentStep.Status = context.StringValue("ListManagedPrivateSpaces.ManagedPrivateSpaceSets["+ i +"].DeploymentAttributes["+ j +"].DeploymentSteps["+ k +"].Status");

						deploymentAttribute_deploymentSteps.Add(deploymentStep);
					}
					deploymentAttribute.DeploymentSteps = deploymentAttribute_deploymentSteps;

					managedPrivateSpaceSet_deploymentAttributes.Add(deploymentAttribute);
				}
				managedPrivateSpaceSet.DeploymentAttributes = managedPrivateSpaceSet_deploymentAttributes;

				List<ListManagedPrivateSpacesResponse.ListManagedPrivateSpaces_ManagedPrivateSpaceSet.ListManagedPrivateSpaces_ManagedHostSet> managedPrivateSpaceSet_managedHostSets = new List<ListManagedPrivateSpacesResponse.ListManagedPrivateSpaces_ManagedPrivateSpaceSet.ListManagedPrivateSpaces_ManagedHostSet>();
				for (int j = 0; j < context.Length("ListManagedPrivateSpaces.ManagedPrivateSpaceSets["+ i +"].ManagedHostSets.Length"); j++) {
					ListManagedPrivateSpacesResponse.ListManagedPrivateSpaces_ManagedPrivateSpaceSet.ListManagedPrivateSpaces_ManagedHostSet managedHostSet = new ListManagedPrivateSpacesResponse.ListManagedPrivateSpaces_ManagedPrivateSpaceSet.ListManagedPrivateSpaces_ManagedHostSet();
					managedHostSet.ManagedHostId = context.StringValue("ListManagedPrivateSpaces.ManagedPrivateSpaceSets["+ i +"].ManagedHostSets["+ j +"].ManagedHostId");
					managedHostSet.ManagedHostStatus = context.StringValue("ListManagedPrivateSpaces.ManagedPrivateSpaceSets["+ i +"].ManagedHostSets["+ j +"].ManagedHostStatus");

					managedPrivateSpaceSet_managedHostSets.Add(managedHostSet);
				}
				managedPrivateSpaceSet.ManagedHostSets = managedPrivateSpaceSet_managedHostSets;

				List<ListManagedPrivateSpacesResponse.ListManagedPrivateSpaces_ManagedPrivateSpaceSet.ListManagedPrivateSpaces_Tag> managedPrivateSpaceSet_tags = new List<ListManagedPrivateSpacesResponse.ListManagedPrivateSpaces_ManagedPrivateSpaceSet.ListManagedPrivateSpaces_Tag>();
				for (int j = 0; j < context.Length("ListManagedPrivateSpaces.ManagedPrivateSpaceSets["+ i +"].Tags.Length"); j++) {
					ListManagedPrivateSpacesResponse.ListManagedPrivateSpaces_ManagedPrivateSpaceSet.ListManagedPrivateSpaces_Tag tag = new ListManagedPrivateSpacesResponse.ListManagedPrivateSpaces_ManagedPrivateSpaceSet.ListManagedPrivateSpaces_Tag();
					tag.Key = context.StringValue("ListManagedPrivateSpaces.ManagedPrivateSpaceSets["+ i +"].Tags["+ j +"].Key");
					tag._Value = context.StringValue("ListManagedPrivateSpaces.ManagedPrivateSpaceSets["+ i +"].Tags["+ j +"].Value");

					managedPrivateSpaceSet_tags.Add(tag);
				}
				managedPrivateSpaceSet.Tags = managedPrivateSpaceSet_tags;

				listManagedPrivateSpacesResponse_managedPrivateSpaceSets.Add(managedPrivateSpaceSet);
			}
			listManagedPrivateSpacesResponse.ManagedPrivateSpaceSets = listManagedPrivateSpacesResponse_managedPrivateSpaceSets;
        
			return listManagedPrivateSpacesResponse;
        }
    }
}
