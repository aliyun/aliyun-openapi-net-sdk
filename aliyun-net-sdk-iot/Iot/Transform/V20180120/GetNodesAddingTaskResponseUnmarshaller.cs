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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class GetNodesAddingTaskResponseUnmarshaller
    {
        public static GetNodesAddingTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetNodesAddingTaskResponse getNodesAddingTaskResponse = new GetNodesAddingTaskResponse();

			getNodesAddingTaskResponse.HttpResponse = _ctx.HttpResponse;
			getNodesAddingTaskResponse.RequestId = _ctx.StringValue("GetNodesAddingTask.RequestId");
			getNodesAddingTaskResponse.Success = _ctx.BooleanValue("GetNodesAddingTask.Success");
			getNodesAddingTaskResponse.Code = _ctx.StringValue("GetNodesAddingTask.Code");
			getNodesAddingTaskResponse.ErrorMessage = _ctx.StringValue("GetNodesAddingTask.ErrorMessage");
			getNodesAddingTaskResponse.TaskId = _ctx.StringValue("GetNodesAddingTask.TaskId");
			getNodesAddingTaskResponse.TaskState = _ctx.StringValue("GetNodesAddingTask.TaskState");
			getNodesAddingTaskResponse.TotalCount = _ctx.LongValue("GetNodesAddingTask.TotalCount");
			getNodesAddingTaskResponse.SuccessCount = _ctx.LongValue("GetNodesAddingTask.SuccessCount");

			List<string> getNodesAddingTaskResponse_successDevEuis = new List<string>();
			for (int i = 0; i < _ctx.Length("GetNodesAddingTask.SuccessDevEuis.Length"); i++) {
				getNodesAddingTaskResponse_successDevEuis.Add(_ctx.StringValue("GetNodesAddingTask.SuccessDevEuis["+ i +"]"));
			}
			getNodesAddingTaskResponse.SuccessDevEuis = getNodesAddingTaskResponse_successDevEuis;
        
			return getNodesAddingTaskResponse;
        }
    }
}
