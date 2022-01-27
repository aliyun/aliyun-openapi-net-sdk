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
using Aliyun.Acs.gpdb.Model.V20160503;

namespace Aliyun.Acs.gpdb.Transform.V20160503
{
    public class DescribeAccountsResponseUnmarshaller
    {
        public static DescribeAccountsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAccountsResponse describeAccountsResponse = new DescribeAccountsResponse();

			describeAccountsResponse.HttpResponse = _ctx.HttpResponse;
			describeAccountsResponse.RequestId = _ctx.StringValue("DescribeAccounts.RequestId");

			List<DescribeAccountsResponse.DescribeAccounts_DBInstanceAccount> describeAccountsResponse_accounts = new List<DescribeAccountsResponse.DescribeAccounts_DBInstanceAccount>();
			for (int i = 0; i < _ctx.Length("DescribeAccounts.Accounts.Length"); i++) {
				DescribeAccountsResponse.DescribeAccounts_DBInstanceAccount dBInstanceAccount = new DescribeAccountsResponse.DescribeAccounts_DBInstanceAccount();
				dBInstanceAccount.AccountStatus = _ctx.StringValue("DescribeAccounts.Accounts["+ i +"].AccountStatus");
				dBInstanceAccount.AccountDescription = _ctx.StringValue("DescribeAccounts.Accounts["+ i +"].AccountDescription");
				dBInstanceAccount.DBInstanceId = _ctx.StringValue("DescribeAccounts.Accounts["+ i +"].DBInstanceId");
				dBInstanceAccount.AccountName = _ctx.StringValue("DescribeAccounts.Accounts["+ i +"].AccountName");

				describeAccountsResponse_accounts.Add(dBInstanceAccount);
			}
			describeAccountsResponse.Accounts = describeAccountsResponse_accounts;
        
			return describeAccountsResponse;
        }
    }
}
