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
using Aliyun.Acs.Slb.Model.V20140515;

namespace Aliyun.Acs.Slb.Transform.V20140515
{
    public class DescribeMasterSlaveServerGroupsResponseUnmarshaller
    {
        public static DescribeMasterSlaveServerGroupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeMasterSlaveServerGroupsResponse describeMasterSlaveServerGroupsResponse = new DescribeMasterSlaveServerGroupsResponse();

			describeMasterSlaveServerGroupsResponse.HttpResponse = _ctx.HttpResponse;
			describeMasterSlaveServerGroupsResponse.RequestId = _ctx.StringValue("DescribeMasterSlaveServerGroups.RequestId");

			List<DescribeMasterSlaveServerGroupsResponse.DescribeMasterSlaveServerGroups_MasterSlaveServerGroup> describeMasterSlaveServerGroupsResponse_masterSlaveServerGroups = new List<DescribeMasterSlaveServerGroupsResponse.DescribeMasterSlaveServerGroups_MasterSlaveServerGroup>();
			for (int i = 0; i < _ctx.Length("DescribeMasterSlaveServerGroups.MasterSlaveServerGroups.Length"); i++) {
				DescribeMasterSlaveServerGroupsResponse.DescribeMasterSlaveServerGroups_MasterSlaveServerGroup masterSlaveServerGroup = new DescribeMasterSlaveServerGroupsResponse.DescribeMasterSlaveServerGroups_MasterSlaveServerGroup();
				masterSlaveServerGroup.MasterSlaveServerGroupId = _ctx.StringValue("DescribeMasterSlaveServerGroups.MasterSlaveServerGroups["+ i +"].MasterSlaveServerGroupId");
				masterSlaveServerGroup.MasterSlaveServerGroupName = _ctx.StringValue("DescribeMasterSlaveServerGroups.MasterSlaveServerGroups["+ i +"].MasterSlaveServerGroupName");

				DescribeMasterSlaveServerGroupsResponse.DescribeMasterSlaveServerGroups_MasterSlaveServerGroup.DescribeMasterSlaveServerGroups_AssociatedObjects associatedObjects = new DescribeMasterSlaveServerGroupsResponse.DescribeMasterSlaveServerGroups_MasterSlaveServerGroup.DescribeMasterSlaveServerGroups_AssociatedObjects();

				List<DescribeMasterSlaveServerGroupsResponse.DescribeMasterSlaveServerGroups_MasterSlaveServerGroup.DescribeMasterSlaveServerGroups_AssociatedObjects.DescribeMasterSlaveServerGroups_Listener> associatedObjects_listeners = new List<DescribeMasterSlaveServerGroupsResponse.DescribeMasterSlaveServerGroups_MasterSlaveServerGroup.DescribeMasterSlaveServerGroups_AssociatedObjects.DescribeMasterSlaveServerGroups_Listener>();
				for (int j = 0; j < _ctx.Length("DescribeMasterSlaveServerGroups.MasterSlaveServerGroups["+ i +"].AssociatedObjects.Listeners.Length"); j++) {
					DescribeMasterSlaveServerGroupsResponse.DescribeMasterSlaveServerGroups_MasterSlaveServerGroup.DescribeMasterSlaveServerGroups_AssociatedObjects.DescribeMasterSlaveServerGroups_Listener listener = new DescribeMasterSlaveServerGroupsResponse.DescribeMasterSlaveServerGroups_MasterSlaveServerGroup.DescribeMasterSlaveServerGroups_AssociatedObjects.DescribeMasterSlaveServerGroups_Listener();
					listener.Protocol = _ctx.StringValue("DescribeMasterSlaveServerGroups.MasterSlaveServerGroups["+ i +"].AssociatedObjects.Listeners["+ j +"].Protocol");
					listener.Port = _ctx.IntegerValue("DescribeMasterSlaveServerGroups.MasterSlaveServerGroups["+ i +"].AssociatedObjects.Listeners["+ j +"].Port");

					associatedObjects_listeners.Add(listener);
				}
				associatedObjects.Listeners = associatedObjects_listeners;
				masterSlaveServerGroup.AssociatedObjects = associatedObjects;

				describeMasterSlaveServerGroupsResponse_masterSlaveServerGroups.Add(masterSlaveServerGroup);
			}
			describeMasterSlaveServerGroupsResponse.MasterSlaveServerGroups = describeMasterSlaveServerGroupsResponse_masterSlaveServerGroups;
        
			return describeMasterSlaveServerGroupsResponse;
        }
    }
}
