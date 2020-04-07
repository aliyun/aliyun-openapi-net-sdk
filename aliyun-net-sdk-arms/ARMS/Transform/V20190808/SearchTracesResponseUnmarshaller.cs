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
    public class SearchTracesResponseUnmarshaller
    {
        public static SearchTracesResponse Unmarshall(UnmarshallerContext context)
        {
			SearchTracesResponse searchTracesResponse = new SearchTracesResponse();

			searchTracesResponse.HttpResponse = context.HttpResponse;
			searchTracesResponse.RequestId = context.StringValue("SearchTraces.RequestId");

			List<SearchTracesResponse.SearchTraces_TraceInfo> searchTracesResponse_traceInfos = new List<SearchTracesResponse.SearchTraces_TraceInfo>();
			for (int i = 0; i < context.Length("SearchTraces.TraceInfos.Length"); i++) {
				SearchTracesResponse.SearchTraces_TraceInfo traceInfo = new SearchTracesResponse.SearchTraces_TraceInfo();
				traceInfo.TraceID = context.StringValue("SearchTraces.TraceInfos["+ i +"].TraceID");
				traceInfo.OperationName = context.StringValue("SearchTraces.TraceInfos["+ i +"].OperationName");
				traceInfo.ServiceName = context.StringValue("SearchTraces.TraceInfos["+ i +"].ServiceName");
				traceInfo.ServiceIp = context.StringValue("SearchTraces.TraceInfos["+ i +"].ServiceIp");
				traceInfo.Duration = context.LongValue("SearchTraces.TraceInfos["+ i +"].Duration");
				traceInfo.Timestamp = context.LongValue("SearchTraces.TraceInfos["+ i +"].Timestamp");

				searchTracesResponse_traceInfos.Add(traceInfo);
			}
			searchTracesResponse.TraceInfos = searchTracesResponse_traceInfos;
        
			return searchTracesResponse;
        }
    }
}
