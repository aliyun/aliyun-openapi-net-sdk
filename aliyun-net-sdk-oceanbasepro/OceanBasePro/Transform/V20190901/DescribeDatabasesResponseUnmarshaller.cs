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
using Aliyun.Acs.OceanBasePro.Model.V20190901;

namespace Aliyun.Acs.OceanBasePro.Transform.V20190901
{
    public class DescribeDatabasesResponseUnmarshaller
    {
        public static DescribeDatabasesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDatabasesResponse describeDatabasesResponse = new DescribeDatabasesResponse();

			describeDatabasesResponse.HttpResponse = _ctx.HttpResponse;
			describeDatabasesResponse.TotalCount = _ctx.IntegerValue("DescribeDatabases.TotalCount");
			describeDatabasesResponse.RequestId = _ctx.StringValue("DescribeDatabases.RequestId");

			List<DescribeDatabasesResponse.DescribeDatabases_Data> describeDatabasesResponse_databases = new List<DescribeDatabasesResponse.DescribeDatabases_Data>();
			for (int i = 0; i < _ctx.Length("DescribeDatabases.Databases.Length"); i++) {
				DescribeDatabasesResponse.DescribeDatabases_Data data = new DescribeDatabasesResponse.DescribeDatabases_Data();
				data.Status = _ctx.StringValue("DescribeDatabases.Databases["+ i +"].Status");
				data.Description = _ctx.StringValue("DescribeDatabases.Databases["+ i +"].Description");
				data.Encoding = _ctx.StringValue("DescribeDatabases.Databases["+ i +"].Encoding");
				data.DbType = _ctx.StringValue("DescribeDatabases.Databases["+ i +"].DbType");
				data.DatabaseName = _ctx.StringValue("DescribeDatabases.Databases["+ i +"].DatabaseName");
				data.CreateTime = _ctx.StringValue("DescribeDatabases.Databases["+ i +"].CreateTime");
				data.TenantId = _ctx.StringValue("DescribeDatabases.Databases["+ i +"].TenantId");
				data.RequiredSize = _ctx.DoubleValue("DescribeDatabases.Databases["+ i +"].RequiredSize");
				data.DataSize = _ctx.DoubleValue("DescribeDatabases.Databases["+ i +"].DataSize");
				data.Collation = _ctx.StringValue("DescribeDatabases.Databases["+ i +"].Collation");
				data.InstanceId = _ctx.StringValue("DescribeDatabases.Databases["+ i +"].InstanceId");
				data.TenantName = _ctx.StringValue("DescribeDatabases.Databases["+ i +"].TenantName");

				List<DescribeDatabasesResponse.DescribeDatabases_Data.DescribeDatabases_UsersItem> data_users = new List<DescribeDatabasesResponse.DescribeDatabases_Data.DescribeDatabases_UsersItem>();
				for (int j = 0; j < _ctx.Length("DescribeDatabases.Databases["+ i +"].Users.Length"); j++) {
					DescribeDatabasesResponse.DescribeDatabases_Data.DescribeDatabases_UsersItem usersItem = new DescribeDatabasesResponse.DescribeDatabases_Data.DescribeDatabases_UsersItem();
					usersItem.UserType = _ctx.StringValue("DescribeDatabases.Databases["+ i +"].Users["+ j +"].UserType");
					usersItem.Role = _ctx.StringValue("DescribeDatabases.Databases["+ i +"].Users["+ j +"].Role");
					usersItem.UserName = _ctx.StringValue("DescribeDatabases.Databases["+ i +"].Users["+ j +"].UserName");
					usersItem.Privileges = _ctx.StringValue("DescribeDatabases.Databases["+ i +"].Users["+ j +"].Privileges");

					data_users.Add(usersItem);
				}
				data.Users = data_users;

				List<DescribeDatabasesResponse.DescribeDatabases_Data.DescribeDatabases_TablesItem> data_tables = new List<DescribeDatabasesResponse.DescribeDatabases_Data.DescribeDatabases_TablesItem>();
				for (int j = 0; j < _ctx.Length("DescribeDatabases.Databases["+ i +"].Tables.Length"); j++) {
					DescribeDatabasesResponse.DescribeDatabases_Data.DescribeDatabases_TablesItem tablesItem = new DescribeDatabasesResponse.DescribeDatabases_Data.DescribeDatabases_TablesItem();
					tablesItem.TableName = _ctx.StringValue("DescribeDatabases.Databases["+ i +"].Tables["+ j +"].TableName");

					data_tables.Add(tablesItem);
				}
				data.Tables = data_tables;

				describeDatabasesResponse_databases.Add(data);
			}
			describeDatabasesResponse.Databases = describeDatabasesResponse_databases;
        
			return describeDatabasesResponse;
        }
    }
}
