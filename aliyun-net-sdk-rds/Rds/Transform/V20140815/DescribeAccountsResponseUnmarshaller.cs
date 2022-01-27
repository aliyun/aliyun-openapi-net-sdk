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
    public class DescribeAccountsResponseUnmarshaller
    {
        public static DescribeAccountsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAccountsResponse describeAccountsResponse = new DescribeAccountsResponse();

			describeAccountsResponse.HttpResponse = _ctx.HttpResponse;
			describeAccountsResponse.RequestId = _ctx.StringValue("DescribeAccounts.RequestId");
			describeAccountsResponse.SystemAdminAccountStatus = _ctx.StringValue("DescribeAccounts.SystemAdminAccountStatus");
			describeAccountsResponse.SystemAdminAccountFirstActivationTime = _ctx.StringValue("DescribeAccounts.SystemAdminAccountFirstActivationTime");
			describeAccountsResponse.PageNumber = _ctx.IntegerValue("DescribeAccounts.PageNumber");
			describeAccountsResponse.TotalRecordCount = _ctx.IntegerValue("DescribeAccounts.TotalRecordCount");

			List<DescribeAccountsResponse.DescribeAccounts_DBInstanceAccount> describeAccountsResponse_accounts = new List<DescribeAccountsResponse.DescribeAccounts_DBInstanceAccount>();
			for (int i = 0; i < _ctx.Length("DescribeAccounts.Accounts.Length"); i++) {
				DescribeAccountsResponse.DescribeAccounts_DBInstanceAccount dBInstanceAccount = new DescribeAccountsResponse.DescribeAccounts_DBInstanceAccount();
				dBInstanceAccount.DBInstanceId = _ctx.StringValue("DescribeAccounts.Accounts["+ i +"].DBInstanceId");
				dBInstanceAccount.AccountName = _ctx.StringValue("DescribeAccounts.Accounts["+ i +"].AccountName");
				dBInstanceAccount.AccountStatus = _ctx.StringValue("DescribeAccounts.Accounts["+ i +"].AccountStatus");
				dBInstanceAccount.AccountType = _ctx.StringValue("DescribeAccounts.Accounts["+ i +"].AccountType");
				dBInstanceAccount.AccountDescription = _ctx.StringValue("DescribeAccounts.Accounts["+ i +"].AccountDescription");
				dBInstanceAccount.PrivExceeded = _ctx.StringValue("DescribeAccounts.Accounts["+ i +"].PrivExceeded");

				List<DescribeAccountsResponse.DescribeAccounts_DBInstanceAccount.DescribeAccounts_DatabasePrivilege> dBInstanceAccount_databasePrivileges = new List<DescribeAccountsResponse.DescribeAccounts_DBInstanceAccount.DescribeAccounts_DatabasePrivilege>();
				for (int j = 0; j < _ctx.Length("DescribeAccounts.Accounts["+ i +"].DatabasePrivileges.Length"); j++) {
					DescribeAccountsResponse.DescribeAccounts_DBInstanceAccount.DescribeAccounts_DatabasePrivilege databasePrivilege = new DescribeAccountsResponse.DescribeAccounts_DBInstanceAccount.DescribeAccounts_DatabasePrivilege();
					databasePrivilege.DBName = _ctx.StringValue("DescribeAccounts.Accounts["+ i +"].DatabasePrivileges["+ j +"].DBName");
					databasePrivilege.AccountPrivilege = _ctx.StringValue("DescribeAccounts.Accounts["+ i +"].DatabasePrivileges["+ j +"].AccountPrivilege");
					databasePrivilege.AccountPrivilegeDetail = _ctx.StringValue("DescribeAccounts.Accounts["+ i +"].DatabasePrivileges["+ j +"].AccountPrivilegeDetail");

					dBInstanceAccount_databasePrivileges.Add(databasePrivilege);
				}
				dBInstanceAccount.DatabasePrivileges = dBInstanceAccount_databasePrivileges;

				describeAccountsResponse_accounts.Add(dBInstanceAccount);
			}
			describeAccountsResponse.Accounts = describeAccountsResponse_accounts;
        
			return describeAccountsResponse;
        }
    }
}
