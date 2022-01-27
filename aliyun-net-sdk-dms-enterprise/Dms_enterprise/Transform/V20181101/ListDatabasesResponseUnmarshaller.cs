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
    public class ListDatabasesResponseUnmarshaller
    {
        public static ListDatabasesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDatabasesResponse listDatabasesResponse = new ListDatabasesResponse();

			listDatabasesResponse.HttpResponse = _ctx.HttpResponse;
			listDatabasesResponse.TotalCount = _ctx.LongValue("ListDatabases.TotalCount");
			listDatabasesResponse.RequestId = _ctx.StringValue("ListDatabases.RequestId");
			listDatabasesResponse.ErrorCode = _ctx.StringValue("ListDatabases.ErrorCode");
			listDatabasesResponse.ErrorMessage = _ctx.StringValue("ListDatabases.ErrorMessage");
			listDatabasesResponse.Success = _ctx.BooleanValue("ListDatabases.Success");

			List<ListDatabasesResponse.ListDatabases_Database> listDatabasesResponse_databaseList = new List<ListDatabasesResponse.ListDatabases_Database>();
			for (int i = 0; i < _ctx.Length("ListDatabases.DatabaseList.Length"); i++) {
				ListDatabasesResponse.ListDatabases_Database database = new ListDatabasesResponse.ListDatabases_Database();
				database.DatabaseId = _ctx.StringValue("ListDatabases.DatabaseList["+ i +"].DatabaseId");
				database.Host = _ctx.StringValue("ListDatabases.DatabaseList["+ i +"].Host");
				database.CatalogName = _ctx.StringValue("ListDatabases.DatabaseList["+ i +"].CatalogName");
				database.DbaName = _ctx.StringValue("ListDatabases.DatabaseList["+ i +"].DbaName");
				database.State = _ctx.StringValue("ListDatabases.DatabaseList["+ i +"].State");
				database.DbaId = _ctx.StringValue("ListDatabases.DatabaseList["+ i +"].DbaId");
				database.SchemaName = _ctx.StringValue("ListDatabases.DatabaseList["+ i +"].SchemaName");
				database.InstanceId = _ctx.StringValue("ListDatabases.DatabaseList["+ i +"].InstanceId");
				database.Port = _ctx.IntegerValue("ListDatabases.DatabaseList["+ i +"].Port");
				database.EnvType = _ctx.StringValue("ListDatabases.DatabaseList["+ i +"].EnvType");
				database.Sid = _ctx.StringValue("ListDatabases.DatabaseList["+ i +"].Sid");
				database.Encoding = _ctx.StringValue("ListDatabases.DatabaseList["+ i +"].Encoding");
				database.DbType = _ctx.StringValue("ListDatabases.DatabaseList["+ i +"].DbType");
				database.SearchName = _ctx.StringValue("ListDatabases.DatabaseList["+ i +"].SearchName");

				List<string> database_ownerIdList = new List<string>();
				for (int j = 0; j < _ctx.Length("ListDatabases.DatabaseList["+ i +"].OwnerIdList.Length"); j++) {
					database_ownerIdList.Add(_ctx.StringValue("ListDatabases.DatabaseList["+ i +"].OwnerIdList["+ j +"]"));
				}
				database.OwnerIdList = database_ownerIdList;

				List<string> database_ownerNameList = new List<string>();
				for (int j = 0; j < _ctx.Length("ListDatabases.DatabaseList["+ i +"].OwnerNameList.Length"); j++) {
					database_ownerNameList.Add(_ctx.StringValue("ListDatabases.DatabaseList["+ i +"].OwnerNameList["+ j +"]"));
				}
				database.OwnerNameList = database_ownerNameList;

				listDatabasesResponse_databaseList.Add(database);
			}
			listDatabasesResponse.DatabaseList = listDatabasesResponse_databaseList;
        
			return listDatabasesResponse;
        }
    }
}
