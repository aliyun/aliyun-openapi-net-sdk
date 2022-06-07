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
    public class DescribeSQLPatternsResponseUnmarshaller
    {
        public static DescribeSQLPatternsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSQLPatternsResponse describeSQLPatternsResponse = new DescribeSQLPatternsResponse();

			describeSQLPatternsResponse.HttpResponse = _ctx.HttpResponse;
			describeSQLPatternsResponse.PageNumber = _ctx.IntegerValue("DescribeSQLPatterns.PageNumber");
			describeSQLPatternsResponse.PageSize = _ctx.IntegerValue("DescribeSQLPatterns.PageSize");
			describeSQLPatternsResponse.TotalCount = _ctx.IntegerValue("DescribeSQLPatterns.TotalCount");
			describeSQLPatternsResponse.RequestId = _ctx.StringValue("DescribeSQLPatterns.RequestId");

			List<DescribeSQLPatternsResponse.DescribeSQLPatterns_PatternDetailsItem> describeSQLPatternsResponse_patternDetails = new List<DescribeSQLPatternsResponse.DescribeSQLPatterns_PatternDetailsItem>();
			for (int i = 0; i < _ctx.Length("DescribeSQLPatterns.PatternDetails.Length"); i++) {
				DescribeSQLPatternsResponse.DescribeSQLPatterns_PatternDetailsItem patternDetailsItem = new DescribeSQLPatternsResponse.DescribeSQLPatterns_PatternDetailsItem();
				patternDetailsItem.SQLPattern = _ctx.StringValue("DescribeSQLPatterns.PatternDetails["+ i +"].SQLPattern");
				patternDetailsItem.PatternId = _ctx.StringValue("DescribeSQLPatterns.PatternDetails["+ i +"].PatternId");
				patternDetailsItem.User = _ctx.StringValue("DescribeSQLPatterns.PatternDetails["+ i +"].User");
				patternDetailsItem.AccessIp = _ctx.StringValue("DescribeSQLPatterns.PatternDetails["+ i +"].AccessIp");
				patternDetailsItem.Tables = _ctx.StringValue("DescribeSQLPatterns.PatternDetails["+ i +"].Tables");
				patternDetailsItem.PatternCreationTime = _ctx.StringValue("DescribeSQLPatterns.PatternDetails["+ i +"].PatternCreationTime");
				patternDetailsItem.AverageQueryTime = _ctx.DoubleValue("DescribeSQLPatterns.PatternDetails["+ i +"].AverageQueryTime");
				patternDetailsItem.MaxQueryTime = _ctx.LongValue("DescribeSQLPatterns.PatternDetails["+ i +"].MaxQueryTime");
				patternDetailsItem.AverageExecutionTime = _ctx.DoubleValue("DescribeSQLPatterns.PatternDetails["+ i +"].AverageExecutionTime");
				patternDetailsItem.MaxExecutionTime = _ctx.LongValue("DescribeSQLPatterns.PatternDetails["+ i +"].MaxExecutionTime");
				patternDetailsItem.AveragePeakMemory = _ctx.DoubleValue("DescribeSQLPatterns.PatternDetails["+ i +"].AveragePeakMemory");
				patternDetailsItem.MaxPeakMemory = _ctx.LongValue("DescribeSQLPatterns.PatternDetails["+ i +"].MaxPeakMemory");
				patternDetailsItem.AverageScanSize = _ctx.DoubleValue("DescribeSQLPatterns.PatternDetails["+ i +"].AverageScanSize");
				patternDetailsItem.MaxScanSize = _ctx.LongValue("DescribeSQLPatterns.PatternDetails["+ i +"].MaxScanSize");
				patternDetailsItem.QueryCount = _ctx.LongValue("DescribeSQLPatterns.PatternDetails["+ i +"].QueryCount");
				patternDetailsItem.FailedCount = _ctx.LongValue("DescribeSQLPatterns.PatternDetails["+ i +"].FailedCount");
				patternDetailsItem.Blockable = _ctx.BooleanValue("DescribeSQLPatterns.PatternDetails["+ i +"].Blockable");

				describeSQLPatternsResponse_patternDetails.Add(patternDetailsItem);
			}
			describeSQLPatternsResponse.PatternDetails = describeSQLPatternsResponse_patternDetails;
        
			return describeSQLPatternsResponse;
        }
    }
}
