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
using Aliyun.Acs.retailcloud.Model.V20180313;

namespace Aliyun.Acs.retailcloud.Transform.V20180313
{
    public class DescribeDatabasesResponseUnmarshaller
    {
        public static DescribeDatabasesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDatabasesResponse describeDatabasesResponse = new DescribeDatabasesResponse();

			describeDatabasesResponse.HttpResponse = context.HttpResponse;
			describeDatabasesResponse.Code = context.IntegerValue("DescribeDatabases.Code");
			describeDatabasesResponse.RequestId = context.StringValue("DescribeDatabases.RequestId");
			describeDatabasesResponse.ErrMsg = context.StringValue("DescribeDatabases.ErrMsg");

			DescribeDatabasesResponse.DescribeDatabases_Result result = new DescribeDatabasesResponse.DescribeDatabases_Result();

			List<DescribeDatabasesResponse.DescribeDatabases_Result.DescribeDatabases_DatabasesItem> result_databases = new List<DescribeDatabasesResponse.DescribeDatabases_Result.DescribeDatabases_DatabasesItem>();
			for (int i = 0; i < context.Length("DescribeDatabases.Result.Databases.Length"); i++) {
				DescribeDatabasesResponse.DescribeDatabases_Result.DescribeDatabases_DatabasesItem databasesItem = new DescribeDatabasesResponse.DescribeDatabases_Result.DescribeDatabases_DatabasesItem();
				databasesItem.DBName = context.StringValue("DescribeDatabases.Result.Databases["+ i +"].DBName");
				databasesItem.DBStatus = context.StringValue("DescribeDatabases.Result.Databases["+ i +"].DBStatus");
				databasesItem.DBDescription = context.StringValue("DescribeDatabases.Result.Databases["+ i +"].DBDescription");
				databasesItem.Engine = context.StringValue("DescribeDatabases.Result.Databases["+ i +"].Engine");
				databasesItem.CharacterSetName = context.StringValue("DescribeDatabases.Result.Databases["+ i +"].CharacterSetName");
				databasesItem.DBInstanceId = context.StringValue("DescribeDatabases.Result.Databases["+ i +"].DBInstanceId");

				List<DescribeDatabasesResponse.DescribeDatabases_Result.DescribeDatabases_DatabasesItem.DescribeDatabases_AccountsItem> databasesItem_accounts = new List<DescribeDatabasesResponse.DescribeDatabases_Result.DescribeDatabases_DatabasesItem.DescribeDatabases_AccountsItem>();
				for (int j = 0; j < context.Length("DescribeDatabases.Result.Databases["+ i +"].Accounts.Length"); j++) {
					DescribeDatabasesResponse.DescribeDatabases_Result.DescribeDatabases_DatabasesItem.DescribeDatabases_AccountsItem accountsItem = new DescribeDatabasesResponse.DescribeDatabases_Result.DescribeDatabases_DatabasesItem.DescribeDatabases_AccountsItem();
					accountsItem.AccountPrivilegeDetail = context.StringValue("DescribeDatabases.Result.Databases["+ i +"].Accounts["+ j +"].AccountPrivilegeDetail");
					accountsItem.AccountPrivilege = context.StringValue("DescribeDatabases.Result.Databases["+ i +"].Accounts["+ j +"].AccountPrivilege");
					accountsItem.Account = context.StringValue("DescribeDatabases.Result.Databases["+ i +"].Accounts["+ j +"].Account");

					databasesItem_accounts.Add(accountsItem);
				}
				databasesItem.Accounts = databasesItem_accounts;

				result_databases.Add(databasesItem);
			}
			result.Databases = result_databases;
			describeDatabasesResponse.Result = result;
        
			return describeDatabasesResponse;
        }
    }
}
