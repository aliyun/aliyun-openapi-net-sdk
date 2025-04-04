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
    public class DescribeDBClustersWithBackupsResponseUnmarshaller
    {
        public static DescribeDBClustersWithBackupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBClustersWithBackupsResponse describeDBClustersWithBackupsResponse = new DescribeDBClustersWithBackupsResponse();

			describeDBClustersWithBackupsResponse.HttpResponse = _ctx.HttpResponse;
			describeDBClustersWithBackupsResponse.RequestId = _ctx.StringValue("DescribeDBClustersWithBackups.RequestId");
			describeDBClustersWithBackupsResponse.PageNumber = _ctx.IntegerValue("DescribeDBClustersWithBackups.PageNumber");
			describeDBClustersWithBackupsResponse.PageRecordCount = _ctx.IntegerValue("DescribeDBClustersWithBackups.PageRecordCount");
			describeDBClustersWithBackupsResponse.TotalRecordCount = _ctx.IntegerValue("DescribeDBClustersWithBackups.TotalRecordCount");

			List<DescribeDBClustersWithBackupsResponse.DescribeDBClustersWithBackups_DBCluster> describeDBClustersWithBackupsResponse_items = new List<DescribeDBClustersWithBackupsResponse.DescribeDBClustersWithBackups_DBCluster>();
			for (int i = 0; i < _ctx.Length("DescribeDBClustersWithBackups.Items.Length"); i++) {
				DescribeDBClustersWithBackupsResponse.DescribeDBClustersWithBackups_DBCluster dBCluster = new DescribeDBClustersWithBackupsResponse.DescribeDBClustersWithBackups_DBCluster();
				dBCluster.DeletedTime = _ctx.StringValue("DescribeDBClustersWithBackups.Items["+ i +"].DeletedTime");
				dBCluster.VpcId = _ctx.StringValue("DescribeDBClustersWithBackups.Items["+ i +"].VpcId");
				dBCluster.ExpireTime = _ctx.StringValue("DescribeDBClustersWithBackups.Items["+ i +"].ExpireTime");
				dBCluster.Expired = _ctx.StringValue("DescribeDBClustersWithBackups.Items["+ i +"].Expired");
				dBCluster.CreateTime = _ctx.StringValue("DescribeDBClustersWithBackups.Items["+ i +"].CreateTime");
				dBCluster.DBNodeClass = _ctx.StringValue("DescribeDBClustersWithBackups.Items["+ i +"].DBNodeClass");
				dBCluster.PayType = _ctx.StringValue("DescribeDBClustersWithBackups.Items["+ i +"].PayType");
				dBCluster.DBType = _ctx.StringValue("DescribeDBClustersWithBackups.Items["+ i +"].DBType");
				dBCluster.LockMode = _ctx.StringValue("DescribeDBClustersWithBackups.Items["+ i +"].LockMode");
				dBCluster.RegionId = _ctx.StringValue("DescribeDBClustersWithBackups.Items["+ i +"].RegionId");
				dBCluster.DeletionLock = _ctx.IntegerValue("DescribeDBClustersWithBackups.Items["+ i +"].DeletionLock");
				dBCluster.DBVersion = _ctx.StringValue("DescribeDBClustersWithBackups.Items["+ i +"].DBVersion");
				dBCluster.DBClusterId = _ctx.StringValue("DescribeDBClustersWithBackups.Items["+ i +"].DBClusterId");
				dBCluster.DBClusterStatus = _ctx.StringValue("DescribeDBClustersWithBackups.Items["+ i +"].DBClusterStatus");
				dBCluster.IsDeleted = _ctx.IntegerValue("DescribeDBClustersWithBackups.Items["+ i +"].IsDeleted");
				dBCluster.DBClusterNetworkType = _ctx.StringValue("DescribeDBClustersWithBackups.Items["+ i +"].DBClusterNetworkType");
				dBCluster.DBClusterDescription = _ctx.StringValue("DescribeDBClustersWithBackups.Items["+ i +"].DBClusterDescription");
				dBCluster.ZoneId = _ctx.StringValue("DescribeDBClustersWithBackups.Items["+ i +"].ZoneId");
				dBCluster.Engine = _ctx.StringValue("DescribeDBClustersWithBackups.Items["+ i +"].Engine");
				dBCluster.Category = _ctx.StringValue("DescribeDBClustersWithBackups.Items["+ i +"].Category");
				dBCluster.CnClass = _ctx.StringValue("DescribeDBClustersWithBackups.Items["+ i +"].CnClass");

				describeDBClustersWithBackupsResponse_items.Add(dBCluster);
			}
			describeDBClustersWithBackupsResponse.Items = describeDBClustersWithBackupsResponse_items;
        
			return describeDBClustersWithBackupsResponse;
        }
    }
}
