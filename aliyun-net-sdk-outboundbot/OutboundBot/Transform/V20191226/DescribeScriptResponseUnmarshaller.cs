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
    public class DescribeScriptResponseUnmarshaller
    {
        public static DescribeScriptResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeScriptResponse describeScriptResponse = new DescribeScriptResponse();

			describeScriptResponse.HttpResponse = _ctx.HttpResponse;
			describeScriptResponse.HttpStatusCode = _ctx.IntegerValue("DescribeScript.HttpStatusCode");
			describeScriptResponse.RequestId = _ctx.StringValue("DescribeScript.RequestId");
			describeScriptResponse.Success = _ctx.BooleanValue("DescribeScript.Success");
			describeScriptResponse.ChatbotId = _ctx.StringValue("DescribeScript.ChatbotId");
			describeScriptResponse.Code = _ctx.StringValue("DescribeScript.Code");
			describeScriptResponse.Message = _ctx.StringValue("DescribeScript.Message");
			describeScriptResponse.TtsConfig = _ctx.StringValue("DescribeScript.TtsConfig");
			describeScriptResponse.AsrConfig = _ctx.StringValue("DescribeScript.AsrConfig");
			describeScriptResponse.NlsConfig = _ctx.StringValue("DescribeScript.NlsConfig");

			DescribeScriptResponse.DescribeScript_Script script = new DescribeScriptResponse.DescribeScript_Script();
			script.Status = _ctx.StringValue("DescribeScript.Script.Status");
			script.UpdateTime = _ctx.LongValue("DescribeScript.Script.UpdateTime");
			script.ChatbotId = _ctx.StringValue("DescribeScript.Script.ChatbotId");
			script.ScriptId = _ctx.StringValue("DescribeScript.Script.ScriptId");
			script.IsDebugDrafted = _ctx.BooleanValue("DescribeScript.Script.IsDebugDrafted");
			script.Industry = _ctx.StringValue("DescribeScript.Script.Industry");
			script.ScriptDescription = _ctx.StringValue("DescribeScript.Script.ScriptDescription");
			script.MiniPlaybackEnable = _ctx.BooleanValue("DescribeScript.Script.MiniPlaybackEnable");
			script.IsDrafted = _ctx.BooleanValue("DescribeScript.Script.IsDrafted");
			script.TtsConfig = _ctx.StringValue("DescribeScript.Script.TtsConfig");
			script.DebugStatus = _ctx.StringValue("DescribeScript.Script.DebugStatus");
			script.AsrConfig = _ctx.StringValue("DescribeScript.Script.AsrConfig");
			script.Scene = _ctx.StringValue("DescribeScript.Script.Scene");
			script.ScriptName = _ctx.StringValue("DescribeScript.Script.ScriptName");
			script.NewBargeInEnable = _ctx.BooleanValue("DescribeScript.Script.NewBargeInEnable");
			script.LongWaitEnable = _ctx.BooleanValue("DescribeScript.Script.LongWaitEnable");
			describeScriptResponse.Script = script;
        
			return describeScriptResponse;
        }
    }
}
