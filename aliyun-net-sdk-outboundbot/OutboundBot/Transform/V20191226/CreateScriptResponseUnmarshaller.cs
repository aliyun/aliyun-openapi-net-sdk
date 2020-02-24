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
        public static CreateScriptResponse Unmarshall(UnmarshallerContext context)
        {
			CreateScriptResponse createScriptResponse = new CreateScriptResponse();

			createScriptResponse.HttpResponse = context.HttpResponse;
			createScriptResponse.RequestId = context.StringValue("CreateScript.RequestId");
			createScriptResponse.Success = context.BooleanValue("CreateScript.Success");
			createScriptResponse.Code = context.StringValue("CreateScript.Code");
			createScriptResponse.Message = context.StringValue("CreateScript.Message");
			createScriptResponse.HttpStatusCode = context.IntegerValue("CreateScript.HttpStatusCode");

			CreateScriptResponse.CreateScript_Script script = new CreateScriptResponse.CreateScript_Script();
			script.ScriptId = context.StringValue("CreateScript.Script.ScriptId");
			script.ScriptName = context.StringValue("CreateScript.Script.ScriptName");
			script.ScriptDescription = context.StringValue("CreateScript.Script.ScriptDescription");
			script.Industry = context.StringValue("CreateScript.Script.Industry");
			script.Scene = context.StringValue("CreateScript.Script.Scene");
			script.Status = context.StringValue("CreateScript.Script.Status");
			script.DebugStatus = context.StringValue("CreateScript.Script.DebugStatus");
			script.UpdateTime = context.LongValue("CreateScript.Script.UpdateTime");
			script.IsDrafted = context.BooleanValue("CreateScript.Script.IsDrafted");
			script.IsDebugDrafted = context.BooleanValue("CreateScript.Script.IsDebugDrafted");
			createScriptResponse.Script = script;
        
			return createScriptResponse;
        }
    }
}
