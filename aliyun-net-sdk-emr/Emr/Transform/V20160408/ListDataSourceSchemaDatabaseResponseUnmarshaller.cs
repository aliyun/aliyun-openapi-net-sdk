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
    public class ListDataSourceSchemaDatabaseResponseUnmarshaller
    {
        public static ListDataSourceSchemaDatabaseResponse Unmarshall(UnmarshallerContext context)
        {
			ListDataSourceSchemaDatabaseResponse listDataSourceSchemaDatabaseResponse = new ListDataSourceSchemaDatabaseResponse();

			listDataSourceSchemaDatabaseResponse.HttpResponse = context.HttpResponse;
			listDataSourceSchemaDatabaseResponse.RequestId = context.StringValue("ListDataSourceSchemaDatabase.RequestId");
			listDataSourceSchemaDatabaseResponse.DataSourceId = context.StringValue("ListDataSourceSchemaDatabase.DataSourceId");

			List<ListDataSourceSchemaDatabaseResponse.ListDataSourceSchemaDatabase_Schema> listDataSourceSchemaDatabaseResponse_schemaList = new List<ListDataSourceSchemaDatabaseResponse.ListDataSourceSchemaDatabase_Schema>();
			for (int i = 0; i < context.Length("ListDataSourceSchemaDatabase.SchemaList.Length"); i++) {
				ListDataSourceSchemaDatabaseResponse.ListDataSourceSchemaDatabase_Schema schema = new ListDataSourceSchemaDatabaseResponse.ListDataSourceSchemaDatabase_Schema();
				schema.DbName = context.StringValue("ListDataSourceSchemaDatabase.SchemaList["+ i +"].DbName");
				schema.DbVersion = context.StringValue("ListDataSourceSchemaDatabase.SchemaList["+ i +"].DbVersion");
				schema.DbType = context.StringValue("ListDataSourceSchemaDatabase.SchemaList["+ i +"].DbType");

				listDataSourceSchemaDatabaseResponse_schemaList.Add(schema);
			}
			listDataSourceSchemaDatabaseResponse.SchemaList = listDataSourceSchemaDatabaseResponse_schemaList;
        
			return listDataSourceSchemaDatabaseResponse;
        }
    }
}
