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
    public class ListManagedRacksResponseUnmarshaller
    {
        public static ListManagedRacksResponse Unmarshall(UnmarshallerContext context)
        {
			ListManagedRacksResponse listManagedRacksResponse = new ListManagedRacksResponse();

			listManagedRacksResponse.HttpResponse = context.HttpResponse;
			listManagedRacksResponse.NextToken = context.StringValue("ListManagedRacks.NextToken");
			listManagedRacksResponse.PageSize = context.IntegerValue("ListManagedRacks.PageSize");
			listManagedRacksResponse.RequestId = context.StringValue("ListManagedRacks.RequestId");
			listManagedRacksResponse.TotalCount = context.IntegerValue("ListManagedRacks.TotalCount");

			List<ListManagedRacksResponse.ListManagedRacks_ManagedRacksSet> listManagedRacksResponse_managedRacksSets = new List<ListManagedRacksResponse.ListManagedRacks_ManagedRacksSet>();
			for (int i = 0; i < context.Length("ListManagedRacks.ManagedRacksSets.Length"); i++) {
				ListManagedRacksResponse.ListManagedRacks_ManagedRacksSet managedRacksSet = new ListManagedRacksResponse.ListManagedRacks_ManagedRacksSet();
				managedRacksSet.ManagedRackId = context.StringValue("ListManagedRacks.ManagedRacksSets["+ i +"].ManagedRackId");
				managedRacksSet.ZoneId = context.StringValue("ListManagedRacks.ManagedRacksSets["+ i +"].ZoneId");

				List<ListManagedRacksResponse.ListManagedRacks_ManagedRacksSet.ListManagedRacks_ManagedHostSet> managedRacksSet_managedHostSets = new List<ListManagedRacksResponse.ListManagedRacks_ManagedRacksSet.ListManagedRacks_ManagedHostSet>();
				for (int j = 0; j < context.Length("ListManagedRacks.ManagedRacksSets["+ i +"].ManagedHostSets.Length"); j++) {
					ListManagedRacksResponse.ListManagedRacks_ManagedRacksSet.ListManagedRacks_ManagedHostSet managedHostSet = new ListManagedRacksResponse.ListManagedRacks_ManagedRacksSet.ListManagedRacks_ManagedHostSet();
					managedHostSet.Description = context.StringValue("ListManagedRacks.ManagedRacksSets["+ i +"].ManagedHostSets["+ j +"].Description");
					managedHostSet.ManagedHostId = context.StringValue("ListManagedRacks.ManagedRacksSets["+ i +"].ManagedHostSets["+ j +"].ManagedHostId");
					managedHostSet.Status = context.StringValue("ListManagedRacks.ManagedRacksSets["+ i +"].ManagedHostSets["+ j +"].Status");

					ListManagedRacksResponse.ListManagedRacks_ManagedRacksSet.ListManagedRacks_ManagedHostSet.ListManagedRacks_HostAttribute hostAttribute = new ListManagedRacksResponse.ListManagedRacks_ManagedRacksSet.ListManagedRacks_ManagedHostSet.ListManagedRacks_HostAttribute();
					hostAttribute.CpuModelName = context.StringValue("ListManagedRacks.ManagedRacksSets["+ i +"].ManagedHostSets["+ j +"].HostAttribute.CpuModelName");
					hostAttribute.HostType = context.StringValue("ListManagedRacks.ManagedRacksSets["+ i +"].ManagedHostSets["+ j +"].HostAttribute.HostType");
					managedHostSet.HostAttribute = hostAttribute;

					managedRacksSet_managedHostSets.Add(managedHostSet);
				}
				managedRacksSet.ManagedHostSets = managedRacksSet_managedHostSets;

				listManagedRacksResponse_managedRacksSets.Add(managedRacksSet);
			}
			listManagedRacksResponse.ManagedRacksSets = listManagedRacksResponse_managedRacksSets;
        
			return listManagedRacksResponse;
        }
    }
}
