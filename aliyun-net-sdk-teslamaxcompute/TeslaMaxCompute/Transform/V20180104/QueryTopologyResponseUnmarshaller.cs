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

			QueryTopologyResponse.QueryTopology_Result result = new QueryTopologyResponse.QueryTopology_Result();
			result.LastUpdate = context.StringValue("QueryTopology.Result.LastUpdate");

			QueryTopologyResponse.QueryTopology_Result.QueryTopology_Regions regions = new QueryTopologyResponse.QueryTopology_Result.QueryTopology_Regions();
			regions.Region = context.StringValue("QueryTopology.Result.Regions.Region");
			regions.RegionEnName = context.StringValue("QueryTopology.Result.Regions.RegionEnName");
			regions.RegionCnName = context.StringValue("QueryTopology.Result.Regions.RegionCnName");

			QueryTopologyResponse.QueryTopology_Result.QueryTopology_Regions.QueryTopology_Clusters clusters = new QueryTopologyResponse.QueryTopology_Result.QueryTopology_Regions.QueryTopology_Clusters();
			clusters.Cluster = context.StringValue("QueryTopology.Result.Regions.Clusters.Cluster");
			clusters.ProductLine = context.StringValue("QueryTopology.Result.Regions.Clusters.ProductLine");
			clusters.ProductClass = context.StringValue("QueryTopology.Result.Regions.Clusters.ProductClass");
			clusters.NetCode = context.StringValue("QueryTopology.Result.Regions.Clusters.NetCode");
			clusters.Business = context.StringValue("QueryTopology.Result.Regions.Clusters.Business");
			clusters.MachineRoom = context.StringValue("QueryTopology.Result.Regions.Clusters.MachineRoom");
			clusters.NetArch = context.StringValue("QueryTopology.Result.Regions.Clusters.NetArch");
			regions.Clusters = clusters;
			result.Regions = regions;
			queryTopologyResponse.Result = result;
        
			return queryTopologyResponse;
        }
    }
}