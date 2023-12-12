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
using Aliyun.Acs.tingwu.Model.V20230930;

namespace Aliyun.Acs.tingwu.Transform.V20230930
{
    public class GetTaskInfoResponseUnmarshaller
    {
        public static GetTaskInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetTaskInfoResponse getTaskInfoResponse = new GetTaskInfoResponse();

			getTaskInfoResponse.HttpResponse = _ctx.HttpResponse;
			getTaskInfoResponse.RequestId = _ctx.StringValue("GetTaskInfo.RequestId");
			getTaskInfoResponse.Code = _ctx.StringValue("GetTaskInfo.Code");
			getTaskInfoResponse.Message = _ctx.StringValue("GetTaskInfo.Message");

			GetTaskInfoResponse.GetTaskInfo_Data data = new GetTaskInfoResponse.GetTaskInfo_Data();
			data.TaskId = _ctx.StringValue("GetTaskInfo.Data.TaskId");
			data.TaskKey = _ctx.StringValue("GetTaskInfo.Data.TaskKey");
			data.TaskStatus = _ctx.StringValue("GetTaskInfo.Data.TaskStatus");
			getTaskInfoResponse.Data = data;
        
			return getTaskInfoResponse;
        }
    }
}
