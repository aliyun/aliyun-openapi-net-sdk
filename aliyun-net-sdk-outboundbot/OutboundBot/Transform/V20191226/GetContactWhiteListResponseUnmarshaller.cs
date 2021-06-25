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
using Aliyun.Acs.OutboundBot.Model.V20191226;

namespace Aliyun.Acs.OutboundBot.Transform.V20191226
{
    public class GetContactWhiteListResponseUnmarshaller
    {
        public static GetContactWhiteListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetContactWhiteListResponse getContactWhiteListResponse = new GetContactWhiteListResponse();

			getContactWhiteListResponse.HttpResponse = _ctx.HttpResponse;
			getContactWhiteListResponse.RequestId = _ctx.StringValue("GetContactWhiteList.RequestId");
			getContactWhiteListResponse.Success = _ctx.BooleanValue("GetContactWhiteList.Success");
			getContactWhiteListResponse.Code = _ctx.StringValue("GetContactWhiteList.Code");
			getContactWhiteListResponse.Message = _ctx.StringValue("GetContactWhiteList.Message");
			getContactWhiteListResponse.HttpStatusCode = _ctx.IntegerValue("GetContactWhiteList.HttpStatusCode");

			GetContactWhiteListResponse.GetContactWhiteList_ContactWhitelistList contactWhitelistList = new GetContactWhiteListResponse.GetContactWhiteList_ContactWhitelistList();
			contactWhitelistList.PageSize = _ctx.IntegerValue("GetContactWhiteList.ContactWhitelistList.PageSize");
			contactWhitelistList.PageNumber = _ctx.IntegerValue("GetContactWhiteList.ContactWhitelistList.PageNumber");
			contactWhitelistList.TotalCount = _ctx.IntegerValue("GetContactWhiteList.ContactWhitelistList.TotalCount");

			List<GetContactWhiteListResponse.GetContactWhiteList_ContactWhitelistList.GetContactWhiteList_ContactWhitelistList1> contactWhitelistList_list = new List<GetContactWhiteListResponse.GetContactWhiteList_ContactWhitelistList.GetContactWhiteList_ContactWhitelistList1>();
			for (int i = 0; i < _ctx.Length("GetContactWhiteList.ContactWhitelistList.List.Length"); i++) {
				GetContactWhiteListResponse.GetContactWhiteList_ContactWhitelistList.GetContactWhiteList_ContactWhitelistList1 contactWhitelistList1 = new GetContactWhiteListResponse.GetContactWhiteList_ContactWhitelistList.GetContactWhiteList_ContactWhitelistList1();
				contactWhitelistList1.ContactWhiteListId = _ctx.StringValue("GetContactWhiteList.ContactWhitelistList.List["+ i +"].ContactWhiteListId");
				contactWhitelistList1.InstanceId = _ctx.StringValue("GetContactWhiteList.ContactWhitelistList.List["+ i +"].InstanceId");
				contactWhitelistList1.CreationTime = _ctx.LongValue("GetContactWhiteList.ContactWhitelistList.List["+ i +"].CreationTime");
				contactWhitelistList1.PhoneNumber = _ctx.StringValue("GetContactWhiteList.ContactWhitelistList.List["+ i +"].PhoneNumber");
				contactWhitelistList1.Name = _ctx.StringValue("GetContactWhiteList.ContactWhitelistList.List["+ i +"].Name");
				contactWhitelistList1.Creator = _ctx.StringValue("GetContactWhiteList.ContactWhitelistList.List["+ i +"].Creator");
				contactWhitelistList1._Operator = _ctx.StringValue("GetContactWhiteList.ContactWhitelistList.List["+ i +"].Operator");
				contactWhitelistList1.Remark = _ctx.StringValue("GetContactWhiteList.ContactWhitelistList.List["+ i +"].Remark");

				contactWhitelistList_list.Add(contactWhitelistList1);
			}
			contactWhitelistList.List = contactWhitelistList_list;
			getContactWhiteListResponse.ContactWhitelistList = contactWhitelistList;
        
			return getContactWhiteListResponse;
        }
    }
}
