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
    public class DescribeAccountDetailResponseUnmarshaller
    {
        public static DescribeAccountDetailResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAccountDetailResponse describeAccountDetailResponse = new DescribeAccountDetailResponse();

			describeAccountDetailResponse.HttpResponse = context.HttpResponse;
			describeAccountDetailResponse.RequestId = context.StringValue("DescribeAccountDetail.RequestId");

			DescribeAccountDetailResponse.DescribeAccountDetail_Account account = new DescribeAccountDetailResponse.DescribeAccountDetail_Account();
			account.Id = context.LongValue("DescribeAccountDetail.Account.Id");
			account.UserId = context.LongValue("DescribeAccountDetail.Account.UserId");
			account.FirstLevelDepartId = context.LongValue("DescribeAccountDetail.Account.FirstLevelDepartId");
			account.LoginName = context.StringValue("DescribeAccountDetail.Account.LoginName");
			account.FullName = context.StringValue("DescribeAccountDetail.Account.FullName");
			account.CellphoneNum = context.StringValue("DescribeAccountDetail.Account.CellphoneNum");
			account.TelephoneNum = context.StringValue("DescribeAccountDetail.Account.TelephoneNum");
			account.Email = context.StringValue("DescribeAccountDetail.Account.Email");
			account.ActiveStatus = context.StringValue("DescribeAccountDetail.Account.ActiveStatus");
			account.DeleteStatus = context.StringValue("DescribeAccountDetail.Account.DeleteStatus");
			account.DataInstance = context.StringValue("DescribeAccountDetail.Account.DataInstance");
			account.CreateTime = context.LongValue("DescribeAccountDetail.Account.CreateTime");
			account.LoginDataTime = context.LongValue("DescribeAccountDetail.Account.LoginDataTime");
			account.LoginPolicyName = context.StringValue("DescribeAccountDetail.Account.LoginPolicyName");
			account.FirstLevelDepartName = context.StringValue("DescribeAccountDetail.Account.FirstLevelDepartName");
			account.RoleNames = context.StringValue("DescribeAccountDetail.Account.RoleNames");
			account.AliUid = context.LongValue("DescribeAccountDetail.Account.AliUid");

			DescribeAccountDetailResponse.DescribeAccountDetail_Account.DescribeAccountDetail_EventCount eventCount = new DescribeAccountDetailResponse.DescribeAccountDetail_Account.DescribeAccountDetail_EventCount();

			DescribeAccountDetailResponse.DescribeAccountDetail_Account.DescribeAccountDetail_EventCount.DescribeAccountDetail_Total total = new DescribeAccountDetailResponse.DescribeAccountDetail_Account.DescribeAccountDetail_EventCount.DescribeAccountDetail_Total();
			total.TotalCount = context.LongValue("DescribeAccountDetail.Account.EventCount.Total.TotalCount");
			total.UndealCount = context.LongValue("DescribeAccountDetail.Account.EventCount.Total.UndealCount");
			total.ConfirmCount = context.LongValue("DescribeAccountDetail.Account.EventCount.Total.ConfirmCount");
			total.ExcludeCount = context.LongValue("DescribeAccountDetail.Account.EventCount.Total.ExcludeCount");
			eventCount.Total = total;
			account.EventCount = eventCount;

			List<DescribeAccountDetailResponse.DescribeAccountDetail_Account.DescribeAccountDetail_Privilege> account_privilegeList = new List<DescribeAccountDetailResponse.DescribeAccountDetail_Account.DescribeAccountDetail_Privilege>();
			for (int i = 0; i < context.Length("DescribeAccountDetail.Account.PrivilegeList.Length"); i++) {
				DescribeAccountDetailResponse.DescribeAccountDetail_Account.DescribeAccountDetail_Privilege privilege = new DescribeAccountDetailResponse.DescribeAccountDetail_Account.DescribeAccountDetail_Privilege();
				privilege.ProductName = context.StringValue("DescribeAccountDetail.Account.PrivilegeList["+ i +"].ProductName");
				privilege.UseAccountId = context.StringValue("DescribeAccountDetail.Account.PrivilegeList["+ i +"].UseAccountId");
				privilege.UseAccountType = context.IntegerValue("DescribeAccountDetail.Account.PrivilegeList["+ i +"].UseAccountType");
				privilege.UseAccountTypeName = context.StringValue("DescribeAccountDetail.Account.PrivilegeList["+ i +"].UseAccountTypeName");
				privilege.UseAccountCreateTime = context.LongValue("DescribeAccountDetail.Account.PrivilegeList["+ i +"].UseAccountCreateTime");
				privilege.UseAccountName = context.StringValue("DescribeAccountDetail.Account.PrivilegeList["+ i +"].UseAccountName");

				account_privilegeList.Add(privilege);
			}
			account.PrivilegeList = account_privilegeList;
			describeAccountDetailResponse.Account = account;
        
			return describeAccountDetailResponse;
        }
    }
}
