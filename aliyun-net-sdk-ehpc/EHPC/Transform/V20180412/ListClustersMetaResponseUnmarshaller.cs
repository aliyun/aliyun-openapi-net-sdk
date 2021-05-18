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
    public class ListClustersMetaResponseUnmarshaller
    {
        public static ListClustersMetaResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListClustersMetaResponse listClustersMetaResponse = new ListClustersMetaResponse();

			listClustersMetaResponse.HttpResponse = _ctx.HttpResponse;
			listClustersMetaResponse.RequestId = _ctx.StringValue("ListClustersMeta.RequestId");
			listClustersMetaResponse.TotalCount = _ctx.IntegerValue("ListClustersMeta.TotalCount");
			listClustersMetaResponse.PageNumber = _ctx.IntegerValue("ListClustersMeta.PageNumber");
			listClustersMetaResponse.PageSize = _ctx.IntegerValue("ListClustersMeta.PageSize");

			List<ListClustersMetaResponse.ListClustersMeta_ClusterInfoSimple> listClustersMetaResponse_clusters = new List<ListClustersMetaResponse.ListClustersMeta_ClusterInfoSimple>();
			for (int i = 0; i < _ctx.Length("ListClustersMeta.Clusters.Length"); i++) {
				ListClustersMetaResponse.ListClustersMeta_ClusterInfoSimple clusterInfoSimple = new ListClustersMetaResponse.ListClustersMeta_ClusterInfoSimple();
				clusterInfoSimple.Id = _ctx.StringValue("ListClustersMeta.Clusters["+ i +"].Id");
				clusterInfoSimple.Name = _ctx.StringValue("ListClustersMeta.Clusters["+ i +"].Name");
				clusterInfoSimple.Description = _ctx.StringValue("ListClustersMeta.Clusters["+ i +"].Description");
				clusterInfoSimple.Status = _ctx.StringValue("ListClustersMeta.Clusters["+ i +"].Status");
				clusterInfoSimple.Location = _ctx.StringValue("ListClustersMeta.Clusters["+ i +"].Location");
				clusterInfoSimple.OsTag = _ctx.StringValue("ListClustersMeta.Clusters["+ i +"].OsTag");
				clusterInfoSimple.ClientVersion = _ctx.StringValue("ListClustersMeta.Clusters["+ i +"].ClientVersion");
				clusterInfoSimple.AccountType = _ctx.StringValue("ListClustersMeta.Clusters["+ i +"].AccountType");
				clusterInfoSimple.SchedulerType = _ctx.StringValue("ListClustersMeta.Clusters["+ i +"].SchedulerType");
				clusterInfoSimple.VpcId = _ctx.StringValue("ListClustersMeta.Clusters["+ i +"].VpcId");
				clusterInfoSimple.DeployMode = _ctx.StringValue("ListClustersMeta.Clusters["+ i +"].DeployMode");
				clusterInfoSimple.IsComputeEss = _ctx.BooleanValue("ListClustersMeta.Clusters["+ i +"].IsComputeEss");

				listClustersMetaResponse_clusters.Add(clusterInfoSimple);
			}
			listClustersMetaResponse.Clusters = listClustersMetaResponse_clusters;
        
			return listClustersMetaResponse;
        }
    }
}
