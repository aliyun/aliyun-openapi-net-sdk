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
    public class DescribeAccountsResponseUnmarshaller
    {
        public static DescribeAccountsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAccountsResponse describeAccountsResponse = new DescribeAccountsResponse();

			describeAccountsResponse.HttpResponse = context.HttpResponse;
			describeAccountsResponse.RequestId = context.StringValue("DescribeAccounts.RequestId");
			describeAccountsResponse.PageSize = context.IntegerValue("DescribeAccounts.PageSize");
			describeAccountsResponse.CurrentPage = context.IntegerValue("DescribeAccounts.CurrentPage");
			describeAccountsResponse.TotalCount = context.IntegerValue("DescribeAccounts.TotalCount");

			List<DescribeAccountsResponse.DescribeAccounts_Account> describeAccountsResponse_items = new List<DescribeAccountsResponse.DescribeAccounts_Account>();
			for (int i = 0; i < context.Length("DescribeAccounts.Items.Length"); i++) {
				DescribeAccountsResponse.DescribeAccounts_Account account = new DescribeAccountsResponse.DescribeAccounts_Account();
				account.Id = context.LongValue("DescribeAccounts.Items["+ i +"].Id");
				account.UserId = context.LongValue("DescribeAccounts.Items["+ i +"].UserId");
				account.FirstLevelDepartId = context.LongValue("DescribeAccounts.Items["+ i +"].FirstLevelDepartId");
				account.LoginName = context.StringValue("DescribeAccounts.Items["+ i +"].LoginName");
				account.FullName = context.StringValue("DescribeAccounts.Items["+ i +"].FullName");
				account.CellphoneNum = context.StringValue("DescribeAccounts.Items["+ i +"].CellphoneNum");
				account.TelephoneNum = context.StringValue("DescribeAccounts.Items["+ i +"].TelephoneNum");
				account.Email = context.StringValue("DescribeAccounts.Items["+ i +"].Email");
				account.ActiveStatus = context.StringValue("DescribeAccounts.Items["+ i +"].ActiveStatus");
				account.DeleteStatus = context.StringValue("DescribeAccounts.Items["+ i +"].DeleteStatus");
				account.DataInstance = context.StringValue("DescribeAccounts.Items["+ i +"].DataInstance");
				account.CreateTime = context.LongValue("DescribeAccounts.Items["+ i +"].CreateTime");
				account.LoginDataTime = context.LongValue("DescribeAccounts.Items["+ i +"].LoginDataTime");
				account.LoginPolicyName = context.StringValue("DescribeAccounts.Items["+ i +"].LoginPolicyName");
				account.FirstLevelDepartName = context.StringValue("DescribeAccounts.Items["+ i +"].FirstLevelDepartName");
				account.RoleNames = context.StringValue("DescribeAccounts.Items["+ i +"].RoleNames");
				account.InstanceName = context.StringValue("DescribeAccounts.Items["+ i +"].InstanceName");
				account.AliUid = context.LongValue("DescribeAccounts.Items["+ i +"].AliUid");
				account.AccountTypeId = context.LongValue("DescribeAccounts.Items["+ i +"].AccountTypeId");

				DescribeAccountsResponse.DescribeAccounts_Account.DescribeAccounts_EventCount eventCount = new DescribeAccountsResponse.DescribeAccounts_Account.DescribeAccounts_EventCount();

				DescribeAccountsResponse.DescribeAccounts_Account.DescribeAccounts_EventCount.DescribeAccounts_Total total = new DescribeAccountsResponse.DescribeAccounts_Account.DescribeAccounts_EventCount.DescribeAccounts_Total();
				total.TotalCount = context.LongValue("DescribeAccounts.Items["+ i +"].EventCount.Total.TotalCount");
				total.UndealCount = context.LongValue("DescribeAccounts.Items["+ i +"].EventCount.Total.UndealCount");
				total.ConfirmCount = context.LongValue("DescribeAccounts.Items["+ i +"].EventCount.Total.ConfirmCount");
				total.ExcludeCount = context.LongValue("DescribeAccounts.Items["+ i +"].EventCount.Total.ExcludeCount");
				eventCount.Total = total;
				account.EventCount = eventCount;

				describeAccountsResponse_items.Add(account);
			}
			describeAccountsResponse.Items = describeAccountsResponse_items;
        
			return describeAccountsResponse;
        }
    }
}
