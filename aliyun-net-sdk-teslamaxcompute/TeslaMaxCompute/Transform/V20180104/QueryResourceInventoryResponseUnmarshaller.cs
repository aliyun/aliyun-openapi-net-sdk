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
    public class QueryResourceInventoryResponseUnmarshaller
    {
        public static QueryResourceInventoryResponse Unmarshall(UnmarshallerContext context)
        {
			QueryResourceInventoryResponse queryResourceInventoryResponse = new QueryResourceInventoryResponse();

			queryResourceInventoryResponse.HttpResponse = context.HttpResponse;
			queryResourceInventoryResponse.Code = context.IntegerValue("QueryResourceInventory.Code");
			queryResourceInventoryResponse.Message = context.StringValue("QueryResourceInventory.Message");
			queryResourceInventoryResponse.RequestId = context.StringValue("QueryResourceInventory.RequestId");

			QueryResourceInventoryResponse.QueryResourceInventory_Data data = new QueryResourceInventoryResponse.QueryResourceInventory_Data();
			data.LastUpdate = context.StringValue("QueryResourceInventory.Data.LastUpdate");

			List<QueryResourceInventoryResponse.QueryResourceInventory_Data.QueryResourceInventory_Cluster> data_clusters = new List<QueryResourceInventoryResponse.QueryResourceInventory_Data.QueryResourceInventory_Cluster>();
			for (int i = 0; i < context.Length("QueryResourceInventory.Data.Clusters.Length"); i++) {
				QueryResourceInventoryResponse.QueryResourceInventory_Data.QueryResourceInventory_Cluster cluster = new QueryResourceInventoryResponse.QueryResourceInventory_Data.QueryResourceInventory_Cluster();
				cluster.Status = context.StringValue("QueryResourceInventory.Data.Clusters["+ i +"].Status");
				cluster.Cluster = context.StringValue("QueryResourceInventory.Data.Clusters["+ i +"].Cluster");
				cluster.MachineRoom = context.StringValue("QueryResourceInventory.Data.Clusters["+ i +"].MachineRoom");
				cluster.Region = context.StringValue("QueryResourceInventory.Data.Clusters["+ i +"].Region");

				List<QueryResourceInventoryResponse.QueryResourceInventory_Data.QueryResourceInventory_Cluster.QueryResourceInventory_ResourceParameter> cluster_resourceParameters = new List<QueryResourceInventoryResponse.QueryResourceInventory_Data.QueryResourceInventory_Cluster.QueryResourceInventory_ResourceParameter>();
				for (int j = 0; j < context.Length("QueryResourceInventory.Data.Clusters["+ i +"].ResourceParameters.Length"); j++) {
					QueryResourceInventoryResponse.QueryResourceInventory_Data.QueryResourceInventory_Cluster.QueryResourceInventory_ResourceParameter resourceParameter = new QueryResourceInventoryResponse.QueryResourceInventory_Data.QueryResourceInventory_Cluster.QueryResourceInventory_ResourceParameter();
					resourceParameter.ParaName = context.StringValue("QueryResourceInventory.Data.Clusters["+ i +"].ResourceParameters["+ j +"].ParaName");
					resourceParameter.ParaValue = context.StringValue("QueryResourceInventory.Data.Clusters["+ i +"].ResourceParameters["+ j +"].ParaValue");

					cluster_resourceParameters.Add(resourceParameter);
				}
				cluster.ResourceParameters = cluster_resourceParameters;

				List<QueryResourceInventoryResponse.QueryResourceInventory_Data.QueryResourceInventory_Cluster.QueryResourceInventory_ResourceInventory> cluster_resourceInventories = new List<QueryResourceInventoryResponse.QueryResourceInventory_Data.QueryResourceInventory_Cluster.QueryResourceInventory_ResourceInventory>();
				for (int j = 0; j < context.Length("QueryResourceInventory.Data.Clusters["+ i +"].ResourceInventories.Length"); j++) {
					QueryResourceInventoryResponse.QueryResourceInventory_Data.QueryResourceInventory_Cluster.QueryResourceInventory_ResourceInventory resourceInventory = new QueryResourceInventoryResponse.QueryResourceInventory_Data.QueryResourceInventory_Cluster.QueryResourceInventory_ResourceInventory();
					resourceInventory.Total = context.LongValue("QueryResourceInventory.Data.Clusters["+ i +"].ResourceInventories["+ j +"].Total");
					resourceInventory.Available = context.LongValue("QueryResourceInventory.Data.Clusters["+ i +"].ResourceInventories["+ j +"].Available");
					resourceInventory.Used = context.LongValue("QueryResourceInventory.Data.Clusters["+ i +"].ResourceInventories["+ j +"].Used");
					resourceInventory.ResourceType = context.StringValue("QueryResourceInventory.Data.Clusters["+ i +"].ResourceInventories["+ j +"].ResourceType");

					cluster_resourceInventories.Add(resourceInventory);
				}
				cluster.ResourceInventories = cluster_resourceInventories;

				data_clusters.Add(cluster);
			}
			data.Clusters = data_clusters;
			queryResourceInventoryResponse.Data = data;
        
			return queryResourceInventoryResponse;
        }
    }
}