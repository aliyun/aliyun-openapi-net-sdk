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
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class InsertClusterResponseUnmarshaller
    {
        public static InsertClusterResponse Unmarshall(UnmarshallerContext _ctx)
        {
			InsertClusterResponse insertClusterResponse = new InsertClusterResponse();

			insertClusterResponse.HttpResponse = _ctx.HttpResponse;
			insertClusterResponse.Code = _ctx.IntegerValue("InsertCluster.Code");
			insertClusterResponse.Message = _ctx.StringValue("InsertCluster.Message");
			insertClusterResponse.RequestId = _ctx.StringValue("InsertCluster.RequestId");

			InsertClusterResponse.InsertCluster_Cluster cluster = new InsertClusterResponse.InsertCluster_Cluster();
			cluster.ClusterId = _ctx.StringValue("InsertCluster.Cluster.ClusterId");
			cluster.RegionId = _ctx.StringValue("InsertCluster.Cluster.RegionId");
			cluster.ClusterName = _ctx.StringValue("InsertCluster.Cluster.ClusterName");
			cluster.ClusterType = _ctx.IntegerValue("InsertCluster.Cluster.ClusterType");
			cluster.OversoldFactor = _ctx.IntegerValue("InsertCluster.Cluster.OversoldFactor");
			cluster.NetworkMode = _ctx.IntegerValue("InsertCluster.Cluster.NetworkMode");
			cluster.VpcId = _ctx.StringValue("InsertCluster.Cluster.VpcId");
			cluster.IaasProvider = _ctx.StringValue("InsertCluster.Cluster.IaasProvider");
			insertClusterResponse.Cluster = cluster;
        
			return insertClusterResponse;
        }
    }
}
