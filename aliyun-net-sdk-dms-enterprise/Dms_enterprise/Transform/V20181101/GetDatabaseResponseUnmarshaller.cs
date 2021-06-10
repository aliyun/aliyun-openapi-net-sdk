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
        public static GetDatabaseResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDatabaseResponse getDatabaseResponse = new GetDatabaseResponse();

			getDatabaseResponse.HttpResponse = _ctx.HttpResponse;
			getDatabaseResponse.RequestId = _ctx.StringValue("GetDatabase.RequestId");
			getDatabaseResponse.ErrorCode = _ctx.StringValue("GetDatabase.ErrorCode");
			getDatabaseResponse.ErrorMessage = _ctx.StringValue("GetDatabase.ErrorMessage");
			getDatabaseResponse.Success = _ctx.BooleanValue("GetDatabase.Success");

			GetDatabaseResponse.GetDatabase_Database database = new GetDatabaseResponse.GetDatabase_Database();
			database.DatabaseId = _ctx.StringValue("GetDatabase.Database.DatabaseId");
			database.Host = _ctx.StringValue("GetDatabase.Database.Host");
			database.CatalogName = _ctx.StringValue("GetDatabase.Database.CatalogName");
			database.DbaName = _ctx.StringValue("GetDatabase.Database.DbaName");
			database.State = _ctx.StringValue("GetDatabase.Database.State");
			database.DbaId = _ctx.StringValue("GetDatabase.Database.DbaId");
			database.SchemaName = _ctx.StringValue("GetDatabase.Database.SchemaName");
			database.InstanceId = _ctx.StringValue("GetDatabase.Database.InstanceId");
			database.Port = _ctx.IntegerValue("GetDatabase.Database.Port");
			database.EnvType = _ctx.StringValue("GetDatabase.Database.EnvType");
			database.Sid = _ctx.StringValue("GetDatabase.Database.Sid");
			database.Encoding = _ctx.StringValue("GetDatabase.Database.Encoding");
			database.DbType = _ctx.StringValue("GetDatabase.Database.DbType");
			database.SearchName = _ctx.StringValue("GetDatabase.Database.SearchName");

			List<string> database_ownerIdList = new List<string>();
			for (int i = 0; i < _ctx.Length("GetDatabase.Database.OwnerIdList.Length"); i++) {
				database_ownerIdList.Add(_ctx.StringValue("GetDatabase.Database.OwnerIdList["+ i +"]"));
			}
			database.OwnerIdList = database_ownerIdList;

			List<string> database_ownerNameList = new List<string>();
			for (int i = 0; i < _ctx.Length("GetDatabase.Database.OwnerNameList.Length"); i++) {
				database_ownerNameList.Add(_ctx.StringValue("GetDatabase.Database.OwnerNameList["+ i +"]"));
			}
			database.OwnerNameList = database_ownerNameList;
			getDatabaseResponse.Database = database;
        
			return getDatabaseResponse;
        }
    }
}
