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
    public class DescribePdnsOperateLogsResponseUnmarshaller
    {
        public static DescribePdnsOperateLogsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePdnsOperateLogsResponse describePdnsOperateLogsResponse = new DescribePdnsOperateLogsResponse();

			describePdnsOperateLogsResponse.HttpResponse = _ctx.HttpResponse;
			describePdnsOperateLogsResponse.TotalCount = _ctx.LongValue("DescribePdnsOperateLogs.TotalCount");
			describePdnsOperateLogsResponse.RequestId = _ctx.StringValue("DescribePdnsOperateLogs.RequestId");
			describePdnsOperateLogsResponse.PageSize = _ctx.LongValue("DescribePdnsOperateLogs.PageSize");
			describePdnsOperateLogsResponse.PageNumber = _ctx.LongValue("DescribePdnsOperateLogs.PageNumber");

			List<DescribePdnsOperateLogsResponse.DescribePdnsOperateLogs_Log> describePdnsOperateLogsResponse_logs = new List<DescribePdnsOperateLogsResponse.DescribePdnsOperateLogs_Log>();
			for (int i = 0; i < _ctx.Length("DescribePdnsOperateLogs.Logs.Length"); i++) {
				DescribePdnsOperateLogsResponse.DescribePdnsOperateLogs_Log log = new DescribePdnsOperateLogsResponse.DescribePdnsOperateLogs_Log();
				log.OperateTime = _ctx.StringValue("DescribePdnsOperateLogs.Logs["+ i +"].OperateTime");
				log.Action = _ctx.StringValue("DescribePdnsOperateLogs.Logs["+ i +"].Action");
				log.Type = _ctx.StringValue("DescribePdnsOperateLogs.Logs["+ i +"].Type");
				log.Content = _ctx.StringValue("DescribePdnsOperateLogs.Logs["+ i +"].content");

				describePdnsOperateLogsResponse_logs.Add(log);
			}
			describePdnsOperateLogsResponse.Logs = describePdnsOperateLogsResponse_logs;
        
			return describePdnsOperateLogsResponse;
        }
    }
}
