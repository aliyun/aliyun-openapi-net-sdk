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
    public class DescribeDataSourceSchemaTableResponseUnmarshaller
    {
        public static DescribeDataSourceSchemaTableResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDataSourceSchemaTableResponse describeDataSourceSchemaTableResponse = new DescribeDataSourceSchemaTableResponse();

			describeDataSourceSchemaTableResponse.HttpResponse = context.HttpResponse;
			describeDataSourceSchemaTableResponse.RequestId = context.StringValue("DescribeDataSourceSchemaTable.RequestId");
			describeDataSourceSchemaTableResponse.DataSourceId = context.StringValue("DescribeDataSourceSchemaTable.DataSourceId");

			DescribeDataSourceSchemaTableResponse.DescribeDataSourceSchemaTable_Schema schema = new DescribeDataSourceSchemaTableResponse.DescribeDataSourceSchemaTable_Schema();
			schema.DbType = context.StringValue("DescribeDataSourceSchemaTable.Schema.DbType");
			schema.DbVersion = context.StringValue("DescribeDataSourceSchemaTable.Schema.DbVersion");
			schema.DbName = context.StringValue("DescribeDataSourceSchemaTable.Schema.DbName");
			schema.TableName = context.StringValue("DescribeDataSourceSchemaTable.Schema.TableName");

			List<DescribeDataSourceSchemaTableResponse.DescribeDataSourceSchemaTable_Schema.DescribeDataSourceSchemaTable_Field> schema_fields = new List<DescribeDataSourceSchemaTableResponse.DescribeDataSourceSchemaTable_Schema.DescribeDataSourceSchemaTable_Field>();
			for (int i = 0; i < context.Length("DescribeDataSourceSchemaTable.Schema.Fields.Length"); i++) {
				DescribeDataSourceSchemaTableResponse.DescribeDataSourceSchemaTable_Schema.DescribeDataSourceSchemaTable_Field field = new DescribeDataSourceSchemaTableResponse.DescribeDataSourceSchemaTable_Schema.DescribeDataSourceSchemaTable_Field();
				field.Type = context.StringValue("DescribeDataSourceSchemaTable.Schema.Fields["+ i +"].Type");
				field.Name = context.StringValue("DescribeDataSourceSchemaTable.Schema.Fields["+ i +"].Name");
				field.Index = context.IntegerValue("DescribeDataSourceSchemaTable.Schema.Fields["+ i +"].Index");
				field.RawType = context.StringValue("DescribeDataSourceSchemaTable.Schema.Fields["+ i +"].RawType");
				field.AssignType = context.StringValue("DescribeDataSourceSchemaTable.Schema.Fields["+ i +"].AssignType");
				field.AssignValue = context.StringValue("DescribeDataSourceSchemaTable.Schema.Fields["+ i +"].AssignValue");

				schema_fields.Add(field);
			}
			schema.Fields = schema_fields;
			describeDataSourceSchemaTableResponse.Schema = schema;
        
			return describeDataSourceSchemaTableResponse;
        }
    }
}
