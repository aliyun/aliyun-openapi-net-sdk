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
using Aliyun.Acs.WebsiteBuild.Model.V20250429;

namespace Aliyun.Acs.WebsiteBuild.Transform.V20250429
{
    public class GetCreateLogoTaskResponseUnmarshaller
    {
        public static GetCreateLogoTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetCreateLogoTaskResponse getCreateLogoTaskResponse = new GetCreateLogoTaskResponse();

			getCreateLogoTaskResponse.HttpResponse = _ctx.HttpResponse;
			getCreateLogoTaskResponse.RequestId = _ctx.StringValue("GetCreateLogoTask.RequestId");
			getCreateLogoTaskResponse.ErrorMsg = _ctx.StringValue("GetCreateLogoTask.ErrorMsg");
			getCreateLogoTaskResponse.Success = _ctx.BooleanValue("GetCreateLogoTask.Success");
			getCreateLogoTaskResponse.ErrorCode = _ctx.StringValue("GetCreateLogoTask.ErrorCode");

			GetCreateLogoTaskResponse.GetCreateLogoTask_Task task = new GetCreateLogoTaskResponse.GetCreateLogoTask_Task();
			task.TaskId = _ctx.StringValue("GetCreateLogoTask.Task.TaskId");
			task.TaskStatus = _ctx.StringValue("GetCreateLogoTask.Task.TaskStatus");

			List<string> task_urls = new List<string>();
			for (int i = 0; i < _ctx.Length("GetCreateLogoTask.Task.Urls.Length"); i++) {
				task_urls.Add(_ctx.StringValue("GetCreateLogoTask.Task.Urls["+ i +"]"));
			}
			task.Urls = task_urls;
			getCreateLogoTaskResponse.Task = task;
        
			return getCreateLogoTaskResponse;
        }
    }
}
