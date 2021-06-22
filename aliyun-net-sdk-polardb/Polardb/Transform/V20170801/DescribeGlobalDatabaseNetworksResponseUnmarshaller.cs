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
    public class DescribeGlobalDatabaseNetworksResponseUnmarshaller
    {
        public static DescribeGlobalDatabaseNetworksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGlobalDatabaseNetworksResponse describeGlobalDatabaseNetworksResponse = new DescribeGlobalDatabaseNetworksResponse();

			describeGlobalDatabaseNetworksResponse.HttpResponse = _ctx.HttpResponse;
			describeGlobalDatabaseNetworksResponse.TotalRecordCount = _ctx.IntegerValue("DescribeGlobalDatabaseNetworks.TotalRecordCount");
			describeGlobalDatabaseNetworksResponse.PageRecordCount = _ctx.IntegerValue("DescribeGlobalDatabaseNetworks.PageRecordCount");
			describeGlobalDatabaseNetworksResponse.RequestId = _ctx.StringValue("DescribeGlobalDatabaseNetworks.RequestId");
			describeGlobalDatabaseNetworksResponse.PageNumber = _ctx.IntegerValue("DescribeGlobalDatabaseNetworks.PageNumber");

			List<DescribeGlobalDatabaseNetworksResponse.DescribeGlobalDatabaseNetworks_GlobalDatabaseNetwork> describeGlobalDatabaseNetworksResponse_items = new List<DescribeGlobalDatabaseNetworksResponse.DescribeGlobalDatabaseNetworks_GlobalDatabaseNetwork>();
			for (int i = 0; i < _ctx.Length("DescribeGlobalDatabaseNetworks.Items.Length"); i++) {
				DescribeGlobalDatabaseNetworksResponse.DescribeGlobalDatabaseNetworks_GlobalDatabaseNetwork globalDatabaseNetwork = new DescribeGlobalDatabaseNetworksResponse.DescribeGlobalDatabaseNetworks_GlobalDatabaseNetwork();
				globalDatabaseNetwork.DBVersion = _ctx.StringValue("DescribeGlobalDatabaseNetworks.Items["+ i +"].DBVersion");
				globalDatabaseNetwork.GDNId = _ctx.StringValue("DescribeGlobalDatabaseNetworks.Items["+ i +"].GDNId");
				globalDatabaseNetwork.CreateTime = _ctx.StringValue("DescribeGlobalDatabaseNetworks.Items["+ i +"].CreateTime");
				globalDatabaseNetwork.GDNStatus = _ctx.StringValue("DescribeGlobalDatabaseNetworks.Items["+ i +"].GDNStatus");
				globalDatabaseNetwork.DBType = _ctx.StringValue("DescribeGlobalDatabaseNetworks.Items["+ i +"].DBType");
				globalDatabaseNetwork.GDNDescription = _ctx.StringValue("DescribeGlobalDatabaseNetworks.Items["+ i +"].GDNDescription");

				List<DescribeGlobalDatabaseNetworksResponse.DescribeGlobalDatabaseNetworks_GlobalDatabaseNetwork.DescribeGlobalDatabaseNetworks_DBCluster> globalDatabaseNetwork_dBClusters = new List<DescribeGlobalDatabaseNetworksResponse.DescribeGlobalDatabaseNetworks_GlobalDatabaseNetwork.DescribeGlobalDatabaseNetworks_DBCluster>();
				for (int j = 0; j < _ctx.Length("DescribeGlobalDatabaseNetworks.Items["+ i +"].DBClusters.Length"); j++) {
					DescribeGlobalDatabaseNetworksResponse.DescribeGlobalDatabaseNetworks_GlobalDatabaseNetwork.DescribeGlobalDatabaseNetworks_DBCluster dBCluster = new DescribeGlobalDatabaseNetworksResponse.DescribeGlobalDatabaseNetworks_GlobalDatabaseNetwork.DescribeGlobalDatabaseNetworks_DBCluster();
					dBCluster.DBClusterId = _ctx.StringValue("DescribeGlobalDatabaseNetworks.Items["+ i +"].DBClusters["+ j +"].DBClusterId");
					dBCluster.Role = _ctx.StringValue("DescribeGlobalDatabaseNetworks.Items["+ i +"].DBClusters["+ j +"].Role");
					dBCluster.RegionId = _ctx.StringValue("DescribeGlobalDatabaseNetworks.Items["+ i +"].DBClusters["+ j +"].RegionId");

					globalDatabaseNetwork_dBClusters.Add(dBCluster);
				}
				globalDatabaseNetwork.DBClusters = globalDatabaseNetwork_dBClusters;

				describeGlobalDatabaseNetworksResponse_items.Add(globalDatabaseNetwork);
			}
			describeGlobalDatabaseNetworksResponse.Items = describeGlobalDatabaseNetworksResponse_items;
        
			return describeGlobalDatabaseNetworksResponse;
        }
    }
}
