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
    public class GetPhysicalDatabaseResponseUnmarshaller
    {
        public static GetPhysicalDatabaseResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetPhysicalDatabaseResponse getPhysicalDatabaseResponse = new GetPhysicalDatabaseResponse();

			getPhysicalDatabaseResponse.HttpResponse = _ctx.HttpResponse;
			getPhysicalDatabaseResponse.RequestId = _ctx.StringValue("GetPhysicalDatabase.RequestId");
			getPhysicalDatabaseResponse.ErrorCode = _ctx.StringValue("GetPhysicalDatabase.ErrorCode");
			getPhysicalDatabaseResponse.ErrorMessage = _ctx.StringValue("GetPhysicalDatabase.ErrorMessage");
			getPhysicalDatabaseResponse.Success = _ctx.BooleanValue("GetPhysicalDatabase.Success");

			GetPhysicalDatabaseResponse.GetPhysicalDatabase_Database database = new GetPhysicalDatabaseResponse.GetPhysicalDatabase_Database();
			database.DatabaseId = _ctx.StringValue("GetPhysicalDatabase.Database.DatabaseId");
			database.Host = _ctx.StringValue("GetPhysicalDatabase.Database.Host");
			database.CatalogName = _ctx.StringValue("GetPhysicalDatabase.Database.CatalogName");
			database.DbaName = _ctx.StringValue("GetPhysicalDatabase.Database.DbaName");
			database.State = _ctx.StringValue("GetPhysicalDatabase.Database.State");
			database.DbaId = _ctx.StringValue("GetPhysicalDatabase.Database.DbaId");
			database.SchemaName = _ctx.StringValue("GetPhysicalDatabase.Database.SchemaName");
			database.InstanceId = _ctx.StringValue("GetPhysicalDatabase.Database.InstanceId");
			database.Port = _ctx.IntegerValue("GetPhysicalDatabase.Database.Port");
			database.EnvType = _ctx.StringValue("GetPhysicalDatabase.Database.EnvType");
			database.Sid = _ctx.StringValue("GetPhysicalDatabase.Database.Sid");
			database.Encoding = _ctx.StringValue("GetPhysicalDatabase.Database.Encoding");
			database.DbType = _ctx.StringValue("GetPhysicalDatabase.Database.DbType");
			database.SearchName = _ctx.StringValue("GetPhysicalDatabase.Database.SearchName");

			List<string> database_ownerIdList = new List<string>();
			for (int i = 0; i < _ctx.Length("GetPhysicalDatabase.Database.OwnerIdList.Length"); i++) {
				database_ownerIdList.Add(_ctx.StringValue("GetPhysicalDatabase.Database.OwnerIdList["+ i +"]"));
			}
			database.OwnerIdList = database_ownerIdList;

			List<string> database_ownerNameList = new List<string>();
			for (int i = 0; i < _ctx.Length("GetPhysicalDatabase.Database.OwnerNameList.Length"); i++) {
				database_ownerNameList.Add(_ctx.StringValue("GetPhysicalDatabase.Database.OwnerNameList["+ i +"]"));
			}
			database.OwnerNameList = database_ownerNameList;
			getPhysicalDatabaseResponse.Database = database;
        
			return getPhysicalDatabaseResponse;
        }
    }
}
