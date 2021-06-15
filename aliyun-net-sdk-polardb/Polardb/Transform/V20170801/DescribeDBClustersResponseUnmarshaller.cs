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
    public class DescribeDBClustersResponseUnmarshaller
    {
        public static DescribeDBClustersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBClustersResponse describeDBClustersResponse = new DescribeDBClustersResponse();

			describeDBClustersResponse.HttpResponse = _ctx.HttpResponse;
			describeDBClustersResponse.TotalRecordCount = _ctx.IntegerValue("DescribeDBClusters.TotalRecordCount");
			describeDBClustersResponse.PageRecordCount = _ctx.IntegerValue("DescribeDBClusters.PageRecordCount");
			describeDBClustersResponse.RequestId = _ctx.StringValue("DescribeDBClusters.RequestId");
			describeDBClustersResponse.PageNumber = _ctx.IntegerValue("DescribeDBClusters.PageNumber");

			List<DescribeDBClustersResponse.DescribeDBClusters_DBCluster> describeDBClustersResponse_items = new List<DescribeDBClustersResponse.DescribeDBClusters_DBCluster>();
			for (int i = 0; i < _ctx.Length("DescribeDBClusters.Items.Length"); i++) {
				DescribeDBClustersResponse.DescribeDBClusters_DBCluster dBCluster = new DescribeDBClustersResponse.DescribeDBClusters_DBCluster();
				dBCluster.VpcId = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].VpcId");
				dBCluster.ExpireTime = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].ExpireTime");
				dBCluster.Expired = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].Expired");
				dBCluster.DBNodeNumber = _ctx.IntegerValue("DescribeDBClusters.Items["+ i +"].DBNodeNumber");
				dBCluster.CreateTime = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].CreateTime");
				dBCluster.PayType = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].PayType");
				dBCluster.DBNodeClass = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].DBNodeClass");
				dBCluster.DBType = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].DBType");
				dBCluster.LockMode = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].LockMode");
				dBCluster.RegionId = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].RegionId");
				dBCluster.DeletionLock = _ctx.IntegerValue("DescribeDBClusters.Items["+ i +"].DeletionLock");
				dBCluster.DBVersion = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].DBVersion");
				dBCluster.DBClusterId = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].DBClusterId");
				dBCluster.DBClusterStatus = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].DBClusterStatus");
				dBCluster.ResourceGroupId = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].ResourceGroupId");
				dBCluster.StorageUsed = _ctx.LongValue("DescribeDBClusters.Items["+ i +"].StorageUsed");
				dBCluster.DBClusterNetworkType = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].DBClusterNetworkType");
				dBCluster.DBClusterDescription = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].DBClusterDescription");
				dBCluster.ZoneId = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].ZoneId");
				dBCluster.Engine = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].Engine");

				List<DescribeDBClustersResponse.DescribeDBClusters_DBCluster.DescribeDBClusters_Tag> dBCluster_tags = new List<DescribeDBClustersResponse.DescribeDBClusters_DBCluster.DescribeDBClusters_Tag>();
				for (int j = 0; j < _ctx.Length("DescribeDBClusters.Items["+ i +"].Tags.Length"); j++) {
					DescribeDBClustersResponse.DescribeDBClusters_DBCluster.DescribeDBClusters_Tag tag = new DescribeDBClustersResponse.DescribeDBClusters_DBCluster.DescribeDBClusters_Tag();
					tag.Key = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].Tags["+ j +"].Key");
					tag._Value = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].Tags["+ j +"].Value");

					dBCluster_tags.Add(tag);
				}
				dBCluster.Tags = dBCluster_tags;

				List<DescribeDBClustersResponse.DescribeDBClusters_DBCluster.DescribeDBClusters_DBNode> dBCluster_dBNodes = new List<DescribeDBClustersResponse.DescribeDBClusters_DBCluster.DescribeDBClusters_DBNode>();
				for (int j = 0; j < _ctx.Length("DescribeDBClusters.Items["+ i +"].DBNodes.Length"); j++) {
					DescribeDBClustersResponse.DescribeDBClusters_DBCluster.DescribeDBClusters_DBNode dBNode = new DescribeDBClustersResponse.DescribeDBClusters_DBCluster.DescribeDBClusters_DBNode();
					dBNode.DBNodeClass = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].DBNodes["+ j +"].DBNodeClass");
					dBNode.ZoneId = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].DBNodes["+ j +"].ZoneId");
					dBNode.DBNodeRole = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].DBNodes["+ j +"].DBNodeRole");
					dBNode.DBNodeId = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].DBNodes["+ j +"].DBNodeId");
					dBNode.RegionId = _ctx.StringValue("DescribeDBClusters.Items["+ i +"].DBNodes["+ j +"].RegionId");

					dBCluster_dBNodes.Add(dBNode);
				}
				dBCluster.DBNodes = dBCluster_dBNodes;

				describeDBClustersResponse_items.Add(dBCluster);
			}
			describeDBClustersResponse.Items = describeDBClustersResponse_items;
        
			return describeDBClustersResponse;
        }
    }
}
