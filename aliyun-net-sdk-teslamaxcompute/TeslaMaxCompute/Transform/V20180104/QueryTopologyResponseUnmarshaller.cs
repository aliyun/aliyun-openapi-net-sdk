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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.TeslaMaxCompute.Model.V20180104;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.TeslaMaxCompute.Transform.V20180104
{
    public class QueryTopologyResponseUnmarshaller
    {
        public static QueryTopologyResponse Unmarshall(UnmarshallerContext context)
        {
			QueryTopologyResponse queryTopologyResponse = new QueryTopologyResponse();

			queryTopologyResponse.HttpResponse = context.HttpResponse;
			queryTopologyResponse.Code = context.IntegerValue("QueryTopology.Code");
			queryTopologyResponse.Message = context.StringValue("QueryTopology.Message");
			queryTopologyResponse.RequestId = context.StringValue("QueryTopology.RequestId");

			List<QueryTopologyResponse.QueryTopology_ResultItem> queryTopologyResponse_result = new List<QueryTopologyResponse.QueryTopology_ResultItem>();
			for (int i = 0; i < context.Length("QueryTopology.Result.Length"); i++) {
				QueryTopologyResponse.QueryTopology_ResultItem resultItem = new QueryTopologyResponse.QueryTopology_ResultItem();
				resultItem.LastUpdate = context.StringValue("QueryTopology.Result["+ i +"].LastUpdate");

				List<QueryTopologyResponse.QueryTopology_ResultItem.QueryTopology_RegionItem> resultItem_regions = new List<QueryTopologyResponse.QueryTopology_ResultItem.QueryTopology_RegionItem>();
				for (int j = 0; j < context.Length("QueryTopology.Result["+ i +"].Regions.Length"); j++) {
					QueryTopologyResponse.QueryTopology_ResultItem.QueryTopology_RegionItem regionItem = new QueryTopologyResponse.QueryTopology_ResultItem.QueryTopology_RegionItem();
					regionItem.Region = context.StringValue("QueryTopology.Result["+ i +"].Regions["+ j +"].Region");
					regionItem.RegionEnName = context.StringValue("QueryTopology.Result["+ i +"].Regions["+ j +"].RegionEnName");
					regionItem.RegionCnName = context.StringValue("QueryTopology.Result["+ i +"].Regions["+ j +"].RegionCnName");

					List<QueryTopologyResponse.QueryTopology_ResultItem.QueryTopology_RegionItem.QueryTopology_ClusterItem> regionItem_clusters = new List<QueryTopologyResponse.QueryTopology_ResultItem.QueryTopology_RegionItem.QueryTopology_ClusterItem>();
					for (int k = 0; k < context.Length("QueryTopology.Result["+ i +"].Regions["+ j +"].Clusters.Length"); k++) {
						QueryTopologyResponse.QueryTopology_ResultItem.QueryTopology_RegionItem.QueryTopology_ClusterItem clusterItem = new QueryTopologyResponse.QueryTopology_ResultItem.QueryTopology_RegionItem.QueryTopology_ClusterItem();
						clusterItem.Cluster = context.StringValue("QueryTopology.Result["+ i +"].Regions["+ j +"].Clusters["+ k +"].Cluster");
						clusterItem.ProductLine = context.StringValue("QueryTopology.Result["+ i +"].Regions["+ j +"].Clusters["+ k +"].ProductLine");
						clusterItem.ProductClass = context.StringValue("QueryTopology.Result["+ i +"].Regions["+ j +"].Clusters["+ k +"].ProductClass");
						clusterItem.NetCode = context.StringValue("QueryTopology.Result["+ i +"].Regions["+ j +"].Clusters["+ k +"].NetCode");
						clusterItem.Business = context.StringValue("QueryTopology.Result["+ i +"].Regions["+ j +"].Clusters["+ k +"].Business");
						clusterItem.MachineRoom = context.StringValue("QueryTopology.Result["+ i +"].Regions["+ j +"].Clusters["+ k +"].MachineRoom");
						clusterItem.NetArch = context.StringValue("QueryTopology.Result["+ i +"].Regions["+ j +"].Clusters["+ k +"].NetArch");

						regionItem_clusters.Add(clusterItem);
					}
					regionItem.Clusters = regionItem_clusters;

					resultItem_regions.Add(regionItem);
				}
				resultItem.Regions = resultItem_regions;

				queryTopologyResponse_result.Add(resultItem);
			}
			queryTopologyResponse.Result = queryTopologyResponse_result;
        
			return queryTopologyResponse;
        }
    }
}