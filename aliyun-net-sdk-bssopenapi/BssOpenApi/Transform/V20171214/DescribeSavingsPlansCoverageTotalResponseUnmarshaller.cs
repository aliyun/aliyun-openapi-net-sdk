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
    public class DescribeSavingsPlansCoverageTotalResponseUnmarshaller
    {
        public static DescribeSavingsPlansCoverageTotalResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSavingsPlansCoverageTotalResponse describeSavingsPlansCoverageTotalResponse = new DescribeSavingsPlansCoverageTotalResponse();

			describeSavingsPlansCoverageTotalResponse.HttpResponse = _ctx.HttpResponse;
			describeSavingsPlansCoverageTotalResponse.Code = _ctx.StringValue("DescribeSavingsPlansCoverageTotal.Code");
			describeSavingsPlansCoverageTotalResponse.Message = _ctx.StringValue("DescribeSavingsPlansCoverageTotal.Message");
			describeSavingsPlansCoverageTotalResponse.RequestId = _ctx.StringValue("DescribeSavingsPlansCoverageTotal.RequestId");
			describeSavingsPlansCoverageTotalResponse.Success = _ctx.BooleanValue("DescribeSavingsPlansCoverageTotal.Success");

			DescribeSavingsPlansCoverageTotalResponse.DescribeSavingsPlansCoverageTotal_Data data = new DescribeSavingsPlansCoverageTotalResponse.DescribeSavingsPlansCoverageTotal_Data();

			DescribeSavingsPlansCoverageTotalResponse.DescribeSavingsPlansCoverageTotal_Data.DescribeSavingsPlansCoverageTotal_TotalCoverage totalCoverage = new DescribeSavingsPlansCoverageTotalResponse.DescribeSavingsPlansCoverageTotal_Data.DescribeSavingsPlansCoverageTotal_TotalCoverage();
			totalCoverage.CoveragePercentage = _ctx.FloatValue("DescribeSavingsPlansCoverageTotal.Data.TotalCoverage.CoveragePercentage");
			totalCoverage.DeductAmount = _ctx.FloatValue("DescribeSavingsPlansCoverageTotal.Data.TotalCoverage.DeductAmount");
			data.TotalCoverage = totalCoverage;

			List<DescribeSavingsPlansCoverageTotalResponse.DescribeSavingsPlansCoverageTotal_Data.DescribeSavingsPlansCoverageTotal_Item> data_periodCoverage = new List<DescribeSavingsPlansCoverageTotalResponse.DescribeSavingsPlansCoverageTotal_Data.DescribeSavingsPlansCoverageTotal_Item>();
			for (int i = 0; i < _ctx.Length("DescribeSavingsPlansCoverageTotal.Data.PeriodCoverage.Length"); i++) {
				DescribeSavingsPlansCoverageTotalResponse.DescribeSavingsPlansCoverageTotal_Data.DescribeSavingsPlansCoverageTotal_Item item = new DescribeSavingsPlansCoverageTotalResponse.DescribeSavingsPlansCoverageTotal_Data.DescribeSavingsPlansCoverageTotal_Item();
				item.Percentage = _ctx.FloatValue("DescribeSavingsPlansCoverageTotal.Data.PeriodCoverage["+ i +"].Percentage");
				item.Period = _ctx.StringValue("DescribeSavingsPlansCoverageTotal.Data.PeriodCoverage["+ i +"].Period");

				data_periodCoverage.Add(item);
			}
			data.PeriodCoverage = data_periodCoverage;
			describeSavingsPlansCoverageTotalResponse.Data = data;
        
			return describeSavingsPlansCoverageTotalResponse;
        }
    }
}
