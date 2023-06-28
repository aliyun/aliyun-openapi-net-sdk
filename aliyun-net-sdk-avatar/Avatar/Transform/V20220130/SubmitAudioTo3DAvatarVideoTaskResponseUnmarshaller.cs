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
    public class SubmitAudioTo3DAvatarVideoTaskResponseUnmarshaller
    {
        public static SubmitAudioTo3DAvatarVideoTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SubmitAudioTo3DAvatarVideoTaskResponse submitAudioTo3DAvatarVideoTaskResponse = new SubmitAudioTo3DAvatarVideoTaskResponse();

			submitAudioTo3DAvatarVideoTaskResponse.HttpResponse = _ctx.HttpResponse;
			submitAudioTo3DAvatarVideoTaskResponse.RequestId = _ctx.StringValue("SubmitAudioTo3DAvatarVideoTask.RequestId");
			submitAudioTo3DAvatarVideoTaskResponse.Code = _ctx.StringValue("SubmitAudioTo3DAvatarVideoTask.Code");
			submitAudioTo3DAvatarVideoTaskResponse.Message = _ctx.StringValue("SubmitAudioTo3DAvatarVideoTask.Message");
			submitAudioTo3DAvatarVideoTaskResponse.Success = _ctx.StringValue("SubmitAudioTo3DAvatarVideoTask.Success");

			SubmitAudioTo3DAvatarVideoTaskResponse.SubmitAudioTo3DAvatarVideoTask_Data data = new SubmitAudioTo3DAvatarVideoTaskResponse.SubmitAudioTo3DAvatarVideoTask_Data();
			data.TaskUuid = _ctx.StringValue("SubmitAudioTo3DAvatarVideoTask.Data.TaskUuid");
			submitAudioTo3DAvatarVideoTaskResponse.Data = data;
        
			return submitAudioTo3DAvatarVideoTaskResponse;
        }
    }
}
