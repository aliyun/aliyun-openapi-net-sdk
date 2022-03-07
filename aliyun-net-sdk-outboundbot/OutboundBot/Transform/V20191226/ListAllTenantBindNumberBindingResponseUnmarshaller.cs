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
    public class ListAllTenantBindNumberBindingResponseUnmarshaller
    {
        public static ListAllTenantBindNumberBindingResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAllTenantBindNumberBindingResponse listAllTenantBindNumberBindingResponse = new ListAllTenantBindNumberBindingResponse();

			listAllTenantBindNumberBindingResponse.HttpResponse = _ctx.HttpResponse;
			listAllTenantBindNumberBindingResponse.Success = _ctx.BooleanValue("ListAllTenantBindNumberBinding.Success");
			listAllTenantBindNumberBindingResponse.Code = _ctx.StringValue("ListAllTenantBindNumberBinding.Code");
			listAllTenantBindNumberBindingResponse.Message = _ctx.StringValue("ListAllTenantBindNumberBinding.Message");
			listAllTenantBindNumberBindingResponse.HttpStatusCode = _ctx.IntegerValue("ListAllTenantBindNumberBinding.HttpStatusCode");
			listAllTenantBindNumberBindingResponse.RequestId = _ctx.StringValue("ListAllTenantBindNumberBinding.RequestId");

			ListAllTenantBindNumberBindingResponse.ListAllTenantBindNumberBinding_Data data = new ListAllTenantBindNumberBindingResponse.ListAllTenantBindNumberBinding_Data();

			List<ListAllTenantBindNumberBindingResponse.ListAllTenantBindNumberBinding_Data.ListAllTenantBindNumberBinding_ListItem> data_list = new List<ListAllTenantBindNumberBindingResponse.ListAllTenantBindNumberBinding_Data.ListAllTenantBindNumberBinding_ListItem>();
			for (int i = 0; i < _ctx.Length("ListAllTenantBindNumberBinding.Data.List.Length"); i++) {
				ListAllTenantBindNumberBindingResponse.ListAllTenantBindNumberBinding_Data.ListAllTenantBindNumberBinding_ListItem listItem = new ListAllTenantBindNumberBindingResponse.ListAllTenantBindNumberBinding_Data.ListAllTenantBindNumberBinding_ListItem();
				listItem.BindingId = _ctx.StringValue("ListAllTenantBindNumberBinding.Data.List["+ i +"].BindingId");
				listItem.Number = _ctx.StringValue("ListAllTenantBindNumberBinding.Data.List["+ i +"].Number");
				listItem.TrunkName = _ctx.StringValue("ListAllTenantBindNumberBinding.Data.List["+ i +"].TrunkName");
				listItem.SerializedParams = _ctx.StringValue("ListAllTenantBindNumberBinding.Data.List["+ i +"].SerializedParams");

				List<string> listItem_instanceNameList = new List<string>();
				for (int j = 0; j < _ctx.Length("ListAllTenantBindNumberBinding.Data.List["+ i +"].InstanceNameList.Length"); j++) {
					listItem_instanceNameList.Add(_ctx.StringValue("ListAllTenantBindNumberBinding.Data.List["+ i +"].InstanceNameList["+ j +"]"));
				}
				listItem.InstanceNameList = listItem_instanceNameList;

				data_list.Add(listItem);
			}
			data.List = data_list;
			listAllTenantBindNumberBindingResponse.Data = data;
        
			return listAllTenantBindNumberBindingResponse;
        }
    }
}
