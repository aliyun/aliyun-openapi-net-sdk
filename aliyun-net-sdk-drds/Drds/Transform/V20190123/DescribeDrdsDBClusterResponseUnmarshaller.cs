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
using Aliyun.Acs.Drds.Model.V20190123;

namespace Aliyun.Acs.Drds.Transform.V20190123
{
    public class DescribeDrdsDBClusterResponseUnmarshaller
    {
        public static DescribeDrdsDBClusterResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDrdsDBClusterResponse describeDrdsDBClusterResponse = new DescribeDrdsDBClusterResponse();

			describeDrdsDBClusterResponse.HttpResponse = _ctx.HttpResponse;
			describeDrdsDBClusterResponse.RequestId = _ctx.StringValue("DescribeDrdsDBCluster.RequestId");
			describeDrdsDBClusterResponse.Success = _ctx.BooleanValue("DescribeDrdsDBCluster.Success");

			DescribeDrdsDBClusterResponse.DescribeDrdsDBCluster_DbInstance dbInstance = new DescribeDrdsDBClusterResponse.DescribeDrdsDBCluster_DbInstance();
			dbInstance.DBInstanceId = _ctx.StringValue("DescribeDrdsDBCluster.DbInstance.DBInstanceId");
			dbInstance.Port = _ctx.IntegerValue("DescribeDrdsDBCluster.DbInstance.Port");
			dbInstance.DBInstanceStatus = _ctx.StringValue("DescribeDrdsDBCluster.DbInstance.DBInstanceStatus");
			dbInstance.DbInstType = _ctx.StringValue("DescribeDrdsDBCluster.DbInstance.DbInstType");
			dbInstance.Engine = _ctx.StringValue("DescribeDrdsDBCluster.DbInstance.Engine");
			dbInstance.EngineVersion = _ctx.StringValue("DescribeDrdsDBCluster.DbInstance.EngineVersion");
			dbInstance.RdsInstType = _ctx.StringValue("DescribeDrdsDBCluster.DbInstance.RdsInstType");
			dbInstance.PayType = _ctx.StringValue("DescribeDrdsDBCluster.DbInstance.PayType");
			dbInstance.ExpireTime = _ctx.StringValue("DescribeDrdsDBCluster.DbInstance.ExpireTime");
			dbInstance.RemainDays = _ctx.StringValue("DescribeDrdsDBCluster.DbInstance.RemainDays");
			dbInstance.NetworkType = _ctx.StringValue("DescribeDrdsDBCluster.DbInstance.NetworkType");
			dbInstance.ReadMode = _ctx.StringValue("DescribeDrdsDBCluster.DbInstance.ReadMode");

			List<DescribeDrdsDBClusterResponse.DescribeDrdsDBCluster_DbInstance.DescribeDrdsDBCluster_Endpoint> dbInstance_endpoints = new List<DescribeDrdsDBClusterResponse.DescribeDrdsDBCluster_DbInstance.DescribeDrdsDBCluster_Endpoint>();
			for (int i = 0; i < _ctx.Length("DescribeDrdsDBCluster.DbInstance.Endpoints.Length"); i++) {
				DescribeDrdsDBClusterResponse.DescribeDrdsDBCluster_DbInstance.DescribeDrdsDBCluster_Endpoint endpoint = new DescribeDrdsDBClusterResponse.DescribeDrdsDBCluster_DbInstance.DescribeDrdsDBCluster_Endpoint();
				endpoint.NodeIds = _ctx.StringValue("DescribeDrdsDBCluster.DbInstance.Endpoints["+ i +"].NodeIds");
				endpoint.EndpointId = _ctx.StringValue("DescribeDrdsDBCluster.DbInstance.Endpoints["+ i +"].EndpointId");
				endpoint.ReadWeight = _ctx.IntegerValue("DescribeDrdsDBCluster.DbInstance.Endpoints["+ i +"].ReadWeight");

				dbInstance_endpoints.Add(endpoint);
			}
			dbInstance.Endpoints = dbInstance_endpoints;

			List<DescribeDrdsDBClusterResponse.DescribeDrdsDBCluster_DbInstance.DescribeDrdsDBCluster_DBNode> dbInstance_dBNodes = new List<DescribeDrdsDBClusterResponse.DescribeDrdsDBCluster_DbInstance.DescribeDrdsDBCluster_DBNode>();
			for (int i = 0; i < _ctx.Length("DescribeDrdsDBCluster.DbInstance.DBNodes.Length"); i++) {
				DescribeDrdsDBClusterResponse.DescribeDrdsDBCluster_DbInstance.DescribeDrdsDBCluster_DBNode dBNode = new DescribeDrdsDBClusterResponse.DescribeDrdsDBCluster_DbInstance.DescribeDrdsDBCluster_DBNode();
				dBNode.DBNodeId = _ctx.StringValue("DescribeDrdsDBCluster.DbInstance.DBNodes["+ i +"].DBNodeId");
				dBNode.ZoneId = _ctx.StringValue("DescribeDrdsDBCluster.DbInstance.DBNodes["+ i +"].ZoneId");
				dBNode.DBNodeStatus = _ctx.StringValue("DescribeDrdsDBCluster.DbInstance.DBNodes["+ i +"].DBNodeStatus");
				dBNode.DBNodeRole = _ctx.StringValue("DescribeDrdsDBCluster.DbInstance.DBNodes["+ i +"].DBNodeRole");

				dbInstance_dBNodes.Add(dBNode);
			}
			dbInstance.DBNodes = dbInstance_dBNodes;
			describeDrdsDBClusterResponse.DbInstance = dbInstance;
        
			return describeDrdsDBClusterResponse;
        }
    }
}
