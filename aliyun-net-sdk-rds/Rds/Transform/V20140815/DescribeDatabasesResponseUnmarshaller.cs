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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Rds.Model.V20140815;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeDatabasesResponseUnmarshaller
    {
        public static DescribeDatabasesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDatabasesResponse describeDatabasesResponse = new DescribeDatabasesResponse();

			describeDatabasesResponse.HttpResponse = context.HttpResponse;
			describeDatabasesResponse.RequestId = context.StringValue("DescribeDatabases.RequestId");

			List<DescribeDatabasesResponse.Database> databases = new List<DescribeDatabasesResponse.Database>();
			for (int i = 0; i < context.Length("DescribeDatabases.Databases.Length"); i++) {
				DescribeDatabasesResponse.Database database = new DescribeDatabasesResponse.Database();
				database.DBName = context.StringValue("DescribeDatabases.Databases["+ i +"].DBName");
				database.DBInstanceId = context.StringValue("DescribeDatabases.Databases["+ i +"].DBInstanceId");
				database.Engine = context.StringValue("DescribeDatabases.Databases["+ i +"].Engine");
				database.DBStatus = context.EnumValue<DescribeDatabasesResponse.Database.DBStatusEnum>("DescribeDatabases.Databases["+ i +"].DBStatus");
				database.CharacterSetName = context.StringValue("DescribeDatabases.Databases["+ i +"].CharacterSetName");
				database.DBDescription = context.StringValue("DescribeDatabases.Databases["+ i +"].DBDescription");

				List<DescribeDatabasesResponse.Database.AccountPrivilegeInfo> accounts = new List<DescribeDatabasesResponse.Database.AccountPrivilegeInfo>();
				for (int j = 0; j < context.Length("DescribeDatabases.Databases["+ i +"].Accounts.Length"); j++) {
					DescribeDatabasesResponse.Database.AccountPrivilegeInfo accountPrivilegeInfo = new DescribeDatabasesResponse.Database.AccountPrivilegeInfo();
					accountPrivilegeInfo.Account = context.StringValue("DescribeDatabases.Databases["+ i +"].Accounts["+ j +"].Account");
					accountPrivilegeInfo.AccountPrivilege = context.StringValue("DescribeDatabases.Databases["+ i +"].Accounts["+ j +"].AccountPrivilege");

					accounts.Add(accountPrivilegeInfo);
				}
				database.Accounts = accounts;

				databases.Add(database);
			}
			describeDatabasesResponse.Databases = databases;
        
			return describeDatabasesResponse;
        }
    }
}