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
using Aliyun.Acs.cusanalytic_sc_online.Model.V20190524;

namespace Aliyun.Acs.cusanalytic_sc_online.Transform.V20190524
{
    public class GetOverviewDataResponseUnmarshaller
    {
        public static GetOverviewDataResponse Unmarshall(UnmarshallerContext context)
        {
			GetOverviewDataResponse getOverviewDataResponse = new GetOverviewDataResponse();

			getOverviewDataResponse.HttpResponse = context.HttpResponse;
			getOverviewDataResponse.StayDeepAvg = context.FloatValue("GetOverviewData.StayDeepAvg");
			getOverviewDataResponse.UvWeekGrowthPercent = context.FloatValue("GetOverviewData.UvWeekGrowthPercent");
			getOverviewDataResponse.StayDeepAvgWeekGrowthPercent = context.FloatValue("GetOverviewData.StayDeepAvgWeekGrowthPercent");
			getOverviewDataResponse.Uv = context.LongValue("GetOverviewData.Uv");
			getOverviewDataResponse.StayAvgPeriodWeekGrowthPercent = context.FloatValue("GetOverviewData.StayAvgPeriodWeekGrowthPercent");
			getOverviewDataResponse.UvEverySqm = context.FloatValue("GetOverviewData.UvEverySqm");
			getOverviewDataResponse.UvAvgWeekGrowthPercent = context.FloatValue("GetOverviewData.UvAvgWeekGrowthPercent");
			getOverviewDataResponse.StayAvgPeriod = context.FloatValue("GetOverviewData.StayAvgPeriod");
			getOverviewDataResponse.UvAvg = context.FloatValue("GetOverviewData.UvAvg");
			getOverviewDataResponse.UvEverySqmGrowthWeekPercent = context.FloatValue("GetOverviewData.UvEverySqmGrowthWeekPercent");
        
			return getOverviewDataResponse;
        }
    }
}
