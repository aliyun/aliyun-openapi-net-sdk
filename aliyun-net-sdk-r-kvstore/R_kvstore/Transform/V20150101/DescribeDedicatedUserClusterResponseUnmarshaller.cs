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
using Aliyun.Acs.R_kvstore.Model.V20150101;

namespace Aliyun.Acs.R_kvstore.Transform.V20150101
{
    public class DescribeDedicatedUserClusterResponseUnmarshaller
    {
        public static DescribeDedicatedUserClusterResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDedicatedUserClusterResponse describeDedicatedUserClusterResponse = new DescribeDedicatedUserClusterResponse();

			describeDedicatedUserClusterResponse.HttpResponse = _ctx.HttpResponse;
			describeDedicatedUserClusterResponse.RequestId = _ctx.StringValue("DescribeDedicatedUserCluster.RequestId");
			describeDedicatedUserClusterResponse.MaxRecordsPerPage = _ctx.IntegerValue("DescribeDedicatedUserCluster.MaxRecordsPerPage");
			describeDedicatedUserClusterResponse.PageNumber = _ctx.IntegerValue("DescribeDedicatedUserCluster.PageNumber");
			describeDedicatedUserClusterResponse.TotalRecords = _ctx.IntegerValue("DescribeDedicatedUserCluster.TotalRecords");
			describeDedicatedUserClusterResponse.ItemsNumbers = _ctx.IntegerValue("DescribeDedicatedUserCluster.ItemsNumbers");

			List<DescribeDedicatedUserClusterResponse.DescribeDedicatedUserCluster_ClusterInfo> describeDedicatedUserClusterResponse_clusterItems = new List<DescribeDedicatedUserClusterResponse.DescribeDedicatedUserCluster_ClusterInfo>();
			for (int i = 0; i < _ctx.Length("DescribeDedicatedUserCluster.ClusterItems.Length"); i++) {
				DescribeDedicatedUserClusterResponse.DescribeDedicatedUserCluster_ClusterInfo clusterInfo = new DescribeDedicatedUserClusterResponse.DescribeDedicatedUserCluster_ClusterInfo();
				clusterInfo.ClusterId = _ctx.StringValue("DescribeDedicatedUserCluster.ClusterItems["+ i +"].ClusterId");
				clusterInfo.ClusterName = _ctx.StringValue("DescribeDedicatedUserCluster.ClusterItems["+ i +"].ClusterName");
				clusterInfo.HostNumbers = _ctx.IntegerValue("DescribeDedicatedUserCluster.ClusterItems["+ i +"].HostNumbers");
				clusterInfo.InstanceNumbers = _ctx.IntegerValue("DescribeDedicatedUserCluster.ClusterItems["+ i +"].InstanceNumbers");
				clusterInfo.CpuOverAllocationRatio = _ctx.IntegerValue("DescribeDedicatedUserCluster.ClusterItems["+ i +"].CpuOverAllocationRatio");
				clusterInfo.MemoryOverAllocationRatio = _ctx.IntegerValue("DescribeDedicatedUserCluster.ClusterItems["+ i +"].MemoryOverAllocationRatio");
				clusterInfo.DiskOverAllocationRatio = _ctx.IntegerValue("DescribeDedicatedUserCluster.ClusterItems["+ i +"].DiskOverAllocationRatio");
				clusterInfo.AllocationPolicy = _ctx.StringValue("DescribeDedicatedUserCluster.ClusterItems["+ i +"].AllocationPolicy");
				clusterInfo.HostReplacePolicy = _ctx.StringValue("DescribeDedicatedUserCluster.ClusterItems["+ i +"].HostReplacePolicy");
				clusterInfo.CreateTime = _ctx.StringValue("DescribeDedicatedUserCluster.ClusterItems["+ i +"].CreateTime");

				describeDedicatedUserClusterResponse_clusterItems.Add(clusterInfo);
			}
			describeDedicatedUserClusterResponse.ClusterItems = describeDedicatedUserClusterResponse_clusterItems;
        
			return describeDedicatedUserClusterResponse;
        }
    }
}
