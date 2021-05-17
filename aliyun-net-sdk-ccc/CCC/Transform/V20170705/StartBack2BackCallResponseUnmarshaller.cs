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
using Aliyun.Acs.CCC.Model.V20170705;

namespace Aliyun.Acs.CCC.Transform.V20170705
{
    public class StartBack2BackCallResponseUnmarshaller
    {
        public static StartBack2BackCallResponse Unmarshall(UnmarshallerContext _ctx)
        {
			StartBack2BackCallResponse startBack2BackCallResponse = new StartBack2BackCallResponse();

			startBack2BackCallResponse.HttpResponse = _ctx.HttpResponse;
			startBack2BackCallResponse.RequestId = _ctx.StringValue("StartBack2BackCall.RequestId");
			startBack2BackCallResponse.Success = _ctx.BooleanValue("StartBack2BackCall.Success");
			startBack2BackCallResponse.Code = _ctx.StringValue("StartBack2BackCall.Code");
			startBack2BackCallResponse.Message = _ctx.StringValue("StartBack2BackCall.Message");
			startBack2BackCallResponse.HttpStatusCode = _ctx.IntegerValue("StartBack2BackCall.HttpStatusCode");
			startBack2BackCallResponse.StatusCode = _ctx.StringValue("StartBack2BackCall.StatusCode");
			startBack2BackCallResponse.StatusDesc = _ctx.StringValue("StartBack2BackCall.StatusDesc");
			startBack2BackCallResponse.TaskId = _ctx.StringValue("StartBack2BackCall.TaskId");
			startBack2BackCallResponse.TimeStamp = _ctx.StringValue("StartBack2BackCall.TimeStamp");
        
			return startBack2BackCallResponse;
        }
    }
}
