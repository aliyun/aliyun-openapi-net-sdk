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
using Aliyun.Acs.OutboundBot.Model.V20191226;

namespace Aliyun.Acs.OutboundBot.Transform.V20191226
{
    public class SuspendCallWithFileResponseUnmarshaller
    {
        public static SuspendCallWithFileResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SuspendCallWithFileResponse suspendCallWithFileResponse = new SuspendCallWithFileResponse();

			suspendCallWithFileResponse.HttpResponse = _ctx.HttpResponse;
			suspendCallWithFileResponse.RequestId = _ctx.StringValue("SuspendCallWithFile.RequestId");
			suspendCallWithFileResponse.Success = _ctx.BooleanValue("SuspendCallWithFile.Success");
			suspendCallWithFileResponse.Code = _ctx.StringValue("SuspendCallWithFile.Code");
			suspendCallWithFileResponse.Message = _ctx.StringValue("SuspendCallWithFile.Message");
			suspendCallWithFileResponse.HttpStatusCode = _ctx.IntegerValue("SuspendCallWithFile.HttpStatusCode");
        
			return suspendCallWithFileResponse;
        }
    }
}
