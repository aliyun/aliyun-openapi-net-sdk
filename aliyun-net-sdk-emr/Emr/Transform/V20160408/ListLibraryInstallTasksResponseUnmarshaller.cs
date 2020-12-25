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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class ListLibraryInstallTasksResponseUnmarshaller
    {
        public static ListLibraryInstallTasksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListLibraryInstallTasksResponse listLibraryInstallTasksResponse = new ListLibraryInstallTasksResponse();

			listLibraryInstallTasksResponse.HttpResponse = _ctx.HttpResponse;
			listLibraryInstallTasksResponse.RequestId = _ctx.StringValue("ListLibraryInstallTasks.RequestId");
			listLibraryInstallTasksResponse.PageNumber = _ctx.IntegerValue("ListLibraryInstallTasks.PageNumber");
			listLibraryInstallTasksResponse.PageSize = _ctx.IntegerValue("ListLibraryInstallTasks.PageSize");
			listLibraryInstallTasksResponse.TotalCount = _ctx.IntegerValue("ListLibraryInstallTasks.TotalCount");
			listLibraryInstallTasksResponse.NextToken = _ctx.StringValue("ListLibraryInstallTasks.NextToken");

			List<ListLibraryInstallTasksResponse.ListLibraryInstallTasks_Item> listLibraryInstallTasksResponse_items = new List<ListLibraryInstallTasksResponse.ListLibraryInstallTasks_Item>();
			for (int i = 0; i < _ctx.Length("ListLibraryInstallTasks.Items.Length"); i++) {
				ListLibraryInstallTasksResponse.ListLibraryInstallTasks_Item item = new ListLibraryInstallTasksResponse.ListLibraryInstallTasks_Item();
				item.LibraryBizId = _ctx.StringValue("ListLibraryInstallTasks.Items["+ i +"].LibraryBizId");
				item.TaskGroupId = _ctx.StringValue("ListLibraryInstallTasks.Items["+ i +"].TaskGroupId");
				item.TaskId = _ctx.StringValue("ListLibraryInstallTasks.Items["+ i +"].TaskId");
				item.TaskStatus = _ctx.StringValue("ListLibraryInstallTasks.Items["+ i +"].TaskStatus");
				item.StartTime = _ctx.LongValue("ListLibraryInstallTasks.Items["+ i +"].StartTime");
				item.EndTime = _ctx.LongValue("ListLibraryInstallTasks.Items["+ i +"].EndTime");
				item.ExecuteTime = _ctx.LongValue("ListLibraryInstallTasks.Items["+ i +"].ExecuteTime");
				item.TaskProcess = _ctx.IntegerValue("ListLibraryInstallTasks.Items["+ i +"].TaskProcess");
				item.TaskType = _ctx.StringValue("ListLibraryInstallTasks.Items["+ i +"].TaskType");
				item.Detail = _ctx.StringValue("ListLibraryInstallTasks.Items["+ i +"].Detail");
				item.ClusterBizId = _ctx.StringValue("ListLibraryInstallTasks.Items["+ i +"].ClusterBizId");
				item.Hostname = _ctx.StringValue("ListLibraryInstallTasks.Items["+ i +"].Hostname");

				listLibraryInstallTasksResponse_items.Add(item);
			}
			listLibraryInstallTasksResponse.Items = listLibraryInstallTasksResponse_items;
        
			return listLibraryInstallTasksResponse;
        }
    }
}
