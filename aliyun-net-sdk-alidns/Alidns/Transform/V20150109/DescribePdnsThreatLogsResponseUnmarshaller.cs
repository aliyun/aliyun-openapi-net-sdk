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
using Aliyun.Acs.Alidns.Model.V20150109;

namespace Aliyun.Acs.Alidns.Transform.V20150109
{
    public class DescribePdnsThreatLogsResponseUnmarshaller
    {
        public static DescribePdnsThreatLogsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePdnsThreatLogsResponse describePdnsThreatLogsResponse = new DescribePdnsThreatLogsResponse();

			describePdnsThreatLogsResponse.HttpResponse = _ctx.HttpResponse;
			describePdnsThreatLogsResponse.TotalCount = _ctx.LongValue("DescribePdnsThreatLogs.TotalCount");
			describePdnsThreatLogsResponse.RequestId = _ctx.StringValue("DescribePdnsThreatLogs.RequestId");
			describePdnsThreatLogsResponse.PageSize = _ctx.LongValue("DescribePdnsThreatLogs.PageSize");
			describePdnsThreatLogsResponse.PageNumber = _ctx.LongValue("DescribePdnsThreatLogs.PageNumber");

			List<DescribePdnsThreatLogsResponse.DescribePdnsThreatLogs_Log> describePdnsThreatLogsResponse_logs = new List<DescribePdnsThreatLogsResponse.DescribePdnsThreatLogs_Log>();
			for (int i = 0; i < _ctx.Length("DescribePdnsThreatLogs.Logs.Length"); i++) {
				DescribePdnsThreatLogsResponse.DescribePdnsThreatLogs_Log log = new DescribePdnsThreatLogsResponse.DescribePdnsThreatLogs_Log();
				log.SubDomain = _ctx.StringValue("DescribePdnsThreatLogs.Logs["+ i +"].SubDomain");
				log.SourceIp = _ctx.StringValue("DescribePdnsThreatLogs.Logs["+ i +"].SourceIp");
				log.ThreatLevel = _ctx.StringValue("DescribePdnsThreatLogs.Logs["+ i +"].ThreatLevel");
				log.ThreatTime = _ctx.StringValue("DescribePdnsThreatLogs.Logs["+ i +"].ThreatTime");
				log.ThreatType = _ctx.StringValue("DescribePdnsThreatLogs.Logs["+ i +"].ThreatType");

				describePdnsThreatLogsResponse_logs.Add(log);
			}
			describePdnsThreatLogsResponse.Logs = describePdnsThreatLogsResponse_logs;
        
			return describePdnsThreatLogsResponse;
        }
    }
}
