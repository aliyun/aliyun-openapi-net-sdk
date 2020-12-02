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
using Aliyun.Acs.idrsservice.Model.V20200630;

namespace Aliyun.Acs.idrsservice.Transform.V20200630
{
    public class ListUsersResponseUnmarshaller
    {
        public static ListUsersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListUsersResponse listUsersResponse = new ListUsersResponse();

			listUsersResponse.HttpResponse = _ctx.HttpResponse;
			listUsersResponse.Code = _ctx.StringValue("ListUsers.Code");
			listUsersResponse.Message = _ctx.StringValue("ListUsers.Message");
			listUsersResponse.RequestId = _ctx.StringValue("ListUsers.RequestId");

			ListUsersResponse.ListUsers_Data data = new ListUsersResponse.ListUsers_Data();
			data.TotalElements = _ctx.LongValue("ListUsers.Data.TotalElements");
			data.TotalPages = _ctx.IntegerValue("ListUsers.Data.TotalPages");

			List<ListUsersResponse.ListUsers_Data.ListUsers_ItemsItem> data_items = new List<ListUsersResponse.ListUsers_Data.ListUsers_ItemsItem>();
			for (int i = 0; i < _ctx.Length("ListUsers.Data.Items.Length"); i++) {
				ListUsersResponse.ListUsers_Data.ListUsers_ItemsItem itemsItem = new ListUsersResponse.ListUsers_Data.ListUsers_ItemsItem();
				itemsItem.CreatedAt = _ctx.StringValue("ListUsers.Data.Items["+ i +"].CreatedAt");
				itemsItem.Email = _ctx.StringValue("ListUsers.Data.Items["+ i +"].Email");
				itemsItem.Id = _ctx.StringValue("ListUsers.Data.Items["+ i +"].Id");
				itemsItem.Name = _ctx.StringValue("ListUsers.Data.Items["+ i +"].Name");
				itemsItem.PhoneNumber = _ctx.StringValue("ListUsers.Data.Items["+ i +"].PhoneNumber");
				itemsItem.RamUsername = _ctx.StringValue("ListUsers.Data.Items["+ i +"].RamUsername");
				itemsItem.Role = _ctx.StringValue("ListUsers.Data.Items["+ i +"].Role");
				itemsItem.Source = _ctx.StringValue("ListUsers.Data.Items["+ i +"].Source");
				itemsItem.UpdatedAt = _ctx.StringValue("ListUsers.Data.Items["+ i +"].UpdatedAt");
				itemsItem.Username = _ctx.StringValue("ListUsers.Data.Items["+ i +"].Username");

				List<ListUsersResponse.ListUsers_Data.ListUsers_ItemsItem.ListUsers_DepartmentsItem> itemsItem_departments = new List<ListUsersResponse.ListUsers_Data.ListUsers_ItemsItem.ListUsers_DepartmentsItem>();
				for (int j = 0; j < _ctx.Length("ListUsers.Data.Items["+ i +"].Departments.Length"); j++) {
					ListUsersResponse.ListUsers_Data.ListUsers_ItemsItem.ListUsers_DepartmentsItem departmentsItem = new ListUsersResponse.ListUsers_Data.ListUsers_ItemsItem.ListUsers_DepartmentsItem();
					departmentsItem.CreatedAt = _ctx.StringValue("ListUsers.Data.Items["+ i +"].Departments["+ j +"].CreatedAt");
					departmentsItem.Description = _ctx.StringValue("ListUsers.Data.Items["+ i +"].Departments["+ j +"].Description");
					departmentsItem.Id = _ctx.StringValue("ListUsers.Data.Items["+ i +"].Departments["+ j +"].Id");
					departmentsItem.Name = _ctx.StringValue("ListUsers.Data.Items["+ i +"].Departments["+ j +"].Name");
					departmentsItem.UpdatedAt = _ctx.StringValue("ListUsers.Data.Items["+ i +"].Departments["+ j +"].UpdatedAt");

					itemsItem_departments.Add(departmentsItem);
				}
				itemsItem.Departments = itemsItem_departments;

				data_items.Add(itemsItem);
			}
			data.Items = data_items;
			listUsersResponse.Data = data;
        
			return listUsersResponse;
        }
    }
}
