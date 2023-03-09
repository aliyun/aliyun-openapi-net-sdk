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
    public class DescribeDiagnosisMonitorPerformanceResponseUnmarshaller
    {
        public static DescribeDiagnosisMonitorPerformanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDiagnosisMonitorPerformanceResponse describeDiagnosisMonitorPerformanceResponse = new DescribeDiagnosisMonitorPerformanceResponse();

			describeDiagnosisMonitorPerformanceResponse.HttpResponse = _ctx.HttpResponse;
			describeDiagnosisMonitorPerformanceResponse.PerformancesThreshold = _ctx.IntegerValue("DescribeDiagnosisMonitorPerformance.PerformancesThreshold");
			describeDiagnosisMonitorPerformanceResponse.PerformancesTruncated = _ctx.BooleanValue("DescribeDiagnosisMonitorPerformance.PerformancesTruncated");
			describeDiagnosisMonitorPerformanceResponse.RequestId = _ctx.StringValue("DescribeDiagnosisMonitorPerformance.RequestId");

			List<DescribeDiagnosisMonitorPerformanceResponse.DescribeDiagnosisMonitorPerformance_Items> describeDiagnosisMonitorPerformanceResponse_performances = new List<DescribeDiagnosisMonitorPerformanceResponse.DescribeDiagnosisMonitorPerformance_Items>();
			for (int i = 0; i < _ctx.Length("DescribeDiagnosisMonitorPerformance.Performances.Length"); i++) {
				DescribeDiagnosisMonitorPerformanceResponse.DescribeDiagnosisMonitorPerformance_Items items = new DescribeDiagnosisMonitorPerformanceResponse.DescribeDiagnosisMonitorPerformance_Items();
				items.Status = _ctx.StringValue("DescribeDiagnosisMonitorPerformance.Performances["+ i +"].Status");
				items.ProcessId = _ctx.StringValue("DescribeDiagnosisMonitorPerformance.Performances["+ i +"].ProcessId");
				items.StartTime = _ctx.LongValue("DescribeDiagnosisMonitorPerformance.Performances["+ i +"].StartTime");
				items.Cost = _ctx.LongValue("DescribeDiagnosisMonitorPerformance.Performances["+ i +"].Cost");
				items.ScanRows = _ctx.LongValue("DescribeDiagnosisMonitorPerformance.Performances["+ i +"].ScanRows");
				items.PeakMemory = _ctx.LongValue("DescribeDiagnosisMonitorPerformance.Performances["+ i +"].PeakMemory");
				items.RcHost = _ctx.StringValue("DescribeDiagnosisMonitorPerformance.Performances["+ i +"].RcHost");
				items.ScanSize = _ctx.LongValue("DescribeDiagnosisMonitorPerformance.Performances["+ i +"].ScanSize");
				items.UserName = _ctx.StringValue("DescribeDiagnosisMonitorPerformance.Performances["+ i +"].UserName");

				describeDiagnosisMonitorPerformanceResponse_performances.Add(items);
			}
			describeDiagnosisMonitorPerformanceResponse.Performances = describeDiagnosisMonitorPerformanceResponse_performances;
        
			return describeDiagnosisMonitorPerformanceResponse;
        }
    }
}
