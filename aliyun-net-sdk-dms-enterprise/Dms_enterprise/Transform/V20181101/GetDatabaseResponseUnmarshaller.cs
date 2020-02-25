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
using Aliyun.Acs.dms_enterprise.Model.V20181101;

namespace Aliyun.Acs.dms_enterprise.Transform.V20181101
{
    public class GetDatabaseResponseUnmarshaller
    {
        public static GetDatabaseResponse Unmarshall(UnmarshallerContext context)
        {
			GetDatabaseResponse getDatabaseResponse = new GetDatabaseResponse();

			getDatabaseResponse.HttpResponse = context.HttpResponse;
			getDatabaseResponse.RequestId = context.StringValue("GetDatabase.RequestId");
			getDatabaseResponse.Success = context.BooleanValue("GetDatabase.Success");
			getDatabaseResponse.ErrorMessage = context.StringValue("GetDatabase.ErrorMessage");
			getDatabaseResponse.ErrorCode = context.StringValue("GetDatabase.ErrorCode");

			GetDatabaseResponse.GetDatabase_Database database = new GetDatabaseResponse.GetDatabase_Database();
			database.InstanceId = context.StringValue("GetDatabase.Database.InstanceId");
			database.DatabaseId = context.StringValue("GetDatabase.Database.DatabaseId");
			database.EnvType = context.StringValue("GetDatabase.Database.EnvType");
			database.SchemaName = context.StringValue("GetDatabase.Database.SchemaName");
			database.CatalogName = context.StringValue("GetDatabase.Database.CatalogName");
			database.Encoding = context.StringValue("GetDatabase.Database.Encoding");
			database.SearchName = context.StringValue("GetDatabase.Database.SearchName");
			database.State = context.StringValue("GetDatabase.Database.State");
			database.DbType = context.StringValue("GetDatabase.Database.DbType");
			database.Host = context.StringValue("GetDatabase.Database.Host");
			database.Port = context.IntegerValue("GetDatabase.Database.Port");
			database.Sid = context.StringValue("GetDatabase.Database.Sid");
			database.DbaName = context.StringValue("GetDatabase.Database.DbaName");
			database.DbaId = context.StringValue("GetDatabase.Database.DbaId");

			List<string> database_ownerIdList = new List<string>();
			for (int i = 0; i < context.Length("GetDatabase.Database.OwnerIdList.Length"); i++) {
				database_ownerIdList.Add(context.StringValue("GetDatabase.Database.OwnerIdList["+ i +"]"));
			}
			database.OwnerIdList = database_ownerIdList;

			List<string> database_ownerNameList = new List<string>();
			for (int i = 0; i < context.Length("GetDatabase.Database.OwnerNameList.Length"); i++) {
				database_ownerNameList.Add(context.StringValue("GetDatabase.Database.OwnerNameList["+ i +"]"));
			}
			database.OwnerNameList = database_ownerNameList;
			getDatabaseResponse.Database = database;
        
			return getDatabaseResponse;
        }
    }
}
