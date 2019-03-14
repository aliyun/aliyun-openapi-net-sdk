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
    public class ListDataSourceSchemaTableResponseUnmarshaller
    {
        public static ListDataSourceSchemaTableResponse Unmarshall(UnmarshallerContext context)
        {
			ListDataSourceSchemaTableResponse listDataSourceSchemaTableResponse = new ListDataSourceSchemaTableResponse();

			listDataSourceSchemaTableResponse.HttpResponse = context.HttpResponse;
			listDataSourceSchemaTableResponse.RequestId = context.StringValue("ListDataSourceSchemaTable.RequestId");
			listDataSourceSchemaTableResponse.DataSourceId = context.StringValue("ListDataSourceSchemaTable.DataSourceId");

			List<ListDataSourceSchemaTableResponse.ListDataSourceSchemaTable_Schema> listDataSourceSchemaTableResponse_schemaList = new List<ListDataSourceSchemaTableResponse.ListDataSourceSchemaTable_Schema>();
			for (int i = 0; i < context.Length("ListDataSourceSchemaTable.SchemaList.Length"); i++) {
				ListDataSourceSchemaTableResponse.ListDataSourceSchemaTable_Schema schema = new ListDataSourceSchemaTableResponse.ListDataSourceSchemaTable_Schema();
				schema.DbType = context.StringValue("ListDataSourceSchemaTable.SchemaList["+ i +"].DbType");
				schema.DbVersion = context.StringValue("ListDataSourceSchemaTable.SchemaList["+ i +"].DbVersion");
				schema.DbName = context.StringValue("ListDataSourceSchemaTable.SchemaList["+ i +"].DbName");
				schema.TableName = context.StringValue("ListDataSourceSchemaTable.SchemaList["+ i +"].TableName");

				List<ListDataSourceSchemaTableResponse.ListDataSourceSchemaTable_Schema.ListDataSourceSchemaTable_Field> schema_fields = new List<ListDataSourceSchemaTableResponse.ListDataSourceSchemaTable_Schema.ListDataSourceSchemaTable_Field>();
				for (int j = 0; j < context.Length("ListDataSourceSchemaTable.SchemaList["+ i +"].Fields.Length"); j++) {
					ListDataSourceSchemaTableResponse.ListDataSourceSchemaTable_Schema.ListDataSourceSchemaTable_Field field = new ListDataSourceSchemaTableResponse.ListDataSourceSchemaTable_Schema.ListDataSourceSchemaTable_Field();
					field.Type = context.StringValue("ListDataSourceSchemaTable.SchemaList["+ i +"].Fields["+ j +"].Type");
					field.Name = context.StringValue("ListDataSourceSchemaTable.SchemaList["+ i +"].Fields["+ j +"].Name");
					field.Index = context.IntegerValue("ListDataSourceSchemaTable.SchemaList["+ i +"].Fields["+ j +"].Index");
					field.RawType = context.StringValue("ListDataSourceSchemaTable.SchemaList["+ i +"].Fields["+ j +"].RawType");
					field.AssignType = context.StringValue("ListDataSourceSchemaTable.SchemaList["+ i +"].Fields["+ j +"].AssignType");
					field.AssignValue = context.StringValue("ListDataSourceSchemaTable.SchemaList["+ i +"].Fields["+ j +"].AssignValue");

					schema_fields.Add(field);
				}
				schema.Fields = schema_fields;

				listDataSourceSchemaTableResponse_schemaList.Add(schema);
			}
			listDataSourceSchemaTableResponse.SchemaList = listDataSourceSchemaTableResponse_schemaList;
        
			return listDataSourceSchemaTableResponse;
        }
    }
}
