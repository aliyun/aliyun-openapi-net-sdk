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
    public class DescribeDedicatedBlockStorageClustersResponseUnmarshaller
    {
        public static DescribeDedicatedBlockStorageClustersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDedicatedBlockStorageClustersResponse describeDedicatedBlockStorageClustersResponse = new DescribeDedicatedBlockStorageClustersResponse();

			describeDedicatedBlockStorageClustersResponse.HttpResponse = _ctx.HttpResponse;
			describeDedicatedBlockStorageClustersResponse.RequestId = _ctx.StringValue("DescribeDedicatedBlockStorageClusters.RequestId");
			describeDedicatedBlockStorageClustersResponse.NextToken = _ctx.StringValue("DescribeDedicatedBlockStorageClusters.NextToken");

			List<DescribeDedicatedBlockStorageClustersResponse.DescribeDedicatedBlockStorageClusters_DedicatedBlockStorageCluster> describeDedicatedBlockStorageClustersResponse_dedicatedBlockStorageClusters = new List<DescribeDedicatedBlockStorageClustersResponse.DescribeDedicatedBlockStorageClusters_DedicatedBlockStorageCluster>();
			for (int i = 0; i < _ctx.Length("DescribeDedicatedBlockStorageClusters.DedicatedBlockStorageClusters.Length"); i++) {
				DescribeDedicatedBlockStorageClustersResponse.DescribeDedicatedBlockStorageClusters_DedicatedBlockStorageCluster dedicatedBlockStorageCluster = new DescribeDedicatedBlockStorageClustersResponse.DescribeDedicatedBlockStorageClusters_DedicatedBlockStorageCluster();
				dedicatedBlockStorageCluster.DedicatedBlockStorageClusterId = _ctx.StringValue("DescribeDedicatedBlockStorageClusters.DedicatedBlockStorageClusters["+ i +"].DedicatedBlockStorageClusterId");
				dedicatedBlockStorageCluster.DedicatedBlockStorageClusterName = _ctx.StringValue("DescribeDedicatedBlockStorageClusters.DedicatedBlockStorageClusters["+ i +"].DedicatedBlockStorageClusterName");
				dedicatedBlockStorageCluster.Description = _ctx.StringValue("DescribeDedicatedBlockStorageClusters.DedicatedBlockStorageClusters["+ i +"].Description");
				dedicatedBlockStorageCluster.ZoneId = _ctx.StringValue("DescribeDedicatedBlockStorageClusters.DedicatedBlockStorageClusters["+ i +"].ZoneId");
				dedicatedBlockStorageCluster.Status = _ctx.StringValue("DescribeDedicatedBlockStorageClusters.DedicatedBlockStorageClusters["+ i +"].Status");
				dedicatedBlockStorageCluster.Category = _ctx.StringValue("DescribeDedicatedBlockStorageClusters.DedicatedBlockStorageClusters["+ i +"].Category");
				dedicatedBlockStorageCluster.PerformanceLevel = _ctx.StringValue("DescribeDedicatedBlockStorageClusters.DedicatedBlockStorageClusters["+ i +"].PerformanceLevel");
				dedicatedBlockStorageCluster.ExpiredTime = _ctx.StringValue("DescribeDedicatedBlockStorageClusters.DedicatedBlockStorageClusters["+ i +"].ExpiredTime");
				dedicatedBlockStorageCluster.CreateTime = _ctx.StringValue("DescribeDedicatedBlockStorageClusters.DedicatedBlockStorageClusters["+ i +"].CreateTime");

				DescribeDedicatedBlockStorageClustersResponse.DescribeDedicatedBlockStorageClusters_DedicatedBlockStorageCluster.DescribeDedicatedBlockStorageClusters_DedicatedBlockStorageClusterCapacity dedicatedBlockStorageClusterCapacity = new DescribeDedicatedBlockStorageClustersResponse.DescribeDedicatedBlockStorageClusters_DedicatedBlockStorageCluster.DescribeDedicatedBlockStorageClusters_DedicatedBlockStorageClusterCapacity();
				dedicatedBlockStorageClusterCapacity.AvailableCapacity = _ctx.LongValue("DescribeDedicatedBlockStorageClusters.DedicatedBlockStorageClusters["+ i +"].DedicatedBlockStorageClusterCapacity.AvailableCapacity");
				dedicatedBlockStorageClusterCapacity.TotalCapacity = _ctx.LongValue("DescribeDedicatedBlockStorageClusters.DedicatedBlockStorageClusters["+ i +"].DedicatedBlockStorageClusterCapacity.TotalCapacity");
				dedicatedBlockStorageCluster.DedicatedBlockStorageClusterCapacity = dedicatedBlockStorageClusterCapacity;

				describeDedicatedBlockStorageClustersResponse_dedicatedBlockStorageClusters.Add(dedicatedBlockStorageCluster);
			}
			describeDedicatedBlockStorageClustersResponse.DedicatedBlockStorageClusters = describeDedicatedBlockStorageClustersResponse_dedicatedBlockStorageClusters;
        
			return describeDedicatedBlockStorageClustersResponse;
        }
    }
}
