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
    public class SubmitAvatarVideoTaskResponseUnmarshaller
    {
        public static SubmitAvatarVideoTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SubmitAvatarVideoTaskResponse submitAvatarVideoTaskResponse = new SubmitAvatarVideoTaskResponse();

			submitAvatarVideoTaskResponse.HttpResponse = _ctx.HttpResponse;
			submitAvatarVideoTaskResponse.RequestId = _ctx.StringValue("SubmitAvatarVideoTask.RequestId");
			submitAvatarVideoTaskResponse.Success = _ctx.BooleanValue("SubmitAvatarVideoTask.Success");
			submitAvatarVideoTaskResponse.Code = _ctx.StringValue("SubmitAvatarVideoTask.Code");
			submitAvatarVideoTaskResponse.Message = _ctx.StringValue("SubmitAvatarVideoTask.Message");

			SubmitAvatarVideoTaskResponse.SubmitAvatarVideoTask_Data data = new SubmitAvatarVideoTaskResponse.SubmitAvatarVideoTask_Data();
			data.TaskUuid = _ctx.StringValue("SubmitAvatarVideoTask.Data.TaskUuid");
			submitAvatarVideoTaskResponse.Data = data;
        
			return submitAvatarVideoTaskResponse;
        }
    }
}
