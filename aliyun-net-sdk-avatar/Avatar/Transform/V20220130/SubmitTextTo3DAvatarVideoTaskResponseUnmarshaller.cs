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
    public class SubmitTextTo3DAvatarVideoTaskResponseUnmarshaller
    {
        public static SubmitTextTo3DAvatarVideoTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SubmitTextTo3DAvatarVideoTaskResponse submitTextTo3DAvatarVideoTaskResponse = new SubmitTextTo3DAvatarVideoTaskResponse();

			submitTextTo3DAvatarVideoTaskResponse.HttpResponse = _ctx.HttpResponse;
			submitTextTo3DAvatarVideoTaskResponse.RequestId = _ctx.StringValue("SubmitTextTo3DAvatarVideoTask.RequestId");
			submitTextTo3DAvatarVideoTaskResponse.Success = _ctx.BooleanValue("SubmitTextTo3DAvatarVideoTask.Success");
			submitTextTo3DAvatarVideoTaskResponse.Code = _ctx.StringValue("SubmitTextTo3DAvatarVideoTask.Code");
			submitTextTo3DAvatarVideoTaskResponse.Message = _ctx.StringValue("SubmitTextTo3DAvatarVideoTask.Message");

			SubmitTextTo3DAvatarVideoTaskResponse.SubmitTextTo3DAvatarVideoTask_Data data = new SubmitTextTo3DAvatarVideoTaskResponse.SubmitTextTo3DAvatarVideoTask_Data();
			data.TaskUuid = _ctx.StringValue("SubmitTextTo3DAvatarVideoTask.Data.TaskUuid");
			submitTextTo3DAvatarVideoTaskResponse.Data = data;
        
			return submitTextTo3DAvatarVideoTaskResponse;
        }
    }
}
