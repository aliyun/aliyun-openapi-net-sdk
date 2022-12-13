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
    public class ExecJobResponseUnmarshaller
    {
        public static ExecJobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ExecJobResponse execJobResponse = new ExecJobResponse();

			execJobResponse.HttpResponse = _ctx.HttpResponse;
			execJobResponse.RequestId = _ctx.StringValue("ExecJob.RequestId");
			execJobResponse.Message = _ctx.StringValue("ExecJob.Message");
			execJobResponse.TraceId = _ctx.StringValue("ExecJob.TraceId");
			execJobResponse.ErrorCode = _ctx.StringValue("ExecJob.ErrorCode");
			execJobResponse.Code = _ctx.StringValue("ExecJob.Code");
			execJobResponse.Success = _ctx.BooleanValue("ExecJob.Success");

			ExecJobResponse.ExecJob_Data data = new ExecJobResponse.ExecJob_Data();
			data.Data = _ctx.StringValue("ExecJob.Data.Data");
			data.Msg = _ctx.StringValue("ExecJob.Data.Msg");
			data.Success = _ctx.StringValue("ExecJob.Data.Success");
			data.Code = _ctx.StringValue("ExecJob.Data.Code");
			execJobResponse.Data = data;
        
			return execJobResponse;
        }
    }
}
