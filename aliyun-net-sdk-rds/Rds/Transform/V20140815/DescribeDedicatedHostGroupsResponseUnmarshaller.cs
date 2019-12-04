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
        public static DescribeDedicatedHostGroupsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDedicatedHostGroupsResponse describeDedicatedHostGroupsResponse = new DescribeDedicatedHostGroupsResponse();

			describeDedicatedHostGroupsResponse.HttpResponse = context.HttpResponse;
			describeDedicatedHostGroupsResponse.RequestId = context.StringValue("DescribeDedicatedHostGroups.RequestId");

			List<DescribeDedicatedHostGroupsResponse.DescribeDedicatedHostGroups_DedicatedHostGroupsItem> describeDedicatedHostGroupsResponse_dedicatedHostGroups = new List<DescribeDedicatedHostGroupsResponse.DescribeDedicatedHostGroups_DedicatedHostGroupsItem>();
			for (int i = 0; i < context.Length("DescribeDedicatedHostGroups.DedicatedHostGroups.Length"); i++) {
				DescribeDedicatedHostGroupsResponse.DescribeDedicatedHostGroups_DedicatedHostGroupsItem dedicatedHostGroupsItem = new DescribeDedicatedHostGroupsResponse.DescribeDedicatedHostGroups_DedicatedHostGroupsItem();
				dedicatedHostGroupsItem.DedicatedHostGroupId = context.StringValue("DescribeDedicatedHostGroups.DedicatedHostGroups["+ i +"].DedicatedHostGroupId");
				dedicatedHostGroupsItem.DedicatedHostGroupDesc = context.StringValue("DescribeDedicatedHostGroups.DedicatedHostGroups["+ i +"].DedicatedHostGroupDesc");
				dedicatedHostGroupsItem.CpuAllocationRatio = context.IntegerValue("DescribeDedicatedHostGroups.DedicatedHostGroups["+ i +"].CpuAllocationRatio");
				dedicatedHostGroupsItem.MemAllocationRatio = context.IntegerValue("DescribeDedicatedHostGroups.DedicatedHostGroups["+ i +"].MemAllocationRatio");
				dedicatedHostGroupsItem.DiskAllocationRatio = context.IntegerValue("DescribeDedicatedHostGroups.DedicatedHostGroups["+ i +"].DiskAllocationRatio");
				dedicatedHostGroupsItem.AllocationPolicy = context.StringValue("DescribeDedicatedHostGroups.DedicatedHostGroups["+ i +"].AllocationPolicy");
				dedicatedHostGroupsItem.HostReplacePolicy = context.StringValue("DescribeDedicatedHostGroups.DedicatedHostGroups["+ i +"].HostReplacePolicy");
				dedicatedHostGroupsItem.CreateTime = context.StringValue("DescribeDedicatedHostGroups.DedicatedHostGroups["+ i +"].CreateTime");
				dedicatedHostGroupsItem.VPCId = context.StringValue("DescribeDedicatedHostGroups.DedicatedHostGroups["+ i +"].VPCId");
				dedicatedHostGroupsItem.HostNumber = context.IntegerValue("DescribeDedicatedHostGroups.DedicatedHostGroups["+ i +"].HostNumber");
				dedicatedHostGroupsItem.InstanceNumber = context.IntegerValue("DescribeDedicatedHostGroups.DedicatedHostGroups["+ i +"].InstanceNumber");
				dedicatedHostGroupsItem.Engine = context.StringValue("DescribeDedicatedHostGroups.DedicatedHostGroups["+ i +"].Engine");
				dedicatedHostGroupsItem.Text = context.StringValue("DescribeDedicatedHostGroups.DedicatedHostGroups["+ i +"].Text");

				describeDedicatedHostGroupsResponse_dedicatedHostGroups.Add(dedicatedHostGroupsItem);
			}
			describeDedicatedHostGroupsResponse.DedicatedHostGroups = describeDedicatedHostGroupsResponse_dedicatedHostGroups;
        
			return describeDedicatedHostGroupsResponse;
        }
    }
}
