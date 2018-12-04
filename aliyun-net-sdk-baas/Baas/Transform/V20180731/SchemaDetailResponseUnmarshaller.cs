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
    public class SchemaDetailResponseUnmarshaller
    {
        public static SchemaDetailResponse Unmarshall(UnmarshallerContext context)
        {
			SchemaDetailResponse schemaDetailResponse = new SchemaDetailResponse();

			schemaDetailResponse.HttpResponse = context.HttpResponse;
			schemaDetailResponse.RequestId = context.StringValue("SchemaDetail.RequestId");

			SchemaDetailResponse.SchemaDetail_Result result = new SchemaDetailResponse.SchemaDetail_Result();

			SchemaDetailResponse.SchemaDetail_Result.SchemaDetail_Schema schema = new SchemaDetailResponse.SchemaDetail_Result.SchemaDetail_Schema();
			schema.Id = context.LongValue("SchemaDetail.Result.Schema.Id");
			schema.Name = context.StringValue("SchemaDetail.Result.Schema.Name");
			schema.Description = context.StringValue("SchemaDetail.Result.Schema.Description");
			schema.Version = context.LongValue("SchemaDetail.Result.Schema.Version");
			schema.CreateTime = context.LongValue("SchemaDetail.Result.Schema.CreateTime");
			schema.UpdateTime = context.LongValue("SchemaDetail.Result.Schema.UpdateTime");
			schema.IsTemplate = context.BooleanValue("SchemaDetail.Result.Schema.IsTemplate");
			result.Schema = schema;

			List<SchemaDetailResponse.SchemaDetail_Result.SchemaDetail_ResponsesItem> result_responses = new List<SchemaDetailResponse.SchemaDetail_Result.SchemaDetail_ResponsesItem>();
			for (int i = 0; i < context.Length("SchemaDetail.Result.Responses.Length"); i++) {
				SchemaDetailResponse.SchemaDetail_Result.SchemaDetail_ResponsesItem responsesItem = new SchemaDetailResponse.SchemaDetail_Result.SchemaDetail_ResponsesItem();
				responsesItem.CategoryName = context.StringValue("SchemaDetail.Result.Responses["+ i +"].CategoryName");
				responsesItem.Description = context.StringValue("SchemaDetail.Result.Responses["+ i +"].Description");
				responsesItem.Category = context.StringValue("SchemaDetail.Result.Responses["+ i +"].Category");

				SchemaDetailResponse.SchemaDetail_Result.SchemaDetail_ResponsesItem.SchemaDetail_Properties properties = new SchemaDetailResponse.SchemaDetail_Result.SchemaDetail_ResponsesItem.SchemaDetail_Properties();
				properties.Count = context.IntegerValue("SchemaDetail.Result.Responses["+ i +"].Properties.Count");

				List<SchemaDetailResponse.SchemaDetail_Result.SchemaDetail_ResponsesItem.SchemaDetail_Properties.SchemaDetail_DataSourceItem> properties_dataSource = new List<SchemaDetailResponse.SchemaDetail_Result.SchemaDetail_ResponsesItem.SchemaDetail_Properties.SchemaDetail_DataSourceItem>();
				for (int j = 0; j < context.Length("SchemaDetail.Result.Responses["+ i +"].Properties.DataSource.Length"); j++) {
					SchemaDetailResponse.SchemaDetail_Result.SchemaDetail_ResponsesItem.SchemaDetail_Properties.SchemaDetail_DataSourceItem dataSourceItem = new SchemaDetailResponse.SchemaDetail_Result.SchemaDetail_ResponsesItem.SchemaDetail_Properties.SchemaDetail_DataSourceItem();
					dataSourceItem.Key = context.IntegerValue("SchemaDetail.Result.Responses["+ i +"].Properties.DataSource["+ j +"].Key");
					dataSourceItem.Field = context.StringValue("SchemaDetail.Result.Responses["+ i +"].Properties.DataSource["+ j +"].Field");
					dataSourceItem.Type = context.StringValue("SchemaDetail.Result.Responses["+ i +"].Properties.DataSource["+ j +"].Type");
					dataSourceItem.Length = context.IntegerValue("SchemaDetail.Result.Responses["+ i +"].Properties.DataSource["+ j +"].Length");
					dataSourceItem.AllowNull = context.IntegerValue("SchemaDetail.Result.Responses["+ i +"].Properties.DataSource["+ j +"].AllowNull");
					dataSourceItem.Reg = context.StringValue("SchemaDetail.Result.Responses["+ i +"].Properties.DataSource["+ j +"].Reg");
					dataSourceItem.Indexes = context.IntegerValue("SchemaDetail.Result.Responses["+ i +"].Properties.DataSource["+ j +"].Indexes");
					dataSourceItem.Annotation = context.StringValue("SchemaDetail.Result.Responses["+ i +"].Properties.DataSource["+ j +"].Annotation");

					properties_dataSource.Add(dataSourceItem);
				}
				properties.DataSource = properties_dataSource;
				responsesItem.Properties = properties;

				result_responses.Add(responsesItem);
			}
			result.Responses = result_responses;
			schemaDetailResponse.Result = result;
        
			return schemaDetailResponse;
        }
    }
}