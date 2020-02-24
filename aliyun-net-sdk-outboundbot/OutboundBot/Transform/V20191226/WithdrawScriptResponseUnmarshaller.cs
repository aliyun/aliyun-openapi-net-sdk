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
    public class WithdrawScriptResponseUnmarshaller
    {
        public static WithdrawScriptResponse Unmarshall(UnmarshallerContext context)
        {
			WithdrawScriptResponse withdrawScriptResponse = new WithdrawScriptResponse();

			withdrawScriptResponse.HttpResponse = context.HttpResponse;
			withdrawScriptResponse.Code = context.StringValue("WithdrawScript.Code");
			withdrawScriptResponse.HttpStatusCode = context.IntegerValue("WithdrawScript.HttpStatusCode");
			withdrawScriptResponse.Message = context.StringValue("WithdrawScript.Message");
			withdrawScriptResponse.RequestId = context.StringValue("WithdrawScript.RequestId");
			withdrawScriptResponse.Success = context.BooleanValue("WithdrawScript.Success");

			WithdrawScriptResponse.WithdrawScript_Script script = new WithdrawScriptResponse.WithdrawScript_Script();
			script.DebugStatus = context.StringValue("WithdrawScript.Script.DebugStatus");
			script.Industry = context.StringValue("WithdrawScript.Script.Industry");
			script.IsDebugDrafted = context.BooleanValue("WithdrawScript.Script.IsDebugDrafted");
			script.IsDrafted = context.BooleanValue("WithdrawScript.Script.IsDrafted");
			script.Scene = context.StringValue("WithdrawScript.Script.Scene");
			script.ScriptDescription = context.StringValue("WithdrawScript.Script.ScriptDescription");
			script.ScriptId = context.StringValue("WithdrawScript.Script.ScriptId");
			script.ScriptName = context.StringValue("WithdrawScript.Script.ScriptName");
			script.Status = context.StringValue("WithdrawScript.Script.Status");
			script.UpdateTime = context.LongValue("WithdrawScript.Script.UpdateTime");
			withdrawScriptResponse.Script = script;
        
			return withdrawScriptResponse;
        }
    }
}
