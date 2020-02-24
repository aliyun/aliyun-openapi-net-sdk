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
        public static QueryScriptsByStatusResponse Unmarshall(UnmarshallerContext context)
        {
			QueryScriptsByStatusResponse queryScriptsByStatusResponse = new QueryScriptsByStatusResponse();

			queryScriptsByStatusResponse.HttpResponse = context.HttpResponse;
			queryScriptsByStatusResponse.RequestId = context.StringValue("QueryScriptsByStatus.RequestId");
			queryScriptsByStatusResponse.Success = context.BooleanValue("QueryScriptsByStatus.Success");
			queryScriptsByStatusResponse.Code = context.StringValue("QueryScriptsByStatus.Code");
			queryScriptsByStatusResponse.Message = context.StringValue("QueryScriptsByStatus.Message");
			queryScriptsByStatusResponse.HttpStatusCode = context.IntegerValue("QueryScriptsByStatus.HttpStatusCode");

			QueryScriptsByStatusResponse.QueryScriptsByStatus_Scripts scripts = new QueryScriptsByStatusResponse.QueryScriptsByStatus_Scripts();
			scripts.TotalCount = context.IntegerValue("QueryScriptsByStatus.Scripts.TotalCount");
			scripts.PageNumber = context.IntegerValue("QueryScriptsByStatus.Scripts.PageNumber");
			scripts.PageSize = context.IntegerValue("QueryScriptsByStatus.Scripts.PageSize");

			List<QueryScriptsByStatusResponse.QueryScriptsByStatus_Scripts.QueryScriptsByStatus_Script> scripts_list = new List<QueryScriptsByStatusResponse.QueryScriptsByStatus_Scripts.QueryScriptsByStatus_Script>();
			for (int i = 0; i < context.Length("QueryScriptsByStatus.Scripts.List.Length"); i++) {
				QueryScriptsByStatusResponse.QueryScriptsByStatus_Scripts.QueryScriptsByStatus_Script script = new QueryScriptsByStatusResponse.QueryScriptsByStatus_Scripts.QueryScriptsByStatus_Script();
				script.ScriptId = context.StringValue("QueryScriptsByStatus.Scripts.List["+ i +"].ScriptId");
				script.ScriptName = context.StringValue("QueryScriptsByStatus.Scripts.List["+ i +"].ScriptName");
				script.ScriptDescription = context.StringValue("QueryScriptsByStatus.Scripts.List["+ i +"].ScriptDescription");
				script.Industry = context.StringValue("QueryScriptsByStatus.Scripts.List["+ i +"].Industry");
				script.Scene = context.StringValue("QueryScriptsByStatus.Scripts.List["+ i +"].Scene");
				script.Status = context.StringValue("QueryScriptsByStatus.Scripts.List["+ i +"].Status");
				script.DebugStatus = context.StringValue("QueryScriptsByStatus.Scripts.List["+ i +"].DebugStatus");
				script.DebugVersion = context.StringValue("QueryScriptsByStatus.Scripts.List["+ i +"].DebugVersion");
				script.AppliedVersion = context.StringValue("QueryScriptsByStatus.Scripts.List["+ i +"].AppliedVersion");
				script.UpdateTime = context.LongValue("QueryScriptsByStatus.Scripts.List["+ i +"].UpdateTime");
				script.IsDrafted = context.BooleanValue("QueryScriptsByStatus.Scripts.List["+ i +"].IsDrafted");
				script.IsDebugDrafted = context.BooleanValue("QueryScriptsByStatus.Scripts.List["+ i +"].IsDebugDrafted");

				scripts_list.Add(script);
			}
			scripts.List = scripts_list;
			queryScriptsByStatusResponse.Scripts = scripts;
        
			return queryScriptsByStatusResponse;
        }
    }
}
