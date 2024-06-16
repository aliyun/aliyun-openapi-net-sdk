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
    public class DescribeExecutionResponseUnmarshaller
    {
        public static DescribeExecutionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeExecutionResponse describeExecutionResponse = new DescribeExecutionResponse();

			describeExecutionResponse.HttpResponse = _ctx.HttpResponse;
			describeExecutionResponse.Status = _ctx.StringValue("DescribeExecution.Status");
			describeExecutionResponse.StoppedTime = _ctx.StringValue("DescribeExecution.StoppedTime");
			describeExecutionResponse.RequestId = _ctx.StringValue("DescribeExecution.RequestId");
			describeExecutionResponse.StartedTime = _ctx.StringValue("DescribeExecution.StartedTime");
			describeExecutionResponse.FlowDefinition = _ctx.StringValue("DescribeExecution.FlowDefinition");
			describeExecutionResponse.ExternalInputUri = _ctx.StringValue("DescribeExecution.ExternalInputUri");
			describeExecutionResponse.Output = _ctx.StringValue("DescribeExecution.Output");
			describeExecutionResponse.FlowName = _ctx.StringValue("DescribeExecution.FlowName");
			describeExecutionResponse.ExternalOutputUri = _ctx.StringValue("DescribeExecution.ExternalOutputUri");
			describeExecutionResponse.Name = _ctx.StringValue("DescribeExecution.Name");
			describeExecutionResponse.Input = _ctx.StringValue("DescribeExecution.Input");
        
			return describeExecutionResponse;
        }
    }
}
