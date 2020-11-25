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
    public class DescribeHpcClustersResponseUnmarshaller
    {
        public static DescribeHpcClustersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeHpcClustersResponse describeHpcClustersResponse = new DescribeHpcClustersResponse();

			describeHpcClustersResponse.HttpResponse = _ctx.HttpResponse;
			describeHpcClustersResponse.RequestId = _ctx.StringValue("DescribeHpcClusters.RequestId");
			describeHpcClustersResponse.TotalCount = _ctx.IntegerValue("DescribeHpcClusters.TotalCount");
			describeHpcClustersResponse.PageNumber = _ctx.IntegerValue("DescribeHpcClusters.PageNumber");
			describeHpcClustersResponse.PageSize = _ctx.IntegerValue("DescribeHpcClusters.PageSize");

			List<DescribeHpcClustersResponse.DescribeHpcClusters_HpcCluster> describeHpcClustersResponse_hpcClusters = new List<DescribeHpcClustersResponse.DescribeHpcClusters_HpcCluster>();
			for (int i = 0; i < _ctx.Length("DescribeHpcClusters.HpcClusters.Length"); i++) {
				DescribeHpcClustersResponse.DescribeHpcClusters_HpcCluster hpcCluster = new DescribeHpcClustersResponse.DescribeHpcClusters_HpcCluster();
				hpcCluster.HpcClusterId = _ctx.StringValue("DescribeHpcClusters.HpcClusters["+ i +"].HpcClusterId");
				hpcCluster.Name = _ctx.StringValue("DescribeHpcClusters.HpcClusters["+ i +"].Name");
				hpcCluster.Description = _ctx.StringValue("DescribeHpcClusters.HpcClusters["+ i +"].Description");

				describeHpcClustersResponse_hpcClusters.Add(hpcCluster);
			}
			describeHpcClustersResponse.HpcClusters = describeHpcClustersResponse_hpcClusters;
        
			return describeHpcClustersResponse;
        }
    }
}
