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
using Aliyun.Acs.avatar.Model.V20220130;

namespace Aliyun.Acs.avatar.Transform.V20220130
{
    public class GetVideoTaskInfoResponseUnmarshaller
    {
        public static GetVideoTaskInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetVideoTaskInfoResponse getVideoTaskInfoResponse = new GetVideoTaskInfoResponse();

			getVideoTaskInfoResponse.HttpResponse = _ctx.HttpResponse;
			getVideoTaskInfoResponse.RequestId = _ctx.StringValue("GetVideoTaskInfo.RequestId");
			getVideoTaskInfoResponse.Code = _ctx.StringValue("GetVideoTaskInfo.Code");
			getVideoTaskInfoResponse.Message = _ctx.StringValue("GetVideoTaskInfo.Message");
			getVideoTaskInfoResponse.Success = _ctx.BooleanValue("GetVideoTaskInfo.Success");

			GetVideoTaskInfoResponse.GetVideoTaskInfo_Data data = new GetVideoTaskInfoResponse.GetVideoTaskInfo_Data();
			data.TaskUuid = _ctx.StringValue("GetVideoTaskInfo.Data.TaskUuid");
			data.Type = _ctx.StringValue("GetVideoTaskInfo.Data.Type");
			data.Status = _ctx.StringValue("GetVideoTaskInfo.Data.Status");
			data.Process = _ctx.StringValue("GetVideoTaskInfo.Data.Process");

			GetVideoTaskInfoResponse.GetVideoTaskInfo_Data.GetVideoTaskInfo_TaskResult taskResult = new GetVideoTaskInfoResponse.GetVideoTaskInfo_Data.GetVideoTaskInfo_TaskResult();
			taskResult.VideoUrl = _ctx.StringValue("GetVideoTaskInfo.Data.TaskResult.VideoUrl");
			taskResult.SubtitlesUrl = _ctx.StringValue("GetVideoTaskInfo.Data.TaskResult.SubtitlesUrl");
			taskResult.WordSubtitlesUrl = _ctx.StringValue("GetVideoTaskInfo.Data.TaskResult.WordSubtitlesUrl");
			taskResult.FailReason = _ctx.StringValue("GetVideoTaskInfo.Data.TaskResult.FailReason");
			taskResult.FailCode = _ctx.StringValue("GetVideoTaskInfo.Data.TaskResult.FailCode");
			taskResult.VideoDuration = _ctx.IntegerValue("GetVideoTaskInfo.Data.TaskResult.VideoDuration");
			taskResult.AlphaUrl = _ctx.StringValue("GetVideoTaskInfo.Data.TaskResult.AlphaUrl");
			taskResult.PreviewPic = _ctx.StringValue("GetVideoTaskInfo.Data.TaskResult.PreviewPic");
			taskResult.AttachmentUrl = _ctx.StringValue("GetVideoTaskInfo.Data.TaskResult.AttachmentUrl");
			data.TaskResult = taskResult;
			getVideoTaskInfoResponse.Data = data;
        
			return getVideoTaskInfoResponse;
        }
    }
}
