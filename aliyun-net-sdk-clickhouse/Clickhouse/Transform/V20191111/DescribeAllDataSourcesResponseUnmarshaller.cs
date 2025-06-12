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
    public class DescribeAllDataSourcesResponseUnmarshaller
    {
        public static DescribeAllDataSourcesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAllDataSourcesResponse describeAllDataSourcesResponse = new DescribeAllDataSourcesResponse();

			describeAllDataSourcesResponse.HttpResponse = _ctx.HttpResponse;
			describeAllDataSourcesResponse.RequestId = _ctx.StringValue("DescribeAllDataSources.RequestId");

			List<DescribeAllDataSourcesResponse.DescribeAllDataSources_Table> describeAllDataSourcesResponse_tables = new List<DescribeAllDataSourcesResponse.DescribeAllDataSources_Table>();
			for (int i = 0; i < _ctx.Length("DescribeAllDataSources.Tables.Length"); i++) {
				DescribeAllDataSourcesResponse.DescribeAllDataSources_Table table = new DescribeAllDataSourcesResponse.DescribeAllDataSources_Table();
				table.TableName = _ctx.StringValue("DescribeAllDataSources.Tables["+ i +"].TableName");
				table.DBClusterId = _ctx.StringValue("DescribeAllDataSources.Tables["+ i +"].DBClusterId");
				table.SchemaName = _ctx.StringValue("DescribeAllDataSources.Tables["+ i +"].SchemaName");

				describeAllDataSourcesResponse_tables.Add(table);
			}
			describeAllDataSourcesResponse.Tables = describeAllDataSourcesResponse_tables;

			List<DescribeAllDataSourcesResponse.DescribeAllDataSources_Column> describeAllDataSourcesResponse_columns = new List<DescribeAllDataSourcesResponse.DescribeAllDataSources_Column>();
			for (int i = 0; i < _ctx.Length("DescribeAllDataSources.Columns.Length"); i++) {
				DescribeAllDataSourcesResponse.DescribeAllDataSources_Column column = new DescribeAllDataSourcesResponse.DescribeAllDataSources_Column();
				column.Type = _ctx.StringValue("DescribeAllDataSources.Columns["+ i +"].Type");
				column.ColumnName = _ctx.StringValue("DescribeAllDataSources.Columns["+ i +"].ColumnName");
				column.TableName = _ctx.StringValue("DescribeAllDataSources.Columns["+ i +"].TableName");
				column.AutoIncrementColumn = _ctx.BooleanValue("DescribeAllDataSources.Columns["+ i +"].AutoIncrementColumn");
				column.DBClusterId = _ctx.StringValue("DescribeAllDataSources.Columns["+ i +"].DBClusterId");
				column.PrimaryKey = _ctx.BooleanValue("DescribeAllDataSources.Columns["+ i +"].PrimaryKey");
				column.SchemaName = _ctx.StringValue("DescribeAllDataSources.Columns["+ i +"].SchemaName");

				describeAllDataSourcesResponse_columns.Add(column);
			}
			describeAllDataSourcesResponse.Columns = describeAllDataSourcesResponse_columns;

			List<DescribeAllDataSourcesResponse.DescribeAllDataSources_Schema> describeAllDataSourcesResponse_schemas = new List<DescribeAllDataSourcesResponse.DescribeAllDataSources_Schema>();
			for (int i = 0; i < _ctx.Length("DescribeAllDataSources.Schemas.Length"); i++) {
				DescribeAllDataSourcesResponse.DescribeAllDataSources_Schema schema = new DescribeAllDataSourcesResponse.DescribeAllDataSources_Schema();
				schema.DBClusterId = _ctx.StringValue("DescribeAllDataSources.Schemas["+ i +"].DBClusterId");
				schema.SchemaName = _ctx.StringValue("DescribeAllDataSources.Schemas["+ i +"].SchemaName");

				describeAllDataSourcesResponse_schemas.Add(schema);
			}
			describeAllDataSourcesResponse.Schemas = describeAllDataSourcesResponse_schemas;
        
			return describeAllDataSourcesResponse;
        }
    }
}
