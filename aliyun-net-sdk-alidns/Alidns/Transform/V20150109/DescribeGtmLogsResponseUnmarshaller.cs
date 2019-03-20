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
    public class DescribeGtmLogsResponseUnmarshaller
    {
        public static DescribeGtmLogsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeGtmLogsResponse describeGtmLogsResponse = new DescribeGtmLogsResponse();

			describeGtmLogsResponse.HttpResponse = context.HttpResponse;
			describeGtmLogsResponse.RequestId = context.StringValue("DescribeGtmLogs.RequestId");
			describeGtmLogsResponse.TotalItems = context.IntegerValue("DescribeGtmLogs.TotalItems");
			describeGtmLogsResponse.TotalPages = context.IntegerValue("DescribeGtmLogs.TotalPages");
			describeGtmLogsResponse.PageSize = context.IntegerValue("DescribeGtmLogs.PageSize");
			describeGtmLogsResponse.PageNumber = context.IntegerValue("DescribeGtmLogs.PageNumber");

			List<DescribeGtmLogsResponse.DescribeGtmLogs_Log> describeGtmLogsResponse_logs = new List<DescribeGtmLogsResponse.DescribeGtmLogs_Log>();
			for (int i = 0; i < context.Length("DescribeGtmLogs.Logs.Length"); i++) {
				DescribeGtmLogsResponse.DescribeGtmLogs_Log log = new DescribeGtmLogsResponse.DescribeGtmLogs_Log();
				log.OperTime = context.StringValue("DescribeGtmLogs.Logs["+ i +"].OperTime");
				log.OperAction = context.StringValue("DescribeGtmLogs.Logs["+ i +"].OperAction");
				log.EntityType = context.StringValue("DescribeGtmLogs.Logs["+ i +"].EntityType");
				log.EntityId = context.StringValue("DescribeGtmLogs.Logs["+ i +"].EntityId");
				log.EntityName = context.StringValue("DescribeGtmLogs.Logs["+ i +"].EntityName");
				log.OperIp = context.StringValue("DescribeGtmLogs.Logs["+ i +"].OperIp");
				log.OperTimestamp = context.LongValue("DescribeGtmLogs.Logs["+ i +"].OperTimestamp");
				log.Id = context.LongValue("DescribeGtmLogs.Logs["+ i +"].Id");
				log.Content = context.StringValue("DescribeGtmLogs.Logs["+ i +"].Content");

				describeGtmLogsResponse_logs.Add(log);
			}
			describeGtmLogsResponse.Logs = describeGtmLogsResponse_logs;
        
			return describeGtmLogsResponse;
        }
    }
}
