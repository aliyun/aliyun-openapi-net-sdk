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
using Aliyun.Acs.OpenSearch.Model.V20171225;

namespace Aliyun.Acs.OpenSearch.Transform.V20171225
{
    public class ListSortScriptsResponseUnmarshaller
    {
        public static ListSortScriptsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSortScriptsResponse listSortScriptsResponse = new ListSortScriptsResponse();

			listSortScriptsResponse.HttpResponse = _ctx.HttpResponse;
			listSortScriptsResponse.RequestId = _ctx.StringValue("ListSortScripts.requestId");

			List<ListSortScriptsResponse.ListSortScripts_ScriptInfo> listSortScriptsResponse_result = new List<ListSortScriptsResponse.ListSortScripts_ScriptInfo>();
			for (int i = 0; i < _ctx.Length("ListSortScripts.Result.Length"); i++) {
				ListSortScriptsResponse.ListSortScripts_ScriptInfo scriptInfo = new ListSortScriptsResponse.ListSortScripts_ScriptInfo();
				scriptInfo.ScriptName = _ctx.StringValue("ListSortScripts.Result["+ i +"].scriptName");
				scriptInfo.Type = _ctx.StringValue("ListSortScripts.Result["+ i +"].type");
				scriptInfo.Scope = _ctx.StringValue("ListSortScripts.Result["+ i +"].scope");
				scriptInfo.Status = _ctx.StringValue("ListSortScripts.Result["+ i +"].status");
				scriptInfo.CreateTime = _ctx.StringValue("ListSortScripts.Result["+ i +"].createTime");
				scriptInfo.ModifyTime = _ctx.StringValue("ListSortScripts.Result["+ i +"].modifyTime");

				listSortScriptsResponse_result.Add(scriptInfo);
			}
			listSortScriptsResponse.Result = listSortScriptsResponse_result;
        
			return listSortScriptsResponse;
        }
    }
}
