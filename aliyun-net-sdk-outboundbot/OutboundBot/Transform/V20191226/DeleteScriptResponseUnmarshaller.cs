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
    public class DeleteScriptResponseUnmarshaller
    {
        public static DeleteScriptResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteScriptResponse deleteScriptResponse = new DeleteScriptResponse();

			deleteScriptResponse.HttpResponse = _ctx.HttpResponse;
			deleteScriptResponse.Code = _ctx.StringValue("DeleteScript.Code");
			deleteScriptResponse.HttpStatusCode = _ctx.IntegerValue("DeleteScript.HttpStatusCode");
			deleteScriptResponse.Message = _ctx.StringValue("DeleteScript.Message");
			deleteScriptResponse.RequestId = _ctx.StringValue("DeleteScript.RequestId");
			deleteScriptResponse.Success = _ctx.BooleanValue("DeleteScript.Success");
        
			return deleteScriptResponse;
        }
    }
}
