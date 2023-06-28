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
    public class CancelVideoTaskResponseUnmarshaller
    {
        public static CancelVideoTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CancelVideoTaskResponse cancelVideoTaskResponse = new CancelVideoTaskResponse();

			cancelVideoTaskResponse.HttpResponse = _ctx.HttpResponse;
			cancelVideoTaskResponse.RequestId = _ctx.StringValue("CancelVideoTask.RequestId");
			cancelVideoTaskResponse.Code = _ctx.StringValue("CancelVideoTask.Code");
			cancelVideoTaskResponse.Message = _ctx.StringValue("CancelVideoTask.Message");
			cancelVideoTaskResponse.Success = _ctx.BooleanValue("CancelVideoTask.Success");

			CancelVideoTaskResponse.CancelVideoTask_Data data = new CancelVideoTaskResponse.CancelVideoTask_Data();
			data.TaskUuid = _ctx.StringValue("CancelVideoTask.Data.TaskUuid");
			data.IsCancel = _ctx.BooleanValue("CancelVideoTask.Data.IsCancel");
			data.FailReason = _ctx.StringValue("CancelVideoTask.Data.FailReason");
			cancelVideoTaskResponse.Data = data;
        
			return cancelVideoTaskResponse;
        }
    }
}
