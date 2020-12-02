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
    public class ModifyScriptResponseUnmarshaller
    {
        public static ModifyScriptResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifyScriptResponse modifyScriptResponse = new ModifyScriptResponse();

			modifyScriptResponse.HttpResponse = _ctx.HttpResponse;
			modifyScriptResponse.Code = _ctx.StringValue("ModifyScript.Code");
			modifyScriptResponse.HttpStatusCode = _ctx.IntegerValue("ModifyScript.HttpStatusCode");
			modifyScriptResponse.Message = _ctx.StringValue("ModifyScript.Message");
			modifyScriptResponse.RequestId = _ctx.StringValue("ModifyScript.RequestId");
			modifyScriptResponse.Success = _ctx.BooleanValue("ModifyScript.Success");
			modifyScriptResponse.ChatbotId = _ctx.StringValue("ModifyScript.ChatbotId");

			ModifyScriptResponse.ModifyScript_Script script = new ModifyScriptResponse.ModifyScript_Script();
			script.DebugStatus = _ctx.StringValue("ModifyScript.Script.DebugStatus");
			script.Industry = _ctx.StringValue("ModifyScript.Script.Industry");
			script.IsDebugDrafted = _ctx.BooleanValue("ModifyScript.Script.IsDebugDrafted");
			script.IsDrafted = _ctx.BooleanValue("ModifyScript.Script.IsDrafted");
			script.Scene = _ctx.StringValue("ModifyScript.Script.Scene");
			script.ScriptDescription = _ctx.StringValue("ModifyScript.Script.ScriptDescription");
			script.ScriptId = _ctx.StringValue("ModifyScript.Script.ScriptId");
			script.ScriptName = _ctx.StringValue("ModifyScript.Script.ScriptName");
			script.Status = _ctx.StringValue("ModifyScript.Script.Status");
			script.UpdateTime = _ctx.LongValue("ModifyScript.Script.UpdateTime");
			modifyScriptResponse.Script = script;
        
			return modifyScriptResponse;
        }
    }
}
