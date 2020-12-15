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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeDedicatedHostGroupsResponseUnmarshaller
    {
        public static DescribeDedicatedHostGroupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDedicatedHostGroupsResponse describeDedicatedHostGroupsResponse = new DescribeDedicatedHostGroupsResponse();

			describeDedicatedHostGroupsResponse.HttpResponse = _ctx.HttpResponse;
			describeDedicatedHostGroupsResponse.RequestId = _ctx.StringValue("DescribeDedicatedHostGroups.RequestId");

			List<DescribeDedicatedHostGroupsResponse.DescribeDedicatedHostGroups_DedicatedHostGroupsItem> describeDedicatedHostGroupsResponse_dedicatedHostGroups = new List<DescribeDedicatedHostGroupsResponse.DescribeDedicatedHostGroups_DedicatedHostGroupsItem>();
			for (int i = 0; i < _ctx.Length("DescribeDedicatedHostGroups.DedicatedHostGroups.Length"); i++) {
				DescribeDedicatedHostGroupsResponse.DescribeDedicatedHostGroups_DedicatedHostGroupsItem dedicatedHostGroupsItem = new DescribeDedicatedHostGroupsResponse.DescribeDedicatedHostGroups_DedicatedHostGroupsItem();
				dedicatedHostGroupsItem.DedicatedHostGroupId = _ctx.StringValue("DescribeDedicatedHostGroups.DedicatedHostGroups["+ i +"].DedicatedHostGroupId");
				dedicatedHostGroupsItem.DedicatedHostGroupDesc = _ctx.StringValue("DescribeDedicatedHostGroups.DedicatedHostGroups["+ i +"].DedicatedHostGroupDesc");
				dedicatedHostGroupsItem.CpuAllocationRatio = _ctx.IntegerValue("DescribeDedicatedHostGroups.DedicatedHostGroups["+ i +"].CpuAllocationRatio");
				dedicatedHostGroupsItem.MemAllocationRatio = _ctx.IntegerValue("DescribeDedicatedHostGroups.DedicatedHostGroups["+ i +"].MemAllocationRatio");
				dedicatedHostGroupsItem.DiskAllocationRatio = _ctx.IntegerValue("DescribeDedicatedHostGroups.DedicatedHostGroups["+ i +"].DiskAllocationRatio");
				dedicatedHostGroupsItem.AllocationPolicy = _ctx.StringValue("DescribeDedicatedHostGroups.DedicatedHostGroups["+ i +"].AllocationPolicy");
				dedicatedHostGroupsItem.HostReplacePolicy = _ctx.StringValue("DescribeDedicatedHostGroups.DedicatedHostGroups["+ i +"].HostReplacePolicy");
				dedicatedHostGroupsItem.CreateTime = _ctx.StringValue("DescribeDedicatedHostGroups.DedicatedHostGroups["+ i +"].CreateTime");
				dedicatedHostGroupsItem.VPCId = _ctx.StringValue("DescribeDedicatedHostGroups.DedicatedHostGroups["+ i +"].VPCId");
				dedicatedHostGroupsItem.HostNumber = _ctx.IntegerValue("DescribeDedicatedHostGroups.DedicatedHostGroups["+ i +"].HostNumber");
				dedicatedHostGroupsItem.InstanceNumber = _ctx.IntegerValue("DescribeDedicatedHostGroups.DedicatedHostGroups["+ i +"].InstanceNumber");
				dedicatedHostGroupsItem.Engine = _ctx.StringValue("DescribeDedicatedHostGroups.DedicatedHostGroups["+ i +"].Engine");
				dedicatedHostGroupsItem.Text = _ctx.StringValue("DescribeDedicatedHostGroups.DedicatedHostGroups["+ i +"].Text");
				dedicatedHostGroupsItem.DedicatedHostCountGroupByHostType = _ctx.StringValue("DescribeDedicatedHostGroups.DedicatedHostGroups["+ i +"].DedicatedHostCountGroupByHostType");
				dedicatedHostGroupsItem.BastionInstanceId = _ctx.StringValue("DescribeDedicatedHostGroups.DedicatedHostGroups["+ i +"].BastionInstanceId");
				dedicatedHostGroupsItem.OpenPermission = _ctx.StringValue("DescribeDedicatedHostGroups.DedicatedHostGroups["+ i +"].OpenPermission");
				dedicatedHostGroupsItem.MemUtility = _ctx.FloatValue("DescribeDedicatedHostGroups.DedicatedHostGroups["+ i +"].MemUtility");
				dedicatedHostGroupsItem.MemUsedAmount = _ctx.FloatValue("DescribeDedicatedHostGroups.DedicatedHostGroups["+ i +"].MemUsedAmount");
				dedicatedHostGroupsItem.DiskUtility = _ctx.FloatValue("DescribeDedicatedHostGroups.DedicatedHostGroups["+ i +"].DiskUtility");
				dedicatedHostGroupsItem.DiskUsedAmount = _ctx.FloatValue("DescribeDedicatedHostGroups.DedicatedHostGroups["+ i +"].DiskUsedAmount");
				dedicatedHostGroupsItem.CpuAllocateRation = _ctx.FloatValue("DescribeDedicatedHostGroups.DedicatedHostGroups["+ i +"].CpuAllocateRation");
				dedicatedHostGroupsItem.CpuAllocatedAmount = _ctx.FloatValue("DescribeDedicatedHostGroups.DedicatedHostGroups["+ i +"].CpuAllocatedAmount");
				dedicatedHostGroupsItem.MemAllocateRation = _ctx.FloatValue("DescribeDedicatedHostGroups.DedicatedHostGroups["+ i +"].MemAllocateRation");
				dedicatedHostGroupsItem.MemAllocatedAmount = _ctx.FloatValue("DescribeDedicatedHostGroups.DedicatedHostGroups["+ i +"].MemAllocatedAmount");
				dedicatedHostGroupsItem.DiskAllocateRation = _ctx.FloatValue("DescribeDedicatedHostGroups.DedicatedHostGroups["+ i +"].DiskAllocateRation");
				dedicatedHostGroupsItem.DiskAllocatedAmount = _ctx.FloatValue("DescribeDedicatedHostGroups.DedicatedHostGroups["+ i +"].DiskAllocatedAmount");

				List<string> dedicatedHostGroupsItem_zoneIDList = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeDedicatedHostGroups.DedicatedHostGroups["+ i +"].ZoneIDList.Length"); j++) {
					dedicatedHostGroupsItem_zoneIDList.Add(_ctx.StringValue("DescribeDedicatedHostGroups.DedicatedHostGroups["+ i +"].ZoneIDList["+ j +"]"));
				}
				dedicatedHostGroupsItem.ZoneIDList = dedicatedHostGroupsItem_zoneIDList;

				describeDedicatedHostGroupsResponse_dedicatedHostGroups.Add(dedicatedHostGroupsItem);
			}
			describeDedicatedHostGroupsResponse.DedicatedHostGroups = describeDedicatedHostGroupsResponse_dedicatedHostGroups;
        
			return describeDedicatedHostGroupsResponse;
        }
    }
}
