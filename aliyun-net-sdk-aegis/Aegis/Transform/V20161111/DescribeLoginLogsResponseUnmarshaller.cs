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
using Aliyun.Acs.aegis.Model.V20161111;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class DescribeLoginLogsResponseUnmarshaller
    {
        public static DescribeLoginLogsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLoginLogsResponse describeLoginLogsResponse = new DescribeLoginLogsResponse();

			describeLoginLogsResponse.HttpResponse = context.HttpResponse;
			describeLoginLogsResponse.RequestId = context.StringValue("DescribeLoginLogs.RequestId");
			describeLoginLogsResponse.PageSize = context.IntegerValue("DescribeLoginLogs.PageSize");
			describeLoginLogsResponse.CurrentPage = context.IntegerValue("DescribeLoginLogs.CurrentPage");
			describeLoginLogsResponse.TotalCount = context.IntegerValue("DescribeLoginLogs.TotalCount");

			List<DescribeLoginLogsResponse.DescribeLoginLogs_LogListItem> describeLoginLogsResponse_logList = new List<DescribeLoginLogsResponse.DescribeLoginLogs_LogListItem>();
			for (int i = 0; i < context.Length("DescribeLoginLogs.LogList.Length"); i++) {
				DescribeLoginLogsResponse.DescribeLoginLogs_LogListItem logListItem = new DescribeLoginLogsResponse.DescribeLoginLogs_LogListItem();
				logListItem.LoginSourceIp = context.StringValue("DescribeLoginLogs.LogList["+ i +"].LoginSourceIp");
				logListItem.InstanceName = context.StringValue("DescribeLoginLogs.LogList["+ i +"].InstanceName");
				logListItem.GroupId = context.LongValue("DescribeLoginLogs.LogList["+ i +"].GroupId");
				logListItem.Ip = context.StringValue("DescribeLoginLogs.LogList["+ i +"].Ip");
				logListItem.Type = context.StringValue("DescribeLoginLogs.LogList["+ i +"].Type");
				logListItem.UserName = context.StringValue("DescribeLoginLogs.LogList["+ i +"].UserName");
				logListItem.Uuid = context.StringValue("DescribeLoginLogs.LogList["+ i +"].Uuid");
				logListItem.Protocol = context.IntegerValue("DescribeLoginLogs.LogList["+ i +"].Protocol");
				logListItem.LoginTime = context.LongValue("DescribeLoginLogs.LogList["+ i +"].LoginTime");
				logListItem.InstanceId = context.StringValue("DescribeLoginLogs.LogList["+ i +"].InstanceId");
				logListItem.OsVersion = context.StringValue("DescribeLoginLogs.LogList["+ i +"].OsVersion");
				logListItem.ProtocolName = context.StringValue("DescribeLoginLogs.LogList["+ i +"].ProtocolName");
				logListItem.Online = context.StringValue("DescribeLoginLogs.LogList["+ i +"].Online");
				logListItem.Location = context.StringValue("DescribeLoginLogs.LogList["+ i +"].Location");
				logListItem.Id = context.LongValue("DescribeLoginLogs.LogList["+ i +"].Id");
				logListItem.Region = context.StringValue("DescribeLoginLogs.LogList["+ i +"].Region");
				logListItem.Status = context.IntegerValue("DescribeLoginLogs.LogList["+ i +"].Status");

				describeLoginLogsResponse_logList.Add(logListItem);
			}
			describeLoginLogsResponse.LogList = describeLoginLogsResponse_logList;
        
			return describeLoginLogsResponse;
        }
    }
}
