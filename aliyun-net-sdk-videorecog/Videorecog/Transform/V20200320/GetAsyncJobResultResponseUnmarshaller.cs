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
using Aliyun.Acs.videorecog.Model.V20200320;

namespace Aliyun.Acs.videorecog.Transform.V20200320
{
    public class GetAsyncJobResultResponseUnmarshaller
    {
        public static GetAsyncJobResultResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetAsyncJobResultResponse getAsyncJobResultResponse = new GetAsyncJobResultResponse();

			getAsyncJobResultResponse.HttpResponse = _ctx.HttpResponse;
			getAsyncJobResultResponse.RequestId = _ctx.StringValue("GetAsyncJobResult.RequestId");

			GetAsyncJobResultResponse.GetAsyncJobResult_Data data = new GetAsyncJobResultResponse.GetAsyncJobResult_Data();
			data.Status = _ctx.StringValue("GetAsyncJobResult.Data.Status");
			data.ErrorCode = _ctx.StringValue("GetAsyncJobResult.Data.ErrorCode");
			data.ErrorMessage = _ctx.StringValue("GetAsyncJobResult.Data.ErrorMessage");
			data.JobId = _ctx.StringValue("GetAsyncJobResult.Data.JobId");
			data.Result = _ctx.StringValue("GetAsyncJobResult.Data.Result");
			getAsyncJobResultResponse.Data = data;
        
			return getAsyncJobResultResponse;
        }
    }
}
