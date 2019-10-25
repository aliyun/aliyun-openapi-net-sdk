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
        public static DescribeDBClustersResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDBClustersResponse describeDBClustersResponse = new DescribeDBClustersResponse();

			describeDBClustersResponse.HttpResponse = context.HttpResponse;
			describeDBClustersResponse.RequestId = context.StringValue("DescribeDBClusters.RequestId");
			describeDBClustersResponse.PageNumber = context.IntegerValue("DescribeDBClusters.PageNumber");
			describeDBClustersResponse.TotalRecordCount = context.IntegerValue("DescribeDBClusters.TotalRecordCount");
			describeDBClustersResponse.PageRecordCount = context.IntegerValue("DescribeDBClusters.PageRecordCount");

			List<DescribeDBClustersResponse.DescribeDBClusters_DBCluster> describeDBClustersResponse_items = new List<DescribeDBClustersResponse.DescribeDBClusters_DBCluster>();
			for (int i = 0; i < context.Length("DescribeDBClusters.Items.Length"); i++) {
				DescribeDBClustersResponse.DescribeDBClusters_DBCluster dBCluster = new DescribeDBClustersResponse.DescribeDBClusters_DBCluster();
				dBCluster.DBClusterId = context.StringValue("DescribeDBClusters.Items["+ i +"].DBClusterId");
				dBCluster.DBClusterDescription = context.StringValue("DescribeDBClusters.Items["+ i +"].DBClusterDescription");
				dBCluster.PayType = context.StringValue("DescribeDBClusters.Items["+ i +"].PayType");
				dBCluster.DBClusterNetworkType = context.StringValue("DescribeDBClusters.Items["+ i +"].DBClusterNetworkType");
				dBCluster.RegionId = context.StringValue("DescribeDBClusters.Items["+ i +"].RegionId");
				dBCluster.ZoneId = context.StringValue("DescribeDBClusters.Items["+ i +"].ZoneId");
				dBCluster.ExpireTime = context.StringValue("DescribeDBClusters.Items["+ i +"].ExpireTime");
				dBCluster.Expired = context.StringValue("DescribeDBClusters.Items["+ i +"].Expired");
				dBCluster.DBClusterStatus = context.StringValue("DescribeDBClusters.Items["+ i +"].DBClusterStatus");
				dBCluster.Engine = context.StringValue("DescribeDBClusters.Items["+ i +"].Engine");
				dBCluster.DBType = context.StringValue("DescribeDBClusters.Items["+ i +"].DBType");
				dBCluster.DBVersion = context.StringValue("DescribeDBClusters.Items["+ i +"].DBVersion");
				dBCluster.LockMode = context.StringValue("DescribeDBClusters.Items["+ i +"].LockMode");
				dBCluster.DeletionLock = context.IntegerValue("DescribeDBClusters.Items["+ i +"].DeletionLock");
				dBCluster.CreateTime = context.StringValue("DescribeDBClusters.Items["+ i +"].CreateTime");
				dBCluster.VpcId = context.StringValue("DescribeDBClusters.Items["+ i +"].VpcId");
				dBCluster.DBNodeNumber = context.IntegerValue("DescribeDBClusters.Items["+ i +"].DBNodeNumber");
				dBCluster.DBNodeClass = context.StringValue("DescribeDBClusters.Items["+ i +"].DBNodeClass");
				dBCluster.StorageUsed = context.LongValue("DescribeDBClusters.Items["+ i +"].StorageUsed");

				List<DescribeDBClustersResponse.DescribeDBClusters_DBCluster.DescribeDBClusters_DBNode> dBCluster_dBNodes = new List<DescribeDBClustersResponse.DescribeDBClusters_DBCluster.DescribeDBClusters_DBNode>();
				for (int j = 0; j < context.Length("DescribeDBClusters.Items["+ i +"].DBNodes.Length"); j++) {
					DescribeDBClustersResponse.DescribeDBClusters_DBCluster.DescribeDBClusters_DBNode dBNode = new DescribeDBClustersResponse.DescribeDBClusters_DBCluster.DescribeDBClusters_DBNode();
					dBNode.DBNodeId = context.StringValue("DescribeDBClusters.Items["+ i +"].DBNodes["+ j +"].DBNodeId");
					dBNode.DBNodeClass = context.StringValue("DescribeDBClusters.Items["+ i +"].DBNodes["+ j +"].DBNodeClass");
					dBNode.DBNodeRole = context.StringValue("DescribeDBClusters.Items["+ i +"].DBNodes["+ j +"].DBNodeRole");
					dBNode.RegionId = context.StringValue("DescribeDBClusters.Items["+ i +"].DBNodes["+ j +"].RegionId");
					dBNode.ZoneId = context.StringValue("DescribeDBClusters.Items["+ i +"].DBNodes["+ j +"].ZoneId");

					dBCluster_dBNodes.Add(dBNode);
				}
				dBCluster.DBNodes = dBCluster_dBNodes;

				List<DescribeDBClustersResponse.DescribeDBClusters_DBCluster.DescribeDBClusters_Tag> dBCluster_tags = new List<DescribeDBClustersResponse.DescribeDBClusters_DBCluster.DescribeDBClusters_Tag>();
				for (int j = 0; j < context.Length("DescribeDBClusters.Items["+ i +"].Tags.Length"); j++) {
					DescribeDBClustersResponse.DescribeDBClusters_DBCluster.DescribeDBClusters_Tag tag = new DescribeDBClustersResponse.DescribeDBClusters_DBCluster.DescribeDBClusters_Tag();
					tag.Key = context.StringValue("DescribeDBClusters.Items["+ i +"].Tags["+ j +"].Key");
					tag._Value = context.StringValue("DescribeDBClusters.Items["+ i +"].Tags["+ j +"].Value");

					dBCluster_tags.Add(tag);
				}
				dBCluster.Tags = dBCluster_tags;

				describeDBClustersResponse_items.Add(dBCluster);
			}
			describeDBClustersResponse.Items = describeDBClustersResponse_items;
        
			return describeDBClustersResponse;
        }
    }
}
