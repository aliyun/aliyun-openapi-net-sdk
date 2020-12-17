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
using Aliyun.Acs.servicemesh.Model.V20200111;

namespace Aliyun.Acs.servicemesh.Transform.V20200111
{
    public class DescribeClustersInServiceMeshResponseUnmarshaller
    {
        public static DescribeClustersInServiceMeshResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeClustersInServiceMeshResponse describeClustersInServiceMeshResponse = new DescribeClustersInServiceMeshResponse();

			describeClustersInServiceMeshResponse.HttpResponse = _ctx.HttpResponse;
			describeClustersInServiceMeshResponse.RequestId = _ctx.StringValue("DescribeClustersInServiceMesh.RequestId");

			List<DescribeClustersInServiceMeshResponse.DescribeClustersInServiceMesh_Cluster> describeClustersInServiceMeshResponse_clusters = new List<DescribeClustersInServiceMeshResponse.DescribeClustersInServiceMesh_Cluster>();
			for (int i = 0; i < _ctx.Length("DescribeClustersInServiceMesh.Clusters.Length"); i++) {
				DescribeClustersInServiceMeshResponse.DescribeClustersInServiceMesh_Cluster cluster = new DescribeClustersInServiceMeshResponse.DescribeClustersInServiceMesh_Cluster();
				cluster.ClusterId = _ctx.StringValue("DescribeClustersInServiceMesh.Clusters["+ i +"].ClusterId");
				cluster.ClusterType = _ctx.StringValue("DescribeClustersInServiceMesh.Clusters["+ i +"].ClusterType");
				cluster.CreationTime = _ctx.StringValue("DescribeClustersInServiceMesh.Clusters["+ i +"].CreationTime");
				cluster.ErrorMessage = _ctx.StringValue("DescribeClustersInServiceMesh.Clusters["+ i +"].ErrorMessage");
				cluster.Name = _ctx.StringValue("DescribeClustersInServiceMesh.Clusters["+ i +"].Name");
				cluster.RegionId = _ctx.StringValue("DescribeClustersInServiceMesh.Clusters["+ i +"].RegionId");
				cluster.State = _ctx.StringValue("DescribeClustersInServiceMesh.Clusters["+ i +"].State");
				cluster.UpdateTime = _ctx.StringValue("DescribeClustersInServiceMesh.Clusters["+ i +"].UpdateTime");
				cluster.Version = _ctx.StringValue("DescribeClustersInServiceMesh.Clusters["+ i +"].Version");
				cluster.VpcId = _ctx.StringValue("DescribeClustersInServiceMesh.Clusters["+ i +"].VpcId");
				cluster.SgId = _ctx.StringValue("DescribeClustersInServiceMesh.Clusters["+ i +"].SgId");
				cluster.ClusterDomain = _ctx.StringValue("DescribeClustersInServiceMesh.Clusters["+ i +"].ClusterDomain");

				describeClustersInServiceMeshResponse_clusters.Add(cluster);
			}
			describeClustersInServiceMeshResponse.Clusters = describeClustersInServiceMeshResponse_clusters;
        
			return describeClustersInServiceMeshResponse;
        }
    }
}
