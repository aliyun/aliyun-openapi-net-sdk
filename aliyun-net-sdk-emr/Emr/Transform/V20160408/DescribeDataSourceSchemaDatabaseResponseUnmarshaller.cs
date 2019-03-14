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
    public class DescribeDataSourceSchemaDatabaseResponseUnmarshaller
    {
        public static DescribeDataSourceSchemaDatabaseResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDataSourceSchemaDatabaseResponse describeDataSourceSchemaDatabaseResponse = new DescribeDataSourceSchemaDatabaseResponse();

			describeDataSourceSchemaDatabaseResponse.HttpResponse = context.HttpResponse;
			describeDataSourceSchemaDatabaseResponse.RequestId = context.StringValue("DescribeDataSourceSchemaDatabase.RequestId");
			describeDataSourceSchemaDatabaseResponse.DataSourceId = context.StringValue("DescribeDataSourceSchemaDatabase.DataSourceId");

			DescribeDataSourceSchemaDatabaseResponse.DescribeDataSourceSchemaDatabase_Schema schema = new DescribeDataSourceSchemaDatabaseResponse.DescribeDataSourceSchemaDatabase_Schema();
			schema.DbName = context.StringValue("DescribeDataSourceSchemaDatabase.Schema.DbName");
			schema.DbVersion = context.StringValue("DescribeDataSourceSchemaDatabase.Schema.DbVersion");
			schema.DbType = context.StringValue("DescribeDataSourceSchemaDatabase.Schema.DbType");
			describeDataSourceSchemaDatabaseResponse.Schema = schema;
        
			return describeDataSourceSchemaDatabaseResponse;
        }
    }
}
