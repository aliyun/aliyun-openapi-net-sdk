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
        public static DescribeAccountsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAccountsResponse describeAccountsResponse = new DescribeAccountsResponse();

			describeAccountsResponse.HttpResponse = _ctx.HttpResponse;
			describeAccountsResponse.RequestId = _ctx.StringValue("DescribeAccounts.RequestId");
			describeAccountsResponse.PageSize = _ctx.IntegerValue("DescribeAccounts.PageSize");
			describeAccountsResponse.CurrentPage = _ctx.IntegerValue("DescribeAccounts.CurrentPage");
			describeAccountsResponse.TotalCount = _ctx.IntegerValue("DescribeAccounts.TotalCount");

			List<DescribeAccountsResponse.DescribeAccounts_Account> describeAccountsResponse_items = new List<DescribeAccountsResponse.DescribeAccounts_Account>();
			for (int i = 0; i < _ctx.Length("DescribeAccounts.Items.Length"); i++) {
				DescribeAccountsResponse.DescribeAccounts_Account account = new DescribeAccountsResponse.DescribeAccounts_Account();
				account.Id = _ctx.LongValue("DescribeAccounts.Items["+ i +"].Id");
				account.UserId = _ctx.LongValue("DescribeAccounts.Items["+ i +"].UserId");
				account.FirstLevelDepartId = _ctx.LongValue("DescribeAccounts.Items["+ i +"].FirstLevelDepartId");
				account.LoginName = _ctx.StringValue("DescribeAccounts.Items["+ i +"].LoginName");
				account.FullName = _ctx.StringValue("DescribeAccounts.Items["+ i +"].FullName");
				account.CellphoneNum = _ctx.StringValue("DescribeAccounts.Items["+ i +"].CellphoneNum");
				account.TelephoneNum = _ctx.StringValue("DescribeAccounts.Items["+ i +"].TelephoneNum");
				account.Email = _ctx.StringValue("DescribeAccounts.Items["+ i +"].Email");
				account.ActiveStatus = _ctx.StringValue("DescribeAccounts.Items["+ i +"].ActiveStatus");
				account.DeleteStatus = _ctx.StringValue("DescribeAccounts.Items["+ i +"].DeleteStatus");
				account.DataInstance = _ctx.StringValue("DescribeAccounts.Items["+ i +"].DataInstance");
				account.CreateTime = _ctx.LongValue("DescribeAccounts.Items["+ i +"].CreateTime");
				account.LoginDataTime = _ctx.LongValue("DescribeAccounts.Items["+ i +"].LoginDataTime");
				account.LoginPolicyName = _ctx.StringValue("DescribeAccounts.Items["+ i +"].LoginPolicyName");
				account.FirstLevelDepartName = _ctx.StringValue("DescribeAccounts.Items["+ i +"].FirstLevelDepartName");
				account.RoleNames = _ctx.StringValue("DescribeAccounts.Items["+ i +"].RoleNames");
				account.InstanceName = _ctx.StringValue("DescribeAccounts.Items["+ i +"].InstanceName");
				account.AliUid = _ctx.LongValue("DescribeAccounts.Items["+ i +"].AliUid");
				account.AccountTypeId = _ctx.LongValue("DescribeAccounts.Items["+ i +"].AccountTypeId");

				DescribeAccountsResponse.DescribeAccounts_Account.DescribeAccounts_EventCount eventCount = new DescribeAccountsResponse.DescribeAccounts_Account.DescribeAccounts_EventCount();

				DescribeAccountsResponse.DescribeAccounts_Account.DescribeAccounts_EventCount.DescribeAccounts_Total total = new DescribeAccountsResponse.DescribeAccounts_Account.DescribeAccounts_EventCount.DescribeAccounts_Total();
				total.TotalCount = _ctx.LongValue("DescribeAccounts.Items["+ i +"].EventCount.Total.TotalCount");
				total.UndealCount = _ctx.LongValue("DescribeAccounts.Items["+ i +"].EventCount.Total.UndealCount");
				total.ConfirmCount = _ctx.LongValue("DescribeAccounts.Items["+ i +"].EventCount.Total.ConfirmCount");
				total.ExcludeCount = _ctx.LongValue("DescribeAccounts.Items["+ i +"].EventCount.Total.ExcludeCount");
				eventCount.Total = total;
				account.EventCount = eventCount;

				describeAccountsResponse_items.Add(account);
			}
			describeAccountsResponse.Items = describeAccountsResponse_items;
        
			return describeAccountsResponse;
        }
    }
}
