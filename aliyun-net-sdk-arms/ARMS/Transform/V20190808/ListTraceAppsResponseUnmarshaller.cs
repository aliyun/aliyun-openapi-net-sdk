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
    public class ListTraceAppsResponseUnmarshaller
    {
        public static ListTraceAppsResponse Unmarshall(UnmarshallerContext context)
        {
			ListTraceAppsResponse listTraceAppsResponse = new ListTraceAppsResponse();

			listTraceAppsResponse.HttpResponse = context.HttpResponse;
			listTraceAppsResponse.RequestId = context.StringValue("ListTraceApps.RequestId");
			listTraceAppsResponse.Success = context.BooleanValue("ListTraceApps.Success");
			listTraceAppsResponse.Code = context.IntegerValue("ListTraceApps.Code");
			listTraceAppsResponse.Message = context.StringValue("ListTraceApps.Message");

			List<ListTraceAppsResponse.ListTraceApps_TraceApp> listTraceAppsResponse_traceApps = new List<ListTraceAppsResponse.ListTraceApps_TraceApp>();
			for (int i = 0; i < context.Length("ListTraceApps.TraceApps.Length"); i++) {
				ListTraceAppsResponse.ListTraceApps_TraceApp traceApp = new ListTraceAppsResponse.ListTraceApps_TraceApp();
				traceApp.AppId = context.LongValue("ListTraceApps.TraceApps["+ i +"].AppId");
				traceApp.Pid = context.StringValue("ListTraceApps.TraceApps["+ i +"].Pid");
				traceApp.AppName = context.StringValue("ListTraceApps.TraceApps["+ i +"].AppName");
				traceApp.Type = context.StringValue("ListTraceApps.TraceApps["+ i +"].Type");
				traceApp.UserId = context.StringValue("ListTraceApps.TraceApps["+ i +"].UserId");
				traceApp.CreateTime = context.LongValue("ListTraceApps.TraceApps["+ i +"].CreateTime");
				traceApp.UpdateTime = context.LongValue("ListTraceApps.TraceApps["+ i +"].UpdateTime");
				traceApp.RegionId = context.StringValue("ListTraceApps.TraceApps["+ i +"].RegionId");

				listTraceAppsResponse_traceApps.Add(traceApp);
			}
			listTraceAppsResponse.TraceApps = listTraceAppsResponse_traceApps;
        
			return listTraceAppsResponse;
        }
    }
}
