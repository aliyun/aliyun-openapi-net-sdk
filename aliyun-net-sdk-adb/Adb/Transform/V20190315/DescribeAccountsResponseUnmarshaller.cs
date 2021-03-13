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
using Aliyun.Acs.adb.Model.V20190315;

namespace Aliyun.Acs.adb.Transform.V20190315
{
    public class DescribeAccountsResponseUnmarshaller
    {
        public static DescribeAccountsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAccountsResponse describeAccountsResponse = new DescribeAccountsResponse();

			describeAccountsResponse.HttpResponse = _ctx.HttpResponse;
			describeAccountsResponse.RequestId = _ctx.StringValue("DescribeAccounts.RequestId");

			List<DescribeAccountsResponse.DescribeAccounts_DBAccount> describeAccountsResponse_accountList = new List<DescribeAccountsResponse.DescribeAccounts_DBAccount>();
			for (int i = 0; i < _ctx.Length("DescribeAccounts.AccountList.Length"); i++) {
				DescribeAccountsResponse.DescribeAccounts_DBAccount dBAccount = new DescribeAccountsResponse.DescribeAccounts_DBAccount();
				dBAccount.AccountName = _ctx.StringValue("DescribeAccounts.AccountList["+ i +"].AccountName");
				dBAccount.AccountStatus = _ctx.StringValue("DescribeAccounts.AccountList["+ i +"].AccountStatus");
				dBAccount.AccountDescription = _ctx.StringValue("DescribeAccounts.AccountList["+ i +"].AccountDescription");
				dBAccount.AccountType = _ctx.StringValue("DescribeAccounts.AccountList["+ i +"].AccountType");

				describeAccountsResponse_accountList.Add(dBAccount);
			}
			describeAccountsResponse.AccountList = describeAccountsResponse_accountList;
        
			return describeAccountsResponse;
        }
    }
}
