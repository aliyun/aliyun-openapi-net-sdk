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
using Aliyun.Acs.xtrace.Model.V20190808;

namespace Aliyun.Acs.xtrace.Transform.V20190808
{
    public class SearchTracesResponseUnmarshaller
    {
        public static SearchTracesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SearchTracesResponse searchTracesResponse = new SearchTracesResponse();

			searchTracesResponse.HttpResponse = _ctx.HttpResponse;
			searchTracesResponse.RequestId = _ctx.StringValue("SearchTraces.RequestId");

			SearchTracesResponse.SearchTraces_PageBean pageBean = new SearchTracesResponse.SearchTraces_PageBean();
			pageBean.TotalCount = _ctx.LongValue("SearchTraces.PageBean.TotalCount");
			pageBean.PageSize = _ctx.IntegerValue("SearchTraces.PageBean.PageSize");
			pageBean.PageNumber = _ctx.IntegerValue("SearchTraces.PageBean.PageNumber");

			List<SearchTracesResponse.SearchTraces_PageBean.SearchTraces_TraceInfo> pageBean_traceInfos = new List<SearchTracesResponse.SearchTraces_PageBean.SearchTraces_TraceInfo>();
			for (int i = 0; i < _ctx.Length("SearchTraces.PageBean.TraceInfos.Length"); i++) {
				SearchTracesResponse.SearchTraces_PageBean.SearchTraces_TraceInfo traceInfo = new SearchTracesResponse.SearchTraces_PageBean.SearchTraces_TraceInfo();
				traceInfo.TraceID = _ctx.StringValue("SearchTraces.PageBean.TraceInfos["+ i +"].TraceID");
				traceInfo.OperationName = _ctx.StringValue("SearchTraces.PageBean.TraceInfos["+ i +"].OperationName");
				traceInfo.ServiceName = _ctx.StringValue("SearchTraces.PageBean.TraceInfos["+ i +"].ServiceName");
				traceInfo.ServiceIp = _ctx.StringValue("SearchTraces.PageBean.TraceInfos["+ i +"].ServiceIp");
				traceInfo.Duration = _ctx.LongValue("SearchTraces.PageBean.TraceInfos["+ i +"].Duration");
				traceInfo.Timestamp = _ctx.LongValue("SearchTraces.PageBean.TraceInfos["+ i +"].Timestamp");

				pageBean_traceInfos.Add(traceInfo);
			}
			pageBean.TraceInfos = pageBean_traceInfos;
			searchTracesResponse.PageBean = pageBean;
        
			return searchTracesResponse;
        }
    }
}
