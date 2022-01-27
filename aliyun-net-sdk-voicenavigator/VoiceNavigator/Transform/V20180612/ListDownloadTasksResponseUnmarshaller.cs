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
using Aliyun.Acs.VoiceNavigator.Model.V20180612;

namespace Aliyun.Acs.VoiceNavigator.Transform.V20180612
{
    public class ListDownloadTasksResponseUnmarshaller
    {
        public static ListDownloadTasksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDownloadTasksResponse listDownloadTasksResponse = new ListDownloadTasksResponse();

			listDownloadTasksResponse.HttpResponse = _ctx.HttpResponse;
			listDownloadTasksResponse.HttpStatusCode = _ctx.IntegerValue("ListDownloadTasks.HttpStatusCode");
			listDownloadTasksResponse.Code = _ctx.StringValue("ListDownloadTasks.Code");
			listDownloadTasksResponse.Message = _ctx.StringValue("ListDownloadTasks.Message");
			listDownloadTasksResponse.RequestId = _ctx.StringValue("ListDownloadTasks.RequestId");
			listDownloadTasksResponse.Success = _ctx.BooleanValue("ListDownloadTasks.Success");

			ListDownloadTasksResponse.ListDownloadTasks_DownloadTasks downloadTasks = new ListDownloadTasksResponse.ListDownloadTasks_DownloadTasks();
			downloadTasks.PageNumber = _ctx.IntegerValue("ListDownloadTasks.DownloadTasks.PageNumber");
			downloadTasks.PageSize = _ctx.IntegerValue("ListDownloadTasks.DownloadTasks.PageSize");
			downloadTasks.TotalCount = _ctx.IntegerValue("ListDownloadTasks.DownloadTasks.TotalCount");

			List<ListDownloadTasksResponse.ListDownloadTasks_DownloadTasks.ListDownloadTasks_DownloadTask> downloadTasks_list = new List<ListDownloadTasksResponse.ListDownloadTasks_DownloadTasks.ListDownloadTasks_DownloadTask>();
			for (int i = 0; i < _ctx.Length("ListDownloadTasks.DownloadTasks.List.Length"); i++) {
				ListDownloadTasksResponse.ListDownloadTasks_DownloadTasks.ListDownloadTasks_DownloadTask downloadTask = new ListDownloadTasksResponse.ListDownloadTasks_DownloadTasks.ListDownloadTasks_DownloadTask();
				downloadTask.Status = _ctx.StringValue("ListDownloadTasks.DownloadTasks.List["+ i +"].Status");
				downloadTask.Title = _ctx.StringValue("ListDownloadTasks.DownloadTasks.List["+ i +"].Title");
				downloadTask.ExpireTime = _ctx.LongValue("ListDownloadTasks.DownloadTasks.List["+ i +"].ExpireTime");
				downloadTask.TaskId = _ctx.StringValue("ListDownloadTasks.DownloadTasks.List["+ i +"].TaskId");

				List<ListDownloadTasksResponse.ListDownloadTasks_DownloadTasks.ListDownloadTasks_DownloadTask.ListDownloadTasks_DownloadTaskFile0> downloadTask_downloadTaskFiles = new List<ListDownloadTasksResponse.ListDownloadTasks_DownloadTasks.ListDownloadTasks_DownloadTask.ListDownloadTasks_DownloadTaskFile0>();
				for (int j = 0; j < _ctx.Length("ListDownloadTasks.DownloadTasks.List["+ i +"].DownloadTaskFiles.Length"); j++) {
					ListDownloadTasksResponse.ListDownloadTasks_DownloadTasks.ListDownloadTasks_DownloadTask.ListDownloadTasks_DownloadTaskFile0 downloadTaskFile0 = new ListDownloadTasksResponse.ListDownloadTasks_DownloadTasks.ListDownloadTasks_DownloadTask.ListDownloadTasks_DownloadTaskFile0();
					downloadTaskFile0.Status = _ctx.StringValue("ListDownloadTasks.DownloadTasks.List["+ i +"].DownloadTaskFiles["+ j +"].Status");
					downloadTaskFile0.Title = _ctx.StringValue("ListDownloadTasks.DownloadTasks.List["+ i +"].DownloadTaskFiles["+ j +"].Title");
					downloadTaskFile0.Progress = _ctx.IntegerValue("ListDownloadTasks.DownloadTasks.List["+ i +"].DownloadTaskFiles["+ j +"].Progress");
					downloadTaskFile0.FileId = _ctx.StringValue("ListDownloadTasks.DownloadTasks.List["+ i +"].DownloadTaskFiles["+ j +"].FileId");

					downloadTask_downloadTaskFiles.Add(downloadTaskFile0);
				}
				downloadTask.DownloadTaskFiles = downloadTask_downloadTaskFiles;

				downloadTasks_list.Add(downloadTask);
			}
			downloadTasks.List = downloadTasks_list;
			listDownloadTasksResponse.DownloadTasks = downloadTasks;
        
			return listDownloadTasksResponse;
        }
    }
}
