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
using Aliyun.Acs.fnf.Model.V20190315;

namespace Aliyun.Acs.fnf.Transform.V20190315
{
    public class StartSyncExecutionResponseUnmarshaller
    {
        public static StartSyncExecutionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			StartSyncExecutionResponse startSyncExecutionResponse = new StartSyncExecutionResponse();

			startSyncExecutionResponse.HttpResponse = _ctx.HttpResponse;
			startSyncExecutionResponse.RequestId = _ctx.StringValue("StartSyncExecution.RequestId");
			startSyncExecutionResponse.FlowName = _ctx.StringValue("StartSyncExecution.FlowName");
			startSyncExecutionResponse.Name = _ctx.StringValue("StartSyncExecution.Name");
			startSyncExecutionResponse.Status = _ctx.StringValue("StartSyncExecution.Status");
			startSyncExecutionResponse.ErrorCode = _ctx.StringValue("StartSyncExecution.ErrorCode");
			startSyncExecutionResponse.ErrorMessage = _ctx.StringValue("StartSyncExecution.ErrorMessage");
			startSyncExecutionResponse.Output = _ctx.StringValue("StartSyncExecution.Output");
			startSyncExecutionResponse.StartedTime = _ctx.StringValue("StartSyncExecution.StartedTime");
			startSyncExecutionResponse.StoppedTime = _ctx.StringValue("StartSyncExecution.StoppedTime");
        
			return startSyncExecutionResponse;
        }
    }
}
