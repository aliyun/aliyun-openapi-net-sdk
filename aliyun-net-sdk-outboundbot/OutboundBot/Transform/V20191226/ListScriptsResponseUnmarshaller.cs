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
    public class ListScriptsResponseUnmarshaller
    {
        public static ListScriptsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListScriptsResponse listScriptsResponse = new ListScriptsResponse();

			listScriptsResponse.HttpResponse = _ctx.HttpResponse;
			listScriptsResponse.HttpStatusCode = _ctx.IntegerValue("ListScripts.HttpStatusCode");
			listScriptsResponse.Code = _ctx.StringValue("ListScripts.Code");
			listScriptsResponse.Message = _ctx.StringValue("ListScripts.Message");
			listScriptsResponse.RequestId = _ctx.StringValue("ListScripts.RequestId");
			listScriptsResponse.Success = _ctx.BooleanValue("ListScripts.Success");

			ListScriptsResponse.ListScripts_Scripts scripts = new ListScriptsResponse.ListScripts_Scripts();
			scripts.PageNumber = _ctx.IntegerValue("ListScripts.Scripts.PageNumber");
			scripts.PageSize = _ctx.IntegerValue("ListScripts.Scripts.PageSize");
			scripts.TotalCount = _ctx.IntegerValue("ListScripts.Scripts.TotalCount");

			List<ListScriptsResponse.ListScripts_Scripts.ListScripts_Script> scripts_list = new List<ListScriptsResponse.ListScripts_Scripts.ListScripts_Script>();
			for (int i = 0; i < _ctx.Length("ListScripts.Scripts.List.Length"); i++) {
				ListScriptsResponse.ListScripts_Scripts.ListScripts_Script script = new ListScriptsResponse.ListScripts_Scripts.ListScripts_Script();
				script.Status = _ctx.StringValue("ListScripts.Scripts.List["+ i +"].Status");
				script.UpdateTime = _ctx.LongValue("ListScripts.Scripts.List["+ i +"].UpdateTime");
				script.ScriptId = _ctx.StringValue("ListScripts.Scripts.List["+ i +"].ScriptId");
				script.IsDebugDrafted = _ctx.BooleanValue("ListScripts.Scripts.List["+ i +"].IsDebugDrafted");
				script.Industry = _ctx.StringValue("ListScripts.Scripts.List["+ i +"].Industry");
				script.ScriptDescription = _ctx.StringValue("ListScripts.Scripts.List["+ i +"].ScriptDescription");
				script.IsDrafted = _ctx.BooleanValue("ListScripts.Scripts.List["+ i +"].IsDrafted");
				script.DebugStatus = _ctx.StringValue("ListScripts.Scripts.List["+ i +"].DebugStatus");
				script.MiniPlaybackEnable = _ctx.BooleanValue("ListScripts.Scripts.List["+ i +"].MiniPlaybackEnable");
				script.RejectReason = _ctx.StringValue("ListScripts.Scripts.List["+ i +"].RejectReason");
				script.FailReason = _ctx.StringValue("ListScripts.Scripts.List["+ i +"].FailReason");
				script.Scene = _ctx.StringValue("ListScripts.Scripts.List["+ i +"].Scene");
				script.ScriptName = _ctx.StringValue("ListScripts.Scripts.List["+ i +"].ScriptName");
				script.NewBargeInEnable = _ctx.BooleanValue("ListScripts.Scripts.List["+ i +"].NewBargeInEnable");
				script.LongWaitEnable = _ctx.BooleanValue("ListScripts.Scripts.List["+ i +"].LongWaitEnable");
				script.EmotionEnable = _ctx.BooleanValue("ListScripts.Scripts.List["+ i +"].EmotionEnable");
				script.IsPreset = _ctx.BooleanValue("ListScripts.Scripts.List["+ i +"].IsPreset");

				scripts_list.Add(script);
			}
			scripts.List = scripts_list;
			listScriptsResponse.Scripts = scripts;
        
			return listScriptsResponse;
        }
    }
}
