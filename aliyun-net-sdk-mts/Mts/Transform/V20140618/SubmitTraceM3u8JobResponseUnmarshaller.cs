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
    public class SubmitTraceM3u8JobResponseUnmarshaller
    {
        public static SubmitTraceM3u8JobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SubmitTraceM3u8JobResponse submitTraceM3u8JobResponse = new SubmitTraceM3u8JobResponse();

			submitTraceM3u8JobResponse.HttpResponse = _ctx.HttpResponse;
			submitTraceM3u8JobResponse.RequestId = _ctx.StringValue("SubmitTraceM3u8Job.RequestId");
			submitTraceM3u8JobResponse.Message = _ctx.StringValue("SubmitTraceM3u8Job.Message");

			SubmitTraceM3u8JobResponse.SubmitTraceM3u8Job_Data data = new SubmitTraceM3u8JobResponse.SubmitTraceM3u8Job_Data();
			data.JobId = _ctx.StringValue("SubmitTraceM3u8Job.Data.JobId");
			submitTraceM3u8JobResponse.Data = data;
        
			return submitTraceM3u8JobResponse;
        }
    }
}
