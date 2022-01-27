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
    public class ListDetectionsResponseUnmarshaller
    {
        public static ListDetectionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDetectionsResponse listDetectionsResponse = new ListDetectionsResponse();

			listDetectionsResponse.HttpResponse = _ctx.HttpResponse;
			listDetectionsResponse.Code = _ctx.StringValue("ListDetections.Code");
			listDetectionsResponse.Message = _ctx.StringValue("ListDetections.Message");
			listDetectionsResponse.RequestId = _ctx.StringValue("ListDetections.RequestId");

			ListDetectionsResponse.ListDetections_Data data = new ListDetectionsResponse.ListDetections_Data();
			data.TotalElements = _ctx.LongValue("ListDetections.Data.TotalElements");
			data.TotalPages = _ctx.IntegerValue("ListDetections.Data.TotalPages");

			List<ListDetectionsResponse.ListDetections_Data.ListDetections_ItemsItem> data_items = new List<ListDetectionsResponse.ListDetections_Data.ListDetections_ItemsItem>();
			for (int i = 0; i < _ctx.Length("ListDetections.Data.Items.Length"); i++) {
				ListDetectionsResponse.ListDetections_Data.ListDetections_ItemsItem itemsItem = new ListDetectionsResponse.ListDetections_Data.ListDetections_ItemsItem();
				itemsItem.CreatedAt = _ctx.StringValue("ListDetections.Data.Items["+ i +"].CreatedAt");
				itemsItem.DepartmentId = _ctx.StringValue("ListDetections.Data.Items["+ i +"].DepartmentId");
				itemsItem.DepartmentName = _ctx.StringValue("ListDetections.Data.Items["+ i +"].DepartmentName");
				itemsItem.Id = _ctx.StringValue("ListDetections.Data.Items["+ i +"].Id");
				itemsItem.RecordingType = _ctx.StringValue("ListDetections.Data.Items["+ i +"].RecordingType");
				itemsItem.RuleId = _ctx.StringValue("ListDetections.Data.Items["+ i +"].RuleId");
				itemsItem.RuleName = _ctx.StringValue("ListDetections.Data.Items["+ i +"].RuleName");
				itemsItem.Status = _ctx.StringValue("ListDetections.Data.Items["+ i +"].Status");

				List<ListDetectionsResponse.ListDetections_Data.ListDetections_ItemsItem.ListDetections_TasksItem> itemsItem_tasks = new List<ListDetectionsResponse.ListDetections_Data.ListDetections_ItemsItem.ListDetections_TasksItem>();
				for (int j = 0; j < _ctx.Length("ListDetections.Data.Items["+ i +"].Tasks.Length"); j++) {
					ListDetectionsResponse.ListDetections_Data.ListDetections_ItemsItem.ListDetections_TasksItem tasksItem = new ListDetectionsResponse.ListDetections_Data.ListDetections_ItemsItem.ListDetections_TasksItem();
					tasksItem.CreatedAt = _ctx.StringValue("ListDetections.Data.Items["+ i +"].Tasks["+ j +"].CreatedAt");
					tasksItem.Id = _ctx.StringValue("ListDetections.Data.Items["+ i +"].Tasks["+ j +"].Id");
					tasksItem.Status = _ctx.StringValue("ListDetections.Data.Items["+ i +"].Tasks["+ j +"].Status");
					tasksItem.VideoMetaUrl = _ctx.StringValue("ListDetections.Data.Items["+ i +"].Tasks["+ j +"].VideoMetaUrl");
					tasksItem.VideoUrl = _ctx.StringValue("ListDetections.Data.Items["+ i +"].Tasks["+ j +"].VideoUrl");

					itemsItem_tasks.Add(tasksItem);
				}
				itemsItem.Tasks = itemsItem_tasks;

				data_items.Add(itemsItem);
			}
			data.Items = data_items;
			listDetectionsResponse.Data = data;

			List<ListDetectionsResponse.ListDetections_ErrorsItem> listDetectionsResponse_errors = new List<ListDetectionsResponse.ListDetections_ErrorsItem>();
			for (int i = 0; i < _ctx.Length("ListDetections.Errors.Length"); i++) {
				ListDetectionsResponse.ListDetections_ErrorsItem errorsItem = new ListDetectionsResponse.ListDetections_ErrorsItem();
				errorsItem.Field = _ctx.StringValue("ListDetections.Errors["+ i +"].Field");
				errorsItem.Message = _ctx.StringValue("ListDetections.Errors["+ i +"].Message");

				listDetectionsResponse_errors.Add(errorsItem);
			}
			listDetectionsResponse.Errors = listDetectionsResponse_errors;
        
			return listDetectionsResponse;
        }
    }
}
