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
    public class QueryScriptsByStatusResponseUnmarshaller
    {
        public static QueryScriptsByStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryScriptsByStatusResponse queryScriptsByStatusResponse = new QueryScriptsByStatusResponse();

			queryScriptsByStatusResponse.HttpResponse = _ctx.HttpResponse;
			queryScriptsByStatusResponse.Code = _ctx.StringValue("QueryScriptsByStatus.Code");
			queryScriptsByStatusResponse.HttpStatusCode = _ctx.IntegerValue("QueryScriptsByStatus.HttpStatusCode");
			queryScriptsByStatusResponse.Message = _ctx.StringValue("QueryScriptsByStatus.Message");
			queryScriptsByStatusResponse.RequestId = _ctx.StringValue("QueryScriptsByStatus.RequestId");
			queryScriptsByStatusResponse.Success = _ctx.BooleanValue("QueryScriptsByStatus.Success");

			QueryScriptsByStatusResponse.QueryScriptsByStatus_Scripts scripts = new QueryScriptsByStatusResponse.QueryScriptsByStatus_Scripts();
			scripts.PageNumber = _ctx.IntegerValue("QueryScriptsByStatus.Scripts.PageNumber");
			scripts.PageSize = _ctx.IntegerValue("QueryScriptsByStatus.Scripts.PageSize");
			scripts.TotalCount = _ctx.IntegerValue("QueryScriptsByStatus.Scripts.TotalCount");

			List<QueryScriptsByStatusResponse.QueryScriptsByStatus_Scripts.QueryScriptsByStatus_Script> scripts_list = new List<QueryScriptsByStatusResponse.QueryScriptsByStatus_Scripts.QueryScriptsByStatus_Script>();
			for (int i = 0; i < _ctx.Length("QueryScriptsByStatus.Scripts.List.Length"); i++) {
				QueryScriptsByStatusResponse.QueryScriptsByStatus_Scripts.QueryScriptsByStatus_Script script = new QueryScriptsByStatusResponse.QueryScriptsByStatus_Scripts.QueryScriptsByStatus_Script();
				script.AppliedVersion = _ctx.StringValue("QueryScriptsByStatus.Scripts.List["+ i +"].AppliedVersion");
				script.DebugStatus = _ctx.StringValue("QueryScriptsByStatus.Scripts.List["+ i +"].DebugStatus");
				script.DebugVersion = _ctx.StringValue("QueryScriptsByStatus.Scripts.List["+ i +"].DebugVersion");
				script.Industry = _ctx.StringValue("QueryScriptsByStatus.Scripts.List["+ i +"].Industry");
				script.IsDebugDrafted = _ctx.BooleanValue("QueryScriptsByStatus.Scripts.List["+ i +"].IsDebugDrafted");
				script.IsDrafted = _ctx.BooleanValue("QueryScriptsByStatus.Scripts.List["+ i +"].IsDrafted");
				script.Scene = _ctx.StringValue("QueryScriptsByStatus.Scripts.List["+ i +"].Scene");
				script.ScriptDescription = _ctx.StringValue("QueryScriptsByStatus.Scripts.List["+ i +"].ScriptDescription");
				script.ScriptId = _ctx.StringValue("QueryScriptsByStatus.Scripts.List["+ i +"].ScriptId");
				script.ScriptName = _ctx.StringValue("QueryScriptsByStatus.Scripts.List["+ i +"].ScriptName");
				script.Status = _ctx.StringValue("QueryScriptsByStatus.Scripts.List["+ i +"].Status");
				script.UpdateTime = _ctx.LongValue("QueryScriptsByStatus.Scripts.List["+ i +"].UpdateTime");

				scripts_list.Add(script);
			}
			scripts.List = scripts_list;
			queryScriptsByStatusResponse.Scripts = scripts;
        
			return queryScriptsByStatusResponse;
        }
    }
}
