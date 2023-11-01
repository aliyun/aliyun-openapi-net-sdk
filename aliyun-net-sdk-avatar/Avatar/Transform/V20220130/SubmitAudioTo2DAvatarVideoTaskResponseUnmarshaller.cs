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
    public class SubmitAudioTo2DAvatarVideoTaskResponseUnmarshaller
    {
        public static SubmitAudioTo2DAvatarVideoTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SubmitAudioTo2DAvatarVideoTaskResponse submitAudioTo2DAvatarVideoTaskResponse = new SubmitAudioTo2DAvatarVideoTaskResponse();

			submitAudioTo2DAvatarVideoTaskResponse.HttpResponse = _ctx.HttpResponse;
			submitAudioTo2DAvatarVideoTaskResponse.RequestId = _ctx.StringValue("SubmitAudioTo2DAvatarVideoTask.RequestId");
			submitAudioTo2DAvatarVideoTaskResponse.Code = _ctx.StringValue("SubmitAudioTo2DAvatarVideoTask.Code");
			submitAudioTo2DAvatarVideoTaskResponse.Message = _ctx.StringValue("SubmitAudioTo2DAvatarVideoTask.Message");
			submitAudioTo2DAvatarVideoTaskResponse.Success = _ctx.BooleanValue("SubmitAudioTo2DAvatarVideoTask.Success");

			SubmitAudioTo2DAvatarVideoTaskResponse.SubmitAudioTo2DAvatarVideoTask_Data data = new SubmitAudioTo2DAvatarVideoTaskResponse.SubmitAudioTo2DAvatarVideoTask_Data();
			data.TaskUuid = _ctx.StringValue("SubmitAudioTo2DAvatarVideoTask.Data.TaskUuid");
			submitAudioTo2DAvatarVideoTaskResponse.Data = data;
        
			return submitAudioTo2DAvatarVideoTaskResponse;
        }
    }
}
