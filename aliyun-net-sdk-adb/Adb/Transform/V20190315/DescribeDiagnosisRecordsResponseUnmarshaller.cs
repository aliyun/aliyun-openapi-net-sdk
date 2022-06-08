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
using Aliyun.Acs.adb.Model.V20190315;

namespace Aliyun.Acs.adb.Transform.V20190315
{
    public class DescribeDiagnosisRecordsResponseUnmarshaller
    {
        public static DescribeDiagnosisRecordsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDiagnosisRecordsResponse describeDiagnosisRecordsResponse = new DescribeDiagnosisRecordsResponse();

			describeDiagnosisRecordsResponse.HttpResponse = _ctx.HttpResponse;
			describeDiagnosisRecordsResponse.PageNumber = _ctx.IntegerValue("DescribeDiagnosisRecords.PageNumber");
			describeDiagnosisRecordsResponse.PageSize = _ctx.IntegerValue("DescribeDiagnosisRecords.PageSize");
			describeDiagnosisRecordsResponse.TotalCount = _ctx.IntegerValue("DescribeDiagnosisRecords.TotalCount");
			describeDiagnosisRecordsResponse.RequestId = _ctx.StringValue("DescribeDiagnosisRecords.RequestId");

			List<DescribeDiagnosisRecordsResponse.DescribeDiagnosisRecords_Items> describeDiagnosisRecordsResponse_querys = new List<DescribeDiagnosisRecordsResponse.DescribeDiagnosisRecords_Items>();
			for (int i = 0; i < _ctx.Length("DescribeDiagnosisRecords.Querys.Length"); i++) {
				DescribeDiagnosisRecordsResponse.DescribeDiagnosisRecords_Items items = new DescribeDiagnosisRecordsResponse.DescribeDiagnosisRecords_Items();
				items.SQL = _ctx.StringValue("DescribeDiagnosisRecords.Querys["+ i +"].SQL");
				items.SQLTruncatedThreshold = _ctx.LongValue("DescribeDiagnosisRecords.Querys["+ i +"].SQLTruncatedThreshold");
				items.Status = _ctx.StringValue("DescribeDiagnosisRecords.Querys["+ i +"].Status");
				items.OutputDataSize = _ctx.LongValue("DescribeDiagnosisRecords.Querys["+ i +"].OutputDataSize");
				items.Cost = _ctx.LongValue("DescribeDiagnosisRecords.Querys["+ i +"].Cost");
				items.OutputRows = _ctx.LongValue("DescribeDiagnosisRecords.Querys["+ i +"].OutputRows");
				items.RcHost = _ctx.StringValue("DescribeDiagnosisRecords.Querys["+ i +"].RcHost");
				items.ScanSize = _ctx.LongValue("DescribeDiagnosisRecords.Querys["+ i +"].ScanSize");
				items.ProcessId = _ctx.StringValue("DescribeDiagnosisRecords.Querys["+ i +"].ProcessId");
				items.StartTime = _ctx.LongValue("DescribeDiagnosisRecords.Querys["+ i +"].StartTime");
				items.SQLTruncated = _ctx.BooleanValue("DescribeDiagnosisRecords.Querys["+ i +"].SQLTruncated");
				items.Database = _ctx.StringValue("DescribeDiagnosisRecords.Querys["+ i +"].Database");
				items.ScanRows = _ctx.LongValue("DescribeDiagnosisRecords.Querys["+ i +"].ScanRows");
				items.ResourceCostRank = _ctx.IntegerValue("DescribeDiagnosisRecords.Querys["+ i +"].ResourceCostRank");
				items.ClientIp = _ctx.StringValue("DescribeDiagnosisRecords.Querys["+ i +"].ClientIp");
				items.PeakMemory = _ctx.LongValue("DescribeDiagnosisRecords.Querys["+ i +"].PeakMemory");
				items.QueueTime = _ctx.LongValue("DescribeDiagnosisRecords.Querys["+ i +"].QueueTime");
				items.ResourceGroup = _ctx.StringValue("DescribeDiagnosisRecords.Querys["+ i +"].ResourceGroup");
				items.UserName = _ctx.StringValue("DescribeDiagnosisRecords.Querys["+ i +"].UserName");
				items.ExecutionTime = _ctx.LongValue("DescribeDiagnosisRecords.Querys["+ i +"].ExecutionTime");
				items.TotalPlanningTime = _ctx.LongValue("DescribeDiagnosisRecords.Querys["+ i +"].TotalPlanningTime");
				items.EtlWriteRows = _ctx.LongValue("DescribeDiagnosisRecords.Querys["+ i +"].EtlWriteRows");
				items.TotalStages = _ctx.IntegerValue("DescribeDiagnosisRecords.Querys["+ i +"].TotalStages");

				describeDiagnosisRecordsResponse_querys.Add(items);
			}
			describeDiagnosisRecordsResponse.Querys = describeDiagnosisRecordsResponse_querys;
        
			return describeDiagnosisRecordsResponse;
        }
    }
}
