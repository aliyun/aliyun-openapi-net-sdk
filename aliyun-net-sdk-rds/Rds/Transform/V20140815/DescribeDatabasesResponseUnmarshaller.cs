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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeDatabasesResponseUnmarshaller
    {
        public static DescribeDatabasesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDatabasesResponse describeDatabasesResponse = new DescribeDatabasesResponse();

			describeDatabasesResponse.HttpResponse = _ctx.HttpResponse;
			describeDatabasesResponse.RequestId = _ctx.StringValue("DescribeDatabases.RequestId");

			List<DescribeDatabasesResponse.DescribeDatabases_Database> describeDatabasesResponse_databases = new List<DescribeDatabasesResponse.DescribeDatabases_Database>();
			for (int i = 0; i < _ctx.Length("DescribeDatabases.Databases.Length"); i++) {
				DescribeDatabasesResponse.DescribeDatabases_Database database = new DescribeDatabasesResponse.DescribeDatabases_Database();
				database.DBName = _ctx.StringValue("DescribeDatabases.Databases["+ i +"].DBName");
				database.DBInstanceId = _ctx.StringValue("DescribeDatabases.Databases["+ i +"].DBInstanceId");
				database.Engine = _ctx.StringValue("DescribeDatabases.Databases["+ i +"].Engine");
				database.DBStatus = _ctx.StringValue("DescribeDatabases.Databases["+ i +"].DBStatus");
				database.CharacterSetName = _ctx.StringValue("DescribeDatabases.Databases["+ i +"].CharacterSetName");
				database.DBDescription = _ctx.StringValue("DescribeDatabases.Databases["+ i +"].DBDescription");

				List<DescribeDatabasesResponse.DescribeDatabases_Database.DescribeDatabases_AccountPrivilegeInfo> database_accounts = new List<DescribeDatabasesResponse.DescribeDatabases_Database.DescribeDatabases_AccountPrivilegeInfo>();
				for (int j = 0; j < _ctx.Length("DescribeDatabases.Databases["+ i +"].Accounts.Length"); j++) {
					DescribeDatabasesResponse.DescribeDatabases_Database.DescribeDatabases_AccountPrivilegeInfo accountPrivilegeInfo = new DescribeDatabasesResponse.DescribeDatabases_Database.DescribeDatabases_AccountPrivilegeInfo();
					accountPrivilegeInfo.Account = _ctx.StringValue("DescribeDatabases.Databases["+ i +"].Accounts["+ j +"].Account");
					accountPrivilegeInfo.AccountPrivilege = _ctx.StringValue("DescribeDatabases.Databases["+ i +"].Accounts["+ j +"].AccountPrivilege");
					accountPrivilegeInfo.AccountPrivilegeDetail = _ctx.StringValue("DescribeDatabases.Databases["+ i +"].Accounts["+ j +"].AccountPrivilegeDetail");

					database_accounts.Add(accountPrivilegeInfo);
				}
				database.Accounts = database_accounts;

				describeDatabasesResponse_databases.Add(database);
			}
			describeDatabasesResponse.Databases = describeDatabasesResponse_databases;
        
			return describeDatabasesResponse;
        }
    }
}
