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
using Aliyun.Acs.Ecs.Model.V20140526;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeDedicatedHostClustersResponseUnmarshaller
    {
        public static DescribeDedicatedHostClustersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDedicatedHostClustersResponse describeDedicatedHostClustersResponse = new DescribeDedicatedHostClustersResponse();

			describeDedicatedHostClustersResponse.HttpResponse = _ctx.HttpResponse;
			describeDedicatedHostClustersResponse.RequestId = _ctx.StringValue("DescribeDedicatedHostClusters.RequestId");
			describeDedicatedHostClustersResponse.TotalCount = _ctx.IntegerValue("DescribeDedicatedHostClusters.TotalCount");
			describeDedicatedHostClustersResponse.PageNumber = _ctx.IntegerValue("DescribeDedicatedHostClusters.PageNumber");
			describeDedicatedHostClustersResponse.PageSize = _ctx.IntegerValue("DescribeDedicatedHostClusters.PageSize");

			List<DescribeDedicatedHostClustersResponse.DescribeDedicatedHostClusters_DedicatedHostCluster> describeDedicatedHostClustersResponse_dedicatedHostClusters = new List<DescribeDedicatedHostClustersResponse.DescribeDedicatedHostClusters_DedicatedHostCluster>();
			for (int i = 0; i < _ctx.Length("DescribeDedicatedHostClusters.DedicatedHostClusters.Length"); i++) {
				DescribeDedicatedHostClustersResponse.DescribeDedicatedHostClusters_DedicatedHostCluster dedicatedHostCluster = new DescribeDedicatedHostClustersResponse.DescribeDedicatedHostClusters_DedicatedHostCluster();
				dedicatedHostCluster.DedicatedHostClusterId = _ctx.StringValue("DescribeDedicatedHostClusters.DedicatedHostClusters["+ i +"].DedicatedHostClusterId");
				dedicatedHostCluster.RegionId = _ctx.StringValue("DescribeDedicatedHostClusters.DedicatedHostClusters["+ i +"].RegionId");
				dedicatedHostCluster.ZoneId = _ctx.StringValue("DescribeDedicatedHostClusters.DedicatedHostClusters["+ i +"].ZoneId");
				dedicatedHostCluster.DedicatedHostClusterName = _ctx.StringValue("DescribeDedicatedHostClusters.DedicatedHostClusters["+ i +"].DedicatedHostClusterName");
				dedicatedHostCluster.Description = _ctx.StringValue("DescribeDedicatedHostClusters.DedicatedHostClusters["+ i +"].Description");
				dedicatedHostCluster.ResourceGroupId = _ctx.StringValue("DescribeDedicatedHostClusters.DedicatedHostClusters["+ i +"].ResourceGroupId");

				List<string> dedicatedHostCluster_dedicatedHostIds = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeDedicatedHostClusters.DedicatedHostClusters["+ i +"].DedicatedHostIds.Length"); j++) {
					dedicatedHostCluster_dedicatedHostIds.Add(_ctx.StringValue("DescribeDedicatedHostClusters.DedicatedHostClusters["+ i +"].DedicatedHostIds["+ j +"]"));
				}
				dedicatedHostCluster.DedicatedHostIds = dedicatedHostCluster_dedicatedHostIds;

				DescribeDedicatedHostClustersResponse.DescribeDedicatedHostClusters_DedicatedHostCluster.DescribeDedicatedHostClusters_DedicatedHostClusterCapacity dedicatedHostClusterCapacity = new DescribeDedicatedHostClustersResponse.DescribeDedicatedHostClusters_DedicatedHostCluster.DescribeDedicatedHostClusters_DedicatedHostClusterCapacity();
				dedicatedHostClusterCapacity.TotalVcpus = _ctx.IntegerValue("DescribeDedicatedHostClusters.DedicatedHostClusters["+ i +"].DedicatedHostClusterCapacity.TotalVcpus");
				dedicatedHostClusterCapacity.AvailableVcpus = _ctx.IntegerValue("DescribeDedicatedHostClusters.DedicatedHostClusters["+ i +"].DedicatedHostClusterCapacity.AvailableVcpus");
				dedicatedHostClusterCapacity.TotalMemory = _ctx.IntegerValue("DescribeDedicatedHostClusters.DedicatedHostClusters["+ i +"].DedicatedHostClusterCapacity.TotalMemory");
				dedicatedHostClusterCapacity.AvailableMemory = _ctx.IntegerValue("DescribeDedicatedHostClusters.DedicatedHostClusters["+ i +"].DedicatedHostClusterCapacity.AvailableMemory");

				List<DescribeDedicatedHostClustersResponse.DescribeDedicatedHostClusters_DedicatedHostCluster.DescribeDedicatedHostClusters_DedicatedHostClusterCapacity.DescribeDedicatedHostClusters_LocalStorageCapacity> dedicatedHostClusterCapacity_localStorageCapacities = new List<DescribeDedicatedHostClustersResponse.DescribeDedicatedHostClusters_DedicatedHostCluster.DescribeDedicatedHostClusters_DedicatedHostClusterCapacity.DescribeDedicatedHostClusters_LocalStorageCapacity>();
				for (int j = 0; j < _ctx.Length("DescribeDedicatedHostClusters.DedicatedHostClusters["+ i +"].DedicatedHostClusterCapacity.LocalStorageCapacities.Length"); j++) {
					DescribeDedicatedHostClustersResponse.DescribeDedicatedHostClusters_DedicatedHostCluster.DescribeDedicatedHostClusters_DedicatedHostClusterCapacity.DescribeDedicatedHostClusters_LocalStorageCapacity localStorageCapacity = new DescribeDedicatedHostClustersResponse.DescribeDedicatedHostClusters_DedicatedHostCluster.DescribeDedicatedHostClusters_DedicatedHostClusterCapacity.DescribeDedicatedHostClusters_LocalStorageCapacity();
					localStorageCapacity.TotalDisk = _ctx.IntegerValue("DescribeDedicatedHostClusters.DedicatedHostClusters["+ i +"].DedicatedHostClusterCapacity.LocalStorageCapacities["+ j +"].TotalDisk");
					localStorageCapacity.AvailableDisk = _ctx.IntegerValue("DescribeDedicatedHostClusters.DedicatedHostClusters["+ i +"].DedicatedHostClusterCapacity.LocalStorageCapacities["+ j +"].AvailableDisk");
					localStorageCapacity.DataDiskCategory = _ctx.StringValue("DescribeDedicatedHostClusters.DedicatedHostClusters["+ i +"].DedicatedHostClusterCapacity.LocalStorageCapacities["+ j +"].DataDiskCategory");

					dedicatedHostClusterCapacity_localStorageCapacities.Add(localStorageCapacity);
				}
				dedicatedHostClusterCapacity.LocalStorageCapacities = dedicatedHostClusterCapacity_localStorageCapacities;

				List<DescribeDedicatedHostClustersResponse.DescribeDedicatedHostClusters_DedicatedHostCluster.DescribeDedicatedHostClusters_DedicatedHostClusterCapacity.DescribeDedicatedHostClusters_AvailableInstanceType> dedicatedHostClusterCapacity_availableInstanceTypes = new List<DescribeDedicatedHostClustersResponse.DescribeDedicatedHostClusters_DedicatedHostCluster.DescribeDedicatedHostClusters_DedicatedHostClusterCapacity.DescribeDedicatedHostClusters_AvailableInstanceType>();
				for (int j = 0; j < _ctx.Length("DescribeDedicatedHostClusters.DedicatedHostClusters["+ i +"].DedicatedHostClusterCapacity.AvailableInstanceTypes.Length"); j++) {
					DescribeDedicatedHostClustersResponse.DescribeDedicatedHostClusters_DedicatedHostCluster.DescribeDedicatedHostClusters_DedicatedHostClusterCapacity.DescribeDedicatedHostClusters_AvailableInstanceType availableInstanceType = new DescribeDedicatedHostClustersResponse.DescribeDedicatedHostClusters_DedicatedHostCluster.DescribeDedicatedHostClusters_DedicatedHostClusterCapacity.DescribeDedicatedHostClusters_AvailableInstanceType();
					availableInstanceType.InstanceType = _ctx.StringValue("DescribeDedicatedHostClusters.DedicatedHostClusters["+ i +"].DedicatedHostClusterCapacity.AvailableInstanceTypes["+ j +"].InstanceType");
					availableInstanceType.AvailableInstanceCapacity = _ctx.IntegerValue("DescribeDedicatedHostClusters.DedicatedHostClusters["+ i +"].DedicatedHostClusterCapacity.AvailableInstanceTypes["+ j +"].AvailableInstanceCapacity");

					dedicatedHostClusterCapacity_availableInstanceTypes.Add(availableInstanceType);
				}
				dedicatedHostClusterCapacity.AvailableInstanceTypes = dedicatedHostClusterCapacity_availableInstanceTypes;
				dedicatedHostCluster.DedicatedHostClusterCapacity = dedicatedHostClusterCapacity;

				List<DescribeDedicatedHostClustersResponse.DescribeDedicatedHostClusters_DedicatedHostCluster.DescribeDedicatedHostClusters_Tag> dedicatedHostCluster_tags = new List<DescribeDedicatedHostClustersResponse.DescribeDedicatedHostClusters_DedicatedHostCluster.DescribeDedicatedHostClusters_Tag>();
				for (int j = 0; j < _ctx.Length("DescribeDedicatedHostClusters.DedicatedHostClusters["+ i +"].Tags.Length"); j++) {
					DescribeDedicatedHostClustersResponse.DescribeDedicatedHostClusters_DedicatedHostCluster.DescribeDedicatedHostClusters_Tag tag = new DescribeDedicatedHostClustersResponse.DescribeDedicatedHostClusters_DedicatedHostCluster.DescribeDedicatedHostClusters_Tag();
					tag.TagKey = _ctx.StringValue("DescribeDedicatedHostClusters.DedicatedHostClusters["+ i +"].Tags["+ j +"].TagKey");
					tag.TagValue = _ctx.StringValue("DescribeDedicatedHostClusters.DedicatedHostClusters["+ i +"].Tags["+ j +"].TagValue");

					dedicatedHostCluster_tags.Add(tag);
				}
				dedicatedHostCluster.Tags = dedicatedHostCluster_tags;

				describeDedicatedHostClustersResponse_dedicatedHostClusters.Add(dedicatedHostCluster);
			}
			describeDedicatedHostClustersResponse.DedicatedHostClusters = describeDedicatedHostClustersResponse_dedicatedHostClusters;
        
			return describeDedicatedHostClustersResponse;
        }
    }
}
