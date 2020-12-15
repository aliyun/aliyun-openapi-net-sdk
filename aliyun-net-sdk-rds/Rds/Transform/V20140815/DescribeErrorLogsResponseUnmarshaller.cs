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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeErrorLogsResponseUnmarshaller
    {
        public static DescribeErrorLogsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeErrorLogsResponse describeErrorLogsResponse = new DescribeErrorLogsResponse();

			describeErrorLogsResponse.HttpResponse = _ctx.HttpResponse;
			describeErrorLogsResponse.PageNumber = _ctx.IntegerValue("DescribeErrorLogs.PageNumber");
			describeErrorLogsResponse.PageRecordCount = _ctx.IntegerValue("DescribeErrorLogs.PageRecordCount");
			describeErrorLogsResponse.RequestId = _ctx.StringValue("DescribeErrorLogs.RequestId");
			describeErrorLogsResponse.TotalRecordCount = _ctx.IntegerValue("DescribeErrorLogs.TotalRecordCount");

			List<DescribeErrorLogsResponse.DescribeErrorLogs_ErrorLog> describeErrorLogsResponse_items = new List<DescribeErrorLogsResponse.DescribeErrorLogs_ErrorLog>();
			for (int i = 0; i < _ctx.Length("DescribeErrorLogs.Items.Length"); i++) {
				DescribeErrorLogsResponse.DescribeErrorLogs_ErrorLog errorLog = new DescribeErrorLogsResponse.DescribeErrorLogs_ErrorLog();
				errorLog.CreateTime = _ctx.StringValue("DescribeErrorLogs.Items["+ i +"].CreateTime");
				errorLog.ErrorInfo = _ctx.StringValue("DescribeErrorLogs.Items["+ i +"].ErrorInfo");

				describeErrorLogsResponse_items.Add(errorLog);
			}
			describeErrorLogsResponse.Items = describeErrorLogsResponse_items;
        
			return describeErrorLogsResponse;
        }
    }
}
