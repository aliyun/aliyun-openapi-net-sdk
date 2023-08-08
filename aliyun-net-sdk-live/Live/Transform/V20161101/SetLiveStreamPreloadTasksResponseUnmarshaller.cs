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
    public class SetLiveStreamPreloadTasksResponseUnmarshaller
    {
        public static SetLiveStreamPreloadTasksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SetLiveStreamPreloadTasksResponse setLiveStreamPreloadTasksResponse = new SetLiveStreamPreloadTasksResponse();

			setLiveStreamPreloadTasksResponse.HttpResponse = _ctx.HttpResponse;
			setLiveStreamPreloadTasksResponse.Status = _ctx.StringValue("SetLiveStreamPreloadTasks.Status");
			setLiveStreamPreloadTasksResponse.FailedURL = _ctx.IntegerValue("SetLiveStreamPreloadTasks.FailedURL");
			setLiveStreamPreloadTasksResponse.TotalURL = _ctx.IntegerValue("SetLiveStreamPreloadTasks.TotalURL");
			setLiveStreamPreloadTasksResponse.RequestId = _ctx.StringValue("SetLiveStreamPreloadTasks.RequestId");
			setLiveStreamPreloadTasksResponse.SuccessURL = _ctx.IntegerValue("SetLiveStreamPreloadTasks.SuccessURL");

			List<SetLiveStreamPreloadTasksResponse.SetLiveStreamPreloadTasks_PreloadTasksMessage> setLiveStreamPreloadTasksResponse_preloadTasksMessages = new List<SetLiveStreamPreloadTasksResponse.SetLiveStreamPreloadTasks_PreloadTasksMessage>();
			for (int i = 0; i < _ctx.Length("SetLiveStreamPreloadTasks.PreloadTasksMessages.Length"); i++) {
				SetLiveStreamPreloadTasksResponse.SetLiveStreamPreloadTasks_PreloadTasksMessage preloadTasksMessage = new SetLiveStreamPreloadTasksResponse.SetLiveStreamPreloadTasks_PreloadTasksMessage();
				preloadTasksMessage.PlayUrl = _ctx.StringValue("SetLiveStreamPreloadTasks.PreloadTasksMessages["+ i +"].PlayUrl");
				preloadTasksMessage.Description = _ctx.StringValue("SetLiveStreamPreloadTasks.PreloadTasksMessages["+ i +"].Description");
				preloadTasksMessage.TaskId = _ctx.StringValue("SetLiveStreamPreloadTasks.PreloadTasksMessages["+ i +"].TaskId");

				setLiveStreamPreloadTasksResponse_preloadTasksMessages.Add(preloadTasksMessage);
			}
			setLiveStreamPreloadTasksResponse.PreloadTasksMessages = setLiveStreamPreloadTasksResponse_preloadTasksMessages;
        
			return setLiveStreamPreloadTasksResponse;
        }
    }
}
