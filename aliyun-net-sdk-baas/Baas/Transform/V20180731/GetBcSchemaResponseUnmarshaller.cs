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
    public class GetBcSchemaResponseUnmarshaller
    {
        public static GetBcSchemaResponse Unmarshall(UnmarshallerContext context)
        {
			GetBcSchemaResponse getBcSchemaResponse = new GetBcSchemaResponse();

			getBcSchemaResponse.HttpResponse = context.HttpResponse;
			getBcSchemaResponse.RequestId = context.StringValue("GetBcSchema.RequestId");

			GetBcSchemaResponse.GetBcSchema_Result result = new GetBcSchemaResponse.GetBcSchema_Result();

			GetBcSchemaResponse.GetBcSchema_Result.GetBcSchema_Schema schema = new GetBcSchemaResponse.GetBcSchema_Result.GetBcSchema_Schema();
			schema.Id = context.LongValue("GetBcSchema.Result.Schema.Id");
			schema.Name = context.StringValue("GetBcSchema.Result.Schema.Name");
			schema.Description = context.StringValue("GetBcSchema.Result.Schema.Description");
			schema.Version = context.LongValue("GetBcSchema.Result.Schema.Version");
			schema.CreateTime = context.LongValue("GetBcSchema.Result.Schema.CreateTime");
			schema.UpdateTime = context.LongValue("GetBcSchema.Result.Schema.UpdateTime");
			schema.IsTemplate = context.BooleanValue("GetBcSchema.Result.Schema.IsTemplate");
			result.Schema = schema;

			List<GetBcSchemaResponse.GetBcSchema_Result.GetBcSchema_ResponsesItem> result_responses = new List<GetBcSchemaResponse.GetBcSchema_Result.GetBcSchema_ResponsesItem>();
			for (int i = 0; i < context.Length("GetBcSchema.Result.Responses.Length"); i++) {
				GetBcSchemaResponse.GetBcSchema_Result.GetBcSchema_ResponsesItem responsesItem = new GetBcSchemaResponse.GetBcSchema_Result.GetBcSchema_ResponsesItem();
				responsesItem.CategoryName = context.StringValue("GetBcSchema.Result.Responses["+ i +"].CategoryName");
				responsesItem.Description = context.StringValue("GetBcSchema.Result.Responses["+ i +"].Description");
				responsesItem.Category = context.StringValue("GetBcSchema.Result.Responses["+ i +"].Category");

				GetBcSchemaResponse.GetBcSchema_Result.GetBcSchema_ResponsesItem.GetBcSchema_Properties properties = new GetBcSchemaResponse.GetBcSchema_Result.GetBcSchema_ResponsesItem.GetBcSchema_Properties();
				properties.Count = context.IntegerValue("GetBcSchema.Result.Responses["+ i +"].Properties.Count");

				List<GetBcSchemaResponse.GetBcSchema_Result.GetBcSchema_ResponsesItem.GetBcSchema_Properties.GetBcSchema_DataSourceItem> properties_dataSource = new List<GetBcSchemaResponse.GetBcSchema_Result.GetBcSchema_ResponsesItem.GetBcSchema_Properties.GetBcSchema_DataSourceItem>();
				for (int j = 0; j < context.Length("GetBcSchema.Result.Responses["+ i +"].Properties.DataSource.Length"); j++) {
					GetBcSchemaResponse.GetBcSchema_Result.GetBcSchema_ResponsesItem.GetBcSchema_Properties.GetBcSchema_DataSourceItem dataSourceItem = new GetBcSchemaResponse.GetBcSchema_Result.GetBcSchema_ResponsesItem.GetBcSchema_Properties.GetBcSchema_DataSourceItem();
					dataSourceItem.Key = context.IntegerValue("GetBcSchema.Result.Responses["+ i +"].Properties.DataSource["+ j +"].Key");
					dataSourceItem.Field = context.StringValue("GetBcSchema.Result.Responses["+ i +"].Properties.DataSource["+ j +"].Field");
					dataSourceItem.Type = context.StringValue("GetBcSchema.Result.Responses["+ i +"].Properties.DataSource["+ j +"].Type");
					dataSourceItem.Length = context.IntegerValue("GetBcSchema.Result.Responses["+ i +"].Properties.DataSource["+ j +"].Length");
					dataSourceItem.AllowNull = context.IntegerValue("GetBcSchema.Result.Responses["+ i +"].Properties.DataSource["+ j +"].AllowNull");
					dataSourceItem.Reg = context.StringValue("GetBcSchema.Result.Responses["+ i +"].Properties.DataSource["+ j +"].Reg");
					dataSourceItem.Indexes = context.IntegerValue("GetBcSchema.Result.Responses["+ i +"].Properties.DataSource["+ j +"].Indexes");
					dataSourceItem.Annotation = context.StringValue("GetBcSchema.Result.Responses["+ i +"].Properties.DataSource["+ j +"].Annotation");

					properties_dataSource.Add(dataSourceItem);
				}
				properties.DataSource = properties_dataSource;
				responsesItem.Properties = properties;

				result_responses.Add(responsesItem);
			}
			result.Responses = result_responses;
			getBcSchemaResponse.Result = result;
        
			return getBcSchemaResponse;
        }
    }
}