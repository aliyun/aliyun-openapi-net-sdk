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
    public class DescribeDnsGtmLogsResponseUnmarshaller
    {
        public static DescribeDnsGtmLogsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDnsGtmLogsResponse describeDnsGtmLogsResponse = new DescribeDnsGtmLogsResponse();

			describeDnsGtmLogsResponse.HttpResponse = _ctx.HttpResponse;
			describeDnsGtmLogsResponse.RequestId = _ctx.StringValue("DescribeDnsGtmLogs.RequestId");
			describeDnsGtmLogsResponse.TotalItems = _ctx.IntegerValue("DescribeDnsGtmLogs.TotalItems");
			describeDnsGtmLogsResponse.TotalPages = _ctx.IntegerValue("DescribeDnsGtmLogs.TotalPages");
			describeDnsGtmLogsResponse.PageSize = _ctx.IntegerValue("DescribeDnsGtmLogs.PageSize");
			describeDnsGtmLogsResponse.PageNumber = _ctx.IntegerValue("DescribeDnsGtmLogs.PageNumber");

			List<DescribeDnsGtmLogsResponse.DescribeDnsGtmLogs_Log> describeDnsGtmLogsResponse_logs = new List<DescribeDnsGtmLogsResponse.DescribeDnsGtmLogs_Log>();
			for (int i = 0; i < _ctx.Length("DescribeDnsGtmLogs.Logs.Length"); i++) {
				DescribeDnsGtmLogsResponse.DescribeDnsGtmLogs_Log log = new DescribeDnsGtmLogsResponse.DescribeDnsGtmLogs_Log();
				log.OperTime = _ctx.StringValue("DescribeDnsGtmLogs.Logs["+ i +"].OperTime");
				log.OperAction = _ctx.StringValue("DescribeDnsGtmLogs.Logs["+ i +"].OperAction");
				log.EntityType = _ctx.StringValue("DescribeDnsGtmLogs.Logs["+ i +"].EntityType");
				log.EntityId = _ctx.StringValue("DescribeDnsGtmLogs.Logs["+ i +"].EntityId");
				log.EntityName = _ctx.StringValue("DescribeDnsGtmLogs.Logs["+ i +"].EntityName");
				log.OperTimestamp = _ctx.LongValue("DescribeDnsGtmLogs.Logs["+ i +"].OperTimestamp");
				log.Id = _ctx.LongValue("DescribeDnsGtmLogs.Logs["+ i +"].Id");
				log.Content = _ctx.StringValue("DescribeDnsGtmLogs.Logs["+ i +"].Content");

				describeDnsGtmLogsResponse_logs.Add(log);
			}
			describeDnsGtmLogsResponse.Logs = describeDnsGtmLogsResponse_logs;
        
			return describeDnsGtmLogsResponse;
        }
    }
}
