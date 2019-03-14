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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class DescribeClusterStatisticsResponseUnmarshaller
    {
        public static DescribeClusterStatisticsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeClusterStatisticsResponse describeClusterStatisticsResponse = new DescribeClusterStatisticsResponse();

			describeClusterStatisticsResponse.HttpResponse = context.HttpResponse;
			describeClusterStatisticsResponse.RequestId = context.StringValue("DescribeClusterStatistics.RequestId");
			describeClusterStatisticsResponse.TotalCount = context.IntegerValue("DescribeClusterStatistics.TotalCount");

			List<DescribeClusterStatisticsResponse.DescribeClusterStatistics_ClusterStatistics> describeClusterStatisticsResponse_clusterStatisticsList = new List<DescribeClusterStatisticsResponse.DescribeClusterStatistics_ClusterStatistics>();
			for (int i = 0; i < context.Length("DescribeClusterStatistics.ClusterStatisticsList.Length"); i++) {
				DescribeClusterStatisticsResponse.DescribeClusterStatistics_ClusterStatistics clusterStatistics = new DescribeClusterStatisticsResponse.DescribeClusterStatistics_ClusterStatistics();
				clusterStatistics.ClusterType = context.StringValue("DescribeClusterStatistics.ClusterStatisticsList["+ i +"].ClusterType");
				clusterStatistics.Count = context.IntegerValue("DescribeClusterStatistics.ClusterStatisticsList["+ i +"].Count");
				clusterStatistics.ClusterStatus = context.StringValue("DescribeClusterStatistics.ClusterStatisticsList["+ i +"].ClusterStatus");

				describeClusterStatisticsResponse_clusterStatisticsList.Add(clusterStatistics);
			}
			describeClusterStatisticsResponse.ClusterStatisticsList = describeClusterStatisticsResponse_clusterStatisticsList;
        
			return describeClusterStatisticsResponse;
        }
    }
}
