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
    public class CreateScriptResponseUnmarshaller
    {
        public static CreateScriptResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateScriptResponse createScriptResponse = new CreateScriptResponse();

			createScriptResponse.HttpResponse = _ctx.HttpResponse;
			createScriptResponse.Code = _ctx.StringValue("CreateScript.Code");
			createScriptResponse.HttpStatusCode = _ctx.IntegerValue("CreateScript.HttpStatusCode");
			createScriptResponse.Message = _ctx.StringValue("CreateScript.Message");
			createScriptResponse.RequestId = _ctx.StringValue("CreateScript.RequestId");
			createScriptResponse.Success = _ctx.BooleanValue("CreateScript.Success");
			createScriptResponse.ChatbotId = _ctx.StringValue("CreateScript.ChatbotId");

			CreateScriptResponse.CreateScript_Script script = new CreateScriptResponse.CreateScript_Script();
			script.DebugStatus = _ctx.StringValue("CreateScript.Script.DebugStatus");
			script.Industry = _ctx.StringValue("CreateScript.Script.Industry");
			script.IsDebugDrafted = _ctx.BooleanValue("CreateScript.Script.IsDebugDrafted");
			script.IsDrafted = _ctx.BooleanValue("CreateScript.Script.IsDrafted");
			script.Scene = _ctx.StringValue("CreateScript.Script.Scene");
			script.ScriptDescription = _ctx.StringValue("CreateScript.Script.ScriptDescription");
			script.ScriptId = _ctx.StringValue("CreateScript.Script.ScriptId");
			script.ScriptName = _ctx.StringValue("CreateScript.Script.ScriptName");
			script.Status = _ctx.StringValue("CreateScript.Script.Status");
			script.UpdateTime = _ctx.LongValue("CreateScript.Script.UpdateTime");
			createScriptResponse.Script = script;
        
			return createScriptResponse;
        }
    }
}
