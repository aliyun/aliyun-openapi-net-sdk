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
using Aliyun.Acs.AIPodcast.Model.V20250228;

namespace Aliyun.Acs.AIPodcast.Transform.V20250228
{
    public class PodcastTaskSubmitResponseUnmarshaller
    {
        public static PodcastTaskSubmitResponse Unmarshall(UnmarshallerContext _ctx)
        {
			PodcastTaskSubmitResponse podcastTaskSubmitResponse = new PodcastTaskSubmitResponse();

			podcastTaskSubmitResponse.HttpResponse = _ctx.HttpResponse;
			podcastTaskSubmitResponse.Code = _ctx.StringValue("PodcastTaskSubmit.code");
			podcastTaskSubmitResponse.Message = _ctx.StringValue("PodcastTaskSubmit.message");
			podcastTaskSubmitResponse.RequestId = _ctx.StringValue("PodcastTaskSubmit.requestId");
			podcastTaskSubmitResponse.Success = _ctx.BooleanValue("PodcastTaskSubmit.success");
			podcastTaskSubmitResponse.HttpStatusCode = _ctx.StringValue("PodcastTaskSubmit.httpStatusCode");

			PodcastTaskSubmitResponse.PodcastTaskSubmit_Data data = new PodcastTaskSubmitResponse.PodcastTaskSubmit_Data();
			data.TaskId = _ctx.StringValue("PodcastTaskSubmit.Data.taskId");
			data.TaskStatus = _ctx.StringValue("PodcastTaskSubmit.Data.taskStatus");
			podcastTaskSubmitResponse.Data = data;
        
			return podcastTaskSubmitResponse;
        }
    }
}
