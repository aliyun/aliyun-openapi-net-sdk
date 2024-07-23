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
using Aliyun.Acs.Mts.Model.V20140618;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class SubmitTraceAbJobResponseUnmarshaller
    {
        public static SubmitTraceAbJobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SubmitTraceAbJobResponse submitTraceAbJobResponse = new SubmitTraceAbJobResponse();

			submitTraceAbJobResponse.HttpResponse = _ctx.HttpResponse;
			submitTraceAbJobResponse.RequestId = _ctx.StringValue("SubmitTraceAbJob.RequestId");
			submitTraceAbJobResponse.Message = _ctx.StringValue("SubmitTraceAbJob.Message");
			submitTraceAbJobResponse.StatusCode = _ctx.LongValue("SubmitTraceAbJob.StatusCode");

			SubmitTraceAbJobResponse.SubmitTraceAbJob_Data data = new SubmitTraceAbJobResponse.SubmitTraceAbJob_Data();
			data.JobId = _ctx.StringValue("SubmitTraceAbJob.Data.JobId");
			data.MediaId = _ctx.StringValue("SubmitTraceAbJob.Data.MediaId");
			submitTraceAbJobResponse.Data = data;
        
			return submitTraceAbJobResponse;
        }
    }
}
