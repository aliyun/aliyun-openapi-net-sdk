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
using Aliyun.Acs.imm.Model.V20170906;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class GetVideoTaskResponseUnmarshaller
    {
        public static GetVideoTaskResponse Unmarshall(UnmarshallerContext context)
        {
			GetVideoTaskResponse getVideoTaskResponse = new GetVideoTaskResponse();

			getVideoTaskResponse.HttpResponse = context.HttpResponse;
			getVideoTaskResponse.RequestId = context.StringValue("GetVideoTask.RequestId");
			getVideoTaskResponse.TaskId = context.StringValue("GetVideoTask.TaskId");
			getVideoTaskResponse.TaskType = context.StringValue("GetVideoTask.TaskType");
			getVideoTaskResponse.Parameters = context.StringValue("GetVideoTask.Parameters");
			getVideoTaskResponse.Result = context.StringValue("GetVideoTask.Result");
			getVideoTaskResponse.Status = context.StringValue("GetVideoTask.Status");
			getVideoTaskResponse.StartTime = context.StringValue("GetVideoTask.StartTime");
			getVideoTaskResponse.EndTime = context.StringValue("GetVideoTask.EndTime");
			getVideoTaskResponse.ErrorMessage = context.StringValue("GetVideoTask.ErrorMessage");
			getVideoTaskResponse.NotifyEndpoint = context.StringValue("GetVideoTask.NotifyEndpoint");
			getVideoTaskResponse.NotifyTopicName = context.StringValue("GetVideoTask.NotifyTopicName");
			getVideoTaskResponse.Progress = context.IntegerValue("GetVideoTask.Progress");
        
			return getVideoTaskResponse;
        }
    }
}
