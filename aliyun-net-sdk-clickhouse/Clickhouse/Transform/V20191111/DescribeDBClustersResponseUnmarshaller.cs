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
using Aliyun.Acs.clickhouse.Model.V20191111;

namespace Aliyun.Acs.clickhouse.Transform.V20191111
{
    public class DescribeDBClustersResponseUnmarshaller
    {
        public static DescribeDBClustersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBClustersResponse describeDBClustersResponse = new DescribeDBClustersResponse();

			describeDBClustersResponse.HttpResponse = _ctx.HttpResponse;
			describeDBClustersResponse.TotalCount = _ctx.IntegerValue("DescribeDBClusters.TotalCount");
			describeDBClustersResponse.PageSize = _ctx.IntegerValue("DescribeDBClusters.PageSize");
			describeDBClustersResponse.RequestId = _ctx.StringValue("DescribeDBClusters.RequestId");
			describeDBClustersResponse.PageNumber = _ctx.IntegerValue("DescribeDBClusters.PageNumber");

			List<DescribeDBClustersResponse.DescribeDBClusters_DBCluster> describeDBClustersResponse_dBClusters = new List<DescribeDBClustersResponse.DescribeDBClusters_DBCluster>();
			for (int i = 0; i < _ctx.Length("DescribeDBClusters.DBClusters.Length"); i++) {
				DescribeDBClustersResponse.DescribeDBClusters_DBCluster dBCluster = new DescribeDBClustersResponse.DescribeDBClusters_DBCluster();
				dBCluster.VpcId = _ctx.StringValue("DescribeDBClusters.DBClusters["+ i +"].VpcId");
				dBCluster.DBNodeCount = _ctx.LongValue("DescribeDBClusters.DBClusters["+ i +"].DBNodeCount");
				dBCluster.CreateTime = _ctx.StringValue("DescribeDBClusters.DBClusters["+ i +"].CreateTime");
				dBCluster.PayType = _ctx.StringValue("DescribeDBClusters.DBClusters["+ i +"].PayType");
				dBCluster.StorageType = _ctx.StringValue("DescribeDBClusters.DBClusters["+ i +"].StorageType");
				dBCluster.Port = _ctx.IntegerValue("DescribeDBClusters.DBClusters["+ i +"].Port");
				dBCluster.LockMode = _ctx.StringValue("DescribeDBClusters.DBClusters["+ i +"].LockMode");
				dBCluster.Bid = _ctx.StringValue("DescribeDBClusters.DBClusters["+ i +"].Bid");
				dBCluster.IsExpired = _ctx.StringValue("DescribeDBClusters.DBClusters["+ i +"].IsExpired");
				dBCluster.VpcCloudInstanceId = _ctx.StringValue("DescribeDBClusters.DBClusters["+ i +"].VpcCloudInstanceId");
				dBCluster.ScaleOutDisableWriteWindows = _ctx.StringValue("DescribeDBClusters.DBClusters["+ i +"].ScaleOutDisableWriteWindows");
				dBCluster.DBClusterId = _ctx.StringValue("DescribeDBClusters.DBClusters["+ i +"].DBClusterId");
				dBCluster.ConnectionString = _ctx.StringValue("DescribeDBClusters.DBClusters["+ i +"].ConnectionString");
				dBCluster.CommodityCode = _ctx.StringValue("DescribeDBClusters.DBClusters["+ i +"].CommodityCode");
				dBCluster.ExpireTime = _ctx.StringValue("DescribeDBClusters.DBClusters["+ i +"].ExpireTime");
				dBCluster.DBNodeStorage = _ctx.LongValue("DescribeDBClusters.DBClusters["+ i +"].DBNodeStorage");
				dBCluster.DBNodeClass = _ctx.StringValue("DescribeDBClusters.DBClusters["+ i +"].DBNodeClass");
				dBCluster.AliUid = _ctx.StringValue("DescribeDBClusters.DBClusters["+ i +"].AliUid");
				dBCluster.LockReason = _ctx.StringValue("DescribeDBClusters.DBClusters["+ i +"].LockReason");
				dBCluster.RegionId = _ctx.StringValue("DescribeDBClusters.DBClusters["+ i +"].RegionId");
				dBCluster.VSwitchId = _ctx.StringValue("DescribeDBClusters.DBClusters["+ i +"].VSwitchId");
				dBCluster.DBClusterStatus = _ctx.StringValue("DescribeDBClusters.DBClusters["+ i +"].DBClusterStatus");
				dBCluster.DBClusterDescription = _ctx.StringValue("DescribeDBClusters.DBClusters["+ i +"].DBClusterDescription");
				dBCluster.DBClusterNetworkType = _ctx.StringValue("DescribeDBClusters.DBClusters["+ i +"].DBClusterNetworkType");
				dBCluster.ZoneId = _ctx.StringValue("DescribeDBClusters.DBClusters["+ i +"].ZoneId");
				dBCluster.Category = _ctx.StringValue("DescribeDBClusters.DBClusters["+ i +"].Category");
				dBCluster.ControlVersion = _ctx.StringValue("DescribeDBClusters.DBClusters["+ i +"].ControlVersion");
				dBCluster.ExtStorageType = _ctx.StringValue("DescribeDBClusters.DBClusters["+ i +"].ExtStorageType");
				dBCluster.ExtStorageSize = _ctx.IntegerValue("DescribeDBClusters.DBClusters["+ i +"].ExtStorageSize");
				dBCluster.ResourceGroupId = _ctx.StringValue("DescribeDBClusters.DBClusters["+ i +"].ResourceGroupId");
				dBCluster.DbVersion = _ctx.StringValue("DescribeDBClusters.DBClusters["+ i +"].DbVersion");

				DescribeDBClustersResponse.DescribeDBClusters_DBCluster.DescribeDBClusters_ScaleOutStatus scaleOutStatus = new DescribeDBClustersResponse.DescribeDBClusters_DBCluster.DescribeDBClusters_ScaleOutStatus();
				scaleOutStatus.Progress = _ctx.StringValue("DescribeDBClusters.DBClusters["+ i +"].ScaleOutStatus.Progress");
				scaleOutStatus.Ratio = _ctx.StringValue("DescribeDBClusters.DBClusters["+ i +"].ScaleOutStatus.Ratio");
				dBCluster.ScaleOutStatus = scaleOutStatus;

				List<DescribeDBClustersResponse.DescribeDBClusters_DBCluster.DescribeDBClusters_Tag> dBCluster_tags = new List<DescribeDBClustersResponse.DescribeDBClusters_DBCluster.DescribeDBClusters_Tag>();
				for (int j = 0; j < _ctx.Length("DescribeDBClusters.DBClusters["+ i +"].Tags.Length"); j++) {
					DescribeDBClustersResponse.DescribeDBClusters_DBCluster.DescribeDBClusters_Tag tag = new DescribeDBClustersResponse.DescribeDBClusters_DBCluster.DescribeDBClusters_Tag();
					tag.Key = _ctx.StringValue("DescribeDBClusters.DBClusters["+ i +"].Tags["+ j +"].Key");
					tag._Value = _ctx.StringValue("DescribeDBClusters.DBClusters["+ i +"].Tags["+ j +"].Value");

					dBCluster_tags.Add(tag);
				}
				dBCluster.Tags = dBCluster_tags;

				describeDBClustersResponse_dBClusters.Add(dBCluster);
			}
			describeDBClustersResponse.DBClusters = describeDBClustersResponse_dBClusters;
        
			return describeDBClustersResponse;
        }
    }
}
