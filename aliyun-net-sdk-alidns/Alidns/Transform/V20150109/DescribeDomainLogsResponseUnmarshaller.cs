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
using Aliyun.Acs.Alidns.Model.V20150109;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Alidns.Transform.V20150109
{
    public class DescribeDomainLogsResponseUnmarshaller
    {
        public static DescribeDomainLogsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainLogsResponse describeDomainLogsResponse = new DescribeDomainLogsResponse();

			describeDomainLogsResponse.HttpResponse = context.HttpResponse;
			describeDomainLogsResponse.RequestId = context.StringValue("DescribeDomainLogs.RequestId");
			describeDomainLogsResponse.TotalCount = context.LongValue("DescribeDomainLogs.TotalCount");
			describeDomainLogsResponse.PageNumber = context.LongValue("DescribeDomainLogs.PageNumber");
			describeDomainLogsResponse.PageSize = context.LongValue("DescribeDomainLogs.PageSize");

			List<DescribeDomainLogsResponse.DomainLog> domainLogs = new List<DescribeDomainLogsResponse.DomainLog>();
			for (int i = 0; i < context.Length("DescribeDomainLogs.DomainLogs.Length"); i++) {
				DescribeDomainLogsResponse.DomainLog domainLog = new DescribeDomainLogsResponse.DomainLog();
				domainLog.ActionTime = context.StringValue("DescribeDomainLogs.DomainLogs["+ i +"].ActionTime");
				domainLog.DomainName = context.StringValue("DescribeDomainLogs.DomainLogs["+ i +"].DomainName");
				domainLog.Action = context.StringValue("DescribeDomainLogs.DomainLogs["+ i +"].Action");
				domainLog.Message = context.StringValue("DescribeDomainLogs.DomainLogs["+ i +"].Message");
				domainLog.ClientIp = context.StringValue("DescribeDomainLogs.DomainLogs["+ i +"].ClientIp");

				domainLogs.Add(domainLog);
			}
			describeDomainLogsResponse.DomainLogs = domainLogs;
        
			return describeDomainLogsResponse;
        }
    }
}