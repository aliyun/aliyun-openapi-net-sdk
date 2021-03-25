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
using Aliyun.Acs.sae.Model.V20190506;

namespace Aliyun.Acs.sae.Transform.V20190506
{
    public class ConfirmPipelineBatchResponseUnmarshaller
    {
        public static ConfirmPipelineBatchResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ConfirmPipelineBatchResponse confirmPipelineBatchResponse = new ConfirmPipelineBatchResponse();

			confirmPipelineBatchResponse.HttpResponse = _ctx.HttpResponse;
			confirmPipelineBatchResponse.Code = _ctx.StringValue("ConfirmPipelineBatch.Code");
			confirmPipelineBatchResponse.ErrorCode = _ctx.StringValue("ConfirmPipelineBatch.ErrorCode");
			confirmPipelineBatchResponse.Message = _ctx.StringValue("ConfirmPipelineBatch.Message");
			confirmPipelineBatchResponse.Success = _ctx.BooleanValue("ConfirmPipelineBatch.Success");
			confirmPipelineBatchResponse.TraceId = _ctx.StringValue("ConfirmPipelineBatch.TraceId");
			confirmPipelineBatchResponse.RequestId = _ctx.StringValue("ConfirmPipelineBatch.RequestId");

			ConfirmPipelineBatchResponse.ConfirmPipelineBatch_Data data = new ConfirmPipelineBatchResponse.ConfirmPipelineBatch_Data();
			data.PipelineId = _ctx.StringValue("ConfirmPipelineBatch.Data.PipelineId");
			confirmPipelineBatchResponse.Data = data;
        
			return confirmPipelineBatchResponse;
        }
    }
}
