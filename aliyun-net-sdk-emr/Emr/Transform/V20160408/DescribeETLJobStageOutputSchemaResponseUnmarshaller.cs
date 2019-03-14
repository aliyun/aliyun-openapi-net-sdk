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
    public class DescribeETLJobStageOutputSchemaResponseUnmarshaller
    {
        public static DescribeETLJobStageOutputSchemaResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeETLJobStageOutputSchemaResponse describeETLJobStageOutputSchemaResponse = new DescribeETLJobStageOutputSchemaResponse();

			describeETLJobStageOutputSchemaResponse.HttpResponse = context.HttpResponse;
			describeETLJobStageOutputSchemaResponse.RequestId = context.StringValue("DescribeETLJobStageOutputSchema.RequestId");

			DescribeETLJobStageOutputSchemaResponse.DescribeETLJobStageOutputSchema_Schema schema = new DescribeETLJobStageOutputSchemaResponse.DescribeETLJobStageOutputSchema_Schema();
			schema.Name = context.StringValue("DescribeETLJobStageOutputSchema.Schema.Name");

			List<DescribeETLJobStageOutputSchemaResponse.DescribeETLJobStageOutputSchema_Schema.DescribeETLJobStageOutputSchema_Field> schema_fields = new List<DescribeETLJobStageOutputSchemaResponse.DescribeETLJobStageOutputSchema_Schema.DescribeETLJobStageOutputSchema_Field>();
			for (int i = 0; i < context.Length("DescribeETLJobStageOutputSchema.Schema.Fields.Length"); i++) {
				DescribeETLJobStageOutputSchemaResponse.DescribeETLJobStageOutputSchema_Schema.DescribeETLJobStageOutputSchema_Field field = new DescribeETLJobStageOutputSchemaResponse.DescribeETLJobStageOutputSchema_Schema.DescribeETLJobStageOutputSchema_Field();
				field.Type = context.StringValue("DescribeETLJobStageOutputSchema.Schema.Fields["+ i +"].Type");
				field.Name = context.StringValue("DescribeETLJobStageOutputSchema.Schema.Fields["+ i +"].Name");
				field.Index = context.IntegerValue("DescribeETLJobStageOutputSchema.Schema.Fields["+ i +"].Index");
				field.RawType = context.StringValue("DescribeETLJobStageOutputSchema.Schema.Fields["+ i +"].RawType");
				field.AssignType = context.StringValue("DescribeETLJobStageOutputSchema.Schema.Fields["+ i +"].AssignType");
				field.AssignValue = context.StringValue("DescribeETLJobStageOutputSchema.Schema.Fields["+ i +"].AssignValue");

				schema_fields.Add(field);
			}
			schema.Fields = schema_fields;
			describeETLJobStageOutputSchemaResponse.Schema = schema;
        
			return describeETLJobStageOutputSchemaResponse;
        }
    }
}
