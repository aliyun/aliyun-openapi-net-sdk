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
    public class ListTaskGroupsResponseUnmarshaller
    {
        public static ListTaskGroupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTaskGroupsResponse listTaskGroupsResponse = new ListTaskGroupsResponse();

			listTaskGroupsResponse.HttpResponse = _ctx.HttpResponse;
			listTaskGroupsResponse.Code = _ctx.StringValue("ListTaskGroups.Code");
			listTaskGroupsResponse.Message = _ctx.StringValue("ListTaskGroups.Message");
			listTaskGroupsResponse.RequestId = _ctx.StringValue("ListTaskGroups.RequestId");

			ListTaskGroupsResponse.ListTaskGroups_Data data = new ListTaskGroupsResponse.ListTaskGroups_Data();
			data.TotalElements = _ctx.LongValue("ListTaskGroups.Data.TotalElements");
			data.TotalPages = _ctx.IntegerValue("ListTaskGroups.Data.TotalPages");

			List<ListTaskGroupsResponse.ListTaskGroups_Data.ListTaskGroups_ItemsItem> data_items = new List<ListTaskGroupsResponse.ListTaskGroups_Data.ListTaskGroups_ItemsItem>();
			for (int i = 0; i < _ctx.Length("ListTaskGroups.Data.Items.Length"); i++) {
				ListTaskGroupsResponse.ListTaskGroups_Data.ListTaskGroups_ItemsItem itemsItem = new ListTaskGroupsResponse.ListTaskGroups_Data.ListTaskGroups_ItemsItem();
				itemsItem.CompletedTasks = _ctx.IntegerValue("ListTaskGroups.Data.Items["+ i +"].CompletedTasks");
				itemsItem.CreatedAt = _ctx.StringValue("ListTaskGroups.Data.Items["+ i +"].CreatedAt");
				itemsItem.Id = _ctx.StringValue("ListTaskGroups.Data.Items["+ i +"].Id");
				itemsItem.Name = _ctx.StringValue("ListTaskGroups.Data.Items["+ i +"].Name");
				itemsItem.RuleId = _ctx.StringValue("ListTaskGroups.Data.Items["+ i +"].RuleId");
				itemsItem.RuleName = _ctx.StringValue("ListTaskGroups.Data.Items["+ i +"].RuleName");
				itemsItem.Status = _ctx.StringValue("ListTaskGroups.Data.Items["+ i +"].Status");
				itemsItem.TotalTasks = _ctx.IntegerValue("ListTaskGroups.Data.Items["+ i +"].TotalTasks");

				List<string> itemsItem_taskIds = new List<string>();
				for (int j = 0; j < _ctx.Length("ListTaskGroups.Data.Items["+ i +"].TaskIds.Length"); j++) {
					itemsItem_taskIds.Add(_ctx.StringValue("ListTaskGroups.Data.Items["+ i +"].TaskIds["+ j +"]"));
				}
				itemsItem.TaskIds = itemsItem_taskIds;

				data_items.Add(itemsItem);
			}
			data.Items = data_items;
			listTaskGroupsResponse.Data = data;
        
			return listTaskGroupsResponse;
        }
    }
}
