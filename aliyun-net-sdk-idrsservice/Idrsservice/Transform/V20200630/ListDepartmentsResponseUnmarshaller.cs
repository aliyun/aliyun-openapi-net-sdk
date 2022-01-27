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
    public class ListDepartmentsResponseUnmarshaller
    {
        public static ListDepartmentsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDepartmentsResponse listDepartmentsResponse = new ListDepartmentsResponse();

			listDepartmentsResponse.HttpResponse = _ctx.HttpResponse;
			listDepartmentsResponse.Code = _ctx.StringValue("ListDepartments.Code");
			listDepartmentsResponse.Message = _ctx.StringValue("ListDepartments.Message");
			listDepartmentsResponse.RequestId = _ctx.StringValue("ListDepartments.RequestId");

			ListDepartmentsResponse.ListDepartments_Data data = new ListDepartmentsResponse.ListDepartments_Data();
			data.TotalElements = _ctx.LongValue("ListDepartments.Data.TotalElements");
			data.TotalPages = _ctx.IntegerValue("ListDepartments.Data.TotalPages");

			List<ListDepartmentsResponse.ListDepartments_Data.ListDepartments_ItemsItem> data_items = new List<ListDepartmentsResponse.ListDepartments_Data.ListDepartments_ItemsItem>();
			for (int i = 0; i < _ctx.Length("ListDepartments.Data.Items.Length"); i++) {
				ListDepartmentsResponse.ListDepartments_Data.ListDepartments_ItemsItem itemsItem = new ListDepartmentsResponse.ListDepartments_Data.ListDepartments_ItemsItem();
				itemsItem.CreatedAt = _ctx.StringValue("ListDepartments.Data.Items["+ i +"].CreatedAt");
				itemsItem.Description = _ctx.StringValue("ListDepartments.Data.Items["+ i +"].Description");
				itemsItem.Id = _ctx.StringValue("ListDepartments.Data.Items["+ i +"].Id");
				itemsItem.Name = _ctx.StringValue("ListDepartments.Data.Items["+ i +"].Name");
				itemsItem.UpdatedAt = _ctx.StringValue("ListDepartments.Data.Items["+ i +"].UpdatedAt");

				List<ListDepartmentsResponse.ListDepartments_Data.ListDepartments_ItemsItem.ListDepartments_AdministratorsItem> itemsItem_administrators = new List<ListDepartmentsResponse.ListDepartments_Data.ListDepartments_ItemsItem.ListDepartments_AdministratorsItem>();
				for (int j = 0; j < _ctx.Length("ListDepartments.Data.Items["+ i +"].Administrators.Length"); j++) {
					ListDepartmentsResponse.ListDepartments_Data.ListDepartments_ItemsItem.ListDepartments_AdministratorsItem administratorsItem = new ListDepartmentsResponse.ListDepartments_Data.ListDepartments_ItemsItem.ListDepartments_AdministratorsItem();
					administratorsItem.Id = _ctx.StringValue("ListDepartments.Data.Items["+ i +"].Administrators["+ j +"].Id");
					administratorsItem.Name = _ctx.StringValue("ListDepartments.Data.Items["+ i +"].Administrators["+ j +"].Name");

					itemsItem_administrators.Add(administratorsItem);
				}
				itemsItem.Administrators = itemsItem_administrators;

				data_items.Add(itemsItem);
			}
			data.Items = data_items;
			listDepartmentsResponse.Data = data;
        
			return listDepartmentsResponse;
        }
    }
}
