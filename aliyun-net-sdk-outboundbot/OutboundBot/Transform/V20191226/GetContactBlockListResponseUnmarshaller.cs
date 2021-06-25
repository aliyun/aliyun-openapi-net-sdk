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
    public class GetContactBlockListResponseUnmarshaller
    {
        public static GetContactBlockListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetContactBlockListResponse getContactBlockListResponse = new GetContactBlockListResponse();

			getContactBlockListResponse.HttpResponse = _ctx.HttpResponse;
			getContactBlockListResponse.RequestId = _ctx.StringValue("GetContactBlockList.RequestId");
			getContactBlockListResponse.Success = _ctx.BooleanValue("GetContactBlockList.Success");
			getContactBlockListResponse.Code = _ctx.StringValue("GetContactBlockList.Code");
			getContactBlockListResponse.Message = _ctx.StringValue("GetContactBlockList.Message");
			getContactBlockListResponse.HttpStatusCode = _ctx.IntegerValue("GetContactBlockList.HttpStatusCode");

			GetContactBlockListResponse.GetContactBlockList_ContactBlocklistList contactBlocklistList = new GetContactBlockListResponse.GetContactBlockList_ContactBlocklistList();
			contactBlocklistList.PageNumber = _ctx.IntegerValue("GetContactBlockList.ContactBlocklistList.PageNumber");
			contactBlocklistList.PageSize = _ctx.IntegerValue("GetContactBlockList.ContactBlocklistList.PageSize");
			contactBlocklistList.TotalCount = _ctx.IntegerValue("GetContactBlockList.ContactBlocklistList.TotalCount");

			List<GetContactBlockListResponse.GetContactBlockList_ContactBlocklistList.GetContactBlockList_ContactBlockList> contactBlocklistList_list = new List<GetContactBlockListResponse.GetContactBlockList_ContactBlocklistList.GetContactBlockList_ContactBlockList>();
			for (int i = 0; i < _ctx.Length("GetContactBlockList.ContactBlocklistList.List.Length"); i++) {
				GetContactBlockListResponse.GetContactBlockList_ContactBlocklistList.GetContactBlockList_ContactBlockList contactBlockList = new GetContactBlockListResponse.GetContactBlockList_ContactBlocklistList.GetContactBlockList_ContactBlockList();
				contactBlockList.ContactBlockListId = _ctx.StringValue("GetContactBlockList.ContactBlocklistList.List["+ i +"].ContactBlockListId");
				contactBlockList.InstanceId = _ctx.StringValue("GetContactBlockList.ContactBlocklistList.List["+ i +"].InstanceId");
				contactBlockList.CreationTime = _ctx.LongValue("GetContactBlockList.ContactBlocklistList.List["+ i +"].CreationTime");
				contactBlockList.PhoneNumber = _ctx.StringValue("GetContactBlockList.ContactBlocklistList.List["+ i +"].PhoneNumber");
				contactBlockList.Name = _ctx.StringValue("GetContactBlockList.ContactBlocklistList.List["+ i +"].Name");
				contactBlockList.Creator = _ctx.StringValue("GetContactBlockList.ContactBlocklistList.List["+ i +"].Creator");
				contactBlockList._Operator = _ctx.StringValue("GetContactBlockList.ContactBlocklistList.List["+ i +"].Operator");
				contactBlockList.Remark = _ctx.StringValue("GetContactBlockList.ContactBlocklistList.List["+ i +"].Remark");

				contactBlocklistList_list.Add(contactBlockList);
			}
			contactBlocklistList.List = contactBlocklistList_list;
			getContactBlockListResponse.ContactBlocklistList = contactBlocklistList;
        
			return getContactBlockListResponse;
        }
    }
}
