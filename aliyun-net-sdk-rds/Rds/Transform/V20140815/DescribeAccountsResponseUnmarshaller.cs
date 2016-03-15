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
    public class DescribeAccountsResponseUnmarshaller
    {
        public static DescribeAccountsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAccountsResponse describeAccountsResponse = new DescribeAccountsResponse();

			describeAccountsResponse.HttpResponse = context.HttpResponse;
			describeAccountsResponse.RequestId = context.StringValue("DescribeAccounts.RequestId");

			List<DescribeAccountsResponse.DBInstanceAccount> accounts = new List<DescribeAccountsResponse.DBInstanceAccount>();
			for (int i = 0; i < context.Length("DescribeAccounts.Accounts.Length"); i++) {
				DescribeAccountsResponse.DBInstanceAccount dBInstanceAccount = new DescribeAccountsResponse.DBInstanceAccount();
				dBInstanceAccount.DBInstanceId = context.StringValue("DescribeAccounts.Accounts["+ i +"].DBInstanceId");
				dBInstanceAccount.AccountName = context.StringValue("DescribeAccounts.Accounts["+ i +"].AccountName");
				dBInstanceAccount.AccountStatus = context.EnumValue<DescribeAccountsResponse.DBInstanceAccount.AccountStatusEnum>("DescribeAccounts.Accounts["+ i +"].AccountStatus");
				dBInstanceAccount.AccountType = context.EnumValue<DescribeAccountsResponse.DBInstanceAccount.AccountTypeEnum>("DescribeAccounts.Accounts["+ i +"].AccountType");
				dBInstanceAccount.AccountDescription = context.StringValue("DescribeAccounts.Accounts["+ i +"].AccountDescription");

				List<DescribeAccountsResponse.DBInstanceAccount.DatabasePrivilege> databasePrivileges = new List<DescribeAccountsResponse.DBInstanceAccount.DatabasePrivilege>();
				for (int j = 0; j < context.Length("DescribeAccounts.Accounts["+ i +"].DatabasePrivileges.Length"); j++) {
					DescribeAccountsResponse.DBInstanceAccount.DatabasePrivilege databasePrivilege = new DescribeAccountsResponse.DBInstanceAccount.DatabasePrivilege();
					databasePrivilege.DBName = context.StringValue("DescribeAccounts.Accounts["+ i +"].DatabasePrivileges["+ j +"].DBName");
					databasePrivilege.AccountPrivilege = context.StringValue("DescribeAccounts.Accounts["+ i +"].DatabasePrivileges["+ j +"].AccountPrivilege");

					databasePrivileges.Add(databasePrivilege);
				}
				dBInstanceAccount.DatabasePrivileges = databasePrivileges;

				accounts.Add(dBInstanceAccount);
			}
			describeAccountsResponse.Accounts = accounts;
        
			return describeAccountsResponse;
        }
    }
}