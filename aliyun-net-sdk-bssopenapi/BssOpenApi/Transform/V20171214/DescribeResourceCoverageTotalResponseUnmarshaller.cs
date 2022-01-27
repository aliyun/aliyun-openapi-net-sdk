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
using Aliyun.Acs.BssOpenApi.Model.V20171214;

namespace Aliyun.Acs.BssOpenApi.Transform.V20171214
{
    public class DescribeResourceCoverageTotalResponseUnmarshaller
    {
        public static DescribeResourceCoverageTotalResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeResourceCoverageTotalResponse describeResourceCoverageTotalResponse = new DescribeResourceCoverageTotalResponse();

			describeResourceCoverageTotalResponse.HttpResponse = _ctx.HttpResponse;
			describeResourceCoverageTotalResponse.RequestId = _ctx.StringValue("DescribeResourceCoverageTotal.RequestId");
			describeResourceCoverageTotalResponse.Success = _ctx.BooleanValue("DescribeResourceCoverageTotal.Success");
			describeResourceCoverageTotalResponse.Code = _ctx.StringValue("DescribeResourceCoverageTotal.Code");
			describeResourceCoverageTotalResponse.Message = _ctx.StringValue("DescribeResourceCoverageTotal.Message");

			DescribeResourceCoverageTotalResponse.DescribeResourceCoverageTotal_Data data = new DescribeResourceCoverageTotalResponse.DescribeResourceCoverageTotal_Data();

			DescribeResourceCoverageTotalResponse.DescribeResourceCoverageTotal_Data.DescribeResourceCoverageTotal_TotalCoverage totalCoverage = new DescribeResourceCoverageTotalResponse.DescribeResourceCoverageTotal_Data.DescribeResourceCoverageTotal_TotalCoverage();
			totalCoverage.CoveragePercentage = _ctx.FloatValue("DescribeResourceCoverageTotal.Data.TotalCoverage.CoveragePercentage");
			totalCoverage.DeductQuantity = _ctx.FloatValue("DescribeResourceCoverageTotal.Data.TotalCoverage.DeductQuantity");
			totalCoverage.TotalQuantity = _ctx.FloatValue("DescribeResourceCoverageTotal.Data.TotalCoverage.TotalQuantity");
			totalCoverage.CapacityUnit = _ctx.StringValue("DescribeResourceCoverageTotal.Data.TotalCoverage.CapacityUnit");
			data.TotalCoverage = totalCoverage;

			List<DescribeResourceCoverageTotalResponse.DescribeResourceCoverageTotal_Data.DescribeResourceCoverageTotal_Item> data_periodCoverage = new List<DescribeResourceCoverageTotalResponse.DescribeResourceCoverageTotal_Data.DescribeResourceCoverageTotal_Item>();
			for (int i = 0; i < _ctx.Length("DescribeResourceCoverageTotal.Data.PeriodCoverage.Length"); i++) {
				DescribeResourceCoverageTotalResponse.DescribeResourceCoverageTotal_Data.DescribeResourceCoverageTotal_Item item = new DescribeResourceCoverageTotalResponse.DescribeResourceCoverageTotal_Data.DescribeResourceCoverageTotal_Item();
				item.Period = _ctx.StringValue("DescribeResourceCoverageTotal.Data.PeriodCoverage["+ i +"].Period");
				item.CoveragePercentage = _ctx.FloatValue("DescribeResourceCoverageTotal.Data.PeriodCoverage["+ i +"].CoveragePercentage");

				data_periodCoverage.Add(item);
			}
			data.PeriodCoverage = data_periodCoverage;
			describeResourceCoverageTotalResponse.Data = data;
        
			return describeResourceCoverageTotalResponse;
        }
    }
}
