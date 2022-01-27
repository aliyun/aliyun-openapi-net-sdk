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
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class ListSubAccountResponseUnmarshaller
    {
        public static ListSubAccountResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSubAccountResponse listSubAccountResponse = new ListSubAccountResponse();

			listSubAccountResponse.HttpResponse = _ctx.HttpResponse;
			listSubAccountResponse.Code = _ctx.IntegerValue("ListSubAccount.Code");
			listSubAccountResponse.Message = _ctx.StringValue("ListSubAccount.Message");
			listSubAccountResponse.RequestId = _ctx.StringValue("ListSubAccount.RequestId");

			List<ListSubAccountResponse.ListSubAccount_SubAccount> listSubAccountResponse_subAccountList = new List<ListSubAccountResponse.ListSubAccount_SubAccount>();
			for (int i = 0; i < _ctx.Length("ListSubAccount.SubAccountList.Length"); i++) {
				ListSubAccountResponse.ListSubAccount_SubAccount subAccount = new ListSubAccountResponse.ListSubAccount_SubAccount();
				subAccount.AdminUserId = _ctx.StringValue("ListSubAccount.SubAccountList["+ i +"].AdminUserId");
				subAccount.SubUserId = _ctx.StringValue("ListSubAccount.SubAccountList["+ i +"].SubUserId");
				subAccount.Email = _ctx.StringValue("ListSubAccount.SubAccountList["+ i +"].Email");
				subAccount.Phone = _ctx.StringValue("ListSubAccount.SubAccountList["+ i +"].Phone");
				subAccount.AdminUserKp = _ctx.StringValue("ListSubAccount.SubAccountList["+ i +"].AdminUserKp");
				subAccount.SubUserKp = _ctx.StringValue("ListSubAccount.SubAccountList["+ i +"].SubUserKp");
				subAccount.AdminEdasId = _ctx.StringValue("ListSubAccount.SubAccountList["+ i +"].AdminEdasId");
				subAccount.SubEdasId = _ctx.StringValue("ListSubAccount.SubAccountList["+ i +"].SubEdasId");

				listSubAccountResponse_subAccountList.Add(subAccount);
			}
			listSubAccountResponse.SubAccountList = listSubAccountResponse_subAccountList;
        
			return listSubAccountResponse;
        }
    }
}
