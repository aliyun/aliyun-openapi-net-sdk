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
    public class DescribeRdsAccountsResponseUnmarshaller
    {
        public static DescribeRdsAccountsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRdsAccountsResponse describeRdsAccountsResponse = new DescribeRdsAccountsResponse();

			describeRdsAccountsResponse.HttpResponse = context.HttpResponse;
			describeRdsAccountsResponse.Code = context.IntegerValue("DescribeRdsAccounts.Code");
			describeRdsAccountsResponse.Success = context.BooleanValue("DescribeRdsAccounts.Success");
			describeRdsAccountsResponse.RequestId = context.StringValue("DescribeRdsAccounts.RequestId");
			describeRdsAccountsResponse.ErrMsg = context.StringValue("DescribeRdsAccounts.ErrMsg");
			describeRdsAccountsResponse._Class = context.StringValue("DescribeRdsAccounts.Class");
			describeRdsAccountsResponse.TransmitAliyun = context.BooleanValue("DescribeRdsAccounts.TransmitAliyun");

			DescribeRdsAccountsResponse.DescribeRdsAccounts_Result result = new DescribeRdsAccountsResponse.DescribeRdsAccounts_Result();
			result._Class = context.StringValue("DescribeRdsAccounts.Result.Class");

			List<DescribeRdsAccountsResponse.DescribeRdsAccounts_Result.DescribeRdsAccounts_AccountsItem> result_accounts = new List<DescribeRdsAccountsResponse.DescribeRdsAccounts_Result.DescribeRdsAccounts_AccountsItem>();
			for (int i = 0; i < context.Length("DescribeRdsAccounts.Result.Accounts.Length"); i++) {
				DescribeRdsAccountsResponse.DescribeRdsAccounts_Result.DescribeRdsAccounts_AccountsItem accountsItem = new DescribeRdsAccountsResponse.DescribeRdsAccounts_Result.DescribeRdsAccounts_AccountsItem();
				accountsItem.AccountStatus = context.StringValue("DescribeRdsAccounts.Result.Accounts["+ i +"].AccountStatus");
				accountsItem.DatabasePrivileges = context.StringValue("DescribeRdsAccounts.Result.Accounts["+ i +"].DatabasePrivileges");
				accountsItem.AccountDescription = context.StringValue("DescribeRdsAccounts.Result.Accounts["+ i +"].AccountDescription");
				accountsItem.AccountName = context.StringValue("DescribeRdsAccounts.Result.Accounts["+ i +"].AccountName");
				accountsItem.AccountType = context.StringValue("DescribeRdsAccounts.Result.Accounts["+ i +"].AccountType");
				accountsItem.PrivExceeded = context.StringValue("DescribeRdsAccounts.Result.Accounts["+ i +"].PrivExceeded");
				accountsItem._Class = context.StringValue("DescribeRdsAccounts.Result.Accounts["+ i +"].Class");
				accountsItem.DBInstanceId = context.StringValue("DescribeRdsAccounts.Result.Accounts["+ i +"].DBInstanceId");

				result_accounts.Add(accountsItem);
			}
			result.Accounts = result_accounts;
			describeRdsAccountsResponse.Result = result;
        
			return describeRdsAccountsResponse;
        }
    }
}
