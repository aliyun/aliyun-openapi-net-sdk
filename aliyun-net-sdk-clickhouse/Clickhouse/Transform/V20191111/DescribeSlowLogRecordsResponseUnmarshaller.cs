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
using Aliyun.Acs.clickhouse.Model.V20191111;

namespace Aliyun.Acs.clickhouse.Transform.V20191111
{
    public class DescribeSlowLogRecordsResponseUnmarshaller
    {
        public static DescribeSlowLogRecordsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSlowLogRecordsResponse describeSlowLogRecordsResponse = new DescribeSlowLogRecordsResponse();

			describeSlowLogRecordsResponse.HttpResponse = _ctx.HttpResponse;
			describeSlowLogRecordsResponse.RequestId = _ctx.StringValue("DescribeSlowLogRecords.RequestId");

			DescribeSlowLogRecordsResponse.DescribeSlowLogRecords_SlowLogRecords slowLogRecords = new DescribeSlowLogRecordsResponse.DescribeSlowLogRecords_SlowLogRecords();
			slowLogRecords.Rows = _ctx.StringValue("DescribeSlowLogRecords.SlowLogRecords.Rows");
			slowLogRecords.RowsBeforeLimitAtLeast = _ctx.StringValue("DescribeSlowLogRecords.SlowLogRecords.RowsBeforeLimitAtLeast");

			DescribeSlowLogRecordsResponse.DescribeSlowLogRecords_SlowLogRecords.DescribeSlowLogRecords_Statistics statistics = new DescribeSlowLogRecordsResponse.DescribeSlowLogRecords_SlowLogRecords.DescribeSlowLogRecords_Statistics();
			statistics.RowsRead = _ctx.IntegerValue("DescribeSlowLogRecords.SlowLogRecords.Statistics.RowsRead");
			statistics.ElapsedTime = _ctx.FloatValue("DescribeSlowLogRecords.SlowLogRecords.Statistics.ElapsedTime");
			statistics.BytesRead = _ctx.IntegerValue("DescribeSlowLogRecords.SlowLogRecords.Statistics.BytesRead");
			slowLogRecords.Statistics = statistics;

			List<DescribeSlowLogRecordsResponse.DescribeSlowLogRecords_SlowLogRecords.DescribeSlowLogRecords_ResultSet> slowLogRecords_tableSchema = new List<DescribeSlowLogRecordsResponse.DescribeSlowLogRecords_SlowLogRecords.DescribeSlowLogRecords_ResultSet>();
			for (int i = 0; i < _ctx.Length("DescribeSlowLogRecords.SlowLogRecords.TableSchema.Length"); i++) {
				DescribeSlowLogRecordsResponse.DescribeSlowLogRecords_SlowLogRecords.DescribeSlowLogRecords_ResultSet resultSet = new DescribeSlowLogRecordsResponse.DescribeSlowLogRecords_SlowLogRecords.DescribeSlowLogRecords_ResultSet();
				resultSet.Type = _ctx.StringValue("DescribeSlowLogRecords.SlowLogRecords.TableSchema["+ i +"].Type");
				resultSet.Name = _ctx.StringValue("DescribeSlowLogRecords.SlowLogRecords.TableSchema["+ i +"].Name");

				slowLogRecords_tableSchema.Add(resultSet);
			}
			slowLogRecords.TableSchema = slowLogRecords_tableSchema;

			List<DescribeSlowLogRecordsResponse.DescribeSlowLogRecords_SlowLogRecords.DescribeSlowLogRecords_ResultSet1> slowLogRecords_data = new List<DescribeSlowLogRecordsResponse.DescribeSlowLogRecords_SlowLogRecords.DescribeSlowLogRecords_ResultSet1>();
			for (int i = 0; i < _ctx.Length("DescribeSlowLogRecords.SlowLogRecords.Data.Length"); i++) {
				DescribeSlowLogRecordsResponse.DescribeSlowLogRecords_SlowLogRecords.DescribeSlowLogRecords_ResultSet1 resultSet1 = new DescribeSlowLogRecordsResponse.DescribeSlowLogRecords_SlowLogRecords.DescribeSlowLogRecords_ResultSet1();
				resultSet1.Type = _ctx.StringValue("DescribeSlowLogRecords.SlowLogRecords.Data["+ i +"].Type");
				resultSet1.QueryStartTime = _ctx.StringValue("DescribeSlowLogRecords.SlowLogRecords.Data["+ i +"].QueryStartTime");
				resultSet1.Query = _ctx.StringValue("DescribeSlowLogRecords.SlowLogRecords.Data["+ i +"].Query");
				resultSet1.ReadRows = _ctx.StringValue("DescribeSlowLogRecords.SlowLogRecords.Data["+ i +"].ReadRows");
				resultSet1.InitialAddress = _ctx.StringValue("DescribeSlowLogRecords.SlowLogRecords.Data["+ i +"].InitialAddress");
				resultSet1.MemoryUsage = _ctx.StringValue("DescribeSlowLogRecords.SlowLogRecords.Data["+ i +"].MemoryUsage");
				resultSet1.InitialUser = _ctx.StringValue("DescribeSlowLogRecords.SlowLogRecords.Data["+ i +"].InitialUser");
				resultSet1.InitialQueryId = _ctx.StringValue("DescribeSlowLogRecords.SlowLogRecords.Data["+ i +"].InitialQueryId");
				resultSet1.ReadBytes = _ctx.StringValue("DescribeSlowLogRecords.SlowLogRecords.Data["+ i +"].ReadBytes");
				resultSet1.QueryDurationMs = _ctx.StringValue("DescribeSlowLogRecords.SlowLogRecords.Data["+ i +"].QueryDurationMs");
				resultSet1.ResultBytes = _ctx.StringValue("DescribeSlowLogRecords.SlowLogRecords.Data["+ i +"].ResultBytes");

				slowLogRecords_data.Add(resultSet1);
			}
			slowLogRecords.Data = slowLogRecords_data;
			describeSlowLogRecordsResponse.SlowLogRecords = slowLogRecords;
        
			return describeSlowLogRecordsResponse;
        }
    }
}
