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
    public class ListAppsResponseUnmarshaller
    {
        public static ListAppsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAppsResponse listAppsResponse = new ListAppsResponse();

			listAppsResponse.HttpResponse = _ctx.HttpResponse;
			listAppsResponse.Code = _ctx.StringValue("ListApps.Code");
			listAppsResponse.Message = _ctx.StringValue("ListApps.Message");
			listAppsResponse.RequestId = _ctx.StringValue("ListApps.RequestId");

			ListAppsResponse.ListApps_Data data = new ListAppsResponse.ListApps_Data();
			data.TotalElements = _ctx.LongValue("ListApps.Data.TotalElements");
			data.TotalPages = _ctx.IntegerValue("ListApps.Data.TotalPages");

			List<ListAppsResponse.ListApps_Data.ListApps_ItemsItem> data_items = new List<ListAppsResponse.ListApps_Data.ListApps_ItemsItem>();
			for (int i = 0; i < _ctx.Length("ListApps.Data.Items.Length"); i++) {
				ListAppsResponse.ListApps_Data.ListApps_ItemsItem itemsItem = new ListAppsResponse.ListApps_Data.ListApps_ItemsItem();
				itemsItem.CreatedAt = _ctx.StringValue("ListApps.Data.Items["+ i +"].CreatedAt");
				itemsItem.DepartmentId = _ctx.StringValue("ListApps.Data.Items["+ i +"].DepartmentId");
				itemsItem.DepartmentName = _ctx.StringValue("ListApps.Data.Items["+ i +"].DepartmentName");
				itemsItem.Disabled = _ctx.BooleanValue("ListApps.Data.Items["+ i +"].Disabled");
				itemsItem.Id = _ctx.StringValue("ListApps.Data.Items["+ i +"].Id");
				itemsItem.Name = _ctx.StringValue("ListApps.Data.Items["+ i +"].Name");
				itemsItem.PackageName = _ctx.StringValue("ListApps.Data.Items["+ i +"].PackageName");

				data_items.Add(itemsItem);
			}
			data.Items = data_items;
			listAppsResponse.Data = data;
        
			return listAppsResponse;
        }
    }
}
