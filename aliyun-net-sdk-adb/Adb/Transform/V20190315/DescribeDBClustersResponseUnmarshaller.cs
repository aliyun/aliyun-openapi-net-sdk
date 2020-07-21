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
using Aliyun.Acs.adb.Model.V20190315;

namespace Aliyun.Acs.adb.Transform.V20190315
{
    public class DescribeDBClustersResponseUnmarshaller
    {
        public static DescribeDBClustersResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDBClustersResponse describeDBClustersResponse = new DescribeDBClustersResponse();

			describeDBClustersResponse.HttpResponse = context.HttpResponse;
			describeDBClustersResponse.RequestId = context.StringValue("DescribeDBClusters.RequestId");
			describeDBClustersResponse.PageNumber = context.IntegerValue("DescribeDBClusters.PageNumber");
			describeDBClustersResponse.TotalCount = context.IntegerValue("DescribeDBClusters.TotalCount");
			describeDBClustersResponse.PageSize = context.IntegerValue("DescribeDBClusters.PageSize");

			List<DescribeDBClustersResponse.DescribeDBClusters_DBCluster> describeDBClustersResponse_items = new List<DescribeDBClustersResponse.DescribeDBClusters_DBCluster>();
			for (int i = 0; i < context.Length("DescribeDBClusters.Items.Length"); i++) {
				DescribeDBClustersResponse.DescribeDBClusters_DBCluster dBCluster = new DescribeDBClustersResponse.DescribeDBClusters_DBCluster();
				dBCluster.DBClusterId = context.StringValue("DescribeDBClusters.Items["+ i +"].DBClusterId");
				dBCluster.DBClusterType = context.StringValue("DescribeDBClusters.Items["+ i +"].DBClusterType");
				dBCluster.DBClusterDescription = context.StringValue("DescribeDBClusters.Items["+ i +"].DBClusterDescription");
				dBCluster.PayType = context.StringValue("DescribeDBClusters.Items["+ i +"].PayType");
				dBCluster.RegionId = context.StringValue("DescribeDBClusters.Items["+ i +"].RegionId");
				dBCluster.ExpireTime = context.StringValue("DescribeDBClusters.Items["+ i +"].ExpireTime");
				dBCluster.Expired = context.StringValue("DescribeDBClusters.Items["+ i +"].Expired");
				dBCluster.DBClusterStatus = context.StringValue("DescribeDBClusters.Items["+ i +"].DBClusterStatus");
				dBCluster.DBVersion = context.StringValue("DescribeDBClusters.Items["+ i +"].DBVersion");
				dBCluster.LockMode = context.StringValue("DescribeDBClusters.Items["+ i +"].LockMode");
				dBCluster.LockReason = context.StringValue("DescribeDBClusters.Items["+ i +"].LockReason");
				dBCluster.CreateTime = context.StringValue("DescribeDBClusters.Items["+ i +"].CreateTime");
				dBCluster.DBNodeStorage = context.LongValue("DescribeDBClusters.Items["+ i +"].DBNodeStorage");
				dBCluster.DBNodeClass = context.StringValue("DescribeDBClusters.Items["+ i +"].DBNodeClass");
				dBCluster.DBNodeCount = context.LongValue("DescribeDBClusters.Items["+ i +"].DBNodeCount");
				dBCluster.CommodityCode = context.StringValue("DescribeDBClusters.Items["+ i +"].CommodityCode");
				dBCluster.Category = context.StringValue("DescribeDBClusters.Items["+ i +"].Category");
				dBCluster.RdsInstanceId = context.StringValue("DescribeDBClusters.Items["+ i +"].RdsInstanceId");
				dBCluster.DtsJobId = context.StringValue("DescribeDBClusters.Items["+ i +"].DtsJobId");
				dBCluster.ExecutorCount = context.StringValue("DescribeDBClusters.Items["+ i +"].ExecutorCount");
				dBCluster.DiskType = context.StringValue("DescribeDBClusters.Items["+ i +"].DiskType");
				dBCluster.VPCCloudInstanceId = context.StringValue("DescribeDBClusters.Items["+ i +"].VPCCloudInstanceId");
				dBCluster.Engine = context.StringValue("DescribeDBClusters.Items["+ i +"].Engine");
				dBCluster.DBClusterNetworkType = context.StringValue("DescribeDBClusters.Items["+ i +"].DBClusterNetworkType");
				dBCluster.VPCId = context.StringValue("DescribeDBClusters.Items["+ i +"].VPCId");
				dBCluster.VSwitchId = context.StringValue("DescribeDBClusters.Items["+ i +"].VSwitchId");
				dBCluster.ZoneId = context.StringValue("DescribeDBClusters.Items["+ i +"].ZoneId");
				dBCluster.ConnectionString = context.StringValue("DescribeDBClusters.Items["+ i +"].ConnectionString");
				dBCluster.Port = context.StringValue("DescribeDBClusters.Items["+ i +"].Port");
				dBCluster.ComputeResource = context.StringValue("DescribeDBClusters.Items["+ i +"].ComputeResource");
				dBCluster.StorageResource = context.StringValue("DescribeDBClusters.Items["+ i +"].StorageResource");
				dBCluster.Mode = context.StringValue("DescribeDBClusters.Items["+ i +"].Mode");
				dBCluster.ResourceGroupId = context.StringValue("DescribeDBClusters.Items["+ i +"].ResourceGroupId");

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
