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
using Aliyun.Acs.devops_rdc.Model.V20200303;

namespace Aliyun.Acs.devops_rdc.Transform.V20200303
{
    public class ExecutePipelineResponseUnmarshaller
    {
        public static ExecutePipelineResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ExecutePipelineResponse executePipelineResponse = new ExecutePipelineResponse();

			executePipelineResponse.HttpResponse = _ctx.HttpResponse;
			executePipelineResponse.RequestId = _ctx.StringValue("ExecutePipeline.RequestId");
			executePipelineResponse.ErrorMessage = _ctx.StringValue("ExecutePipeline.ErrorMessage");
			executePipelineResponse._Object = _ctx.LongValue("ExecutePipeline.Object");
			executePipelineResponse.Success = _ctx.BooleanValue("ExecutePipeline.Success");
			executePipelineResponse.ErrorCode = _ctx.StringValue("ExecutePipeline.ErrorCode");
        
			return executePipelineResponse;
        }
    }
}
