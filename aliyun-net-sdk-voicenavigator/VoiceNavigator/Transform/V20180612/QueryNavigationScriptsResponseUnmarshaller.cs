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
using Aliyun.Acs.VoiceNavigator.Model.V20180612;

namespace Aliyun.Acs.VoiceNavigator.Transform.V20180612
{
    public class QueryNavigationScriptsResponseUnmarshaller
    {
        public static QueryNavigationScriptsResponse Unmarshall(UnmarshallerContext context)
        {
			QueryNavigationScriptsResponse queryNavigationScriptsResponse = new QueryNavigationScriptsResponse();

			queryNavigationScriptsResponse.HttpResponse = context.HttpResponse;
			queryNavigationScriptsResponse.RequestId = context.StringValue("QueryNavigationScripts.RequestId");
			queryNavigationScriptsResponse.TotalCount = context.LongValue("QueryNavigationScripts.TotalCount");
			queryNavigationScriptsResponse.PageNumber = context.IntegerValue("QueryNavigationScripts.PageNumber");
			queryNavigationScriptsResponse.PageSize = context.IntegerValue("QueryNavigationScripts.PageSize");

			List<QueryNavigationScriptsResponse.QueryNavigationScripts_NavigationScript> queryNavigationScriptsResponse_navigationScripts = new List<QueryNavigationScriptsResponse.QueryNavigationScripts_NavigationScript>();
			for (int i = 0; i < context.Length("QueryNavigationScripts.NavigationScripts.Length"); i++) {
				QueryNavigationScriptsResponse.QueryNavigationScripts_NavigationScript navigationScript = new QueryNavigationScriptsResponse.QueryNavigationScripts_NavigationScript();
				navigationScript.NavigationScriptId = context.StringValue("QueryNavigationScripts.NavigationScripts["+ i +"].NavigationScriptId");
				navigationScript.Title = context.StringValue("QueryNavigationScripts.NavigationScripts["+ i +"].Title");
				navigationScript.ModifyTime = context.LongValue("QueryNavigationScripts.NavigationScripts["+ i +"].ModifyTime");
				navigationScript.Type = context.StringValue("QueryNavigationScripts.NavigationScripts["+ i +"].Type");

				queryNavigationScriptsResponse_navigationScripts.Add(navigationScript);
			}
			queryNavigationScriptsResponse.NavigationScripts = queryNavigationScriptsResponse_navigationScripts;
        
			return queryNavigationScriptsResponse;
        }
    }
}
