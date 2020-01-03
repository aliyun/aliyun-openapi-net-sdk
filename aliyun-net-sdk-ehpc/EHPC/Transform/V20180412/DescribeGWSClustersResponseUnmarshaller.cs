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
using Aliyun.Acs.EHPC.Model.V20180412;

namespace Aliyun.Acs.EHPC.Transform.V20180412
{
    public class DescribeGWSClustersResponseUnmarshaller
    {
        public static DescribeGWSClustersResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeGWSClustersResponse describeGWSClustersResponse = new DescribeGWSClustersResponse();

			describeGWSClustersResponse.HttpResponse = context.HttpResponse;
			describeGWSClustersResponse.RequestId = context.StringValue("DescribeGWSClusters.RequestId");
			describeGWSClustersResponse.TotalCount = context.IntegerValue("DescribeGWSClusters.TotalCount");
			describeGWSClustersResponse.PageNumber = context.IntegerValue("DescribeGWSClusters.PageNumber");
			describeGWSClustersResponse.PageSize = context.IntegerValue("DescribeGWSClusters.PageSize");
			describeGWSClustersResponse.CallerType = context.StringValue("DescribeGWSClusters.CallerType");

			List<DescribeGWSClustersResponse.DescribeGWSClusters_ClusterInfo> describeGWSClustersResponse_clusters = new List<DescribeGWSClustersResponse.DescribeGWSClusters_ClusterInfo>();
			for (int i = 0; i < context.Length("DescribeGWSClusters.Clusters.Length"); i++) {
				DescribeGWSClustersResponse.DescribeGWSClusters_ClusterInfo clusterInfo = new DescribeGWSClustersResponse.DescribeGWSClusters_ClusterInfo();
				clusterInfo.ClusterId = context.StringValue("DescribeGWSClusters.Clusters["+ i +"].ClusterId");
				clusterInfo.Status = context.StringValue("DescribeGWSClusters.Clusters["+ i +"].Status");
				clusterInfo.CreateTime = context.StringValue("DescribeGWSClusters.Clusters["+ i +"].CreateTime");
				clusterInfo.VpcId = context.StringValue("DescribeGWSClusters.Clusters["+ i +"].VpcId");
				clusterInfo.InstanceCount = context.IntegerValue("DescribeGWSClusters.Clusters["+ i +"].InstanceCount");

				describeGWSClustersResponse_clusters.Add(clusterInfo);
			}
			describeGWSClustersResponse.Clusters = describeGWSClustersResponse_clusters;
        
			return describeGWSClustersResponse;
        }
    }
}
