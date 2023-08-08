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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeLiveStreamPreloadTasksResponseUnmarshaller
    {
        public static DescribeLiveStreamPreloadTasksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveStreamPreloadTasksResponse describeLiveStreamPreloadTasksResponse = new DescribeLiveStreamPreloadTasksResponse();

			describeLiveStreamPreloadTasksResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveStreamPreloadTasksResponse.TotalPage = _ctx.IntegerValue("DescribeLiveStreamPreloadTasks.TotalPage");
			describeLiveStreamPreloadTasksResponse.PageNum = _ctx.IntegerValue("DescribeLiveStreamPreloadTasks.PageNum");
			describeLiveStreamPreloadTasksResponse.PageSize = _ctx.IntegerValue("DescribeLiveStreamPreloadTasks.PageSize");
			describeLiveStreamPreloadTasksResponse.RequestId = _ctx.StringValue("DescribeLiveStreamPreloadTasks.RequestId");
			describeLiveStreamPreloadTasksResponse.TotalNum = _ctx.IntegerValue("DescribeLiveStreamPreloadTasks.TotalNum");

			List<DescribeLiveStreamPreloadTasksResponse.DescribeLiveStreamPreloadTasks_PreloadTask> describeLiveStreamPreloadTasksResponse_preloadTasks = new List<DescribeLiveStreamPreloadTasksResponse.DescribeLiveStreamPreloadTasks_PreloadTask>();
			for (int i = 0; i < _ctx.Length("DescribeLiveStreamPreloadTasks.PreloadTasks.Length"); i++) {
				DescribeLiveStreamPreloadTasksResponse.DescribeLiveStreamPreloadTasks_PreloadTask preloadTask = new DescribeLiveStreamPreloadTasksResponse.DescribeLiveStreamPreloadTasks_PreloadTask();
				preloadTask.Status = _ctx.StringValue("DescribeLiveStreamPreloadTasks.PreloadTasks["+ i +"].Status");
				preloadTask.Process = _ctx.StringValue("DescribeLiveStreamPreloadTasks.PreloadTasks["+ i +"].Process");
				preloadTask.Description = _ctx.StringValue("DescribeLiveStreamPreloadTasks.PreloadTasks["+ i +"].Description");
				preloadTask.CreateTime = _ctx.StringValue("DescribeLiveStreamPreloadTasks.PreloadTasks["+ i +"].CreateTime");
				preloadTask.PreloadedEndTime = _ctx.StringValue("DescribeLiveStreamPreloadTasks.PreloadTasks["+ i +"].PreloadedEndTime");
				preloadTask.PreloadedStartTime = _ctx.StringValue("DescribeLiveStreamPreloadTasks.PreloadTasks["+ i +"].PreloadedStartTime");
				preloadTask.PlayUrl = _ctx.StringValue("DescribeLiveStreamPreloadTasks.PreloadTasks["+ i +"].PlayUrl");
				preloadTask.Area = _ctx.StringValue("DescribeLiveStreamPreloadTasks.PreloadTasks["+ i +"].Area");
				preloadTask.TaskId = _ctx.StringValue("DescribeLiveStreamPreloadTasks.PreloadTasks["+ i +"].TaskId");
				preloadTask.DomainName = _ctx.StringValue("DescribeLiveStreamPreloadTasks.PreloadTasks["+ i +"].DomainName");

				describeLiveStreamPreloadTasksResponse_preloadTasks.Add(preloadTask);
			}
			describeLiveStreamPreloadTasksResponse.PreloadTasks = describeLiveStreamPreloadTasksResponse_preloadTasks;
        
			return describeLiveStreamPreloadTasksResponse;
        }
    }
}
