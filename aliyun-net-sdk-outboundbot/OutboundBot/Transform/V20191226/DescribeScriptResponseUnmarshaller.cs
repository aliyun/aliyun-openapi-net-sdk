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
        public static DescribeScriptResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeScriptResponse describeScriptResponse = new DescribeScriptResponse();

			describeScriptResponse.HttpResponse = context.HttpResponse;
			describeScriptResponse.RequestId = context.StringValue("DescribeScript.RequestId");
			describeScriptResponse.Success = context.BooleanValue("DescribeScript.Success");
			describeScriptResponse.Code = context.StringValue("DescribeScript.Code");
			describeScriptResponse.Message = context.StringValue("DescribeScript.Message");
			describeScriptResponse.HttpStatusCode = context.IntegerValue("DescribeScript.HttpStatusCode");

			DescribeScriptResponse.DescribeScript_Script script = new DescribeScriptResponse.DescribeScript_Script();
			script.ScriptId = context.StringValue("DescribeScript.Script.ScriptId");
			script.ScriptName = context.StringValue("DescribeScript.Script.ScriptName");
			script.ScriptDescription = context.StringValue("DescribeScript.Script.ScriptDescription");
			script.Industry = context.StringValue("DescribeScript.Script.Industry");
			script.Scene = context.StringValue("DescribeScript.Script.Scene");
			script.Status = context.StringValue("DescribeScript.Script.Status");
			script.DebugStatus = context.StringValue("DescribeScript.Script.DebugStatus");
			script.UpdateTime = context.LongValue("DescribeScript.Script.UpdateTime");
			script.IsDrafted = context.BooleanValue("DescribeScript.Script.IsDrafted");
			script.IsDebugDrafted = context.BooleanValue("DescribeScript.Script.IsDebugDrafted");
			describeScriptResponse.Script = script;
        
			return describeScriptResponse;
        }
    }
}
