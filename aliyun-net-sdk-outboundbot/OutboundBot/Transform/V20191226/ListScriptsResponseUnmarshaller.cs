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
        public static ListScriptsResponse Unmarshall(UnmarshallerContext context)
        {
			ListScriptsResponse listScriptsResponse = new ListScriptsResponse();

			listScriptsResponse.HttpResponse = context.HttpResponse;
			listScriptsResponse.RequestId = context.StringValue("ListScripts.RequestId");
			listScriptsResponse.Success = context.BooleanValue("ListScripts.Success");
			listScriptsResponse.Code = context.StringValue("ListScripts.Code");
			listScriptsResponse.Message = context.StringValue("ListScripts.Message");
			listScriptsResponse.HttpStatusCode = context.IntegerValue("ListScripts.HttpStatusCode");

			ListScriptsResponse.ListScripts_Scripts scripts = new ListScriptsResponse.ListScripts_Scripts();
			scripts.TotalCount = context.IntegerValue("ListScripts.Scripts.TotalCount");
			scripts.PageNumber = context.IntegerValue("ListScripts.Scripts.PageNumber");
			scripts.PageSize = context.IntegerValue("ListScripts.Scripts.PageSize");

			List<ListScriptsResponse.ListScripts_Scripts.ListScripts_Script> scripts_list = new List<ListScriptsResponse.ListScripts_Scripts.ListScripts_Script>();
			for (int i = 0; i < context.Length("ListScripts.Scripts.List.Length"); i++) {
				ListScriptsResponse.ListScripts_Scripts.ListScripts_Script script = new ListScriptsResponse.ListScripts_Scripts.ListScripts_Script();
				script.ScriptId = context.StringValue("ListScripts.Scripts.List["+ i +"].ScriptId");
				script.ScriptName = context.StringValue("ListScripts.Scripts.List["+ i +"].ScriptName");
				script.ScriptDescription = context.StringValue("ListScripts.Scripts.List["+ i +"].ScriptDescription");
				script.Industry = context.StringValue("ListScripts.Scripts.List["+ i +"].Industry");
				script.Scene = context.StringValue("ListScripts.Scripts.List["+ i +"].Scene");
				script.Status = context.StringValue("ListScripts.Scripts.List["+ i +"].Status");
				script.DebugStatus = context.StringValue("ListScripts.Scripts.List["+ i +"].DebugStatus");
				script.UpdateTime = context.LongValue("ListScripts.Scripts.List["+ i +"].UpdateTime");
				script.IsDrafted = context.BooleanValue("ListScripts.Scripts.List["+ i +"].IsDrafted");
				script.IsDebugDrafted = context.BooleanValue("ListScripts.Scripts.List["+ i +"].IsDebugDrafted");
				script.FailReason = context.StringValue("ListScripts.Scripts.List["+ i +"].FailReason");

				scripts_list.Add(script);
			}
			scripts.List = scripts_list;
			listScriptsResponse.Scripts = scripts;
        
			return listScriptsResponse;
        }
    }
}
