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
    public class DescribeAnalysisLogsResponseUnmarshaller
    {
        public static DescribeAnalysisLogsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAnalysisLogsResponse describeAnalysisLogsResponse = new DescribeAnalysisLogsResponse();

			describeAnalysisLogsResponse.HttpResponse = context.HttpResponse;
			describeAnalysisLogsResponse.RequestId = context.StringValue("DescribeAnalysisLogs.RequestId");

			DescribeAnalysisLogsResponse.DescribeAnalysisLogs_Logs logs = new DescribeAnalysisLogsResponse.DescribeAnalysisLogs_Logs();
			logs.ProcessedRow = context.IntegerValue("DescribeAnalysisLogs.Logs.ProcessedRow");
			logs.WhereQuery = context.StringValue("DescribeAnalysisLogs.Logs.WhereQuery");
			logs.AggQuery = context.StringValue("DescribeAnalysisLogs.Logs.AggQuery");
			logs.MLimited = context.IntegerValue("DescribeAnalysisLogs.Logs.MLimited");
			logs.Terms = context.StringValue("DescribeAnalysisLogs.Logs.Terms");
			logs.Keys = context.StringValue("DescribeAnalysisLogs.Logs.Keys");
			logs.Count = context.IntegerValue("DescribeAnalysisLogs.Logs.Count");
			logs.ElapsedMilliSecond = context.IntegerValue("DescribeAnalysisLogs.Logs.ElapsedMilliSecond");
			logs.Logs = context.StringValue("DescribeAnalysisLogs.Logs.Logs");
			logs.MMarker = context.StringValue("DescribeAnalysisLogs.Logs.MMarker");
			describeAnalysisLogsResponse.Logs = logs;
        
			return describeAnalysisLogsResponse;
        }
    }
}
