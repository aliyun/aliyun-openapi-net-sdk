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
using Aliyun.Acs.oos.Model.V20190601;

namespace Aliyun.Acs.oos.Transform.V20190601
{
    public class GetInventorySchemaResponseUnmarshaller
    {
        public static GetInventorySchemaResponse Unmarshall(UnmarshallerContext context)
        {
			GetInventorySchemaResponse getInventorySchemaResponse = new GetInventorySchemaResponse();

			getInventorySchemaResponse.HttpResponse = context.HttpResponse;
			getInventorySchemaResponse.RequestId = context.StringValue("GetInventorySchema.RequestId");
			getInventorySchemaResponse.NextToken = context.StringValue("GetInventorySchema.NextToken");

			List<GetInventorySchemaResponse.GetInventorySchema_Schema> getInventorySchemaResponse_schemas = new List<GetInventorySchemaResponse.GetInventorySchema_Schema>();
			for (int i = 0; i < context.Length("GetInventorySchema.Schemas.Length"); i++) {
				GetInventorySchemaResponse.GetInventorySchema_Schema schema = new GetInventorySchemaResponse.GetInventorySchema_Schema();
				schema.TypeName = context.StringValue("GetInventorySchema.Schemas["+ i +"].TypeName");
				schema.Version = context.StringValue("GetInventorySchema.Schemas["+ i +"].Version");

				List<GetInventorySchemaResponse.GetInventorySchema_Schema.GetInventorySchema_Attribute> schema_attributes = new List<GetInventorySchemaResponse.GetInventorySchema_Schema.GetInventorySchema_Attribute>();
				for (int j = 0; j < context.Length("GetInventorySchema.Schemas["+ i +"].Attributes.Length"); j++) {
					GetInventorySchemaResponse.GetInventorySchema_Schema.GetInventorySchema_Attribute attribute = new GetInventorySchemaResponse.GetInventorySchema_Schema.GetInventorySchema_Attribute();
					attribute.Name = context.StringValue("GetInventorySchema.Schemas["+ i +"].Attributes["+ j +"].Name");
					attribute.DataType = context.StringValue("GetInventorySchema.Schemas["+ i +"].Attributes["+ j +"].DataType");

					schema_attributes.Add(attribute);
				}
				schema.Attributes = schema_attributes;

				getInventorySchemaResponse_schemas.Add(schema);
			}
			getInventorySchemaResponse.Schemas = getInventorySchemaResponse_schemas;
        
			return getInventorySchemaResponse;
        }
    }
}
