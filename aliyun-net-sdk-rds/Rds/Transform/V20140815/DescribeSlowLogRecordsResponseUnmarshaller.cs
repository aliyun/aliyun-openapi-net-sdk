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
using Aliyun.Acs.Rds.Model.V20140815;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeSlowLogRecordsResponseUnmarshaller
    {
        public static DescribeSlowLogRecordsResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeSlowLogRecordsResponse describeSlowLogRecordsResponse = new DescribeSlowLogRecordsResponse();

            describeSlowLogRecordsResponse.HttpResponse = context.HttpResponse;
            describeSlowLogRecordsResponse.RequestId = context.StringValue("DescribeSlowLogRecords.RequestId");
            describeSlowLogRecordsResponse.DBInstanceId = context.StringValue("DescribeSlowLogRecords.DBInstanceId");
            describeSlowLogRecordsResponse.Engine = context.StringValue("DescribeSlowLogRecords.Engine");
            describeSlowLogRecordsResponse.TotalRecordCount = context.IntegerValue("DescribeSlowLogRecords.TotalRecordCount");
            describeSlowLogRecordsResponse.PageNumber = context.IntegerValue("DescribeSlowLogRecords.PageNumber");
            describeSlowLogRecordsResponse.PageRecordCount = context.IntegerValue("DescribeSlowLogRecords.PageRecordCount");

            List<DescribeSlowLogRecordsResponse.DescribeSlowLogRecords_SQLSlowRecord> describeSlowLogRecordsResponse_items = new List<DescribeSlowLogRecordsResponse.DescribeSlowLogRecords_SQLSlowRecord>();
            for (int i = 0; i < context.Length("DescribeSlowLogRecords.Items.Length"); i++)
            {
                DescribeSlowLogRecordsResponse.DescribeSlowLogRecords_SQLSlowRecord sQLSlowRecord = new DescribeSlowLogRecordsResponse.DescribeSlowLogRecords_SQLSlowRecord();
                sQLSlowRecord.HostAddress = context.StringValue("DescribeSlowLogRecords.Items[" + i + "].HostAddress");
                sQLSlowRecord.DBName = context.StringValue("DescribeSlowLogRecords.Items[" + i + "].DBName");
                sQLSlowRecord.SQLText = context.StringValue("DescribeSlowLogRecords.Items[" + i + "].SQLText");
                sQLSlowRecord.QueryTimes = context.LongValue("DescribeSlowLogRecords.Items[" + i + "].QueryTimes");
                sQLSlowRecord.LockTimes = context.LongValue("DescribeSlowLogRecords.Items[" + i + "].LockTimes");
                sQLSlowRecord.ParseRowCounts = context.LongValue("DescribeSlowLogRecords.Items[" + i + "].ParseRowCounts");
                sQLSlowRecord.ReturnRowCounts = context.LongValue("DescribeSlowLogRecords.Items[" + i + "].ReturnRowCounts");
                sQLSlowRecord.ExecutionStartTime = context.StringValue("DescribeSlowLogRecords.Items[" + i + "].ExecutionStartTime");

                describeSlowLogRecordsResponse_items.Add(sQLSlowRecord);
            }
            describeSlowLogRecordsResponse.Items = describeSlowLogRecordsResponse_items;

            return describeSlowLogRecordsResponse;
        }
    }
}