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
using Aliyun.Acs.reid.Model.V20190928;

namespace Aliyun.Acs.reid.Transform.V20190928
{
    public class DescribeOverviewDataResponseUnmarshaller
    {
        public static DescribeOverviewDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeOverviewDataResponse describeOverviewDataResponse = new DescribeOverviewDataResponse();

			describeOverviewDataResponse.HttpResponse = context.HttpResponse;
			describeOverviewDataResponse.ErrorCode = context.StringValue("DescribeOverviewData.ErrorCode");
			describeOverviewDataResponse.ErrorMessage = context.StringValue("DescribeOverviewData.ErrorMessage");
			describeOverviewDataResponse.Message = context.StringValue("DescribeOverviewData.Message");
			describeOverviewDataResponse.Code = context.StringValue("DescribeOverviewData.Code");
			describeOverviewDataResponse.DynamicCode = context.StringValue("DescribeOverviewData.DynamicCode");
			describeOverviewDataResponse.RequestId = context.StringValue("DescribeOverviewData.RequestId");
			describeOverviewDataResponse.Success = context.BooleanValue("DescribeOverviewData.Success");
			describeOverviewDataResponse.DynamicMessage = context.StringValue("DescribeOverviewData.DynamicMessage");

			DescribeOverviewDataResponse.DescribeOverviewData_OverviewDetail overviewDetail = new DescribeOverviewDataResponse.DescribeOverviewData_OverviewDetail();
			overviewDetail.StayDeepAvgWOWPercent = context.FloatValue("DescribeOverviewData.OverviewDetail.StayDeepAvgWOWPercent");
			overviewDetail.StayDeepAvg = context.FloatValue("DescribeOverviewData.OverviewDetail.StayDeepAvg");
			overviewDetail.UvAvgWOWPercent = context.FloatValue("DescribeOverviewData.OverviewDetail.UvAvgWOWPercent");
			overviewDetail.StayAvgPeriodWOWPercent = context.FloatValue("DescribeOverviewData.OverviewDetail.StayAvgPeriodWOWPercent");
			overviewDetail.UvEverySqmGrowthWOWPercent = context.FloatValue("DescribeOverviewData.OverviewDetail.UvEverySqmGrowthWOWPercent");
			overviewDetail.UvWOWPercent = context.FloatValue("DescribeOverviewData.OverviewDetail.UvWOWPercent");
			overviewDetail.Uv = context.LongValue("DescribeOverviewData.OverviewDetail.Uv");
			overviewDetail.UvEverySqm = context.FloatValue("DescribeOverviewData.OverviewDetail.UvEverySqm");
			overviewDetail.UvAvg = context.FloatValue("DescribeOverviewData.OverviewDetail.UvAvg");
			overviewDetail.StayAvgPeriod = context.FloatValue("DescribeOverviewData.OverviewDetail.StayAvgPeriod");
			describeOverviewDataResponse.OverviewDetail = overviewDetail;

			DescribeOverviewDataResponse.DescribeOverviewData_AccurateOverviewDetail accurateOverviewDetail = new DescribeOverviewDataResponse.DescribeOverviewData_AccurateOverviewDetail();
			accurateOverviewDetail.StayDeepAvgWOWPercent = context.StringValue("DescribeOverviewData.AccurateOverviewDetail.StayDeepAvgWOWPercent");
			accurateOverviewDetail.StayDeepAvg = context.StringValue("DescribeOverviewData.AccurateOverviewDetail.StayDeepAvg");
			accurateOverviewDetail.UvAvgWOWPercent = context.StringValue("DescribeOverviewData.AccurateOverviewDetail.UvAvgWOWPercent");
			accurateOverviewDetail.StayAvgPeriodWOWPercent = context.StringValue("DescribeOverviewData.AccurateOverviewDetail.StayAvgPeriodWOWPercent");
			accurateOverviewDetail.UvWOWPercent = context.StringValue("DescribeOverviewData.AccurateOverviewDetail.UvWOWPercent");
			accurateOverviewDetail.UvEverySqmGrowthWOWPercent = context.StringValue("DescribeOverviewData.AccurateOverviewDetail.UvEverySqmGrowthWOWPercent");
			accurateOverviewDetail.Uv = context.LongValue("DescribeOverviewData.AccurateOverviewDetail.Uv");
			accurateOverviewDetail.UvEverySqm = context.StringValue("DescribeOverviewData.AccurateOverviewDetail.UvEverySqm");
			accurateOverviewDetail.UvAvg = context.StringValue("DescribeOverviewData.AccurateOverviewDetail.UvAvg");
			accurateOverviewDetail.StayAvgPeriod = context.StringValue("DescribeOverviewData.AccurateOverviewDetail.StayAvgPeriod");
			describeOverviewDataResponse.AccurateOverviewDetail = accurateOverviewDetail;
        
			return describeOverviewDataResponse;
        }
    }
}
