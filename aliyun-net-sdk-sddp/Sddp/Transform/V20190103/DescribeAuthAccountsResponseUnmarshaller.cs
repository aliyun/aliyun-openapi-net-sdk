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
using Aliyun.Acs.Sddp.Model.V20190103;

namespace Aliyun.Acs.Sddp.Transform.V20190103
{
    public class DescribeAuthAccountsResponseUnmarshaller
    {
        public static DescribeAuthAccountsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAuthAccountsResponse describeAuthAccountsResponse = new DescribeAuthAccountsResponse();

			describeAuthAccountsResponse.HttpResponse = context.HttpResponse;
			describeAuthAccountsResponse.RequestId = context.StringValue("DescribeAuthAccounts.RequestId");
			describeAuthAccountsResponse.PageSize = context.IntegerValue("DescribeAuthAccounts.PageSize");
			describeAuthAccountsResponse.CurrentPage = context.IntegerValue("DescribeAuthAccounts.CurrentPage");
			describeAuthAccountsResponse.TotalCount = context.IntegerValue("DescribeAuthAccounts.TotalCount");

			List<DescribeAuthAccountsResponse.DescribeAuthAccounts_Account> describeAuthAccountsResponse_items = new List<DescribeAuthAccountsResponse.DescribeAuthAccounts_Account>();
			for (int i = 0; i < context.Length("DescribeAuthAccounts.Items.Length"); i++) {
				DescribeAuthAccountsResponse.DescribeAuthAccounts_Account account = new DescribeAuthAccountsResponse.DescribeAuthAccounts_Account();
				account.Id = context.LongValue("DescribeAuthAccounts.Items["+ i +"].Id");
				account.LoginName = context.StringValue("DescribeAuthAccounts.Items["+ i +"].LoginName");
				account.FullName = context.StringValue("DescribeAuthAccounts.Items["+ i +"].FullName");
				account.AuthLoginName = context.StringValue("DescribeAuthAccounts.Items["+ i +"].AuthLoginName");
				account.AuthFullName = context.StringValue("DescribeAuthAccounts.Items["+ i +"].AuthFullName");
				account.AuthTime = context.LongValue("DescribeAuthAccounts.Items["+ i +"].AuthTime");

				describeAuthAccountsResponse_items.Add(account);
			}
			describeAuthAccountsResponse.Items = describeAuthAccountsResponse_items;
        
			return describeAuthAccountsResponse;
        }
    }
}
