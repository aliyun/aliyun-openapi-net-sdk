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
    public class StopExecutionResponseUnmarshaller
    {
        public static StopExecutionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			StopExecutionResponse stopExecutionResponse = new StopExecutionResponse();

			stopExecutionResponse.HttpResponse = _ctx.HttpResponse;
			stopExecutionResponse.RequestId = _ctx.StringValue("StopExecution.RequestId");
			stopExecutionResponse.Name = _ctx.StringValue("StopExecution.Name");
			stopExecutionResponse.FlowName = _ctx.StringValue("StopExecution.FlowName");
			stopExecutionResponse.FlowDefinition = _ctx.StringValue("StopExecution.FlowDefinition");
			stopExecutionResponse.Input = _ctx.StringValue("StopExecution.Input");
			stopExecutionResponse.Output = _ctx.StringValue("StopExecution.Output");
			stopExecutionResponse.Status = _ctx.StringValue("StopExecution.Status");
			stopExecutionResponse.StartedTime = _ctx.StringValue("StopExecution.StartedTime");
			stopExecutionResponse.StoppedTime = _ctx.StringValue("StopExecution.StoppedTime");
			stopExecutionResponse.ExternalInputUri = _ctx.StringValue("StopExecution.ExternalInputUri");
			stopExecutionResponse.ExternalOutputUri = _ctx.StringValue("StopExecution.ExternalOutputUri");
        
			return stopExecutionResponse;
        }
    }
}
