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
using Aliyun.Acs.viapi.Model.V20230117;

namespace Aliyun.Acs.viapi.Transform.V20230117
{
    public class CancelWaitingAsyncJobResponseUnmarshaller
    {
        public static CancelWaitingAsyncJobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CancelWaitingAsyncJobResponse cancelWaitingAsyncJobResponse = new CancelWaitingAsyncJobResponse();

			cancelWaitingAsyncJobResponse.HttpResponse = _ctx.HttpResponse;
			cancelWaitingAsyncJobResponse.RequestId = _ctx.StringValue("CancelWaitingAsyncJob.RequestId");
			cancelWaitingAsyncJobResponse.Message = _ctx.StringValue("CancelWaitingAsyncJob.Message");
			cancelWaitingAsyncJobResponse.Success = _ctx.BooleanValue("CancelWaitingAsyncJob.Success");
			cancelWaitingAsyncJobResponse.HttpCode = _ctx.StringValue("CancelWaitingAsyncJob.HttpCode");
        
			return cancelWaitingAsyncJobResponse;
        }
    }
}
