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
using Aliyun.Acs.polardb.Model.V20170801;

namespace Aliyun.Acs.polardb.Transform.V20170801
{
    public class DescribeGlobalDatabaseNetworkResponseUnmarshaller
    {
        public static DescribeGlobalDatabaseNetworkResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGlobalDatabaseNetworkResponse describeGlobalDatabaseNetworkResponse = new DescribeGlobalDatabaseNetworkResponse();

			describeGlobalDatabaseNetworkResponse.HttpResponse = _ctx.HttpResponse;
			describeGlobalDatabaseNetworkResponse.GDNStatus = _ctx.StringValue("DescribeGlobalDatabaseNetwork.GDNStatus");
			describeGlobalDatabaseNetworkResponse.DBVersion = _ctx.StringValue("DescribeGlobalDatabaseNetwork.DBVersion");
			describeGlobalDatabaseNetworkResponse.RequestId = _ctx.StringValue("DescribeGlobalDatabaseNetwork.RequestId");
			describeGlobalDatabaseNetworkResponse.GDNId = _ctx.StringValue("DescribeGlobalDatabaseNetwork.GDNId");
			describeGlobalDatabaseNetworkResponse.CreateTime = _ctx.StringValue("DescribeGlobalDatabaseNetwork.CreateTime");
			describeGlobalDatabaseNetworkResponse.DBType = _ctx.StringValue("DescribeGlobalDatabaseNetwork.DBType");
			describeGlobalDatabaseNetworkResponse.GDNDescription = _ctx.StringValue("DescribeGlobalDatabaseNetwork.GDNDescription");

			List<DescribeGlobalDatabaseNetworkResponse.DescribeGlobalDatabaseNetwork_Connection> describeGlobalDatabaseNetworkResponse_connections = new List<DescribeGlobalDatabaseNetworkResponse.DescribeGlobalDatabaseNetwork_Connection>();
			for (int i = 0; i < _ctx.Length("DescribeGlobalDatabaseNetwork.Connections.Length"); i++) {
				DescribeGlobalDatabaseNetworkResponse.DescribeGlobalDatabaseNetwork_Connection connection = new DescribeGlobalDatabaseNetworkResponse.DescribeGlobalDatabaseNetwork_Connection();
				connection.ConnectionString = _ctx.StringValue("DescribeGlobalDatabaseNetwork.Connections["+ i +"].ConnectionString");
				connection.NetType = _ctx.StringValue("DescribeGlobalDatabaseNetwork.Connections["+ i +"].NetType");
				connection.Port = _ctx.StringValue("DescribeGlobalDatabaseNetwork.Connections["+ i +"].Port");

				describeGlobalDatabaseNetworkResponse_connections.Add(connection);
			}
			describeGlobalDatabaseNetworkResponse.Connections = describeGlobalDatabaseNetworkResponse_connections;

			List<DescribeGlobalDatabaseNetworkResponse.DescribeGlobalDatabaseNetwork_DBCluster> describeGlobalDatabaseNetworkResponse_dBClusters = new List<DescribeGlobalDatabaseNetworkResponse.DescribeGlobalDatabaseNetwork_DBCluster>();
			for (int i = 0; i < _ctx.Length("DescribeGlobalDatabaseNetwork.DBClusters.Length"); i++) {
				DescribeGlobalDatabaseNetworkResponse.DescribeGlobalDatabaseNetwork_DBCluster dBCluster = new DescribeGlobalDatabaseNetworkResponse.DescribeGlobalDatabaseNetwork_DBCluster();
				dBCluster.ReplicaLag = _ctx.StringValue("DescribeGlobalDatabaseNetwork.DBClusters["+ i +"].ReplicaLag");
				dBCluster.ExpireTime = _ctx.StringValue("DescribeGlobalDatabaseNetwork.DBClusters["+ i +"].ExpireTime");
				dBCluster.Expired = _ctx.StringValue("DescribeGlobalDatabaseNetwork.DBClusters["+ i +"].Expired");
				dBCluster.DBNodeClass = _ctx.StringValue("DescribeGlobalDatabaseNetwork.DBClusters["+ i +"].DBNodeClass");
				dBCluster.PayType = _ctx.StringValue("DescribeGlobalDatabaseNetwork.DBClusters["+ i +"].PayType");
				dBCluster.DBType = _ctx.StringValue("DescribeGlobalDatabaseNetwork.DBClusters["+ i +"].DBType");
				dBCluster.RegionId = _ctx.StringValue("DescribeGlobalDatabaseNetwork.DBClusters["+ i +"].RegionId");
				dBCluster.DBVersion = _ctx.StringValue("DescribeGlobalDatabaseNetwork.DBClusters["+ i +"].DBVersion");
				dBCluster.DBClusterId = _ctx.StringValue("DescribeGlobalDatabaseNetwork.DBClusters["+ i +"].DBClusterId");
				dBCluster.DBClusterStatus = _ctx.StringValue("DescribeGlobalDatabaseNetwork.DBClusters["+ i +"].DBClusterStatus");
				dBCluster.StorageUsed = _ctx.StringValue("DescribeGlobalDatabaseNetwork.DBClusters["+ i +"].StorageUsed");
				dBCluster.DBClusterDescription = _ctx.StringValue("DescribeGlobalDatabaseNetwork.DBClusters["+ i +"].DBClusterDescription");
				dBCluster.Role = _ctx.StringValue("DescribeGlobalDatabaseNetwork.DBClusters["+ i +"].Role");

				describeGlobalDatabaseNetworkResponse_dBClusters.Add(dBCluster);
			}
			describeGlobalDatabaseNetworkResponse.DBClusters = describeGlobalDatabaseNetworkResponse_dBClusters;
        
			return describeGlobalDatabaseNetworkResponse;
        }
    }
}
