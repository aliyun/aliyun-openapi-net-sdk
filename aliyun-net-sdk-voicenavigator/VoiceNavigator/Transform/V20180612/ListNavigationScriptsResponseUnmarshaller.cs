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
    public class ListNavigationScriptsResponseUnmarshaller
    {
        public static ListNavigationScriptsResponse Unmarshall(UnmarshallerContext context)
        {
			ListNavigationScriptsResponse listNavigationScriptsResponse = new ListNavigationScriptsResponse();

			listNavigationScriptsResponse.HttpResponse = context.HttpResponse;
			listNavigationScriptsResponse.RequestId = context.StringValue("ListNavigationScripts.RequestId");
			listNavigationScriptsResponse.TotalCount = context.LongValue("ListNavigationScripts.TotalCount");
			listNavigationScriptsResponse.PageNumber = context.IntegerValue("ListNavigationScripts.PageNumber");
			listNavigationScriptsResponse.PageSize = context.IntegerValue("ListNavigationScripts.PageSize");

			List<ListNavigationScriptsResponse.ListNavigationScripts_NavigationScript> listNavigationScriptsResponse_navigationScripts = new List<ListNavigationScriptsResponse.ListNavigationScripts_NavigationScript>();
			for (int i = 0; i < context.Length("ListNavigationScripts.NavigationScripts.Length"); i++) {
				ListNavigationScriptsResponse.ListNavigationScripts_NavigationScript navigationScript = new ListNavigationScriptsResponse.ListNavigationScripts_NavigationScript();
				navigationScript.NavigationScriptId = context.StringValue("ListNavigationScripts.NavigationScripts["+ i +"].NavigationScriptId");
				navigationScript.Title = context.StringValue("ListNavigationScripts.NavigationScripts["+ i +"].Title");
				navigationScript.ModifyTime = context.LongValue("ListNavigationScripts.NavigationScripts["+ i +"].ModifyTime");
				navigationScript.Type = context.StringValue("ListNavigationScripts.NavigationScripts["+ i +"].Type");

				listNavigationScriptsResponse_navigationScripts.Add(navigationScript);
			}
			listNavigationScriptsResponse.NavigationScripts = listNavigationScriptsResponse_navigationScripts;
        
			return listNavigationScriptsResponse;
        }
    }
}
