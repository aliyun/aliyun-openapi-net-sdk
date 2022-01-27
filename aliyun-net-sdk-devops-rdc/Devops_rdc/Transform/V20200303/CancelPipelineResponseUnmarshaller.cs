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
    public class CancelPipelineResponseUnmarshaller
    {
        public static CancelPipelineResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CancelPipelineResponse cancelPipelineResponse = new CancelPipelineResponse();

			cancelPipelineResponse.HttpResponse = _ctx.HttpResponse;
			cancelPipelineResponse.RequestId = _ctx.StringValue("CancelPipeline.RequestId");
			cancelPipelineResponse.ErrorMessage = _ctx.StringValue("CancelPipeline.ErrorMessage");
			cancelPipelineResponse._Object = _ctx.BooleanValue("CancelPipeline.Object");
			cancelPipelineResponse.ErrorCode = _ctx.StringValue("CancelPipeline.ErrorCode");
			cancelPipelineResponse.Success = _ctx.BooleanValue("CancelPipeline.Success");
        
			return cancelPipelineResponse;
        }
    }
}
