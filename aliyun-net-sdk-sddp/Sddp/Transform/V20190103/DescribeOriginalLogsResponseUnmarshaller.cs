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
using Aliyun.Acs.Sddp.Model.V20190103;

namespace Aliyun.Acs.Sddp.Transform.V20190103
{
    public class DescribeOriginalLogsResponseUnmarshaller
    {
        public static DescribeOriginalLogsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeOriginalLogsResponse describeOriginalLogsResponse = new DescribeOriginalLogsResponse();

			describeOriginalLogsResponse.HttpResponse = context.HttpResponse;
			describeOriginalLogsResponse.RequestId = context.StringValue("DescribeOriginalLogs.RequestId");
			describeOriginalLogsResponse.PageSize = context.IntegerValue("DescribeOriginalLogs.PageSize");
			describeOriginalLogsResponse.CurrentPage = context.IntegerValue("DescribeOriginalLogs.CurrentPage");
			describeOriginalLogsResponse.TotalCount = context.IntegerValue("DescribeOriginalLogs.TotalCount");

			List<DescribeOriginalLogsResponse.DescribeOriginalLogs_Log> describeOriginalLogsResponse_items = new List<DescribeOriginalLogsResponse.DescribeOriginalLogs_Log>();
			for (int i = 0; i < context.Length("DescribeOriginalLogs.Items.Length"); i++) {
				DescribeOriginalLogsResponse.DescribeOriginalLogs_Log log = new DescribeOriginalLogsResponse.DescribeOriginalLogs_Log();

				List<DescribeOriginalLogsResponse.DescribeOriginalLogs_Log.DescribeOriginalLogs_LogContent> log_logContents = new List<DescribeOriginalLogsResponse.DescribeOriginalLogs_Log.DescribeOriginalLogs_LogContent>();
				for (int j = 0; j < context.Length("DescribeOriginalLogs.Items["+ i +"].LogContents.Length"); j++) {
					DescribeOriginalLogsResponse.DescribeOriginalLogs_Log.DescribeOriginalLogs_LogContent logContent = new DescribeOriginalLogsResponse.DescribeOriginalLogs_Log.DescribeOriginalLogs_LogContent();
					logContent.Key = context.StringValue("DescribeOriginalLogs.Items["+ i +"].LogContents["+ j +"].Key");
					logContent._Value = context.StringValue("DescribeOriginalLogs.Items["+ i +"].LogContents["+ j +"].Value");

					log_logContents.Add(logContent);
				}
				log.LogContents = log_logContents;

				describeOriginalLogsResponse_items.Add(log);
			}
			describeOriginalLogsResponse.Items = describeOriginalLogsResponse_items;
        
			return describeOriginalLogsResponse;
        }
    }
}
