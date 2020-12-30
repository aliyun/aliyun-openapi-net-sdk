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
using Aliyun.Acs.R_kvstore.Model.V20150101;

namespace Aliyun.Acs.R_kvstore.Transform.V20150101
{
    public class DescribeAccountsResponseUnmarshaller
    {
        public static DescribeAccountsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAccountsResponse describeAccountsResponse = new DescribeAccountsResponse();

			describeAccountsResponse.HttpResponse = _ctx.HttpResponse;
			describeAccountsResponse.RequestId = _ctx.StringValue("DescribeAccounts.RequestId");

			List<DescribeAccountsResponse.DescribeAccounts_Account> describeAccountsResponse_accounts = new List<DescribeAccountsResponse.DescribeAccounts_Account>();
			for (int i = 0; i < _ctx.Length("DescribeAccounts.Accounts.Length"); i++) {
				DescribeAccountsResponse.DescribeAccounts_Account account = new DescribeAccountsResponse.DescribeAccounts_Account();
				account.InstanceId = _ctx.StringValue("DescribeAccounts.Accounts["+ i +"].InstanceId");
				account.AccountName = _ctx.StringValue("DescribeAccounts.Accounts["+ i +"].AccountName");
				account.AccountStatus = _ctx.StringValue("DescribeAccounts.Accounts["+ i +"].AccountStatus");
				account.AccountType = _ctx.StringValue("DescribeAccounts.Accounts["+ i +"].AccountType");
				account.AccountDescription = _ctx.StringValue("DescribeAccounts.Accounts["+ i +"].AccountDescription");

				List<DescribeAccountsResponse.DescribeAccounts_Account.DescribeAccounts_DatabasePrivilege> account_databasePrivileges = new List<DescribeAccountsResponse.DescribeAccounts_Account.DescribeAccounts_DatabasePrivilege>();
				for (int j = 0; j < _ctx.Length("DescribeAccounts.Accounts["+ i +"].DatabasePrivileges.Length"); j++) {
					DescribeAccountsResponse.DescribeAccounts_Account.DescribeAccounts_DatabasePrivilege databasePrivilege = new DescribeAccountsResponse.DescribeAccounts_Account.DescribeAccounts_DatabasePrivilege();
					databasePrivilege.AccountPrivilege = _ctx.StringValue("DescribeAccounts.Accounts["+ i +"].DatabasePrivileges["+ j +"].AccountPrivilege");
					databasePrivilege.AccountPrivilegeDetail = _ctx.StringValue("DescribeAccounts.Accounts["+ i +"].DatabasePrivileges["+ j +"].AccountPrivilegeDetail");

					account_databasePrivileges.Add(databasePrivilege);
				}
				account.DatabasePrivileges = account_databasePrivileges;

				describeAccountsResponse_accounts.Add(account);
			}
			describeAccountsResponse.Accounts = describeAccountsResponse_accounts;
        
			return describeAccountsResponse;
        }
    }
}
