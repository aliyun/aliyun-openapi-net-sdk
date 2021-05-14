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
using Aliyun.Acs.Drds.Model.V20190123;

namespace Aliyun.Acs.Drds.Transform.V20190123
{
    public class DescribeInstanceAccountsResponseUnmarshaller
    {
        public static DescribeInstanceAccountsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstanceAccountsResponse describeInstanceAccountsResponse = new DescribeInstanceAccountsResponse();

			describeInstanceAccountsResponse.HttpResponse = _ctx.HttpResponse;
			describeInstanceAccountsResponse.RequestId = _ctx.StringValue("DescribeInstanceAccounts.RequestId");
			describeInstanceAccountsResponse.Success = _ctx.BooleanValue("DescribeInstanceAccounts.Success");

			List<DescribeInstanceAccountsResponse.DescribeInstanceAccounts_InstanceAccount> describeInstanceAccountsResponse_instanceAccounts = new List<DescribeInstanceAccountsResponse.DescribeInstanceAccounts_InstanceAccount>();
			for (int i = 0; i < _ctx.Length("DescribeInstanceAccounts.InstanceAccounts.Length"); i++) {
				DescribeInstanceAccountsResponse.DescribeInstanceAccounts_InstanceAccount instanceAccount = new DescribeInstanceAccountsResponse.DescribeInstanceAccounts_InstanceAccount();
				instanceAccount.AccountName = _ctx.StringValue("DescribeInstanceAccounts.InstanceAccounts["+ i +"].AccountName");
				instanceAccount.Host = _ctx.StringValue("DescribeInstanceAccounts.InstanceAccounts["+ i +"].Host");
				instanceAccount.AccountType = _ctx.IntegerValue("DescribeInstanceAccounts.InstanceAccounts["+ i +"].AccountType");
				instanceAccount.Description = _ctx.StringValue("DescribeInstanceAccounts.InstanceAccounts["+ i +"].Description");

				List<DescribeInstanceAccountsResponse.DescribeInstanceAccounts_InstanceAccount.DescribeInstanceAccounts_DbPrivilege> instanceAccount_dbPrivileges = new List<DescribeInstanceAccountsResponse.DescribeInstanceAccounts_InstanceAccount.DescribeInstanceAccounts_DbPrivilege>();
				for (int j = 0; j < _ctx.Length("DescribeInstanceAccounts.InstanceAccounts["+ i +"].DbPrivileges.Length"); j++) {
					DescribeInstanceAccountsResponse.DescribeInstanceAccounts_InstanceAccount.DescribeInstanceAccounts_DbPrivilege dbPrivilege = new DescribeInstanceAccountsResponse.DescribeInstanceAccounts_InstanceAccount.DescribeInstanceAccounts_DbPrivilege();
					dbPrivilege.DbName = _ctx.StringValue("DescribeInstanceAccounts.InstanceAccounts["+ i +"].DbPrivileges["+ j +"].DbName");
					dbPrivilege.Privilege = _ctx.StringValue("DescribeInstanceAccounts.InstanceAccounts["+ i +"].DbPrivileges["+ j +"].Privilege");

					instanceAccount_dbPrivileges.Add(dbPrivilege);
				}
				instanceAccount.DbPrivileges = instanceAccount_dbPrivileges;

				describeInstanceAccountsResponse_instanceAccounts.Add(instanceAccount);
			}
			describeInstanceAccountsResponse.InstanceAccounts = describeInstanceAccountsResponse_instanceAccounts;
        
			return describeInstanceAccountsResponse;
        }
    }
}
