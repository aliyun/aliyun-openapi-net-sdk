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
        public static DescribeAccountDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAccountDetailResponse describeAccountDetailResponse = new DescribeAccountDetailResponse();

			describeAccountDetailResponse.HttpResponse = _ctx.HttpResponse;
			describeAccountDetailResponse.RequestId = _ctx.StringValue("DescribeAccountDetail.RequestId");

			DescribeAccountDetailResponse.DescribeAccountDetail_Account account = new DescribeAccountDetailResponse.DescribeAccountDetail_Account();
			account.Id = _ctx.LongValue("DescribeAccountDetail.Account.Id");
			account.UserId = _ctx.LongValue("DescribeAccountDetail.Account.UserId");
			account.FirstLevelDepartId = _ctx.LongValue("DescribeAccountDetail.Account.FirstLevelDepartId");
			account.LoginName = _ctx.StringValue("DescribeAccountDetail.Account.LoginName");
			account.FullName = _ctx.StringValue("DescribeAccountDetail.Account.FullName");
			account.CellphoneNum = _ctx.StringValue("DescribeAccountDetail.Account.CellphoneNum");
			account.TelephoneNum = _ctx.StringValue("DescribeAccountDetail.Account.TelephoneNum");
			account.Email = _ctx.StringValue("DescribeAccountDetail.Account.Email");
			account.ActiveStatus = _ctx.StringValue("DescribeAccountDetail.Account.ActiveStatus");
			account.DeleteStatus = _ctx.StringValue("DescribeAccountDetail.Account.DeleteStatus");
			account.DataInstance = _ctx.StringValue("DescribeAccountDetail.Account.DataInstance");
			account.CreateTime = _ctx.LongValue("DescribeAccountDetail.Account.CreateTime");
			account.LoginDataTime = _ctx.LongValue("DescribeAccountDetail.Account.LoginDataTime");
			account.LoginPolicyName = _ctx.StringValue("DescribeAccountDetail.Account.LoginPolicyName");
			account.FirstLevelDepartName = _ctx.StringValue("DescribeAccountDetail.Account.FirstLevelDepartName");
			account.RoleNames = _ctx.StringValue("DescribeAccountDetail.Account.RoleNames");
			account.AliUid = _ctx.LongValue("DescribeAccountDetail.Account.AliUid");

			DescribeAccountDetailResponse.DescribeAccountDetail_Account.DescribeAccountDetail_EventCount eventCount = new DescribeAccountDetailResponse.DescribeAccountDetail_Account.DescribeAccountDetail_EventCount();

			DescribeAccountDetailResponse.DescribeAccountDetail_Account.DescribeAccountDetail_EventCount.DescribeAccountDetail_Total total = new DescribeAccountDetailResponse.DescribeAccountDetail_Account.DescribeAccountDetail_EventCount.DescribeAccountDetail_Total();
			total.TotalCount = _ctx.LongValue("DescribeAccountDetail.Account.EventCount.Total.TotalCount");
			total.UndealCount = _ctx.LongValue("DescribeAccountDetail.Account.EventCount.Total.UndealCount");
			total.ConfirmCount = _ctx.LongValue("DescribeAccountDetail.Account.EventCount.Total.ConfirmCount");
			total.ExcludeCount = _ctx.LongValue("DescribeAccountDetail.Account.EventCount.Total.ExcludeCount");
			eventCount.Total = total;
			account.EventCount = eventCount;

			List<DescribeAccountDetailResponse.DescribeAccountDetail_Account.DescribeAccountDetail_Privilege> account_privilegeList = new List<DescribeAccountDetailResponse.DescribeAccountDetail_Account.DescribeAccountDetail_Privilege>();
			for (int i = 0; i < _ctx.Length("DescribeAccountDetail.Account.PrivilegeList.Length"); i++) {
				DescribeAccountDetailResponse.DescribeAccountDetail_Account.DescribeAccountDetail_Privilege privilege = new DescribeAccountDetailResponse.DescribeAccountDetail_Account.DescribeAccountDetail_Privilege();
				privilege.ProductName = _ctx.StringValue("DescribeAccountDetail.Account.PrivilegeList["+ i +"].ProductName");
				privilege.UseAccountId = _ctx.StringValue("DescribeAccountDetail.Account.PrivilegeList["+ i +"].UseAccountId");
				privilege.UseAccountType = _ctx.IntegerValue("DescribeAccountDetail.Account.PrivilegeList["+ i +"].UseAccountType");
				privilege.UseAccountTypeName = _ctx.StringValue("DescribeAccountDetail.Account.PrivilegeList["+ i +"].UseAccountTypeName");
				privilege.UseAccountCreateTime = _ctx.LongValue("DescribeAccountDetail.Account.PrivilegeList["+ i +"].UseAccountCreateTime");
				privilege.UseAccountName = _ctx.StringValue("DescribeAccountDetail.Account.PrivilegeList["+ i +"].UseAccountName");

				account_privilegeList.Add(privilege);
			}
			account.PrivilegeList = account_privilegeList;
			describeAccountDetailResponse.Account = account;
        
			return describeAccountDetailResponse;
        }
    }
}
