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
using Aliyun.Acs.pvtz.Model.V20180101;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.pvtz.Transform.V20180101
{
    public class DescribeChangeLogsResponseUnmarshaller
    {
        public static DescribeChangeLogsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeChangeLogsResponse describeChangeLogsResponse = new DescribeChangeLogsResponse();

			describeChangeLogsResponse.HttpResponse = context.HttpResponse;
			describeChangeLogsResponse.RequestId = context.StringValue("DescribeChangeLogs.RequestId");
			describeChangeLogsResponse.TotalItems = context.IntegerValue("DescribeChangeLogs.TotalItems");
			describeChangeLogsResponse.TotalPages = context.IntegerValue("DescribeChangeLogs.TotalPages");
			describeChangeLogsResponse.PageSize = context.IntegerValue("DescribeChangeLogs.PageSize");
			describeChangeLogsResponse.PageNumber = context.IntegerValue("DescribeChangeLogs.PageNumber");

			List<DescribeChangeLogsResponse.DescribeChangeLogs_ChangeLog> describeChangeLogsResponse_changeLogs = new List<DescribeChangeLogsResponse.DescribeChangeLogs_ChangeLog>();
			for (int i = 0; i < context.Length("DescribeChangeLogs.ChangeLogs.Length"); i++) {
				DescribeChangeLogsResponse.DescribeChangeLogs_ChangeLog changeLog = new DescribeChangeLogsResponse.DescribeChangeLogs_ChangeLog();
				changeLog.OperTime = context.StringValue("DescribeChangeLogs.ChangeLogs["+ i +"].OperTime");
				changeLog.OperAction = context.StringValue("DescribeChangeLogs.ChangeLogs["+ i +"].OperAction");
				changeLog.OperObject = context.StringValue("DescribeChangeLogs.ChangeLogs["+ i +"].OperObject");
				changeLog.EntityId = context.StringValue("DescribeChangeLogs.ChangeLogs["+ i +"].EntityId");
				changeLog.EntityName = context.StringValue("DescribeChangeLogs.ChangeLogs["+ i +"].EntityName");
				changeLog.OperIp = context.StringValue("DescribeChangeLogs.ChangeLogs["+ i +"].OperIp");
				changeLog.OperTimestamp = context.LongValue("DescribeChangeLogs.ChangeLogs["+ i +"].OperTimestamp");
				changeLog.Id = context.LongValue("DescribeChangeLogs.ChangeLogs["+ i +"].Id");
				changeLog.Content = context.StringValue("DescribeChangeLogs.ChangeLogs["+ i +"].Content");

				describeChangeLogsResponse_changeLogs.Add(changeLog);
			}
			describeChangeLogsResponse.ChangeLogs = describeChangeLogsResponse_changeLogs;
        
			return describeChangeLogsResponse;
        }
    }
}