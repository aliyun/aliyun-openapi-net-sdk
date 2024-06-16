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
    public class SubmitTextTo2DAvatarVideoTaskResponseUnmarshaller
    {
        public static SubmitTextTo2DAvatarVideoTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SubmitTextTo2DAvatarVideoTaskResponse submitTextTo2DAvatarVideoTaskResponse = new SubmitTextTo2DAvatarVideoTaskResponse();

			submitTextTo2DAvatarVideoTaskResponse.HttpResponse = _ctx.HttpResponse;
			submitTextTo2DAvatarVideoTaskResponse.RequestId = _ctx.StringValue("SubmitTextTo2DAvatarVideoTask.RequestId");
			submitTextTo2DAvatarVideoTaskResponse.Success = _ctx.BooleanValue("SubmitTextTo2DAvatarVideoTask.Success");
			submitTextTo2DAvatarVideoTaskResponse.Code = _ctx.StringValue("SubmitTextTo2DAvatarVideoTask.Code");
			submitTextTo2DAvatarVideoTaskResponse.Message = _ctx.StringValue("SubmitTextTo2DAvatarVideoTask.Message");

			SubmitTextTo2DAvatarVideoTaskResponse.SubmitTextTo2DAvatarVideoTask_Data data = new SubmitTextTo2DAvatarVideoTaskResponse.SubmitTextTo2DAvatarVideoTask_Data();
			data.TaskUuid = _ctx.StringValue("SubmitTextTo2DAvatarVideoTask.Data.TaskUuid");
			submitTextTo2DAvatarVideoTaskResponse.Data = data;
        
			return submitTextTo2DAvatarVideoTaskResponse;
        }
    }
}
