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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Push.Model.V20160801;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Push.Transform.V20160801
{
    public class ListTinyAppsResponseUnmarshaller
    {
        public static ListTinyAppsResponse Unmarshall(UnmarshallerContext context)
        {
			ListTinyAppsResponse listTinyAppsResponse = new ListTinyAppsResponse();

			listTinyAppsResponse.HttpResponse = context.HttpResponse;
			listTinyAppsResponse.RequestId = context.StringValue("ListTinyApps.RequestId");

			List<ListTinyAppsResponse.TinyAppInfo> tinyAppInfos = new List<ListTinyAppsResponse.TinyAppInfo>();
			for (int i = 0; i < context.Length("ListTinyApps.TinyAppInfos.Length"); i++) {
				ListTinyAppsResponse.TinyAppInfo tinyAppInfo = new ListTinyAppsResponse.TinyAppInfo();
				tinyAppInfo.AppName = context.StringValue("ListTinyApps.TinyAppInfos["+ i +"].AppName");
				tinyAppInfo.Platform = context.StringValue("ListTinyApps.TinyAppInfos["+ i +"].Platform");
				tinyAppInfo.AppKey = context.LongValue("ListTinyApps.TinyAppInfos["+ i +"].AppKey");

				tinyAppInfos.Add(tinyAppInfo);
			}
			listTinyAppsResponse.TinyAppInfos = tinyAppInfos;
        
			return listTinyAppsResponse;
        }
    }
}