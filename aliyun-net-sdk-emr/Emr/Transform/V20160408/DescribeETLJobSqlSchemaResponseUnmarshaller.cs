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
    public class DescribeETLJobSqlSchemaResponseUnmarshaller
    {
        public static DescribeETLJobSqlSchemaResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeETLJobSqlSchemaResponse describeETLJobSqlSchemaResponse = new DescribeETLJobSqlSchemaResponse();

			describeETLJobSqlSchemaResponse.HttpResponse = context.HttpResponse;
			describeETLJobSqlSchemaResponse.RequestId = context.StringValue("DescribeETLJobSqlSchema.RequestId");

			DescribeETLJobSqlSchemaResponse.DescribeETLJobSqlSchema_Schema schema = new DescribeETLJobSqlSchemaResponse.DescribeETLJobSqlSchema_Schema();
			schema.Name = context.StringValue("DescribeETLJobSqlSchema.Schema.Name");

			List<DescribeETLJobSqlSchemaResponse.DescribeETLJobSqlSchema_Schema.DescribeETLJobSqlSchema_Field> schema_fields = new List<DescribeETLJobSqlSchemaResponse.DescribeETLJobSqlSchema_Schema.DescribeETLJobSqlSchema_Field>();
			for (int i = 0; i < context.Length("DescribeETLJobSqlSchema.Schema.Fields.Length"); i++) {
				DescribeETLJobSqlSchemaResponse.DescribeETLJobSqlSchema_Schema.DescribeETLJobSqlSchema_Field field = new DescribeETLJobSqlSchemaResponse.DescribeETLJobSqlSchema_Schema.DescribeETLJobSqlSchema_Field();
				field.Type = context.StringValue("DescribeETLJobSqlSchema.Schema.Fields["+ i +"].Type");
				field.Name = context.StringValue("DescribeETLJobSqlSchema.Schema.Fields["+ i +"].Name");
				field.Index = context.IntegerValue("DescribeETLJobSqlSchema.Schema.Fields["+ i +"].Index");
				field.RawType = context.StringValue("DescribeETLJobSqlSchema.Schema.Fields["+ i +"].RawType");
				field.AssignType = context.StringValue("DescribeETLJobSqlSchema.Schema.Fields["+ i +"].AssignType");
				field.AssignValue = context.StringValue("DescribeETLJobSqlSchema.Schema.Fields["+ i +"].AssignValue");

				schema_fields.Add(field);
			}
			schema.Fields = schema_fields;
			describeETLJobSqlSchemaResponse.Schema = schema;
        
			return describeETLJobSqlSchemaResponse;
        }
    }
}
