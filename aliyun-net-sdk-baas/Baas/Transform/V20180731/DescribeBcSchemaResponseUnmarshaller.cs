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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Baas.Model.V20180731;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Baas.Transform.V20180731
{
    public class DescribeBcSchemaResponseUnmarshaller
    {
        public static DescribeBcSchemaResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeBcSchemaResponse describeBcSchemaResponse = new DescribeBcSchemaResponse();

			describeBcSchemaResponse.HttpResponse = context.HttpResponse;
			describeBcSchemaResponse.RequestId = context.StringValue("DescribeBcSchema.RequestId");

			DescribeBcSchemaResponse.DescribeBcSchema_Result result = new DescribeBcSchemaResponse.DescribeBcSchema_Result();

			DescribeBcSchemaResponse.DescribeBcSchema_Result.DescribeBcSchema_Schema schema = new DescribeBcSchemaResponse.DescribeBcSchema_Result.DescribeBcSchema_Schema();
			schema.Id = context.LongValue("DescribeBcSchema.Result.Schema.Id");
			schema.Name = context.StringValue("DescribeBcSchema.Result.Schema.Name");
			schema.Description = context.StringValue("DescribeBcSchema.Result.Schema.Description");
			schema.Version = context.LongValue("DescribeBcSchema.Result.Schema.Version");
			schema.CreateTime = context.LongValue("DescribeBcSchema.Result.Schema.CreateTime");
			schema.UpdateTime = context.LongValue("DescribeBcSchema.Result.Schema.UpdateTime");
			schema.IsTemplate = context.BooleanValue("DescribeBcSchema.Result.Schema.IsTemplate");
			result.Schema = schema;

			List<DescribeBcSchemaResponse.DescribeBcSchema_Result.DescribeBcSchema_ResponsesItem> result_responses = new List<DescribeBcSchemaResponse.DescribeBcSchema_Result.DescribeBcSchema_ResponsesItem>();
			for (int i = 0; i < context.Length("DescribeBcSchema.Result.Responses.Length"); i++) {
				DescribeBcSchemaResponse.DescribeBcSchema_Result.DescribeBcSchema_ResponsesItem responsesItem = new DescribeBcSchemaResponse.DescribeBcSchema_Result.DescribeBcSchema_ResponsesItem();
				responsesItem.CategoryName = context.StringValue("DescribeBcSchema.Result.Responses["+ i +"].CategoryName");
				responsesItem.Description = context.StringValue("DescribeBcSchema.Result.Responses["+ i +"].Description");
				responsesItem.Category = context.StringValue("DescribeBcSchema.Result.Responses["+ i +"].Category");

				DescribeBcSchemaResponse.DescribeBcSchema_Result.DescribeBcSchema_ResponsesItem.DescribeBcSchema_Properties properties = new DescribeBcSchemaResponse.DescribeBcSchema_Result.DescribeBcSchema_ResponsesItem.DescribeBcSchema_Properties();
				properties.Count = context.IntegerValue("DescribeBcSchema.Result.Responses["+ i +"].Properties.Count");

				List<DescribeBcSchemaResponse.DescribeBcSchema_Result.DescribeBcSchema_ResponsesItem.DescribeBcSchema_Properties.DescribeBcSchema_DataSourceItem> properties_dataSource = new List<DescribeBcSchemaResponse.DescribeBcSchema_Result.DescribeBcSchema_ResponsesItem.DescribeBcSchema_Properties.DescribeBcSchema_DataSourceItem>();
				for (int j = 0; j < context.Length("DescribeBcSchema.Result.Responses["+ i +"].Properties.DataSource.Length"); j++) {
					DescribeBcSchemaResponse.DescribeBcSchema_Result.DescribeBcSchema_ResponsesItem.DescribeBcSchema_Properties.DescribeBcSchema_DataSourceItem dataSourceItem = new DescribeBcSchemaResponse.DescribeBcSchema_Result.DescribeBcSchema_ResponsesItem.DescribeBcSchema_Properties.DescribeBcSchema_DataSourceItem();
					dataSourceItem.Key = context.IntegerValue("DescribeBcSchema.Result.Responses["+ i +"].Properties.DataSource["+ j +"].Key");
					dataSourceItem.Field = context.StringValue("DescribeBcSchema.Result.Responses["+ i +"].Properties.DataSource["+ j +"].Field");
					dataSourceItem.Type = context.StringValue("DescribeBcSchema.Result.Responses["+ i +"].Properties.DataSource["+ j +"].Type");
					dataSourceItem.Length = context.IntegerValue("DescribeBcSchema.Result.Responses["+ i +"].Properties.DataSource["+ j +"].Length");
					dataSourceItem.AllowNull = context.IntegerValue("DescribeBcSchema.Result.Responses["+ i +"].Properties.DataSource["+ j +"].AllowNull");
					dataSourceItem.Reg = context.StringValue("DescribeBcSchema.Result.Responses["+ i +"].Properties.DataSource["+ j +"].Reg");
					dataSourceItem.Indexes = context.IntegerValue("DescribeBcSchema.Result.Responses["+ i +"].Properties.DataSource["+ j +"].Indexes");
					dataSourceItem.Annotation = context.StringValue("DescribeBcSchema.Result.Responses["+ i +"].Properties.DataSource["+ j +"].Annotation");

					properties_dataSource.Add(dataSourceItem);
				}
				properties.DataSource = properties_dataSource;
				responsesItem.Properties = properties;

				result_responses.Add(responsesItem);
			}
			result.Responses = result_responses;
			describeBcSchemaResponse.Result = result;
        
			return describeBcSchemaResponse;
        }
    }
}