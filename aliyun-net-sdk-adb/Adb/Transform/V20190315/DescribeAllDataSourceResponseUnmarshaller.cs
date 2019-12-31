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
    public class DescribeAllDataSourceResponseUnmarshaller
    {
        public static DescribeAllDataSourceResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAllDataSourceResponse describeAllDataSourceResponse = new DescribeAllDataSourceResponse();

			describeAllDataSourceResponse.HttpResponse = context.HttpResponse;
			describeAllDataSourceResponse.RequestId = context.StringValue("DescribeAllDataSource.RequestId");

			List<DescribeAllDataSourceResponse.DescribeAllDataSource_Schema> describeAllDataSourceResponse_schemas = new List<DescribeAllDataSourceResponse.DescribeAllDataSource_Schema>();
			for (int i = 0; i < context.Length("DescribeAllDataSource.Schemas.Length"); i++) {
				DescribeAllDataSourceResponse.DescribeAllDataSource_Schema schema = new DescribeAllDataSourceResponse.DescribeAllDataSource_Schema();
				schema.DBClusterId = context.StringValue("DescribeAllDataSource.Schemas["+ i +"].DBClusterId");
				schema.SchemaName = context.StringValue("DescribeAllDataSource.Schemas["+ i +"].SchemaName");

				describeAllDataSourceResponse_schemas.Add(schema);
			}
			describeAllDataSourceResponse.Schemas = describeAllDataSourceResponse_schemas;

			List<DescribeAllDataSourceResponse.DescribeAllDataSource_Table> describeAllDataSourceResponse_tables = new List<DescribeAllDataSourceResponse.DescribeAllDataSource_Table>();
			for (int i = 0; i < context.Length("DescribeAllDataSource.Tables.Length"); i++) {
				DescribeAllDataSourceResponse.DescribeAllDataSource_Table table = new DescribeAllDataSourceResponse.DescribeAllDataSource_Table();
				table.DBClusterId = context.StringValue("DescribeAllDataSource.Tables["+ i +"].DBClusterId");
				table.SchemaName = context.StringValue("DescribeAllDataSource.Tables["+ i +"].SchemaName");
				table.TableName = context.StringValue("DescribeAllDataSource.Tables["+ i +"].TableName");

				describeAllDataSourceResponse_tables.Add(table);
			}
			describeAllDataSourceResponse.Tables = describeAllDataSourceResponse_tables;

			List<DescribeAllDataSourceResponse.DescribeAllDataSource_Column> describeAllDataSourceResponse_columns = new List<DescribeAllDataSourceResponse.DescribeAllDataSource_Column>();
			for (int i = 0; i < context.Length("DescribeAllDataSource.Columns.Length"); i++) {
				DescribeAllDataSourceResponse.DescribeAllDataSource_Column column = new DescribeAllDataSourceResponse.DescribeAllDataSource_Column();
				column.DBClusterId = context.StringValue("DescribeAllDataSource.Columns["+ i +"].DBClusterId");
				column.SchemaName = context.StringValue("DescribeAllDataSource.Columns["+ i +"].SchemaName");
				column.TableName = context.StringValue("DescribeAllDataSource.Columns["+ i +"].TableName");
				column.ColumnName = context.StringValue("DescribeAllDataSource.Columns["+ i +"].ColumnName");
				column.Type = context.StringValue("DescribeAllDataSource.Columns["+ i +"].Type");
				column.PrimaryKey = context.BooleanValue("DescribeAllDataSource.Columns["+ i +"].PrimaryKey");

				describeAllDataSourceResponse_columns.Add(column);
			}
			describeAllDataSourceResponse.Columns = describeAllDataSourceResponse_columns;
        
			return describeAllDataSourceResponse;
        }
    }
}
