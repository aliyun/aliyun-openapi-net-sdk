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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class MetastoreDescribeDataSourceResponseUnmarshaller
    {
        public static MetastoreDescribeDataSourceResponse Unmarshall(UnmarshallerContext context)
        {
			MetastoreDescribeDataSourceResponse metastoreDescribeDataSourceResponse = new MetastoreDescribeDataSourceResponse();

			metastoreDescribeDataSourceResponse.HttpResponse = context.HttpResponse;
			metastoreDescribeDataSourceResponse.RequestId = context.StringValue("MetastoreDescribeDataSource.RequestId");

			MetastoreDescribeDataSourceResponse.MetastoreDescribeDataSource_DataSource dataSource = new MetastoreDescribeDataSourceResponse.MetastoreDescribeDataSource_DataSource();
			dataSource.Id = context.StringValue("MetastoreDescribeDataSource.DataSource.Id");
			dataSource.Name = context.StringValue("MetastoreDescribeDataSource.DataSource.Name");
			dataSource.SourceType = context.StringValue("MetastoreDescribeDataSource.DataSource.SourceType");
			dataSource.Description = context.StringValue("MetastoreDescribeDataSource.DataSource.Description");
			dataSource.ConnectionInfo = context.StringValue("MetastoreDescribeDataSource.DataSource.ConnectionInfo");
			dataSource.ClusterBizId = context.StringValue("MetastoreDescribeDataSource.DataSource.ClusterBizId");
			dataSource.ClusterName = context.StringValue("MetastoreDescribeDataSource.DataSource.ClusterName");
			dataSource.UserId = context.StringValue("MetastoreDescribeDataSource.DataSource.UserId");
			dataSource.GmtCreate = context.LongValue("MetastoreDescribeDataSource.DataSource.GmtCreate");
			dataSource.GmtModified = context.LongValue("MetastoreDescribeDataSource.DataSource.GmtModified");
			dataSource.Capacity = context.LongValue("MetastoreDescribeDataSource.DataSource.Capacity");
			dataSource.UsedSize = context.LongValue("MetastoreDescribeDataSource.DataSource.UsedSize");

			List<MetastoreDescribeDataSourceResponse.MetastoreDescribeDataSource_DataSource.MetastoreDescribeDataSource_Config> dataSource_configList = new List<MetastoreDescribeDataSourceResponse.MetastoreDescribeDataSource_DataSource.MetastoreDescribeDataSource_Config>();
			for (int i = 0; i < context.Length("MetastoreDescribeDataSource.DataSource.ConfigList.Length"); i++) {
				MetastoreDescribeDataSourceResponse.MetastoreDescribeDataSource_DataSource.MetastoreDescribeDataSource_Config config = new MetastoreDescribeDataSourceResponse.MetastoreDescribeDataSource_DataSource.MetastoreDescribeDataSource_Config();
				config.ConfigName = context.StringValue("MetastoreDescribeDataSource.DataSource.ConfigList["+ i +"].ConfigName");
				config._Value = context.StringValue("MetastoreDescribeDataSource.DataSource.ConfigList["+ i +"].Value");

				dataSource_configList.Add(config);
			}
			dataSource.ConfigList = dataSource_configList;
			metastoreDescribeDataSourceResponse.DataSource = dataSource;
        
			return metastoreDescribeDataSourceResponse;
        }
    }
}
