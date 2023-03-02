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
using Aliyun.Acs.SWAS_OPEN.Model.V20200601;

namespace Aliyun.Acs.SWAS_OPEN.Transform.V20200601
{
    public class DescribeDatabaseSlowLogRecordsResponseUnmarshaller
    {
        public static DescribeDatabaseSlowLogRecordsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDatabaseSlowLogRecordsResponse describeDatabaseSlowLogRecordsResponse = new DescribeDatabaseSlowLogRecordsResponse();

			describeDatabaseSlowLogRecordsResponse.HttpResponse = _ctx.HttpResponse;
			describeDatabaseSlowLogRecordsResponse.RequestId = _ctx.StringValue("DescribeDatabaseSlowLogRecords.RequestId");
			describeDatabaseSlowLogRecordsResponse.PageNumber = _ctx.IntegerValue("DescribeDatabaseSlowLogRecords.PageNumber");
			describeDatabaseSlowLogRecordsResponse.PageSize = _ctx.IntegerValue("DescribeDatabaseSlowLogRecords.PageSize");
			describeDatabaseSlowLogRecordsResponse.TotalCount = _ctx.IntegerValue("DescribeDatabaseSlowLogRecords.TotalCount");
			describeDatabaseSlowLogRecordsResponse.PhysicalIORead = _ctx.LongValue("DescribeDatabaseSlowLogRecords.PhysicalIORead");
			describeDatabaseSlowLogRecordsResponse.Engine = _ctx.StringValue("DescribeDatabaseSlowLogRecords.Engine");

			List<DescribeDatabaseSlowLogRecordsResponse.DescribeDatabaseSlowLogRecords_SlowLog> describeDatabaseSlowLogRecordsResponse_slowLogs = new List<DescribeDatabaseSlowLogRecordsResponse.DescribeDatabaseSlowLogRecords_SlowLog>();
			for (int i = 0; i < _ctx.Length("DescribeDatabaseSlowLogRecords.SlowLogs.Length"); i++) {
				DescribeDatabaseSlowLogRecordsResponse.DescribeDatabaseSlowLogRecords_SlowLog slowLog = new DescribeDatabaseSlowLogRecordsResponse.DescribeDatabaseSlowLogRecords_SlowLog();
				slowLog.HostAddress = _ctx.StringValue("DescribeDatabaseSlowLogRecords.SlowLogs["+ i +"].HostAddress");
				slowLog.QueryTimes = _ctx.LongValue("DescribeDatabaseSlowLogRecords.SlowLogs["+ i +"].QueryTimes");
				slowLog.SQLText = _ctx.StringValue("DescribeDatabaseSlowLogRecords.SlowLogs["+ i +"].SQLText");
				slowLog.QueryTimeMS = _ctx.LongValue("DescribeDatabaseSlowLogRecords.SlowLogs["+ i +"].QueryTimeMS");
				slowLog.LockTimes = _ctx.LongValue("DescribeDatabaseSlowLogRecords.SlowLogs["+ i +"].LockTimes");
				slowLog.ExecutionStartTime = _ctx.StringValue("DescribeDatabaseSlowLogRecords.SlowLogs["+ i +"].ExecutionStartTime");
				slowLog.ReturnRowCounts = _ctx.LongValue("DescribeDatabaseSlowLogRecords.SlowLogs["+ i +"].ReturnRowCounts");
				slowLog.ParseRowCounts = _ctx.LongValue("DescribeDatabaseSlowLogRecords.SlowLogs["+ i +"].ParseRowCounts");
				slowLog.DBName = _ctx.StringValue("DescribeDatabaseSlowLogRecords.SlowLogs["+ i +"].DBName");

				describeDatabaseSlowLogRecordsResponse_slowLogs.Add(slowLog);
			}
			describeDatabaseSlowLogRecordsResponse.SlowLogs = describeDatabaseSlowLogRecordsResponse_slowLogs;
        
			return describeDatabaseSlowLogRecordsResponse;
        }
    }
}
