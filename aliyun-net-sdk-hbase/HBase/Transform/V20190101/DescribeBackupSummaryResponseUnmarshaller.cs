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
using Aliyun.Acs.HBase.Model.V20190101;

namespace Aliyun.Acs.HBase.Transform.V20190101
{
    public class DescribeBackupSummaryResponseUnmarshaller
    {
        public static DescribeBackupSummaryResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeBackupSummaryResponse describeBackupSummaryResponse = new DescribeBackupSummaryResponse();

			describeBackupSummaryResponse.HttpResponse = context.HttpResponse;
			describeBackupSummaryResponse.RequestId = context.StringValue("DescribeBackupSummary.RequestId");

			DescribeBackupSummaryResponse.DescribeBackupSummary_Incr incr = new DescribeBackupSummaryResponse.DescribeBackupSummary_Incr();
			incr.Pos = context.StringValue("DescribeBackupSummary.Incr.Pos");
			incr.QueueLogNum = context.StringValue("DescribeBackupSummary.Incr.QueueLogNum");
			incr.Speed = context.StringValue("DescribeBackupSummary.Incr.Speed");
			incr.Status = context.StringValue("DescribeBackupSummary.Incr.Status");
			incr.RunningLogNum = context.StringValue("DescribeBackupSummary.Incr.RunningLogNum");
			incr.BackupLogSize = context.StringValue("DescribeBackupSummary.Incr.BackupLogSize");
			describeBackupSummaryResponse.Incr = incr;

			DescribeBackupSummaryResponse.DescribeBackupSummary_Full full = new DescribeBackupSummaryResponse.DescribeBackupSummary_Full();
			full.HasMore = context.StringValue("DescribeBackupSummary.Full.HasMore");
			full.RecordSize = context.StringValue("DescribeBackupSummary.Full.RecordSize");
			full.NextFullBackupDate = context.StringValue("DescribeBackupSummary.Full.NextFullBackupDate");

			List<DescribeBackupSummaryResponse.DescribeBackupSummary_Full.DescribeBackupSummary_Record> full_records = new List<DescribeBackupSummaryResponse.DescribeBackupSummary_Full.DescribeBackupSummary_Record>();
			for (int i = 0; i < context.Length("DescribeBackupSummary.Full.Records.Length"); i++) {
				DescribeBackupSummaryResponse.DescribeBackupSummary_Full.DescribeBackupSummary_Record record = new DescribeBackupSummaryResponse.DescribeBackupSummary_Full.DescribeBackupSummary_Record();
				record.RecordId = context.StringValue("DescribeBackupSummary.Full.Records["+ i +"].RecordId");
				record.FinishTime = context.StringValue("DescribeBackupSummary.Full.Records["+ i +"].FinishTime");
				record.Process = context.StringValue("DescribeBackupSummary.Full.Records["+ i +"].Process");
				record.CreateTime = context.StringValue("DescribeBackupSummary.Full.Records["+ i +"].CreateTime");
				record.DataSize = context.StringValue("DescribeBackupSummary.Full.Records["+ i +"].DataSize");
				record.Speed = context.StringValue("DescribeBackupSummary.Full.Records["+ i +"].Speed");
				record.Status = context.StringValue("DescribeBackupSummary.Full.Records["+ i +"].Status");

				full_records.Add(record);
			}
			full.Records = full_records;
			describeBackupSummaryResponse.Full = full;
        
			return describeBackupSummaryResponse;
        }
    }
}
