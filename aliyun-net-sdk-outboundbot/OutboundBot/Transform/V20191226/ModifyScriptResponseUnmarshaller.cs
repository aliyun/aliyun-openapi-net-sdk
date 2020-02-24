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
        public static ModifyScriptResponse Unmarshall(UnmarshallerContext context)
        {
			ModifyScriptResponse modifyScriptResponse = new ModifyScriptResponse();

			modifyScriptResponse.HttpResponse = context.HttpResponse;
			modifyScriptResponse.RequestId = context.StringValue("ModifyScript.RequestId");
			modifyScriptResponse.Success = context.BooleanValue("ModifyScript.Success");
			modifyScriptResponse.Code = context.StringValue("ModifyScript.Code");
			modifyScriptResponse.Message = context.StringValue("ModifyScript.Message");
			modifyScriptResponse.HttpStatusCode = context.IntegerValue("ModifyScript.HttpStatusCode");

			ModifyScriptResponse.ModifyScript_Script script = new ModifyScriptResponse.ModifyScript_Script();
			script.ScriptId = context.StringValue("ModifyScript.Script.ScriptId");
			script.ScriptName = context.StringValue("ModifyScript.Script.ScriptName");
			script.ScriptDescription = context.StringValue("ModifyScript.Script.ScriptDescription");
			script.Industry = context.StringValue("ModifyScript.Script.Industry");
			script.Scene = context.StringValue("ModifyScript.Script.Scene");
			script.Status = context.StringValue("ModifyScript.Script.Status");
			script.DebugStatus = context.StringValue("ModifyScript.Script.DebugStatus");
			script.UpdateTime = context.LongValue("ModifyScript.Script.UpdateTime");
			script.IsDrafted = context.BooleanValue("ModifyScript.Script.IsDrafted");
			script.IsDebugDrafted = context.BooleanValue("ModifyScript.Script.IsDebugDrafted");
			modifyScriptResponse.Script = script;
        
			return modifyScriptResponse;
        }
    }
}
