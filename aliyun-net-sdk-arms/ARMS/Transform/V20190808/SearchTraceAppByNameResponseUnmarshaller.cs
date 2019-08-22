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
using Aliyun.Acs.ARMS.Model.V20190808;

namespace Aliyun.Acs.ARMS.Transform.V20190808
{
    public class SearchTraceAppByNameResponseUnmarshaller
    {
        public static SearchTraceAppByNameResponse Unmarshall(UnmarshallerContext context)
        {
			SearchTraceAppByNameResponse searchTraceAppByNameResponse = new SearchTraceAppByNameResponse();

			searchTraceAppByNameResponse.HttpResponse = context.HttpResponse;
			searchTraceAppByNameResponse.RequestId = context.StringValue("SearchTraceAppByName.RequestId");

			List<SearchTraceAppByNameResponse.SearchTraceAppByName_TraceApp> searchTraceAppByNameResponse_traceApps = new List<SearchTraceAppByNameResponse.SearchTraceAppByName_TraceApp>();
			for (int i = 0; i < context.Length("SearchTraceAppByName.TraceApps.Length"); i++) {
				SearchTraceAppByNameResponse.SearchTraceAppByName_TraceApp traceApp = new SearchTraceAppByNameResponse.SearchTraceAppByName_TraceApp();
				traceApp.AppId = context.LongValue("SearchTraceAppByName.TraceApps["+ i +"].AppId");
				traceApp.Pid = context.StringValue("SearchTraceAppByName.TraceApps["+ i +"].Pid");
				traceApp.AppName = context.StringValue("SearchTraceAppByName.TraceApps["+ i +"].AppName");
				traceApp.Type = context.StringValue("SearchTraceAppByName.TraceApps["+ i +"].Type");
				traceApp.UserId = context.StringValue("SearchTraceAppByName.TraceApps["+ i +"].UserId");
				traceApp.RegionId = context.StringValue("SearchTraceAppByName.TraceApps["+ i +"].RegionId");
				traceApp.CreateTime = context.LongValue("SearchTraceAppByName.TraceApps["+ i +"].CreateTime");
				traceApp.UpdateTime = context.LongValue("SearchTraceAppByName.TraceApps["+ i +"].UpdateTime");

				searchTraceAppByNameResponse_traceApps.Add(traceApp);
			}
			searchTraceAppByNameResponse.TraceApps = searchTraceAppByNameResponse_traceApps;
        
			return searchTraceAppByNameResponse;
        }
    }
}
