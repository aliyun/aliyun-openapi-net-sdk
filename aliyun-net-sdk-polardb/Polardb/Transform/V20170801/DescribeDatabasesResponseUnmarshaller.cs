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
using Aliyun.Acs.polardb.Model.V20170801;

namespace Aliyun.Acs.polardb.Transform.V20170801
{
    public class DescribeDatabasesResponseUnmarshaller
    {
        public static DescribeDatabasesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDatabasesResponse describeDatabasesResponse = new DescribeDatabasesResponse();

			describeDatabasesResponse.HttpResponse = _ctx.HttpResponse;
			describeDatabasesResponse.RequestId = _ctx.StringValue("DescribeDatabases.RequestId");
			describeDatabasesResponse.PageNumber = _ctx.IntegerValue("DescribeDatabases.PageNumber");
			describeDatabasesResponse.PageRecordCount = _ctx.IntegerValue("DescribeDatabases.PageRecordCount");

			List<DescribeDatabasesResponse.DescribeDatabases_Database> describeDatabasesResponse_databases = new List<DescribeDatabasesResponse.DescribeDatabases_Database>();
			for (int i = 0; i < _ctx.Length("DescribeDatabases.Databases.Length"); i++) {
				DescribeDatabasesResponse.DescribeDatabases_Database database = new DescribeDatabasesResponse.DescribeDatabases_Database();
				database.DBName = _ctx.StringValue("DescribeDatabases.Databases["+ i +"].DBName");
				database.DBStatus = _ctx.StringValue("DescribeDatabases.Databases["+ i +"].DBStatus");
				database.DBDescription = _ctx.StringValue("DescribeDatabases.Databases["+ i +"].DBDescription");
				database.CharacterSetName = _ctx.StringValue("DescribeDatabases.Databases["+ i +"].CharacterSetName");
				database.Engine = _ctx.StringValue("DescribeDatabases.Databases["+ i +"].Engine");

				List<DescribeDatabasesResponse.DescribeDatabases_Database.DescribeDatabases_Account> database_accounts = new List<DescribeDatabasesResponse.DescribeDatabases_Database.DescribeDatabases_Account>();
				for (int j = 0; j < _ctx.Length("DescribeDatabases.Databases["+ i +"].Accounts.Length"); j++) {
					DescribeDatabasesResponse.DescribeDatabases_Database.DescribeDatabases_Account account = new DescribeDatabasesResponse.DescribeDatabases_Database.DescribeDatabases_Account();
					account.AccountName = _ctx.StringValue("DescribeDatabases.Databases["+ i +"].Accounts["+ j +"].AccountName");
					account.AccountStatus = _ctx.StringValue("DescribeDatabases.Databases["+ i +"].Accounts["+ j +"].AccountStatus");
					account.AccountPrivilege = _ctx.StringValue("DescribeDatabases.Databases["+ i +"].Accounts["+ j +"].AccountPrivilege");
					account.PrivilegeStatus = _ctx.StringValue("DescribeDatabases.Databases["+ i +"].Accounts["+ j +"].PrivilegeStatus");

					database_accounts.Add(account);
				}
				database.Accounts = database_accounts;

				describeDatabasesResponse_databases.Add(database);
			}
			describeDatabasesResponse.Databases = describeDatabasesResponse_databases;
        
			return describeDatabasesResponse;
        }
    }
}
