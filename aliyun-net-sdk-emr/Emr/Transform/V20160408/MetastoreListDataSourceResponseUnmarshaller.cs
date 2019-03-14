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
    public class MetastoreListDataSourceResponseUnmarshaller
    {
        public static MetastoreListDataSourceResponse Unmarshall(UnmarshallerContext context)
        {
			MetastoreListDataSourceResponse metastoreListDataSourceResponse = new MetastoreListDataSourceResponse();

			metastoreListDataSourceResponse.HttpResponse = context.HttpResponse;
			metastoreListDataSourceResponse.RequestId = context.StringValue("MetastoreListDataSource.RequestId");
			metastoreListDataSourceResponse.TotalCount = context.IntegerValue("MetastoreListDataSource.TotalCount");
			metastoreListDataSourceResponse.PageNumber = context.IntegerValue("MetastoreListDataSource.PageNumber");
			metastoreListDataSourceResponse.PageSize = context.IntegerValue("MetastoreListDataSource.PageSize");

			List<MetastoreListDataSourceResponse.MetastoreListDataSource_DataSource> metastoreListDataSourceResponse_dataSourceList = new List<MetastoreListDataSourceResponse.MetastoreListDataSource_DataSource>();
			for (int i = 0; i < context.Length("MetastoreListDataSource.DataSourceList.Length"); i++) {
				MetastoreListDataSourceResponse.MetastoreListDataSource_DataSource dataSource = new MetastoreListDataSourceResponse.MetastoreListDataSource_DataSource();
				dataSource.Id = context.StringValue("MetastoreListDataSource.DataSourceList["+ i +"].Id");
				dataSource.Name = context.StringValue("MetastoreListDataSource.DataSourceList["+ i +"].Name");
				dataSource.SourceType = context.StringValue("MetastoreListDataSource.DataSourceList["+ i +"].SourceType");
				dataSource.Description = context.StringValue("MetastoreListDataSource.DataSourceList["+ i +"].Description");
				dataSource.ConnectionInfo = context.StringValue("MetastoreListDataSource.DataSourceList["+ i +"].ConnectionInfo");
				dataSource.ClusterBizId = context.StringValue("MetastoreListDataSource.DataSourceList["+ i +"].ClusterBizId");
				dataSource.ClusterName = context.StringValue("MetastoreListDataSource.DataSourceList["+ i +"].ClusterName");
				dataSource.UserId = context.StringValue("MetastoreListDataSource.DataSourceList["+ i +"].UserId");
				dataSource.GmtCreate = context.LongValue("MetastoreListDataSource.DataSourceList["+ i +"].GmtCreate");
				dataSource.GmtModified = context.LongValue("MetastoreListDataSource.DataSourceList["+ i +"].GmtModified");
				dataSource.Capacity = context.LongValue("MetastoreListDataSource.DataSourceList["+ i +"].Capacity");
				dataSource.UsedSize = context.LongValue("MetastoreListDataSource.DataSourceList["+ i +"].UsedSize");

				List<MetastoreListDataSourceResponse.MetastoreListDataSource_DataSource.MetastoreListDataSource_Config> dataSource_configList = new List<MetastoreListDataSourceResponse.MetastoreListDataSource_DataSource.MetastoreListDataSource_Config>();
				for (int j = 0; j < context.Length("MetastoreListDataSource.DataSourceList["+ i +"].ConfigList.Length"); j++) {
					MetastoreListDataSourceResponse.MetastoreListDataSource_DataSource.MetastoreListDataSource_Config config = new MetastoreListDataSourceResponse.MetastoreListDataSource_DataSource.MetastoreListDataSource_Config();
					config.ConfigName = context.StringValue("MetastoreListDataSource.DataSourceList["+ i +"].ConfigList["+ j +"].ConfigName");
					config._Value = context.StringValue("MetastoreListDataSource.DataSourceList["+ i +"].ConfigList["+ j +"].Value");

					dataSource_configList.Add(config);
				}
				dataSource.ConfigList = dataSource_configList;

				metastoreListDataSourceResponse_dataSourceList.Add(dataSource);
			}
			metastoreListDataSourceResponse.DataSourceList = metastoreListDataSourceResponse_dataSourceList;
        
			return metastoreListDataSourceResponse;
        }
    }
}
