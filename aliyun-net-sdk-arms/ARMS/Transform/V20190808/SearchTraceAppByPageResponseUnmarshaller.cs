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
    public class SearchTraceAppByPageResponseUnmarshaller
    {
        public static SearchTraceAppByPageResponse Unmarshall(UnmarshallerContext context)
        {
			SearchTraceAppByPageResponse searchTraceAppByPageResponse = new SearchTraceAppByPageResponse();

			searchTraceAppByPageResponse.HttpResponse = context.HttpResponse;
			searchTraceAppByPageResponse.RequestId = context.StringValue("SearchTraceAppByPage.RequestId");

			SearchTraceAppByPageResponse.SearchTraceAppByPage_PageBean pageBean = new SearchTraceAppByPageResponse.SearchTraceAppByPage_PageBean();
			pageBean.TotalCount = context.IntegerValue("SearchTraceAppByPage.PageBean.TotalCount");
			pageBean.PageNumber = context.IntegerValue("SearchTraceAppByPage.PageBean.PageNumber");
			pageBean.PageSize = context.IntegerValue("SearchTraceAppByPage.PageBean.PageSize");

			List<SearchTraceAppByPageResponse.SearchTraceAppByPage_PageBean.SearchTraceAppByPage_TraceApp> pageBean_traceApps = new List<SearchTraceAppByPageResponse.SearchTraceAppByPage_PageBean.SearchTraceAppByPage_TraceApp>();
			for (int i = 0; i < context.Length("SearchTraceAppByPage.PageBean.TraceApps.Length"); i++) {
				SearchTraceAppByPageResponse.SearchTraceAppByPage_PageBean.SearchTraceAppByPage_TraceApp traceApp = new SearchTraceAppByPageResponse.SearchTraceAppByPage_PageBean.SearchTraceAppByPage_TraceApp();
				traceApp.AppId = context.LongValue("SearchTraceAppByPage.PageBean.TraceApps["+ i +"].AppId");
				traceApp.Pid = context.StringValue("SearchTraceAppByPage.PageBean.TraceApps["+ i +"].Pid");
				traceApp.AppName = context.StringValue("SearchTraceAppByPage.PageBean.TraceApps["+ i +"].AppName");
				traceApp.Type = context.StringValue("SearchTraceAppByPage.PageBean.TraceApps["+ i +"].Type");
				traceApp.UserId = context.StringValue("SearchTraceAppByPage.PageBean.TraceApps["+ i +"].UserId");
				traceApp.RegionId = context.StringValue("SearchTraceAppByPage.PageBean.TraceApps["+ i +"].RegionId");
				traceApp.CreateTime = context.LongValue("SearchTraceAppByPage.PageBean.TraceApps["+ i +"].CreateTime");
				traceApp.UpdateTime = context.LongValue("SearchTraceAppByPage.PageBean.TraceApps["+ i +"].UpdateTime");

				pageBean_traceApps.Add(traceApp);
			}
			pageBean.TraceApps = pageBean_traceApps;
			searchTraceAppByPageResponse.PageBean = pageBean;
        
			return searchTraceAppByPageResponse;
        }
    }
}
