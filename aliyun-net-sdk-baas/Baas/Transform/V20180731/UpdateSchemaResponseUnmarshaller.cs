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
    public class UpdateSchemaResponseUnmarshaller
    {
        public static UpdateSchemaResponse Unmarshall(UnmarshallerContext context)
        {
			UpdateSchemaResponse updateSchemaResponse = new UpdateSchemaResponse();

			updateSchemaResponse.HttpResponse = context.HttpResponse;
			updateSchemaResponse.RequestId = context.StringValue("UpdateSchema.RequestId");

			UpdateSchemaResponse.UpdateSchema_Result result = new UpdateSchemaResponse.UpdateSchema_Result();

			UpdateSchemaResponse.UpdateSchema_Result.UpdateSchema_Schema schema = new UpdateSchemaResponse.UpdateSchema_Result.UpdateSchema_Schema();
			schema.Id = context.LongValue("UpdateSchema.Result.Schema.Id");
			schema.Name = context.StringValue("UpdateSchema.Result.Schema.Name");
			schema.Description = context.StringValue("UpdateSchema.Result.Schema.Description");
			schema.Version = context.LongValue("UpdateSchema.Result.Schema.Version");
			schema.CreateTime = context.LongValue("UpdateSchema.Result.Schema.CreateTime");
			schema.UpdateTime = context.LongValue("UpdateSchema.Result.Schema.UpdateTime");
			schema.IsTemplate = context.BooleanValue("UpdateSchema.Result.Schema.IsTemplate");
			result.Schema = schema;

			List<UpdateSchemaResponse.UpdateSchema_Result.UpdateSchema_ResponsesItem> result_responses = new List<UpdateSchemaResponse.UpdateSchema_Result.UpdateSchema_ResponsesItem>();
			for (int i = 0; i < context.Length("UpdateSchema.Result.Responses.Length"); i++) {
				UpdateSchemaResponse.UpdateSchema_Result.UpdateSchema_ResponsesItem responsesItem = new UpdateSchemaResponse.UpdateSchema_Result.UpdateSchema_ResponsesItem();
				responsesItem.CategoryName = context.StringValue("UpdateSchema.Result.Responses["+ i +"].CategoryName");
				responsesItem.Description = context.StringValue("UpdateSchema.Result.Responses["+ i +"].Description");
				responsesItem.Category = context.StringValue("UpdateSchema.Result.Responses["+ i +"].Category");

				UpdateSchemaResponse.UpdateSchema_Result.UpdateSchema_ResponsesItem.UpdateSchema_Properties properties = new UpdateSchemaResponse.UpdateSchema_Result.UpdateSchema_ResponsesItem.UpdateSchema_Properties();
				properties.Count = context.IntegerValue("UpdateSchema.Result.Responses["+ i +"].Properties.Count");

				List<UpdateSchemaResponse.UpdateSchema_Result.UpdateSchema_ResponsesItem.UpdateSchema_Properties.UpdateSchema_DataSourceItem> properties_dataSource = new List<UpdateSchemaResponse.UpdateSchema_Result.UpdateSchema_ResponsesItem.UpdateSchema_Properties.UpdateSchema_DataSourceItem>();
				for (int j = 0; j < context.Length("UpdateSchema.Result.Responses["+ i +"].Properties.DataSource.Length"); j++) {
					UpdateSchemaResponse.UpdateSchema_Result.UpdateSchema_ResponsesItem.UpdateSchema_Properties.UpdateSchema_DataSourceItem dataSourceItem = new UpdateSchemaResponse.UpdateSchema_Result.UpdateSchema_ResponsesItem.UpdateSchema_Properties.UpdateSchema_DataSourceItem();
					dataSourceItem.Key = context.IntegerValue("UpdateSchema.Result.Responses["+ i +"].Properties.DataSource["+ j +"].Key");
					dataSourceItem.Field = context.StringValue("UpdateSchema.Result.Responses["+ i +"].Properties.DataSource["+ j +"].Field");
					dataSourceItem.Type = context.StringValue("UpdateSchema.Result.Responses["+ i +"].Properties.DataSource["+ j +"].Type");
					dataSourceItem.Length = context.IntegerValue("UpdateSchema.Result.Responses["+ i +"].Properties.DataSource["+ j +"].Length");
					dataSourceItem.AllowNull = context.IntegerValue("UpdateSchema.Result.Responses["+ i +"].Properties.DataSource["+ j +"].AllowNull");
					dataSourceItem.Reg = context.StringValue("UpdateSchema.Result.Responses["+ i +"].Properties.DataSource["+ j +"].Reg");
					dataSourceItem.Indexes = context.IntegerValue("UpdateSchema.Result.Responses["+ i +"].Properties.DataSource["+ j +"].Indexes");
					dataSourceItem.Annotation = context.StringValue("UpdateSchema.Result.Responses["+ i +"].Properties.DataSource["+ j +"].Annotation");

					properties_dataSource.Add(dataSourceItem);
				}
				properties.DataSource = properties_dataSource;
				responsesItem.Properties = properties;

				result_responses.Add(responsesItem);
			}
			result.Responses = result_responses;
			updateSchemaResponse.Result = result;
        
			return updateSchemaResponse;
        }
    }
}