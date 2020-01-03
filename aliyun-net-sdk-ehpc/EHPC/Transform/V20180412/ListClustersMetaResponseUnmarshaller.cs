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
        public static ListClustersMetaResponse Unmarshall(UnmarshallerContext context)
        {
			ListClustersMetaResponse listClustersMetaResponse = new ListClustersMetaResponse();

			listClustersMetaResponse.HttpResponse = context.HttpResponse;
			listClustersMetaResponse.RequestId = context.StringValue("ListClustersMeta.RequestId");
			listClustersMetaResponse.TotalCount = context.IntegerValue("ListClustersMeta.TotalCount");
			listClustersMetaResponse.PageNumber = context.IntegerValue("ListClustersMeta.PageNumber");
			listClustersMetaResponse.PageSize = context.IntegerValue("ListClustersMeta.PageSize");

			List<ListClustersMetaResponse.ListClustersMeta_ClusterInfoSimple> listClustersMetaResponse_clusters = new List<ListClustersMetaResponse.ListClustersMeta_ClusterInfoSimple>();
			for (int i = 0; i < context.Length("ListClustersMeta.Clusters.Length"); i++) {
				ListClustersMetaResponse.ListClustersMeta_ClusterInfoSimple clusterInfoSimple = new ListClustersMetaResponse.ListClustersMeta_ClusterInfoSimple();
				clusterInfoSimple.Id = context.StringValue("ListClustersMeta.Clusters["+ i +"].Id");
				clusterInfoSimple.Name = context.StringValue("ListClustersMeta.Clusters["+ i +"].Name");
				clusterInfoSimple.Description = context.StringValue("ListClustersMeta.Clusters["+ i +"].Description");
				clusterInfoSimple.Status = context.StringValue("ListClustersMeta.Clusters["+ i +"].Status");
				clusterInfoSimple.Location = context.StringValue("ListClustersMeta.Clusters["+ i +"].Location");

				listClustersMetaResponse_clusters.Add(clusterInfoSimple);
			}
			listClustersMetaResponse.Clusters = listClustersMetaResponse_clusters;
        
			return listClustersMetaResponse;
        }
    }
}
